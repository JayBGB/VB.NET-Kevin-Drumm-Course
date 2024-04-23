Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim order As New orderProcessing.Order
        Dim result As Decimal

        Dim oCalculateTotalToPayDelegate As New orderProcessing.Order.CalculateTotalToPayDelegate(AddressOf SummerSpecial)

        result = order.CalculateTotalToPay(oCalculateTotalToPayDelegate, 5, 10)

        MsgBox(result)

    End Sub

    Function NormalDeal(ByVal quantity As Integer, ByVal price As Decimal) As Decimal

        Return quantity * price

    End Function

    Function HalfPrice(ByVal quantity As Integer, ByVal price As Decimal) As Decimal

        Return (quantity * price) / 2

    End Function

    Function SummerSpecial(ByVal quantity As Integer, ByVal price As Decimal)

        Dim discount As Decimal = CDec(Me.txtDiscount.Text)
        Dim undiscounted As Decimal

        undiscounted = price * quantity

        Return undiscounted - (price * quantity) * discount

    End Function

End Class


