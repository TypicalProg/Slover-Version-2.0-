Public Class gip
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim res = Math.Round(Math.Sqrt(TextBox2.Text ^ 2 + TextBox1.Text ^ 2), 3)
            Label2.Text = "Результат = " & res
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub
End Class