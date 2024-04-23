Public Class Form1

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry.ToUpper = "AUSTRALIA" Then

            MessageBox.Show("G'day mate!")
            MessageBox.Show("Good on ya!")
            MessageBox.Show("No worries!")

        ElseIf stCountry.ToUpper = "SPAIN" Then

            MessageBox.Show("¡Olé, olé! ¡Viva la tortilla de patata!")

        ElseIf stCountry.ToUpper = "GERMANY " Then

            MessageBox.Show("Guten Tag! Wie geht es Ihnen heute Abend?")

        Else

            MessageBox.Show("Hello, pal. How are you doing?")

        End If

    End Sub

End Class
