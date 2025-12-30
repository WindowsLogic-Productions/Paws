Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Threading
Imports Microsoft.Web.WebView2.Core

Public Class Main
#Region "Load Settings"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check for updates.
        CheckForIllegalCrossThreadCalls = False
        Variables.Update_Settings()

        'Load correct icon.
        Variables.UpdateIcon()

        'Preload hardware support.
        If My.Settings.HA = 1 Then
            Settings.HardwareCheckbox.Checked = True
        Else
            Settings.HardwareCheckbox.Checked = False
        End If

        'Load random tip.
        If My.Settings.AleTips = 1 Then
            TipPic.Visible = True
            TipLabel.Visible = True
            If My.Settings.NSFWFeatures = 1 Then
                Dim lewdrand As New Random
                Select Case lewdrand.Next(1, 6)
                    Case 1
                        TipLabel.Text = "A single human male produces enough sperm in two weeks to impregnate every fertile woman on the planet."
                    Case 2
                        TipLabel.Text = "A single sperm contains 37.5 MB of DNA information. One ejaculation represents a data transfer of 15,875 GB."
                    Case 3
                        TipLabel.Text = "The clitoris is the only organ in the body solely dedicated to pleasure."
                    Case 4
                        TipLabel.Text = "84 percent of women have sex to get their guy to do more around the house."
                    Case 5
                        TipLabel.Text = "Cumming is better for your brain than a game of Sudoku."
                    Case Else
                        TipLabel.Text = "1 of 4 acts of vaginal intercourse are condom protected."
                End Select
            Else
                Dim rand As New Random
                Select Case rand.Next(1, 6)
                    Case 1
                        TipLabel.Text = "Tip: If VisCord isn't running as fast as it used to, you can clear cache via the VisCord Settings."
                    Case 2
                        TipLabel.Text = "Tip: You can set custom JavaScript to run at startup via the VisCord Toolbox."
                    Case 3
                        TipLabel.Text = "Tip: You can access your Discord user settings via the system tray menu."
                    Case 4
                        TipLabel.Text = "Tip: Choose from a selection of app icons to use in the VisCord Settings."
                    Case 5
                        TipLabel.Text = "Tip: You can send important messages to the outbox when offline."
                    Case Else

                End Select
            End If
        Else
            TipPic.Visible = False
            TipLabel.Visible = False
        End If

        'Check Windows version.
        If My.Computer.Info.OSVersion.Contains("6.1") Then
            Me.Hide()
            MsgBox("This version of VisCord is incompatible with Windows 7 due to WebView2 no longer being updated for Windows 7." + vbNewLine + vbNewLine + "Please use the Windows 7 version of VisCord.")
            End
        Else

        End If

        'Load outbox data from external file.
        Try
            My.Settings.OutboxList = File.ReadAllText(Application.StartupPath & "\Outbox.vco").ToString()
        Catch
        End Try

        'Load settings from INI file.
        Try

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(2).ToString()

            My.Settings.Startup = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(3).ToString()

            My.Settings.NotifBadge = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(4).ToString()

            My.Settings.AleTips = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(6).ToString()

            My.Settings.SysTray = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(8).ToString()

            My.Settings.Notify = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(10).ToString()

            My.Settings.OpenExternal = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(12).ToString()

            My.Settings.HA = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(13).ToString()

            My.Settings.Updates = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(15).ToString()

            My.Settings.EnableNetwork = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(17).ToString()

            My.Settings.PinList1Name = TextBox1.Text

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(18).ToString()

            My.Settings.PinList2Name = TextBox1.Text

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(19).ToString()

            My.Settings.PinList3Name = TextBox1.Text

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(21).ToString()

            My.Settings.Icon = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(22).ToString()

            My.Settings.NSFWFeatures = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(23).ToString()

            My.Settings.NSFWContent = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(24).ToString()

            My.Settings.HideNav = (Convert.ToInt32(TextBox1.Text))

            TextBox1.Text = File.ReadAllLines(Application.StartupPath & "\VisCord.ini").ElementAt(25).ToString()

            My.Settings.CloseMinimise = (Convert.ToInt32(TextBox1.Text))
        Catch

        End Try
    End Sub
