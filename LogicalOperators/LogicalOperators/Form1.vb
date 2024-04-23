Public Class Form1

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer

        If IsNumeric(txtScore.Text) = True Then

            iScore = CInt(txtScore.Text)

        Else

            MessageBox.Show("You must enter a numeric value.")
            Exit Sub

        End If

        If Not (iScore >= 0 And iScore <= 100) Then

            MessageBox.Show("That is not a valid score. Enter a number between 0 and 100.")

        ElseIf iScore <= 20 Then

            MessageBox.Show("GRADE: F")

        ElseIf iScore >= 20 And iScore <= 30 Then

            MessageBox.Show("GRADE: E")

        ElseIf iScore > 30 And iScore <= 40 Then

            MessageBox.Show("GRADE: D")

        ElseIf iScore > 40 And iScore <= 50 Then

            MessageBox.Show("GRADE: C")

        ElseIf iScore > 50 And iScore <= 70 Then

            MessageBox.Show("GRADE: B")

        ElseIf iScore > 70 And iScore <= 90 Then

            MessageBox.Show("GRADE: A")

        ElseIf iScore > 90 And iScore <= 99 Then

            MessageBox.Show("GRADE: A+")

        Else

            MessageBox.Show("GRADE: S")

        End If

        MessageBox.Show("All done.")

    End Sub

End Class
