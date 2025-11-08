<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdaterPrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdaterPrompt))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PostponeButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PNText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.VisCord.My.Resources.Resources.Updates_New
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Let your computer install an update."
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = Global.VisCord.My.Resources.Resources.WarningGradient
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(483, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(293, 234)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(93, 23)
        Me.UpdateButton.TabIndex = 32
        Me.UpdateButton.Text = "Update Now"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'PostponeButton
        '
        Me.PostponeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PostponeButton.BackColor = System.Drawing.Color.Transparent
        Me.PostponeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PostponeButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PostponeButton.ForeColor = System.Drawing.Color.White
        Me.PostponeButton.Location = New System.Drawing.Point(392, 234)
        Me.PostponeButton.Name = "PostponeButton"
        Me.PostponeButton.Size = New System.Drawing.Size(79, 23)
        Me.PostponeButton.TabIndex = 33
        Me.PostponeButton.Text = "Postpone"
        Me.PostponeButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PNText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 176)
        Me.Panel1.TabIndex = 35
        '
        'PNText
        '
        Me.PNText.Location = New System.Drawing.Point(12, 58)
        Me.PNText.Multiline = True
        Me.PNText.Name = "PNText"
        Me.PNText.ReadOnly = True
        Me.PNText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PNText.Size = New System.Drawing.Size(459, 104)
        Me.PNText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "You are running an out of date copy of VisCord. Updating provides you with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "what'" &
    "s listed below and more!"
        '
        'UpdaterPrompt
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 264)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.PostponeButton)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdaterPrompt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automatic Updates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PostponeButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PNText As TextBox
    Friend WithEvents Label2 As Label
End Class
