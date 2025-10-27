Public Class SendOfflineMessage
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox2.Text = "" Then
            MsgBox("Your message cannot be blank.")
        Else
            Main.OutboxView.Items.Add(TextBox2.Text)
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class