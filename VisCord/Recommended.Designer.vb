<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recommended
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recommended))
        Me.List1Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitleLink = New System.Windows.Forms.LinkLabel()
        Me.WLPButton = New System.Windows.Forms.Button()
        Me.FiMAButton = New System.Windows.Forms.Button()
        Me.List2Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.List3Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ServersPanel = New System.Windows.Forms.Panel()
        Me.List1Menu.SuspendLayout()
        Me.List2Menu.SuspendLayout()
        Me.List3Menu.SuspendLayout()
        Me.ServersPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'List1Menu
        '
        Me.List1Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameListToolStripMenuItem})
        Me.List1Menu.Name = "List1Menu"
        Me.List1Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.List1Menu.Size = New System.Drawing.Size(145, 26)
        '
        'RenameListToolStripMenuItem
        '
        Me.RenameListToolStripMenuItem.Name = "RenameListToolStripMenuItem"
        Me.RenameListToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RenameListToolStripMenuItem.Text = "Rename list..."
        '
        'TitleLink
        '
        Me.TitleLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.TitleLink.AutoSize = True
        Me.TitleLink.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.TitleLink.LinkColor = System.Drawing.Color.White
        Me.TitleLink.Location = New System.Drawing.Point(256, 33)
        Me.TitleLink.Name = "TitleLink"
        Me.TitleLink.Size = New System.Drawing.Size(114, 30)
        Me.TitleLink.TabIndex = 15
        Me.TitleLink.TabStop = True
        Me.TitleLink.Text = "Add Server"
        Me.ToolTip1.SetToolTip(Me.TitleLink, "Add your own server to this list.")
        '
        'WLPButton
        '
        Me.WLPButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WLPButton.BackColor = System.Drawing.Color.Black
        Me.WLPButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WLPButton.FlatAppearance.BorderSize = 0
        Me.WLPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WLPButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLPButton.ForeColor = System.Drawing.Color.White
        Me.WLPButton.Image = Global.VisCord.My.Resources.Resources.WLP
        Me.WLPButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WLPButton.Location = New System.Drawing.Point(0, 0)
        Me.WLPButton.Name = "WLPButton"
        Me.WLPButton.Size = New System.Drawing.Size(443, 70)
        Me.WLPButton.TabIndex = 16
        Me.WLPButton.Text = "WindowsLogic Productions (18+)"
        Me.ToolTip1.SetToolTip(Me.WLPButton, "The official WindowsLogic Productions Discord server" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for game development and di" &
        "scussion.")
        Me.WLPButton.UseVisualStyleBackColor = False
        '
        'FiMAButton
        '
        Me.FiMAButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiMAButton.BackColor = System.Drawing.Color.Black
        Me.FiMAButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiMAButton.FlatAppearance.BorderSize = 0
        Me.FiMAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiMAButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiMAButton.ForeColor = System.Drawing.Color.White
        Me.FiMAButton.Image = Global.VisCord.My.Resources.Resources.FiMA
        Me.FiMAButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FiMAButton.Location = New System.Drawing.Point(0, 70)
        Me.FiMAButton.Name = "FiMAButton"
        Me.FiMAButton.Size = New System.Drawing.Size(443, 70)
        Me.FiMAButton.TabIndex = 17
        Me.FiMAButton.Text = "Fighting is Magic: Aurora"
        Me.ToolTip1.SetToolTip(Me.FiMAButton, "The official Fighting is Magic: Aurora Discord server" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for discussion of the infa" &
        "mous 2D pony fighting game.")
        Me.FiMAButton.UseVisualStyleBackColor = False
        '
        'List2Menu
        '
        Me.List2Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.List2Menu.Name = "List1Menu"
        Me.List2Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.List2Menu.Size = New System.Drawing.Size(145, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem1.Text = "Rename list..."
        '
        'List3Menu
        '
        Me.List3Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.List3Menu.Name = "List1Menu"
        Me.List3Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.List3Menu.Size = New System.Drawing.Size(145, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem2.Text = "Rename list..."
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(25, 33)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(244, 30)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Recommended Servers - "
        '
        'ServersPanel
        '
        Me.ServersPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServersPanel.AutoScroll = True
        Me.ServersPanel.Controls.Add(Me.FiMAButton)
        Me.ServersPanel.Controls.Add(Me.WLPButton)
        Me.ServersPanel.Location = New System.Drawing.Point(0, 95)
        Me.ServersPanel.Name = "ServersPanel"
        Me.ServersPanel.Size = New System.Drawing.Size(443, 355)
        Me.ServersPanel.TabIndex = 17
        '
        'Recommended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImage = Global.VisCord.My.Resources.Resources.gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(443, 450)
        Me.Controls.Add(Me.ServersPanel)
        Me.Controls.Add(Me.TitleLink)
        Me.Controls.Add(Me.TitleLabel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Recommended"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recommended Servers"
        Me.List1Menu.ResumeLayout(False)
        Me.List2Menu.ResumeLayout(False)
        Me.List3Menu.ResumeLayout(False)
        Me.ServersPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents List1Menu As ContextMenuStrip
    Friend WithEvents RenameListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents List2Menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents List3Menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TitleLink As LinkLabel
    Friend WithEvents WLPButton As Button
    Friend WithEvents ServersPanel As Panel
    Friend WithEvents FiMAButton As Button
End Class
