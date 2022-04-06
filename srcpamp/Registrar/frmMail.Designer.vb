<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMail
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
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btncredential = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(97, 13)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(229, 20)
        Me.txtFrom.TabIndex = 0
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(97, 39)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(229, 20)
        Me.txtSubject.TabIndex = 1
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(97, 65)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(229, 20)
        Me.txtTo.TabIndex = 2
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(38, 116)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(541, 264)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FROM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SUBJECT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MESSAGE"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(473, 386)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(106, 23)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send Mail"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(39, 386)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(428, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'btncredential
        '
        Me.btncredential.Enabled = False
        Me.btncredential.Location = New System.Drawing.Point(351, 12)
        Me.btncredential.Name = "btncredential"
        Me.btncredential.Size = New System.Drawing.Size(106, 23)
        Me.btncredential.TabIndex = 11
        Me.btncredential.Text = "Email Credentials"
        Me.btncredential.UseVisualStyleBackColor = True
        '
        'frmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 450)
        Me.Controls.Add(Me.btncredential)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtFrom)
        Me.Name = "frmMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtMessage As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btncredential As Button
End Class
