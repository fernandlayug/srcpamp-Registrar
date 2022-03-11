<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptpayslip
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
        Me.namePM = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Month = New System.Windows.Forms.Label()
        Me.payslipno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.yr = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.monthCovered = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'namePM
        '
        Me.namePM.AutoSize = True
        Me.namePM.Location = New System.Drawing.Point(15, 123)
        Me.namePM.Name = "namePM"
        Me.namePM.Size = New System.Drawing.Size(39, 13)
        Me.namePM.TabIndex = 65
        Me.namePM.Text = "Label1"
        Me.namePM.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 290
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Month
        '
        Me.Month.AutoSize = True
        Me.Month.Location = New System.Drawing.Point(15, 139)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(39, 13)
        Me.Month.TabIndex = 291
        Me.Month.Text = "Label1"
        Me.Month.Visible = False
        '
        'payslipno
        '
        Me.payslipno.FormattingEnabled = True
        Me.payslipno.Location = New System.Drawing.Point(77, 96)
        Me.payslipno.Name = "payslipno"
        Me.payslipno.Size = New System.Drawing.Size(161, 21)
        Me.payslipno.TabIndex = 292
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "Payslip No:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.yr)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.monthCovered)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(227, 73)
        Me.GroupBox4.TabIndex = 293
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Duration Covered:"
        '
        'yr
        '
        Me.yr.FormattingEnabled = True
        Me.yr.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017"})
        Me.yr.Location = New System.Drawing.Point(43, 43)
        Me.yr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.yr.Name = "yr"
        Me.yr.Size = New System.Drawing.Size(91, 21)
        Me.yr.TabIndex = 288
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(4, 45)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 21)
        Me.Label24.TabIndex = 287
        Me.Label24.Text = "Year"
        '
        'monthCovered
        '
        Me.monthCovered.FormattingEnabled = True
        Me.monthCovered.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthCovered.Location = New System.Drawing.Point(43, 18)
        Me.monthCovered.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.monthCovered.Name = "monthCovered"
        Me.monthCovered.Size = New System.Drawing.Size(129, 21)
        Me.monthCovered.TabIndex = 286
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(4, 21)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 21)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Month"
        '
        'rptpayslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 171)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.payslipno)
        Me.Controls.Add(Me.Month)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.namePM)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "rptpayslip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents namePM As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Month As System.Windows.Forms.Label
    Friend WithEvents payslipno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents yr As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents monthCovered As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
