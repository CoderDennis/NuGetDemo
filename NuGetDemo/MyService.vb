Public Class MyService

    Public Shared Function GetPeople() As Dictionary(Of String, String)

        Dim dataXml = XDocument.Load("data.xml")
        Return dataXml...<person>.ToDictionary(Function(p) p.<name>.Value, Function(p) p.<twitter>.Value)

    End Function


End Class
