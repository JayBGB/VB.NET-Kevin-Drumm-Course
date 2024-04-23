Public Class Form1

    Private Sub btnCountUp_Click(sender As Object, e As EventArgs) Handles btnCountUp.Click

        Dim iNumber As Integer
        Dim iCount As Integer
        Dim stNumber As String

        iNumber = InputBox("What number do you want to count up to?")
        stNumber = InputBox("Do you want odd or even numbers?")

        If stNumber.ToUpper = "EVEN" Then

            For iCount = 0 To iNumber Step 2
                MessageBox.Show(iCount)
            Next

        ElseIf stNumber.ToUpper = "ODD" Then

            For iCount = 1 To iNumber Step 2
                MessageBox.Show(iCount)
            Next

        Else

            MessageBox.Show("You have to write either 'Even' or 'Odd'")
            End If

    End Sub

End Class
