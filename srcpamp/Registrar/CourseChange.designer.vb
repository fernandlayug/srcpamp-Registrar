<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseChange))
        Me.surname = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.student = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.studid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.StudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.sy = New System.Windows.Forms.TextBox()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.c_code = New System.Windows.Forms.TextBox()
        Me.admissioninfo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picstudent = New System.Windows.Forms.PictureBox()
        Me.StudentInfo.SuspendLayout()
        Me.admissioninfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'surname
        '
        Me.surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(100, 57)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(384, 23)
        Me.surname.TabIndex = 4
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.Blue
        Me.submit.Location = New System.Drawing.Point(500, 5)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(134, 33)
        Me.submit.TabIndex = 18
        Me.submit.Text = "Commit Changes"
        Me.submit.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(1020, 149)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 41
        Me.student.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 18)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Name"
        '
        'studid
        '
        Me.studid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studid.Location = New System.Drawing.Point(99, 22)
        Me.studid.Name = "studid"
        Me.studid.ReadOnly = True
        Me.studid.Size = New System.Drawing.Size(199, 24)
        Me.studid.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 18)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Student ID"
        '
        'StudentInfo
        '
        Me.StudentInfo.Controls.Add(Me.txtTerm)
        Me.StudentInfo.Controls.Add(Me.sy)
        Me.StudentInfo.Controls.Add(Me.txtCourseID)
        Me.StudentInfo.Controls.Add(Me.c_code)
        Me.StudentInfo.Controls.Add(Me.Label25)
        Me.StudentInfo.Controls.Add(Me.surname)
        Me.StudentInfo.Controls.Add(Me.Label26)
        Me.StudentInfo.Controls.Add(Me.studid)
        Me.StudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentInfo.Location = New System.Drawing.Point(32, 12)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(767, 98)
        Me.StudentInfo.TabIndex = 66
        Me.StudentInfo.TabStop = False
        Me.StudentInfo.Text = "Student Information"
        '
        'txtTerm
        '
        Me.txtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(550, 45)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(81, 24)
        Me.txtTerm.TabIndex = 69
        Me.txtTerm.Visible = False
        '
        'sy
        '
        Me.sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sy.Location = New System.Drawing.Point(550, 74)
        Me.sy.Name = "sy"
        Me.sy.ReadOnly = True
        Me.sy.Size = New System.Drawing.Size(81, 24)
        Me.sy.TabIndex = 68
        Me.sy.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.AcceptsReturn = True
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(536, 16)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.ReadOnly = True
        Me.txtCourseID.Size = New System.Drawing.Size(81, 24)
        Me.txtCourseID.TabIndex = 67
        Me.txtCourseID.Visible = False
        '
        'c_code
        '
        Me.c_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_code.Location = New System.Drawing.Point(637, 16)
        Me.c_code.Name = "c_code"
        Me.c_code.ReadOnly = True
        Me.c_code.Size = New System.Drawing.Size(81, 24)
        Me.c_code.TabIndex = 66
        Me.c_code.Visible = False
        '
        'admissioninfo
        '
        Me.admissioninfo.Controls.Add(Me.Label2)
        Me.admissioninfo.Controls.Add(Me.cmbMajor)
        Me.admissioninfo.Controls.Add(Me.cmbCourse)
        Me.admissioninfo.Controls.Add(Me.Label1)
        Me.admissioninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfo.Location = New System.Drawing.Point(32, 111)
        Me.admissioninfo.Name = "admissioninfo"
        Me.admissioninfo.Size = New System.Drawing.Size(767, 52)
        Me.admissioninfo.TabIndex = 14
        Me.admissioninfo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Major/Track"
        '
        'cmbMajor
        '
        Me.cmbMajor.Enabled = False
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(568, 15)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(185, 23)
        Me.cmbMajor.TabIndex = 224
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(131, 17)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(322, 23)
        Me.cmbCourse.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Course/Program"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(637, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 34)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Location = New System.Drawing.Point(32, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 41)
        Me.Panel1.TabIndex = 567
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 34)
        Me.Button2.TabIndex = 214
        Me.Button2.Text = "Change Course"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'picstudent
        '
        Me.picstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picstudent.Image = CType(resources.GetObject("picstudent.Image"), System.Drawing.Image)
        Me.picstudent.Location = New System.Drawing.Point(1231, 12)
        Me.picstudent.Name = "picstudent"
        Me.picstudent.Size = New System.Drawing.Size(111, 87)
        Me.picstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstudent.TabIndex = 47
        Me.picstudent.TabStop = False
        Me.picstudent.Visible = False
        '
        'CourseChange
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 304)
        Me.Controls.Add(Me.admissioninfo)
        Me.Controls.Add(Me.StudentInfo)
        Me.Controls.Add(Me.picstudent)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CourseChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Course"
        Me.StudentInfo.ResumeLayout(False)
        Me.StudentInfo.PerformLayout()
        Me.admissioninfo.ResumeLayout(False)
        Me.admissioninfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents picstudent As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents studid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents StudentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents admissioninfo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents c_code As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents sy As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
