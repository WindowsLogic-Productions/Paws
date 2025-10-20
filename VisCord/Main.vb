Imports System.Threading
Imports Microsoft.Web.WebView2.Core

Public Class Main

    Private initialUrl As String = "https://discord.com/app"

    Private Async Sub InitialiseWebView()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
        AddHandler WebView21.CoreWebView2.NavigationStarting, AddressOf WebView21_NavigationStarting
        WebView21.Source = New Uri(initialUrl)
    End Sub

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
    End Sub

    Private Sub Ping()
        For val As Integer = 0 To 1
            If WebView21.CoreWebView2.DocumentTitle.Contains("(") Then
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                SysTrayIcon.ShowBalloonTip(1, "VisCord - Notification", "You have unread messages.", ToolTipIcon.Info)
                Me.Text = "New messages - VisCord"
                SysTrayIcon.Text = "New messages - VisCord"
                If My.Settings.NotifBadge = 1 Then
                    SysTrayIcon.Icon = My.Resources.DiscordNotif
                    Me.Icon = My.Resources.DiscordNotif
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
            SysTrayIcon.Icon = My.Resources.DiscordNotif
            Me.Icon = My.Resources.DiscordNotif
        End If
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
                Me.Text = "Initialising... - VisCord"
                SysTrayIcon.Text = "Initialising... - VisCord"
            Else
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
            End If


            If Me.Text.Contains("Settings") Then
                Panel1.Visible = True
            Else
                Panel1.Visible = False
            End If

            If My.Settings.Notify = 1 Then
                Ping()
                If Me.WindowState = FormWindowState.Minimized Then
                    Ping()
                End If
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
            SysTrayIcon.Icon = My.Resources.Discord1
            Me.Icon = My.Resources.Discord1
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
                    SysTrayIcon.Icon = My.Resources.Discord1
                    Me.Icon = My.Resources.Discord1
                    ContentTimer.Start()
                End If

                If Not Me.WebView21.CoreWebView2.DocumentTitle.Contains("(") Then
                    Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                    SysTrayIcon.Text = "VisCord"
                    SysTrayIcon.Icon = My.Resources.Discord1
                    Me.Icon = My.Resources.Discord1
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
                e.NewWindow = WebView21.CoreWebView2
                e.Handled = True
                WebView21.CoreWebView2.Navigate("https://discord.com/app")
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
End Class
