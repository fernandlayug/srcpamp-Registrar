<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSubjectStudentsBE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCourseID = New System.Windows.Forms.Label()
        Me.txtLevelID = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtsubjectid = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnEnrollees = New System.Windows.Forms.Button()
        Me.groupCourse = New System.Windows.Forms.GroupBox()
        Me.txtMajor = New System.Windows.Forms.Label()
        Me.txtcoursename = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAlphalistSection = New System.Windows.Forms.Button()
        Me.btnAlphalist = New System.Windows.Forms.Button()
        Me.txtFacultyID = New System.Windows.Forms.Label()
        Me.txtcoursecode = New System.Windows.Forms.Label()
        Me.txtclassscheduleid = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtPrint = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.txtday = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.Label()
        Me.txtroom = New System.Windows.Forms.Label()
        Me.txtlevel = New System.Windows.Forms.Label()
        Me.groupSubject = New System.Windows.Forms.GroupBox()
        Me.sectionid = New System.Windows.Forms.Label()
        Me.classscheduleid = New System.Windows.Forms.Label()
        Me.courseid = New System.Windows.Forms.Label()
        Me.txtfaculty = New System.Windows.Forms.TextBox()
        Me.txtclassid = New System.Windows.Forms.TextBox()
        Me.tabFaculty = New System.Windows.Forms.TabPage()
        Me.chkJuniorHSFaculty = New System.Windows.Forms.RadioButton()
        Me.chkElementaryFaculty = New System.Windows.Forms.RadioButton()
        Me.dtFaculty = New System.Windows.Forms.DataGridView()
        Me.tabCourse = New System.Windows.Forms.TabPage()
        Me.btnPrintSection = New System.Windows.Forms.Button()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbAYCourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTermCourse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLevelCourse = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkJuniorHS = New System.Windows.Forms.RadioButton()
        Me.chkElementary = New System.Windows.Forms.RadioButton()
        Me.TabPrint = New System.Windows.Forms.TabControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.groupCourse.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSubject.SuspendLayout()
        Me.tabFaculty.SuspendLayout()
        CType(Me.dtFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCourse.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCourseID
        '
        Me.txtCourseID.AutoSize = True
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(905, 9)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(64, 16)
        Me.txtCourseID.TabIndex = 288
        Me.txtCourseID.Text = "CourseID"
        Me.txtCourseID.Visible = False
        '
        'txtLevelID
        '
        Me.txtLevelID.AutoSize = True
        Me.txtLevelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelID.Location = New System.Drawing.Point(201, 0)
        Me.txtLevelID.Name = "txtLevelID"
        Me.txtLevelID.Size = New System.Drawing.Size(54, 16)
        Me.txtLevelID.TabIndex = 289
        Me.txtLevelID.Text = "LevelID"
        Me.txtLevelID.Visible = False
        '
        'txtTerm
        '
        Me.txtTerm.AutoSize = True
        Me.txtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(715, 0)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(12, 16)
        Me.txtTerm.TabIndex = 292
        Me.txtTerm.Text = "-"
        Me.txtTerm.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(9, 531)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(239, 28)
        Me.btnClose.TabIndex = 293
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtsubjectid
        '
        Me.txtsubjectid.AutoSize = True
        Me.txtsubjectid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectid.Location = New System.Drawing.Point(1082, 2)
        Me.txtsubjectid.Name = "txtsubjectid"
        Me.txtsubjectid.Size = New System.Drawing.Size(12, 16)
        Me.txtsubjectid.TabIndex = 296
        Me.txtsubjectid.Text = "-"
        Me.txtsubjectid.Visible = False
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(29, 464)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(191, 32)
        Me.btnSummary.TabIndex = 311
        Me.btnSummary.Text = "Print Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnEnrollees
        '
        Me.btnEnrollees.Location = New System.Drawing.Point(19, 13)
        Me.btnEnrollees.Name = "btnEnrollees"
        Me.btnEnrollees.Size = New System.Drawing.Size(191, 32)
        Me.btnEnrollees.TabIndex = 310
        Me.btnEnrollees.Text = "Print Course Enrollees"
        Me.btnEnrollees.UseVisualStyleBackColor = True
        '
        'groupCourse
        '
        Me.groupCourse.Controls.Add(Me.txtMajor)
        Me.groupCourse.Controls.Add(Me.txtcoursename)
        Me.groupCourse.Controls.Add(Me.Label8)
        Me.groupCourse.Controls.Add(Me.Label7)
        Me.groupCourse.Location = New System.Drawing.Point(263, 12)
        Me.groupCourse.Name = "groupCourse"
        Me.groupCourse.Size = New System.Drawing.Size(851, 68)
        Me.groupCourse.TabIndex = 298
        Me.groupCourse.TabStop = False
        Me.groupCourse.Text = "Course Information"
        Me.groupCourse.Visible = False
        '
        'txtMajor
        '
        Me.txtMajor.AutoSize = True
        Me.txtMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMajor.ForeColor = System.Drawing.Color.Blue
        Me.txtMajor.Location = New System.Drawing.Point(65, 41)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(0, 16)
        Me.txtMajor.TabIndex = 312
        '
        'txtcoursename
        '
        Me.txtcoursename.AutoSize = True
        Me.txtcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoursename.ForeColor = System.Drawing.Color.Blue
        Me.txtcoursename.Location = New System.Drawing.Point(75, 21)
        Me.txtcoursename.Name = "txtcoursename"
        Me.txtcoursename.Size = New System.Drawing.Size(12, 16)
        Me.txtcoursename.TabIndex = 311
        Me.txtcoursename.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "Major:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 299
        Me.Label7.Text = "Course:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAlphalistSection)
        Me.GroupBox2.Controls.Add(Me.btnEnrollees)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 87)
        Me.GroupBox2.TabIndex = 313
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Print"
        '
        'btnAlphalistSection
        '
        Me.btnAlphalistSection.Location = New System.Drawing.Point(18, 53)
        Me.btnAlphalistSection.Name = "btnAlphalistSection"
        Me.btnAlphalistSection.Size = New System.Drawing.Size(191, 26)
        Me.btnAlphalistSection.TabIndex = 312
        Me.btnAlphalistSection.Text = "Print Alphalist per Section"
        Me.btnAlphalistSection.UseVisualStyleBackColor = True
        '
        'btnAlphalist
        '
        Me.btnAlphalist.Location = New System.Drawing.Point(29, 499)
        Me.btnAlphalist.Name = "btnAlphalist"
        Me.btnAlphalist.Size = New System.Drawing.Size(191, 28)
        Me.btnAlphalist.TabIndex = 312
        Me.btnAlphalist.Text = "Print Alphalist"
        Me.btnAlphalist.UseVisualStyleBackColor = True
        '
        'txtFacultyID
        '
        Me.txtFacultyID.AutoSize = True
        Me.txtFacultyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacultyID.Location = New System.Drawing.Point(287, -6)
        Me.txtFacultyID.Name = "txtFacultyID"
        Me.txtFacultyID.Size = New System.Drawing.Size(12, 16)
        Me.txtFacultyID.TabIndex = 314
        Me.txtFacultyID.Text = "-"
        Me.txtFacultyID.Visible = False
        '
        'txtcoursecode
        '
        Me.txtcoursecode.AutoSize = True
        Me.txtcoursecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoursecode.Location = New System.Drawing.Point(683, 0)
        Me.txtcoursecode.Name = "txtcoursecode"
        Me.txtcoursecode.Size = New System.Drawing.Size(12, 16)
        Me.txtcoursecode.TabIndex = 313
        Me.txtcoursecode.Text = "-"
        Me.txtcoursecode.Visible = False
        '
        'txtclassscheduleid
        '
        Me.txtclassscheduleid.AutoSize = True
        Me.txtclassscheduleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclassscheduleid.Location = New System.Drawing.Point(1136, 185)
        Me.txtclassscheduleid.Name = "txtclassscheduleid"
        Me.txtclassscheduleid.Size = New System.Drawing.Size(12, 16)
        Me.txtclassscheduleid.TabIndex = 314
        Me.txtclassscheduleid.Text = "-"
        Me.txtclassscheduleid.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1136, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 16)
        Me.Label15.TabIndex = 315
        Me.Label15.Text = "-"
        Me.Label15.Visible = False
        '
        'dtPrint
        '
        Me.dtPrint.AllowUserToAddRows = False
        Me.dtPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtPrint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtPrint.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtPrint.Location = New System.Drawing.Point(263, 86)
        Me.dtPrint.Name = "dtPrint"
        Me.dtPrint.Size = New System.Drawing.Size(850, 473)
        Me.dtPrint.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 299
        Me.Label10.Text = "Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 300
        Me.Label9.Text = "Subject:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(151, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 301
        Me.Label11.Text = "Day:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(239, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 302
        Me.Label12.Text = "Time:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(478, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 303
        Me.Label13.Text = "Room:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(686, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 16)
        Me.Label14.TabIndex = 304
        Me.Label14.Text = "Yr. Level:"
        '
        'txtSubject
        '
        Me.txtSubject.AutoSize = True
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.ForeColor = System.Drawing.Color.Blue
        Me.txtSubject.Location = New System.Drawing.Point(77, 22)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(0, 16)
        Me.txtSubject.TabIndex = 305
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.Blue
        Me.txtcode.Location = New System.Drawing.Point(57, 42)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(0, 16)
        Me.txtcode.TabIndex = 306
        '
        'txtday
        '
        Me.txtday.AutoSize = True
        Me.txtday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtday.ForeColor = System.Drawing.Color.Blue
        Me.txtday.Location = New System.Drawing.Point(191, 42)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(0, 16)
        Me.txtday.TabIndex = 307
        '
        'txttime
        '
        Me.txttime.AutoSize = True
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.ForeColor = System.Drawing.Color.Blue
        Me.txttime.Location = New System.Drawing.Point(286, 42)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(0, 16)
        Me.txttime.TabIndex = 308
        '
        'txtroom
        '
        Me.txtroom.AutoSize = True
        Me.txtroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroom.ForeColor = System.Drawing.Color.Blue
        Me.txtroom.Location = New System.Drawing.Point(529, 42)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(0, 16)
        Me.txtroom.TabIndex = 309
        '
        'txtlevel
        '
        Me.txtlevel.AutoSize = True
        Me.txtlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlevel.ForeColor = System.Drawing.Color.Blue
        Me.txtlevel.Location = New System.Drawing.Point(764, 42)
        Me.txtlevel.Name = "txtlevel"
        Me.txtlevel.Size = New System.Drawing.Size(0, 16)
        Me.txtlevel.TabIndex = 310
        '
        'groupSubject
        '
        Me.groupSubject.Controls.Add(Me.txtlevel)
        Me.groupSubject.Controls.Add(Me.txtroom)
        Me.groupSubject.Controls.Add(Me.txttime)
        Me.groupSubject.Controls.Add(Me.txtday)
        Me.groupSubject.Controls.Add(Me.txtcode)
        Me.groupSubject.Controls.Add(Me.txtSubject)
        Me.groupSubject.Controls.Add(Me.Label14)
        Me.groupSubject.Controls.Add(Me.Label13)
        Me.groupSubject.Controls.Add(Me.Label12)
        Me.groupSubject.Controls.Add(Me.Label11)
        Me.groupSubject.Controls.Add(Me.Label9)
        Me.groupSubject.Controls.Add(Me.Label10)
        Me.groupSubject.Location = New System.Drawing.Point(262, 13)
        Me.groupSubject.Name = "groupSubject"
        Me.groupSubject.Size = New System.Drawing.Size(851, 68)
        Me.groupSubject.TabIndex = 301
        Me.groupSubject.TabStop = False
        Me.groupSubject.Text = "Subject Information"
        Me.groupSubject.Visible = False
        '
        'sectionid
        '
        Me.sectionid.AutoSize = True
        Me.sectionid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionid.Location = New System.Drawing.Point(397, -6)
        Me.sectionid.Name = "sectionid"
        Me.sectionid.Size = New System.Drawing.Size(12, 16)
        Me.sectionid.TabIndex = 316
        Me.sectionid.Text = "-"
        Me.sectionid.Visible = False
        '
        'classscheduleid
        '
        Me.classscheduleid.AutoSize = True
        Me.classscheduleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classscheduleid.Location = New System.Drawing.Point(548, 0)
        Me.classscheduleid.Name = "classscheduleid"
        Me.classscheduleid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.classscheduleid.Size = New System.Drawing.Size(12, 16)
        Me.classscheduleid.TabIndex = 317
        Me.classscheduleid.Text = "-"
        Me.classscheduleid.Visible = False
        '
        'courseid
        '
        Me.courseid.AutoSize = True
        Me.courseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseid.Location = New System.Drawing.Point(595, 2)
        Me.courseid.Name = "courseid"
        Me.courseid.Size = New System.Drawing.Size(12, 16)
        Me.courseid.TabIndex = 318
        Me.courseid.Text = "-"
        Me.courseid.Visible = False
        '
        'txtfaculty
        '
        Me.txtfaculty.Location = New System.Drawing.Point(940, 1)
        Me.txtfaculty.Name = "txtfaculty"
        Me.txtfaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtfaculty.TabIndex = 319
        Me.txtfaculty.Visible = False
        '
        'txtclassid
        '
        Me.txtclassid.Location = New System.Drawing.Point(813, 1)
        Me.txtclassid.Name = "txtclassid"
        Me.txtclassid.Size = New System.Drawing.Size(100, 20)
        Me.txtclassid.TabIndex = 320
        Me.txtclassid.Visible = False
        '
        'tabFaculty
        '
        Me.tabFaculty.Controls.Add(Me.chkJuniorHSFaculty)
        Me.tabFaculty.Controls.Add(Me.chkElementaryFaculty)
        Me.tabFaculty.Controls.Add(Me.dtFaculty)
        Me.tabFaculty.Location = New System.Drawing.Point(4, 22)
        Me.tabFaculty.Name = "tabFaculty"
        Me.tabFaculty.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFaculty.Size = New System.Drawing.Size(239, 334)
        Me.tabFaculty.TabIndex = 2
        Me.tabFaculty.Text = "Faculty"
        Me.tabFaculty.UseVisualStyleBackColor = True
        '
        'chkJuniorHSFaculty
        '
        Me.chkJuniorHSFaculty.AutoSize = True
        Me.chkJuniorHSFaculty.Location = New System.Drawing.Point(124, 6)
        Me.chkJuniorHSFaculty.Name = "chkJuniorHSFaculty"
        Me.chkJuniorHSFaculty.Size = New System.Drawing.Size(71, 17)
        Me.chkJuniorHSFaculty.TabIndex = 318
        Me.chkJuniorHSFaculty.TabStop = True
        Me.chkJuniorHSFaculty.Text = "Junior HS"
        Me.chkJuniorHSFaculty.UseVisualStyleBackColor = True
        '
        'chkElementaryFaculty
        '
        Me.chkElementaryFaculty.AutoSize = True
        Me.chkElementaryFaculty.Location = New System.Drawing.Point(13, 6)
        Me.chkElementaryFaculty.Name = "chkElementaryFaculty"
        Me.chkElementaryFaculty.Size = New System.Drawing.Size(77, 17)
        Me.chkElementaryFaculty.TabIndex = 317
        Me.chkElementaryFaculty.TabStop = True
        Me.chkElementaryFaculty.Text = "Elementary"
        Me.chkElementaryFaculty.UseVisualStyleBackColor = True
        '
        'dtFaculty
        '
        Me.dtFaculty.AllowUserToAddRows = False
        Me.dtFaculty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFaculty.Location = New System.Drawing.Point(8, 29)
        Me.dtFaculty.Name = "dtFaculty"
        Me.dtFaculty.Size = New System.Drawing.Size(225, 299)
        Me.dtFaculty.TabIndex = 316
        '
        'tabCourse
        '
        Me.tabCourse.Controls.Add(Me.btnPrintSection)
        Me.tabCourse.Controls.Add(Me.cmbSection)
        Me.tabCourse.Controls.Add(Me.Label19)
        Me.tabCourse.Controls.Add(Me.cmbAYCourse)
        Me.tabCourse.Controls.Add(Me.Label5)
        Me.tabCourse.Controls.Add(Me.cmbTermCourse)
        Me.tabCourse.Controls.Add(Me.Label4)
        Me.tabCourse.Controls.Add(Me.cmbLevelCourse)
        Me.tabCourse.Controls.Add(Me.Label2)
        Me.tabCourse.Controls.Add(Me.GroupBox3)
        Me.tabCourse.Location = New System.Drawing.Point(4, 22)
        Me.tabCourse.Name = "tabCourse"
        Me.tabCourse.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCourse.Size = New System.Drawing.Size(239, 334)
        Me.tabCourse.TabIndex = 0
        Me.tabCourse.Text = "Course"
        Me.tabCourse.UseVisualStyleBackColor = True
        '
        'btnPrintSection
        '
        Me.btnPrintSection.Location = New System.Drawing.Point(20, 296)
        Me.btnPrintSection.Name = "btnPrintSection"
        Me.btnPrintSection.Size = New System.Drawing.Size(191, 31)
        Me.btnPrintSection.TabIndex = 313
        Me.btnPrintSection.Text = "Print Class Section"
        Me.btnPrintSection.UseVisualStyleBackColor = True
        Me.btnPrintSection.Visible = False
        '
        'cmbSection
        '
        Me.cmbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(21, 267)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(187, 23)
        Me.cmbSection.TabIndex = 311
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 248)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 16)
        Me.Label19.TabIndex = 310
        Me.Label19.Text = "Class Section"
        '
        'cmbAYCourse
        '
        Me.cmbAYCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAYCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAYCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAYCourse.FormattingEnabled = True
        Me.cmbAYCourse.Location = New System.Drawing.Point(20, 117)
        Me.cmbAYCourse.Name = "cmbAYCourse"
        Me.cmbAYCourse.Size = New System.Drawing.Size(187, 23)
        Me.cmbAYCourse.TabIndex = 309
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "Academic Year"
        '
        'cmbTermCourse
        '
        Me.cmbTermCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTermCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTermCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTermCourse.FormattingEnabled = True
        Me.cmbTermCourse.Items.AddRange(New Object() {"", "All", "1st Semester", "2nd Semester", "Summer"})
        Me.cmbTermCourse.Location = New System.Drawing.Point(20, 219)
        Me.cmbTermCourse.Name = "cmbTermCourse"
        Me.cmbTermCourse.Size = New System.Drawing.Size(187, 23)
        Me.cmbTermCourse.TabIndex = 307
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Term"
        '
        'cmbLevelCourse
        '
        Me.cmbLevelCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLevelCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLevelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevelCourse.FormattingEnabled = True
        Me.cmbLevelCourse.Location = New System.Drawing.Point(20, 168)
        Me.cmbLevelCourse.Name = "cmbLevelCourse"
        Me.cmbLevelCourse.Size = New System.Drawing.Size(187, 23)
        Me.cmbLevelCourse.TabIndex = 305
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 304
        Me.Label2.Text = "Year Level"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkJuniorHS)
        Me.GroupBox3.Controls.Add(Me.chkElementary)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 82)
        Me.GroupBox3.TabIndex = 303
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'chkJuniorHS
        '
        Me.chkJuniorHS.AutoSize = True
        Me.chkJuniorHS.Location = New System.Drawing.Point(22, 47)
        Me.chkJuniorHS.Name = "chkJuniorHS"
        Me.chkJuniorHS.Size = New System.Drawing.Size(88, 19)
        Me.chkJuniorHS.TabIndex = 287
        Me.chkJuniorHS.TabStop = True
        Me.chkJuniorHS.Text = "Junior HS"
        Me.chkJuniorHS.UseVisualStyleBackColor = True
        '
        'chkElementary
        '
        Me.chkElementary.AutoSize = True
        Me.chkElementary.Location = New System.Drawing.Point(22, 19)
        Me.chkElementary.Name = "chkElementary"
        Me.chkElementary.Size = New System.Drawing.Size(97, 19)
        Me.chkElementary.TabIndex = 286
        Me.chkElementary.TabStop = True
        Me.chkElementary.Text = "Elementary"
        Me.chkElementary.UseVisualStyleBackColor = True
        '
        'TabPrint
        '
        Me.TabPrint.Controls.Add(Me.tabCourse)
        Me.TabPrint.Controls.Add(Me.tabFaculty)
        Me.TabPrint.Location = New System.Drawing.Point(9, 9)
        Me.TabPrint.Name = "TabPrint"
        Me.TabPrint.SelectedIndex = 0
        Me.TabPrint.Size = New System.Drawing.Size(247, 360)
        Me.TabPrint.TabIndex = 297
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 321
        '
        'frmSubjectStudentsBE
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1125, 571)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtclassid)
        Me.Controls.Add(Me.txtfaculty)
        Me.Controls.Add(Me.courseid)
        Me.Controls.Add(Me.classscheduleid)
        Me.Controls.Add(Me.btnAlphalist)
        Me.Controls.Add(Me.sectionid)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.txtFacultyID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtcoursecode)
        Me.Controls.Add(Me.txtclassscheduleid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupSubject)
        Me.Controls.Add(Me.groupCourse)
        Me.Controls.Add(Me.txtLevelID)
        Me.Controls.Add(Me.TabPrint)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtsubjectid)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.dtPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSubjectStudentsBE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Report"
        Me.groupCourse.ResumeLayout(False)
        Me.groupCourse.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSubject.ResumeLayout(False)
        Me.groupSubject.PerformLayout()
        Me.tabFaculty.ResumeLayout(False)
        Me.tabFaculty.PerformLayout()
        CType(Me.dtFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCourse.ResumeLayout(False)
        Me.tabCourse.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPrint.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCourseID As System.Windows.Forms.Label
    Friend WithEvents txtLevelID As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtsubjectid As System.Windows.Forms.Label
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnEnrollees As System.Windows.Forms.Button
    Friend WithEvents groupCourse As System.Windows.Forms.GroupBox
    Friend WithEvents txtMajor As System.Windows.Forms.Label
    Friend WithEvents txtcoursename As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcoursecode As System.Windows.Forms.Label
    Friend WithEvents txtclassscheduleid As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtPrint As System.Windows.Forms.DataGridView
    Friend WithEvents txtFacultyID As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.Label
    Friend WithEvents txtcode As System.Windows.Forms.Label
    Friend WithEvents txtday As System.Windows.Forms.Label
    Friend WithEvents txttime As System.Windows.Forms.Label
    Friend WithEvents txtroom As System.Windows.Forms.Label
    Friend WithEvents txtlevel As System.Windows.Forms.Label
    Friend WithEvents groupSubject As System.Windows.Forms.GroupBox
    Friend WithEvents sectionid As System.Windows.Forms.Label
    Friend WithEvents btnAlphalist As System.Windows.Forms.Button
    Friend WithEvents btnAlphalistSection As System.Windows.Forms.Button
    Friend WithEvents classscheduleid As System.Windows.Forms.Label
    Friend WithEvents courseid As System.Windows.Forms.Label
    Friend WithEvents txtclassid As System.Windows.Forms.TextBox
    Friend WithEvents txtfaculty As System.Windows.Forms.TextBox
    Friend WithEvents tabFaculty As TabPage
    Friend WithEvents chkJuniorHSFaculty As RadioButton
    Friend WithEvents chkElementaryFaculty As RadioButton
    Friend WithEvents dtFaculty As DataGridView
    Friend WithEvents tabCourse As TabPage
    Friend WithEvents btnPrintSection As Button
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbAYCourse As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTermCourse As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbLevelCourse As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkJuniorHS As RadioButton
    Friend WithEvents chkElementary As RadioButton
    Friend WithEvents TabPrint As TabControl
    Friend WithEvents TextBox1 As TextBox
End Class
