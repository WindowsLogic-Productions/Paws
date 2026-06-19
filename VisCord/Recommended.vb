Public Class Recommended
#Region "Load Settings"
    Private Sub Recommended_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load correct icon.
        Select Case My.Settings.Icon
            Case 0
                Me.Icon = My.Resources.Discord1
            Case 1
                Me.Icon = My.Resources.PDiscord
            Case 2
                Me.Icon = My.Resources.Alethila_Discord
            Case 3
                Me.Icon = My.Resources.Velo
        End Select
    End Sub
#End Region
#Region "Functions"
    Private Sub TitleLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TitleLink.LinkClicked
        Process.Start("https://github.com/windowslogic/viscord/issues")
    End Sub
#End Region
#Region "Buttons"
    Private Sub WLPButton_Click(sender As Object, e As EventArgs) Handles WLPButton.Click

    End Sub
#End Region
End Class