Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class ReportCollection
    Dim query As String
    Private Sub ReportCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboClass.DataSource = dt
            cboClass.DisplayMember = "COURSE_NAME"
            cboClassWise.DataSource = dt
            cboClassWise.DisplayMember = "COURSE_NAME"
            '''''
            CboClassStudentWent.DataSource = dt
            CboClassStudentWent.DisplayMember = "COURSE_NAME"
            '''''''
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYear.Text = ""
        '-'
        cboYearStudentWent.Text = ""
        ''''
        Try
            con.Open()
            query = "select DISTINCT[WORK_AS] from EmployeeDetails;"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboWorkAs.DataSource = dt
            cboWorkAs.DisplayMember = "WORK_AS"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Me.ReportViewerEmpAttendance.RefreshReport()

        Me.rptViewerWentStudentList.RefreshReport()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClass.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClass.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboYear.DataSource = dt
            cboYear.DisplayMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYear.Text = ""
    End Sub
    Private Sub cboClassWise_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClassWise.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClassWise.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboyearWisestudent.DataSource = dt
            cboYear.DisplayMember = "COURSE_SPECIFICATION"
            cboyearWisestudent.ValueMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboyearWisestudent.Text = ""
    End Sub
    '''''''''''''''''''''''''''''''''''' report viewer1 codes '''''''''''''''''''''''''''''''''''
    Private Sub btnReportView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportView.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim query As String = "SELECT  last(FeePayment.PAYED_AMOUNT) as PAYED_AMOUNT, last(FeePayment.PAYMENT_DATE) as PAYMENT_DATE, last(FeePayment.REMAINING_AMOUNT) as REMAINING_AMOUNT, last(RoomAllotment.S_ID) as S_ID, last(RoomAllotment.NAME) AS NAME, last(RoomAllotment.CONTACT) as Contact, last(RoomAllotment.CLASS)  as Class, last(RoomAllotment.COURSE_YEAR )  as Course_Year FROM  (FeePayment INNER JOIN   RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID) GROUP BY Name HAVING last(FeePayment.REMAINING_AMOUNT)<>0 and last(RoomAllotment.ROOM_ID)<> '' and last(RoomAllotment.CLASS)=? and  last(RoomAllotment.COURSE_YEAR )=?;"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@cls", cboClass.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@year", cboYear.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet1 As New DataSet
            adptr.Fill(DataSet1, "DataSet1")
            Me.ReportViewer1.LocalReport.ReportPath = "ReportViewerDueFeesStudentList.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''' report viewer2 codes '''''''''''''''''''''''''''''''''''
    Private Sub btnViewClassWiseStudnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewClassWiseStudnet.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim query As String = "SELECT S_ID, NAME, CONTACT, FATHERS_NAME, FATHERS_CONTACT, CLASS, COURSE_YEAR, ROOM_ID, BED_ID, BUS_ID, ROUTE_ID, REGISTRATION_DATE FROM RoomAllotment where CLASS=? AND COURSE_YEAR=? AND ROOM_ID <> ''"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@sid", cboClassWise.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@pdate", cboyearWisestudent.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet2 As New DataSet
            adptr.Fill(DataSet2, "DataSet2")
            Me.ReportViewer2.LocalReport.ReportPath = "ReportViewerClasswiseStudentList.rdlc"
            Me.ReportViewer2.LocalReport.DataSources.Clear()
            Me.ReportViewer2.LocalReport.DataSources.Add(New ReportDataSource("DataSet2", DataSet2.Tables("DataSet2")))
            Me.ReportViewer2.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboWorkAs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkAs.SelectedIndexChanged
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        '   cboEmpID.Text = ""
        query = "select * from EmployeeDetails where WORK_AS like '" + cboWorkAs.Text + "'"
        Try
            CON.Open()
            Dim adptr As New OleDbDataAdapter(query, CON)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboEmpName.DataSource = dt
            cboEmpName.DisplayMember = "EMPLOYEE_NAME"
            cboEmpID.DataSource = dt
            cboEmpID.DisplayMember = "EMPLOYEE_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CON.Close()
        End Try
    End Sub

    Private Sub btnViewEmpDateWiseAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEmpDateWiseAttendance.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try

            con.Open()
            Dim query As String = "SELECT EmployeeDetails.EMPLOYEE_NAME, EmployeeDetails.EMPLOYEE_ID, EmployeeDetails.EMPLOYEE_CONTACT, EmployeeDetails.WORK_AS, EmployeeDetails.WORK_SHIFT, Eattendance.Available, Eattendance.A_DATE, Eattendance.REMARKS FROM (Eattendance INNER JOIN EmployeeDetails ON Eattendance.EMPLOYEE_ID = EmployeeDetails.EMPLOYEE_ID) WHERE EmployeeDetails.EMPLOYEE_ID=? And Eattendance.A_DATE Between ? And ?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@eid", cboEmpID.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@sdate", dtp1.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@edate", dtp2.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet3 As New DataSet
            adptr.Fill(DataSet3, "DataSet3")
            Me.ReportViewerEmpAttendance.LocalReport.ReportPath = "ReportViewerEmpAttendance.rdlc"
            Me.ReportViewerEmpAttendance.LocalReport.DataSources.Clear()
            Me.ReportViewerEmpAttendance.LocalReport.DataSources.Add(New ReportDataSource("DataSet3", DataSet3.Tables("DataSet3")))
            Me.ReportViewerEmpAttendance.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRemaingView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemaingView.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim query As String = "SELECT  RoomAllotment.NAME, RoomAllotment.S_ID, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, DailyAttendance.Attendance_date, DailyAttendance.Check_Mode FROM (DailyAttendance INNER JOIN   RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Check_Mode='Check in' and DailyAttendance.Attendance_date=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@Cdate", dtp3.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet4 As New DataSet
            adptr.Fill(DataSet4, "DataSet4")
            Me.ReportViewerRemainingStudents.LocalReport.ReportPath = "ReportViewerListOFremaingStudentOnParticularDate.rdlc"
            Me.ReportViewerRemainingStudents.LocalReport.DataSources.Clear()
            Me.ReportViewerRemainingStudents.LocalReport.DataSources.Add(New ReportDataSource("DataSet4", DataSet4.Tables("DataSet4")))
            Me.ReportViewerRemainingStudents.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

   
    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            If MetroRadioButton1.Checked = True Then
                query = "SELECT RoomAllotment.S_ID, RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, RoomAllotment.ROOM_ID, RoomAllotment.BED_ID, RoomAllotment.BUS_ID, RoomAllotment.ROUTE_ID, DailyAttendance.Check_Mode, DailyAttendance.Attendance_date FROM (DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Attendance_date=? and RoomAllotment.CLASS=? AND RoomAllotment.COURSE_YEAR=?  AND RoomAllotment.ROOM_ID <> '' AND DailyAttendance.Check_Mode='Check in'"
                Dim adptr As New OleDbDataAdapter(query, con)
                adptr.SelectCommand.Parameters.AddWithValue("cdte", DateTimePicker1.Text)
                adptr.SelectCommand.Parameters.AddWithValue("cls", CboClassStudentWent.Text)
                adptr.SelectCommand.Parameters.AddWithValue("year", cboYearStudentWent.Text)
                Dim DataSet5 As New DataSet
                adptr.Fill(DataSet5, "DataSet5")
                Me.rptViewerWentStudentList.LocalReport.ReportPath = "RportViewerListOFStudentsWentToCollege.rdlc"
                Me.rptViewerWentStudentList.LocalReport.DataSources.Clear()
                Me.rptViewerWentStudentList.LocalReport.DataSources.Add(New ReportDataSource("DataSet5", DataSet5.Tables("DataSet5")))
                Me.rptViewerWentStudentList.RefreshReport()
            ElseIf MetroRadioButton2.Checked = True Then
                query = " SELECT last(RoomAllotment.S_ID) as S_ID , last(RoomAllotment.NAME) as NAME, last(RoomAllotment.CONTACT) as CONTACT, last(RoomAllotment.CLASS) as CLASS, last(RoomAllotment.COURSE_YEAR) as COURSE_YEAR, last(RoomAllotment.ROOM_ID) as ROOM_ID, last(RoomAllotment.BED_ID) as BED_ID, last(RoomAllotment.BUS_ID) as BUS_ID, last(RoomAllotment.ROUTE_ID) as ROUTE_ID, last(DailyAttendance.Check_Mode) as Check_Mode, last(DailyAttendance.Attendance_date) as Attendance_date FROM DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID WHERE (((DailyAttendance.Attendance_date)=?) AND ((RoomAllotment.CLASS)=?) AND ((RoomAllotment.COURSE_YEAR)=?) AND ((DailyAttendance.Check_Mode)='Check out'));"
                'query = "SELECT RoomAllotment.S_ID, RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, RoomAllotment.ROOM_ID, RoomAllotment.BED_ID, RoomAllotment.BUS_ID, RoomAllotment.ROUTE_ID, DailyAttendance.Check_Mode, DailyAttendance.Attendance_date FROM (DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Attendance_date=? and RoomAllotment.CLASS=? AND RoomAllotment.COURSE_YEAR=? AND RoomAllotment.ROOM_ID <> '' AND DailyAttendance.Check_Mode='Check out'"
                Dim adptr As New OleDbDataAdapter(query, con)
                adptr.SelectCommand.Parameters.AddWithValue("cdte", DateTimePicker1.Text)
                adptr.SelectCommand.Parameters.AddWithValue("cls", CboClassStudentWent.Text)
                adptr.SelectCommand.Parameters.AddWithValue("year", cboYearStudentWent.Text)
                Dim DataSet5 As New DataSet
                adptr.Fill(DataSet5, "DataSet5")
                Me.rptViewerWentStudentList.LocalReport.ReportPath = "RportViewerListOFStudentsWentToCollege.rdlc"
                Me.rptViewerWentStudentList.LocalReport.DataSources.Clear()
                Me.rptViewerWentStudentList.LocalReport.DataSources.Add(New ReportDataSource("DataSet5", DataSet5.Tables("DataSet5")))
                Me.rptViewerWentStudentList.RefreshReport()
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub CboClassStudentWent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboClassStudentWent.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClassWise.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboYearStudentWent.DataSource = dt
            cboYearStudentWent.DisplayMember = "COURSE_SPECIFICATION"
            cboYearStudentWent.ValueMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MetroRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroRadioButton1.CheckedChanged

    End Sub

    Private Sub MetroRadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroRadioButton2.CheckedChanged

    End Sub
End Class