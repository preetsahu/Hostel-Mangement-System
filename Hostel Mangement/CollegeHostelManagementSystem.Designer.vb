<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hostel_Management_System
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hostel_Management_System))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllotmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDepatcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeRegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesPaymentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorsEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitingDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRoomStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpansesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentCurrentStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblLoginAS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsrName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.FeesPaymentToolStripMenuItem, Me.VisitorsToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.ExpansesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.StudentCurrentStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllotmentToolStripMenuItem, Me.StudentDepatcherToolStripMenuItem, Me.StudentDetailToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.MasterToolStripMenuItem.Text = "Student"
        '
        'AllotmentToolStripMenuItem
        '
        Me.AllotmentToolStripMenuItem.Name = "AllotmentToolStripMenuItem"
        Me.AllotmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AllotmentToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.AllotmentToolStripMenuItem.Text = "Student Room Allotment"
        '
        'StudentDepatcherToolStripMenuItem
        '
        Me.StudentDepatcherToolStripMenuItem.Name = "StudentDepatcherToolStripMenuItem"
        Me.StudentDepatcherToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.StudentDepatcherToolStripMenuItem.Text = "Student Depatcher"
        '
        'StudentDetailToolStripMenuItem
        '
        Me.StudentDetailToolStripMenuItem.Name = "StudentDetailToolStripMenuItem"
        Me.StudentDetailToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StudentDetailToolStripMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.StudentDetailToolStripMenuItem.Text = "View Update/Student Detail"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeEntryToolStripMenuItem, Me.ViewEmployeeDetailToolStripMenuItem, Me.EmployeeRegionToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EmployeeEntryToolStripMenuItem
        '
        Me.EmployeeEntryToolStripMenuItem.Name = "EmployeeEntryToolStripMenuItem"
        Me.EmployeeEntryToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.EmployeeEntryToolStripMenuItem.Text = "Employee Entry"
        '
        'ViewEmployeeDetailToolStripMenuItem
        '
        Me.ViewEmployeeDetailToolStripMenuItem.Name = "ViewEmployeeDetailToolStripMenuItem"
        Me.ViewEmployeeDetailToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.ViewEmployeeDetailToolStripMenuItem.Text = "View/update Employee Detail"
        '
        'EmployeeRegionToolStripMenuItem
        '
        Me.EmployeeRegionToolStripMenuItem.Name = "EmployeeRegionToolStripMenuItem"
        Me.EmployeeRegionToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.EmployeeRegionToolStripMenuItem.Text = "Employee Region"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentAttendanceToolStripMenuItem, Me.EmployeeAttendanceToolStripMenuItem, Me.BusAttendanceToolStripMenuItem})
        Me.AttendanceToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'StudentAttendanceToolStripMenuItem
        '
        Me.StudentAttendanceToolStripMenuItem.Name = "StudentAttendanceToolStripMenuItem"
        Me.StudentAttendanceToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.StudentAttendanceToolStripMenuItem.Text = "Student Check IN/OUT Entry"
        '
        'EmployeeAttendanceToolStripMenuItem
        '
        Me.EmployeeAttendanceToolStripMenuItem.Name = "EmployeeAttendanceToolStripMenuItem"
        Me.EmployeeAttendanceToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.EmployeeAttendanceToolStripMenuItem.Text = "Employee Daily Attendance"
        '
        'BusAttendanceToolStripMenuItem
        '
        Me.BusAttendanceToolStripMenuItem.Name = "BusAttendanceToolStripMenuItem"
        Me.BusAttendanceToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.BusAttendanceToolStripMenuItem.Text = "Student BusWise Attendance"
        '
        'FeesPaymentToolStripMenuItem
        '
        Me.FeesPaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeesPaymentToolStripMenuItem1, Me.EmployeePaymentToolStripMenuItem})
        Me.FeesPaymentToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesPaymentToolStripMenuItem.Name = "FeesPaymentToolStripMenuItem"
        Me.FeesPaymentToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.FeesPaymentToolStripMenuItem.Text = "Payment"
        '
        'FeesPaymentToolStripMenuItem1
        '
        Me.FeesPaymentToolStripMenuItem1.Name = "FeesPaymentToolStripMenuItem1"
        Me.FeesPaymentToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.FeesPaymentToolStripMenuItem1.Text = "Student Fees Payment"
        '
        'EmployeePaymentToolStripMenuItem
        '
        Me.EmployeePaymentToolStripMenuItem.Name = "EmployeePaymentToolStripMenuItem"
        Me.EmployeePaymentToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EmployeePaymentToolStripMenuItem.Text = "Employee Payment"
        '
        'VisitorsToolStripMenuItem
        '
        Me.VisitorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitorsEntryToolStripMenuItem, Me.VisitingDetailsToolStripMenuItem1})
        Me.VisitorsToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitorsToolStripMenuItem.Name = "VisitorsToolStripMenuItem"
        Me.VisitorsToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.VisitorsToolStripMenuItem.Text = "Visitors"
        '
        'VisitorsEntryToolStripMenuItem
        '
        Me.VisitorsEntryToolStripMenuItem.Name = "VisitorsEntryToolStripMenuItem"
        Me.VisitorsEntryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.VisitorsEntryToolStripMenuItem.Text = "Visitors Entry"
        '
        'VisitingDetailsToolStripMenuItem1
        '
        Me.VisitingDetailsToolStripMenuItem1.Name = "VisitingDetailsToolStripMenuItem1"
        Me.VisitingDetailsToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.VisitingDetailsToolStripMenuItem1.Text = "Visiting  Details"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomDetailToolStripMenuItem, Me.BusDetailToolStripMenuItem, Me.ViewRoomStatusToolStripMenuItem})
        Me.DetailsToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'RoomDetailToolStripMenuItem
        '
        Me.RoomDetailToolStripMenuItem.Name = "RoomDetailToolStripMenuItem"
        Me.RoomDetailToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.RoomDetailToolStripMenuItem.Text = "Room Specification Update"
        '
        'BusDetailToolStripMenuItem
        '
        Me.BusDetailToolStripMenuItem.Name = "BusDetailToolStripMenuItem"
        Me.BusDetailToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.BusDetailToolStripMenuItem.Text = "Bus Detail"
        '
        'ViewRoomStatusToolStripMenuItem
        '
        Me.ViewRoomStatusToolStripMenuItem.Name = "ViewRoomStatusToolStripMenuItem"
        Me.ViewRoomStatusToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ViewRoomStatusToolStripMenuItem.Text = "View Room Status"
        '
        'ExpansesToolStripMenuItem
        '
        Me.ExpansesToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpansesToolStripMenuItem.Name = "ExpansesToolStripMenuItem"
        Me.ExpansesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExpansesToolStripMenuItem.Text = "Hostel Expanses"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StudentCurrentStatusToolStripMenuItem
        '
        Me.StudentCurrentStatusToolStripMenuItem.Name = "StudentCurrentStatusToolStripMenuItem"
        Me.StudentCurrentStatusToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.StudentCurrentStatusToolStripMenuItem.Text = "Student Current Status"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLoginAS, Me.lblUsrName, Me.lblDate, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1354, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblLoginAS
        '
        Me.lblLoginAS.Name = "lblLoginAS"
        Me.lblLoginAS.Size = New System.Drawing.Size(53, 17)
        Me.lblLoginAS.Text = "Login As"
        '
        'lblUsrName
        '
        Me.lblUsrName.Name = "lblUsrName"
        Me.lblUsrName.Size = New System.Drawing.Size(65, 17)
        Me.lblUsrName.Text = "User Name"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(58, 17)
        Me.lblDate.Text = "DateTime"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(1042, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "Welcome To Disha College"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(1106, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(96, 27)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Create Backup"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(1208, 0)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(96, 27)
        Me.MetroButton2.TabIndex = 7
        Me.MetroButton2.Text = "Log Out"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(990, 0)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(110, 27)
        Me.MetroButton3.TabIndex = 8
        Me.MetroButton3.Text = "Change Password"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(863, 0)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(121, 26)
        Me.MetroLink1.TabIndex = 11
        Me.MetroLink1.Text = "dc.india.in"
        Me.MetroLink1.UseSelectable = True
        '
        'Hostel_Management_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Hostel_Management_System"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Hostel Management System"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllotmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesPaymentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpansesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmployeeDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDepatcherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblLoginAS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ViewRoomStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsrName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents VisitorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorsEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitingDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents BusAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeRegionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentCurrentStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
