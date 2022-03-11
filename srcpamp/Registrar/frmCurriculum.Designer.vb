<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurriculum
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtSubjects = New System.Windows.Forms.DataGridView()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCollege = New System.Windows.Forms.RadioButton()
        Me.chkSenior = New System.Windows.Forms.RadioButton()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.Label()
        Me.txtLevelID = New System.Windows.Forms.Label()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbCAY = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsubjectid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbAY = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 260
        Me.Label15.Text = "Course"
        '
        'dtSubjects
        '
        Me.dtSubjects.AllowUserToAddRows = False
        Me.dtSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtSubjects.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtSubjects.Location = New System.Drawing.Point(301, 31)
        Me.dtSubjects.Name = "dtSubjects"
        Me.dtSubjects.Size = New System.Drawing.Size(706, 481)
        Me.dtSubjects.TabIndex = 0
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(12, 82)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(286, 23)
        Me.cmbCourse.TabIndex = 272
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 41)
        Me.Button1.TabIndex = 277
        Me.Button1.Text = "Add Subject"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 41)
        Me.Button2.TabIndex = 278
        Me.Button2.Text = "Print Curriculum"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(7, 351)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(191, 41)
        Me.btnRemove.TabIndex = 279
        Me.btnRemove.Text = "Remove Subject"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Subjects"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Major"
        '
        'cmbMajor
        '
        Me.cmbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(12, 128)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(187, 23)
        Me.cmbMajor.TabIndex = 281
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCollege)
        Me.GroupBox3.Controls.Add(Me.chkSenior)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 51)
        Me.GroupBox3.TabIndex = 285
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'chkCollege
        '
        Me.chkCollege.AutoSize = True
        Me.chkCollege.Location = New System.Drawing.Point(143, 19)
        Me.chkCollege.Name = "chkCollege"
        Me.chkCollege.Size = New System.Drawing.Size(83, 22)
        Me.chkCollege.TabIndex = 287
        Me.chkCollege.TabStop = True
        Me.chkCollege.Text = "College"
        Me.chkCollege.UseVisualStyleBackColor = True
        '
        'chkSenior
        '
        Me.chkSenior.AutoSize = True
        Me.chkSenior.Location = New System.Drawing.Point(22, 19)
        Me.chkSenior.Name = "chkSenior"
        Me.chkSenior.Size = New System.Drawing.Size(103, 22)
        Me.chkSenior.TabIndex = 286
        Me.chkSenior.TabStop = True
        Me.chkSenior.Text = "Senior HS"
        Me.chkSenior.UseVisualStyleBackColor = True
        '
        'cmbLevel
        '
        Me.cmbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(12, 224)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(187, 23)
        Me.cmbLevel.TabIndex = 287
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 286
        Me.Label2.Text = "Year Level"
        '
        'txtCourseID
        '
        Me.txtCourseID.AutoSize = True
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(810, 37)
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
        Me.txtLevelID.Location = New System.Drawing.Point(880, 37)
        Me.txtLevelID.Name = "txtLevelID"
        Me.txtLevelID.Size = New System.Drawing.Size(54, 16)
        Me.txtLevelID.TabIndex = 289
        Me.txtLevelID.Text = "LevelID"
        Me.txtLevelID.Visible = False
        '
        'cmbTerm
        '
        Me.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Items.AddRange(New Object() {"", "All", "1st Semester", "2nd Semester", "Summer"})
        Me.cmbTerm.Location = New System.Drawing.Point(12, 269)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(187, 23)
        Me.cmbTerm.TabIndex = 291
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "Term"
        '
        'txtTerm
        '
        Me.txtTerm.AutoSize = True
        Me.txtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(940, 37)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(12, 16)
        Me.txtTerm.TabIndex = 292
        Me.txtTerm.Text = "-"
        Me.txtTerm.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 471)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 41)
        Me.Button4.TabIndex = 293
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbCAY
        '
        Me.cmbCAY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCAY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCAY.FormattingEnabled = True
        Me.cmbCAY.Location = New System.Drawing.Point(12, 175)
        Me.cmbCAY.Name = "cmbCAY"
        Me.cmbCAY.Size = New System.Drawing.Size(187, 23)
        Me.cmbCAY.TabIndex = 295
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 16)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Curriculum Academic Year"
        '
        'txtsubjectid
        '
        Me.txtsubjectid.AutoSize = True
        Me.txtsubjectid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectid.Location = New System.Drawing.Point(972, 40)
        Me.txtsubjectid.Name = "txtsubjectid"
        Me.txtsubjectid.Size = New System.Drawing.Size(12, 16)
        Me.txtsubjectid.TabIndex = 296
        Me.txtsubjectid.Text = "-"
        Me.txtsubjectid.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(701, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "Academic Year"
        '
        'cmbAY
        '
        Me.cmbAY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAY.FormattingEnabled = True
        Me.cmbAY.Location = New System.Drawing.Point(809, 5)
        Me.cmbAY.Name = "cmbAY"
        Me.cmbAY.Size = New System.Drawing.Size(175, 23)
        Me.cmbAY.TabIndex = 298
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 29)
        Me.Button3.TabIndex = 299
        Me.Button3.Text = "Set Active Curriculum"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(466, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 27)
        Me.Button5.TabIndex = 300
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmCurriculum
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1019, 523)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmbAY)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsubjectid)
        Me.Controls.Add(Me.cmbCAY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.cmbTerm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLevelID)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMajor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtSubjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCurriculum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum"
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCollege As System.Windows.Forms.RadioButton
    Friend WithEvents chkSenior As System.Windows.Forms.RadioButton
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCourseID As System.Windows.Forms.Label
    Friend WithEvents txtLevelID As System.Windows.Forms.Label
    Friend WithEvents cmbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbCAY As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectid As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbAY As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
