Public Class SendOfflineMessage
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Main.OutboxView.Items.Add(TextBox2.Text)
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class