<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ToolboxButton = New System.Windows.Forms.Button()
        Me.OfflineMessageLink = New System.Windows.Forms.LinkLabel()
        Me.ReloadLink = New System.Windows.Forms.LinkLabel()
        Me.GetWVLink = New System.Windows.Forms.LinkLabel()
        Me.PinsButton = New System.Windows.Forms.Button()
        Me.NoWVCloseButton = New System.Windows.Forms.Button()
        Me.ContentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutVisCordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FixTitle = New System.Windows.Forms.Timer(Me.components)
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.VisCordPic = New System.Windows.Forms.PictureBox()
        Me.OfflinePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OfflineLabel = New System.Windows.Forms.Label()
        Me.IconPictureBox = New System.Windows.Forms.PictureBox()
        Me.InternetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TipPic = New System.Windows.Forms.PictureBox()
        Me.NoWVPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.NoWVLabel = New System.Windows.Forms.Label()
        Me.NoVWPic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TipLabel = New System.Windows.Forms.Label()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Updater = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.UDLabel = New System.Windows.Forms.Label()
        Me.SysTrayMenu.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.VisCordPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfflinePanel.SuspendLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoWVPanel.SuspendLayout()
        CType(Me.NoVWPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Enabled = False
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.VisCord.My.Resources.Resources.WinBack
        Me.BackButton.Location = New System.Drawing.Point(1, 1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(28, 28)
        Me.BackButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.Enabled = False
        Me.ForwardButton.FlatAppearance.BorderSize = 0
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForwardButton.Image = Global.VisCord.My.Resources.Resources.WinForward
        Me.ForwardButton.Location = New System.Drawing.Point(29, 1)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(28, 28)
        Me.ForwardButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpButton.FlatAppearance.BorderSize = 0
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpButton.Image = Global.VisCord.My.Resources.Resources.WinHelp
        Me.HelpButton.Location = New System.Drawing.Point(1236, 0)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(28, 28)
        Me.HelpButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.HelpButton, "Help")
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ToolboxButton
        '
        Me.ToolboxButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolboxButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ToolboxButton.FlatAppearance.BorderSize = 0
        Me.ToolboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolboxButton.Image = Global.VisCord.My.Resources.Resources.WinAccount
        Me.ToolboxButton.Location = New System.Drawing.Point(1208, 0)
        Me.ToolboxButton.Name = "ToolboxButton"
        Me.ToolboxButton.Size = New System.Drawing.Size(28, 28)
        Me.ToolboxButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ToolboxButton, "VisCord Settings")
        Me.ToolboxButton.UseVisualStyleBackColor = False
        '
        'OfflineMessageLink
        '
        Me.OfflineMessageLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.OfflineMessageLink.AutoSize = True
        Me.OfflineMessageLink.BackColor = System.Drawing.Color.Transparent
        Me.OfflineMessageLink.LinkColor = System.Drawing.Color.White
        Me.OfflineMessageLink.Location = New System.Drawing.Point(31, 287)
        Me.OfflineMessageLink.Name = "OfflineMessageLink"
        Me.OfflineMessageLink.Size = New System.Drawing.Size(141, 13)
        Me.OfflineMessageLink.TabIndex = 30
        Me.OfflineMessageLink.TabStop = True
        Me.OfflineMessageLink.Text = "Send a message (offline)..."
        Me.ToolTip1.SetToolTip(Me.OfflineMessageLink, "Send a message offline." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When you go back online, you can send the messages" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to" &
        " anyone you desire.")
        '
        'ReloadLink
        '
        Me.ReloadLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.ReloadLink.AutoSize = True
        Me.ReloadLink.BackColor = System.Drawing.Color.Transparent
        Me.ReloadLink.Enabled = False
        Me.ReloadLink.LinkColor = System.Drawing.Color.White
        Me.ReloadLink.Location = New System.Drawing.Point(178, 287)
        Me.ReloadLink.Name = "ReloadLink"
        Me.ReloadLink.Size = New System.Drawing.Size(104, 13)
        Me.ReloadLink.TabIndex = 31
        Me.ReloadLink.TabStop = True
        Me.ReloadLink.Text = "Try loading again..."
        Me.ToolTip1.SetToolTip(Me.ReloadLink, "Discord is down or there is no connection available." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here to try loading" &
        " Discord again.")
        '
        'GetWVLink
        '
        Me.GetWVLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.GetWVLink.AutoSize = True
        Me.GetWVLink.BackColor = System.Drawing.Color.Transparent
        Me.GetWVLink.LinkColor = System.Drawing.Color.White
        Me.GetWVLink.Location = New System.Drawing.Point(74, 286)
        Me.GetWVLink.Name = "GetWVLink"
        Me.GetWVLink.Size = New System.Drawing.Size(165, 13)
        Me.GetWVLink.TabIndex = 20
        Me.GetWVLink.TabStop = True
        Me.GetWVLink.Text = "Download WebView2 Runtime"
        Me.ToolTip1.SetToolTip(Me.GetWVLink, "Open the download page for WebView2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WebView2 is required for VisCord to load " &
        "the Discord interface.")
        '
        'PinsButton
        '
        Me.PinsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PinsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PinsButton.FlatAppearance.BorderSize = 0
        Me.PinsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PinsButton.Image = Global.VisCord.My.Resources.Resources.Pins
        Me.PinsButton.Location = New System.Drawing.Point(1180, 0)
        Me.PinsButton.Name = "PinsButton"
        Me.PinsButton.Size = New System.Drawing.Size(28, 28)
        Me.PinsButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.PinsButton, "Pinned Friends")
        Me.PinsButton.UseVisualStyleBackColor = False
        Me.PinsButton.Visible = False
        '
        'NoWVCloseButton
        '
        Me.NoWVCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoWVCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.NoWVCloseButton.FlatAppearance.BorderSize = 0
        Me.NoWVCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoWVCloseButton.Image = Global.VisCord.My.Resources.Resources.WinClose
        Me.NoWVCloseButton.Location = New System.Drawing.Point(284, 0)
        Me.NoWVCloseButton.Name = "NoWVCloseButton"
        Me.NoWVCloseButton.Size = New System.Drawing.Size(28, 28)
        Me.NoWVCloseButton.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.NoWVCloseButton, "Close")
        Me.NoWVCloseButton.UseVisualStyleBackColor = False
        '
        'ContentTimer
        '
        Me.ContentTimer.Enabled = True
        Me.ContentTimer.Interval = 10
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.ContextMenuStrip = Me.SysTrayMenu
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        Me.SysTrayIcon.Text = "VisCord"
        Me.SysTrayIcon.Visible = True
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ToolStripSeparator1, Me.SettingsToolStripMenuItem, Me.AboutVisCordToolStripMenuItem, Me.ToolStripSeparator2, Me.LogOffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SysTrayMenu.Name = "SysTrayMenu"
        Me.SysTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SysTrayMenu.Size = New System.Drawing.Size(170, 176)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinRefresh
        Me.RestoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinAccount
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.SettingsToolStripMenuItem.Text = "Settings..."
        '
        'AboutVisCordToolStripMenuItem
        '
        Me.AboutVisCordToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinMore
        Me.AboutVisCordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutVisCordToolStripMenuItem.Name = "AboutVisCordToolStripMenuItem"
        Me.AboutVisCordToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.AboutVisCordToolStripMenuItem.Text = "About VisCord..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(166, 6)
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinForward
        Me.LogOffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.LogOffToolStripMenuItem.Text = "Log off"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinClose
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifTimer
        '
        Me.NotifTimer.Enabled = True
        '
        'FixTitle
        '
        Me.FixTitle.Enabled = True
        Me.FixTitle.Interval = 1000
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.Controls.Add(Me.TextBox1)
        Me.TitlePanel.Controls.Add(Me.PinsButton)
        Me.TitlePanel.Controls.Add(Me.ToolboxButton)
        Me.TitlePanel.Controls.Add(Me.HelpButton)
        Me.TitlePanel.Controls.Add(Me.AreaLabel)
        Me.TitlePanel.Controls.Add(Me.VisCordPic)
        Me.TitlePanel.Controls.Add(Me.BackButton)
        Me.TitlePanel.Controls.Add(Me.ForwardButton)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1264, 32)
        Me.TitlePanel.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(298, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Visible = False
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaLabel.ForeColor = System.Drawing.Color.White
        Me.AreaLabel.Location = New System.Drawing.Point(111, 6)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(0, 17)
        Me.AreaLabel.TabIndex = 21
        '
        'VisCordPic
        '
        Me.VisCordPic.Image = Global.VisCord.My.Resources.Resources.VisCord
        Me.VisCordPic.Location = New System.Drawing.Point(60, 6)
        Me.VisCordPic.Name = "VisCordPic"
        Me.VisCordPic.Size = New System.Drawing.Size(49, 18)
        Me.VisCordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VisCordPic.TabIndex = 20
        Me.VisCordPic.TabStop = False
        '
        'OfflinePanel
        '
        Me.OfflinePanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OfflinePanel.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.OfflinePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OfflinePanel.Controls.Add(Me.ReloadLink)
        Me.OfflinePanel.Controls.Add(Me.LinkLabel1)
        Me.OfflinePanel.Controls.Add(Me.OfflineMessageLink)
        Me.OfflinePanel.Controls.Add(Me.OfflineLabel)
        Me.OfflinePanel.Controls.Add(Me.IconPictureBox)
        Me.OfflinePanel.Location = New System.Drawing.Point(476, 183)
        Me.OfflinePanel.Name = "OfflinePanel"
        Me.OfflinePanel.Size = New System.Drawing.Size(312, 315)
        Me.OfflinePanel.TabIndex = 21
        Me.OfflinePanel.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(164, 286)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 21
        '
        'OfflineLabel
        '
        Me.OfflineLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfflineLabel.AutoSize = True
        Me.OfflineLabel.BackColor = System.Drawing.Color.Transparent
        Me.OfflineLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfflineLabel.ForeColor = System.Drawing.Color.White
        Me.OfflineLabel.Location = New System.Drawing.Point(74, 258)
        Me.OfflineLabel.Name = "OfflineLabel"
        Me.OfflineLabel.Size = New System.Drawing.Size(165, 17)
        Me.OfflineLabel.TabIndex = 1
        Me.OfflineLabel.Text = "VisCord is in offline mode."
        Me.OfflineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox
        '
        Me.IconPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox.Image = Global.VisCord.My.Resources.Resources.Discord_Big
        Me.IconPictureBox.Location = New System.Drawing.Point(81, 82)
        Me.IconPictureBox.Name = "IconPictureBox"
        Me.IconPictureBox.Size = New System.Drawing.Size(150, 150)
        Me.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox.TabIndex = 0
        Me.IconPictureBox.TabStop = False
        '
        'InternetTimer
        '
        Me.InternetTimer.Enabled = True
        Me.InternetTimer.Interval = 1000
        '
        'TipPic
        '
        Me.TipPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipPic.Image = Global.VisCord.My.Resources.Resources.SplashPone
        Me.TipPic.Location = New System.Drawing.Point(-103, 196)
        Me.TipPic.Name = "TipPic"
        Me.TipPic.Size = New System.Drawing.Size(576, 612)
        Me.TipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TipPic.TabIndex = 23
        Me.TipPic.TabStop = False
        '
        'NoWVPanel
        '
        Me.NoWVPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoWVPanel.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.NoWVPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NoWVPanel.Controls.Add(Me.NoWVCloseButton)
        Me.NoWVPanel.Controls.Add(Me.LinkLabel3)
        Me.NoWVPanel.Controls.Add(Me.GetWVLink)
        Me.NoWVPanel.Controls.Add(Me.NoWVLabel)
        Me.NoWVPanel.Controls.Add(Me.NoVWPic)
        Me.NoWVPanel.Location = New System.Drawing.Point(476, 183)
        Me.NoWVPanel.Name = "NoWVPanel"
        Me.NoWVPanel.Size = New System.Drawing.Size(312, 315)
        Me.NoWVPanel.TabIndex = 23
        Me.NoWVPanel.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(164, 286)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel3.TabIndex = 21
        '
        'NoWVLabel
        '
        Me.NoWVLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoWVLabel.AutoSize = True
        Me.NoWVLabel.BackColor = System.Drawing.Color.Transparent
        Me.NoWVLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoWVLabel.ForeColor = System.Drawing.Color.White
        Me.NoWVLabel.Location = New System.Drawing.Point(18, 258)
        Me.NoWVLabel.Name = "NoWVLabel"
        Me.NoWVLabel.Size = New System.Drawing.Size(276, 17)
        Me.NoWVLabel.TabIndex = 1
        Me.NoWVLabel.Text = "VisCord cannot find the WebView2 Runtime."
        Me.NoWVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoVWPic
        '
        Me.NoVWPic.BackColor = System.Drawing.Color.Transparent
        Me.NoVWPic.Image = Global.VisCord.My.Resources.Resources.MissingWebView
        Me.NoVWPic.Location = New System.Drawing.Point(81, 82)
        Me.NoVWPic.Name = "NoVWPic"
        Me.NoVWPic.Size = New System.Drawing.Size(150, 150)
        Me.NoVWPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoVWPic.TabIndex = 0
        Me.NoVWPic.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2500
        '
        'TipLabel
        '
        Me.TipLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipLabel.AutoSize = True
        Me.TipLabel.BackColor = System.Drawing.Color.Transparent
        Me.TipLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLabel.ForeColor = System.Drawing.Color.White
        Me.TipLabel.Location = New System.Drawing.Point(354, 655)
        Me.TipLabel.Name = "TipLabel"
        Me.TipLabel.Size = New System.Drawing.Size(533, 17)
        Me.TipLabel.TabIndex = 23
        Me.TipLabel.Text = "Tip: The VisCord Toolbox contains useful features which enhance how you use Disco" &
    "rd."
        Me.TipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(0, 0)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(1264, 681)
        Me.WebView21.Source = New System.Uri("https://discord.com/app", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 24
        Me.WebView21.Visible = False
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Updater
        '
        Me.Updater.WorkerReportsProgress = True
        Me.Updater.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 671)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1264, 10)
        Me.ProgressBar1.TabIndex = 25
        Me.ProgressBar1.Visible = False
        '
        'UDLabel
        '
        Me.UDLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UDLabel.AutoSize = True
        Me.UDLabel.ForeColor = System.Drawing.Color.White
        Me.UDLabel.Location = New System.Drawing.Point(2, 656)
        Me.UDLabel.Name = "UDLabel"
        Me.UDLabel.Size = New System.Drawing.Size(50, 13)
        Me.UDLabel.TabIndex = 26
        Me.UDLabel.Text = "UDLabel"
        Me.UDLabel.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.UDLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.OfflinePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.NoWVPanel)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.TipLabel)
        Me.Controls.Add(Me.TipPic)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Main"
        Me.Text = "VisCord"
        Me.SysTrayMenu.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.VisCordPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfflinePanel.ResumeLayout(False)
        Me.OfflinePanel.PerformLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoWVPanel.ResumeLayout(False)
        Me.NoWVPanel.PerformLayout()
        CType(Me.NoVWPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContentTimer As Timer
    Friend WithEvents SysTrayIcon As NotifyIcon
    Friend WithEvents NotifTimer As Timer
    Friend WithEvents FixTitle As Timer
    Friend WithEvents SysTrayMenu As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutVisCordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents VisCordPic As PictureBox
    Friend WithEvents AreaLabel As Label
    Friend WithEvents HelpButton As Button
    Friend WithEvents OfflinePanel As Panel
    Friend WithEvents IconPictureBox As PictureBox
    Friend WithEvents OfflineLabel As Label
    Friend WithEvents ToolboxButton As Button
    Friend WithEvents OfflineMessageLink As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents InternetTimer As Timer
    Friend WithEvents ReloadLink As LinkLabel
    Friend WithEvents TipPic As PictureBox
    Friend WithEvents NoWVPanel As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents GetWVLink As LinkLabel
    Friend WithEvents NoWVLabel As Label
    Friend WithEvents NoVWPic As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TipLabel As Label
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents PinsButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Updater As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents UDLabel As Label
    Friend WithEvents NoWVCloseButton As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
