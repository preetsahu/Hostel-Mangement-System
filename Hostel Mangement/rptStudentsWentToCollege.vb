Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class rptStudentsWentToCollege
    Dim query As String
    Private Sub rptStudentsWentToCollege_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            CboClassStudentWent.DataSource = dt
            CboClassStudentWent.DisplayMember = "COURSE_NAME"
            '''''''
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYearStudentWent.Text = ""
    End Sub

    Private Sub CboClassStudentWent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboClassStudentWent.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + CboClassStudentWent.Text + "'"
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

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            query = "SELECT RoomAllotment.S_ID, RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, RoomAllotment.ROOM_ID, RoomAllotment.BED_ID, RoomAllotment.BUS_ID, RoomAllotment.ROUTE_ID, DailyAttendance.Check_Mode, DailyAttendance.Attendance_date FROM (DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Attendance_date=? and RoomAllotment.CLASS=? AND RoomAllotment.COURSE_YEAR=? AND DailyAttendance.Check_Mode='Check out'"
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
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
End Class