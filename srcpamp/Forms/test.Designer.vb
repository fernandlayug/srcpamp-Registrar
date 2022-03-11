<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.gridparticular = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ddldisabled = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridparticular
        '
        Me.gridparticular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.gridparticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridparticular.Location = New System.Drawing.Point(42, 122)
        Me.gridparticular.Name = "gridparticular"
        Me.gridparticular.Size = New System.Drawing.Size(682, 150)
        Me.gridparticular.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ddldisabled
        '
        Me.ddldisabled.Enabled = False
        Me.ddldisabled.FormattingEnabled = True
        Me.ddldisabled.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ddldisabled.Location = New System.Drawing.Point(327, 38)
        Me.ddldisabled.Name = "ddldisabled"
        Me.ddldisabled.Size = New System.Drawing.Size(188, 21)
        Me.ddldisabled.TabIndex = 2
        Me.ddldisabled.Text = "Select"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 278)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(327, 278)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 425)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ddldisabled)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gridparticular)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridparticular As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ddldisabled As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
