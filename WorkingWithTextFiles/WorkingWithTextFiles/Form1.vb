Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myStreamWriter As StreamWriter

        myStreamWriter = New StreamWriter("c:\delme\mytextfile.txt", True)

        myStreamWriter.WriteLine("Jay")
        myStreamWriter.WriteLine("Lukas")
        myStreamWriter.WriteLine("Arliden")
        myStreamWriter.WriteLine("Thakk")
        myStreamWriter.WriteLine("Kaila")
        myStreamWriter.Write("Scooby")
        myStreamWriter.Write("Dooby")
        myStreamWriter.Write("Doo")

        myStreamWriter.Close()

        MsgBox("All done.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myStreamReader As StreamReader
        myStreamReader = New StreamReader("c:\delme\mytextfile.txt")

        Dim stOutput As String

        Do While Not myStreamReader.EndOfStream
            stOutput = stOutput & myStreamReader.ReadLine & vbNewLine
        Loop

        myStreamReader.Close()
        MsgBox(stOutput)

    End Sub

    Private Sub btnArrayToFile_Click(sender As Object, e As EventArgs) Handles btnArrayToFile.Click

        Dim astCountries(5) As String

        astCountries(0) = "Spain"
        astCountries(1) = "Ireland"
        astCountries(2) = "Norway"
        astCountries(3) = "Austria"
        astCountries(4) = "Germany"
        astCountries(5) = "Switzerland"

        Dim streamWriter As StreamWriter
        streamWriter = New StreamWriter("c:\delme\countries.txt", True)

        Dim i As Integer
        i = 0

        Do While i < astCountries.Length

            streamWriter.WriteLine(astCountries(i))
            i = i + 1

        Loop

        streamWriter.Close()
        MsgBox("Countries written.")

    End Sub

    Private Sub btnFiletoArray_Click(sender As Object, e As EventArgs) Handles btnFiletoArray.Click

        Dim streamReader As StreamReader
        streamReader = New StreamReader("c:\delme\countries.txt")
        Dim stOut As String

        Dim astCountries(5) As String

        Do While Not streamReader.EndOfStream

            Dim i As Integer = 0
            astCountries(i) = streamReader.ReadLine
            stOut = stOut & astCountries(i) & vbNewLine
            i = i + 1

        Loop

        MsgBox(stOut)

    End Sub

    Private Sub btnFiletoFile_Click(sender As Object, e As EventArgs) Handles btnFiletoFile.Click

        Dim astSpain(5) As String

        astSpain(0) = "Asturias"
        astSpain(1) = "Galicia"
        astSpain(2) = "Ciudad Real"
        astSpain(3) = "País Vasco"
        astSpain(4) = "Castilla y León"
        astSpain(5) = "Murcia"

        Dim strw As StreamWriter
        strw = New StreamWriter("c:\delme\from_spain.txt", True)

        For i = 0 To 5
            strw.WriteLine(astSpain(i))
        Next

        strw.Close()

        Dim strr As StreamReader
        strr = New StreamReader("c:\delme\from_spain.txt")

        Dim astToSpain(5) As String

        For i = 0 To 5
            astToSpain(i) = strr.ReadLine
        Next

        strr.Close()

        strw = New StreamWriter("c:\delme\toSpain.txt", True)

        For i = 0 To 5

            strw.WriteLine(astToSpain(i))

        Next

        strw.Close()

    End Sub

    Private Sub btn2DFuke_Click(sender As Object, e As EventArgs) Handles btn2DFuke.Click

        Dim spain(1, 4) As String

        spain(0, 0) = "Asturias"
        spain(0, 1) = "Galicia"
        spain(0, 2) = "Cataluña"
        spain(0, 3) = "Madrid"
        spain(0, 4) = "Castilla"
        spain(1, 0) = "Oviedo"
        spain(1, 1) = "Santiago"
        spain(1, 2) = "Barcelona"
        spain(1, 3) = "Madrid"
        spain(1, 4) = "Toledo"

        Dim strw As StreamWriter
        strw = New StreamWriter("c:\delme\2dSpain.txt", False)
        Dim i As Integer = 0

        Do While i < spain.Length / 2

            strw.WriteLine(spain(0, i) & " " & spain(1, i) & vbNewLine)
            i = i + 1

        Loop

        strw.Close()

    End Sub

    Private Sub btnFileto2D_Click(sender As Object, e As EventArgs) Handles btnFileto2D.Click

        Dim strr As StreamReader
        strr = New StreamReader("c:\delme\2dSpain.txt")
        Dim twoDspain(1, 4) As String

        Dim currentSpain As String
        Dim tempArray() As String

        For y = 0 To 4
            currentSpain = strr.ReadLine
            MsgBox(currentSpain)

            ' Split the line by the first space encountered
            Dim index As Integer = currentSpain.IndexOf(" ")
            If index <> -1 Then
                ' Extract the two parts of the line
                Dim part1 As String = currentSpain.Substring(0, index)
                Dim part2 As String = currentSpain.Substring(index + 1)

                MsgBox(part1)
                MsgBox(part2)

                ' Store the parts in the 2D array
                twoDspain(0, y) = part1
                twoDspain(1, y) = part2
            Else
                MsgBox("Line does not contain enough elements.")
            End If
        Next



        strr.Close()

        MsgBox("Done")

    End Sub
End Class
