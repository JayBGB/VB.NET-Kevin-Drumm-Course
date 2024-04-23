Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome to the VB .NET programming course!")
        MessageBox.Show("This is another message.")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Jay"
        stLastName = "de Orestes"

        MessageBox.Show("Hello and welcome, " & stFirstName & " " & stLastName & ", I hope you are well.")

        stFirstName = "Lukas"
        stLastName = "Skorski"

        MessageBox.Show("Hello and welcome, " & stFirstName & " " & stLastName & ", I hope you are well.")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "Red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 23500.4
        dtDateRegistered = #4/15/2024#

        MessageBox.Show("The car is a " & stMake & " " & stModel & vbNewLine &
                        "It has " & iDoors & " doors and is " & stColour & vbNewLine &
                        "Taxed: " & bTaxed & vbNewLine &
                        "Its engine size is " & iEngineSize & ", the car costing " & decPrice & vbNewLine &
                        "It was made on " & dtDateRegistered)

    End Sub

End Class
