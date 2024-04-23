Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports Newtonsoft.Json

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim emp As Employee
        emp = New Employee
        emp.FirstName = "Jay"
        emp.LastName = "de Orestes"
        emp.Gender = "Male"
        emp.JobRole = "Programmer"
        emp.Salary = "65000"

        'Dim myString As String
        'myString = JsonConvert.SerializeObject(emp, Formatting.Indented)
        'MsgBox(myString)

        'File.WriteAllText("c:\delme\person.json", JsonConvert.SerializeObject(emp, Formatting.Indented))

        Dim swPerson As StreamWriter
        swPerson = New StreamWriter("c:\delme\person2.json", True)
        Dim myPersonserializer As New JsonSerializer()
        myPersonserializer.Serialize(swPerson, emp)
        swPerson.Close()

        'Dim emp2 As New Employee
        'emp2 = JsonConvert.DeserializeObject(myString, emp2.GetType)
        'emp2 = JsonConvert.DeserializeObject(Of Employee)(myString)

        'Dim emp2 As New Employee
        'Dim srperson As StreamReader
        'srperson = New StreamReader("c:\delme\person.json")
        'Dim myPersonserializer As New JsonSerializer()

        'emp2 = myPersonserializer.Deserialize(srperson, emp2.GetType)
        'srperson.Close()

        'MsgBox(emp2.FirstName & " " & emp2.LastName & " " & emp2.Gender & " " & emp2.JobRole & " " & emp2.Salary)

    End Sub

End Class

Public Class Person

    Public FirstName As String
    Public LastName As String
    Public Gender As String

    Public Function SayHi() As String
        Return "Hello World!"
    End Function

End Class

Public Class Employee

    Inherits Person

    Public JobRole As String
    Public Salary As Decimal

    Public Function ShouldSerializeSalary() As Boolean

        If Salary < 50000 Then
            Return False
        Else
            Return True
        End If

        'Return (Salary >= 50000)

    End Function

End Class
