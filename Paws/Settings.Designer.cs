namespace Paws
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.CMLabel = new System.Windows.Forms.Label();
            this.chkCM = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.chkSysTray = new System.Windows.Forms.CheckBox();
            this.StartupLabel = new System.Windows.Forms.Label();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.chkHardware = new System.Windows.Forms.CheckBox();
            this.DataButton = new System.Windows.Forms.Button();
            this.CacheButton = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.pnlAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutLink
            // 
            this.AboutLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.AboutLink.AutoSize = true;
            this.AboutLink.BackColor = System.Drawing.Color.Transparent;
            this.AboutLink.LinkColor = System.Drawing.Color.White;
            this.AboutLink.Location = new System.Drawing.Point(22, 428);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(77, 13);
            this.AboutLink.TabIndex = 33;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "About Paws...";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(25, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(139, 30);
            this.TitleLabel.TabIndex = 30;
            this.TitleLabel.Text = "Paws Settings";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced.FlatAppearance.BorderSize = 0;
            this.btnAdvanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdvanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanced.ForeColor = System.Drawing.Color.White;
            this.btnAdvanced.Location = new System.Drawing.Point(0, 125);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(127, 36);
            this.btnAdvanced.TabIndex = 28;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = false;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.Location = new System.Drawing.Point(0, 89);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(127, 36);
            this.btnGeneral.TabIndex = 27;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.AutoScroll = true;
            this.pnlGeneral.BackColor = System.Drawing.Color.Black;
            this.pnlGeneral.Controls.Add(this.CMLabel);
            this.pnlGeneral.Controls.Add(this.chkCM);
            this.pnlGeneral.Controls.Add(this.PictureBox3);
            this.pnlGeneral.Controls.Add(this.Label3);
            this.pnlGeneral.Controls.Add(this.chkSysTray);
            this.pnlGeneral.Controls.Add(this.PictureBox1);
            this.pnlGeneral.Controls.Add(this.StartupLabel);
            this.pnlGeneral.Controls.Add(this.chkStartup);
            this.pnlGeneral.Location = new System.Drawing.Point(124, 89);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(676, 361);
            this.pnlGeneral.TabIndex = 34;
            // 
            // CMLabel
            // 
            this.CMLabel.AutoSize = true;
            this.CMLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMLabel.ForeColor = System.Drawing.Color.White;
            this.CMLabel.Location = new System.Drawing.Point(52, 238);
            this.CMLabel.Name = "CMLabel";
            this.CMLabel.Size = new System.Drawing.Size(403, 17);
            this.CMLabel.TabIndex = 33;
            this.CMLabel.Text = "Clicking the close button (X) will minimise instead of exiting the app.";
            // 
            // chkCM
            // 
            this.chkCM.AutoSize = true;
            this.chkCM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCM.ForeColor = System.Drawing.Color.White;
            this.chkCM.Location = new System.Drawing.Point(55, 214);
            this.chkCM.Name = "chkCM";
            this.chkCM.Size = new System.Drawing.Size(139, 21);
            this.chkCM.TabIndex = 8;
            this.chkCM.Text = "Minimise on close";
            this.chkCM.UseVisualStyleBackColor = true;
            this.chkCM.CheckedChanged += new System.EventHandler(this.chkCM_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(52, 142);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(264, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Minimising will hide Paws in the system tray.";
            // 
            // chkSysTray
            // 
            this.chkSysTray.AutoSize = true;
            this.chkSysTray.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSysTray.ForeColor = System.Drawing.Color.White;
            this.chkSysTray.Location = new System.Drawing.Point(55, 118);
            this.chkSysTray.Name = "chkSysTray";
            this.chkSysTray.Size = new System.Drawing.Size(176, 21);
            this.chkSysTray.TabIndex = 3;
            this.chkSysTray.Text = "Minimise to system tray";
            this.chkSysTray.UseVisualStyleBackColor = true;
            this.chkSysTray.CheckedChanged += new System.EventHandler(this.chkSysTray_CheckedChanged);
            // 
            // StartupLabel
            // 
            this.StartupLabel.AutoSize = true;
            this.StartupLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartupLabel.ForeColor = System.Drawing.Color.White;
            this.StartupLabel.Location = new System.Drawing.Point(52, 55);
            this.StartupLabel.Name = "StartupLabel";
            this.StartupLabel.Size = new System.Drawing.Size(215, 17);
            this.StartupLabel.TabIndex = 8;
            this.StartupLabel.Text = "Automatically start Paws on startup.";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartup.ForeColor = System.Drawing.Color.White;
            this.chkStartup.Location = new System.Drawing.Point(55, 31);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(115, 21);
            this.chkStartup.TabIndex = 1;
            this.chkStartup.Text = "Run at startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::Paws.Properties.Resources.line;
            this.PictureBox3.Location = new System.Drawing.Point(43, 180);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(590, 10);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 17;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Paws.Properties.Resources.line;
            this.PictureBox1.Location = new System.Drawing.Point(43, 93);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(590, 10);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.AutoScroll = true;
            this.pnlAdvanced.BackColor = System.Drawing.Color.Black;
            this.pnlAdvanced.Controls.Add(this.chkHardware);
            this.pnlAdvanced.Controls.Add(this.DataButton);
            this.pnlAdvanced.Controls.Add(this.CacheButton);
            this.pnlAdvanced.Controls.Add(this.Label10);
            this.pnlAdvanced.Controls.Add(this.Label12);
            this.pnlAdvanced.Controls.Add(this.Label14);
            this.pnlAdvanced.Controls.Add(this.PictureBox7);
            this.pnlAdvanced.Location = new System.Drawing.Point(124, 89);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(676, 360);
            this.pnlAdvanced.TabIndex = 40;
            // 
            // chkHardware
            // 
            this.chkHardware.AutoSize = true;
            this.chkHardware.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHardware.ForeColor = System.Drawing.Color.White;
            this.chkHardware.Location = new System.Drawing.Point(55, 31);
            this.chkHardware.Name = "chkHardware";
            this.chkHardware.Size = new System.Drawing.Size(164, 21);
            this.chkHardware.TabIndex = 1;
            this.chkHardware.Text = "Hardware acceleration";
            this.chkHardware.UseVisualStyleBackColor = true;
            this.chkHardware.CheckedChanged += new System.EventHandler(this.chkHardware_CheckedChanged);
            // 
            // DataButton
            // 
            this.DataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.DataButton.FlatAppearance.BorderSize = 0;
            this.DataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataButton.ForeColor = System.Drawing.Color.White;
            this.DataButton.Location = new System.Drawing.Point(516, 107);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(111, 23);
            this.DataButton.TabIndex = 3;
            this.DataButton.Text = "Clear User Data";
            this.DataButton.UseVisualStyleBackColor = false;
            this.DataButton.Click += new System.EventHandler(this.DataButton_Click);
            // 
            // CacheButton
            // 
            this.CacheButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.CacheButton.FlatAppearance.BorderSize = 0;
            this.CacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CacheButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheButton.ForeColor = System.Drawing.Color.White;
            this.CacheButton.Location = new System.Drawing.Point(405, 107);
            this.CacheButton.Name = "CacheButton";
            this.CacheButton.Size = new System.Drawing.Size(105, 23);
            this.CacheButton.TabIndex = 2;
            this.CacheButton.Text = "Clear Cache";
            this.CacheButton.UseVisualStyleBackColor = false;
            this.CacheButton.Click += new System.EventHandler(this.CacheButton_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(52, 110);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(120, 17);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "Cache && user data";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(52, 133);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(483, 17);
            this.Label12.TabIndex = 27;
            this.Label12.Text = "These options will reload Paws. Useful if Paws is running slow or has other issue" +
    "s.";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(52, 53);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(398, 34);
            this.Label14.TabIndex = 19;
            this.Label14.Text = "Select whether to use your GPU or CPU to render Pawchive.\r\n(Paws will reload the " +
    "page when this option is checked/unchecked.)";
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = global::Paws.Properties.Resources.line;
            this.PictureBox7.Location = new System.Drawing.Point(43, 93);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(593, 10);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 9;
            this.PictureBox7.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutLink);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.pnlAdvanced);
            this.Controls.Add(this.pnlGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paws Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel AboutLink;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.Button btnAdvanced;
        internal System.Windows.Forms.Button btnGeneral;
        internal System.Windows.Forms.Panel pnlGeneral;
        internal System.Windows.Forms.Label CMLabel;
        internal System.Windows.Forms.CheckBox chkCM;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox chkSysTray;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label StartupLabel;
        internal System.Windows.Forms.CheckBox chkStartup;
        internal System.Windows.Forms.Panel pnlAdvanced;
        internal System.Windows.Forms.Button DataButton;
        internal System.Windows.Forms.Button CacheButton;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.PictureBox PictureBox7;
        internal System.Windows.Forms.CheckBox chkHardware;
    }
}