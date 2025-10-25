Public Class SendOfflineMessage
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Main.OutboxView.Items.Add(TextBox1.Text).SubItems.AddRange(New String() {TextBox2.Text})
        Me.Close()
    End Sub
End Class