#End Region
#Region "WebView2"
    Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted
        WebView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = False
        WebView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = False
        WebView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = True
        WebView21.CoreWebView2.Settings.AreDevToolsEnabled = False
        WebView21.CoreWebView2.Settings.IsStatusBarEnabled = False
        If My.Settings.HA = 0 Then
            Dim options As New CoreWebView2EnvironmentOptions()
            options.AdditionalBrowserArguments = "--disable-gpu"
        Else
        End If
        AddHandler WebView21.CoreWebView2.NewWindowRequested, AddressOf CoreWebView2_NewWindowRequested

        'Check for Internet connection.
        If My.Settings.EnableNetwork = 1 Then
            If CheckForInternetConnection() = False Then
                Offline()
                ReloadLink.Enabled = True
            End If
        Else
            Offline()
            ReloadLink.Enabled = False
        End If

        NoWVPanel.Visible = False
        LoadJS()
    End Sub

    Private Sub WebView21_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
        If Not e.Uri.Contains("discord.com") Then
            e.Cancel = True
            OpenInExternalBrowser(e.Uri)
        End If

        NoWVPanel.Visible = False
    End Sub

    Private Sub OpenInExternalBrowser(url As String)
        Process.Start(url)
    End Sub

    Private Sub CoreWebView2_NewWindowRequested(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs)
        If My.Settings.OpenExternal = 0 Then
        Else
            If Not e.Uri.Contains("discord.com") Then
                Process.Start(e.Uri)
                e.Handled = True
            End If
        End If
    End Sub
#End Region
#Region "Title Bar"
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        WebView21.CoreWebView2.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        WebView21.CoreWebView2.GoForward()
    End Sub

    Private Sub ToolboxButton_Click(sender As Object, e As EventArgs) Handles ToolboxButton.Click
        Settings.ShowDialog()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Process.Start("https://support.discord.com/")
    End Sub
#End Region
#Region "Offline Mode"
    Private Sub OfflineMessageLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OfflineMessageLink.LinkClicked
        SendOfflineMessage.ShowDialog()
    End Sub

    Private Sub ReloadLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReloadLink.LinkClicked
        If My.Settings.EnableNetwork = 1 Then
            If CheckForInternetConnection() = True Then
                WebView21.CoreWebView2.Navigate("https://discord.com/app")
                WebView21.Visible = True
                OfflinePanel.Visible = False
                HelpButton.Enabled = True
                ContentTimer.Start()
                NotifTimer.Start()
                FixTitle.Start()
            End If
        Else

        End If
    End Sub
#End Region
#Region "System Tray"

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

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub AboutVisCordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutVisCordToolStripMenuItem.Click
        About.labelVersion.Text = "VisCord " + My.Application.Info.Version.ToString()
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Would you like to exit VisCord?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            My.Settings.Save()
            End
        Else
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        WebView21.CoreWebView2.Profile.ClearBrowsingDataAsync()
        WebView21.Reload()
    End Sub
#End Region
#Region "Timers"
    Private Sub ContentTimer_Tick(sender As Object, e As EventArgs) Handles ContentTimer.Tick

        'Attempt to update window title to match area of Discord. 
        Try
            If WebView21.CoreWebView2.DocumentTitle = "" Then
                WebView21.Visible = False
                Me.Text = "Initialising... - VisCord"
                SysTrayIcon.Text = "Initialising... - VisCord"
                Thread.Sleep(1000)
                WebView21.Visible = True
            Else
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                If WebView21.CoreWebView2.DocumentTitle = "Discord" Then
                    AreaLabel.Text = ""
                    WebView21.Visible = True
                Else
                    AreaLabel.Text = "- " + WebView21.CoreWebView2.DocumentTitle
                End If
            End If

            'Ping user if message is detected.
            If My.Settings.Notify = 1 Then
                Ping()
                If Me.WindowState = FormWindowState.Minimized Then
                    Ping()
                End If
            End If

            'Check if user is on friends or DMs.
            If WebView21.CoreWebView2.Source.Contains("@me") Then
                PinsButton.Visible = True
            Else
                PinsButton.Visible = False
            End If

            'Check if user is on a NSFW area.
            If My.Settings.NSFWContent = 1 Then
                If Me.Text.Contains("nsfw") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("lewd") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("horny") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("dungeon") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("adult") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("boobs") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("pussy") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("anal") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("sex") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("hentai") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("yaoi") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("bisexual") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("futa") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("yuri") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("cum") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("squirting") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("tit") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("solo") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("duo") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("shaved") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("milf") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("latina") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("gangbang") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("porn") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("alternative") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("asian") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("bbc") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("bbw") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("ass") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("arse") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("creampie") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("penetration") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("ebony") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("piss") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("bdsm") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("furry") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("breeding") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("cuck") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("hairy") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("pegging") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("femdom") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("pregnant") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("oral") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("feet") Then
                    WebView21.CoreWebView2.GoBack()
                ElseIf Me.Text.Contains("naughty") Then
                    WebView21.CoreWebView2.GoBack()
                End If
            Else
            End If

            'Make sure title bar is following user settings.
            If My.Settings.HideNav = 1 Then
            Else
                TitlePanel.Visible = True
            End If

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

    Private Sub NotifTimer_Tick(sender As Object, e As EventArgs) Handles NotifTimer.Tick
        Try
            If Me.WebView21.CoreWebView2.DocumentTitle.Contains("(1)") Then
                Variables.UpdateBadge()
            End If
        Catch
        End Try

        If Me.Focused = True Then
            If Not Me.WebView21.CoreWebView2.DocumentTitle.Contains("(1)") Then
                ContentTimer.Start()
            End If
        End If
    End Sub

    Private Sub FixTitle_Tick(sender As Object, e As EventArgs) Handles FixTitle.Tick
        Try
            If Me.WindowState = FormWindowState.Minimized = False Then
                If Me.WebView21.CoreWebView2.DocumentTitle.Contains("•") Then
                    Variables.UpdateIcon()
                    ContentTimer.Start()
                End If

                If Not Me.WebView21.CoreWebView2.DocumentTitle.Contains("(1)") Then
                    Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                    SysTrayIcon.Text = "VisCord"
                    Variables.UpdateIcon()
                End If
            End If
        Catch
        End Try
    End Sub
