Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjectCurrentSked


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

   
    Private Sub frmSubjectCurrentSked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlserver.connect()

        If sqlconn.State = ConnectionState.Open Then
   
            Call fetch_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject()
            sqlconn.Close()
        End If

    End Sub

    Private Sub fetch_subject()



        Dim obj As Object = DBNull.Value
        Dim str As String = "select firstname +', ' + surname as name, subjectid, sectionid, levelid , classscheduleid,  " & _
            "coursecode, subjectcode, subjectdescription, sectioname, yrlevel, term, sy, days, time, room " & _
            "FROM ClassScheduleView WHERE sy = '" & sy.Text & "' AND term = '" & term.Text & "' AND subjectid = '" & txtSubjectID.Text & "' "

        Dim cmd As New SqlCommand(str, sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "ClassScheduleView")) Then

            dtPrint.Columns.Clear()

            dtPrint.DataSource = ds.Tables(0)

            dtPrint.Columns("subjectid").Visible = False
            dtPrint.Columns("sectionid").Visible = False
            dtPrint.Columns("levelid").Visible = False
            dtPrint.Columns("term").Visible = False
            dtPrint.Columns("yrlevel").Visible = False
            dtPrint.Columns("sy").Visible = False
            'dtPrint.Columns("coursecode").Visible = False
            dtPrint.Columns("classscheduleid").Visible = False


            dtPrint.Columns("subjectcode").DisplayIndex = 0
            dtPrint.Columns("subjectcode").Width = 60
            dtPrint.Columns("subjectcode").HeaderText = "Code"

            dtPrint.Columns("subjectdescription").DisplayIndex = 1
            dtPrint.Columns("subjectdescription").Width = 250
            dtPrint.Columns("subjectdescription").HeaderText = "Subject"

            dtPrint.Columns("coursecode").DisplayIndex = 2
            dtPrint.Columns("coursecode").Width = 100
            dtPrint.Columns("coursecode").HeaderText = "Course"

            dtPrint.Columns("sectioname").DisplayIndex = 3
            dtPrint.Columns("sectioname").Width = 50
            dtPrint.Columns("sectioname").HeaderText = "Section"

            dtPrint.Columns("name").DisplayIndex = 4
            dtPrint.Columns("name").Width = 180
            dtPrint.Columns("name").HeaderText = "Faculty"

            dtPrint.Columns("days").DisplayIndex = 5
            dtPrint.Columns("days").Width = 100
            dtPrint.Columns("days").HeaderText = "Day"

            dtPrint.Columns("time").DisplayIndex = 6
            dtPrint.Columns("time").Width = 110
            dtPrint.Columns("time").HeaderText = "Time"

            dtPrint.Columns("room").DisplayIndex = 7
            dtPrint.Columns("room").Width = 80
            dtPrint.Columns("room").HeaderText = "Room"

        Else

            dtPrint.DataSource = Nothing
        End If

 

    End Sub

    Private Sub dtPrint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPrint.CellClick
        Dim myVariable As String = dtPrint.CurrentRow.Cells("classscheduleid").Value.ToString
        classscheduleid.Text = myVariable
    End Sub

    Private Sub classscheduleid_TextChanged(sender As Object, e As EventArgs) Handles classscheduleid.TextChanged
        If classscheduleid.Text = "" Then
            btnapply.Enabled = False
        ElseIf classscheduleid.Text = String.Empty = False Then
            btnapply.Enabled = True
        End If
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        studentfile.classscheduleid.Text = classscheduleid.Text
        Me.Dispose()
    End Sub
End Class