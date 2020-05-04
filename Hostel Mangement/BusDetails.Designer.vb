<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusDetails
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grpRouteDetails = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTravelTime = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboRouteIDAdde = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSaveRoute = New System.Windows.Forms.Button()
        Me.btnUpdateRouteDetails = New System.Windows.Forms.Button()
        Me.txtRouteDescription = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkDriverDetail = New System.Windows.Forms.CheckBox()
        Me.chkBusDetails = New System.Windows.Forms.CheckBox()
        Me.grpBusDetails = New System.Windows.Forms.GroupBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.dname = New System.Windows.Forms.Label()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.cboBusNumber = New System.Windows.Forms.ComboBox()
        Me.cboDriverID = New System.Windows.Forms.ComboBox()
        Me.btnUpdateBus = New System.Windows.Forms.Button()
        Me.cboRouteid = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSaveBus = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtPickerHosTime = New System.Windows.Forms.DateTimePicker()
        Me.DTPickerClgTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpDriverDetail = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cboBlood = New System.Windows.Forms.ComboBox()
        Me.BtnUpdateDriver = New System.Windows.Forms.Button()
        Me.dtPickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboIDType = New System.Windows.Forms.ComboBox()
        Me.txtIDdetails = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLICnumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSaveDriver = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDriverName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDriverID = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboRoute = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBusID = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.grpRouteDetails.SuspendLayout()
        Me.grpBusDetails.SuspendLayout()
        Me.grpDriverDetail.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 520)
        Me.TabControl1.TabIndex = 0
        '
        'tab1
        '
        Me.tab1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tab1.Controls.Add(Me.btnClose)
        Me.tab1.Controls.Add(Me.CheckBox1)
        Me.tab1.Controls.Add(Me.grpRouteDetails)
        Me.tab1.Controls.Add(Me.chkDriverDetail)
        Me.tab1.Controls.Add(Me.chkBusDetails)
        Me.tab1.Controls.Add(Me.grpBusDetails)
        Me.tab1.Controls.Add(Me.grpDriverDetail)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(960, 494)
        Me.tab1.TabIndex = 1
        Me.tab1.Text = "Bus Details"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(829, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 28)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(44, 310)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 22)
        Me.CheckBox1.TabIndex = 34
        Me.CheckBox1.Text = "Route Details"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpRouteDetails
        '
        Me.grpRouteDetails.Controls.Add(Me.Button2)
        Me.grpRouteDetails.Controls.Add(Me.Label23)
        Me.grpRouteDetails.Controls.Add(Me.txtTravelTime)
        Me.grpRouteDetails.Controls.Add(Me.txtDistance)
        Me.grpRouteDetails.Controls.Add(Me.Label22)
        Me.grpRouteDetails.Controls.Add(Me.cboRouteIDAdde)
        Me.grpRouteDetails.Controls.Add(Me.Label4)
        Me.grpRouteDetails.Controls.Add(Me.btnSaveRoute)
        Me.grpRouteDetails.Controls.Add(Me.btnUpdateRouteDetails)
        Me.grpRouteDetails.Controls.Add(Me.txtRouteDescription)
        Me.grpRouteDetails.Controls.Add(Me.Label18)
        Me.grpRouteDetails.Enabled = False
        Me.grpRouteDetails.Location = New System.Drawing.Point(38, 320)
        Me.grpRouteDetails.Name = "grpRouteDetails"
        Me.grpRouteDetails.Size = New System.Drawing.Size(424, 168)
        Me.grpRouteDetails.TabIndex = 33
        Me.grpRouteDetails.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(301, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 15)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Time"
        '
        'txtTravelTime
        '
        Me.txtTravelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTravelTime.Location = New System.Drawing.Point(353, 99)
        Me.txtTravelTime.Name = "txtTravelTime"
        Me.txtTravelTime.Size = New System.Drawing.Size(64, 21)
        Me.txtTravelTime.TabIndex = 9
        '
        'txtDistance
        '
        Me.txtDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistance.Location = New System.Drawing.Point(242, 98)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(53, 21)
        Me.txtDistance.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(53, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 15)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Distance"
        '
        'cboRouteIDAdde
        '
        Me.cboRouteIDAdde.FormattingEnabled = True
        Me.cboRouteIDAdde.Location = New System.Drawing.Point(243, 16)
        Me.cboRouteIDAdde.Name = "cboRouteIDAdde"
        Me.cboRouteIDAdde.Size = New System.Drawing.Size(142, 21)
        Me.cboRouteIDAdde.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Route ID"
        '
        'btnSaveRoute
        '
        Me.btnSaveRoute.Location = New System.Drawing.Point(138, 135)
        Me.btnSaveRoute.Name = "btnSaveRoute"
        Me.btnSaveRoute.Size = New System.Drawing.Size(129, 27)
        Me.btnSaveRoute.TabIndex = 11
        Me.btnSaveRoute.Text = "Save Bus Details"
        Me.btnSaveRoute.UseVisualStyleBackColor = True
        '
        'btnUpdateRouteDetails
        '
        Me.btnUpdateRouteDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRouteDetails.Location = New System.Drawing.Point(273, 135)
        Me.btnUpdateRouteDetails.Name = "btnUpdateRouteDetails"
        Me.btnUpdateRouteDetails.Size = New System.Drawing.Size(145, 27)
        Me.btnUpdateRouteDetails.TabIndex = 12
        Me.btnUpdateRouteDetails.Text = "Update Route Details"
        Me.btnUpdateRouteDetails.UseVisualStyleBackColor = True
        '
        'txtRouteDescription
        '
        Me.txtRouteDescription.Location = New System.Drawing.Point(243, 42)
        Me.txtRouteDescription.Name = "txtRouteDescription"
        Me.txtRouteDescription.Size = New System.Drawing.Size(174, 47)
        Me.txtRouteDescription.TabIndex = 7
        Me.txtRouteDescription.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 15)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Route Description"
        '
        'chkDriverDetail
        '
        Me.chkDriverDetail.AutoSize = True
        Me.chkDriverDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDriverDetail.Location = New System.Drawing.Point(490, 37)
        Me.chkDriverDetail.Name = "chkDriverDetail"
        Me.chkDriverDetail.Size = New System.Drawing.Size(154, 22)
        Me.chkDriverDetail.TabIndex = 13
        Me.chkDriverDetail.Text = "Enter Driver Details"
        Me.chkDriverDetail.UseVisualStyleBackColor = True
        '
        'chkBusDetails
        '
        Me.chkBusDetails.AutoSize = True
        Me.chkBusDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBusDetails.Location = New System.Drawing.Point(44, 12)
        Me.chkBusDetails.Name = "chkBusDetails"
        Me.chkBusDetails.Size = New System.Drawing.Size(141, 22)
        Me.chkBusDetails.TabIndex = 2
        Me.chkBusDetails.Text = "Enter Bus Details"
        Me.chkBusDetails.UseVisualStyleBackColor = True
        '
        'grpBusDetails
        '
        Me.grpBusDetails.Controls.Add(Me.btnAddNew)
        Me.grpBusDetails.Controls.Add(Me.dname)
        Me.grpBusDetails.Controls.Add(Me.MetroTile3)
        Me.grpBusDetails.Controls.Add(Me.MetroTile2)
        Me.grpBusDetails.Controls.Add(Me.Label26)
        Me.grpBusDetails.Controls.Add(Me.Label25)
        Me.grpBusDetails.Controls.Add(Me.Label24)
        Me.grpBusDetails.Controls.Add(Me.MetroTile1)
        Me.grpBusDetails.Controls.Add(Me.cboBusNumber)
        Me.grpBusDetails.Controls.Add(Me.cboDriverID)
        Me.grpBusDetails.Controls.Add(Me.btnUpdateBus)
        Me.grpBusDetails.Controls.Add(Me.cboRouteid)
        Me.grpBusDetails.Controls.Add(Me.Label17)
        Me.grpBusDetails.Controls.Add(Me.btnSaveBus)
        Me.grpBusDetails.Controls.Add(Me.Label7)
        Me.grpBusDetails.Controls.Add(Me.dtPickerHosTime)
        Me.grpBusDetails.Controls.Add(Me.DTPickerClgTime)
        Me.grpBusDetails.Controls.Add(Me.Label6)
        Me.grpBusDetails.Controls.Add(Me.Label5)
        Me.grpBusDetails.Controls.Add(Me.Label3)
        Me.grpBusDetails.Controls.Add(Me.Label2)
        Me.grpBusDetails.Enabled = False
        Me.grpBusDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBusDetails.Location = New System.Drawing.Point(38, 12)
        Me.grpBusDetails.Name = "grpBusDetails"
        Me.grpBusDetails.Size = New System.Drawing.Size(424, 292)
        Me.grpBusDetails.TabIndex = 0
        Me.grpBusDetails.TabStop = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(45, 256)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(83, 27)
        Me.btnAddNew.TabIndex = 66
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'dname
        '
        Me.dname.AutoSize = True
        Me.dname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dname.Location = New System.Drawing.Point(328, 64)
        Me.dname.Name = "dname"
        Me.dname.Size = New System.Drawing.Size(48, 15)
        Me.dname.TabIndex = 39
        Me.dname.Text = "Dname"
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTile3.Location = New System.Drawing.Point(305, 218)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(73, 32)
        Me.MetroTile3.TabIndex = 38
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseCustomForeColor = True
        Me.MetroTile3.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTile2.Location = New System.Drawing.Point(190, 218)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(77, 32)
        Me.MetroTile2.TabIndex = 35
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseCustomForeColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(302, 198)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 15)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Time IN minutes"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(194, 198)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 15)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Distaince"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(47, 198)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 15)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Route Details"
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTile1.Location = New System.Drawing.Point(8, 218)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(166, 32)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroTile1.TabIndex = 34
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'cboBusNumber
        '
        Me.cboBusNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusNumber.FormattingEnabled = True
        Me.cboBusNumber.Location = New System.Drawing.Point(242, 25)
        Me.cboBusNumber.Name = "cboBusNumber"
        Me.cboBusNumber.Size = New System.Drawing.Size(140, 24)
        Me.cboBusNumber.TabIndex = 1
        '
        'cboDriverID
        '
        Me.cboDriverID.FormattingEnabled = True
        Me.cboDriverID.Location = New System.Drawing.Point(242, 60)
        Me.cboDriverID.Name = "cboDriverID"
        Me.cboDriverID.Size = New System.Drawing.Size(80, 24)
        Me.cboDriverID.TabIndex = 2
        '
        'btnUpdateBus
        '
        Me.btnUpdateBus.Location = New System.Drawing.Point(277, 256)
        Me.btnUpdateBus.Name = "btnUpdateBus"
        Me.btnUpdateBus.Size = New System.Drawing.Size(137, 27)
        Me.btnUpdateBus.TabIndex = 5
        Me.btnUpdateBus.Text = "Update Bus Details"
        Me.btnUpdateBus.UseVisualStyleBackColor = True
        '
        'cboRouteid
        '
        Me.cboRouteid.FormattingEnabled = True
        Me.cboRouteid.Location = New System.Drawing.Point(242, 163)
        Me.cboRouteid.Name = "cboRouteid"
        Me.cboRouteid.Size = New System.Drawing.Size(142, 24)
        Me.cboRouteid.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(46, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Route ID"
        '
        'btnSaveBus
        '
        Me.btnSaveBus.Location = New System.Drawing.Point(134, 256)
        Me.btnSaveBus.Name = "btnSaveBus"
        Me.btnSaveBus.Size = New System.Drawing.Size(137, 27)
        Me.btnSaveBus.TabIndex = 4
        Me.btnSaveBus.Text = "Save Bus Details"
        Me.btnSaveBus.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "HOSTEL ARRIVAL TIME"
        '
        'dtPickerHosTime
        '
        Me.dtPickerHosTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerHosTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtPickerHosTime.Location = New System.Drawing.Point(243, 128)
        Me.dtPickerHosTime.Name = "dtPickerHosTime"
        Me.dtPickerHosTime.Size = New System.Drawing.Size(143, 21)
        Me.dtPickerHosTime.TabIndex = 65
        '
        'DTPickerClgTime
        '
        Me.DTPickerClgTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerClgTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPickerClgTime.Location = New System.Drawing.Point(242, 96)
        Me.DTPickerClgTime.Name = "DTPickerClgTime"
        Me.DTPickerClgTime.Size = New System.Drawing.Size(140, 21)
        Me.DTPickerClgTime.TabIndex = 35
        Me.DTPickerClgTime.Value = New Date(2017, 1, 7, 23, 44, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "COLLEGE ARRIVAL TIME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DRIVER ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bus Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 0
        '
        'grpDriverDetail
        '
        Me.grpDriverDetail.Controls.Add(Me.Button3)
        Me.grpDriverDetail.Controls.Add(Me.cboBlood)
        Me.grpDriverDetail.Controls.Add(Me.BtnUpdateDriver)
        Me.grpDriverDetail.Controls.Add(Me.dtPickerDOB)
        Me.grpDriverDetail.Controls.Add(Me.Label16)
        Me.grpDriverDetail.Controls.Add(Me.Label15)
        Me.grpDriverDetail.Controls.Add(Me.cboIDType)
        Me.grpDriverDetail.Controls.Add(Me.txtIDdetails)
        Me.grpDriverDetail.Controls.Add(Me.Label14)
        Me.grpDriverDetail.Controls.Add(Me.Label13)
        Me.grpDriverDetail.Controls.Add(Me.txtContact)
        Me.grpDriverDetail.Controls.Add(Me.Label11)
        Me.grpDriverDetail.Controls.Add(Me.txtLICnumber)
        Me.grpDriverDetail.Controls.Add(Me.Label10)
        Me.grpDriverDetail.Controls.Add(Me.btnSaveDriver)
        Me.grpDriverDetail.Controls.Add(Me.Label8)
        Me.grpDriverDetail.Controls.Add(Me.txtDriverName)
        Me.grpDriverDetail.Controls.Add(Me.Label9)
        Me.grpDriverDetail.Controls.Add(Me.txtDriverID)
        Me.grpDriverDetail.Enabled = False
        Me.grpDriverDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDriverDetail.Location = New System.Drawing.Point(484, 45)
        Me.grpDriverDetail.Name = "grpDriverDetail"
        Me.grpDriverDetail.Size = New System.Drawing.Size(436, 338)
        Me.grpDriverDetail.TabIndex = 31
        Me.grpDriverDetail.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 24)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cboBlood
        '
        Me.cboBlood.FormattingEnabled = True
        Me.cboBlood.Items.AddRange(New Object() {"A+", "O+", "B+", "AB+", "AB-", "O-"})
        Me.cboBlood.Location = New System.Drawing.Point(206, 96)
        Me.cboBlood.Name = "cboBlood"
        Me.cboBlood.Size = New System.Drawing.Size(61, 23)
        Me.cboBlood.TabIndex = 16
        '
        'BtnUpdateDriver
        '
        Me.BtnUpdateDriver.Location = New System.Drawing.Point(206, 288)
        Me.BtnUpdateDriver.Name = "BtnUpdateDriver"
        Me.BtnUpdateDriver.Size = New System.Drawing.Size(144, 27)
        Me.BtnUpdateDriver.TabIndex = 23
        Me.BtnUpdateDriver.Text = "Update Driver Details"
        Me.BtnUpdateDriver.UseVisualStyleBackColor = True
        '
        'dtPickerDOB
        '
        Me.dtPickerDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerDOB.Location = New System.Drawing.Point(317, 97)
        Me.dtPickerDOB.Name = "dtPickerDOB"
        Me.dtPickerDOB.Size = New System.Drawing.Size(111, 21)
        Me.dtPickerDOB.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(278, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "DOB"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(41, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ID Proof Type"
        '
        'cboIDType
        '
        Me.cboIDType.FormattingEnabled = True
        Me.cboIDType.Items.AddRange(New Object() {"Voter ID", "PAN Card", "Aadhhar Card"})
        Me.cboIDType.Location = New System.Drawing.Point(206, 206)
        Me.cboIDType.Name = "cboIDType"
        Me.cboIDType.Size = New System.Drawing.Size(128, 23)
        Me.cboIDType.TabIndex = 20
        '
        'txtIDdetails
        '
        Me.txtIDdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDdetails.Location = New System.Drawing.Point(206, 241)
        Me.txtIDdetails.Name = "txtIDdetails"
        Me.txtIDdetails.Size = New System.Drawing.Size(222, 21)
        Me.txtIDdetails.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "ID Proof Details"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Blood Group"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(204, 171)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(130, 21)
        Me.txtContact.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Contact Number"
        '
        'txtLICnumber
        '
        Me.txtLICnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLICnumber.Location = New System.Drawing.Point(204, 133)
        Me.txtLICnumber.Name = "txtLICnumber"
        Me.txtLICnumber.Size = New System.Drawing.Size(224, 21)
        Me.txtLICnumber.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Licence Number"
        '
        'btnSaveDriver
        '
        Me.btnSaveDriver.Location = New System.Drawing.Point(44, 288)
        Me.btnSaveDriver.Name = "btnSaveDriver"
        Me.btnSaveDriver.Size = New System.Drawing.Size(132, 27)
        Me.btnSaveDriver.TabIndex = 22
        Me.btnSaveDriver.Text = "Save Driver Details"
        Me.btnSaveDriver.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Driver ID"
        '
        'txtDriverName
        '
        Me.txtDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(204, 63)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(224, 21)
        Me.txtDriverName.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Driver Name"
        '
        'txtDriverID
        '
        Me.txtDriverID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverID.Location = New System.Drawing.Point(204, 28)
        Me.txtDriverID.Name = "txtDriverID"
        Me.txtDriverID.Size = New System.Drawing.Size(119, 21)
        Me.txtDriverID.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.btnView)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cboRoute)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cboBusID)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(960, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Driver"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(463, 26)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(99, 30)
        Me.btnView.TabIndex = 26
        Me.btnView.Text = "View Details"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(245, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Route ID"
        '
        'cboRoute
        '
        Me.cboRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoute.FormattingEnabled = True
        Me.cboRoute.Location = New System.Drawing.Point(311, 27)
        Me.cboRoute.Name = "cboRoute"
        Me.cboRoute.Size = New System.Drawing.Size(86, 24)
        Me.cboRoute.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Bus Number"
        '
        'cboBusID
        '
        Me.cboBusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusID.FormattingEnabled = True
        Me.cboBusID.Location = New System.Drawing.Point(127, 30)
        Me.cboBusID.Name = "cboBusID"
        Me.cboBusID.Size = New System.Drawing.Size(93, 24)
        Me.cboBusID.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.cboyear)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cboName)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.cboClass)
        Me.TabPage2.Controls.Add(Me.BtnSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(960, 494)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Student Bus Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(802, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 30)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "View Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(225, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 16)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Year"
        '
        'cboyear
        '
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"I-Year", "II-Year", "III-Year", "I-Semester", "II-Semester", "III-Semester", "IV-Semester"})
        Me.cboyear.Location = New System.Drawing.Point(284, 18)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(86, 24)
        Me.cboyear.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(538, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 16)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Name"
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(601, 18)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(169, 24)
        Me.cboName.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Class"
        '
        'cboClass
        '
        Me.cboClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(96, 18)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(93, 24)
        Me.cboClass.TabIndex = 20
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(403, 14)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(99, 30)
        Me.BtnSearch.TabIndex = 19
        Me.BtnSearch.Text = "Search Student"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BusDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "BusDetails"
        Me.ShowIcon = False
        Me.Text = "Bus Details"
        Me.TabControl1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab1.PerformLayout()
        Me.grpRouteDetails.ResumeLayout(False)
        Me.grpRouteDetails.PerformLayout()
        Me.grpBusDetails.ResumeLayout(False)
        Me.grpBusDetails.PerformLayout()
        Me.grpDriverDetail.ResumeLayout(False)
        Me.grpDriverDetail.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tab1 As System.Windows.Forms.TabPage
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboRoute As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBusID As System.Windows.Forms.ComboBox
    Friend WithEvents grpBusDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtPickerHosTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPickerClgTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkBusDetails As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboRouteid As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateBus As System.Windows.Forms.Button
    Friend WithEvents btnSaveBus As System.Windows.Forms.Button
    Friend WithEvents cboDriverID As System.Windows.Forms.ComboBox
    Friend WithEvents grpDriverDetail As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUpdateDriver As System.Windows.Forms.Button
    Friend WithEvents dtPickerDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboIDType As System.Windows.Forms.ComboBox
    Friend WithEvents txtIDdetails As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLICnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSaveDriver As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDriverID As System.Windows.Forms.TextBox
    Friend WithEvents chkDriverDetail As System.Windows.Forms.CheckBox
    Friend WithEvents cboBlood As System.Windows.Forms.ComboBox
    Friend WithEvents cboBusNumber As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpRouteDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateRouteDetails As System.Windows.Forms.Button
    Friend WithEvents txtRouteDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSaveRoute As System.Windows.Forms.Button
    Friend WithEvents cboRouteIDAdde As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTravelTime As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dname As System.Windows.Forms.Label
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