#End Region
#Region "Functions"
    Private Async Function LoadJS() As Task
        Await Task.Delay(0)
        Dim js As String = My.Settings.AddNavJS
        Dim resultJson As String = Await WebView21.CoreWebView2.ExecuteScriptAsync(js)
    End Function

    Private Sub Ping()
        For val As Integer = 0 To 1
            If WebView21.CoreWebView2.DocumentTitle.Contains("❀") Then
                Exit For
            ElseIf WebView21.CoreWebView2.DocumentTitle.Contains("(1)") Then
                Me.Text = WebView21.CoreWebView2.DocumentTitle + " - VisCord"
                SysTrayIcon.ShowBalloonTip(1, "VisCord - Notification", "You have unread messages.", ToolTipIcon.Info)
                Me.Text = "New messages - VisCord"
                SysTrayIcon.Text = "New messages - VisCord"
                If My.Settings.NotifBadge = 1 Then
                    Variables.UpdateBadge()
                End If
            ElseIf Not WebView21.CoreWebView2.DocumentTitle.Contains("(1)") Then
                Exit For
            End If
            If val = 1 Then
                ContentTimer.Stop()
                Exit For
            End If
        Next
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

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.discord.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub Offline()
        WebView21.Visible = False
        OfflinePanel.Visible = True
        Me.Text = "Offline Mode - VisCord"
        AreaLabel.Text = ""
        BackButton.Enabled = False
        ForwardButton.Enabled = False
        HelpButton.Enabled = False
        ContentTimer.Stop()
        NotifTimer.Stop()
        FixTitle.Stop()
    End Sub
#End Region
#Region "Updater"
    Private Sub Updater_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Updater.DoWork
        Try
            BackButton.Enabled = False
            ForwardButton.Enabled = False
            ToolboxButton.Enabled = False
            HelpButton.Enabled = False
            UDLabel.Visible = True
            ProgressBar1.Visible = True
            Dim saveAs As String = "update.exe"
            Dim theResponse As HttpWebResponse
            Dim theRequest As HttpWebRequest
            Try 'Checks if the file exist
                theRequest = WebRequest.Create(Variables.setup)
                theResponse = theRequest.GetResponse
            Catch ex As Exception
                MsgBox("Unable to update at this time.", MsgBoxStyle.Information, "Update Error")
                Exit Sub
            End Try
            Dim length As Long = theResponse.ContentLength
            Dim writeStream As New IO.FileStream(saveAs, IO.FileMode.Create)
            Dim nRead As Long

            Dim speedtimer As New Stopwatch
            Dim currentspeed As Double = -1
            Dim readings As Integer = 0
            Dim speed As String
            Dim updatesize As String

            Do
                speedtimer.Start()
                Dim readBytes(4095) As Byte
                Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
                nRead += bytesread

                Dim percent As Long = (nRead * 100) / length


                If bytesread = 0 Then Exit Do
                writeStream.Write(readBytes, 0, bytesread)

                speedtimer.Stop()

                readings += 1
                If readings >= 5 Then
                    currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                    'speed = Math.Round((currentspeed / 1048576), 2) & " MB/s"
                    updatesize = Math.Round((length / 1048576), 2) & " MB"
                    UDLabel.Text = "Downloading update... " & percent & "% of " & updatesize
                    Updater.ReportProgress(percent)
                    UDLabel.Refresh()
                    speedtimer.Reset()
                    readings = 0
                End If
            Loop
            theResponse.GetResponseStream.Close()
            writeStream.Close()
        Catch
            MsgBox("Connection to the update server has been lost. Please check your Internet connections and/or proxy settings.", MsgBoxStyle.Critical, "Connection Error")
        End Try
    End Sub

    Private Sub Updater_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Updater.RunWorkerCompleted
        Try
            Process.Start("update.exe")
        Catch
            MsgBox("Error starting update process, make sure that the update downloaded properly or any anti-virus hasn't deleted the file.", MsgBoxStyle.Critical, "Update Error")
        End Try
        BackButton.Enabled = True
        ForwardButton.Enabled = True
        ToolboxButton.Enabled = True
        HelpButton.Enabled = True
        UDLabel.Visible = False
        ProgressBar1.Visible = False
        Me.Close()
    End Sub

    Private Sub Updater_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles Updater.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
