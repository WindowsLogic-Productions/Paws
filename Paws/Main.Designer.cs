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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblArt = new System.Windows.Forms.Label();
            this.linkArt = new System.Windows.Forms.LinkLabel();
            this.sysTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutVisCordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblWVWarn = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ContentTimer = new System.Windows.Forms.Timer(this.components);
            this.menuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.sysTrayMenu.SuspendLayout();
            this.menuRightClick.SuspendLayout();
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
            this.webView21.Source = new System.Uri("https://pawchive.st/", System.UriKind.Absolute);
            this.webView21.TabIndex = 25;
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView21_CoreWebView2InitializationCompleted);
            this.webView21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.webView21_MouseDown);
            // 
            // lblArt
            // 
            this.lblArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.linkArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // sysTrayMenu
            // 
            this.sysTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SettingsToolStripMenuItem,
            this.toolStripSeparator7,
            this.AboutVisCordToolStripMenuItem,
            this.ToolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.sysTrayMenu.Name = "SysTrayMenu";
            this.sysTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.sysTrayMenu.Size = new System.Drawing.Size(147, 110);
            // 
            // RestoreToolStripMenuItem
            // 
            this.RestoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
            this.RestoreToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.RestoreToolStripMenuItem.Text = "Restore";
            this.RestoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SettingsToolStripMenuItem.Text = "Settings...";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(143, 6);
            // 
            // AboutVisCordToolStripMenuItem
            // 
            this.AboutVisCordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AboutVisCordToolStripMenuItem.Name = "AboutVisCordToolStripMenuItem";
            this.AboutVisCordToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.AboutVisCordToolStripMenuItem.Text = "About Paws...";
            this.AboutVisCordToolStripMenuItem.Click += new System.EventHandler(this.AboutVisCordToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // sysTrayIcon
            // 
            this.sysTrayIcon.ContextMenuStrip = this.sysTrayMenu;
            this.sysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTrayIcon.Icon")));
            this.sysTrayIcon.Text = "Paws";
            this.sysTrayIcon.Visible = true;
            // 
            // lblWVWarn
            // 
            this.lblWVWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWVWarn.AutoSize = true;
            this.lblWVWarn.ForeColor = System.Drawing.Color.White;
            this.lblWVWarn.Location = new System.Drawing.Point(12, 659);
            this.lblWVWarn.Name = "lblWVWarn";
            this.lblWVWarn.Size = new System.Drawing.Size(352, 13);
            this.lblWVWarn.TabIndex = 28;
            this.lblWVWarn.Text = "If Pawchive does not load, then you may need to install WebView2.";
            // 
            // ContentTimer
            // 
            this.ContentTimer.Enabled = true;
            this.ContentTimer.Tick += new System.EventHandler(this.ContentTimer_Tick);
            // 
            // menuRightClick
            // 
            this.menuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInNewWindowToolStripMenuItem,
            this.toolStripSeparator6,
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.copyLinkToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem1});
            this.menuRightClick.Name = "menuRightClick";
            this.menuRightClick.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuRightClick.Size = new System.Drawing.Size(187, 220);
            this.menuRightClick.MouseLeave += new System.EventHandler(this.menuRightClick_MouseLeave);
            // 
            // openInNewWindowToolStripMenuItem
            // 
            this.openInNewWindowToolStripMenuItem.Name = "openInNewWindowToolStripMenuItem";
            this.openInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openInNewWindowToolStripMenuItem.Text = "Open in new window";
            this.openInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openInNewWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(183, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyLinkToolStripMenuItem
            // 
            this.copyLinkToolStripMenuItem.Name = "copyLinkToolStripMenuItem";
            this.copyLinkToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.copyLinkToolStripMenuItem.Text = "Copy link";
            this.copyLinkToolStripMenuItem.Click += new System.EventHandler(this.copyLinkToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.settingsToolStripMenuItem1.Text = "Settings...";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lblWVWarn);
            this.Controls.Add(this.linkArt);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.picBack);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main";
            this.Text = "Initialising... - Paws";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.sysTrayMenu.ResumeLayout(false);
            this.menuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.LinkLabel linkArt;
        internal System.Windows.Forms.ContextMenuStrip sysTrayMenu;
        internal System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutVisCordToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.NotifyIcon sysTrayIcon;
        private System.Windows.Forms.Label lblWVWarn;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Timer ContentTimer;
        private System.Windows.Forms.ContextMenuStrip menuRightClick;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem copyLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        internal Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

