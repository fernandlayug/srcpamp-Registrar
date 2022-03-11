<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleFaculty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtSubjects = New System.Windows.Forms.DataGridView()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCollege = New System.Windows.Forms.RadioButton()
        Me.chkSenior = New System.Windows.Forms.RadioButton()
        Me.txtTerm = New System.Windows.Forms.Label()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcurriculumid = New System.Windows.Forms.Label()
        Me.txtFacultyid = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.dtFaculty = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtSchedule = New System.Windows.Forms.DataGridView()
        Me.txtcourseid = New System.Windows.Forms.Label()
        Me.txtlevelid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfacultname = New System.Windows.Forms.Label()
        Me.schedulingimage = New System.Windows.Forms.PictureBox()
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulingimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 260
        Me.Label15.Text = "Course"
        '
        'dtSubjects
        '
        Me.dtSubjects.AllowUserToAddRows = False
        Me.dtSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSubjects.Location = New System.Drawing.Point(267, 81)
        Me.dtSubjects.Name = "dtSubjects"
        Me.dtSubjects.Size = New System.Drawing.Size(727, 322)
        Me.dtSubjects.TabIndex = 0
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(46, 15)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(444, 21)
        Me.cmbCourse.TabIndex = 272
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Faculty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Major"
        '
        'cmbMajor
        '
        Me.cmbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(47, 40)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(152, 21)
        Me.cmbMajor.TabIndex = 281
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCollege)
        Me.GroupBox3.Controls.Add(Me.chkSenior)
        Me.GroupBox3.Controls.Add(Me.txtTerm)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 48)
        Me.GroupBox3.TabIndex = 285
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'chkCollege
        '
        Me.chkCollege.AutoSize = True
        Me.chkCollege.Location = New System.Drawing.Point(133, 19)
        Me.chkCollege.Name = "chkCollege"
        Me.chkCollege.Size = New System.Drawing.Size(80, 20)
        Me.chkCollege.TabIndex = 287
        Me.chkCollege.TabStop = True
        Me.chkCollege.Text = "College"
        Me.chkCollege.UseVisualStyleBackColor = True
        '
        'chkSenior
        '
        Me.chkSenior.AutoSize = True
        Me.chkSenior.Location = New System.Drawing.Point(20, 19)
        Me.chkSenior.Name = "chkSenior"
        Me.chkSenior.Size = New System.Drawing.Size(96, 20)
        Me.chkSenior.TabIndex = 286
        Me.chkSenior.TabStop = True
        Me.chkSenior.Text = "Senior HS"
        Me.chkSenior.UseVisualStyleBackColor = True
        '
        'txtTerm
        '
        Me.txtTerm.AutoSize = True
        Me.txtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(219, 17)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(12, 16)
        Me.txtTerm.TabIndex = 292
        Me.txtTerm.Text = "-"
        Me.txtTerm.Visible = False
        '
        'cmbTerm
        '
        Me.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Items.AddRange(New Object() {"", "All", "1st Semester", "2nd Semester", "Summer"})
        Me.cmbTerm.Location = New System.Drawing.Point(357, 39)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(132, 21)
        Me.cmbTerm.TabIndex = 291
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "Term"
        '
        'txtcurriculumid
        '
        Me.txtcurriculumid.AutoSize = True
        Me.txtcurriculumid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurriculumid.Location = New System.Drawing.Point(70, 59)
        Me.txtcurriculumid.Name = "txtcurriculumid"
        Me.txtcurriculumid.Size = New System.Drawing.Size(79, 16)
        Me.txtcurriculumid.TabIndex = 288
        Me.txtcurriculumid.Text = "curriuclumid"
        Me.txtcurriculumid.Visible = False
        '
        'txtFacultyid
        '
        Me.txtFacultyid.AutoSize = True
        Me.txtFacultyid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacultyid.Location = New System.Drawing.Point(152, 57)
        Me.txtFacultyid.Name = "txtFacultyid"
        Me.txtFacultyid.Size = New System.Drawing.Size(46, 16)
        Me.txtFacultyid.TabIndex = 289
        Me.txtFacultyid.Text = "faculty"
        Me.txtFacultyid.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(882, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 66)
        Me.btnClose.TabIndex = 293
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(767, 9)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(109, 64)
        Me.btnGenerate.TabIndex = 304
        Me.btnGenerate.Text = "Save Faculty Schedule"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'dtFaculty
        '
        Me.dtFaculty.AllowUserToAddRows = False
        Me.dtFaculty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFaculty.Location = New System.Drawing.Point(13, 80)
        Me.dtFaculty.Name = "dtFaculty"
        Me.dtFaculty.Size = New System.Drawing.Size(243, 323)
        Me.dtFaculty.TabIndex = 309
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbMajor)
        Me.GroupBox1.Controls.Add(Me.cmbTerm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 70)
        Me.GroupBox1.TabIndex = 310
        Me.GroupBox1.TabStop = False
        '
        'dtSchedule
        '
        Me.dtSchedule.AllowUserToAddRows = False
        Me.dtSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSchedule.Location = New System.Drawing.Point(267, 435)
        Me.dtSchedule.Name = "dtSchedule"
        Me.dtSchedule.Size = New System.Drawing.Size(727, 108)
        Me.dtSchedule.TabIndex = 311
        '
        'txtcourseid
        '
        Me.txtcourseid.AutoSize = True
        Me.txtcourseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourseid.Location = New System.Drawing.Point(155, 59)
        Me.txtcourseid.Name = "txtcourseid"
        Me.txtcourseid.Size = New System.Drawing.Size(49, 16)
        Me.txtcourseid.TabIndex = 313
        Me.txtcourseid.Text = "course"
        Me.txtcourseid.Visible = False
        '
        'txtlevelid
        '
        Me.txtlevelid.AutoSize = True
        Me.txtlevelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlevelid.Location = New System.Drawing.Point(146, 59)
        Me.txtlevelid.Name = "txtlevelid"
        Me.txtlevelid.Size = New System.Drawing.Size(48, 16)
        Me.txtlevelid.TabIndex = 314
        Me.txtlevelid.Text = "levelid"
        Me.txtlevelid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "Name of Faculty:"
        '
        'txtfacultname
        '
        Me.txtfacultname.AutoSize = True
        Me.txtfacultname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfacultname.ForeColor = System.Drawing.Color.Maroon
        Me.txtfacultname.Location = New System.Drawing.Point(271, 412)
        Me.txtfacultname.Name = "txtfacultname"
        Me.txtfacultname.Size = New System.Drawing.Size(0, 16)
        Me.txtfacultname.TabIndex = 316
        '
        'schedulingimage
        '
        Me.schedulingimage.BackgroundImage = Global.srcregistrar.My.Resources.Resources._07_calendar
        Me.schedulingimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.schedulingimage.Location = New System.Drawing.Point(56, 412)
        Me.schedulingimage.Name = "schedulingimage"
        Me.schedulingimage.Size = New System.Drawing.Size(138, 131)
        Me.schedulingimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.schedulingimage.TabIndex = 312
        Me.schedulingimage.TabStop = False
        '
        'frmScheduleFaculty
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1001, 551)
        Me.Controls.Add(Me.txtfacultname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlevelid)
        Me.Controls.Add(Me.txtcourseid)
        Me.Controls.Add(Me.schedulingimage)
        Me.Controls.Add(Me.dtSchedule)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtFaculty)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtFacultyid)
        Me.Controls.Add(Me.txtcurriculumid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtSubjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmScheduleFaculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulingimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCollege As System.Windows.Forms.RadioButton
    Friend WithEvents chkSenior As System.Windows.Forms.RadioButton
    Friend WithEvents txtcurriculumid As System.Windows.Forms.Label
    Friend WithEvents txtFacultyid As System.Windows.Forms.Label
    Friend WithEvents cmbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents dtFaculty As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents schedulingimage As System.Windows.Forms.PictureBox
    Friend WithEvents txtcourseid As System.Windows.Forms.Label
    Friend WithEvents txtlevelid As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfacultname As System.Windows.Forms.Label
End Class
