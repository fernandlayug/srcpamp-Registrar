Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmSubjectStudentOption

    Public FormName As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If department.Text = "Elementary-JuniorHS" Then
            Dim frm As New frmSubjectStudentsBE
            frm.Show()
        ElseIf department.Text = "SeniorHS-College" Then
            Dim frm As New frmSubjectStudents
            frm.Show()
        End If
    End Sub

    Private Sub frmSubjectStudentOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class