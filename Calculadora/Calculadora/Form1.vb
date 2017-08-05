Public Class Form1

    Dim A As Double
    Dim B As Double
    Dim OPERACION As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt1.Text = txt1.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt1.Text = txt1.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt1.Text = txt1.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt1.Text = txt1.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt1.Text = txt1.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt1.Text = txt1.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt1.Text = txt1.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt1.Text = txt1.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt1.Text = txt1.Text & "9"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        txt1.Text = txt1.Text & "."
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txt1.Text = txt1.Text & "0"
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        B = txt1.Text
        txt1.Text = ""
        If OPERACION = "+" Then
            txt1.Text = A + B
        ElseIf OPERACION = "-" Then
            txt1.Text = A - B
        ElseIf OPERACION = "*" Then
            txt1.Text = A * B
        ElseIf OPERACION = "/" Then
            txt1.Text = A / B
        End If
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        A = txt1.Text
        txt1.Text = ""
        OPERACION = "+"
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        A = txt1.Text
        txt1.Text = ""
        OPERACION = "-"
    End Sub

    Private Sub btnpor_Click(sender As Object, e As EventArgs) Handles btnpor.Click
        A = txt1.Text
        txt1.Text = ""
        OPERACION = "*"
    End Sub

    Private Sub btnentre_Click(sender As Object, e As EventArgs) Handles btnentre.Click
        A = txt1.Text
        txt1.Text = ""
        OPERACION = "/"
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txt1.Text = ""
    End Sub
End Class
