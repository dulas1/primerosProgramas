Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If rbtn1.Checked Then
            MessageBox.Show("Tienes mas de 18 años", "Felicidades eres legal")

        ElseIf rbtn2.Checked Then
            MessageBox.Show("Tienes menos de 18 años", "Aun no eres legal")
        End If

    End Sub
End Class
