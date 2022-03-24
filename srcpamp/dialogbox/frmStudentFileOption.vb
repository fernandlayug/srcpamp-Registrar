Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmStudentFileOption

    Public FormName As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If department.Text = "Elementary" Then
            studentfileBE.Show()
        ElseIf department.Text = "Junior HS" Then
            studentfileBE.Show()
        ElseIf department.Text = "Senior HS" Then
            studentfile.Show()
        ElseIf department.Text = "College" Then
            studentfile.formstatus = "viewfile"
            studentfile.Show()
        End If
    End Sub

    Private Sub frmStudentFileOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class