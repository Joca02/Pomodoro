
Public Class Form2

    Dim min_work As Integer = Val(Form1.txtMin.Text)
    Dim sek_work As Integer = Val(Form1.txtSek.Text)
    Dim min_pause As Integer = Val(Form1.txtMinP.Text)
    Dim sek_pause As Integer = Val(Form1.txtSekP.Text)
    Dim chk As Boolean = True
    Dim prvi As Boolean = True

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick


        If chk = True Then

            'pokriva mi prvu sekundu pri startu tajmera jer iz nekog razloga pokretanje ima delay
            If prvi = True Then
                If min_work > 0 And sek_work = 0 Then
                    min_work -= 1
                    sek_work = 59
                    prvi = False
                Else
                    sek_work -= 1
                    prvi = False
                End If
            End If

            If min_work = 0 And sek_work = 0 Then
                My.Computer.Audio.Play("C:\Users\pc\Desktop\programiranje\Pomodoro\sewy.wav")
                If def_uslovi(Form1.txtMin, Form1.txtSek, Form1.txtMinP, Form1.txtSekP) = True Then
                    difolt(min_work, sek_work, min_pause, sek_pause, chk)
                Else
                    min_pause = Val(Form1.txtMinP.Text)
                    sek_pause = Val(Form1.txtSekP.Text)
                    chk = False
                End If
            End If

            ispis_lbl(lblTimer, min_work, sek_work)

            If sek_work > 0 Then
                sek_work -= 1
            Else
                sek_work = 59
                min_work -= 1
            End If

        Else

            If min_pause = 0 And sek_pause = 0 Then
                My.Computer.Audio.Play("C:\Users\pc\Desktop\programiranje\Pomodoro\sewy.wav")
                If def_uslovi(Form1.txtMin, Form1.txtSek, Form1.txtMinP, Form1.txtSekP) = True Then
                    difolt(min_work, sek_work, min_pause, sek_pause, chk)
                Else
                    chk = True
                    sek_work = Val(Form1.txtSek.Text)
                    min_work = Val(Form1.txtMin.Text)
                End If
            End If

            ispis_lbl(lblTimer, min_pause, sek_pause)

            If sek_pause > 0 Then
                sek_pause -= 1
            Else
                min_pause -= 1
                sek_pause = 59
            End If
        End If

    End Sub

    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        If Me.WindowState = WindowState.Maximized Then
            lblTimer.Font = New Font("Century Schoolbook", 150, FontStyle.Bold)
            btnPlay.Font = New Font("Yu Gothic UI", 35, FontStyle.Bold)
            btnPlay.Height += 20
        Else
            lblTimer.Font = New Font("Century Schoolbook", 64, FontStyle.Bold)
            btnPlay.Font = New Font("Yu Gothic UI", 16, FontStyle.Bold)
            btnPlay.Height -= 20
        End If
        lblTimer.Top = Me.ClientSize.Height / 3
        lblTimer.Left = Me.ClientSize.Width / 2 - lblTimer.Width / 2
        btnPlay.Width = Me.ClientSize.Width / 2
        btnPlay.Top = Me.ClientSize.Height - 2 * btnPlay.Height
        btnPlay.Left = Me.ClientSize.Width / 2 - btnPlay.Width / 2

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If def_uslovi(Form1.txtMin, Form1.txtSek, Form1.txtMinP, Form1.txtSekP) = True Then
            chk = False
            difolt(min_work, sek_work, min_pause, sek_pause, chk)
        End If

        ispis_lbl(lblTimer, min_work, sek_work)
        lblTimer.Top = Me.ClientSize.Height / 3
        lblTimer.Left = Me.ClientSize.Width / 2 - lblTimer.Width / 2
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
