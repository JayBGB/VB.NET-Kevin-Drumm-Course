Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer = 5
        Dim b As Double = 0.00001
        Dim result As Integer

        result = a / b

        MsgBox(result)

    End Sub

End Class
