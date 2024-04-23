Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MessageBox.Show("Welcome, " & stFirstName & " " & stLastName & ". You are a " & stGender & " " & stOccupation)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")

    End Sub

End Class
