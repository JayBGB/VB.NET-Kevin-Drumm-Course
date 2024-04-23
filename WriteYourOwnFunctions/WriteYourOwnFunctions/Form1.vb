Public Class Form1

    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click

        Dim decResult As Decimal

        decResult = TotalPay(9.81, 40)

        MessageBox.Show(decResult)

        MsgBox(TriangleArea(21, 12))

        MsgBox(TemperatureChecker(12))
    End Sub

    Function TotalPay(HourlyRate As Decimal, HoursWorked As Integer)

        Dim decTotalPay As Decimal

        decTotalPay = HourlyRate * HoursWorked

        Return decTotalPay

    End Function

    Function TriangleArea(Base As Double, Height As Double) As Double

        Dim dblResult As Double
        dblResult = (Base / Height) * 2
        Return dblResult

    End Function

    Function TemperatureChecker(Temperature As Integer) As String


        If Temperature < 10 Then
            Return "Cold"

        ElseIf Temperature >= 10 And Temperature < 25 Then
            Return "Warm"

        Else
            Return "Hot"

        End If


    End Function

End Class
