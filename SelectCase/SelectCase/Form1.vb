Public Class Form1

    Private Sub btnTemperature_Click(sender As Object, e As EventArgs) Handles btnTemperature.Click

        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Select Case iTemperature
            Case Is = 0
                MessageBox.Show("Freezing")
            Case Is < 0
                MessageBox.Show("Sub Zero")
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                MessageBox.Show("Cold")
            Case 11 To 20
                MessageBox.Show("Warm")
            Case Else
                MessageBox.Show("Hot")
        End Select

    End Sub

End Class
