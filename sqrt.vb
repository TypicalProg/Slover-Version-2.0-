Imports System.Math

Public Class sqrt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim a = TextBox1.Text
            Dim b = TextBox2.Text
            Dim c = TextBox3.Text
            Dim D = (b * b) - (4 * a * c)
            If D > 0 Then
                Dim x = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 3)
                Dim y = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 3)
                Label5.Text = "x = " & x
                Label6.Text = "y = " & y
            End If
            If D = 0 Then
                Dim x = Math.Round(-b / (2 * a), 3)
                Label5.Text = "x = " & x
                Label6.Text = ""
            End If
            If D < 0 Then
                Label5.Text = "Корней нет"
                Label6.Text = ""
            End If
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub
End Class