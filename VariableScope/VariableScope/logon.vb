Public Class logon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.TextBox1.Text = "Jay" And Me.TextBox2.Text = "1234" Then

            stUser = "Jay"
            Form1.Show()

        Else

            MessageBox.Show("You are not authorised to use this system.")

        End If


    End Sub
End Class