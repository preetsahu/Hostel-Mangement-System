Public Class Hostel_Management_System
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Close()
            LoginForm.SetDesktopLocation(500, 200)
            LoginForm.Visible = False
            LoginForm.ShowDialog()
        End If
    End Sub
    Private Sub AllotmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllotmentToolStripMenuItem.Click
        'If loginAuthetication = 0 Then
        '   
        'LoginForm.Show()
        'ElseIf loginAuthetication = 1 Then
        '   
        StudentRoomAllotment.MdiParent = Me
        '    
        StudentRoomAllotment.Dock = DockStyle.None
        '    
        StudentRoomAllotment.Show()
        'End If

    End Sub
    Private Sub VisitorsDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RoomDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Room_Detail.Show()
        Room_Detail.MdiParent = Me
        Room_Detail.Dock = DockStyle.None
    End Sub

    Private Sub StudentDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailToolStripMenuItem.Click
        ViewStudentDetails.MdiParent = Me
        ViewStudentDetails.Dock = DockStyle.None
        ViewStudentDetails.Show()
    End Sub
    Private Sub FeesPaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesPaymentToolStripMenuItem1.Click
        Feepayment.Show()
        Feepayment.MdiParent = Me
        Feepayment.Dock = DockStyle.None
    End Sub
    Private Sub mainfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        For Each frm In Me.Controls.OfType(Of Form)()
            frm.Close()
            frm.Dock = DockStyle.None
        Next
    End Sub

    Private Sub EmployeeAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeAttendanceToolStripMenuItem.Click
        EmpAttendancenew.MdiParent = Me
        EmpAttendancenew.Dock = DockStyle.Fill
        EmpAttendancenew.Show()
    End Sub

    Private Sub MeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EmpAttendancenew.MdiParent = Me
        EmpAttendancenew.Dock = DockStyle.None
        EmpAttendancenew.Show()
    End Sub
    Private Sub StudentDepatcherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDepatcherToolStripMenuItem.Click
        StudentDeparture.MdiParent = Me
        StudentDeparture.Dock = DockStyle.None
        StudentDeparture.Show()
    End Sub

    Private Sub VisitingDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmployeeEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeEntryToolStripMenuItem.Click
        Employee.MdiParent = Me
        Employee.Show()
        Employee.Dock = DockStyle.Fill
    End Sub

    Private Sub ViewEmployeeDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeDetailToolStripMenuItem.Click
        EmployeeDetailsView.Show()
        EmployeeDetailsView.MdiParent = Me
        EmployeeDetailsView.Dock = DockStyle.Fill
    End Sub

    Private Sub GoToDCIndiainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DCindia.Show()
    End Sub
    Private Sub RoomDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomDetailToolStripMenuItem.Click
        Room_Detail.MdiParent = Me
        Room_Detail.Dock = DockStyle.None
        Room_Detail.Show()
    End Sub

    Private Sub HostelExpansesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HostelExpanse.Show()
        HostelExpanse.Dock = DockStyle.None
        HostelExpanse.MdiParent = Me
    End Sub

    Private Sub StudentAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAttendanceToolStripMenuItem.Click
        StudemtCheckInOutEntry.Show()
        StudemtCheckInOutEntry.Dock = DockStyle.Fill
        StudemtCheckInOutEntry.MdiParent = Me
    End Sub

    Private Sub EmployeePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeePaymentToolStripMenuItem.Click
        Employee_Payment.Show()
        Employee_Payment.MdiParent = Me
        Employee_Payment.Dock = DockStyle.None

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click

    End Sub

    Private Sub ViewRoomStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRoomStatusToolStripMenuItem.Click
        RoomView.Show()
        RoomView.MdiParent = Me
        RoomView.Dock = DockStyle.Fill
    End Sub

    Private Sub BusDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusDetailToolStripMenuItem.Click
        BusDetails.Show()
        BusDetails.MdiParent = Me
        BusDetails.Dock = DockStyle.Fill
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangePassword.Show()
        ChangePassword.MdiParent = Me
        ChangePassword.Dock = DockStyle.None
    End Sub
    ' ---------------------------------------- create backup ----------------------------------------------------

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Back_up.Show()
        Back_up.MdiParent = Me

    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
        ChangePassword.Show()
        ChangePassword.MdiParent = Me
        ChangePassword.Dock = DockStyle.None
    End Sub

    Private Sub VisitorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitorsToolStripMenuItem.Click

    End Sub

    Private Sub VisitorsEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitorsEntryToolStripMenuItem.Click
        VisitorEntry.Show()
        VisitorEntry.MdiParent = Me
        VisitorEntry.Dock = DockStyle.Fill
    End Sub

    Private Sub VisitingDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitingDetailsToolStripMenuItem1.Click
        VisitingDetail.MdiParent = Me
        VisitingDetail.Dock = DockStyle.Fill
        VisitingDetail.Show()
    End Sub

    Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DCindia.Show()
        DCindia.MdiParent = Me
        DCindia.Dock = DockStyle.Fill
    End Sub

    Private Sub ToolStripStatusLabel3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click

    End Sub

    Private Sub MetroLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink1.Click
        DCindia.Show()
        DCindia.MdiParent = Me
        DCindia.Dock = DockStyle.Fill
    End Sub

    Private Sub ExpansesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpansesToolStripMenuItem.Click
        HostelExpanse.Show()
        HostelExpanse.MdiParent = Me
        HostelExpanse.Dock = DockStyle.Fill
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub BusAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusAttendanceToolStripMenuItem.Click
        StudentBusWiseAttendance.Show()
        StudentBusWiseAttendance.MdiParent = Me
        StudentBusWiseAttendance.Dock = DockStyle.Fill
    End Sub

    Private Sub ReportsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        ReportCollection.Show()
        ReportCollection.MdiParent = Me
        ReportCollection.Dock = DockStyle.Fill
    End Sub

    Private Sub EmployeeRegionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRegionToolStripMenuItem.Click
        DeleteEmployeeDetails.Show()
        DeleteEmployeeDetails.MdiParent = Me
        DeleteEmployeeDetails.Dock = DockStyle.Fill
    End Sub

    Private Sub StudentCurrentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentCurrentStatusToolStripMenuItem.Click
        StudentCurrentStatus.Show()
        StudentCurrentStatus.MdiParent = Me
        StudentCurrentStatus.Dock = DockStyle.Fill
    End Sub
End Class
