Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class rptViewStudenetAttendace
    Dim query As String
    Private Sub rptViewStudenetAttendace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetStudentAttendance.DataTable1' table. You can move, or remove it, as needed.
        ' Me.DataTable1TableAdapter.Fill(Me.DataSetStudentAttendance.DataTable1)
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT StudentAttendance.S_ID,RoomAllotment.NAME,RoomAllotment.CONTACT,StudentAttendance.DATE_TIME,RoomAllotment.COURSE_YEAR,RoomAllotment.CLASS FROM  (RoomAllotment INNER JOIN  StudentAttendance ON RoomAllotment.S_ID = StudentAttendance.S_ID)"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            adptr.Fill(ds, "DataSetStudentAttendance")
            Me.ReportViewer1.LocalReport.ReportPath = "Report2.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetStudentAttendance", ds.Tables("DataSetStudentAttendance")))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class