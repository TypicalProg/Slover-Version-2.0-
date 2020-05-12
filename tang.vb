Public Class tang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim res = Math.Round(TextBox2.Text / TextBox1.Text, 3)
            Label2.Text = "Результат = " & res
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub
End Class