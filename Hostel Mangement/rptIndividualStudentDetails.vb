Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Public Class rptIndividualStudentDetails
    Dim query As String
    Private Sub rptIndividualStudentDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            Cboclass.DataSource = dt
            Cboclass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYear.Text = ""
        cboSelected.Text = ""
    End Sub
    Private Sub viewStudent()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where CLASS like '" + Cboclass.Text + "' and COURSE_YEAR like '" + cboYear.Text + "' and ROOM_ID <> '' AND BED_ID <> '' "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboSelected.DataSource = dt
            cboSelected.DisplayMember = "NAME"
            adptr.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT  S_ID, DOB, NAME, CONTACT, PHOTO, FATHERS_NAME, FATHERS_CONTACT, MOTHERS_NAME, MOTHERS_CONTACT, PERMANENT_ADDRESS, LOCAL_GAURDIAN, LOCAL_GAURDIAN_CONTACT, LOCAL_GAURDIAN_ADDRESS, CLASS, COURSE_YEAR, ROOM_ID, BED_ID, BUS_ID, ROUTE_ID, REGISTRATION_DATE FROM  RoomAllotment where CLASS='" + Cboclass.Text + "' AND COURSE_YEAR='" + cboYear.Text + "' and NAME=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            'adptr.SelectCommand.Parameters.AddWithValue("@cls", Cboclass.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@sid", cboSelected.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet6 As New DataSet
            adptr.Fill(DataSet6, "DataSet6")
            Me.ReportViewer1.LocalReport.ReportPath = "ReportViewerStudentIndividualDetails.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet6", DataSet6.Tables("DataSet6")))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Cboclass_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cboclass.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + Cboclass.Text + "'"
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
        cboSelected.Text = ""
        cboYear.Text = ""
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        cboSelected.Text = ""
        viewStudent()
    End Sub
End Class