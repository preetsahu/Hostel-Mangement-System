<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostelExpanse
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExpDescription = New System.Windows.Forms.RichTextBox()
        Me.mtExpType = New MetroFramework.Controls.MetroComboBox()
        Me.txtBillno = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtExpanse = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClick = New MetroFramework.Controls.MetroButton()
        Me.dtPickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.dtp1Monthly = New System.Windows.Forms.DateTimePicker()
        Me.dtp2Monthly = New System.Windows.Forms.DateTimePicker()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TxtYear = New MetroFramework.Controls.MetroTextBox()
        Me.cboMonth = New MetroFramework.Controls.MetroComboBox()
        Me.BtnViewReport = New MetroFramework.Controls.MetroButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(999, 474)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(991, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hostel Expanditure Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 76)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClose.Location = New System.Drawing.Point(194, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 34)
        Me.btnClose.Style = MetroFramework.MetroColorStyle.Silver
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.Location = New System.Drawing.Point(32, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 34)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Silver
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save Expanse"
        Me.btnSave.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.txtExpDescription)
        Me.GroupBox1.Controls.Add(Me.mtExpType)
        Me.GroupBox1.Controls.Add(Me.txtBillno)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.dtExpanse)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(163, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 280)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtExpDescription
        '
        Me.txtExpDescription.Location = New System.Drawing.Point(138, 120)
        Me.txtExpDescription.Name = "txtExpDescription"
        Me.txtExpDescription.Size = New System.Drawing.Size(188, 52)
        Me.txtExpDescription.TabIndex = 3
        Me.txtExpDescription.Text = ""
        '
        'mtExpType
        '
        Me.mtExpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtExpType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mtExpType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mtExpType.ItemHeight = 19
        Me.mtExpType.Items.AddRange(New Object() {"Mess", "Electricity Bill", "Purchase New Item", "Maintainance", "Security", "Other"})
        Me.mtExpType.Location = New System.Drawing.Point(139, 73)
        Me.mtExpType.Name = "mtExpType"
        Me.mtExpType.Size = New System.Drawing.Size(188, 25)
        Me.mtExpType.TabIndex = 2
        Me.mtExpType.UseSelectable = True
        '
        'txtBillno
        '
        Me.txtBillno.Location = New System.Drawing.Point(138, 223)
        Me.txtBillno.Name = "txtBillno"
        Me.txtBillno.Size = New System.Drawing.Size(189, 21)
        Me.txtBillno.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(138, 188)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(189, 21)
        Me.txtAmount.TabIndex = 4
        '
        'dtExpanse
        '
        Me.dtExpanse.CustomFormat = "MM-dd-yyyy"
        Me.dtExpanse.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpanse.Location = New System.Drawing.Point(139, 38)
        Me.dtExpanse.Name = "dtExpanse"
        Me.dtExpanse.Size = New System.Drawing.Size(187, 21)
        Me.dtExpanse.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bill Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MetroTile1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.MetroLabel1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.btnClick)
        Me.TabPage2.Controls.Add(Me.dtPickerEnd)
        Me.TabPage2.Controls.Add(Me.dtPickerStart)
        Me.TabPage2.Controls.Add(Me.MetroComboBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(991, 448)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Expanse View Category Wise"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(416, 206)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(107, 59)
        Me.MetroTile1.TabIndex = 50
        Me.MetroTile1.Text = "MetroTile1"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseSelectable = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(276, 218)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 49
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.MetroLabel1.Location = New System.Drawing.Point(252, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(235, 25)
        Me.MetroLabel1.TabIndex = 48
        Me.MetroLabel1.Text = "Category Wise Expanse View "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(374, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "From"
        '
        'btnClick
        '
        Me.btnClick.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClick.Location = New System.Drawing.Point(276, 154)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(133, 24)
        Me.btnClick.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnClick.TabIndex = 47
        Me.btnClick.Text = "Click to View "
        Me.btnClick.UseSelectable = True
        '
        'dtPickerEnd
        '
        Me.dtPickerEnd.CustomFormat = "MM-dd-yyyy"
        Me.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerEnd.Location = New System.Drawing.Point(416, 113)
        Me.dtPickerEnd.Name = "dtPickerEnd"
        Me.dtPickerEnd.Size = New System.Drawing.Size(98, 20)
        Me.dtPickerEnd.TabIndex = 44
        '
        'dtPickerStart
        '
        Me.dtPickerStart.CustomFormat = "MM-dd-yyyy"
        Me.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerStart.Location = New System.Drawing.Point(238, 114)
        Me.dtPickerStart.Name = "dtPickerStart"
        Me.dtPickerStart.Size = New System.Drawing.Size(98, 20)
        Me.dtPickerStart.TabIndex = 43
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MetroComboBox1.ItemHeight = 19
        Me.MetroComboBox1.Items.AddRange(New Object() {"Mess", "Electricity Bill", "Purchase New Item", "Maintainance", "Security", "Other"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(276, 72)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(188, 25)
        Me.MetroComboBox1.TabIndex = 5
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Category"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MetroLabel2)
        Me.TabPage3.Controls.Add(Me.MetroGrid1)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.MetroTile2)
        Me.TabPage3.Controls.Add(Me.MetroButton1)
        Me.TabPage3.Controls.Add(Me.dtp1Monthly)
        Me.TabPage3.Controls.Add(Me.dtp2Monthly)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(991, 448)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Monthly Expanse View"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(274, 186)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel2.TabIndex = 54
        Me.MetroLabel2.Text = "MetroLabel2"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle17
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(77, 186)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(397, 64)
        Me.MetroGrid1.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "From"
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(237, 13)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(186, 59)
        Me.MetroTile2.TabIndex = 51
        Me.MetroTile2.Text = "Montly Expanse View"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.Location = New System.Drawing.Point(252, 138)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(133, 24)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton1.TabIndex = 52
        Me.MetroButton1.Text = "Click to View "
        Me.MetroButton1.UseSelectable = True
        '
        'dtp1Monthly
        '
        Me.dtp1Monthly.CustomFormat = "MM-dd-yyyy"
        Me.dtp1Monthly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1Monthly.Location = New System.Drawing.Point(214, 98)
        Me.dtp1Monthly.Name = "dtp1Monthly"
        Me.dtp1Monthly.Size = New System.Drawing.Size(98, 20)
        Me.dtp1Monthly.TabIndex = 48
        '
        'dtp2Monthly
        '
        Me.dtp2Monthly.CustomFormat = "MM-dd-yyyy"
        Me.dtp2Monthly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2Monthly.Location = New System.Drawing.Point(392, 97)
        Me.dtp2Monthly.Name = "dtp2Monthly"
        Me.dtp2Monthly.Size = New System.Drawing.Size(98, 20)
        Me.dtp2Monthly.TabIndex = 49
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.MetroLabel4)
        Me.TabPage4.Controls.Add(Me.MetroLabel3)
        Me.TabPage4.Controls.Add(Me.ReportViewer1)
        Me.TabPage4.Controls.Add(Me.TxtYear)
        Me.TabPage4.Controls.Add(Me.cboMonth)
        Me.TabPage4.Controls.Add(Me.BtnViewReport)
        Me.TabPage4.Controls.Add(Me.MetroComboBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(991, 448)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Expanse Report"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.MetroComboBox2.Location = New System.Drawing.Point(157, 29)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(108, 29)
        Me.MetroComboBox2.TabIndex = 8
        Me.MetroComboBox2.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(298, 29)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Year"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(104, 31)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Month"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(87, 111)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 331)
        Me.ReportViewer1.TabIndex = 4
        '
        'TxtYear
        '
        '
        '
        '
        Me.TxtYear.CustomButton.Image = Nothing
        Me.TxtYear.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.TxtYear.CustomButton.Name = ""
        Me.TxtYear.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.TxtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtYear.CustomButton.TabIndex = 1
        Me.TxtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtYear.CustomButton.UseSelectable = True
        Me.TxtYear.CustomButton.Visible = False
        Me.TxtYear.Lines = New String(-1) {}
        Me.TxtYear.Location = New System.Drawing.Point(351, 29)
        Me.TxtYear.MaxLength = 32767
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtYear.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtYear.SelectedText = ""
        Me.TxtYear.SelectionLength = 0
        Me.TxtYear.SelectionStart = 0
        Me.TxtYear.Size = New System.Drawing.Size(90, 21)
        Me.TxtYear.TabIndex = 3
        Me.TxtYear.UseSelectable = True
        Me.TxtYear.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtYear.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.ItemHeight = 23
        Me.cboMonth.Items.AddRange(New Object() {"JANUARY", "FEBURARY", "MARCH", "APRIL", "MAY", "JUN", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cboMonth.Location = New System.Drawing.Point(157, 29)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(108, 29)
        Me.cboMonth.TabIndex = 1
        Me.cboMonth.UseSelectable = True
        '
        'BtnViewReport
        '
        Me.BtnViewReport.Location = New System.Drawing.Point(491, 21)
        Me.BtnViewReport.Name = "BtnViewReport"
        Me.BtnViewReport.Size = New System.Drawing.Size(137, 29)
        Me.BtnViewReport.TabIndex = 0
        Me.BtnViewReport.Text = "MetroButton2"
        Me.BtnViewReport.UseSelectable = True
        '
        'HostelExpanse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 523)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HostelExpanse"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents mtExpType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtBillno As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtExpanse As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClick As MetroFramework.Controls.MetroButton
    Friend WithEvents dtPickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtp1Monthly As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2Monthly As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TxtYear As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboMonth As MetroFramework.Controls.MetroComboBox
    Friend WithEvents BtnViewReport As MetroFramework.Controls.MetroButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
End Class
