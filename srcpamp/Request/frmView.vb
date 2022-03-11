Imports System.Data.SqlClient
Public Class frmView

    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        Dim cmd As New SqlCommand("select * FROM facilityrequest order by dateusestart desc;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "facilityrequest")) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns("timestart").DefaultCellStyle.Format = "hh:mm"
            DataGridView1.Columns("timeend").DefaultCellStyle.Format = "hh:mm"
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim cmd As New SqlCommand("select * From facilityrequest Where (dateusestart = '" & DateTimePicker1.Text & " ');", sqlconn)
        Dim cmd As New SqlCommand("select * From facilityrequest Where (dateusestart = ' " & DateTimePicker1.Text & "');", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "facilityrequest")) Then
            DataGridView1.Visible = True
            DataGridView1.DataSource = ds.Tables(0)
            'DataGridView1.Columns("ID").Visible = False
            DataGridView1.Columns("activity").Visible = False
            'DataGridView1.Columns("room_location").Visible = False
            DataGridView1.Columns("dateusestart").Visible = False
            DataGridView1.Columns("dateuseend").Visible = False
            DataGridView1.Columns("daterequested").Visible = False
            DataGridView1.Columns("supportmaterial1").Visible = False
            DataGridView1.Columns("supportingmaterial2").Visible = False
            DataGridView1.Columns("supportingmaterial3").Visible = False
            DataGridView1.Columns("supportingmaterial4").Visible = False
            DataGridView1.Columns("supportingmaterial5").Visible = False
            DataGridView1.Columns("supportingmaterial6").Visible = False
            DataGridView1.Columns("supportingmaterial7").Visible = False
            DataGridView1.Columns("supportingmaterial8").Visible = False
            DataGridView1.Columns("remarks").Visible = False

            DataGridView1.Columns(0).HeaderText = "Tracking"
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).HeaderText = "ID"
            DataGridView1.Columns(1).Width = 50
            DataGridView1.Columns(2).HeaderText = "Requester Name"
            DataGridView1.Columns(2).Width = 210
            DataGridView1.Columns(3).HeaderText = "Facility"
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(5).HeaderText = "Location"
            DataGridView1.Columns(5).Width = 90
            DataGridView1.Columns(6).HeaderText = "Department"
            DataGridView1.Columns(6).Width = 80
            DataGridView1.Columns(9).HeaderText = "Start"
            DataGridView1.Columns(9).Width = 60
            DataGridView1.Columns(10).HeaderText = "End"
            DataGridView1.Columns(10).Width = 60
            DataGridView1.Columns(20).HeaderText = "Status"
            DataGridView1.Columns(20).Width = 70




        Else
            MessageBox.Show("No Scheduled Activity Found")
            DataGridView1.Visible = False
        End If
    End Sub
    Private Sub fetch_detail()
        Try
            sqlcmd.CommandText = "select * FROM facilityrequest Where (requestid = '" & rid.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
          
                daterequest.Text = daMyname.Item("daterequested")
                activity.Text = daMyname.Item("activity")
                datestart.Text = daMyname.Item("dateusestart")
                dateend.Text = daMyname.Item("dateuseend")
                s1.Text = daMyname.Item("supportmaterial1")
                s2.Text = daMyname.Item("supportingmaterial2")
                s3.Text = daMyname.Item("supportingmaterial3")
                s4.Text = daMyname.Item("supportingmaterial4")
                s5.Text = daMyname.Item("supportingmaterial5")
                s6.Text = daMyname.Item("supportingmaterial6")
                s7.Text = daMyname.Item("supportingmaterial7")
                s8.Text = daMyname.Item("supportingmaterial8")
                remark.Text = daMyname.Item("remarks")

            Else
                daterequest.Text = ""
                activity.Text = ""
                datestart.Text = ""
                dateend.Text = ""
                s1.Text = ""
                s2.Text = ""
                s3.Text = ""
                s4.Text = ""
                s5.Text = ""
                s6.Text = ""
                s7.Text = ""
                s8.Text = ""
                remark.Text = ""

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim myVariable As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        rid.Text = myVariable
    End Sub

    Private Sub rid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rid.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_detail()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_detail()
            sqlconn.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim myVariable As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        rid.Text = myVariable
    End Sub


End Class