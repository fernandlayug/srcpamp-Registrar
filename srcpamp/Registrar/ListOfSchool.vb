Imports System.Data.SqlClient
Imports System.IO
Public Class ListOfSchool

    Private Sub ListOfSchool_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ListOfSchool_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSchoolCode.Focus()
        txtSchoolname.ReadOnly = True
   
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub verify_school()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into schoollist([schoolcode],[schoolname],[schoolcategory],[address3],[address2], " & _
            "[address1]) values ('" & txtSchoolCode.Text & "','" & txtSchoolname.Text & "','" & txtType.Text & "','" & txtAddress3.Text & "', " & _
            " '" & txtAddress2.Text & "'," & _
            " '" & txtAddress1.Text & "')"

        sqlconn.Open()
        sqlcmd.CommandText = "select * FROM schoollist Where (schoolname = '" & txtSchoolname.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader

        daMyname2 = sqlcmd.ExecuteReader()

        If daMyname2.HasRows Then

            MessageBox.Show("School already exist.  For assisstance please see the administrator.")

            'command para insert ang mga data
        Else
            sqlconn.Close()
            Me.Refresh()
            sqlconn.Open()
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
            MessageBox.Show("School Name successfully added to School List.")

            sqlcmd.CommandText = "select * FROM schoollist Where (schoolname = '" & txtSchoolname.Text & "') and (schoolcode = '" & txtSchoolCode.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                admissionFrm.schoolcode = daMyname.Item("schoolcode")
                admissionFrm.schoolid = daMyname.Item("ID")
            End If
            sqlconn.Close()
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call verify_school()
        Me.Dispose()
    End Sub
End Class