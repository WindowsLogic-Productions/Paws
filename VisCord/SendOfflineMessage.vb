Public Class SendOfflineMessage
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox2.Text = "" Then
            MsgBox("Your message cannot be blank.")
        Else
            Settings.OutboxView.Items.Add(TextBox2.Text)

            'Save outbox messages to settings.
            Dim OutboxItems As New List(Of String)()

            For Each OutboxItem As ListViewItem In Settings.OutboxView.Items
                Dim mainItem As String = OutboxItem.Text

                Dim pinList1SubItems As New List(Of String)()

                For i As Integer = 1 To OutboxItem.SubItems.Count - 1
                    pinList1SubItems.Add(OutboxItem.SubItems(i).Text)
                Next

                OutboxItems.Add($"{mainItem}|{String.Join(";", pinList1SubItems)}")
            Next

            My.Settings.OutboxList = String.Join(";", OutboxItems)
            My.Settings.Save()

            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class