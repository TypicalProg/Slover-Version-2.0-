Public Class sys_math
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM -- labs.raraavis.ru -- Перевод между системами счисления.
        Dim MI, MK, C, K, I, J As Integer
        Dim Dec As Long = 0
        Dim MMax As Integer = 16
        Dim Ms As String = Mid(Str(MMax), 2)
        Dim Alf As String = "0123456789ABCDEF"
        Dim Num, Target As String

        MI = TextBox1.Text 'исходное число
        Num = TextBox2.Text 'Исходное основание
        MK = TextBox3.Text 'Конечное основание

        K = 1
        For I = Num.Length To 1 Step -1
            For J = 1 To Alf.Length
                If Mid(Alf, J, 1) = Mid(Num, I, 1) Then
                    C = J - 1
                    Exit For
                End If
            Next
            Dec = Dec + C * K
            K = K * MI
        Next

        REM Перевод числа в нужную систему счисления.
        While Dec > 1
            Target = Mid(Alf, (Dec Mod MK) + 1, 1) + Target
            Dec = Dec \ MK
        End While
        Target = Mid(Alf, (Dec Mod MK) + 1, 1) + Target

        REM Вывод результата.
        While Mid(Target, 1, 1) = "0"
            Target = Mid(Target, 2)
        End While

        TextBox4.Text = Target
    End Sub
End Class