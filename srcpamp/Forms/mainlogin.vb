Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class mainlogin
    Private Sub user_pass_case()
        sqlcmd.CommandText = " select * From employee where(username = '" & UsernameTextBox.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader()
        If damyname.HasRows Then
            damyname.Read()
            verifyusername.Text = damyname.Item("username")
            verifypassword.Text = damyname.Item("password")
            firstname.Text = damyname.Item("firstname")
            surname.Text = damyname.Item("surname")
            mname.Text = damyname.Item("mname")
            designation.Text = damyname.Item("designation")
            department.Text = damyname.Item("department")
            account.Text = damyname.Item("accounttype")
            empid.Text = damyname.Item("id")
        Else
            MsgBox("Account is not registered")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub login_system()
        'LOG Session
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call logsession()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call logsession()
            sqlconn.Close()
        End If

        'Log System Session ID
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sysID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sysID()
            sqlconn.Close()
        End If

        If account.Text = "Cashier" Then
            Call cashier()
        ElseIf account.Text = "Administrator" Then
            Call administrator()
        ElseIf account.Text = "Registrar" Then
            Call registrar()
        ElseIf account.Text = "IT" Then
            Call it()
        ElseIf account.Text = "Accountant" Then
            Call accounting()
        ElseIf account.Text = "Accountant-Power User" Then
            Call accountingPU()
        ElseIf account.Text = "Faculty" Then
            Call faculty()
        ElseIf account.Text = "Head Teacher" Then
            Call headteacher()
        ElseIf account.Text = "HR" Then
            Call hr()
        ElseIf account.Text = "Head Librarian" Then
            Call headlibrarian()
        ElseIf account.Text = "Librarian" Then
            Call librarian()
        End If


    End Sub
    Private Sub update_session_status()
        Dim inactive As String = "Inactive"
        Dim active As String = "Active"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE systemLOG SET status = '" & inactive & "' where sessionid = '" & sessionid.Text & "' and username = '" & UsernameTextBox.Text & "' and session = '" & login.Text & "' and status = '" & active & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub log_session_logoff()
        Dim endofsession As String = "End of Session"
        Dim logoff As String = "LOGOFF"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into systemLOG([sessionID],[username],[userpc],[hostname],[ipadd],[domain],[dayTIME],[session],[status]) values ('" & sessionid.Text & "','" & UsernameTextBox.Text & "', " & _
            " '" & PCuser.Text & "'," & _
            " '" & host.Text & "'," & _
            " '" & ip.Text & "'," & _
            " '" & domain.Text & "'," & _
            " '" & dateandtime.Text & "'," & _
            " '" & logoff & "'," & _
            " '" & endofsession & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub verified_session()
        Dim active As String = "Active"
        sqlcmd.CommandText = "select * FROM systemLOG Where (username = '" & UsernameTextBox.Text & "') and (session = '" & login.Text & "')and (status = '" & active & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            daMyname2.Read()
            Dim user As String
            sessionid.Text = daMyname2.Item("sessionID")
            user = daMyname2.Item("hostname")
            Dim result = MessageBox.Show("Previous session of your account still active at '" & user & "' PC. Do you want to end the previous session and start NEW SESSION?", "System Information", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call update_session_status()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_session_status()
                    sqlconn.Close()
                End If

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call log_session_logoff()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call log_session_logoff()
                    sqlconn.Close()
                End If

                Call login_system()

            ElseIf result = DialogResult.No Then
                MsgBox("Please upate your session status to this terminal before creating NEW SESSION.")
                Me.Dispose()
            End If

        Else
            Call login_system()
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click

        If sqlconn.State = ConnectionState.Open Then
            Call user_pass_case()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call user_pass_case()
            sqlconn.Close()
        End If

        If Me.UsernameTextBox.Text = verifyusername.Text And Me.PasswordTextBox.Text = verifypassword.Text And cmbAccounttype.Text = account.Text Then
            'Me.DialogResult = System.Windows.Forms.DialogResult.OK
            If account.Text = "Administrator" Then
                Main.Show()
            ElseIf account.Text = "Registrar" Then
                MainRegistrar.Show()
            ElseIf account.Text = "ELEM Principal" Then
                MainELEM.Show()
            ElseIf account.Text = "JHS Principal" Then
                MainJHS.Show()
            ElseIf account.Text = "SHS Principal" Then
                MainSHS.Show()
            ElseIf account.Text = "IHS Principal" Then
                MainIHS.accttype = "IHS"
                MainIHS.Show()
            ElseIf account.Text = "Dean" Then
                MainCollege.Show()
            End If
            Me.Dispose()
        ElseIf Me.UsernameTextBox.Text <> verifyusername.Text And Me.PasswordTextBox.Text = verifypassword.Text And cmbAccounttype.Text = account.Text Then
            MsgBox("Invalid Username! Username not exist!", MsgBoxStyle.OkOnly, "ERROR")

        ElseIf Me.UsernameTextBox.Text = verifyusername.Text And Me.PasswordTextBox.Text <> verifypassword.Text And cmbAccounttype.Text = account.Text Then
            MsgBox("Incorrect Password", MsgBoxStyle.OkOnly, "ERROR")
        ElseIf Me.UsernameTextBox.Text = verifyusername.Text And Me.PasswordTextBox.Text = verifypassword.Text And cmbAccounttype.Text <> account.Text Then
            MsgBox("Account Type is not set", MsgBoxStyle.OkOnly, "ERROR")
        Else

            PasswordTextBox.Text = ""
        End If

        Main.loguser.Text = firstname.Text
        Main.mname.Text = mname.Text
        Main.surname.Text = surname.Text
        Main.logas.Text = account.Text
        Main.dep.Text = department.Text
        Main.designation.Text = designation.Text
        Main.username.Text = verifyusername.Text
        Main.sysID.Text = sysID.Text
        Main.host.Text = host.Text
        Main.ip.Text = ip.Text
        Main.domain.Text = domain.Text
        Main.PCuser.Text = PCuser.Text
        Main.empid.Text = empid.Text
        Main.Vdtr.Enabled = True
        Main.Vpayslip.Enabled = True
        Main.ChangeUsernameToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PCname()
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        host.Text = strHostName
    End Sub

    Public Function GetLocalIP() As String
        Dim _IP As String = Nothing

        ' Resolves a host name or IP address to an IPHostEntry instance.
        ' IPHostEntry - Provides a container class for Internet host address information. 
        Dim _IPHostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())

        ' IPAddress class contains the address of a computer on an IP network. 
        For Each _IPAddress As System.Net.IPAddress In _IPHostEntry.AddressList
            ' InterNetwork indicates that an IP version 4 address is expected 
            ' when a Socket connects to an endpoint
            If _IPAddress.AddressFamily.ToString() = "InterNetwork" Then
                _IP = _IPAddress.ToString()
            End If
        Next _IPAddress
        Return _IP
    End Function
    Private Sub fetch_accounttype()
        Try
            Dim cmd As New SqlCommand("select accounttype FROM employee " &
                                            "group by accounttype order by accounttype desc;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "curriculum")) Then

                ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
                cmbAccounttype.DataSource = ds.Tables(0)
                cmbAccounttype.ValueMember = "accounttype"
                cmbAccounttype.DisplayMember = "accounttype"
            Else
                cmbAccounttype.DataSource = ""
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub loginform1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        PCname()
        domain.Text = Environment.UserDomainName.ToString
        ip.Text = GetLocalIP()
        PCuser.Text = Environment.UserName.ToString
        dateandtime.Text = Now()

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_accounttype()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_accounttype()
            sqlconn.Close()
        End If

    End Sub
    Private Sub logsession()
        Dim active As String = "Active"
        Dim sessionID As Integer = 0
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into systemLOG([sessionID],[username],[userpc],[hostname],[ipadd],[domain],[dayTIME],[session],[status]) values ('" & sessionID & "','" & UsernameTextBox.Text & "', " & _
            " '" & PCuser.Text & "'," & _
            " '" & host.Text & "'," & _
            " '" & ip.Text & "'," & _
            " '" & domain.Text & "'," & _
            " '" & dateandtime.Text & "'," & _
            " '" & login.Text & "'," & _
            " '" & active & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub fetch_sysID()
        sqlcmd.CommandText = "select * FROM systemLOG Where (username = '" & UsernameTextBox.Text & "') and (hostname = '" & host.Text & "') and (ipadd = '" & ip.Text & "') and (domain = '" & domain.Text & "')  and (dayTIME = '" & dateandtime.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            sysID.Text = daMyname.Item("sysID")
            ' sessionid.Text = daMyname.Item("sysID")
        End If
      
    End Sub
    Private Sub update_sessionID()
        Dim inactive As String = "Inactive"
        Dim active As String = "Active"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE systemLOG SET sessionID = '" & sysID.Text & "' where username = '" & UsernameTextBox.Text & "' and hostname = '" & host.Text & "' and session = '" & login.Text & "' and status = '" & active & "' and dayTIME = '" & dateandtime.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub mainform_userinfo()
        Main.loguser.Text = firstname.Text
        Main.mname.Text = mname.Text
        Main.surname.Text = surname.Text
        Main.logas.Text = account.Text
        Main.dep.Text = department.Text
        Main.designation.Text = designation.Text
        Main.username.Text = verifyusername.Text
        Main.sysID.Text = sysID.Text
        Main.host.Text = host.Text
        Main.ip.Text = ip.Text
        Main.domain.Text = domain.Text
        Main.PCuser.Text = PCuser.Text
        Main.empid.Text = empid.Text
        Main.Vdtr.Enabled = True
        Main.Vpayslip.Enabled = True
        Main.ChangeUsernameToolStripMenuItem.Enabled = True

        If sqlconn.State = ConnectionState.Open Then
            Call update_sessionID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_sessionID()
            sqlconn.Close()
        End If


        Me.Dispose()
    End Sub
    Private Sub administrator()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        Main.CashierToolStripMenuItem.Visible = True
        Main.RegistrarToolStripMenuItem.Visible = True
        Main.AccountingToolStripMenuItem.Visible = True
        Main.ITToolStripMenuItem.Visible = True
        Main.MISToolStripMenuItem.Visible = True
        Main.LibrarianToolStripMenuItem.Visible = True
        Main.FacultyToolStripMenuItem.Visible = True
        Main.HRToolStripMenuItem.Visible = True
        Main.AdministratorToolStripMenuItem.Visible = True
        Main.Test.Enabled = True
        Main.HR.Enabled = True
        Main.headteacher.Enabled = True
        Main.SystemManagementToolStripMenuItem.Enabled = True
        Main.ExitSystem.Enabled = True
        Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True



    End Sub

    Private Sub cashier()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True


    End Sub

    Private Sub registrar()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        Main.LinkLabel1.Enabled = True

        Main.Linklabel3.Enabled = True
        Main.linkstudentreport.Enabled = True
        Main.linkschedule.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True

        'Main.schedulinglink.Enabled = True

    End Sub
    Private Sub it()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        Main.ITToolStripMenuItem.Visible = True
        Main.MISToolStripMenuItem.Visible = True
        Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True


    End Sub
    Private Sub accountingPU()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        Main.CashierToolStripMenuItem.Visible = True
        'Main.PaymentToolStripMenuItem.Enabled = False
        'Main.RegistrarToolStripMenuItem.Visible = True
        Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        Main.AdministratorToolStripMenuItem.Visible = True
        Main.Test.Enabled = False
        Main.HR.Enabled = False
        Main.headteacher.Enabled = False
        Main.SystemManagementToolStripMenuItem.Enabled = False
        Main.ExitSystem.Enabled = False
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True

    End Sub

    Private Sub accounting()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        Main.CashierToolStripMenuItem.Visible = True
        'Main.PaymentToolStripMenuItem.Enabled = False
        'Main.RegistrarToolStripMenuItem.Visible = True
        Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        Main.AdministratorToolStripMenuItem.Visible = True
        Main.Test.Enabled = False
        Main.HR.Enabled = False
        Main.headteacher.Enabled = False
        Main.SystemManagementToolStripMenuItem.Enabled = False
        Main.ExitSystem.Enabled = False
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True

    End Sub
    Private Sub librarian()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True

    End Sub
    Private Sub headlibrarian()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True


    End Sub

    Private Sub headteacher()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        Main.FacultyToolStripMenuItem.Visible = True
        Main.AdministratorToolStripMenuItem.Visible = True
        Main.Test.Enabled = False
        Main.HR.Enabled = False
        Main.Accounting.Enabled = False
        'Main.headteacher.Enabled = False
        Main.SystemManagementToolStripMenuItem.Enabled = False
        Main.ExitSystem.Enabled = False
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True


    End Sub

    Private Sub faculty()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        'Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        Main.FacultyToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True


    End Sub

    Private Sub hr()

        Call mainform_userinfo()

        Main.ChangePasswordToolStripMenuItem.Enabled = True
        'Main.CashierToolStripMenuItem.Visible = True
        'Main.RegistrarToolStripMenuItem.Visible = True
        'Main.AccountingToolStripMenuItem.Visible = True
        'Main.ITToolStripMenuItem.Visible = True
        Main.MISToolStripMenuItem.Visible = True
        'Main.LibrarianToolStripMenuItem.Visible = True
        'Main.FacultyToolStripMenuItem.Visible = True
        Main.HRToolStripMenuItem.Visible = True
        'Main.AdministratorToolStripMenuItem.Visible = True
        'Main.registrationlink.Enabled = True
        Main.searchlink.Enabled = True
        'Main.assessmentlink.Enabled = True
        'Main.ledgerlink.Enabled = True
        'Main.billinglink.Enabled = True
        'Main.capturelink.Enabled = True
        'Main.schedulinglink.Enabled = True

    End Sub
End Class
