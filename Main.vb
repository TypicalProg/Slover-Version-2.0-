Public Class Calc
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            Dim objScript As Object = CreateObject("MSScriptControl.ScriptControl")
            objScript.Language = "VBScript"
            TextBox1.Text = objScript.Eval(TextBox1.Text)
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("7")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.AppendText("8")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.AppendText("4")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.AppendText("5")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.AppendText("6")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.AppendText("(")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.AppendText(")")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.AppendText("+")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.AppendText("-")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.AppendText("*")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.AppendText("/")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            Dim objScript As Object = CreateObject("MSScriptControl.ScriptControl")
            objScript.Language = "VBScript"
            TextBox1.Text = Math.Sqrt(TextBox1.Text)
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim objScript As Object = CreateObject("MSScriptControl.ScriptControl")
            objScript.Language = "VBScript"
            TextBox1.Text = Math.Sin(TextBox1.Text)
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            Dim objScript As Object = CreateObject("MSScriptControl.ScriptControl")
            objScript.Language = "VBScript"
            TextBox1.Text = Math.Cos(TextBox1.Text)
        Catch
            MsgBox("Введите корректное значение!", 16, "Ошибка!")
        End Try
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.AppendText("3.14159265")
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.AppendText("^")
    End Sub

    Private Sub ОбИздателеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбИздателеToolStripMenuItem.Click
        MsgBox("(с) M14 Software. All rights reserved.", 64, "Информация об издателе")
    End Sub

    Private Sub ОбратнаяСвязьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбратнаяСвязьToolStripMenuItem.Click
        Process.Start("feedback.exe")
    End Sub

    Private Sub ТангенсToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ТангенсToolStripMenuItem1.Click
        tang.Show()
    End Sub

    Private Sub ГипотенузаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ГипотенузаToolStripMenuItem.Click
        gip.Show()
    End Sub

    Private Sub КорниКвУравненияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КорниКвУравненияToolStripMenuItem.Click
        sqrt.Show()
    End Sub

    Private Sub RADToGRADUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RADToGRADUSToolStripMenuItem.Click
        r2r.Show()
    End Sub

    Private Sub СрАрифметечискоеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СрАрифметечискоеToolStripMenuItem.Click
        middle.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ТангенсToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТангенсToolStripMenuItem.Click
        nok.Show()
    End Sub

    Private Sub ПереводВСистемыСчисленияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПереводВСистемыСчисленияToolStripMenuItem.Click
        Sys_math.Show()
    End Sub
End Class
