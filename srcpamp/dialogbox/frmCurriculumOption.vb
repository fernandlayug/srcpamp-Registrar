Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmCurriculumOption

    Public FormName As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If department.Text = "Elementary-JuniorHS" Then
            frmCurriculumBE.Show()
        ElseIf department.Text = "SeniorHS-College" Then
            frmCurriculum.Show()
        End If
    End Sub

    Private Sub frmCurriculumOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class