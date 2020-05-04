<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudemtCheckInOutEntry
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.txtvehicle = New System.Windows.Forms.TextBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Vname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.VisitWith = New System.Windows.Forms.Label()
        Me.mtGoingWith = New MetroFramework.Controls.MetroComboBox()
        Me.txtRemark = New System.Windows.Forms.RichTextBox()
        Me.txtpurpose = New System.Windows.Forms.RichTextBox()
        Me.TXTsid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboStudentName = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdochkOUT = New System.Windows.Forms.RadioButton()
        Me.rdoCHKin = New System.Windows.Forms.RadioButton()
        Me.DtGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClick = New MetroFramework.Controls.MetroButton()
        Me.dtPickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.txtGaurdOnDuty = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.gb2.SuspendLayout()
        Me.gb1.SuspendLayout()
        CType(Me.DtGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb2
        '
        Me.gb2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gb2.Controls.Add(Me.btnClose)
        Me.gb2.Controls.Add(Me.btnSave)
        Me.gb2.Location = New System.Drawing.Point(89, 561)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(380, 70)
        Me.gb2.TabIndex = 14
        Me.gb2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClose.Location = New System.Drawing.Point(203, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 40)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.Location = New System.Drawing.Point(46, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 40)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Viiting Details"
        Me.btnSave.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Check Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date & Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Purpose"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Vehicle Number"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(167, 156)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(176, 22)
        Me.dtp1.TabIndex = 7
        '
        'txtvehicle
        '
        Me.txtvehicle.Location = New System.Drawing.Point(169, 274)
        Me.txtvehicle.Name = "txtvehicle"
        Me.txtvehicle.Size = New System.Drawing.Size(175, 22)
        Me.txtvehicle.TabIndex = 10
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gb1.Controls.Add(Me.DateTimePicker1)
        Me.gb1.Controls.Add(Me.Label17)
        Me.gb1.Controls.Add(Me.Label16)
        Me.gb1.Controls.Add(Me.TextBox1)
        Me.gb1.Controls.Add(Me.Vname)
        Me.gb1.Controls.Add(Me.txtName)
        Me.gb1.Controls.Add(Me.VisitWith)
        Me.gb1.Controls.Add(Me.mtGoingWith)
        Me.gb1.Controls.Add(Me.txtRemark)
        Me.gb1.Controls.Add(Me.txtpurpose)
        Me.gb1.Controls.Add(Me.TXTsid)
        Me.gb1.Controls.Add(Me.Label14)
        Me.gb1.Controls.Add(Me.Label15)
        Me.gb1.Controls.Add(Me.cboStudentName)
        Me.gb1.Controls.Add(Me.cboYear)
        Me.gb1.Controls.Add(Me.cboClass)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Label13)
        Me.gb1.Controls.Add(Me.rdochkOUT)
        Me.gb1.Controls.Add(Me.rdoCHKin)
        Me.gb1.Controls.Add(Me.txtvehicle)
        Me.gb1.Controls.Add(Me.dtp1)
        Me.gb1.Controls.Add(Me.Label6)
        Me.gb1.Controls.Add(Me.Label5)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(89, 85)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(380, 476)
        Me.gb1.TabIndex = 13
        Me.gb1.TabStop = False
        Me.gb1.Text = "Attendance"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(168, 185)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 22)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Visiting Day/Hour"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(45, 385)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Contact Number"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(169, 380)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 21)
        Me.TextBox1.TabIndex = 13
        '
        'Vname
        '
        Me.Vname.AutoSize = True
        Me.Vname.Location = New System.Drawing.Point(44, 352)
        Me.Vname.Name = "Vname"
        Me.Vname.Size = New System.Drawing.Size(45, 16)
        Me.Vname.TabIndex = 46
        Me.Vname.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(168, 347)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 21)
        Me.txtName.TabIndex = 12
        '
        'VisitWith
        '
        Me.VisitWith.AutoSize = True
        Me.VisitWith.Location = New System.Drawing.Point(44, 318)
        Me.VisitWith.Name = "VisitWith"
        Me.VisitWith.Size = New System.Drawing.Size(80, 16)
        Me.VisitWith.TabIndex = 44
        Me.VisitWith.Text = "Visiting With"
        '
        'mtGoingWith
        '
        Me.mtGoingWith.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mtGoingWith.FormattingEnabled = True
        Me.mtGoingWith.ItemHeight = 19
        Me.mtGoingWith.Items.AddRange(New Object() {"Friend", "Parent", "Other"})
        Me.mtGoingWith.Location = New System.Drawing.Point(169, 309)
        Me.mtGoingWith.Name = "mtGoingWith"
        Me.mtGoingWith.Size = New System.Drawing.Size(175, 25)
        Me.mtGoingWith.TabIndex = 11
        Me.mtGoingWith.UseSelectable = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(169, 414)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(174, 44)
        Me.txtRemark.TabIndex = 14
        Me.txtRemark.Text = ""
        '
        'txtpurpose
        '
        Me.txtpurpose.Location = New System.Drawing.Point(167, 218)
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.Size = New System.Drawing.Size(177, 43)
        Me.txtpurpose.TabIndex = 9
        Me.txtpurpose.Text = ""
        '
        'TXTsid
        '
        Me.TXTsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTsid.Location = New System.Drawing.Point(168, 96)
        Me.TXTsid.Name = "TXTsid"
        Me.TXTsid.Size = New System.Drawing.Size(176, 20)
        Me.TXTsid.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(43, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Student ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(43, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Student Name"
        '
        'cboStudentName
        '
        Me.cboStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentName.FormattingEnabled = True
        Me.cboStudentName.Location = New System.Drawing.Point(168, 63)
        Me.cboStudentName.Name = "cboStudentName"
        Me.cboStudentName.Size = New System.Drawing.Size(176, 21)
        Me.cboStudentName.TabIndex = 3
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(275, 30)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(68, 21)
        Me.cboYear.TabIndex = 2
        '
        'cboClass
        '
        Me.cboClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(168, 30)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(60, 21)
        Me.cboClass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Year"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(43, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Class Name"
        '
        'rdochkOUT
        '
        Me.rdochkOUT.AutoSize = True
        Me.rdochkOUT.Location = New System.Drawing.Point(167, 128)
        Me.rdochkOUT.Name = "rdochkOUT"
        Me.rdochkOUT.Size = New System.Drawing.Size(87, 20)
        Me.rdochkOUT.TabIndex = 5
        Me.rdochkOUT.TabStop = True
        Me.rdochkOUT.Text = "Check Out"
        Me.rdochkOUT.UseVisualStyleBackColor = True
        '
        'rdoCHKin
        '
        Me.rdoCHKin.AutoSize = True
        Me.rdoCHKin.Location = New System.Drawing.Point(270, 128)
        Me.rdoCHKin.Name = "rdoCHKin"
        Me.rdoCHKin.Size = New System.Drawing.Size(77, 20)
        Me.rdoCHKin.TabIndex = 6
        Me.rdoCHKin.TabStop = True
        Me.rdoCHKin.Text = "Check In"
        Me.rdoCHKin.UseVisualStyleBackColor = True
        '
        'DtGridView
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtGridView.Location = New System.Drawing.Point(475, 260)
        Me.DtGridView.Name = "DtGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtGridView.Size = New System.Drawing.Size(784, 352)
        Me.DtGridView.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(475, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 176)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Attendance"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnClick)
        Me.GroupBox2.Controls.Add(Me.dtPickerEnd)
        Me.GroupBox2.Controls.Add(Me.dtPickerStart)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 139)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View Attendance Between Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(294, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(100, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "From"
        '
        'btnClick
        '
        Me.btnClick.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClick.Location = New System.Drawing.Point(196, 83)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(133, 33)
        Me.btnClick.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnClick.TabIndex = 19
        Me.btnClick.Text = "Click to View "
        Me.btnClick.UseSelectable = True
        '
        'dtPickerEnd
        '
        Me.dtPickerEnd.CustomFormat = "MM-dd-yyyy"
        Me.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerEnd.Location = New System.Drawing.Point(325, 36)
        Me.dtPickerEnd.Name = "dtPickerEnd"
        Me.dtPickerEnd.Size = New System.Drawing.Size(98, 22)
        Me.dtPickerEnd.TabIndex = 18
        '
        'dtPickerStart
        '
        Me.dtPickerStart.CustomFormat = "MM-dd-yyyy"
        Me.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerStart.Location = New System.Drawing.Point(145, 37)
        Me.dtPickerStart.Name = "dtPickerStart"
        Me.dtPickerStart.Size = New System.Drawing.Size(98, 22)
        Me.dtPickerStart.TabIndex = 17
        '
        'MetroStyleExtender1
        '
        Me.MetroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'txtGaurdOnDuty
        '
        Me.txtGaurdOnDuty.AutoSize = True
        Me.txtGaurdOnDuty.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.txtGaurdOnDuty.Location = New System.Drawing.Point(606, 43)
        Me.txtGaurdOnDuty.Name = "txtGaurdOnDuty"
        Me.txtGaurdOnDuty.Size = New System.Drawing.Size(103, 25)
        Me.txtGaurdOnDuty.TabIndex = 45
        Me.txtGaurdOnDuty.Text = "MetroLabel1"
        Me.txtGaurdOnDuty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.ForeColor = System.Drawing.Color.Crimson
        Me.MetroTile1.Location = New System.Drawing.Point(414, 43)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(160, 25)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroTile1.TabIndex = 46
        Me.MetroTile1.Text = "Gaurd on Duty :"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.ForeColor = System.Drawing.Color.Crimson
        Me.MetroTile2.Location = New System.Drawing.Point(406, 12)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(320, 25)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.White
        Me.MetroTile2.TabIndex = 47
        Me.MetroTile2.Text = "Student Check in/Check out Entry"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomForeColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(1265, 588)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(109, 32)
        Me.btnReport.TabIndex = 48
        Me.btnReport.Text = "View Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'StudemtCheckInOutEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 637)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.txtGaurdOnDuty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtGridView)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StudemtCheckInOutEntry"
        Me.Text = "Student Check in /check out entry"
        Me.gb2.ResumeLayout(False)
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.DtGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtvehicle As System.Windows.Forms.TextBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtGridView As System.Windows.Forms.DataGridView
    Friend WithEvents rdochkOUT As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCHKin As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtPickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTsid As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboStudentName As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents txtGaurdOnDuty As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents txtpurpose As System.Windows.Forms.RichTextBox
    Friend WithEvents mtGoingWith As MetroFramework.Controls.MetroComboBox
    Friend WithEvents VisitWith As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Vname As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnClick As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
