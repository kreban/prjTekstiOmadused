Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiOmadusedTestid

    <DataRow("aba", 2)>
    <DataRow("pxklLK", 0)>
    <DataRow("ttt", 0)>
    <DataRow("aaa", 3)>
    <DataRow("abcddd", 1)>
    <DataRow("aEiOxX", 4)>
    <DataTestMethod()> Public Sub LoeTaishaalikuteArv_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.intTaishaalikuteArv

        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

    <TestMethod()> Public Sub KontrolliPaliondroom_SonaAnna_VastusToene()
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused("anna")
        Dim vastus = testija.boolPalindroom
        Assert.IsTrue(vastus)
    End Sub

End Class