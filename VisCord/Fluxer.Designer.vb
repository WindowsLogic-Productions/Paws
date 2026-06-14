<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fluxer
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
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PinsButton = New System.Windows.Forms.Button()
        Me.ToolboxButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.OfflinePanel = New System.Windows.Forms.Panel()
        Me.ReloadLink = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OfflineMessageLink = New System.Windows.Forms.LinkLabel()
        Me.OfflineLabel = New System.Windows.Forms.Label()
        Me.IconPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        Me.OfflinePanel.SuspendLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WebView21.Size = New System.Drawing.Size(1264, 681)
        Me.WebView21.Source = New System.Uri("https://fluxer.com/app", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 25
        Me.WebView21.Visible = False
        Me.WebView21.ZoomFactor = 1.0R
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.Controls.Add(Me.PinsButton)
        Me.TitlePanel.Controls.Add(Me.ToolboxButton)
        Me.TitlePanel.Controls.Add(Me.HelpButton)
        Me.TitlePanel.Controls.Add(Me.AreaLabel)
        Me.TitlePanel.Controls.Add(Me.BackButton)
        Me.TitlePanel.Controls.Add(Me.ForwardButton)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1264, 32)
        Me.TitlePanel.TabIndex = 26
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
        Me.PinsButton.UseVisualStyleBackColor = False
        Me.PinsButton.Visible = False
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
        Me.ToolboxButton.UseVisualStyleBackColor = False
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
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaLabel.ForeColor = System.Drawing.Color.White
        Me.AreaLabel.Location = New System.Drawing.Point(63, 6)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(0, 17)
        Me.AreaLabel.TabIndex = 21
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
        Me.ForwardButton.UseVisualStyleBackColor = True
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
        Me.OfflinePanel.TabIndex = 27
        Me.OfflinePanel.Visible = False
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
        '
        'OfflineLabel
        '
        Me.OfflineLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfflineLabel.AutoSize = True
        Me.OfflineLabel.BackColor = System.Drawing.Color.Transparent
        Me.OfflineLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfflineLabel.ForeColor = System.Drawing.Color.White
        Me.OfflineLabel.Location = New System.Drawing.Point(78, 258)
        Me.OfflineLabel.Name = "OfflineLabel"
        Me.OfflineLabel.Size = New System.Drawing.Size(156, 17)
        Me.OfflineLabel.TabIndex = 1
        Me.OfflineLabel.Text = "Fluxer is in offline mode."
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
        'Fluxer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.OfflinePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.WebView21)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Fluxer"
        Me.Text = "Fluxer"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.OfflinePanel.ResumeLayout(False)
        Me.OfflinePanel.PerformLayout()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents PinsButton As Button
    Friend WithEvents ToolboxButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents AreaLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents OfflinePanel As Panel
    Friend WithEvents ReloadLink As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OfflineMessageLink As LinkLabel
    Friend WithEvents OfflineLabel As Label
    Friend WithEvents IconPictureBox As PictureBox
End Class
