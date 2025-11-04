Public Class AddPins
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If Me.Text.Contains(Pins.PinView1.Columns(0).Text) Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Pins.PinView1.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Pins.PinView1.Items.Add(addlist1)
                Me.Close()
            End If
        ElseIf Me.Text.Contains(Pins.pinview2.columns(0).text) Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Pins.PinView2.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Pins.PinView2.Items.Add(addlist1)
                Me.Close()
            End If
        ElseIf Me.Text.Contains(Pins.PinView3.Columns(0).text) Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Pins.PinView3.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Pins.PinView3.Items.Add(addlist1)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class