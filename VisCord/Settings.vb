Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeneralPanel.Show()
        GeneralPanel.BringToFront()
        NotifPanel.Hide()
        NavigationPanel.Hide()
        PersonalisePanel.Hide()
        AdvancedPanel.Hide()
        GeneralButton.BackColor = Color.FromArgb(255, 82, 82, 82)
        NotifButton.BackColor = Color.Transparent()
        NavButton.BackColor = Color.Transparent()
        PersonaliseButton.BackColor = Color.Transparent()
        AdvButton.BackColor = Color.Transparent()

        'Load Startup settings.
        If My.Settings.Startup = 0 Then
            StartupCheckbox.Checked = False
        Else
            StartupCheckbox.Checked = True
        End If

        'Load close button settings.
        If My.Settings.CloseMinimise = 0 Then
            CMCheckBox.Checked = False
        Else
            CMCheckBox.Checked = True
        End If

        'Load online mode settings.
        If My.Settings.EnableNetwork = 0 Then
            NetworkCheckbox.Checked = False
        Else
            NetworkCheckbox.Checked = True
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

        If My.Settings.OpenExternal = 1 Then
            NavCheckbox.Checked = True
        Else
            NavCheckbox.Checked = False
        End If

        'Load update settings.
        If My.Settings.Updates = 1 Then
            UpdatesCheckbox.Checked = True
        Else
            UpdatesCheckbox.Checked = False
        End If

        'Load NSFW icon settings.
        If My.Settings.NSFWFeatures = 1 Then
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

        'Load outbox items.
        OutboxView.Items.Clear()

        Dim savedData As String = My.Settings.OutboxList

        If Not String.IsNullOrEmpty(savedData) Then
            Dim OutboxItems As String() = savedData.Split(";"c)

            For Each OutboxItem As String In OutboxItems
                Dim OutboxParts As String() = OutboxItem.Split("|"c)

                If OutboxParts.Length > 0 Then
                    Dim listItem As New ListViewItem(OutboxParts(0))

                    If OutboxParts.Length > 1 Then
                        Dim subItems As String() = OutboxParts(1).Split(";"c)

                        For Each subItem As String In subItems
                            listItem.SubItems.Add(subItem.Trim())
                        Next
                    End If

                    OutboxView.Items.Add(listItem)
                End If
            Next
        Else
        End If

        'Load random tip settings.
        If My.Settings.AleTips = 1 Then
            TipCheckBox.Checked = True
        Else
            TipCheckBox.Checked = False
        End If

        'Load personalisation settings.
        Select Case My.Settings.Icon
            Case 0
                DiscordButton.Checked = True
            Case 1
                PokemonButton.Checked = True
            Case 2
                AleButton.Checked = True
            Case 3
                VeloButton.Checked = True
            Case 4
                AleNSFWButton.Checked = True
            Case 5
                VeloNSFWButton.Checked = True
        End Select
    End Sub
