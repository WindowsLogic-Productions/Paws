Public Class AddPins
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If Me.Text = "Add To List: " + Recommended.PinView1.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Recommended.PinView1.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Recommended.PinView1.Items.Add(addlist1)
                Me.Close()
            End If
        ElseIf Me.Text = "Add To List: " + Recommended.PinView2.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Recommended.PinView2.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Recommended.PinView2.Items.Add(addlist1)
                Me.Close()
            End If
        ElseIf Me.Text = "Add To List: " + Recommended.PinView3.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom name cannot be blank.")
            ElseIf Me.Text.Contains(Recommended.PinView3.Columns(0).Text) Then
                Dim addlist1 As New ListViewItem(TextBox2.Text)
                addlist1.SubItems.Add(Main.WebView21.CoreWebView2.Source)
                Recommended.PinView3.Items.Add(addlist1)
                Me.Close()
            End If
        ElseIf Me.Text = "Rename: " & Recommended.PinView1.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom list name cannot be blank.")
            Else
                Recommended.PinView1.Columns(0).Text = TextBox2.Text
                Me.Close()
            End If
        ElseIf Me.Text = "Rename: " & Recommended.PinView2.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom list name cannot be blank.")
            Else
                Recommended.PinView2.Columns(0).Text = TextBox2.Text
                Me.Close()
            End If
        ElseIf Me.Text = "Rename: " & Recommended.PinView3.Columns(0).Text Then
            If TextBox2.Text = "" Then
                MsgBox("The custom list name cannot be blank.")
            Else
                Recommended.PinView3.Columns(0).Text = TextBox2.Text
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class