#End Region
#Region "Closing"
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.CloseMinimise = 1 Then
            Me.WindowState = FormWindowState.Minimized
            e.Cancel = True
        Else
            'Save all user settings to application settings.
            My.Settings.Save()

            'Save outbox to file.
            File.Create(Application.StartupPath & "\Outbox.vco").Dispose()
            System.IO.File.WriteAllText(Application.StartupPath & "\Outbox.vco", "")
            Dim objWriter1 As New System.IO.StreamWriter(Application.StartupPath & "\Outbox.vco", True)
            objWriter1.Write(My.Settings.OutboxList)

            objWriter1.Close()

            'Save all user settings to INI file.
            File.Create(Application.StartupPath & "\VisCord.ini").Dispose()

            System.IO.File.WriteAllText(Application.StartupPath & "\VisCord.ini", "")

            Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\VisCord.ini", True)

            objWriter.WriteLine("[VisCord User Data - " & My.Application.Info.Version.ToString & "]")
            objWriter.WriteLine("[General]")
            objWriter.WriteLine(My.Settings.Startup.ToString())
            objWriter.WriteLine(My.Settings.NotifBadge.ToString())
            objWriter.WriteLine(My.Settings.AleTips.ToString())
            objWriter.WriteLine("[System Tray]")
            objWriter.WriteLine(My.Settings.SysTray.ToString())
            objWriter.WriteLine("[Notifications]")
            objWriter.WriteLine(My.Settings.Notify.ToString())
            objWriter.WriteLine("[Navigation]")
            objWriter.WriteLine(My.Settings.OpenExternal.ToString())
            objWriter.WriteLine("[Performance / Cache / Updates]")
            objWriter.WriteLine(My.Settings.HA.ToString())
            objWriter.WriteLine(My.Settings.Updates.ToString())
            objWriter.WriteLine("[Privacy]")
            objWriter.WriteLine(My.Settings.EnableNetwork.ToString())
            objWriter.WriteLine("[Pin List Names]")
            objWriter.WriteLine(My.Settings.PinList1Name)
            objWriter.WriteLine(My.Settings.PinList2Name)
            objWriter.WriteLine(My.Settings.PinList3Name)
            objWriter.WriteLine("[Other]")
            objWriter.WriteLine(My.Settings.Icon.ToString())
            objWriter.WriteLine(My.Settings.NSFWFeatures.ToString())
            objWriter.WriteLine(My.Settings.NSFWContent.ToString())
            objWriter.WriteLine(My.Settings.HideNav.ToString())
            objWriter.WriteLine(My.Settings.CloseMinimise.ToString())

            objWriter.Close()

            End
        End If
    End Sub

    Private Sub GetWVLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GetWVLink.LinkClicked
        Process.Start("https://developer.microsoft.com/en-us/microsoft-edge/webview2/consumer/")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Text.Contains("Initialising...") Then
            NoWVPanel.Visible = True
            NoWVPanel.BringToFront()
        End If
    End Sub

    Private Sub PinsButton_Click(sender As Object, e As EventArgs) Handles PinsButton.Click
        Pins.Show()
    End Sub

    Private Sub NoWVCloseButton_Click(sender As Object, e As EventArgs) Handles NoWVCloseButton.Click
        NoWVPanel.Hide()
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
#End Region
End Class