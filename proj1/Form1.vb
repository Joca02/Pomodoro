

Public Class Form1

    Dim min_work As Integer = 1
    Dim sek As Integer = 60
    Dim min_pause As Integer = 0
    Dim chk As Boolean = True
    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick

        sek -= 1

        If chk = True Then

            If min_work > 1 And sek = 0 Then
                min_work -= 1
                sek = 60
            End If
            If min_work = 1 And sek = 0 Then
                My.Computer.Audio.Play("C:\Users\pc\Desktop\sewy.wav")
                min_pause = 5
                sek = 60
                chk = False
            End If
            If min_work - 10 < 1 And sek - 10 < 0 Then
                lblTimer.Text = "0" + $"{min_work - 1}" + ":0" + $"{sek}"
            ElseIf min_work - 10 < 1 Then
                lblTimer.Text = "0" + $"{min_work - 1}" + ":" + $"{sek}"
            ElseIf sek - 10 < 0 Then
                lblTimer.Text = $"{min_work - 1}" + ":0" + $"{sek}"
            Else
                lblTimer.Text = $"{min_work}" + ":" + $"{sek}"
            End If
        Else

            If min_pause > 1 And sek = 0 Then
                min_pause -= 1
                sek = 60
            End If
            If min_pause = 1 And sek = 0 Then
                My.Computer.Audio.Play("C:\Users\pc\Desktop\sewy.wav")
                chk = True
                sek = 60
                min_work = 2
            End If

            If min_pause - 10 < 1 And sek - 10 < 0 Then
                lblTimer.Text = "0" + $"{min_pause - 1}" + ":0" + $"{sek}"
            ElseIf min_pause - 10 < 1 Then
                lblTimer.Text = "0" + $"{min_pause - 1}" + ":" + $"{sek}"
            ElseIf sek - 10 < 0 Then
                lblTimer.Text = $"{min_pause - 1}" + ":0" + $"{sek}"
            Else
                lblTimer.Text = $"{min_pause - 1}" + ":" + $"{sek}"
            End If

        End If


    End Sub

    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        'If Me.WindowState = WindowState.Maximized Then
        '    lblTimer.Font = New Font("Century Schoolbook", 150, FontStyle.Bold)
        '    btnPlay.Font = New Font("Yu Gothic UI", 35, FontStyle.Regular)
        '    btnPlay.Height += 20
        'Else
        '    lblTimer.Font = New Font("Century Schoolbook", 64, FontStyle.Bold)
        '    btnPlay.Font = New Font("Yu Gothic UI", 16, FontStyle.Regular)
        '    btnPlay.Height -= 20
        'End If
        lblTimer.Top = Me.ClientSize.Height / 3
        lblTimer.Left = Me.ClientSize.Width / 2 - lblTimer.Width / 2
        btnPlay.Width = Me.ClientSize.Width / 2
        btnPlay.Top = Me.ClientSize.Height - 2 * btnPlay.Height
        btnPlay.Left = Me.ClientSize.Width / 2 - btnPlay.Width / 2

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTimer.Text = $"{min_work}" + ":00"
        lblTimer.Top = Me.ClientSize.Height / 3
        lblTimer.Left = Me.ClientSize.Width / 2 - lblTimer.Width / 2 - 20
        btnPlay.Width = Me.ClientSize.Width / 2
        btnPlay.Height = 70
        btnPlay.Top = Me.ClientSize.Height - 2 * btnPlay.Height
        btnPlay.Left = Me.ClientSize.Width / 2 - btnPlay.Width / 2
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If tmr.Enabled Then
            tmr.Enabled = False
        Else
            tmr.Enabled = True
        End If
    End Sub


End Class
