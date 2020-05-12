Public Class nok
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim m, n, r, nod, nok
            m = CInt(TextBox1.Text)
            n = CInt(TextBox2.Text)
            r = 1

            If m >= n And n <> 0 Then
                Do While r <> 0
                    r = (m Mod n)
                    If r = 0 Then
                        nod = n
                    Else
                        m = n
                        n = r
                    End If
                Loop
            Else
                Do While r <> 0
                    r = n Mod m
                    If r = 0 Then
                        nod = m
                    Else
                        n = m And m = r
                    End If
                Loop
            End If

            nok = n * m / nod

            Label8.Text = nod
            Label9.Text = nok

            ' Разложение числа на простые множители
            Dim a1 = TextBox1.Text
            Dim a2 = TextBox2.Text
            Dim a
            Dim b

            While a1 > 1
                Dim i = 2
                While True
                    If a1 Mod i = 0 Then
                        a += i & " "
                        a1 \= i
                        Exit While
                    Else
                        i += 1
                    End If
                End While
            End While

            While a2 > 1
                Dim i1 = 2
                While True
                    If a2 Mod i1 = 0 Then
                        b += i1 & " "
                        a2 \= i1
                        Exit While
                    Else
                        i1 += 1
                    End If
                End While
            End While

            Label6.Text = a
            Label7.Text = b
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub
End Class