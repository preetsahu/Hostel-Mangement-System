Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Public Class rptStudentBillPayment
    Public paydate As Date
    Public sid As Integer

    Private Sub rptStudentBillPayment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            ' Dim query As String = "SELECT  RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, FeePayment.PAYED_AMOUNT, FeePayment.PAYMENT_DATE, FeePayment.Payment_Type, FeePayment.REMAINING_AMOUNT, FeePayment.Check_Number FROM   (FeePayment INNER JOIN RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID)"
            Dim query As String = "SELECT RoomAllotment.NAME, RoomAllotment.S_ID, RoomAllotment.CONTACT, RoomAllotment.COURSE_YEAR, RoomAllotment.CLASS, FeePayment.Payment_Type, FeePayment.PAYED_AMOUNT, Feepayment.PAYMENT_DATE, Feepayment.REMAINING_AMOUNT, Feepayment.Check_Number FROM (FeePayment INNER JOIN RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID) WHERE RoomAllotment.S_ID=? AND FeePayment.PAYMENT_DATE=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@sid", sid)
            adptr.SelectCommand.Parameters.AddWithValue("@pdate", paydate)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet1 As New DataSet
            adptr.Fill(DataSet1, "DataSet1")
            Me.ReportViewer1.LocalReport.ReportPath = "ReportViewerStudentRecieptnew.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class