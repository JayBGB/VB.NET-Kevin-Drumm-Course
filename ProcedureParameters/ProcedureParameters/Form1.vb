Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim x As Integer
        x = 5
        MessageBox.Show(x)

        Call DoSomething(33)

        MessageBox.Show("Button code is running again")


    End Sub

    Sub DoSomething(p As Integer)

        MessageBox.Show("Do something is running")
        MessageBox.Show("I was passed the value " & p)

    End Sub

End Class
