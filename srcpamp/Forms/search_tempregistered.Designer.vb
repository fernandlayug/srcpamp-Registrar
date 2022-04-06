<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_tempregistered
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
        Me.student = New System.Windows.Forms.DataGridView()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.studentID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.student, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'student
        '
        Me.student.AllowUserToAddRows = False
        Me.student.AllowUserToDeleteRows = False
        Me.student.AllowUserToOrderColumns = True
        Me.student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.student.Location = New System.Drawing.Point(35, 72)
        Me.student.Name = "student"
        Me.student.ReadOnly = True
        Me.student.Size = New System.Drawing.Size(645, 324)
        Me.student.TabIndex = 1
        Me.student.Visible = False
        '
        'searchbox
        '
        Me.searchbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.searchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.Location = New System.Drawing.Point(23, 12)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(357, 26)
        Me.searchbox.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureBox1.Location = New System.Drawing.Point(24, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(669, 344)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(27, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lastname Firstname or Student ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(615, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 48)
        Me.Button1.TabIndex = 214
        Me.Button1.TabStop = False
        Me.Button1.Text = "Close" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F4"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'studentID
        '
        Me.studentID.AutoSize = True
        Me.studentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.studentID.Location = New System.Drawing.Point(265, 41)
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(18, 13)
        Me.studentID.TabIndex = 215
        Me.studentID.Text = "ID"
        Me.studentID.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(535, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 48)
        Me.Button2.TabIndex = 216
        Me.Button2.TabStop = False
        Me.Button2.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(455, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 48)
        Me.Button3.TabIndex = 217
        Me.Button3.TabStop = False
        Me.Button3.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'search_tempregistered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 430)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.studentID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "search_tempregistered"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Student"
        CType(Me.student, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents student As System.Windows.Forms.DataGridView
    Friend WithEvents searchbox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents studentID As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
