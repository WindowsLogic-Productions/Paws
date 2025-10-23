Public Class Injection
    Private Sub Injection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.AddNavJS = TextBox1.Text
    End Sub

    Private Sub Injection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.AddNavJS
    End Sub
End Class