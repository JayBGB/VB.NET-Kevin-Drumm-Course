Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 100 To 50 Step -5
            stOut = stOut & iCount & vbNewLine
        Next

        MessageBox.Show(stOut)

    End Sub

End Class
