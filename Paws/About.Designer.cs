namespace Paws
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.buttonOK = new System.Windows.Forms.Button();
            this.linkLabelContribute = new System.Windows.Forms.LinkLabel();
            this.labelLicense = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.AppPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK.Location = new System.Drawing.Point(84, 198);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // linkLabelContribute
            // 
            this.linkLabelContribute.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.linkLabelContribute.AutoSize = true;
            this.linkLabelContribute.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelContribute.LinkColor = System.Drawing.Color.White;
            this.linkLabelContribute.Location = new System.Drawing.Point(90, 167);
            this.linkLabelContribute.Name = "linkLabelContribute";
            this.linkLabelContribute.Size = new System.Drawing.Size(63, 13);
            this.linkLabelContribute.TabIndex = 10;
            this.linkLabelContribute.TabStop = true;
            this.linkLabelContribute.Text = "Contribute";
            this.linkLabelContribute.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContribute_LinkClicked);
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.BackColor = System.Drawing.Color.Transparent;
            this.labelLicense.ForeColor = System.Drawing.Color.White;
            this.labelLicense.Location = new System.Drawing.Point(7, 100);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(228, 52);
            this.labelLicense.TabIndex = 12;
            this.labelLicense.Text = "A lightweight Pawchive client for Windows\r\nsystems using WebView2.\r\n\r\nLicensed un" +
    "der GPLv3";
            this.labelLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(74, 71);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(95, 21);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Paws 0.0.0.0";
            // 
            // AppPic
            // 
            this.AppPic.BackColor = System.Drawing.Color.Transparent;
            this.AppPic.Image = global::Paws.Properties.Resources.mplaceholder;
            this.AppPic.Location = new System.Drawing.Point(105, 10);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(32, 56);
            this.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppPic.TabIndex = 9;
            this.AppPic.TabStop = false;
            // 
            // About
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(242, 234);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.linkLabelContribute);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.AppPic);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Paws";
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.LinkLabel linkLabelContribute;
        private System.Windows.Forms.Label labelLicense;
        internal System.Windows.Forms.PictureBox AppPic;
        internal System.Windows.Forms.Label lblVersion;
    }
}