#Region "Buttons"
    Private Sub GeneralButton_Click(sender As Object, e As EventArgs) Handles GeneralButton.Click
        GeneralPanel.Show()
        GeneralPanel.BringToFront()
        NotifPanel.Hide()
        NavigationPanel.Hide()
        PersonalisePanel.Hide()
        AdvancedPanel.Hide()
        GeneralButton.BackColor = Color.FromArgb(255, 82, 82, 82)
        NotifButton.BackColor = Color.Transparent()
        NavButton.BackColor = Color.Transparent()
        PersonaliseButton.BackColor = Color.Transparent()
        AdvButton.BackColor = Color.Transparent()
    End Sub

    Private Sub NotifButton_Click(sender As Object, e As EventArgs) Handles NotifButton.Click
        GeneralPanel.Hide()
        NotifPanel.Show()
        NotifPanel.BringToFront()
        NavigationPanel.Hide()
        PersonalisePanel.Hide()
        AdvancedPanel.Hide()
        GeneralButton.BackColor = Color.Transparent()
        NotifButton.BackColor = Color.FromArgb(255, 82, 82, 82)
        NavButton.BackColor = Color.Transparent()
        PersonaliseButton.BackColor = Color.Transparent()
        AdvButton.BackColor = Color.Transparent()
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs) Handles NavButton.Click
        GeneralPanel.Hide()
        NotifPanel.Hide()
        NavigationPanel.Show()
        NavigationPanel.BringToFront()
        PersonalisePanel.Hide()
        AdvancedPanel.Hide()
        GeneralButton.BackColor = Color.Transparent()
        NotifButton.BackColor = Color.Transparent()
        NavButton.BackColor = Color.FromArgb(255, 82, 82, 82)
        PersonaliseButton.BackColor = Color.Transparent()
        AdvButton.BackColor = Color.Transparent()
    End Sub

    Private Sub PersonaliseButton_Click(sender As Object, e As EventArgs) Handles PersonaliseButton.Click
        GeneralPanel.Hide()
        NotifPanel.Hide()
        NavigationPanel.Hide()
        PersonalisePanel.Show()
        PersonalisePanel.BringToFront()
        AdvancedPanel.Hide()
        GeneralButton.BackColor = Color.Transparent()
        NotifButton.BackColor = Color.Transparent()
        NavButton.BackColor = Color.Transparent()
        PersonaliseButton.BackColor = Color.FromArgb(255, 82, 82, 82)
        AdvButton.BackColor = Color.Transparent()
    End Sub

    Private Sub AdvButton_Click(sender As Object, e As EventArgs) Handles AdvButton.Click
        GeneralPanel.Hide()
        NotifPanel.Hide()
        NavigationPanel.Hide()
        PersonalisePanel.Hide()
        AdvancedPanel.Show()
        AdvancedPanel.BringToFront()
        GeneralButton.BackColor = Color.Transparent()
        NotifButton.BackColor = Color.Transparent()
        NavButton.BackColor = Color.Transparent()
        PersonaliseButton.BackColor = Color.Transparent()
        AdvButton.BackColor = Color.FromArgb(255, 82, 82, 82)
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
#End Region
#Region "General"
    Private Sub StartupCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles StartupCheckbox.CheckedChanged
        If StartupCheckbox.Checked = True Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            My.Settings.Startup = 1
        Else
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            My.Settings.Startup = 0
        End If
    End Sub

    Private Sub TipCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TipCheckBox.CheckedChanged
        If TipCheckBox.Checked = True Then
            My.Settings.AleTips = 1
        Else
            My.Settings.AleTips = 0
        End If
    End Sub

    Private Sub SysTrayCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles SysTrayCheckbox.CheckedChanged
        If SysTrayCheckbox.Checked = True Then
            My.Settings.SysTray = 1
        Else
            My.Settings.SysTray = 0
        End If
    End Sub

    Private Sub OutboxView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles OutboxView.MouseDoubleClick
        Dim lvi As ListViewItem = OutboxView.HitTest(e.Location).Item
        If lvi IsNot Nothing Then
            Dim ItemText As String
            ItemText = OutboxView.Items(OutboxView.FocusedItem.Index).SubItems(0).Text
            Clipboard.SetText(ItemText)
        End If
    End Sub

    Private Sub NewMessageLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NewMessageLink.LinkClicked
        SendOfflineMessage.ShowDialog()
    End Sub

    Private Sub DeleteMessageLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteMessageLink.LinkClicked
        Dim obi As ListViewItem
        Dim obn As String
        For Each obi In OutboxView.Items
            OutboxView.Items.Remove(obi)
            Exit For
        Next
    End Sub

    Private Sub ClearOutboxLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClearOutboxLink.LinkClicked
        OutboxView.Items.Clear()
    End Sub
#End Region
#Region "Notification"
    Private Sub BadgeCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles BadgeCheckbox.CheckedChanged
        If BadgeCheckbox.Checked = True Then
            My.Settings.NotifBadge = 1
            If Me.Text.Contains("(") Then
                Variables.UpdateBadge()
            End If
        Else
            My.Settings.NotifBadge = 0
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub NotifyCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NotifyCheckbox.CheckedChanged
        If NotifyCheckbox.Checked = True Then
            My.Settings.Notify = 1
        Else
            My.Settings.Notify = 0
        End If
    End Sub
#End Region
#Region "Navigation"
    Private Sub NetworkCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NetworkCheckbox.CheckedChanged
        If NetworkCheckbox.Checked = True Then
            My.Settings.EnableNetwork = 1
            Main.WebView21.Visible = True
            Main.OfflinePanel.Visible = False
            Main.BackButton.Enabled = True
            Main.ForwardButton.Enabled = True
            Main.HelpButton.Enabled = True
            Main.ContentTimer.Start()
            Main.NotifTimer.Start()
            Main.FixTitle.Start()
        Else
            My.Settings.EnableNetwork = 0
            Main.WebView21.Visible = False
            Main.OfflinePanel.Visible = True
            Main.Text = "Offline Mode - VisCord"
            Main.AreaLabel.Text = ""
            Main.BackButton.Enabled = False
            Main.ForwardButton.Enabled = False
            Main.HelpButton.Enabled = False
            Main.ContentTimer.Stop()
            Main.NotifTimer.Stop()
            Main.FixTitle.Stop()
            If Main.CheckForInternetConnection() = True Then
                Main.ReloadLink.Enabled = False
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

    Private Sub JSButton_Click(sender As Object, e As EventArgs) Handles JSButton.Click
        Injection.ShowDialog()
    End Sub

    Private Sub NSFWContentChecbox_CheckedChanged(sender As Object, e As EventArgs) Handles NSFWContentChecbox.CheckedChanged
        If NSFWContentChecbox.Checked = True Then
            My.Settings.NSFWContent = 1
        Else
            My.Settings.NSFWContent = 0
        End If
    End Sub

    Private Sub HideNavBarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HideNavBarCheckBox.CheckedChanged
        If HideNavBarCheckBox.Checked = True Then
            My.Settings.HideNav = 1
            Main.TitlePanel.Hide()
        Else
            My.Settings.HideNav = 0
            Main.TitlePanel.Show()
        End If
    End Sub
