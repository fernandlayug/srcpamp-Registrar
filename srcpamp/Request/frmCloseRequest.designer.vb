<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloseRequest
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
        Me.requestername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.activity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.timestart = New System.Windows.Forms.MaskedTextBox()
        Me.timeend = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.others = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.systemunit = New System.Windows.Forms.CheckBox()
        Me.extensioncord = New System.Windows.Forms.CheckBox()
        Me.speaker = New System.Windows.Forms.CheckBox()
        Me.wirelessmic = New System.Windows.Forms.CheckBox()
        Me.audiojack = New System.Windows.Forms.CheckBox()
        Me.whitescreen = New System.Windows.Forms.CheckBox()
        Me.dvdplayer = New System.Windows.Forms.CheckBox()
        Me.systemunit1 = New System.Windows.Forms.TextBox()
        Me.extensioncord1 = New System.Windows.Forms.TextBox()
        Me.speaker1 = New System.Windows.Forms.TextBox()
        Me.wirelessmic1 = New System.Windows.Forms.TextBox()
        Me.audiojack1 = New System.Windows.Forms.TextBox()
        Me.whitescreen1 = New System.Windows.Forms.TextBox()
        Me.dvdplayer1 = New System.Windows.Forms.TextBox()
        Me.department = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.reqid = New System.Windows.Forms.TextBox()
        Me.requestdone = New System.Windows.Forms.CheckBox()
        Me.cancelrequest = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dateusestart = New System.Windows.Forms.MaskedTextBox()
        Me.dateuseend = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.facility = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.loc_room = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'requestername
        '
        Me.requestername.BackColor = System.Drawing.SystemColors.Control
        Me.requestername.Enabled = False
        Me.requestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestername.ForeColor = System.Drawing.Color.Black
        Me.requestername.Location = New System.Drawing.Point(206, 120)
        Me.requestername.Name = "requestername"
        Me.requestername.Size = New System.Drawing.Size(230, 20)
        Me.requestername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Requester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Activity"
        '
        'activity
        '
        Me.activity.BackColor = System.Drawing.SystemColors.Control
        Me.activity.Enabled = False
        Me.activity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activity.ForeColor = System.Drawing.Color.Black
        Me.activity.Location = New System.Drawing.Point(139, 148)
        Me.activity.Name = "activity"
        Me.activity.Size = New System.Drawing.Size(297, 20)
        Me.activity.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Room/Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Use"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Time of Use:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Start"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "End"
        '
        'timestart
        '
        Me.timestart.BackColor = System.Drawing.SystemColors.Control
        Me.timestart.Enabled = False
        Me.timestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timestart.Location = New System.Drawing.Point(176, 270)
        Me.timestart.Mask = "90:00"
        Me.timestart.Name = "timestart"
        Me.timestart.Size = New System.Drawing.Size(80, 22)
        Me.timestart.TabIndex = 16
        Me.timestart.ValidatingType = GetType(Date)
        '
        'timeend
        '
        Me.timeend.BackColor = System.Drawing.SystemColors.Control
        Me.timeend.Enabled = False
        Me.timeend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeend.Location = New System.Drawing.Point(300, 271)
        Me.timeend.Mask = "90:00"
        Me.timeend.Name = "timeend"
        Me.timeend.Size = New System.Drawing.Size(126, 22)
        Me.timeend.TabIndex = 17
        Me.timeend.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Facility"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Supporting Materials"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Others. Please Specify"
        '
        'others
        '
        Me.others.BackColor = System.Drawing.SystemColors.Control
        Me.others.Enabled = False
        Me.others.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.others.Location = New System.Drawing.Point(176, 405)
        Me.others.Name = "others"
        Me.others.Size = New System.Drawing.Size(262, 22)
        Me.others.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 43)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(237, 470)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 43)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(119, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 31)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Close/Cancel Request"
        '
        'systemunit
        '
        Me.systemunit.AutoSize = True
        Me.systemunit.Enabled = False
        Me.systemunit.Location = New System.Drawing.Point(162, 340)
        Me.systemunit.Name = "systemunit"
        Me.systemunit.Size = New System.Drawing.Size(82, 17)
        Me.systemunit.TabIndex = 21
        Me.systemunit.Text = "System Unit"
        Me.systemunit.UseVisualStyleBackColor = True
        '
        'extensioncord
        '
        Me.extensioncord.AutoSize = True
        Me.extensioncord.Enabled = False
        Me.extensioncord.Location = New System.Drawing.Point(250, 340)
        Me.extensioncord.Name = "extensioncord"
        Me.extensioncord.Size = New System.Drawing.Size(97, 17)
        Me.extensioncord.TabIndex = 22
        Me.extensioncord.Text = "Extension Cord"
        Me.extensioncord.UseVisualStyleBackColor = True
        '
        'speaker
        '
        Me.speaker.AutoSize = True
        Me.speaker.Enabled = False
        Me.speaker.Location = New System.Drawing.Point(353, 340)
        Me.speaker.Name = "speaker"
        Me.speaker.Size = New System.Drawing.Size(66, 17)
        Me.speaker.TabIndex = 23
        Me.speaker.Text = "Speaker"
        Me.speaker.UseVisualStyleBackColor = True
        '
        'wirelessmic
        '
        Me.wirelessmic.AutoSize = True
        Me.wirelessmic.Enabled = False
        Me.wirelessmic.Location = New System.Drawing.Point(162, 363)
        Me.wirelessmic.Name = "wirelessmic"
        Me.wirelessmic.Size = New System.Drawing.Size(86, 17)
        Me.wirelessmic.TabIndex = 24
        Me.wirelessmic.Text = "Wireless Mic"
        Me.wirelessmic.UseVisualStyleBackColor = True
        '
        'audiojack
        '
        Me.audiojack.AutoSize = True
        Me.audiojack.Enabled = False
        Me.audiojack.Location = New System.Drawing.Point(250, 363)
        Me.audiojack.Name = "audiojack"
        Me.audiojack.Size = New System.Drawing.Size(79, 17)
        Me.audiojack.TabIndex = 25
        Me.audiojack.Text = "Audio Jack"
        Me.audiojack.UseVisualStyleBackColor = True
        '
        'whitescreen
        '
        Me.whitescreen.AutoSize = True
        Me.whitescreen.Enabled = False
        Me.whitescreen.Location = New System.Drawing.Point(335, 363)
        Me.whitescreen.Name = "whitescreen"
        Me.whitescreen.Size = New System.Drawing.Size(91, 17)
        Me.whitescreen.TabIndex = 26
        Me.whitescreen.Text = "White Screen"
        Me.whitescreen.UseVisualStyleBackColor = True
        '
        'dvdplayer
        '
        Me.dvdplayer.AutoSize = True
        Me.dvdplayer.Enabled = False
        Me.dvdplayer.Location = New System.Drawing.Point(162, 386)
        Me.dvdplayer.Name = "dvdplayer"
        Me.dvdplayer.Size = New System.Drawing.Size(78, 17)
        Me.dvdplayer.TabIndex = 27
        Me.dvdplayer.Text = "Dvd Player"
        Me.dvdplayer.UseVisualStyleBackColor = True
        '
        'systemunit1
        '
        Me.systemunit1.Location = New System.Drawing.Point(30, 471)
        Me.systemunit1.Name = "systemunit1"
        Me.systemunit1.Size = New System.Drawing.Size(141, 20)
        Me.systemunit1.TabIndex = 33
        Me.systemunit1.Visible = False
        '
        'extensioncord1
        '
        Me.extensioncord1.Location = New System.Drawing.Point(69, 471)
        Me.extensioncord1.Name = "extensioncord1"
        Me.extensioncord1.Size = New System.Drawing.Size(100, 20)
        Me.extensioncord1.TabIndex = 34
        Me.extensioncord1.Visible = False
        '
        'speaker1
        '
        Me.speaker1.Location = New System.Drawing.Point(52, 471)
        Me.speaker1.Name = "speaker1"
        Me.speaker1.Size = New System.Drawing.Size(100, 20)
        Me.speaker1.TabIndex = 35
        Me.speaker1.Visible = False
        '
        'wirelessmic1
        '
        Me.wirelessmic1.Location = New System.Drawing.Point(71, 471)
        Me.wirelessmic1.Name = "wirelessmic1"
        Me.wirelessmic1.Size = New System.Drawing.Size(100, 20)
        Me.wirelessmic1.TabIndex = 36
        Me.wirelessmic1.Visible = False
        '
        'audiojack1
        '
        Me.audiojack1.Location = New System.Drawing.Point(52, 471)
        Me.audiojack1.Name = "audiojack1"
        Me.audiojack1.Size = New System.Drawing.Size(100, 20)
        Me.audiojack1.TabIndex = 37
        Me.audiojack1.Visible = False
        '
        'whitescreen1
        '
        Me.whitescreen1.Location = New System.Drawing.Point(52, 471)
        Me.whitescreen1.Name = "whitescreen1"
        Me.whitescreen1.Size = New System.Drawing.Size(100, 20)
        Me.whitescreen1.TabIndex = 38
        Me.whitescreen1.Visible = False
        '
        'dvdplayer1
        '
        Me.dvdplayer1.Location = New System.Drawing.Point(30, 471)
        Me.dvdplayer1.Name = "dvdplayer1"
        Me.dvdplayer1.Size = New System.Drawing.Size(100, 20)
        Me.dvdplayer1.TabIndex = 39
        Me.dvdplayer1.Visible = False
        '
        'department
        '
        Me.department.BackColor = System.Drawing.SystemColors.Control
        Me.department.Enabled = False
        Me.department.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.ForeColor = System.Drawing.Color.Black
        Me.department.FormattingEnabled = True
        Me.department.Items.AddRange(New Object() {"Grade School", "HighSchool", "College"})
        Me.department.Location = New System.Drawing.Point(140, 209)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(297, 21)
        Me.department.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Request ID"
        '
        'reqid
        '
        Me.reqid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqid.Location = New System.Drawing.Point(140, 53)
        Me.reqid.Name = "reqid"
        Me.reqid.Size = New System.Drawing.Size(156, 35)
        Me.reqid.TabIndex = 42
        '
        'requestdone
        '
        Me.requestdone.AutoSize = True
        Me.requestdone.Location = New System.Drawing.Point(314, 53)
        Me.requestdone.Name = "requestdone"
        Me.requestdone.Size = New System.Drawing.Size(95, 17)
        Me.requestdone.TabIndex = 44
        Me.requestdone.Text = "Request Done"
        Me.requestdone.UseVisualStyleBackColor = True
        '
        'cancelrequest
        '
        Me.cancelrequest.AutoSize = True
        Me.cancelrequest.Location = New System.Drawing.Point(314, 76)
        Me.cancelrequest.Name = "cancelrequest"
        Me.cancelrequest.Size = New System.Drawing.Size(102, 17)
        Me.cancelrequest.TabIndex = 45
        Me.cancelrequest.Text = "Cancel Request"
        Me.cancelrequest.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(137, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Start"
        '
        'dateusestart
        '
        Me.dateusestart.BackColor = System.Drawing.SystemColors.Control
        Me.dateusestart.Enabled = False
        Me.dateusestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateusestart.Location = New System.Drawing.Point(175, 238)
        Me.dateusestart.Name = "dateusestart"
        Me.dateusestart.Size = New System.Drawing.Size(90, 22)
        Me.dateusestart.TabIndex = 47
        '
        'dateuseend
        '
        Me.dateuseend.BackColor = System.Drawing.SystemColors.Control
        Me.dateuseend.Enabled = False
        Me.dateuseend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateuseend.Location = New System.Drawing.Point(314, 238)
        Me.dateuseend.Name = "dateuseend"
        Me.dateuseend.Size = New System.Drawing.Size(112, 22)
        Me.dateuseend.TabIndex = 48
        Me.dateuseend.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(276, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "End"
        '
        'facility
        '
        Me.facility.BackColor = System.Drawing.SystemColors.Control
        Me.facility.Enabled = False
        Me.facility.Location = New System.Drawing.Point(144, 304)
        Me.facility.Name = "facility"
        Me.facility.Size = New System.Drawing.Size(283, 20)
        Me.facility.TabIndex = 50
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(315, 94)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(100, 20)
        Me.status.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 436)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 16)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Remarks"
        '
        'remarks
        '
        Me.remarks.BackColor = System.Drawing.SystemColors.Control
        Me.remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarks.Location = New System.Drawing.Point(96, 433)
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(340, 22)
        Me.remarks.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(264, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Status"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 56
        Me.TextBox1.Visible = False
        '
        'loc_room
        '
        Me.loc_room.Location = New System.Drawing.Point(138, 183)
        Me.loc_room.Name = "loc_room"
        Me.loc_room.Size = New System.Drawing.Size(298, 20)
        Me.loc_room.TabIndex = 57
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.SystemColors.Control
        Me.ID.Enabled = False
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.Black
        Me.ID.Location = New System.Drawing.Point(138, 120)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(62, 20)
        Me.ID.TabIndex = 58
        '
        'frmCloseRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(472, 517)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.loc_room)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.facility)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dateuseend)
        Me.Controls.Add(Me.dateusestart)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cancelrequest)
        Me.Controls.Add(Me.requestdone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.reqid)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.dvdplayer1)
        Me.Controls.Add(Me.whitescreen1)
        Me.Controls.Add(Me.audiojack1)
        Me.Controls.Add(Me.wirelessmic1)
        Me.Controls.Add(Me.speaker1)
        Me.Controls.Add(Me.extensioncord1)
        Me.Controls.Add(Me.systemunit1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.others)
        Me.Controls.Add(Me.dvdplayer)
        Me.Controls.Add(Me.whitescreen)
        Me.Controls.Add(Me.audiojack)
        Me.Controls.Add(Me.wirelessmic)
        Me.Controls.Add(Me.speaker)
        Me.Controls.Add(Me.extensioncord)
        Me.Controls.Add(Me.systemunit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.timeend)
        Me.Controls.Add(Me.timestart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.activity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.requestername)
        Me.Name = "frmCloseRequest"
        Me.Text = "Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents requestername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents activity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents timestart As System.Windows.Forms.MaskedTextBox
    Friend WithEvents timeend As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents others As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents systemunit As System.Windows.Forms.CheckBox
    Friend WithEvents extensioncord As System.Windows.Forms.CheckBox
    Friend WithEvents speaker As System.Windows.Forms.CheckBox
    Friend WithEvents wirelessmic As System.Windows.Forms.CheckBox
    Friend WithEvents audiojack As System.Windows.Forms.CheckBox
    Friend WithEvents whitescreen As System.Windows.Forms.CheckBox
    Friend WithEvents dvdplayer As System.Windows.Forms.CheckBox
    Friend WithEvents systemunit1 As System.Windows.Forms.TextBox
    Friend WithEvents extensioncord1 As System.Windows.Forms.TextBox
    Friend WithEvents speaker1 As System.Windows.Forms.TextBox
    Friend WithEvents wirelessmic1 As System.Windows.Forms.TextBox
    Friend WithEvents audiojack1 As System.Windows.Forms.TextBox
    Friend WithEvents whitescreen1 As System.Windows.Forms.TextBox
    Friend WithEvents dvdplayer1 As System.Windows.Forms.TextBox
    Friend WithEvents department As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents reqid As System.Windows.Forms.TextBox
    Friend WithEvents requestdone As System.Windows.Forms.CheckBox
    Friend WithEvents cancelrequest As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dateusestart As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dateuseend As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents facility As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents loc_room As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
End Class
