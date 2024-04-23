Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stPrice As String
        stPrice = "Twenty Seven Pounds and Thirty Pence"

        'Dim i As Integer
        'i = Len(stPrice)
        'MessageBox.Show(i)

        'i = Asc("A")
        'MessageBox.Show(i)

        'Dim c As String
        'c = Chr(66)
        'MessageBox.Show(c)

        'Dim bCheck As Boolean
        'bCheck = IsNumeric(stPrice)
        'MessageBox.Show(bCheck)

        'Dim decPrice As Decimal
        'decPrice = CDec(stPrice)
        'MessageBox.Show(decPrice)

        'decPrice = CType(stPrice, Decimal)

        'Dim stDisplayPrice As String
        'stDisplayPrice = Format(decPrice, "Currency")
        'MessageBox.Show(stDisplayPrice)

        Dim st As String
        'st = UCase(stPrice)
        'MessageBox.Show(st)

        'st = Mid(stPrice, 9, 4)
        'MessageBox.Show(st)

        'st = Strings.Right(stPrice, 4)
        'MsgBox(st

        'st = Strings.Replace(stPrice, "P", "X")
        'MsgBox(st)

        'i = InStr(stPrice, "P")

        Dim decWeight As Decimal
        decWeight = 78.345

        Dim d As Decimal
        d = Math.Ceiling(decWeight) 'Floor will take it to the nearest low
        MsgBox(d)

        Dim dt As Date
        dt = Now()
        MsgBox(dt)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As Date

        Dim x As Long
        x = 0

        dt = Now()
        Me.lblDate.Text = dt

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
