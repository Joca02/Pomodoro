Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerisi.Click
        If Val(txtSek.Text) > 60 Or Val(txtSekP.Text) > 60 Then
            MessageBox.Show("Sekunde moraju biti u opsegu 0-60 !")
        Else
            Form2.Show()
        End If
    End Sub

    Private Sub klik_forme1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub txtMin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMin.MouseClick
        txtMin.Text = ""
    End Sub

    Private Sub txtSek_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSek.MouseClick
        txtSek.Text = ""
    End Sub

    Private Sub txtMinP_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMinP.MouseClick
        txtMinP.Text = ""
    End Sub

    Private Sub txtSekP_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSekP.MouseClick
        txtSekP.Text = ""
    End Sub
End Class
