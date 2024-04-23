Public Class Form1

    'Exercises from the VB.NET Full Course for Begginers by FreeCodeCamp.org -> ArrayVariables Practice

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnE1.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8


        Dim iCount As Integer

        For iCount = 0 To 4
            MessageBox.Show(aiData(iCount))
        Next

    End Sub

    Private Sub btnE2_Click(sender As Object, e As EventArgs) Handles btnE2.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim stShow As String

        For iCount = 0 To 4
            stShow = stShow & aiData(iCount) & vbNewLine
        Next

        MessageBox.Show(stShow)

    End Sub

    Private Sub btnE3_Click(sender As Object, e As EventArgs) Handles btnE3.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iSum As Integer

        For iCount = 0 To 4

            iSum = iSum + aiData(iCount)

        Next

        MessageBox.Show("The sum is " & iSum)

    End Sub

    Private Sub btnE4_Click(sender As Object, e As EventArgs) Handles btnE4.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iAverage As Integer

        For iCount = 0 To 4

            iAverage = iAverage + aiData(iCount)

        Next

        iAverage = iAverage / 5

        MessageBox.Show("The average is " & iAverage)

    End Sub

    Private Sub btnE5_Click(sender As Object, e As EventArgs) Handles btnE5.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iSum As Integer

        For iCount = 0 To 4

            If aiData(iCount) > 20 Then

                iSum = iSum + aiData(iCount)

            End If

        Next

        MessageBox.Show(iSum)

    End Sub

    Private Sub btnE6_Click(sender As Object, e As EventArgs) Handles btnE6.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iHighest As Integer

        For iCount = 0 To 4

            If aiData(iCount) > iHighest Then

                iHighest = aiData(iCount)

            End If

        Next

        MessageBox.Show("The highest number in the array is " & iHighest)

    End Sub

    Private Sub btnE7_Click(sender As Object, e As EventArgs) Handles btnE7.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iLowest As Integer
        iLowest = 500

        For iCount = 0 To 4

            If iLowest > aiData(iCount) And aiData(iCount) <> 0 Then

                iLowest = aiData(iCount)

            End If

        Next

        MessageBox.Show("The lowest number in the array is " & iLowest)

    End Sub

    Private Sub btnE8_Click(sender As Object, e As EventArgs) Handles btnE8.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim iCount As Integer
        Dim iConverter As Integer
        Dim stShow As String

        For iCount = 0 To 4

            iConverter = aiData(iCount) * 2
            aiData(iCount) = iConverter
            stShow = stShow & aiData(iCount) & vbNewLine

        Next

        MessageBox.Show(stShow)

    End Sub

End Class
