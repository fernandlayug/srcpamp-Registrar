<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registered
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
        Me.picbarcode = New System.Windows.Forms.PictureBox
        Me.welcome = New System.Windows.Forms.Label
        Me.student = New System.Windows.Forms.Label
        Me.hi = New System.Windows.Forms.Label
        Me.caption = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbarcode
        '
        Me.picbarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picbarcode.Location = New System.Drawing.Point(131, 265)
        Me.picbarcode.Name = "picbarcode"
        Me.picbarcode.Size = New System.Drawing.Size(285, 63)
        Me.picbarcode.TabIndex = 58
        Me.picbarcode.TabStop = False
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Font = New System.Drawing.Font("Bernard MT Condensed", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.Blue
        Me.welcome.Location = New System.Drawing.Point(56, 72)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(428, 39)
        Me.welcome.TabIndex = 57
        Me.welcome.Text = "Welcome to Santa Rita College"
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(191, 21)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 56
        '
        'hi
        '
        Me.hi.AutoSize = True
        Me.hi.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi.Location = New System.Drawing.Point(110, 20)
        Me.hi.Name = "hi"
        Me.hi.Size = New System.Drawing.Size(59, 39)
        Me.hi.TabIndex = 55
        Me.hi.Text = "Hi!"
        '
        'caption
        '
        Me.caption.AutoSize = True
        Me.caption.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caption.Location = New System.Drawing.Point(137, 131)
        Me.caption.Name = "caption"
        Me.caption.Size = New System.Drawing.Size(292, 39)
        Me.caption.TabIndex = 54
        Me.caption.Text = "Your Student ID is"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Red
        Me.id.Location = New System.Drawing.Point(131, 183)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(285, 76)
        Me.id.TabIndex = 53
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 382)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(270, 47)
        Me.RichTextBox1.TabIndex = 60
        Me.RichTextBox1.Text = "Every students is required to present the STUDENT ID at ALL TIMES to any Transact" & _
            "ions requiring an ID Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Please take note your Student ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 349)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 88)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 63
        '
        'registeredinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 458)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picbarcode)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.hi)
        Me.Controls.Add(Me.caption)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Name = "registeredinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registered"
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbarcode As System.Windows.Forms.PictureBox
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents hi As System.Windows.Forms.Label
    Friend WithEvents caption As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
