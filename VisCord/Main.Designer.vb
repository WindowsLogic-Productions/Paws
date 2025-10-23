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
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StartupCheckbox = New System.Windows.Forms.CheckBox()
        Me.SysTrayCheckbox = New System.Windows.Forms.CheckBox()
        Me.BadgeCheckbox = New System.Windows.Forms.CheckBox()
        Me.NotifyCheckbox = New System.Windows.Forms.CheckBox()
        Me.CacheButton = New System.Windows.Forms.Button()
        Me.DataButton = New System.Windows.Forms.Button()
        Me.HardwareCheckbox = New System.Windows.Forms.CheckBox()
        Me.NavCheckbox = New System.Windows.Forms.CheckBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.NetworkCheckbox = New System.Windows.Forms.CheckBox()
        Me.NSFWCheckbox = New System.Windows.Forms.CheckBox()
        Me.ToolboxButton = New System.Windows.Forms.Button()
        Me.NSFWContentChecbox = New System.Windows.Forms.CheckBox()
        Me.ContentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VisCordSettings = New System.Windows.Forms.Panel()
        Me.OtherLabel = New System.Windows.Forms.Label()
        Me.IconBox = New System.Windows.Forms.GroupBox()
        Me.VeloNSFWButton = New System.Windows.Forms.RadioButton()
        Me.AleNSFWButton = New System.Windows.Forms.RadioButton()
        Me.VeloButton = New System.Windows.Forms.RadioButton()
        Me.AleButton = New System.Windows.Forms.RadioButton()
        Me.PokemonButton = New System.Windows.Forms.RadioButton()
        Me.DiscordButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CFULink = New System.Windows.Forms.LinkLabel()
        Me.AboutLink = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GeneralTitle = New System.Windows.Forms.Label()
        Me.VCSettingsTitle = New System.Windows.Forms.Label()
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutVisCordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FixTitle = New System.Windows.Forms.Timer(Me.components)
        Me.JSButton = New System.Windows.Forms.Button()
        Me.JSLabel = New System.Windows.Forms.Label()
        Me.ToolLabel = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.VisCordPic = New System.Windows.Forms.PictureBox()
        Me.OfflinePanel = New System.Windows.Forms.Panel()
        Me.OfflineLabel = New System.Windows.Forms.Label()
        Me.IconPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolPanel = New System.Windows.Forms.Panel()
        Me.ContentLabel = New System.Windows.Forms.Label()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VisCordSettings.SuspendLayout()
        Me.IconBox.SuspendLayout()
        Me.SysTrayMenu.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.VisCordPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfflinePanel.SuspendLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.Transparent
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(0, 0)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(1264, 661)
        Me.WebView21.Source = New System.Uri("https://discord.com/app", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 0
        Me.WebView21.ZoomFactor = 1.0R
        '
        'StartupCheckbox
        '
        Me.StartupCheckbox.AutoSize = True
        Me.StartupCheckbox.ForeColor = System.Drawing.Color.White
        Me.StartupCheckbox.Location = New System.Drawing.Point(13, 51)
        Me.StartupCheckbox.Name = "StartupCheckbox"
        Me.StartupCheckbox.Size = New System.Drawing.Size(100, 17)
        Me.StartupCheckbox.TabIndex = 3
        Me.StartupCheckbox.Text = "Run at startup"
        Me.ToolTip1.SetToolTip(Me.StartupCheckbox, "Automatically start VisCord on startup.")
        Me.StartupCheckbox.UseVisualStyleBackColor = True
        '
        'SysTrayCheckbox
        '
        Me.SysTrayCheckbox.AutoSize = True
        Me.SysTrayCheckbox.ForeColor = System.Drawing.Color.White
        Me.SysTrayCheckbox.Location = New System.Drawing.Point(13, 87)
        Me.SysTrayCheckbox.Name = "SysTrayCheckbox"
        Me.SysTrayCheckbox.Size = New System.Drawing.Size(145, 17)
        Me.SysTrayCheckbox.TabIndex = 4
        Me.SysTrayCheckbox.Text = "Minimise to system tray"
        Me.ToolTip1.SetToolTip(Me.SysTrayCheckbox, "Minimising will hide VisCord in the system tray.")
        Me.SysTrayCheckbox.UseVisualStyleBackColor = True
        '
        'BadgeCheckbox
        '
        Me.BadgeCheckbox.AutoSize = True
        Me.BadgeCheckbox.ForeColor = System.Drawing.Color.White
        Me.BadgeCheckbox.Location = New System.Drawing.Point(13, 110)
        Me.BadgeCheckbox.Name = "BadgeCheckbox"
        Me.BadgeCheckbox.Size = New System.Drawing.Size(154, 17)
        Me.BadgeCheckbox.TabIndex = 5
        Me.BadgeCheckbox.Text = "Show notification badge"
        Me.ToolTip1.SetToolTip(Me.BadgeCheckbox, "Show a notification badge on the system tray icon and taskbar icon.")
        Me.BadgeCheckbox.UseVisualStyleBackColor = True
        '
        'NotifyCheckbox
        '
        Me.NotifyCheckbox.AutoSize = True
        Me.NotifyCheckbox.ForeColor = System.Drawing.Color.White
        Me.NotifyCheckbox.Location = New System.Drawing.Point(13, 146)
        Me.NotifyCheckbox.Name = "NotifyCheckbox"
        Me.NotifyCheckbox.Size = New System.Drawing.Size(156, 17)
        Me.NotifyCheckbox.TabIndex = 6
        Me.NotifyCheckbox.Text = "Notify on communication"
        Me.ToolTip1.SetToolTip(Me.NotifyCheckbox, "Send a real-time notification when communication is detected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Notifications do" &
        " not work if VisCord is minimised.")
        Me.NotifyCheckbox.UseVisualStyleBackColor = True
        '
        'CacheButton
        '
        Me.CacheButton.Location = New System.Drawing.Point(13, 254)
        Me.CacheButton.Name = "CacheButton"
        Me.CacheButton.Size = New System.Drawing.Size(111, 23)
        Me.CacheButton.TabIndex = 9
        Me.CacheButton.Text = "Clear Cache"
        Me.ToolTip1.SetToolTip(Me.CacheButton, "Clears cache and reloads VisCord." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful if VisCord is running slow or lagging" &
        ".")
        Me.CacheButton.UseVisualStyleBackColor = True
        '
        'DataButton
        '
        Me.DataButton.Location = New System.Drawing.Point(13, 283)
        Me.DataButton.Name = "DataButton"
        Me.DataButton.Size = New System.Drawing.Size(111, 23)
        Me.DataButton.TabIndex = 10
        Me.DataButton.Text = "Clear User Data"
        Me.ToolTip1.SetToolTip(Me.DataButton, "Clears user data and reloads VisCord." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful if VisCord is running slow or lag" &
        "ging.")
        Me.DataButton.UseVisualStyleBackColor = True
        '
        'HardwareCheckbox
        '
        Me.HardwareCheckbox.AutoSize = True
        Me.HardwareCheckbox.ForeColor = System.Drawing.Color.White
        Me.HardwareCheckbox.Location = New System.Drawing.Point(13, 218)
        Me.HardwareCheckbox.Name = "HardwareCheckbox"
        Me.HardwareCheckbox.Size = New System.Drawing.Size(141, 17)
        Me.HardwareCheckbox.TabIndex = 8
        Me.HardwareCheckbox.Text = "Hardware acceleration"
        Me.ToolTip1.SetToolTip(Me.HardwareCheckbox, "Select whether to use your GPU or CPU to render Discord." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisCord will reload t" &
        "he page when this option is checked/unchecked.")
        Me.HardwareCheckbox.UseVisualStyleBackColor = True
        '
        'NavCheckbox
        '
        Me.NavCheckbox.AutoSize = True
        Me.NavCheckbox.ForeColor = System.Drawing.Color.White
        Me.NavCheckbox.Location = New System.Drawing.Point(13, 182)
        Me.NavCheckbox.Name = "NavCheckbox"
        Me.NavCheckbox.Size = New System.Drawing.Size(149, 17)
        Me.NavCheckbox.TabIndex = 7
        Me.NavCheckbox.Text = "Open links in a browser"
        Me.ToolTip1.SetToolTip(Me.NavCheckbox, "Open links in an external browser." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisCord has to reload when opening an exter" &
        "nal link." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If unchecked, will open links in a new WebView2 window.")
        Me.NavCheckbox.UseVisualStyleBackColor = True
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
        Me.HelpButton.Location = New System.Drawing.Point(1235, 1)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(28, 28)
        Me.HelpButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.HelpButton, "Help")
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'NetworkCheckbox
        '
        Me.NetworkCheckbox.AutoSize = True
        Me.NetworkCheckbox.ForeColor = System.Drawing.Color.White
        Me.NetworkCheckbox.Location = New System.Drawing.Point(12, 343)
        Me.NetworkCheckbox.Name = "NetworkCheckbox"
        Me.NetworkCheckbox.Size = New System.Drawing.Size(129, 17)
        Me.NetworkCheckbox.TabIndex = 15
        Me.NetworkCheckbox.Text = "Enable online mode"
        Me.ToolTip1.SetToolTip(Me.NetworkCheckbox, "Online mode connects VisCord to the Discord interface." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisCord will not load t" &
        "he Discord interface when disabled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and will show your selected icon instead.")
        Me.NetworkCheckbox.UseVisualStyleBackColor = True
        '
        'NSFWCheckbox
        '
        Me.NSFWCheckbox.AutoSize = True
        Me.NSFWCheckbox.ForeColor = System.Drawing.Color.White
        Me.NSFWCheckbox.Location = New System.Drawing.Point(13, 476)
        Me.NSFWCheckbox.Name = "NSFWCheckbox"
        Me.NSFWCheckbox.Size = New System.Drawing.Size(87, 17)
        Me.NSFWCheckbox.TabIndex = 17
        Me.NSFWCheckbox.Text = "NSFW icons"
        Me.ToolTip1.SetToolTip(Me.NSFWCheckbox, "Enable access to 18+ icons." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warning: this option contains lewd pony/furry flui" &
        "ds.")
        Me.NSFWCheckbox.UseVisualStyleBackColor = True
        '
        'ToolboxButton
        '
        Me.ToolboxButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolboxButton.FlatAppearance.BorderSize = 0
        Me.ToolboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolboxButton.Image = Global.VisCord.My.Resources.Resources.WinAccount
        Me.ToolboxButton.Location = New System.Drawing.Point(1207, 1)
        Me.ToolboxButton.Name = "ToolboxButton"
        Me.ToolboxButton.Size = New System.Drawing.Size(28, 28)
        Me.ToolboxButton.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.ToolboxButton, "VisCord Toolbox")
        Me.ToolboxButton.UseVisualStyleBackColor = True
        '
        'NSFWContentChecbox
        '
        Me.NSFWContentChecbox.AutoSize = True
        Me.NSFWContentChecbox.ForeColor = System.Drawing.Color.White
        Me.NSFWContentChecbox.Location = New System.Drawing.Point(144, 41)
        Me.NSFWContentChecbox.Name = "NSFWContentChecbox"
        Me.NSFWContentChecbox.Size = New System.Drawing.Size(210, 17)
        Me.NSFWContentChecbox.TabIndex = 16
        Me.NSFWContentChecbox.Text = "Navigate away from NSFW channels"
        Me.ToolTip1.SetToolTip(Me.NSFWContentChecbox, "When enabled, VisCord will not allow access to NSFW channels.")
        Me.NSFWContentChecbox.UseVisualStyleBackColor = True
        '
        'ContentTimer
        '
        Me.ContentTimer.Enabled = True
        Me.ContentTimer.Interval = 10
        '
        'VisCordSettings
        '
        Me.VisCordSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisCordSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.VisCordSettings.Controls.Add(Me.OtherLabel)
        Me.VisCordSettings.Controls.Add(Me.NSFWCheckbox)
        Me.VisCordSettings.Controls.Add(Me.IconBox)
        Me.VisCordSettings.Controls.Add(Me.NetworkCheckbox)
        Me.VisCordSettings.Controls.Add(Me.Label6)
        Me.VisCordSettings.Controls.Add(Me.CFULink)
        Me.VisCordSettings.Controls.Add(Me.AboutLink)
        Me.VisCordSettings.Controls.Add(Me.NavCheckbox)
        Me.VisCordSettings.Controls.Add(Me.Label5)
        Me.VisCordSettings.Controls.Add(Me.Label4)
        Me.VisCordSettings.Controls.Add(Me.HardwareCheckbox)
        Me.VisCordSettings.Controls.Add(Me.DataButton)
        Me.VisCordSettings.Controls.Add(Me.CacheButton)
        Me.VisCordSettings.Controls.Add(Me.Label3)
        Me.VisCordSettings.Controls.Add(Me.NotifyCheckbox)
        Me.VisCordSettings.Controls.Add(Me.BadgeCheckbox)
        Me.VisCordSettings.Controls.Add(Me.Label2)
        Me.VisCordSettings.Controls.Add(Me.Label1)
        Me.VisCordSettings.Controls.Add(Me.GeneralTitle)
        Me.VisCordSettings.Controls.Add(Me.SysTrayCheckbox)
        Me.VisCordSettings.Controls.Add(Me.StartupCheckbox)
        Me.VisCordSettings.Controls.Add(Me.VCSettingsTitle)
        Me.VisCordSettings.Location = New System.Drawing.Point(1068, 130)
        Me.VisCordSettings.Name = "VisCordSettings"
        Me.VisCordSettings.Size = New System.Drawing.Size(182, 519)
        Me.VisCordSettings.TabIndex = 2
        Me.VisCordSettings.Visible = False
        '
        'OtherLabel
        '
        Me.OtherLabel.AutoSize = True
        Me.OtherLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherLabel.ForeColor = System.Drawing.Color.White
        Me.OtherLabel.Location = New System.Drawing.Point(10, 363)
        Me.OtherLabel.Name = "OtherLabel"
        Me.OtherLabel.Size = New System.Drawing.Size(37, 13)
        Me.OtherLabel.TabIndex = 18
        Me.OtherLabel.Text = "Other"
        '
        'IconBox
        '
        Me.IconBox.Controls.Add(Me.VeloNSFWButton)
        Me.IconBox.Controls.Add(Me.AleNSFWButton)
        Me.IconBox.Controls.Add(Me.VeloButton)
        Me.IconBox.Controls.Add(Me.AleButton)
        Me.IconBox.Controls.Add(Me.PokemonButton)
        Me.IconBox.Controls.Add(Me.DiscordButton)
        Me.IconBox.ForeColor = System.Drawing.Color.White
        Me.IconBox.Location = New System.Drawing.Point(13, 379)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Size = New System.Drawing.Size(157, 91)
        Me.IconBox.TabIndex = 16
        Me.IconBox.TabStop = False
        Me.IconBox.Text = "Icon"
        '
        'VeloNSFWButton
        '
        Me.VeloNSFWButton.AutoSize = True
        Me.VeloNSFWButton.Location = New System.Drawing.Point(77, 67)
        Me.VeloNSFWButton.Name = "VeloNSFWButton"
        Me.VeloNSFWButton.Size = New System.Drawing.Size(75, 17)
        Me.VeloNSFWButton.TabIndex = 5
        Me.VeloNSFWButton.TabStop = True
        Me.VeloNSFWButton.Text = "Velo lewd"
        Me.VeloNSFWButton.UseVisualStyleBackColor = True
        '
        'AleNSFWButton
        '
        Me.AleNSFWButton.AutoSize = True
        Me.AleNSFWButton.Location = New System.Drawing.Point(7, 67)
        Me.AleNSFWButton.Name = "AleNSFWButton"
        Me.AleNSFWButton.Size = New System.Drawing.Size(69, 17)
        Me.AleNSFWButton.TabIndex = 4
        Me.AleNSFWButton.TabStop = True
        Me.AleNSFWButton.Text = "Ale lewd"
        Me.AleNSFWButton.UseVisualStyleBackColor = True
        '
        'VeloButton
        '
        Me.VeloButton.AutoSize = True
        Me.VeloButton.Location = New System.Drawing.Point(77, 44)
        Me.VeloButton.Name = "VeloButton"
        Me.VeloButton.Size = New System.Drawing.Size(47, 17)
        Me.VeloButton.TabIndex = 3
        Me.VeloButton.TabStop = True
        Me.VeloButton.Text = "Velo"
        Me.VeloButton.UseVisualStyleBackColor = True
        '
        'AleButton
        '
        Me.AleButton.AutoSize = True
        Me.AleButton.Location = New System.Drawing.Point(7, 44)
        Me.AleButton.Name = "AleButton"
        Me.AleButton.Size = New System.Drawing.Size(64, 17)
        Me.AleButton.TabIndex = 2
        Me.AleButton.TabStop = True
        Me.AleButton.Text = "Alethila"
        Me.AleButton.UseVisualStyleBackColor = True
        '
        'PokemonButton
        '
        Me.PokemonButton.AutoSize = True
        Me.PokemonButton.Location = New System.Drawing.Point(77, 21)
        Me.PokemonButton.Name = "PokemonButton"
        Me.PokemonButton.Size = New System.Drawing.Size(73, 17)
        Me.PokemonButton.TabIndex = 1
        Me.PokemonButton.TabStop = True
        Me.PokemonButton.Text = "Pokemon"
        Me.PokemonButton.UseVisualStyleBackColor = True
        '
        'DiscordButton
        '
        Me.DiscordButton.AutoSize = True
        Me.DiscordButton.Location = New System.Drawing.Point(7, 21)
        Me.DiscordButton.Name = "DiscordButton"
        Me.DiscordButton.Size = New System.Drawing.Size(64, 17)
        Me.DiscordButton.TabIndex = 0
        Me.DiscordButton.TabStop = True
        Me.DiscordButton.Text = "Discord"
        Me.DiscordButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Privacy"
        '
        'CFULink
        '
        Me.CFULink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.CFULink.AutoSize = True
        Me.CFULink.LinkColor = System.Drawing.Color.White
        Me.CFULink.Location = New System.Drawing.Point(10, 309)
        Me.CFULink.Name = "CFULink"
        Me.CFULink.Size = New System.Drawing.Size(110, 13)
        Me.CFULink.TabIndex = 11
        Me.CFULink.TabStop = True
        Me.CFULink.Text = "Check for updates..."
        '
        'AboutLink
        '
        Me.AboutLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.AboutLink.AutoSize = True
        Me.AboutLink.LinkColor = System.Drawing.Color.White
        Me.AboutLink.Location = New System.Drawing.Point(90, 499)
        Me.AboutLink.Name = "AboutLink"
        Me.AboutLink.Size = New System.Drawing.Size(91, 13)
        Me.AboutLink.TabIndex = 12
        Me.AboutLink.TabStop = True
        Me.AboutLink.Text = "About VisCord..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Navigation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Performance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cache && Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Notifications"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "System Tray"
        '
        'GeneralTitle
        '
        Me.GeneralTitle.AutoSize = True
        Me.GeneralTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralTitle.ForeColor = System.Drawing.Color.White
        Me.GeneralTitle.Location = New System.Drawing.Point(10, 35)
        Me.GeneralTitle.Name = "GeneralTitle"
        Me.GeneralTitle.Size = New System.Drawing.Size(47, 13)
        Me.GeneralTitle.TabIndex = 3
        Me.GeneralTitle.Text = "General"
        '
        'VCSettingsTitle
        '
        Me.VCSettingsTitle.AutoSize = True
        Me.VCSettingsTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VCSettingsTitle.ForeColor = System.Drawing.Color.White
        Me.VCSettingsTitle.Location = New System.Drawing.Point(9, 9)
        Me.VCSettingsTitle.Name = "VCSettingsTitle"
        Me.VCSettingsTitle.Size = New System.Drawing.Size(104, 17)
        Me.VCSettingsTitle.TabIndex = 0
        Me.VCSettingsTitle.Text = "VisCord Settings"
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
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ToolStripSeparator1, Me.UserSettingsToolStripMenuItem, Me.AboutVisCordToolStripMenuItem, Me.ToolStripSeparator2, Me.LogOffToolStripMenuItem, Me.ExitToolStripMenuItem})
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
        'UserSettingsToolStripMenuItem
        '
        Me.UserSettingsToolStripMenuItem.Image = Global.VisCord.My.Resources.Resources.WinAccount
        Me.UserSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserSettingsToolStripMenuItem.Name = "UserSettingsToolStripMenuItem"
        Me.UserSettingsToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.UserSettingsToolStripMenuItem.Text = "User settings..."
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
        'JSButton
        '
        Me.JSButton.BackColor = System.Drawing.Color.Transparent
        Me.JSButton.Location = New System.Drawing.Point(9, 41)
        Me.JSButton.Name = "JSButton"
        Me.JSButton.Size = New System.Drawing.Size(126, 23)
        Me.JSButton.TabIndex = 9
        Me.JSButton.Text = "Edit JavaScript..."
        Me.JSButton.UseVisualStyleBackColor = False
        '
        'JSLabel
        '
        Me.JSLabel.AutoSize = True
        Me.JSLabel.BackColor = System.Drawing.Color.Transparent
        Me.JSLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSLabel.ForeColor = System.Drawing.Color.White
        Me.JSLabel.Location = New System.Drawing.Point(8, 25)
        Me.JSLabel.Name = "JSLabel"
        Me.JSLabel.Size = New System.Drawing.Size(127, 13)
        Me.JSLabel.TabIndex = 3
        Me.JSLabel.Text = "Load Custom JavaScript"
        '
        'ToolLabel
        '
        Me.ToolLabel.AutoSize = True
        Me.ToolLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToolLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolLabel.ForeColor = System.Drawing.Color.White
        Me.ToolLabel.Location = New System.Drawing.Point(8, 6)
        Me.ToolLabel.Name = "ToolLabel"
        Me.ToolLabel.Size = New System.Drawing.Size(55, 17)
        Me.ToolLabel.TabIndex = 0
        Me.ToolLabel.Text = "Toolbox"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.Controls.Add(Me.ToolboxButton)
        Me.TitlePanel.Controls.Add(Me.HelpButton)
        Me.TitlePanel.Controls.Add(Me.AreaLabel)
        Me.TitlePanel.Controls.Add(Me.VisCordPic)
        Me.TitlePanel.Controls.Add(Me.BackButton)
        Me.TitlePanel.Controls.Add(Me.ForwardButton)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1264, 30)
        Me.TitlePanel.TabIndex = 20
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
        Me.OfflinePanel.Controls.Add(Me.OfflineLabel)
        Me.OfflinePanel.Controls.Add(Me.IconPictureBox)
        Me.OfflinePanel.Location = New System.Drawing.Point(476, 173)
        Me.OfflinePanel.Name = "OfflinePanel"
        Me.OfflinePanel.Size = New System.Drawing.Size(312, 315)
        Me.OfflinePanel.TabIndex = 21
        Me.OfflinePanel.Visible = False
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
        'ToolPanel
        '
        Me.ToolPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolPanel.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.ToolPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolPanel.Controls.Add(Me.NSFWContentChecbox)
        Me.ToolPanel.Controls.Add(Me.ContentLabel)
        Me.ToolPanel.Controls.Add(Me.JSLabel)
        Me.ToolPanel.Controls.Add(Me.ToolLabel)
        Me.ToolPanel.Controls.Add(Me.JSButton)
        Me.ToolPanel.Location = New System.Drawing.Point(874, 29)
        Me.ToolPanel.Name = "ToolPanel"
        Me.ToolPanel.Size = New System.Drawing.Size(361, 74)
        Me.ToolPanel.TabIndex = 22
        Me.ToolPanel.Visible = False
        '
        'ContentLabel
        '
        Me.ContentLabel.AutoSize = True
        Me.ContentLabel.BackColor = System.Drawing.Color.Transparent
        Me.ContentLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentLabel.ForeColor = System.Drawing.Color.White
        Me.ContentLabel.Location = New System.Drawing.Point(141, 25)
        Me.ContentLabel.Name = "ContentLabel"
        Me.ContentLabel.Size = New System.Drawing.Size(49, 13)
        Me.ContentLabel.TabIndex = 10
        Me.ContentLabel.Text = "Content"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.ToolPanel)
        Me.Controls.Add(Me.OfflinePanel)
        Me.Controls.Add(Me.VisCordSettings)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.WebView21)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1280, 700)
        Me.Name = "Main"
        Me.Text = "Initialising... - VisCord"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VisCordSettings.ResumeLayout(False)
        Me.VisCordSettings.PerformLayout()
        Me.IconBox.ResumeLayout(False)
        Me.IconBox.PerformLayout()
        Me.SysTrayMenu.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.VisCordPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfflinePanel.ResumeLayout(False)
        Me.OfflinePanel.PerformLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolPanel.ResumeLayout(False)
        Me.ToolPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContentTimer As Timer
    Friend WithEvents VisCordSettings As Panel
    Friend WithEvents StartupCheckbox As CheckBox
    Friend WithEvents VCSettingsTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GeneralTitle As Label
    Friend WithEvents SysTrayCheckbox As CheckBox
    Friend WithEvents SysTrayIcon As NotifyIcon
    Friend WithEvents NotifyCheckbox As CheckBox
    Friend WithEvents BadgeCheckbox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NotifTimer As Timer
    Friend WithEvents FixTitle As Timer
    Friend WithEvents CacheButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataButton As Button
    Friend WithEvents HardwareCheckbox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NavCheckbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AboutLink As LinkLabel
    Friend WithEvents SysTrayMenu As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UserSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutVisCordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CFULink As LinkLabel
    Friend WithEvents JSButton As Button
    Friend WithEvents JSLabel As Label
    Friend WithEvents ToolLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents VisCordPic As PictureBox
    Friend WithEvents AreaLabel As Label
    Friend WithEvents HelpButton As Button
    Friend WithEvents NetworkCheckbox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OfflinePanel As Panel
    Friend WithEvents IconBox As GroupBox
    Friend WithEvents IconPictureBox As PictureBox
    Friend WithEvents OfflineLabel As Label
    Friend WithEvents AleButton As RadioButton
    Friend WithEvents PokemonButton As RadioButton
    Friend WithEvents DiscordButton As RadioButton
    Friend WithEvents NSFWCheckbox As CheckBox
    Friend WithEvents OtherLabel As Label
    Friend WithEvents VeloButton As RadioButton
    Friend WithEvents VeloNSFWButton As RadioButton
    Friend WithEvents AleNSFWButton As RadioButton
    Friend WithEvents ToolboxButton As Button
    Friend WithEvents ToolPanel As Panel
    Friend WithEvents NSFWContentChecbox As CheckBox
    Friend WithEvents ContentLabel As Label
End Class
