namespace Paws
{
    partial class Main
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
            this.picBack = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblArt = new System.Windows.Forms.Label();
            this.linkArt = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBack.Image = global::Paws.Properties.Resources.mplaceholder;
            this.picBack.Location = new System.Drawing.Point(803, 70);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(576, 612);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 24;
            this.picBack.TabStop = false;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1264, 681);
            this.webView21.TabIndex = 25;
            this.webView21.ZoomFactor = 1D;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.ForeColor = System.Drawing.Color.White;
            this.lblArt.Location = new System.Drawing.Point(865, 631);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(37, 13);
            this.lblArt.TabIndex = 26;
            this.lblArt.Text = "Art by";
            // 
            // linkArt
            // 
            this.linkArt.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.linkArt.AutoSize = true;
            this.linkArt.LinkColor = System.Drawing.Color.White;
            this.linkArt.Location = new System.Drawing.Point(901, 631);
            this.linkArt.Name = "linkArt";
            this.linkArt.Size = new System.Drawing.Size(53, 13);
            this.linkArt.TabIndex = 27;
            this.linkArt.TabStop = true;
            this.linkArt.Text = "ruka_tou";
            this.linkArt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkArt_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.linkArt);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.webView21);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main";
            this.Text = "Paws";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picBack;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.LinkLabel linkArt;
    }
}

