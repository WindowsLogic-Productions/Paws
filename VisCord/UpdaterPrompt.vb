Public Class UpdaterPrompt
    Private Sub UpdaterPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2

        'Load latest patch notes.
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.patchnotes)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestpn As String = sr.ReadToEnd()
            PNText.Text = newestpn
        Catch
            PNText.Text = "Unable to get latest patch notes."
        End Try
    End Sub
#Region "Buttons"
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Hide()
        Main.Updater.RunWorkerAsync()
        Me.Close()
    End Sub

    Private Sub PostponeButton_Click(sender As Object, e As EventArgs) Handles PostponeButton.Click
        Me.Close()
    End Sub
#End Region
End Class