<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pins))
        Me.FavouritesLabel = New System.Windows.Forms.Label()
        Me.PinView1 = New System.Windows.Forms.ListView()
        Me.List = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List1Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddList1 = New System.Windows.Forms.Button()
        Me.AddList2 = New System.Windows.Forms.Button()
        Me.AddList3 = New System.Windows.Forms.Button()
        Me.DelList1 = New System.Windows.Forms.Button()
        Me.DelList2 = New System.Windows.Forms.Button()
        Me.DelList3 = New System.Windows.Forms.Button()
        Me.PinView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PinView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List2Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.List3Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.List1Menu.SuspendLayout()
        Me.List2Menu.SuspendLayout()
        Me.List3Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'FavouritesLabel
        '
        Me.FavouritesLabel.AutoSize = True
        Me.FavouritesLabel.ForeColor = System.Drawing.Color.White
        Me.FavouritesLabel.Location = New System.Drawing.Point(9, 9)
        Me.FavouritesLabel.Name = "FavouritesLabel"
        Me.FavouritesLabel.Size = New System.Drawing.Size(745, 13)
        Me.FavouritesLabel.TabIndex = 3
        Me.FavouritesLabel.Text = "Below is a list of users you have pinned. To go to a pinned user, double-click th" &
    "e user you want to go to. You can have up to 3 pinned user lists."
        '
        'PinView1
        '
        Me.PinView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.List, Me.URL})
        Me.PinView1.ContextMenuStrip = Me.List1Menu
        Me.PinView1.HideSelection = False
        Me.PinView1.Location = New System.Drawing.Point(47, 37)
        Me.PinView1.Name = "PinView1"
        Me.PinView1.Size = New System.Drawing.Size(219, 371)
        Me.PinView1.TabIndex = 0
        Me.PinView1.UseCompatibleStateImageBehavior = False
        Me.PinView1.View = System.Windows.Forms.View.Details
        '
        'List
        '
        Me.List.Text = "List 1"
        Me.List.Width = 155
        '
        'URL
        '
        Me.URL.Text = "URL"
        '
        'List1Menu
        '
        Me.List1Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameListToolStripMenuItem})
        Me.List1Menu.Name = "List1Menu"
        Me.List1Menu.Size = New System.Drawing.Size(145, 26)
        '
        'RenameListToolStripMenuItem
        '
        Me.RenameListToolStripMenuItem.Name = "RenameListToolStripMenuItem"
        Me.RenameListToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RenameListToolStripMenuItem.Text = "Rename list..."
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Image = Global.VisCord.My.Resources.Resources.WinBin
        Me.ClearButton.Location = New System.Drawing.Point(760, 410)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(28, 28)
        Me.ClearButton.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear all lists.")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'AddList1
        '
        Me.AddList1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddList1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AddList1.FlatAppearance.BorderSize = 0
        Me.AddList1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddList1.Image = Global.VisCord.My.Resources.Resources.WinMore
        Me.AddList1.Location = New System.Drawing.Point(47, 410)
        Me.AddList1.Name = "AddList1"
        Me.AddList1.Size = New System.Drawing.Size(28, 28)
        Me.AddList1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AddList1, "Add to list 1.")
        Me.AddList1.UseVisualStyleBackColor = False
        '
        'AddList2
        '
        Me.AddList2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddList2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AddList2.FlatAppearance.BorderSize = 0
        Me.AddList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddList2.Image = Global.VisCord.My.Resources.Resources.WinMore
        Me.AddList2.Location = New System.Drawing.Point(291, 410)
        Me.AddList2.Name = "AddList2"
        Me.AddList2.Size = New System.Drawing.Size(28, 28)
        Me.AddList2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.AddList2, "Add to list 2.")
        Me.AddList2.UseVisualStyleBackColor = False
        '
        'AddList3
        '
        Me.AddList3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddList3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AddList3.FlatAppearance.BorderSize = 0
        Me.AddList3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddList3.Image = Global.VisCord.My.Resources.Resources.WinMore
        Me.AddList3.Location = New System.Drawing.Point(535, 410)
        Me.AddList3.Name = "AddList3"
        Me.AddList3.Size = New System.Drawing.Size(28, 28)
        Me.AddList3.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.AddList3, "Add to list 3.")
        Me.AddList3.UseVisualStyleBackColor = False
        '
        'DelList1
        '
        Me.DelList1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelList1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DelList1.FlatAppearance.BorderSize = 0
        Me.DelList1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelList1.Image = Global.VisCord.My.Resources.Resources.WinLess
        Me.DelList1.Location = New System.Drawing.Point(81, 410)
        Me.DelList1.Name = "DelList1"
        Me.DelList1.Size = New System.Drawing.Size(28, 28)
        Me.DelList1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.DelList1, "Delete selected from list 1.")
        Me.DelList1.UseVisualStyleBackColor = False
        '
        'DelList2
        '
        Me.DelList2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelList2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DelList2.FlatAppearance.BorderSize = 0
        Me.DelList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelList2.Image = Global.VisCord.My.Resources.Resources.WinLess
        Me.DelList2.Location = New System.Drawing.Point(325, 410)
        Me.DelList2.Name = "DelList2"
        Me.DelList2.Size = New System.Drawing.Size(28, 28)
        Me.DelList2.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.DelList2, "Delete selected from list 2.")
        Me.DelList2.UseVisualStyleBackColor = False
        '
        'DelList3
        '
        Me.DelList3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelList3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DelList3.FlatAppearance.BorderSize = 0
        Me.DelList3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelList3.Image = Global.VisCord.My.Resources.Resources.WinLess
        Me.DelList3.Location = New System.Drawing.Point(569, 410)
        Me.DelList3.Name = "DelList3"
        Me.DelList3.Size = New System.Drawing.Size(28, 28)
        Me.DelList3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.DelList3, "Delete selected from list 3.")
        Me.DelList3.UseVisualStyleBackColor = False
        '
        'PinView2
        '
        Me.PinView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.PinView2.ContextMenuStrip = Me.List1Menu
        Me.PinView2.HideSelection = False
        Me.PinView2.Location = New System.Drawing.Point(291, 37)
        Me.PinView2.Name = "PinView2"
        Me.PinView2.Size = New System.Drawing.Size(219, 371)
        Me.PinView2.TabIndex = 1
        Me.PinView2.UseCompatibleStateImageBehavior = False
        Me.PinView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "List 2"
        Me.ColumnHeader3.Width = 155
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "URL"
        '
        'PinView3
        '
        Me.PinView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.PinView3.ContextMenuStrip = Me.List1Menu
        Me.PinView3.HideSelection = False
        Me.PinView3.Location = New System.Drawing.Point(535, 37)
        Me.PinView3.Name = "PinView3"
        Me.PinView3.Size = New System.Drawing.Size(219, 371)
        Me.PinView3.TabIndex = 2
        Me.PinView3.UseCompatibleStateImageBehavior = False
        Me.PinView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "List 3"
        Me.ColumnHeader1.Width = 155
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "URL"
        '
        'List2Menu
        '
        Me.List2Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.List2Menu.Name = "List1Menu"
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
        Me.List3Menu.Size = New System.Drawing.Size(145, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem2.Text = "Rename list..."
        '
        'Pins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PinView3)
        Me.Controls.Add(Me.PinView2)
        Me.Controls.Add(Me.DelList3)
        Me.Controls.Add(Me.DelList2)
        Me.Controls.Add(Me.DelList1)
        Me.Controls.Add(Me.AddList3)
        Me.Controls.Add(Me.AddList2)
        Me.Controls.Add(Me.AddList1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PinView1)
        Me.Controls.Add(Me.FavouritesLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pins"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pinned Friends"
        Me.List1Menu.ResumeLayout(False)
        Me.List2Menu.ResumeLayout(False)
        Me.List3Menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FavouritesLabel As Label
    Friend WithEvents PinView1 As ListView
    Friend WithEvents List As ColumnHeader
    Friend WithEvents ClearButton As Button
    Friend WithEvents List1Menu As ContextMenuStrip
    Friend WithEvents RenameListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AddList1 As Button
    Friend WithEvents AddList2 As Button
    Friend WithEvents AddList3 As Button
    Friend WithEvents DelList1 As Button
    Friend WithEvents DelList2 As Button
    Friend WithEvents DelList3 As Button
    Friend WithEvents URL As ColumnHeader
    Friend WithEvents PinView2 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents PinView3 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents List2Menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents List3Menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
