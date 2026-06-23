<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.linkLabelContribute = New System.Windows.Forms.LinkLabel()
        Me.labelLicense = New System.Windows.Forms.Label()
        Me.labelVersion = New System.Windows.Forms.Label()
        Me.AppPic = New System.Windows.Forms.PictureBox()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonOK
        '
        Me.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonOK.Location = New System.Drawing.Point(84, 199)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 3
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'linkLabelContribute
        '
        Me.linkLabelContribute.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.linkLabelContribute.AutoSize = True
        Me.linkLabelContribute.BackColor = System.Drawing.Color.Transparent
        Me.linkLabelContribute.LinkColor = System.Drawing.Color.White
        Me.linkLabelContribute.Location = New System.Drawing.Point(90, 167)
        Me.linkLabelContribute.Name = "linkLabelContribute"
        Me.linkLabelContribute.Size = New System.Drawing.Size(63, 13)
        Me.linkLabelContribute.TabIndex = 5
        Me.linkLabelContribute.TabStop = True
        Me.linkLabelContribute.Text = "Contribute"
        '
        'labelLicense
        '
        Me.labelLicense.AutoSize = True
        Me.labelLicense.BackColor = System.Drawing.Color.Transparent
        Me.labelLicense.ForeColor = System.Drawing.Color.White
        Me.labelLicense.Location = New System.Drawing.Point(7, 100)
        Me.labelLicense.Name = "labelLicense"
        Me.labelLicense.Size = New System.Drawing.Size(228, 52)
        Me.labelLicense.TabIndex = 7
        Me.labelLicense.Text = "A lightweight Pawchive client for Windows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "systems using WebView2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licensed un" &
    "der GPLv3"
        Me.labelLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelVersion
        '
        Me.labelVersion.AutoSize = True
        Me.labelVersion.BackColor = System.Drawing.Color.Transparent
        Me.labelVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVersion.ForeColor = System.Drawing.Color.White
        Me.labelVersion.Location = New System.Drawing.Point(64, 71)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(114, 21)
        Me.labelVersion.TabIndex = 6
        Me.labelVersion.Text = "VisCord 0.0.0.0"
        '
        'AppPic
        '
        Me.AppPic.BackColor = System.Drawing.Color.Transparent
        Me.AppPic.Image = Global.VisCord.My.Resources.Resources.Discord_Big
        Me.AppPic.Location = New System.Drawing.Point(97, 14)
        Me.AppPic.Name = "AppPic"
        Me.AppPic.Size = New System.Drawing.Size(48, 48)
        Me.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppPic.TabIndex = 4
        Me.AppPic.TabStop = False
        '
        'About
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(242, 234)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.linkLabelContribute)
        Me.Controls.Add(Me.labelLicense)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.AppPic)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About VisCord"
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonOK As Button
    Private WithEvents linkLabelContribute As LinkLabel
    Private WithEvents labelLicense As Label
    Friend WithEvents labelVersion As Label
    Friend WithEvents AppPic As PictureBox
End Class
