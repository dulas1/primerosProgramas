Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        MessageBox.Show(txt1.Text, "Este es tu mensaje :)")
        txt1.Text = ""
        txt1.Focus()
    End Sub

End Class
