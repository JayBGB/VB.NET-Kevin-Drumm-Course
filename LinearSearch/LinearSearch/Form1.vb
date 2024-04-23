Public Class Form1

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click

        Dim astFruit(9) As String
        Dim stTarget As String
        Dim bFound As Boolean

        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Banana"
        astFruit(4) = "Tomato"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"

        stTarget = InputBox("Which fruit are you looking for?")

        Dim iCount As Integer

        For iCount = 0 To 9

            If astFruit(iCount).ToUpper = stTarget.ToUpper Then

                bFound = True
                Exit For

            End If

        Next

        If bFound = True Then

            MessageBox.Show("Found it!")

        Else

            MessageBox.Show("Not found!")

        End If

    End Sub

End Class
