Public Class Form1

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click

        Dim stAge As String
        Dim iAge As Integer

        Do While Not IsNumeric(stAge)
            stAge = InputBox("Please enter your age in years.")
        Loop

        iAge = CInt(stAge)

        MessageBox.Show("You are " & iAge)

    End Sub

End Class
