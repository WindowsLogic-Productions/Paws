Public Class About
    Private Sub linkLabelContribute_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabelContribute.LinkClicked
        Process.Start("https://github.com/windowslogic-productions/paws")
    End Sub

    Private Sub buttonOK_Click(sender As Object, e As EventArgs) Handles buttonOK.Click
        Me.Close()
    End Sub
End Class