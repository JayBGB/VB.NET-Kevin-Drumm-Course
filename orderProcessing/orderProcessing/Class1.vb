Public Class Order

    Delegate Function CalculateTotalToPayDelegate(ByVal quantity As Integer, ByVal price As Decimal) As Decimal


    Public Function CalculateTotalToPay(calculation As CalculateTotalToPayDelegate, quantity As Integer, price As Decimal) As Decimal

        Dim totalToPay As Decimal
        totalToPay = calculation.Invoke(quantity, price)

        totalToPay = totalToPay + 5 'delivery charge
        'code to award loyalty points to customer
        'code to save order details in database
        'and more

        Return totalToPay

    End Function

End Class
