<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubject
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
        Me.Cachedrefundreceipt1 = New srcregistrar.Cachedrefundreceipt()
        Me.subject = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.addsubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.category = New System.Windows.Forms.ComboBox()
        CType(Me.subject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'subject
        '
        Me.subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject.Location = New System.Drawing.Point(10, 16)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(430, 185)
        Me.subject.TabIndex = 273
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.subject)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(13, 83)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(449, 209)
        Me.GroupBox7.TabIndex = 274
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Assignment"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 29)
        Me.Button1.TabIndex = 275
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 29)
        Me.Button2.TabIndex = 276
        Me.Button2.Text = "Add Subject"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 29)
        Me.Button3.TabIndex = 277
        Me.Button3.Text = "Remove Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'addsubject
        '
        Me.addsubject.Location = New System.Drawing.Point(287, 20)
        Me.addsubject.Name = "addsubject"
        Me.addsubject.Size = New System.Drawing.Size(170, 20)
        Me.addsubject.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 281
        Me.Label2.Text = "Subject"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(119, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 29)
        Me.Button4.TabIndex = 283
        Me.Button4.Text = "Change Category"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'category
        '
        Me.category.Enabled = False
        Me.category.FormattingEnabled = True
        Me.category.Items.AddRange(New Object() {"Elementary", "Highschool"})
        Me.category.Location = New System.Drawing.Point(75, 17)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(149, 21)
        Me.category.TabIndex = 284
        '
        'frmSubject
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(487, 353)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addsubject)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Subject"
        CType(Me.subject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cachedrefundreceipt1 As srcregistrar.Cachedrefundreceipt
    Friend WithEvents subject As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents addsubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents category As System.Windows.Forms.ComboBox
End Class
