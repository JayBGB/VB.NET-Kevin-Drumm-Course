Public Class Form1

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim iMyAge As Integer
        Dim myArray(4) As String

        Try
            x = Me.txtN1.Text
        Catch ex As Exception
            MsgBox("Number one is required must be a number.")
            MsgBox(ex.Message)
            x = 1
        End Try

        Try
            y = Me.txtN2.Text
        Catch ex As Exception
            MsgBox("Number two is required must be a number.")
            y = 1
        End Try

        Try
            iMyAge = Me.txtN3.Text
        Catch ex As Exception
            MsgBox("My age is required must be a number.")
            iMyAge = 1
        End Try

        Try
            z = x / y
        Catch ex As Exception
            MsgBox("Number two must be bigger than zero.")
            z = 1

        Finally
            MsgBox(z)
            MsgBox(iMyAge)
        End Try

    End Sub

End Class
