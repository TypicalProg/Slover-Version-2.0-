Public Class middle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr = Split(TextBox1.Text)
        Dim sum = 0
        Try
            For i = 0 To arr.Length
                If i = arr.Length Then
                    Exit For
                End If
                sum += arr(i)
            Next
        Catch

        End Try

        Label2.Text = "Результат = " & Math.Round(sum / arr.Length, 3)
    End Sub
End Class

' x * Factorial(x - 1)