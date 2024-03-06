Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TekstiPoorajaTest

    <TestMethod()> Public Sub PooraFunktsiooniga_YksSona_VastusPooratudSona()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("abcdef")

        Assert.AreEqual("fedcba", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_TyhiString_VastusTyhiString()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("")

        Assert.AreEqual("", vastus)
    End Sub

End Class