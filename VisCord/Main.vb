Imports System.Net
Imports System.Threading
Imports Microsoft.Web.WebView2.Core

Public Class Main
    Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted
        WebView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = False
        WebView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = False
        WebView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = True
        WebView21.CoreWebView2.Settings.AreDevToolsEnabled = False
        If My.Settings.HA = 0 Then
            Dim options As New CoreWebView2EnvironmentOptions()
            options.AdditionalBrowserArguments = "--disable-gpu"
        Else
        End If
        AddHandler WebView21.CoreWebView2.NewWindowRequested, AddressOf CoreWebView2_NewWindowRequested

        'Check for Internet connection.
        If My.Settings.EnableNetwork = 1 Then
            CheckForInternetConnection()
        Else
            WebView21.Visible = False
            VisCordSettings.Visible = True
            OfflinePanel.Visible = True
            Me.Text = "Offline Mode - VisCord"
            AreaLabel.Text = ""
            HelpButton.Enabled = False
            ContentTimer.Stop()
            NotifTimer.Stop()
            FixTitle.Stop()
        End If

        LoadJS()
    End Sub

    Private Sub Ping()
        For val As Integer = 0 To 1
            If WebView21.CoreWebView2.DocumentTitle.Contains("(") Then
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                SysTrayIcon.ShowBalloonTip(1, "VisCord - Notification", "You have unread messages.", ToolTipIcon.Info)
                Me.Text = "New messages - VisCord"
                SysTrayIcon.Text = "New messages - VisCord"
                If My.Settings.NotifBadge = 1 Then
                    UpdateBadge()
                End If
            End If
            If val = 1 Then
                ContentTimer.Stop()
                Exit For
            End If
        Next
    End Sub

    Private Sub UpdateBadge()
        If My.Settings.NotifBadge = 1 Then
            Select Case My.Settings.Icon
                Case 0
                    SysTrayIcon.Icon = My.Resources.DiscordNotif
                    Me.Icon = My.Resources.DiscordNotif
                Case 1
                    SysTrayIcon.Icon = My.Resources.PDiscord_Notif
                    Me.Icon = My.Resources.PDiscord_Notif
                Case 2
                    SysTrayIcon.Icon = My.Resources.Alethila_Notif
                    Me.Icon = My.Resources.Alethila_Notif
                Case 3
                    SysTrayIcon.Icon = My.Resources.Velo_Notif
                    Me.Icon = My.Resources.Velo_Notif
                Case 4
                    SysTrayIcon.Icon = My.Resources.AleVag_Notif
                    Me.Icon = My.Resources.AleVag_Notif
                Case 5
                    SysTrayIcon.Icon = My.Resources.VeloVag_Notif
                    Me.Icon = My.Resources.VeloVag_Notif
            End Select
        End If
    End Sub

    Private Sub UpdateIcon()
        Select Case My.Settings.Icon
            Case 0
                IconPictureBox.Image = My.Resources.Discord_Big
                Me.Icon = My.Resources.Discord1
                SysTrayIcon.Icon = My.Resources.Discord1
                DiscordButton.Checked = True
            Case 1
                IconPictureBox.Image = My.Resources.PDiscord_Big
                Me.Icon = My.Resources.PDiscord
                SysTrayIcon.Icon = My.Resources.PDiscord
                PokemonButton.Checked = True
            Case 2
                IconPictureBox.Image = My.Resources.Alethila_Big
                Me.Icon = My.Resources.Alethila_Discord
                SysTrayIcon.Icon = My.Resources.Alethila_Discord
                AleButton.Checked = True
            Case 3
                IconPictureBox.Image = My.Resources.Velo_Big
                Me.Icon = My.Resources.Velo
                SysTrayIcon.Icon = My.Resources.Velo
                VeloButton.Checked = True
            Case 4
                IconPictureBox.Image = My.Resources.AleVag_Big
                Me.Icon = My.Resources.AleVag
                SysTrayIcon.Icon = My.Resources.AleVag
                AleNSFWButton.Checked = True
            Case 5
                IconPictureBox.Image = My.Resources.VeloVag_Big
                Me.Icon = My.Resources.VeloVag
                SysTrayIcon.Icon = My.Resources.VeloVag
                VeloNSFWButton.Checked = True
        End Select
    End Sub

    Private Sub SysTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SysTrayIcon.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If My.Settings.SysTray = 1 Then
            If WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                SysTrayIcon.Visible = True
                SysTrayIcon.ShowBalloonTip(1, "VisCord - Notification", "VisCord is now running in the background.", ToolTipIcon.Info)
                GC.Collect()
            End If
        ElseIf My.Settings.SysTray = 0 Then
            GC.Collect()
        End If
    End Sub

    Private Sub ContentTimer_Tick(sender As Object, e As EventArgs) Handles ContentTimer.Tick

        'Attempt to update window title to match area of Discord. 
        Try
            If WebView21.CoreWebView2.DocumentTitle = "" Then
                WebView21.Visible = False
                Me.Text = "Initialising... - VisCord"
                SysTrayIcon.Text = "Initialising... - VisCord"
                Thread.Sleep(1000)
            Else
                WebView21.Visible = True
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                If WebView21.CoreWebView2.DocumentTitle = "Discord" Then
                    AreaLabel.Text = ""
                Else
                    AreaLabel.Text = "- " + WebView21.CoreWebView2.DocumentTitle
                End If

            End If

            'Check if user is on the settings area of Discord.
            If Me.Text.Contains("User Settings") Then
                VisCordSettings.Visible = True
            Else
                VisCordSettings.Visible = False
            End If

            'Ping user if message is detected.
            If My.Settings.Notify = 1 Then
                Ping()
                If Me.WindowState = FormWindowState.Minimized Then
                    Ping()
                End If
            End If

            'Check if user is on a NSFW area.
            If My.Settings.NSFWContent = 1 Then
                If Me.Text.Contains("nsfw") Then
                    WebView21.CoreWebView2.Navigate("https://discord.com/app")
                End If
            Else
            End If
            'Make sure title bar is visible.
            TitlePanel.Visible = True

            'Check WebView2 history for back/forward buttons.
            If WebView21.CoreWebView2.CanGoBack = True Then
                BackButton.Enabled = True
            Else
                BackButton.Enabled = False
            End If

            If WebView21.CoreWebView2.CanGoForward = True Then
                ForwardButton.Enabled = True
            Else
                ForwardButton.Enabled = False
            End If
        Catch

        End Try
    End Sub

    Private Sub StartupCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles StartupCheckbox.CheckedChanged
        If StartupCheckbox.Checked = True Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            My.Settings.Startup = 1
        Else
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            My.Settings.Startup = 0
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Startup settings.
        If My.Settings.Startup = 0 Then
            StartupCheckbox.Checked = False
        Else
            StartupCheckbox.Checked = True
        End If

        'Load System Tray Settings.
        If My.Settings.SysTray = 0 Then
            SysTrayCheckbox.Checked = False
        Else
            SysTrayCheckbox.Checked = True
        End If

        'Load Notification Badge settings.
        If My.Settings.NotifBadge = 0 Then
            BadgeCheckbox.Checked = False
        Else
            BadgeCheckbox.Checked = True
        End If

        'Load Notification settings.
        If My.Settings.Notify = 0 Then
            NotifyCheckbox.Checked = False
        Else
            NotifyCheckbox.Checked = True
        End If

        If My.Settings.HA = 1 Then
            HardwareCheckbox.Checked = True
        Else
            HardwareCheckbox.Checked = False
        End If

        If My.Settings.OpenExternal = 1 Then
            NavCheckbox.Checked = True
        Else
            NavCheckbox.Checked = False
        End If

        If My.Settings.EnableNetwork = 1 Then
            NetworkCheckbox.Checked = True
        Else
            NetworkCheckbox.Checked = False
        End If

        'Load NSFW icon settings.
        If My.Settings.NSFWIcon = 1 Then
            NSFWCheckbox.Checked = True
            AleNSFWButton.Enabled = True
            VeloNSFWButton.Enabled = True
        Else
            NSFWCheckbox.Checked = False
            AleNSFWButton.Enabled = False
            VeloNSFWButton.Enabled = False
        End If

        'Load NSFW content settings.
        If My.Settings.NSFWContent = 1 Then
            NSFWContentChecbox.Checked = True
        Else
            NSFWContentChecbox.Checked = False
        End If

        'Load correct icon.
        UpdateIcon()
    End Sub

    Private Sub SysTrayCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles SysTrayCheckbox.CheckedChanged
        If SysTrayCheckbox.Checked = True Then
            My.Settings.SysTray = 1
        Else
            My.Settings.SysTray = 0
        End If
    End Sub

    Private Sub BadgeCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles BadgeCheckbox.CheckedChanged
        If BadgeCheckbox.Checked = True Then
            My.Settings.NotifBadge = 1
            If Me.Text.Contains("(") Then
                UpdateBadge()
            End If
        Else
            My.Settings.NotifBadge = 0
            UpdateIcon()
        End If
    End Sub

    Private Sub NotifyCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NotifyCheckbox.CheckedChanged
        If NotifyCheckbox.Checked = True Then
            My.Settings.Notify = 1
        Else
            My.Settings.Notify = 0
        End If
    End Sub

    Private Sub NotifTimer_Tick(sender As Object, e As EventArgs) Handles NotifTimer.Tick
        Try
            If Me.Text.Contains("(") Then
                UpdateBadge()
            End If
        Catch
        End Try

        If Me.Focused = True Then
            If Not Me.Text.Contains("(") Then
                ContentTimer.Start()
            End If
        End If
    End Sub

    Private Sub FixTitle_Tick(sender As Object, e As EventArgs) Handles FixTitle.Tick
        Try
            If Me.WindowState = FormWindowState.Minimized = False Then
                If Me.Text.Contains("Discord") Then
                    UpdateIcon()
                    ContentTimer.Start()
                End If

                If Not Me.WebView21.CoreWebView2.DocumentTitle.Contains("(") Then
                    Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                    SysTrayIcon.Text = "VisCord"
                    UpdateIcon()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub CacheButton_Click(sender As Object, e As EventArgs) Handles CacheButton.Click
        If MsgBox("Would you like to clear VisCord's cache? It may take a while for VisCord to reload fully and you may be logged out of Discord.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            WebView21.CoreWebView2.Profile.ClearBrowsingDataAsync()
            WebView21.Reload()
        End If
    End Sub

    Private Sub DataButton_Click(sender As Object, e As EventArgs) Handles DataButton.Click
        If MsgBox("Would you like to clear VisCord's user data? You may be logged out of Discord.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            WebView21.CoreWebView2.ExecuteScriptAsync("javascript:localStorage.clear()")
            WebView21.Reload()
        End If
    End Sub

    Private Sub HardwareCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles HardwareCheckbox.CheckedChanged
        Try
            If HardwareCheckbox.Checked = True Then
                My.Settings.HA = 1
                WebView21.Reload()
            Else
                My.Settings.HA = 0
                WebView21.Reload()
            End If
        Catch
        End Try
    End Sub

    Private Sub WebView21_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
        If Not e.Uri.Contains("discord.com") Then
            e.Cancel = True
            OpenInExternalBrowser(e.Uri)
        End If
    End Sub

    Private Sub OpenInExternalBrowser(url As String)
        Try
            Dim psi As New ProcessStartInfo(url)
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Unable to open the link in the external browser: " & ex.Message)
        End Try
    End Sub

    Private Sub CoreWebView2_NewWindowRequested(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs)
        If My.Settings.OpenExternal = 0 Then
        Else
            If Not e.Uri.Contains("discord.com") Then
                Dim url As String = WebView21.CoreWebView2.Source
                e.NewWindow = WebView21.CoreWebView2
                e.Handled = True
                WebView21.CoreWebView2.Navigate(url)
            End If
        End If

    End Sub

    Private Sub NavCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NavCheckbox.CheckedChanged
        If NavCheckbox.Checked = True Then
            My.Settings.OpenExternal = 1
        Else
            My.Settings.OpenExternal = 0
        End If
    End Sub

    Private Sub AboutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutLink.LinkClicked
        About.labelVersion.Text = "VisCord " + My.Application.Info.Version.ToString()
        Select Case My.Settings.Icon
            Case 0
                Dim img As New Bitmap(My.Resources.Discord_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.Discord1
            Case 1
                Dim img As New Bitmap(My.Resources.PDiscord_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.PDiscord
            Case 2
                Dim img As New Bitmap(My.Resources.Alethila_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.Alethila_Discord
            Case 3
                Dim img As New Bitmap(My.Resources.Velo_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.Velo
            Case 4
                Dim img As New Bitmap(My.Resources.AleVag_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.AleVag
            Case 5
                Dim img As New Bitmap(My.Resources.VeloVag_Big)
                About.AppPic.Image = img
                About.Icon = My.Resources.VeloVag
        End Select

        About.ShowDialog()
    End Sub

    Private Sub UserSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserSettingsToolStripMenuItem.Click
        Try
            OpenDiscordSettingsAsync()
        Catch
            MsgBox("Discord is not initialised, please wait to access user settings.")
        End Try
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Async Function OpenDiscordSettingsAsync() As Task
        Await Task.Delay(0)
        Dim js As String = "
    (function(){
      try {
        var sel = '[aria-label=""User Settings""] button, [data-list-item-id=""user-settings""], button[aria-label*=""Settings""]';
        var btn = document.querySelector(sel);
        if(btn){ btn.click(); return 'clicked'; }
        // fallback: try hash route
        location.hash = '/settings';
        return 'fallback';
      } catch(e){ return 'error:'+e.message; }
    })();
    "
        Dim resultJson As String = Await WebView21.CoreWebView2.ExecuteScriptAsync(js)
    End Function

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AboutVisCordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutVisCordToolStripMenuItem.Click
        About.labelVersion.Text = "VisCord " + My.Application.Info.Version.ToString()
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Would you like to exit VisCord?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        WebView21.CoreWebView2.Profile.ClearBrowsingDataAsync()
        WebView21.Reload()
    End Sub

    Private Sub CFULink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CFULink.LinkClicked
        Process.Start("https://github.com/windowslogic/VisCord/releases")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        WebView21.CoreWebView2.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        WebView21.CoreWebView2.GoForward()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Process.Start("https://support.discord.com/")
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.discord.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
            Main.VisCordSettings.Visible = True
        End Try
    End Function

    Private Sub NetworkCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NetworkCheckbox.CheckedChanged
        If NetworkCheckbox.Checked = True Then
            My.Settings.EnableNetwork = 1
            WebView21.Visible = True
            VisCordSettings.Visible = False
            OfflinePanel.Visible = False
            HelpButton.Enabled = True
            ContentTimer.Start()
            NotifTimer.Start()
            FixTitle.Start()
            OpenDiscordSettingsAsync()
        Else
            My.Settings.EnableNetwork = 0
            WebView21.Visible = False
            VisCordSettings.Visible = True
            OfflinePanel.Visible = True
            Me.Text = "Offline Mode - VisCord"
            AreaLabel.Text = ""
            HelpButton.Enabled = False
            ContentTimer.Stop()
            NotifTimer.Stop()
            FixTitle.Stop()
        End If
    End Sub

    Private Sub DiscordButton_CheckedChanged(sender As Object, e As EventArgs) Handles DiscordButton.CheckedChanged
        If DiscordButton.Checked = True Then
            My.Settings.Icon = 0
            UpdateIcon()
        End If
    End Sub

    Private Sub PokemonButton_CheckedChanged(sender As Object, e As EventArgs) Handles PokemonButton.CheckedChanged
        If PokemonButton.Checked = True Then
            My.Settings.Icon = 1
            UpdateIcon()
        End If
    End Sub

    Private Sub AleButton_CheckedChanged(sender As Object, e As EventArgs) Handles AleButton.CheckedChanged
        If AleButton.Checked = True Then
            My.Settings.Icon = 2
            UpdateIcon()
        End If
    End Sub

    Private Sub NSFWCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NSFWCheckbox.CheckedChanged
        If NSFWCheckbox.Checked = True Then
            My.Settings.NSFWIcon = 1
            AleNSFWButton.Enabled = True
            VeloNSFWButton.Enabled = True
        Else
            My.Settings.NSFWIcon = 0
            AleNSFWButton.Enabled = False
            VeloNSFWButton.Enabled = False
        End If
    End Sub

    Private Sub VeloButton_CheckedChanged(sender As Object, e As EventArgs) Handles VeloButton.CheckedChanged
        If VeloButton.Checked = True Then
            My.Settings.Icon = 3
            UpdateIcon()
        End If
    End Sub

    Private Sub AleNSFWButton_CheckedChanged(sender As Object, e As EventArgs) Handles AleNSFWButton.CheckedChanged
        If AleNSFWButton.Checked = True Then
            My.Settings.Icon = 4
            UpdateIcon()
        End If
    End Sub

    Private Sub VeloNSFWButton_CheckedChanged(sender As Object, e As EventArgs) Handles VeloNSFWButton.CheckedChanged
        If VeloNSFWButton.Checked = True Then
            My.Settings.Icon = 5
            UpdateIcon()
        End If
    End Sub

    Private Sub ToolboxButton_Click(sender As Object, e As EventArgs) Handles ToolboxButton.Click
        If ToolPanel.Visible = True Then
            ToolPanel.Visible = False
        Else
            ToolPanel.Visible = True
        End If
    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click
        ToolPanel.Visible = False
    End Sub

    Private Sub TitlePanel_Click(sender As Object, e As EventArgs) Handles TitlePanel.Click
        ToolPanel.Visible = False
    End Sub

    Private Async Function LoadJS() As Task
        Await Task.Delay(0)
        Dim js As String = My.Settings.AddNavJS
        Dim resultJson As String = Await WebView21.CoreWebView2.ExecuteScriptAsync(js)
    End Function

    Private Sub JSButton_Click(sender As Object, e As EventArgs) Handles JSButton.Click
        ToolPanel.Visible = False
        Injection.ShowDialog()
    End Sub

    Private Sub Main_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ToolPanel.Visible = False
    End Sub

    Private Sub IconPictureBox_Click(sender As Object, e As EventArgs) Handles IconPictureBox.Click
        ToolPanel.Visible = False
    End Sub

    Private Sub OfflinePanel_Click(sender As Object, e As EventArgs) Handles OfflinePanel.Click
        ToolPanel.Visible = False
    End Sub

    Private Sub OfflineLabel_Click(sender As Object, e As EventArgs) Handles OfflineLabel.Click
        ToolPanel.Visible = False
    End Sub

    Private Sub NSFWContentChecbox_CheckedChanged(sender As Object, e As EventArgs) Handles NSFWContentChecbox.CheckedChanged
        If NSFWContentChecbox.Checked = True Then
            My.Settings.NSFWContent = 1
        Else
            My.Settings.NSFWContent = 0
        End If
    End Sub
End Class