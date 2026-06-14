Imports System.IO
Public Class Recommended
#Region "Load Settings"

#End Region
#Region "Functions"

#End Region
#Region "Buttons"

#End Region
#Region "Closing"
    Private Sub Pins_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Save pin lists.
        SavePinList1()
        SavePinList2()
        SavePinList3()

        'Save pin lists to external files.
        SaveListsToFile()

        'Save pin list names to settings.
        My.Settings.PinList1Name = PinView1.Columns(0).Text
        My.Settings.PinList2Name = PinView2.Columns(0).Text
        My.Settings.PinList3Name = PinView3.Columns(0).Text
        My.Settings.Save()
    End Sub

    Private Sub DelList1_Click(sender As Object, e As EventArgs)
        Dim obi As ListViewItem
        For Each obi In PinView1.Items
            PinView1.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub AddList2_Click(sender As Object, e As EventArgs)
        AddPins.Text = "Add To List: " + PinView2.Columns(0).Text
        AddPins.Label2.Text = "Specify a custom name for the pin."
        AddPins.ShowDialog()
    End Sub

    Private Sub DelList2_Click(sender As Object, e As EventArgs)
        Dim obi As ListViewItem
        For Each obi In PinView2.Items
            PinView2.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub AddList3_Click(sender As Object, e As EventArgs)
        AddPins.Text = "Add To List: " + PinView3.Columns(0).Text
        AddPins.Label2.Text = "Specify a custom name for the pin."
        AddPins.ShowDialog()
    End Sub

    Private Sub DelList3_Click(sender As Object, e As EventArgs)
        Dim obi As ListViewItem
        For Each obi In PinView3.Items
            PinView3.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you would like to clear all pin lists?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PinView1.Items.Clear()
            PinView2.Items.Clear()
            PinView3.Items.Clear()
        Else
        End If
    End Sub

    Private Sub RenameListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameListToolStripMenuItem.Click
        AddPins.Text = "Rename: " + PinView1.Columns(0).Text
        AddPins.Label2.Text = "Choose a new name for the selected list."
        AddPins.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        AddPins.Text = "Rename: " + PinView2.Columns(0).Text
        AddPins.Label2.Text = "Choose a new name for the selected list."
        AddPins.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        AddPins.Text = "Rename: " + PinView3.Columns(0).Text
        AddPins.Label2.Text = "Choose a new name for the selected list."
        AddPins.ShowDialog()
    End Sub

    Private Sub ExportList1_Click(sender As Object, e As EventArgs)
        Try
            Dim MyStreamReader As System.IO.StreamReader
            MyStreamReader = System.IO.File.OpenText(Application.StartupPath & "\PinList1.vcp")
            ExportBox.Text = MyStreamReader.ReadToEnd()
            MyStreamReader.Close()
        Catch
            ExportBox.Text = "Data has not yet been created."
            ExportList1.Enabled = False
        End Try

        Dim Saveas As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Saveas.Filter = "Pin List (*.vcp)|*.vcp"
        Saveas.CheckPathExists = True
        Saveas.Title = "Export Pin List 1..."
        Saveas.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
            myStreamWriter.Write(ExportBox.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExportList2_Click(sender As Object, e As EventArgs)
        Try
            Dim MyStreamReader As System.IO.StreamReader
            MyStreamReader = System.IO.File.OpenText(Application.StartupPath & "\PinList2.vcp")
            ExportBox.Text = MyStreamReader.ReadToEnd()
            MyStreamReader.Close()
        Catch
            ExportBox.Text = "Data has not yet been created."
            ExportList2.Enabled = False
        End Try

        Dim Saveas As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Saveas.Filter = "Pin List (*.vcp)|*.vcp"
        Saveas.CheckPathExists = True
        Saveas.Title = "Export Pin List 2..."
        Saveas.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
            myStreamWriter.Write(ExportBox.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExportList3_Click(sender As Object, e As EventArgs)
        Try
            Dim MyStreamReader As System.IO.StreamReader
            MyStreamReader = System.IO.File.OpenText(Application.StartupPath & "\PinList3.vcp")
            ExportBox.Text = MyStreamReader.ReadToEnd()
            MyStreamReader.Close()
        Catch
            ExportBox.Text = "Data has not yet been created."
            ExportList3.Enabled = False
        End Try

        Dim Saveas As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Saveas.Filter = "Pin List (*.vcp)|*.vcp"
        Saveas.CheckPathExists = True
        Saveas.Title = "Export Pin List 3..."
        Saveas.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
            myStreamWriter.Write(ExportBox.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class