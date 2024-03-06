Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiOmadusedTest

    <DataRow("aba", 2)>
    <DataRow("pxklLK", 0)>
    <DataTestMethod()> Public Sub LoeTaishaalikuteArv_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.intTaishaalikuteArv

        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

End Class