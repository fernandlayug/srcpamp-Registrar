Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.SqlClient
Imports System.IO

Public Class Main
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        registration.ShowDialog()
    End Sub

    Private Sub StudentLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub AssessmentInquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessmentInquiryToolStripMenuItem.Click
       
    End Sub

    Private Sub PhotoCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoCaptureToolStripMenuItem.Click
        Dim frmphotocap As New photocap
        frmphotocap.Show()
    End Sub

    Private Sub SearchIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchIDToolStripMenuItem.Click
        Dim frmsearchid As New searchid
        frmsearchid.Show()
        'frmsearchid.MdiParent = Me
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then e.Cancel = True
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        sqlserver.connect()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call ActiveSchoolYear()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call ActiveSchoolYear()
            sqlconn.Close()
        End If


        ' DisableCloseButton(Me.Handle)


        'AxShockwaveFlash3.Rewind()
        'AxShockwaveFlash3.Loop = True


        datetoday.Text = Format(Now, "Long Date")

        '  Declare a variable for Sys Reflection Assy
        Dim sra As System.Reflection.Assembly
        '  Dec for the Copyright Attribute
        Dim copyrtAttr As System.Reflection.AssemblyCopyrightAttribute
        ' Get the current executing Assembly 
        sra = System.Reflection.Assembly.GetExecutingAssembly
        ' Get the Copyright Attribute via Sys Refl Assy
        copyrtAttr = sra.GetCustomAttributes(GetType(System.Reflection.AssemblyCopyrightAttribute), False)(0)
        '   Display it
        Label5.Text = copyrtAttr.Copyright


        Dim strMajorVersion, strMinorVersion, strBuildVersion, strRevisionVersion As String
        'Dim strRevisionVersion As String

        strMajorVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major()
        strMinorVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor()
        strBuildVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build()
        strRevisionVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision()

        Label6.Text = "Version - " & strMajorVersion & "." & strMinorVersion & "." & strBuildVersion & "." & strRevisionVersion & ""
        'Label6.Text = "Version - " & strRevisionVersion & ""

        'Dim frmmainlogin As New mainlogin
        'frmmainlogin.ShowDialog()
    End Sub

    Private Sub FacilitySchedulingSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilitySchedulingSystemToolStripMenuItem.Click
        Dim frmmain As New frmMain
        frmmain.Show()
        frmmain.MdiParent = Me
    End Sub




    Public Sub registrationlink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles registrationlink.LinkClicked
        registration.ShowDialog()
    End Sub

    Private Sub searchlink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles searchlink.LinkClicked
        Dim frmsearchid As New searchid
        frmsearchid.Show()
        'frmsearchid.MdiParent = Me
    End Sub



    Private Sub schedulinglink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim frmmain As New frmMain
        frmmain.Show()
        frmmain.MdiParent = Me
    End Sub










    Private Sub SYEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmsy As New frmsy
        frmsy.Show()
        frmsy.MdiParent = Me

    End Sub
    Private Sub AddParticularCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddParticularCategoryToolStripMenuItem.Click
        Dim frm As New Category
        frm.Show()
        frm.MdiParent = Me

    End Sub
    Private Sub RegisterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterUserToolStripMenuItem.Click
        Dim frmuser As New frmuser
        frmuser.Show()
        frmuser.MdiParent = Me

    End Sub

    Private Sub StudentAccountSummaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub update_session_status()
        Dim inactive As String = "Inactive"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE systemLOG SET status = '" & inactive & "' where sessionID = '" & sysID.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub log_session_logoff()
        Dim endofsession As String = "End of Session"
        Dim logoff As String = "LOGOFF"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into systemLOG([sessionID],[username],[userpc],[hostname],[ipadd],[domain],[dayTIME],[session],[status]) values ('" & sysID.Text & "','" & username.Text & "', " &
            " '" & PCuser.Text & "'," &
            " '" & host.Text & "'," &
            " '" & ip.Text & "'," &
            " '" & domain.Text & "'," &
            " '" & dateandtime.Text & "'," &
            " '" & logoff & "'," &
            " '" & endofsession & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub verify_session_status()
        Dim inactive As String = "End of Session"
        sqlcmd.CommandText = "select * FROM systemLOG Where (sessionID = '" & sysID.Text & "') and (status = '" & inactive & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            daMyname2.Read()
            Dim host As String
            Dim username As String
            host = daMyname2.Item("hostname")
            username = daMyname2.Item("username")
            MsgBox("You've been logged off at '" & host & "' PC by '" & username & "'.")

            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next

            Call logoff_status()



        Else

            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
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

            Call logoff_status()


        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim frm As New frmView
        frm.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim frm As New changepass
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub UpdateStudentInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentInformationToolStripMenuItem.Click
        Dim frm As New modifyrecord
        frm.Show()
    End Sub

    Private Sub ChangeStudentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeStudentStatusToolStripMenuItem.Click
        Dim frmstatus As New frmstatus
        frmstatus.Show()
    End Sub

    Private Sub ExitSystemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitSystem.Click
        Me.Dispose()
    End Sub



    Private Sub intranet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New intranetmessage
        frm.Show()
    End Sub
    Private Sub SectionNameEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionNameEntryToolStripMenuItem.Click
        Dim frm As New frmsection
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ManageFacultyLoadsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageFacultyLoadsToolStripMenuItem.Click
        Dim frm As New frmfacultyassign
        frm.Show()
    End Sub

    Private Sub ManageSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageSubjectToolStripMenuItem.Click
        Dim frm As New frmSubject
        frm.Show()
    End Sub

    Private Sub ClassManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassManagementToolStripMenuItem.Click
        Dim frm As New classmanagement
        frm.Show()
        frm.MdiParent = Me

    End Sub

    Private Sub SectioningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectioningToolStripMenuItem.Click
        Dim frm As New frmSectioning
        frm.ShowDialog()

    End Sub

    Private Sub ProcessTransferSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessTransferSectionToolStripMenuItem.Click
        Dim frm As New frmtransferSECTION
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ViewStudentSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentSectionToolStripMenuItem.Click
        Dim frm As New onprocess
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ClassRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassRecordToolStripMenuItem.Click
        Dim frm As New onprocess
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ChangeUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUsernameToolStripMenuItem.Click
        Dim frm As New changeuser
        frm.Show()
        frm.MdiParent = Me
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New registrationtemp
        frm.ShowDialog()
        CenterToScreen()
    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentInformationToolStripMenuItem.Click
        studentfile.ShowDialog()

    End Sub



    Private Sub schedulingimage_MouseHover(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmStudentFileOption.FormName = host.Text
        frmStudentFileOption.ShowDialog()

    End Sub

    Private Sub schedulinglink_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Linklabel3.LinkClicked
        Dim frm As New frmCurriculumOption
        frm.ShowDialog()
        'frmSubjectCurrentSked.ShowDialog()
    End Sub

    Private Sub linkstudentreport_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkstudentreport.LinkClicked
        frmSubjectStudentOption.cay = SY.Text
        'frmSubjectStudentOption.TextBox1.Text = SY.Text
        frmSubjectStudentOption.ShowDialog()
    End Sub

    Private Sub linkschedule_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkschedule.LinkClicked
        frmSubjectScheduleOption.ShowDialog()
    End Sub

    Private Sub SubjectManagementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubjectManagementToolStripMenuItem.Click
        SearchSubject.ShowDialog()
    End Sub
    Private Sub ActiveSchoolYear()
        Dim cmdSY As New SqlCommand("select * From sy ORDER BY sy_id DESC;", sqlconn)
        Dim adptSY As New SqlDataAdapter(cmdSY)
        Dim ds_SY As New DataSet()
        If (adptSY.Fill(ds_SY, "sy")) Then

            'ds_SY.Tables(0).Rows.InsertAt(ds_SY.Tables(0).NewRow(), 0)
            SY.DataSource = ds_SY.Tables(0)
            SY.ValueMember = "sy"
            SY.DisplayMember = "sy"

        End If
    End Sub


    Private Sub Vpayslip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Vpayslip.LinkClicked
        Dim frm As New rptpayslip
        frm.ShowDialog()

    End Sub

    Private Sub Vdtr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Vdtr.LinkClicked
        Dim frm As New att
        frm.ShowDialog()
    End Sub

    Private Sub ExportStudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportStudentListToolStripMenuItem.Click
        Dim frm As New frmExportExcel
        frm.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim frm As New frmImport
        frm.ShowDialog()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim frm As New search_tempregistered
        frm.ShowDialog()
    End Sub

    Private Sub ExitSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitSystemToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim frm As New registrationtemp
        frm.ShowDialog()
        CenterToScreen()
    End Sub
End Class
