Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TekstiPoorajaTest

    <TestMethod()> Public Sub PooraFunktsiooniga_YksSona_VastusPooratudSona()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("abcdef")

        Assert.AreEqual("fedcba", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_SuuredJaVaiksedTahed_VastusSuuredJaVaiksedTahed()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("aBcDef")

        Assert.AreEqual("feDcBa", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_MituSona_VastusMituSona()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("a ja b")

        Assert.AreEqual("b aj a", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_Kirjavahemargid_VastusKirjavahemargid()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("a, b = c")

        Assert.AreEqual("c = b ,a", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_Numbrid_VastusNumbrid()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("123")

        Assert.AreEqual("321", vastus)
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_TyhiString_VastusTyhiString()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("")

        Assert.AreEqual("", vastus)
    End Sub

End Class