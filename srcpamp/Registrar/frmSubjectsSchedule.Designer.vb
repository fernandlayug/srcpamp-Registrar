<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjectsschedule
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
        Me.gridparticular = New System.Windows.Forms.DataGridView()
        Me.txtTermID = New System.Windows.Forms.Label()
        Me.txtLevelID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSubjectCategory = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.firstsem = New System.Windows.Forms.RadioButton()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.summer = New System.Windows.Forms.RadioButton()
        Me.secondsem = New System.Windows.Forms.RadioButton()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstudentid = New System.Windows.Forms.Label()
        Me.datetoday = New System.Windows.Forms.DateTimePicker()
        Me.txtCourse = New System.Windows.Forms.ComboBox()
        Me.txtMajor = New System.Windows.Forms.ComboBox()
        Me.coursecode = New System.Windows.Forms.Label()
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.semester.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 16)
        Me.Label15.TabIndex = 260
        Me.Label15.Text = "Category"
        '
        'gridparticular
        '
        Me.gridparticular.AllowUserToAddRows = False
        Me.gridparticular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridparticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridparticular.Location = New System.Drawing.Point(12, 125)
        Me.gridparticular.Name = "gridparticular"
        Me.gridparticular.Size = New System.Drawing.Size(944, 365)
        Me.gridparticular.TabIndex = 0
        '
        'txtTermID
        '
        Me.txtTermID.AutoSize = True
        Me.txtTermID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermID.Location = New System.Drawing.Point(792, 19)
        Me.txtTermID.Name = "txtTermID"
        Me.txtTermID.Size = New System.Drawing.Size(34, 16)
        Me.txtTermID.TabIndex = 295
        Me.txtTermID.Text = "term"
        Me.txtTermID.Visible = False
        '
        'txtLevelID
        '
        Me.txtLevelID.AutoSize = True
        Me.txtLevelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelID.Location = New System.Drawing.Point(832, 19)
        Me.txtLevelID.Name = "txtLevelID"
        Me.txtLevelID.Size = New System.Drawing.Size(54, 16)
        Me.txtLevelID.TabIndex = 294
        Me.txtLevelID.Text = "LevelID"
        Me.txtLevelID.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.AutoSize = True
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(892, 19)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(64, 16)
        Me.txtCourseID.TabIndex = 293
        Me.txtCourseID.Text = "CourseID"
        Me.txtCourseID.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(828, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 30)
        Me.Button1.TabIndex = 296
        Me.Button1.Text = "Add Subjects"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Course:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Major:"
        '
        'cmbSubjectCategory
        '
        Me.cmbSubjectCategory.Location = New System.Drawing.Point(82, 5)
        Me.cmbSubjectCategory.Name = "cmbSubjectCategory"
        Me.cmbSubjectCategory.ReadOnly = True
        Me.cmbSubjectCategory.Size = New System.Drawing.Size(204, 20)
        Me.cmbSubjectCategory.TabIndex = 305
        '
        'txtLevel
        '
        Me.txtLevel.FormattingEnabled = True
        Me.txtLevel.Location = New System.Drawing.Point(82, 64)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(87, 21)
        Me.txtLevel.TabIndex = 310
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(188, 68)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 16)
        Me.Label34.TabIndex = 312
        Me.Label34.Text = "Semester"
        '
        'firstsem
        '
        Me.firstsem.AutoSize = True
        Me.firstsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstsem.Location = New System.Drawing.Point(15, 10)
        Me.firstsem.Name = "firstsem"
        Me.firstsem.Size = New System.Drawing.Size(97, 19)
        Me.firstsem.TabIndex = 3
        Me.firstsem.TabStop = True
        Me.firstsem.Text = "1st Semester"
        Me.firstsem.UseVisualStyleBackColor = True
        '
        'semester
        '
        Me.semester.Controls.Add(Me.summer)
        Me.semester.Controls.Add(Me.secondsem)
        Me.semester.Controls.Add(Me.firstsem)
        Me.semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(264, 57)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(288, 32)
        Me.semester.TabIndex = 311
        Me.semester.TabStop = False
        '
        'summer
        '
        Me.summer.AutoSize = True
        Me.summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summer.Location = New System.Drawing.Point(213, 10)
        Me.summer.Name = "summer"
        Me.summer.Size = New System.Drawing.Size(73, 19)
        Me.summer.TabIndex = 222
        Me.summer.TabStop = True
        Me.summer.Text = "Summer"
        Me.summer.UseVisualStyleBackColor = True
        '
        'secondsem
        '
        Me.secondsem.AutoSize = True
        Me.secondsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondsem.Location = New System.Drawing.Point(111, 10)
        Me.secondsem.Name = "secondsem"
        Me.secondsem.Size = New System.Drawing.Size(102, 19)
        Me.secondsem.TabIndex = 221
        Me.secondsem.TabStop = True
        Me.secondsem.Text = "2nd Semester"
        Me.secondsem.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 96)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(944, 20)
        Me.txtDescription.TabIndex = 270
        '
        'txtSY
        '
        Me.txtSY.Location = New System.Drawing.Point(331, 5)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.ReadOnly = True
        Me.txtSY.Size = New System.Drawing.Size(167, 20)
        Me.txtSY.TabIndex = 313
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 314
        Me.Label2.Text = "SY"
        '
        'txtstudentid
        '
        Me.txtstudentid.AutoSize = True
        Me.txtstudentid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentid.Location = New System.Drawing.Point(792, 3)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(62, 16)
        Me.txtstudentid.TabIndex = 315
        Me.txtstudentid.Text = "studentid"
        Me.txtstudentid.Visible = False
        '
        'datetoday
        '
        Me.datetoday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetoday.Location = New System.Drawing.Point(562, 5)
        Me.datetoday.Name = "datetoday"
        Me.datetoday.Size = New System.Drawing.Size(123, 20)
        Me.datetoday.TabIndex = 316
        Me.datetoday.Visible = False
        '
        'txtCourse
        '
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.Location = New System.Drawing.Point(82, 35)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(416, 21)
        Me.txtCourse.TabIndex = 317
        '
        'txtMajor
        '
        Me.txtMajor.FormattingEnabled = True
        Me.txtMajor.Location = New System.Drawing.Point(555, 36)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(206, 21)
        Me.txtMajor.TabIndex = 318
        '
        'coursecode
        '
        Me.coursecode.AutoSize = True
        Me.coursecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecode.Location = New System.Drawing.Point(727, 3)
        Me.coursecode.Name = "coursecode"
        Me.coursecode.Size = New System.Drawing.Size(80, 16)
        Me.coursecode.TabIndex = 319
        Me.coursecode.Text = "coursecode"
        Me.coursecode.Visible = False
        '
        'frmSubjectsEnrolled
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(968, 496)
        Me.Controls.Add(Me.coursecode)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.datetoday)
        Me.Controls.Add(Me.txtstudentid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.semester)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.cmbSubjectCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTermID)
        Me.Controls.Add(Me.txtLevelID)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gridparticular)
        Me.Name = "frmSubjectsEnrolled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subjects List"
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.semester.ResumeLayout(False)
        Me.semester.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gridparticular As System.Windows.Forms.DataGridView
    Friend WithEvents txtTermID As System.Windows.Forms.Label
    Friend WithEvents txtLevelID As System.Windows.Forms.Label
    Friend WithEvents txtCourseID As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSubjectCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents firstsem As System.Windows.Forms.RadioButton
    Friend WithEvents semester As System.Windows.Forms.GroupBox
    Friend WithEvents summer As System.Windows.Forms.RadioButton
    Friend WithEvents secondsem As System.Windows.Forms.RadioButton
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstudentid As System.Windows.Forms.Label
    Friend WithEvents datetoday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtMajor As System.Windows.Forms.ComboBox
    Friend WithEvents coursecode As System.Windows.Forms.Label
End Class
