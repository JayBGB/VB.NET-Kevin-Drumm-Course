Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer

        Do

            iCount = iCount + 1
            MessageBox.Show(iCount)

        Loop While iCount < 5

        MessageBox.Show("Out of the loop!")

    End Sub

End Class
