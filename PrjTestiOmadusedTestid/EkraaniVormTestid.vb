Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PrjTekstiOmadused

<TestClass()> Public Class EkraaniVormTestid

    <DataRow("ada", "Jah")>
    <DataRow("adaa", "Ei")>
    <DataTestMethod()> Public Sub KontrolliEkraanivormiPalindroom_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New CTekstiOmadused(sisend)
        Dim vorm As New EkraaniVorm
        Dim vastus = vorm.PalindroomVastus(testija.KontrolliPalindroom(sisend))

        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

End Class