Module Module1
    Public Sub ispis_lbl(ByRef lbl As Label, ByVal min As Integer, ByVal sek As Integer)
        If min - 10 < 0 And sek - 10 < 0 Then
            lbl.Text = "0" + $"{min}" + ":0" + $"{sek}"
        ElseIf min - 10 < 0 Then
            lbl.Text = "0" + $"{min}" + ":" + $"{sek}"
        ElseIf sek - 10 < 0 Then
            lbl.Text = $"{min}" + ":0" + $"{sek}"
        Else
            lbl.Text = $"{min}" + ":" + $"{sek}"
        End If
    End Sub


    Public Sub difolt(ByRef minW As Integer, ByRef sekW As Integer, ByRef minP As Integer, ByRef sekP As Integer, ByRef chk As Boolean)
        If chk = True Then
            minP = 15
            sekP = 0
            chk = False
        Else
            minW = 45
            sekW = 0
            chk = True
        End If
    End Sub

    Public Function def_uslovi(ByRef txtM As TextBox, ByVal txtS As TextBox, ByRef txtM_p As TextBox, ByVal txtS_p As TextBox) As Boolean
        If Val(txtM.Text) = 0 And Val(txtM_p.Text) = 0 And Val(txtS.Text) = 0 And Val(txtS_p.Text) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
