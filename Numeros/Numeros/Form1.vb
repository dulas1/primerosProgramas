Public Class Form1

    Dim numeros() As Integer
    Dim num As Integer

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        For t = 0 To 4
            ReDim Preserve numeros(t)
            numeros(t) = InputBox("agrega un numero")
        Next

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        For I As Byte = 0 To 4
            lb1.Items.Add(numeros(I))
        Next
        lb1.Items.Add(" ")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Array.Sort(numeros)
        For Each nume In numeros
            lb1.Items.Add(nume)
        Next
    End Sub
End Class
