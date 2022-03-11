<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateEmail
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvsection = New System.Windows.Forms.DataGridView()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.getsched = New System.Windows.Forms.Button()
        Me.classid = New System.Windows.Forms.TextBox()
        Me.subjectID = New System.Windows.Forms.TextBox()
        Me.levelid_temp = New System.Windows.Forms.TextBox()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1010, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgview
        '
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(856, 380)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(148, 90)
        Me.dgview.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1010, 428)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvsection
        '
        Me.dgvsection.AllowUserToAddRows = False
        Me.dgvsection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsection.Location = New System.Drawing.Point(21, 112)
        Me.dgvsection.Name = "dgvsection"
        Me.dgvsection.Size = New System.Drawing.Size(548, 368)
        Me.dgvsection.TabIndex = 585
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbSection.Location = New System.Drawing.Point(21, 71)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(178, 24)
        Me.cmbSection.TabIndex = 586
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(21, 12)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(433, 24)
        Me.cmbCourse.TabIndex = 584
        '
        'level
        '
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.FormattingEnabled = True
        Me.level.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.level.Location = New System.Drawing.Point(21, 42)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(178, 23)
        Me.level.TabIndex = 583
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(226, 71)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(151, 23)
        Me.btnProcess.TabIndex = 587
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'cmbMajor
        '
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(487, 12)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(170, 24)
        Me.cmbMajor.TabIndex = 588
        '
        'dgvSchedule
        '
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Location = New System.Drawing.Point(577, 112)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.Size = New System.Drawing.Size(532, 262)
        Me.dgvSchedule.TabIndex = 589
        '
        'getsched
        '
        Me.getsched.Location = New System.Drawing.Point(577, 72)
        Me.getsched.Name = "getsched"
        Me.getsched.Size = New System.Drawing.Size(151, 23)
        Me.getsched.TabIndex = 590
        Me.getsched.Text = "Get Schedule"
        Me.getsched.UseVisualStyleBackColor = True
        '
        'classid
        '
        Me.classid.Location = New System.Drawing.Point(787, 75)
        Me.classid.Name = "classid"
        Me.classid.Size = New System.Drawing.Size(100, 20)
        Me.classid.TabIndex = 591
        '
        'subjectID
        '
        Me.subjectID.Location = New System.Drawing.Point(904, 75)
        Me.subjectID.Name = "subjectID"
        Me.subjectID.Size = New System.Drawing.Size(100, 20)
        Me.subjectID.TabIndex = 592
        '
        'levelid_temp
        '
        Me.levelid_temp.Location = New System.Drawing.Point(226, 44)
        Me.levelid_temp.Name = "levelid_temp"
        Me.levelid_temp.Size = New System.Drawing.Size(100, 20)
        Me.levelid_temp.TabIndex = 593
        '
        'CreateEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 609)
        Me.Controls.Add(Me.levelid_temp)
        Me.Controls.Add(Me.subjectID)
        Me.Controls.Add(Me.classid)
        Me.Controls.Add(Me.getsched)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.cmbMajor)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.dgvsection)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.level)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CreateEmail"
        Me.Text = "CreateEmail"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvsection As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents level As System.Windows.Forms.ComboBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents getsched As System.Windows.Forms.Button
    Friend WithEvents classid As System.Windows.Forms.TextBox
    Friend WithEvents subjectID As System.Windows.Forms.TextBox
    Friend WithEvents levelid_temp As System.Windows.Forms.TextBox
End Class