#End Region
#Region "Personalise"
    Private Sub DiscordButton_CheckedChanged(sender As Object, e As EventArgs) Handles DiscordButton.CheckedChanged
        If DiscordButton.Checked = True Then
            My.Settings.Icon = 0
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub PokemonButton_CheckedChanged(sender As Object, e As EventArgs) Handles PokemonButton.CheckedChanged
        If PokemonButton.Checked = True Then
            My.Settings.Icon = 1
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub AleButton_CheckedChanged(sender As Object, e As EventArgs) Handles AleButton.CheckedChanged
        If AleButton.Checked = True Then
            My.Settings.Icon = 2
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub VeloButton_CheckedChanged(sender As Object, e As EventArgs) Handles VeloButton.CheckedChanged
        If VeloButton.Checked = True Then
            My.Settings.Icon = 3
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub AleNSFWButton_CheckedChanged(sender As Object, e As EventArgs) Handles AleNSFWButton.CheckedChanged
        If AleNSFWButton.Checked = True Then
            My.Settings.Icon = 4
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub VeloNSFWButton_CheckedChanged(sender As Object, e As EventArgs) Handles VeloNSFWButton.CheckedChanged
        If VeloNSFWButton.Checked = True Then
            My.Settings.Icon = 5
            Variables.UpdateIcon()
        End If
    End Sub

    Private Sub NSFWCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NSFWCheckbox.CheckedChanged
        If NSFWCheckbox.Checked = True Then
            My.Settings.NSFWFeatures = 1
            AleNSFWButton.Enabled = True
            VeloNSFWButton.Enabled = True
        Else
            My.Settings.NSFWFeatures = 0
            AleNSFWButton.Enabled = False
            VeloNSFWButton.Enabled = False
        End If
    End Sub
#End Region
#Region "Advanced"
    Private Sub HardwareCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles HardwareCheckbox.CheckedChanged
        Try
            If HardwareCheckbox.Checked = True Then
                My.Settings.HA = 1
                Main.WebView21.Reload()
            Else
                My.Settings.HA = 0
                Main.WebView21.Reload()
            End If
        Catch
        End Try
    End Sub

    Private Sub CacheButton_Click(sender As Object, e As EventArgs) Handles CacheButton.Click
        If MsgBox("Would you like to clear VisCord's cache? It may take a while for VisCord to reload fully and you may be logged out of Discord.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.WebView21.CoreWebView2.Profile.ClearBrowsingDataAsync()
            Main.WebView21.Reload()
        End If
    End Sub

    Private Sub DataButton_Click(sender As Object, e As EventArgs) Handles DataButton.Click
        If MsgBox("Would you like to clear VisCord's user data? You may be logged out of Discord.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.WebView21.CoreWebView2.ExecuteScriptAsync("javascript:localStorage.clear()")
            Main.WebView21.Reload()
        End If
    End Sub

    Private Sub UpdatesCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles UpdatesCheckbox.CheckedChanged
        If UpdatesCheckbox.Checked = True Then
            My.Settings.Updates = 1
        Else
            My.Settings.Updates = 0
        End If
    End Sub

    Private Sub CFUButton_Click(sender As Object, e As EventArgs) Handles CFUButton.Click
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                MsgBox("You're on the latest version.", MsgBoxStyle.Information, "Check For Updates")
            Else
                UpdaterPrompt.ShowDialog()
            End If

        Catch
            MsgBox("No connection to update server.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CMCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CMCheckBox.CheckedChanged
        If CMCheckBox.Checked = True Then
            My.Settings.CloseMinimise = 1
        Else
            My.Settings.CloseMinimise = 0
        End If
    End Sub
#End Region
End Class