Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmSubjectStudentOption
    Public cay As String
    Public FormName As String
    Public accttype As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If accttype = "IHS" Then
            If department.Text = "Elementary-JuniorHS" Then
                frmSubjectStudentsBE.cay = cay
                frmSubjectStudentsBE.chkElementary.Enabled = False
                frmSubjectStudentsBE.chkElementaryFaculty.Enabled = False

                frmSubjectStudentsBE.Show()

            ElseIf department.Text = "SeniorHS-College" Then
                frmSubjectStudents.chkCollegeCourse.Enabled = False
                frmSubjectStudents.chkCollegeFaculty.Enabled = False
                frmSubjectStudents.cay = cay

                frmSubjectStudents.Show()
            End If
        Else
            If department.Text = "Elementary-JuniorHS" Then
                frmSubjectStudentsBE.cay = cay
                'frmSubjectStudentsBE.TextBox1.Text = TextBox1.Text
                'Dim frm As New frmSubjectStudentsBE
                frmSubjectStudentsBE.Show()
            ElseIf department.Text = "SeniorHS-College" Then
                frmSubjectStudents.cay = cay
                ' Dim frm As New frmSubjectStudents
                frmSubjectStudents.Show()
            End If
        End If
    End Sub

    Private Sub frmSubjectStudentOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class