Imports System.IO

Public Class Pins
#Region "Load Settings"
    Private Sub Pins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get custom pin list names.
        PinView1.Columns(0).Text = My.Settings.PinList1Name
        PinView2.Columns(0).Text = My.Settings.PinList2Name
        PinView3.Columns(0).Text = My.Settings.PinList3Name

        'Get pin list data from external files in case of update.
        Try
            My.Settings.PinList1 = File.ReadAllText(Application.StartupPath & "\PinList1.vcp").ToString()
            My.Settings.PinList2 = File.ReadAllText(Application.StartupPath & "\PinList2.vcp").ToString()
            My.Settings.PinList3 = File.ReadAllText(Application.StartupPath & "\PinList3.vcp").ToString()
        Catch
        End Try

        'Load pin lists.
        LoadPinList1()
        LoadPinList2()
        LoadPinList3()

        'Disable plus buttons on Discord friends home.
        If Main.Text.Contains("Friends") Then
            AddList1.Enabled = False
            AddList2.Enabled = False
            AddList3.Enabled = False
        Else
            AddList1.Enabled = True
            AddList2.Enabled = True
            AddList3.Enabled = True
        End If
    End Sub
#End Region
#Region "Functions"
    Private Sub PinView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PinView1.MouseDoubleClick
        Dim selecteditem As ListViewItem = PinView1.SelectedItems(0)
        Dim selectedurl As String
        selectedurl = selecteditem.SubItems(1).Text
        Main.WebView21.CoreWebView2.Navigate(selectedurl)
        Me.Close()
    End Sub

    Private Sub PinView2_DoubleClick(sender As Object, e As EventArgs) Handles PinView2.DoubleClick
        Dim selecteditem As ListViewItem = PinView2.SelectedItems(0)
        Dim selectedurl As String
        selectedurl = selecteditem.SubItems(1).Text
        Main.WebView21.CoreWebView2.Navigate(selectedurl)
        Me.Close()
    End Sub

    Private Sub PinView3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PinView3.MouseDoubleClick
        Dim selecteditem As ListViewItem = PinView3.SelectedItems(0)
        Dim selectedurl As String
        selectedurl = selecteditem.SubItems(1).Text
        Main.WebView21.CoreWebView2.Navigate(selectedurl)
        Me.Close()
    End Sub

    Private Sub SaveListsToFile()
        File.Create(Application.StartupPath & "\PinList1.vcp").Dispose()
        File.Create(Application.StartupPath & "\PinList2.vcp").Dispose()
        File.Create(Application.StartupPath & "\PinList3.vcp").Dispose()

        System.IO.File.WriteAllText(Application.StartupPath & "\PinList1.vcp", "")
        System.IO.File.WriteAllText(Application.StartupPath & "\PinList2.vcp", "")
        System.IO.File.WriteAllText(Application.StartupPath & "\PinList3.vcp", "")

        Dim objWriter1 As New System.IO.StreamWriter(Application.StartupPath & "\PinList1.vcp", True)
        Dim objWriter2 As New System.IO.StreamWriter(Application.StartupPath & "\PinList2.vcp", True)
        Dim objWriter3 As New System.IO.StreamWriter(Application.StartupPath & "\PinList3.vcp", True)

        objWriter1.Write(My.Settings.PinList1)
        objWriter2.Write(My.Settings.PinList2)
        objWriter3.Write(My.Settings.PinList3)

        objWriter1.Close()
        objWriter2.Close()
        objWriter3.Close()
    End Sub

    'Saves pin lists to my.settings by splitting the first and second columns of each list.
    Private Sub SavePinList1()
        Dim PinList1Items As New List(Of String)()

        For Each PinList1Item As ListViewItem In PinView1.Items
            Dim mainItem As String = PinList1Item.Text

            Dim pinList1SubItems As New List(Of String)()

            For i As Integer = 1 To PinList1Item.SubItems.Count - 1
                pinList1SubItems.Add(PinList1Item.SubItems(i).Text)
            Next

            PinList1Items.Add($"{mainItem}|{String.Join(";", pinList1SubItems)}")
        Next

        My.Settings.PinList1 = String.Join(";", PinList1Items)
        My.Settings.Save()
    End Sub

    Private Sub SavePinList2()
        Dim pinList3Items As New List(Of String)()

        For Each pinList3Item As ListViewItem In PinView2.Items
            Dim mainItem As String = pinList3Item.Text

            Dim pinList2SubItems As New List(Of String)()

            For i As Integer = 1 To pinList3Item.SubItems.Count - 1
                pinList2SubItems.Add(pinList3Item.SubItems(i).Text)
            Next

            pinList3Items.Add($"{mainItem}|{String.Join(";", pinList2SubItems)}")
        Next

        My.Settings.PinList2 = String.Join(";", pinList3Items)
        My.Settings.Save()
    End Sub

    Private Sub SavePinList3()
        Dim PinList3Items As New List(Of String)()

        For Each PinList3Item As ListViewItem In PinView3.Items
            Dim mainItem As String = PinList3Item.Text

            Dim pinList3SubItems As New List(Of String)()

            For i As Integer = 1 To PinList3Item.SubItems.Count - 1
                pinList3SubItems.Add(PinList3Item.SubItems(i).Text)
            Next

            PinList3Items.Add($"{mainItem}|{String.Join(";", pinList3SubItems)}")
        Next

        My.Settings.PinList3 = String.Join(";", PinList3Items)
        My.Settings.Save()
    End Sub

    'Load lists from settings by joining the first and second columns together.
    Private Sub LoadPinList1()
        PinView1.Items.Clear()

        Dim savedData As String = My.Settings.PinList1

        If Not String.IsNullOrEmpty(savedData) Then
            Dim pinList1Items As String() = savedData.Split(";"c)

            For Each pinList1Item As String In pinList1Items
                Dim pinList1Parts As String() = pinList1Item.Split("|"c)

                If pinList1Parts.Length > 0 Then
                    Dim listItem As New ListViewItem(pinList1Parts(0))

                    If pinList1Parts.Length > 1 Then
                        Dim subItems As String() = pinList1Parts(1).Split(";"c)

                        For Each subItem As String In subItems
                            listItem.SubItems.Add(subItem.Trim())
                        Next
                    End If

                    PinView1.Items.Add(listItem)
                End If
            Next
        Else
        End If
    End Sub

    Private Sub LoadPinList2()
        PinView2.Items.Clear()

        Dim savedData As String = My.Settings.PinList2

        If Not String.IsNullOrEmpty(savedData) Then
            Dim pinList2Items As String() = savedData.Split(";"c)

            For Each pinList2Item As String In pinList2Items
                Dim pinList2Parts As String() = pinList2Item.Split("|"c)

                If pinList2Parts.Length > 0 Then
                    Dim listItem As New ListViewItem(pinList2Parts(0))

                    If pinList2Parts.Length > 1 Then
                        Dim subItems As String() = pinList2Parts(1).Split(";"c)

                        For Each subItem As String In subItems
                            listItem.SubItems.Add(subItem.Trim())
                        Next
                    End If

                    PinView2.Items.Add(listItem)
                End If
            Next
        Else
        End If
    End Sub

    Private Sub LoadPinList3()
        PinView3.Items.Clear()

        Dim savedData As String = My.Settings.PinList3

        If Not String.IsNullOrEmpty(savedData) Then
            Dim pinList3Items As String() = savedData.Split(";"c)

            For Each pinList3Item As String In pinList3Items
                Dim pinList3Parts As String() = pinList3Item.Split("|"c)

                If pinList3Parts.Length > 0 Then
                    Dim listItem As New ListViewItem(pinList3Parts(0))

                    If pinList3Parts.Length > 1 Then
                        Dim subItems As String() = pinList3Parts(1).Split(";"c)

                        For Each subItem As String In subItems
                            listItem.SubItems.Add(subItem.Trim())
                        Next
                    End If

                    PinView3.Items.Add(listItem)
                End If
            Next
        Else
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub AddList1_Click(sender As Object, e As EventArgs) Handles AddList1.Click
        AddPins.Text = "Add To List: " + PinView1.Columns(0).Text
        AddPins.Label2.Text = "Specify a custom name for the pin."
        AddPins.ShowDialog()
    End Sub

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

    Private Sub DelList1_Click(sender As Object, e As EventArgs) Handles DelList1.Click
        Dim obi As ListViewItem
        For Each obi In PinView1.Items
            PinView1.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub AddList2_Click(sender As Object, e As EventArgs) Handles AddList2.Click
        AddPins.Text = "Add To List: " + PinView2.Columns(0).Text
        AddPins.Label2.Text = "Specify a custom name for the pin."
        AddPins.ShowDialog()
    End Sub

    Private Sub DelList2_Click(sender As Object, e As EventArgs) Handles DelList2.Click
        Dim obi As ListViewItem
        For Each obi In PinView2.Items
            PinView2.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub AddList3_Click(sender As Object, e As EventArgs) Handles AddList3.Click
        AddPins.Text = "Add To List: " + PinView3.Columns(0).Text
        AddPins.Label2.Text = "Specify a custom name for the pin."
        AddPins.ShowDialog()
    End Sub

    Private Sub DelList3_Click(sender As Object, e As EventArgs) Handles DelList3.Click
        Dim obi As ListViewItem
        For Each obi In PinView3.Items
            PinView3.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
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

    Private Sub ExportList1_Click(sender As Object, e As EventArgs) Handles ExportList1.Click
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

    Private Sub ExportList2_Click(sender As Object, e As EventArgs) Handles ExportList2.Click
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

    Private Sub ExportList3_Click(sender As Object, e As EventArgs) Handles ExportList3.Click
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