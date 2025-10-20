<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.ContentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SysTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
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
        Me.StartupCheckbox.TabIndex = 1
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
        Me.SysTrayCheckbox.TabIndex = 2
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
        Me.BadgeCheckbox.TabIndex = 6
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
        Me.NotifyCheckbox.TabIndex = 7
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
        Me.HardwareCheckbox.TabIndex = 11
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
        Me.NavCheckbox.TabIndex = 14
        Me.NavCheckbox.Text = "Open links in a browser"
        Me.ToolTip1.SetToolTip(Me.NavCheckbox, "Open links in an external browser." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If unchecked, will open links in a new WebV" &
        "iew2 window.")
        Me.NavCheckbox.UseVisualStyleBackColor = True
        '
        'ContentTimer
        '
        Me.ContentTimer.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CFULink)
        Me.Panel1.Controls.Add(Me.AboutLink)
        Me.Panel1.Controls.Add(Me.NavCheckbox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.HardwareCheckbox)
        Me.Panel1.Controls.Add(Me.DataButton)
        Me.Panel1.Controls.Add(Me.CacheButton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NotifyCheckbox)
        Me.Panel1.Controls.Add(Me.BadgeCheckbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GeneralTitle)
        Me.Panel1.Controls.Add(Me.SysTrayCheckbox)
        Me.Panel1.Controls.Add(Me.StartupCheckbox)
        Me.Panel1.Controls.Add(Me.VCSettingsTitle)
        Me.Panel1.Location = New System.Drawing.Point(1068, 295)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 354)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'CFULink
        '
        Me.CFULink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.CFULink.AutoSize = True
        Me.CFULink.LinkColor = System.Drawing.Color.White
        Me.CFULink.Location = New System.Drawing.Point(14, 309)
        Me.CFULink.Name = "CFULink"
        Me.CFULink.Size = New System.Drawing.Size(110, 13)
        Me.CFULink.TabIndex = 16
        Me.CFULink.TabStop = True
        Me.CFULink.Text = "Check for updates..."
        '
        'AboutLink
        '
        Me.AboutLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.AboutLink.AutoSize = True
        Me.AboutLink.LinkColor = System.Drawing.Color.White
        Me.AboutLink.Location = New System.Drawing.Point(88, 335)
        Me.AboutLink.Name = "AboutLink"
        Me.AboutLink.Size = New System.Drawing.Size(91, 13)
        Me.AboutLink.TabIndex = 15
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebView21)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1280, 700)
        Me.Name = "Main"
        Me.Text = "Initialising... - VisCord"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SysTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContentTimer As Timer
    Friend WithEvents Panel1 As Panel
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
End Class
