Imports <xmlns="demo">

Public Class MyService

    Public Shared Function GetPeople() As Dictionary(Of String, String)

        'Dim dataXml = XDocument.Load("data.xml")

        'Return dataXml...<person>.ToDictionary(Function(p) p.<name>.Value, Function(p) p.<twitter>.Value)
        'Return dataXml...<person>.ToDictionary(Function(p) p.<name>.Value, Function(p) p.<twitter>.Value)
        Dim data = New Dictionary(Of String, String)
        data.Add("Dennis Palmer", "CoderDennis")
        data.Add("Johnny", "JohnJelinek")
        Return data
    End Function


End Class
