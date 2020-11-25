using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Windows.Input;

namespace Helper
{
    public partial class Form1 : Form
    {
        public static int detectInvisible = 0x00A42F0F;
        public static int zoomHack = 0x0052284D;
        public static int ammoMagazine = 0x40D8;
        public static int ammoMagazineUsed = 0x40DC;
        public static int detectTrap = 0x5FA;
        public static int blindOffset = 0x60A;
        public static int stunOffset1 = 0x5FC;
        public static int stunOffset2 = 0x600;
        public static int blinkWalk = 0x26b;
        public static int blinkRun = 0x26F;
        public static int aspd80 = 0x96;
        public static int aspd3f = 0x97;
        public static int coordinateX = 0x52;
        public static int coordinateY = 0x5A;
        public static IntPtr BaseAddress = IntPtr.Zero;
        VAMemory memory = new VAMemory("RF_Online.bin");
        public static int finalAddress;
        bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
            getBaseAddress();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (isRunning) {
                this.timer1.Start();
                Thread TH = new Thread(handleKeyboard);
                TH.SetApartmentState(ApartmentState.STA);
                CheckForIllegalCrossThreadCalls = false;
                TH.Start();
                this.cbBlind.Checked = true;
                this.cbDetectInvis.Checked = true;
                this.cbDTrap.Checked = true;
                this.cbStun.Checked = true;
            
            }
            else
            {
                Application.Exit();
            }
  

        }

        void handleKeyboard()
        {
            while (isRunning)
            {
                Thread.Sleep(40);
                Int32 corX = memory.ReadInt32((IntPtr)finalAddress + coordinateX);
                Int32 corY = memory.ReadInt32((IntPtr)finalAddress + coordinateY);
                if ((Keyboard.GetKeyStates(Key.PageUp) & KeyStates.Down) > 0)
                {
                    memory.WriteInteger((IntPtr)finalAddress + coordinateX, corX+1);
                }
                
                if((Keyboard.GetKeyStates(Key.PageDown) & KeyStates.Down) > 0)
                {
                    memory.WriteInteger((IntPtr)finalAddress + coordinateX, corX - 1);
                }
                if((Keyboard.GetKeyStates(Key.Home) & KeyStates.Down) > 0)
                {
                    memory.WriteInteger((IntPtr)finalAddress + coordinateY, corY + 1);
                }
                if ((Keyboard.GetKeyStates(Key.End) & KeyStates.Down) > 0)
                {
                    memory.WriteInteger((IntPtr)finalAddress + coordinateY, corY - 1);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BaseAddress != IntPtr.Zero)
            {
                finalAddress = memory.ReadInt32((IntPtr)BaseAddress + 0x01F3B5F8);
                handleAmmoMagazine(finalAddress);
                handleDetectTrap(finalAddress);
                handleAntiBlind(finalAddress);
                handleAntiStun(finalAddress);
               // handleBlink(finalAddress);
                //handleAspd(finalAddress);
                handleCoordiante();

            }
        }

        private void handleCoordiante()
        {
            uint corX = memory.ReadUInt32((IntPtr)finalAddress + coordinateX);
            uint cory = memory.ReadUInt32((IntPtr)finalAddress + coordinateY);
            this.label5.Text = corX.ToString();
            this.label6.Text = cory.ToString();
        }

        private void handleAspd(int finalAddress)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text == "")
            {

                memory.WriteByte((IntPtr)finalAddress + aspd80, Byte.Parse(this.textBox1.Text));
                memory.WriteByte((IntPtr)finalAddress + aspd3f, 63);
            }
            else if (this.textBox1.Text != "" && this.textBox2.Text != "")
            {
                memory.WriteByte((IntPtr)finalAddress + aspd80, Byte.Parse(this.textBox1.Text));
                memory.WriteByte((IntPtr)finalAddress + aspd3f, Byte.Parse(this.textBox2.Text));
            }
            else
            {
                memory.WriteByte((IntPtr)finalAddress + aspd80, 128);
                memory.WriteByte((IntPtr)finalAddress + aspd3f, 63);
            }
        }

        private void handleBlink(int finalAddress)
        {
            if (this.cbBlink.Checked)
            {
                memory.WriteUInt32((IntPtr)finalAddress + blinkRun, 2264924271);
                memory.WriteUInt32((IntPtr)finalAddress + blinkWalk, 2264924271);
            }
            else
            {
                memory.WriteUInt32((IntPtr)finalAddress + blinkRun, 2264924226);
                memory.WriteUInt32((IntPtr)finalAddress + blinkWalk, 2264924226);
            }
        }

        private void handleAntiStun(int finalAddress)
        {
            if (this.cbStun.Checked)
            {
                memory.WriteInt32((IntPtr)finalAddress + stunOffset1, 4096);
                memory.WriteInt32((IntPtr)finalAddress + stunOffset2, 4096);
            }
        }

        private void handleAntiBlind(int finalAddress)
        {
            if (this.cbBlind.Checked)
            {
                memory.WriteInt32((IntPtr)finalAddress + blindOffset, 0);
            }
        }

        private void handleDetectTrap(int finalAddress)
        {
            if (this.cbDTrap.Checked)
            {
                memory.WriteInt32((IntPtr)finalAddress + detectTrap, 1);
            }
            else
            {
                memory.WriteInt32((IntPtr)finalAddress + detectTrap, 0);
            }
        }

        private void handleAmmoMagazine(int finalAddress)
        {
            int ammoMagazinActive = memory.ReadInt32((IntPtr)finalAddress + ammoMagazineUsed);
            if (ammoMagazinActive != 255)
            {
                this.cbAmmoMagazine.Checked = true;
                memory.WriteInt32((IntPtr)finalAddress + ammoMagazine, 1);
            }
            else
            {
                this.cbAmmoMagazine.Checked = false;
                memory.WriteInt32((IntPtr)finalAddress + ammoMagazine, 0);
            }
        }

        public void getBaseAddress()
        {
            Process[] process = Process.GetProcessesByName("RF_Online.bin");
            if (process.Length > 0)
            {
                Process MYProc = process[0];

                foreach (ProcessModule module in MYProc.Modules)
                {
                    if (module.ModuleName.Contains("RF_Online.bin"))
                    {
                        BaseAddress = module.BaseAddress;
                    }
                }
                isRunning = true;
            }
            else
            {
              Application.Exit();
            }

        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbZoom.Checked)
            {
                memory.WriteInt32((IntPtr)zoomHack, 1171851755);
            }
            else
            {
                memory.WriteInt32((IntPtr)zoomHack, 1171851642);
            }
        }

        private void cbDetectInvis_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDetectInvis.Checked)
            {
                memory.WriteInt32((IntPtr)detectInvisible, 100);
            }
            else
            {
                memory.WriteInt32((IntPtr)detectInvisible, 67);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" && this.textBox2.Text == "")
            {
                this.textBox1.Text = "128";
                this.textBox2.Text = "63";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.textBox1.Text = String.Empty;
        }

        private void textBox2_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.textBox2.Text = String.Empty;
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isRunning = false;
        }
    }
}
