Imports System.Data.SqlClient

Public Class frmRequest
    Private Sub display_requestID()
        sqlcmd.CommandText = "Select * From facilityrequest where (requester = '" & requestername.Text & "') and (activity = '" & activity.Text & "') and (room_location = '" & loc_room.Text & "') and (department = '" & department.Text & "') and (facility = '" & facility.Text & "') and (dateusestart = '" & dateusestart.Text & "') and (timestart = '" & timestart.Text & "') and (timeend = '" & timeend.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim damyname2 As SqlDataReader
        damyname2 = sqlcmd.ExecuteReader()
        If damyname2.HasRows Then
            damyname2.Read()
            id.Text = damyname2.Item("requestid")
        End If
    End Sub
    Private Sub save_request()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into facilityrequest ([ID],[requester],[facility],[activity],[room_location],[department],[dateusestart],[dateuseend],[timestart],[timeend],[daterequested],[supportmaterial1],[supportingmaterial2],[supportingmaterial3],[supportingmaterial4],[supportingmaterial5],[supportingmaterial6],[supportingmaterial7],[supportingmaterial8],[status]) values ('" & reqID.Text & "','" & requestername.Text & "','" & facility.Text & "','" & activity.Text & "','" & loc_room.Text & "','" & department.Text & "','" & dateusestart.Text & "','" & dateuseend.Text & "','" & timestart.Text & "','" & timeend.Text & "','" & today.Text & "','" & systemunit1.Text & "','" & extensioncord1.Text & "','" & speaker1.Text & "','" & wirelessmic1.Text & "','" & audiojack1.Text & "','" & whitescreen1.Text & "','" & dvdplayer1.Text & "','" & others.Text & "','" & stats.Text & "')"
        If String.IsNullOrEmpty(requestername.Text) Then
            MessageBox.Show("Please enter Requester Name")
            requestername.Focus()
        ElseIf String.IsNullOrEmpty(facility.Text) Then
            MessageBox.Show("Please enter Facility Request")
            facility.Focus()
        ElseIf String.IsNullOrEmpty(activity.Text) Then
            MessageBox.Show("Please enter Activity")
            activity.Focus()
        ElseIf String.IsNullOrEmpty(loc_room.Text) Then
            MessageBox.Show("Please enter Room / Location of the Event")
            loc_room.Focus()
        ElseIf String.IsNullOrEmpty(department.Text) Then
            MessageBox.Show("Please enter Department")
            department.Focus()
        ElseIf String.IsNullOrEmpty(dateusestart.Text) Then
            MessageBox.Show("Please enter the Date of Use")
            dateusestart.Focus()
        ElseIf String.IsNullOrEmpty(timestart.Text) Then
            MessageBox.Show("Please enter the Start Time")
            timestart.Focus()
        ElseIf String.IsNullOrEmpty(timeend.Text) Then
            MessageBox.Show("Please enter End Time")
            timeend.Focus()
        Else
            Dim result = MessageBox.Show("Are you sure you want to add the Request?", "Request", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then

                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlconn
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Request Added!")

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call display_requestID()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call display_requestID()
                    sqlconn.Close()
                End If

            ElseIf result = DialogResult.No Then
                Me.Dispose()

            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Please check all the information")
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call save_request()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call save_request()
            sqlconn.Close()
        End If
    End Sub

    Private Sub frmRequest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub frmRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        stats.Text = "Open"
        reqID.Focus()
        'ComboBox for Facility

        Dim cmdfacility As New SqlCommand("select * FROM facility;", sqlconn)
        Dim adptfacility As New SqlDataAdapter(cmdfacility)
        Dim ds_facility As New DataSet()
        If (adptfacility.Fill(ds_facility, "facility")) Then

            ds_facility.Tables(0).Rows.InsertAt(ds_facility.Tables(0).NewRow(), 0)

            facility.DataSource = ds_facility.Tables(0)
            facility.ValueMember = "facilityname"
            facility.DisplayMember = "facilityname"

        End If
    End Sub

    Private Sub systemunit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles systemunit.CheckedChanged
        If systemunit.Checked = True Then
            systemunit1.Text = "System Unit"
        Else
            systemunit1.Text = ""
        End If
    End Sub

    Private Sub extensioncord_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles extensioncord.CheckedChanged
        If extensioncord.Checked = True Then
            extensioncord1.Text = "Extension Cord"
        Else
            extensioncord1.Text = ""
        End If
    End Sub

    Private Sub speaker_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles speaker.CheckedChanged
        If speaker.Checked = True Then
            speaker1.Text = "Speaker"
        Else
            speaker.Text = ""
        End If
    End Sub

    Private Sub wirelessmic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wirelessmic.CheckedChanged
        If wirelessmic.Checked = True Then
            wirelessmic1.Text = "Wireless Microphone"
        Else
            wirelessmic1.Text = ""
        End If
    End Sub

    Private Sub audiojack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles audiojack.CheckedChanged
        If audiojack.Checked = True Then
            audiojack1.Text = "Audio Jack"
        Else
            audiojack1.Text = ""
        End If
    End Sub

    Private Sub whitescreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whitescreen.CheckedChanged
        If whitescreen.Checked = True Then
            whitescreen1.Text = "White Screen"
        Else
            whitescreen1.Text = ""
        End If
    End Sub

    Private Sub dvdplayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdplayer.CheckedChanged
        If dvdplayer.Checked = True Then
            dvdplayer1.Text = "DVD Player"
        Else
            dvdplayer1.Text = ""
        End If
    End Sub


  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmView.Show()
        frmView.WindowState = FormWindowState.Normal
    End Sub

    Private Sub fetch_studentID()

        Try

            sqlcmd.CommandText = "select * FROM studentdata Where (studentid = '" & reqID.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname2 As SqlDataReader
            daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
            If daMyname2.HasRows Then
                daMyname2.Read()
                firstname.Text = daMyname2.Item("firstname")
                mname.Text = daMyname2.Item("mname")
                surname.Text = daMyname2.Item("surname")
                daMyname2.Close()
            Else
            End If
            Dim space As String = " "

            requestername.Text = firstname.Text + space + mname.Text + space + surname.Text
        Catch ex As Exception
        End Try

    End Sub

    Private Sub fetch_empID()

        Try

            sqlcmd.CommandText = "select * FROM employee Where (id = '" & reqID.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname2 As SqlDataReader
            daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
            If daMyname2.HasRows Then
                daMyname2.Read()
                firstname.Text = daMyname2.Item("firstname")
                mname.Text = daMyname2.Item("mname")
                surname.Text = daMyname2.Item("surname")
                daMyname2.Close()
            Else
            End If
            Dim space As String = " "
            requestername.Text = firstname.Text + space + mname.Text + space + surname.Text
        Catch ex As Exception
        End Try
    End Sub


    Private Sub reqID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles reqID.Leave
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_studentID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentID()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_empID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_empID()
            sqlconn.Close()
        End If
    End Sub
End Class