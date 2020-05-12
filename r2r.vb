Public Class r2r
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim grad = Val(TextBox1.Text)
            Dim gr = Math.Round(grad * 180 / Math.PI, 3)
            Label7.Text = gr & "°"
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gr = Val(TextBox2.Text)
        Dim grad = Math.Round(gr * Math.PI / 180, 3)
        Label6.Text = grad & " rad"
    End Sub
End Class