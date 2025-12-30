Public Class Variables
    Public Shared ver As String = My.Application.Info.Version.ToString + " (" + Date.Now.ToString("MMMM") + " " + Date.Now.Year.ToString + ")"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared appname As String = "VisCord"
    Public Shared vertext As String = "https://u.windowslogic.co.uk/Updates/VISCORD/VISCORD.txt"
    Public Shared setup As String = "https://u.windowslogic.co.uk/Updates/VISCORD/VISCORD%20Setup.exe"
    Public Shared patchnotes As String = "https://u.windowslogic.co.uk/updates/VISCORD/patchnotes.txt"

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname)
    End Sub

    Public Shared Sub UpdateBadge()
        If My.Settings.NotifBadge = 1 Then
            Select Case My.Settings.Icon
                Case 0
                    Main.SysTrayIcon.Icon = My.Resources.DiscordNotif
                    Main.Icon = My.Resources.DiscordNotif
                Case 1
                    Main.Icon = My.Resources.PDiscord_Notif
                    Main.Icon = My.Resources.PDiscord_Notif
                Case 2
                    Main.Icon = My.Resources.Alethila_Notif
                    Main.Icon = My.Resources.Alethila_Notif
                Case 3
                    Main.Icon = My.Resources.Velo_Notif
                    Main.Icon = My.Resources.Velo_Notif
                Case 4
                    Main.Icon = My.Resources.AleVag_Notif
                    Main.Icon = My.Resources.AleVag_Notif
                Case 5
                    Main.Icon = My.Resources.VeloVag_Notif
                    Main.Icon = My.Resources.VeloVag_Notif
            End Select
        End If
    End Sub

    Public Shared Sub UpdateIcon()
        Select Case My.Settings.Icon
            Case 0
                Main.IconPictureBox.Image = My.Resources.Discord_Big
                Main.Icon = My.Resources.Discord1
                Main.SysTrayIcon.Icon = My.Resources.Discord1
                Main.DiscordButton.Checked = True
            Case 1
                Main.IconPictureBox.Image = My.Resources.PDiscord_Big
                Main.Icon = My.Resources.PDiscord
                Main.SysTrayIcon.Icon = My.Resources.PDiscord
                Main.PokemonButton.Checked = True
            Case 2
                Main.IconPictureBox.Image = My.Resources.Alethila_Big
                Main.Icon = My.Resources.Alethila_Discord
                Main.SysTrayIcon.Icon = My.Resources.Alethila_Discord
                Main.AleButton.Checked = True
            Case 3
                Main.IconPictureBox.Image = My.Resources.Velo_Big
                Main.Icon = My.Resources.Velo
                Main.SysTrayIcon.Icon = My.Resources.Velo
                Main.VeloButton.Checked = True
            Case 4
                Main.IconPictureBox.Image = My.Resources.AleVag_Big
                Main.Icon = My.Resources.AleVag
                Main.SysTrayIcon.Icon = My.Resources.AleVag
                Main.AleNSFWButton.Checked = True
            Case 5
                Main.IconPictureBox.Image = My.Resources.VeloVag_Big
                Main.Icon = My.Resources.VeloVag
                Main.SysTrayIcon.Icon = My.Resources.VeloVag
                Main.VeloNSFWButton.Checked = True
        End Select
    End Sub
#Region "Updater"
    Public Shared Sub Update_Settings()
        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then

                Else
                    UpdaterPrompt.ShowDialog()
                End If

            Catch
                'errordiag.Label1.Text = "No connection to the update server."
                'errordiag.ShowDialog()
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
End Class
