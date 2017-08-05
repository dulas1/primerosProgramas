Public Class Form1

    Dim nombre As String
    Dim apellido As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        lbox1.Items.Add(txt1.Text + " " + txt2.Text)

        txt1.Text = ""
        txt2.Text = ""
        txt1.Focus()

    End Sub

End Class
