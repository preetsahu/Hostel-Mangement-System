Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class StudentBusWiseAttendance
    Dim query As String
    Private Sub StudentDailyAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        Dim con As New OleDb.OleDbConnection
        con = connectTOhms()
        Try
            query = "select * from BusDetail"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboBusID.DataSource = dt
            cboBusID.DisplayMember = "BUS_ID"
            cboBusID.ValueMember = "BUS_ID"
            ' cboRoute.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            CboClassStudentWent.DataSource = dt
            CboClassStudentWent.DisplayMember = "COURSE_NAME"
            CboClassStudentWent.ValueMember = "COURSE_NAME"
            '''''''
            cboClassRemainStudent.DataSource = dt
            cboClassRemainStudent.DisplayMember = "COURSE_NAME"
            cboClassRemainStudent.ValueMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYearStudentWent.Text = ""
        cboYearRemainStudent.Text = ""
    End Sub
    Private Sub AddElement()
        Dim i As Integer
        Dim line As Integer = 1
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT * FROM RoomAllotment where BUS_ID='" + cboBusID.SelectedValue.ToString + "' and ROOM_ID <> '';"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            While reader.Read
                Dim lblStuName As New Label
                lblStuName.Name = reader(0).ToString
                lblStuName.AutoSize = New AutoSizeMode()
                lblStuName.Location = New Point(50, line * 20)                    'creating dynamic label
                lblStuName.Text = reader(2).ToString
                GroupBox1.Controls.Add(lblStuName)

                Dim chkbox As New CheckBox
                chkbox.Name = reader(0).ToString                                    '"checkbox" & i
                chkbox.Size = New Size(150, 20)                                  'creating dynamic checkbox
                chkbox.Location = New Point(200, line * 20)
                chkbox.Checked = False

                GroupBox1.Controls.Add(chkbox)
                i = i + 1
                line = line + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            For Each mycheck As CheckBox In GroupBox1.Controls.OfType(Of CheckBox)()
                If mycheck.Checked = True Then
                    Dim query As String = "insert into DailyAttendance (S_ID,BUS_ID,Check_Mode,Attendance_date) values (?,?,?,?)"
                    Dim CMD As New OleDbCommand(query, con)
                    CMD.Parameters.AddWithValue("@sid", Val(mycheck.Name))
                    CMD.Parameters.AddWithValue("@busid", cboBusID.Text)
                    CMD.Parameters.AddWithValue("@avail", cboCheckMode.Text)
                    CMD.Parameters.AddWithValue("@Date", DateTimePicker1.Text)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    MessageBox.Show(mycheck.Name + "  " + cboCheckMode.Text)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub controlClear()
        Try
            For Each chk As CheckBox In GroupBox1.Controls.OfType(Of CheckBox)()
                chk.Checked = False
                chk.Visible = False
            Next
            For Each lbl As Label In GroupBox1.Controls.OfType(Of Label)()
                lbl.Visible = False
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        controlClear()
        AddElement()
    End Sub
    Private Sub CboClassStudentWent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboClassStudentWent.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + CboClassStudentWent.SelectedValue + "'"
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

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWent.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            query = "SELECT RoomAllotment.S_ID, RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, RoomAllotment.ROOM_ID, RoomAllotment.BED_ID, RoomAllotment.BUS_ID, RoomAllotment.ROUTE_ID, DailyAttendance.Check_Mode, DailyAttendance.Attendance_date FROM (DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Attendance_date=? and RoomAllotment.CLASS=? AND RoomAllotment.COURSE_YEAR=? AND DailyAttendance.Check_Mode='Check out' AND RoomAllotment.ROOM_ID <> '';"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("cdte", DateTimePicker2.Text)
            adptr.SelectCommand.Parameters.AddWithValue("cls", CboClassStudentWent.SelectedValue)
            adptr.SelectCommand.Parameters.AddWithValue("year", cboYearStudentWent.SelectedValue)
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

    Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton4.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            query = "SELECT RoomAllotment.S_ID, RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, RoomAllotment.ROOM_ID, RoomAllotment.BED_ID, RoomAllotment.BUS_ID, RoomAllotment.ROUTE_ID, DailyAttendance.Check_Mode, DailyAttendance.Attendance_date FROM (DailyAttendance INNER JOIN RoomAllotment ON DailyAttendance.S_ID = RoomAllotment.S_ID) where DailyAttendance.Attendance_date=? and RoomAllotment.CLASS=? AND RoomAllotment.COURSE_YEAR=? AND DailyAttendance.Check_Mode='Check in' AND RoomAllotment.ROOM_ID <> '';"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("cdte", DateTimePicker3.Text)
            adptr.SelectCommand.Parameters.AddWithValue("cls", cboClassRemainStudent.Text)
            adptr.SelectCommand.Parameters.AddWithValue("year", cboYearRemainStudent.Text)
            Dim DataSet5 As New DataSet
            adptr.Fill(DataSet5, "DataSet5")
            Me.btnRemain.LocalReport.ReportPath = "RportViewerListOFStudentsWentToCollege.rdlc"
            Me.btnRemain.LocalReport.DataSources.Clear()
            Me.btnRemain.LocalReport.DataSources.Add(New ReportDataSource("DataSet5", DataSet5.Tables("DataSet5")))
            Me.btnRemain.RefreshReport()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboClassRemainStudent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClassRemainStudent.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClassRemainStudent.SelectedValue + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboYearRemainStudent.DataSource = dt
            cboYearRemainStudent.DisplayMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class