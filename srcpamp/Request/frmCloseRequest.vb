Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmCloseRequest

    Private Sub frmCloseRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

    End Sub

    Private Sub reqid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles reqid.Leave
        sqlcmd.CommandText = " select * From facilityrequest where(requestid = '" & reqid.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader()
        If damyname.HasRows Then
            damyname.Read()
            ID.Text = damyname.Item("ID")
            requestername.Text = damyname.Item("requester")
            facility.Text = damyname.Item("facility")
            activity.Text = damyname.Item("activity")
            loc_room.Text = damyname.Item("room_location")
            department.Text = damyname.Item("department")
            dateusestart.Text = damyname.Item("dateusestart")
            dateuseend.Text = damyname.Item("dateuseend")
            timestart.Text = damyname.Item("timestart")
            timeend.Text = damyname.Item("timeend")
            systemunit1.Text = damyname.Item("supportmaterial1")
            extensioncord1.Text = damyname.Item("supportingmaterial2")
            speaker1.Text = damyname.Item("supportingmaterial3")
            wirelessmic1.Text = damyname.Item("supportingmaterial4")
            audiojack1.Text = damyname.Item("supportingmaterial5")
            whitescreen1.Text = damyname.Item("supportingmaterial6")
            dvdplayer1.Text = damyname.Item("supportingmaterial7")
            others.Text = damyname.Item("supportingmaterial8")
            status.Text = damyname.Item("status")
            If systemunit1.Text = "System Unit" Then
                systemunit.Checked = True
            End If
            If extensioncord1.Text = "Extension Cord" Then
                extensioncord.Checked = True
            End If
            If speaker1.Text = "Speaker" Then
                speaker.Checked = True
            End If
            If wirelessmic1.Text = "Wireless Microphone" Then
                wirelessmic.Checked = True
            End If
            If audiojack1.Text = "Audio Jack" Then
                audiojack.Checked = True
            End If
            If whitescreen1.Text = "White Screen" Then
                whitescreen.Checked = True
            End If
            If dvdplayer1.Text = "DVD Player" Then
                dvdplayer.Checked = True
            End If
          
        End If
      
        sqlconn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub


    Private Sub requestdone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles requestdone.CheckedChanged
        If requestdone.Checked = True Then
            cancelrequest.Enabled = False
            status.Text = "Done"
        Else
            cancelrequest.Enabled = True
            status.Text = ""
        End If
    End Sub

    Private Sub cancelrequest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelrequest.CheckedChanged
        If cancelrequest.Checked = True Then
            requestdone.Enabled = False
            status.Text = "Cancel"
        Else
            requestdone.Enabled = True
            status.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlconn.Open()

        Dim sqlcmd As New SqlClient.SqlCommand
        
        strsql = "UPDATE facilityrequest SET status = '" & status.Text & "',remarks = '" & remarks.Text & "' where requestid = '" & reqid.Text & "'"

        Dim result = MessageBox.Show("Are you sure you want to save the Information", "Student Information", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
        End If

    End Sub
End Class