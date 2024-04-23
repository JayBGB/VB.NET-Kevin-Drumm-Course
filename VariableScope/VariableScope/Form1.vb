Public Class Form1

    Dim x As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x = 10
        MessageBox.Show(x)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        x = 5
        MessageBox.Show(x)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        logon.Hide()
        MessageBox.Show("Welcome, " & stUser)
        Me.lblName.Text = "Logged user: " & stUser

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        logon.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub
End Class
