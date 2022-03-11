<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportExcel
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
        Me.student = New System.Windows.Forms.Label()
        Me.admissioninfo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.summer = New System.Windows.Forms.RadioButton()
        Me.secondsem = New System.Windows.Forms.RadioButton()
        Me.firstsem = New System.Windows.Forms.RadioButton()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.shsOption = New System.Windows.Forms.RadioButton()
        Me.jhsOption = New System.Windows.Forms.RadioButton()
        Me.elemOption = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.allOption = New System.Windows.Forms.RadioButton()
        Me.collegeOption = New System.Windows.Forms.RadioButton()
        Me.dgvsection = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFemaleSection = New System.Windows.Forms.Label()
        Me.lblMaleSection = New System.Windows.Forms.Label()
        Me.lblTotalStudentsSection = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SY = New System.Windows.Forms.ComboBox()
        Me.admissioninfo.SuspendLayout
        Me.semester.SuspendLayout
        Me.GroupBox3.SuspendLayout
        CType(Me.dgvsection,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'student
        '
        Me.student.AutoSize = true
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.student.Location = New System.Drawing.Point(1010, 156)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 41
        Me.student.Visible = false
        '
        'admissioninfo
        '
        Me.admissioninfo.Controls.Add(Me.Label3)
        Me.admissioninfo.Controls.Add(Me.cmbSection)
        Me.admissioninfo.Controls.Add(Me.Label2)
        Me.admissioninfo.Controls.Add(Me.cmbMajor)
        Me.admissioninfo.Controls.Add(Me.cmbCourse)
        Me.admissioninfo.Controls.Add(Me.Label1)
        Me.admissioninfo.Controls.Add(Me.semester)
        Me.admissioninfo.Controls.Add(Me.level)
        Me.admissioninfo.Controls.Add(Me.Label19)
        Me.admissioninfo.Enabled = false
        Me.admissioninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.admissioninfo.Location = New System.Drawing.Point(21, 34)
        Me.admissioninfo.Name = "admissioninfo"
        Me.admissioninfo.Size = New System.Drawing.Size(727, 115)
        Me.admissioninfo.TabIndex = 14
        Me.admissioninfo.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 583
        Me.Label3.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbSection.FormattingEnabled = true
        Me.cmbSection.Location = New System.Drawing.Point(61, 85)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(160, 24)
        Me.cmbSection.TabIndex = 582
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Major"
        '
        'cmbMajor
        '
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbMajor.FormattingEnabled = true
        Me.cmbMajor.Location = New System.Drawing.Point(554, 52)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(170, 24)
        Me.cmbMajor.TabIndex = 224
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbCourse.FormattingEnabled = true
        Me.cmbCourse.Location = New System.Drawing.Point(53, 52)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(449, 24)
        Me.cmbCourse.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Course"
        '
        'semester
        '
        Me.semester.Controls.Add(Me.summer)
        Me.semester.Controls.Add(Me.secondsem)
        Me.semester.Controls.Add(Me.firstsem)
        Me.semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.semester.Location = New System.Drawing.Point(205, 12)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(516, 36)
        Me.semester.TabIndex = 220
        Me.semester.TabStop = false
        '
        'summer
        '
        Me.summer.AutoSize = true
        Me.summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.summer.Location = New System.Drawing.Point(311, 11)
        Me.summer.Name = "summer"
        Me.summer.Size = New System.Drawing.Size(73, 19)
        Me.summer.TabIndex = 222
        Me.summer.TabStop = true
        Me.summer.Text = "Summer"
        Me.summer.UseVisualStyleBackColor = true
        '
        'secondsem
        '
        Me.secondsem.AutoSize = true
        Me.secondsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.secondsem.Location = New System.Drawing.Point(163, 11)
        Me.secondsem.Name = "secondsem"
        Me.secondsem.Size = New System.Drawing.Size(102, 19)
        Me.secondsem.TabIndex = 221
        Me.secondsem.TabStop = true
        Me.secondsem.Text = "2nd Semester"
        Me.secondsem.UseVisualStyleBackColor = true
        '
        'firstsem
        '
        Me.firstsem.AutoSize = true
        Me.firstsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.firstsem.Location = New System.Drawing.Point(15, 11)
        Me.firstsem.Name = "firstsem"
        Me.firstsem.Size = New System.Drawing.Size(97, 19)
        Me.firstsem.TabIndex = 3
        Me.firstsem.TabStop = true
        Me.firstsem.Text = "1st Semester"
        Me.firstsem.UseVisualStyleBackColor = true
        '
        'level
        '
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.level.FormattingEnabled = true
        Me.level.Location = New System.Drawing.Point(53, 25)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(114, 23)
        Me.level.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 16)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = " Level"
        '
        'shsOption
        '
        Me.shsOption.AutoSize = true
        Me.shsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.shsOption.Location = New System.Drawing.Point(240, 18)
        Me.shsOption.Name = "shsOption"
        Me.shsOption.Size = New System.Drawing.Size(136, 20)
        Me.shsOption.TabIndex = 218
        Me.shsOption.TabStop = true
        Me.shsOption.Text = "Senior Highschool"
        Me.shsOption.UseVisualStyleBackColor = true
        '
        'jhsOption
        '
        Me.jhsOption.AutoSize = true
        Me.jhsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.jhsOption.Location = New System.Drawing.Point(105, 18)
        Me.jhsOption.Name = "jhsOption"
        Me.jhsOption.Size = New System.Drawing.Size(133, 20)
        Me.jhsOption.TabIndex = 217
        Me.jhsOption.TabStop = true
        Me.jhsOption.Text = "Junior Highschool"
        Me.jhsOption.UseVisualStyleBackColor = true
        '
        'elemOption
        '
        Me.elemOption.AutoSize = true
        Me.elemOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.elemOption.Location = New System.Drawing.Point(9, 17)
        Me.elemOption.Name = "elemOption"
        Me.elemOption.Size = New System.Drawing.Size(94, 20)
        Me.elemOption.TabIndex = 216
        Me.elemOption.TabStop = true
        Me.elemOption.Text = "Elementary"
        Me.elemOption.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.allOption)
        Me.GroupBox3.Controls.Add(Me.elemOption)
        Me.GroupBox3.Controls.Add(Me.jhsOption)
        Me.GroupBox3.Controls.Add(Me.shsOption)
        Me.GroupBox3.Controls.Add(Me.collegeOption)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 41)
        Me.GroupBox3.TabIndex = 220
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Level"
        '
        'allOption
        '
        Me.allOption.AutoSize = true
        Me.allOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.allOption.Location = New System.Drawing.Point(448, 17)
        Me.allOption.Name = "allOption"
        Me.allOption.Size = New System.Drawing.Size(41, 20)
        Me.allOption.TabIndex = 220
        Me.allOption.TabStop = true
        Me.allOption.Text = "All"
        Me.allOption.UseVisualStyleBackColor = true
        '
        'collegeOption
        '
        Me.collegeOption.AutoSize = true
        Me.collegeOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.collegeOption.Location = New System.Drawing.Point(376, 18)
        Me.collegeOption.Name = "collegeOption"
        Me.collegeOption.Size = New System.Drawing.Size(73, 20)
        Me.collegeOption.TabIndex = 219
        Me.collegeOption.TabStop = true
        Me.collegeOption.Text = "College"
        Me.collegeOption.UseVisualStyleBackColor = true
        '
        'dgvsection
        '
        Me.dgvsection.AllowUserToAddRows = false
        Me.dgvsection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsection.Location = New System.Drawing.Point(21, 156)
        Me.dgvsection.Name = "dgvsection"
        Me.dgvsection.Size = New System.Drawing.Size(727, 460)
        Me.dgvsection.TabIndex = 582
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFemaleSection)
        Me.GroupBox2.Controls.Add(Me.lblMaleSection)
        Me.GroupBox2.Controls.Add(Me.lblTotalStudentsSection)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 622)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 43)
        Me.GroupBox2.TabIndex = 588
        Me.GroupBox2.TabStop = false
        '
        'lblFemaleSection
        '
        Me.lblFemaleSection.AutoSize = true
        Me.lblFemaleSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFemaleSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblFemaleSection.Location = New System.Drawing.Point(371, 21)
        Me.lblFemaleSection.Name = "lblFemaleSection"
        Me.lblFemaleSection.Size = New System.Drawing.Size(16, 16)
        Me.lblFemaleSection.TabIndex = 591
        Me.lblFemaleSection.Text = "0"
        '
        'lblMaleSection
        '
        Me.lblMaleSection.AutoSize = true
        Me.lblMaleSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMaleSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblMaleSection.Location = New System.Drawing.Point(255, 19)
        Me.lblMaleSection.Name = "lblMaleSection"
        Me.lblMaleSection.Size = New System.Drawing.Size(16, 16)
        Me.lblMaleSection.TabIndex = 590
        Me.lblMaleSection.Text = "0"
        '
        'lblTotalStudentsSection
        '
        Me.lblTotalStudentsSection.AutoSize = true
        Me.lblTotalStudentsSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotalStudentsSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalStudentsSection.Location = New System.Drawing.Point(157, 19)
        Me.lblTotalStudentsSection.Name = "lblTotalStudentsSection"
        Me.lblTotalStudentsSection.Size = New System.Drawing.Size(16, 16)
        Me.lblTotalStudentsSection.TabIndex = 587
        Me.lblTotalStudentsSection.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(312, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 586
        Me.Label14.Text = "Female:"
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(213, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 585
        Me.Label15.Text = "Male:"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 16)
        Me.Label16.TabIndex = 584
        Me.Label16.Text = "Total No. of Students:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 32)
        Me.Button1.TabIndex = 589
        Me.Button1.Text = "Export to Excel"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(527, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 16)
        Me.Label4.TabIndex = 585
        Me.Label4.Text = "SY"
        '
        'SY
        '
        Me.SY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SY.FormattingEnabled = true
        Me.SY.Items.AddRange(New Object() {"2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022"})
        Me.SY.Location = New System.Drawing.Point(575, 11)
        Me.SY.Name = "SY"
        Me.SY.Size = New System.Drawing.Size(170, 24)
        Me.SY.TabIndex = 584
        '
        'frmExportExcel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = true
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 698)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SY)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvsection)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.admissioninfo)
        Me.Controls.Add(Me.student)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmExportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Section"
        Me.admissioninfo.ResumeLayout(false)
        Me.admissioninfo.PerformLayout
        Me.semester.ResumeLayout(false)
        Me.semester.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.dgvsection,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents admissioninfo As System.Windows.Forms.GroupBox
    Friend WithEvents level As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents semester As System.Windows.Forms.GroupBox
    Friend WithEvents secondsem As System.Windows.Forms.RadioButton
    Friend WithEvents firstsem As System.Windows.Forms.RadioButton
    Friend WithEvents shsOption As System.Windows.Forms.RadioButton
    Friend WithEvents jhsOption As System.Windows.Forms.RadioButton
    Friend WithEvents elemOption As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents summer As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents collegeOption As System.Windows.Forms.RadioButton
    Friend WithEvents allOption As System.Windows.Forms.RadioButton
    Friend WithEvents dgvsection As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalStudentsSection As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblFemaleSection As System.Windows.Forms.Label
    Friend WithEvents lblMaleSection As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SY As System.Windows.Forms.ComboBox
End Class
