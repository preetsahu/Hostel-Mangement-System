Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class StudenPayementReport

    Private Sub StudenPayementReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim query As String = "SELECT RoomAllotment.NAME, RoomAllotment.CONTACT, FeePayment.PaymentType, FeePayment.PAYED_AMOUNT, FeePayment.PAYMENT_DATE, FeePayment.REMAINING_AMOUNT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR FROM (FeePayment INNER JOIN  RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID)"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim DataSet As New DataSet
            adptr.Fill(DataSet1, "DataSet")
            Me.ReportViewer1.LocalReport.ReportPath = "C:\hms\hms.accdb"
            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        
    End Sub
End Class