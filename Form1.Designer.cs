
namespace Helper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbDetectInvis = new System.Windows.Forms.CheckBox();
            this.cbAmmoMagazine = new System.Windows.Forms.CheckBox();
            this.cbDTrap = new System.Windows.Forms.CheckBox();
            this.cbBlind = new System.Windows.Forms.CheckBox();
            this.cbStun = new System.Windows.Forms.CheckBox();
            this.cbBlink = new System.Windows.Forms.CheckBox();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.groupASPD = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupASPD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbDetectInvis
            // 
            this.cbDetectInvis.AutoSize = true;
            this.cbDetectInvis.Location = new System.Drawing.Point(13, 13);
            this.cbDetectInvis.Name = "cbDetectInvis";
            this.cbDetectInvis.Size = new System.Drawing.Size(99, 17);
            this.cbDetectInvis.TabIndex = 0;
            this.cbDetectInvis.Text = "Detect Invisible";
            this.cbDetectInvis.UseVisualStyleBackColor = true;
            this.cbDetectInvis.CheckedChanged += new System.EventHandler(this.cbDetectInvis_CheckedChanged);
            // 
            // cbAmmoMagazine
            // 
            this.cbAmmoMagazine.AutoSize = true;
            this.cbAmmoMagazine.Location = new System.Drawing.Point(13, 37);
            this.cbAmmoMagazine.Name = "cbAmmoMagazine";
            this.cbAmmoMagazine.Size = new System.Drawing.Size(104, 17);
            this.cbAmmoMagazine.TabIndex = 1;
            this.cbAmmoMagazine.Text = "Ammo Magazine";
            this.cbAmmoMagazine.UseVisualStyleBackColor = true;
            // 
            // cbDTrap
            // 
            this.cbDTrap.AutoSize = true;
            this.cbDTrap.Location = new System.Drawing.Point(13, 61);
            this.cbDTrap.Name = "cbDTrap";
            this.cbDTrap.Size = new System.Drawing.Size(83, 17);
            this.cbDTrap.TabIndex = 2;
            this.cbDTrap.Text = "Detect Trap";
            this.cbDTrap.UseVisualStyleBackColor = true;
            // 
            // cbBlind
            // 
            this.cbBlind.AutoSize = true;
            this.cbBlind.Location = new System.Drawing.Point(13, 85);
            this.cbBlind.Name = "cbBlind";
            this.cbBlind.Size = new System.Drawing.Size(69, 17);
            this.cbBlind.TabIndex = 3;
            this.cbBlind.Text = "Anti-Buta";
            this.cbBlind.UseVisualStyleBackColor = true;
            // 
            // cbStun
            // 
            this.cbStun.AutoSize = true;
            this.cbStun.Location = new System.Drawing.Point(13, 109);
            this.cbStun.Name = "cbStun";
            this.cbStun.Size = new System.Drawing.Size(69, 17);
            this.cbStun.TabIndex = 4;
            this.cbStun.Text = "Anti-Stun";
            this.cbStun.UseVisualStyleBackColor = true;
            // 
            // cbBlink
            // 
            this.cbBlink.AutoSize = true;
            this.cbBlink.Location = new System.Drawing.Point(359, 487);
            this.cbBlink.Name = "cbBlink";
            this.cbBlink.Size = new System.Drawing.Size(49, 17);
            this.cbBlink.TabIndex = 5;
            this.cbBlink.Text = "Blink";
            this.cbBlink.UseVisualStyleBackColor = true;
            // 
            // cbZoom
            // 
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point(13, 132);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(82, 17);
            this.cbZoom.TabIndex = 6;
            this.cbZoom.Text = "Zoom Hack";
            this.cbZoom.UseVisualStyleBackColor = true;
            this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
            // 
            // groupASPD
            // 
            this.groupASPD.Controls.Add(this.textBox2);
            this.groupASPD.Controls.Add(this.textBox1);
            this.groupASPD.Controls.Add(this.label2);
            this.groupASPD.Controls.Add(this.label1);
            this.groupASPD.Location = new System.Drawing.Point(451, 487);
            this.groupASPD.Name = "groupASPD";
            this.groupASPD.Size = new System.Drawing.Size(194, 96);
            this.groupASPD.TabIndex = 7;
            this.groupASPD.TabStop = false;
            this.groupASPD.Text = "ASPD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "63";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "128";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "3F (default 63)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "80 (default 128)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(144, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y (Pg up / Pg Dn)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X (Home / End)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupASPD);
            this.Controls.Add(this.cbZoom);
            this.Controls.Add(this.cbBlink);
            this.Controls.Add(this.cbStun);
            this.Controls.Add(this.cbBlind);
            this.Controls.Add(this.cbDTrap);
            this.Controls.Add(this.cbAmmoMagazine);
            this.Controls.Add(this.cbDetectInvis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Helper V1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupASPD.ResumeLayout(false);
            this.groupASPD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbDetectInvis;
        private System.Windows.Forms.CheckBox cbAmmoMagazine;
        private System.Windows.Forms.CheckBox cbDTrap;
        private System.Windows.Forms.CheckBox cbBlind;
        private System.Windows.Forms.CheckBox cbStun;
        private System.Windows.Forms.CheckBox cbBlink;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.GroupBox groupASPD;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

