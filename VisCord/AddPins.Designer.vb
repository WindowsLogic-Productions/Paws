<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPins))
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(84, 54)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.Location = New System.Drawing.Point(165, 54)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 26)
        Me.TextBox2.MaxLength = 256
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 22)
        Me.TextBox2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Specify a custom name for the pin."
        '
        'AddPins
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(252, 87)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPins"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add to list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
