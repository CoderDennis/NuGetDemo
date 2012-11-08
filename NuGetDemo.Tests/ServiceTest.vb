Imports NUnit.Framework

<TestFixture>
Public Class ServiceTest

    <Test>
    Public Sub DataIsRight()
        Dim people = MyService.GetPeople
        Assert.AreEqual(1, people.Count)
        Assert.AreEqual("Dennis Palmer", people.First.Key)
        Assert.AreEqual("CoderDennis", people.First.Value)
    End Sub

End Class
