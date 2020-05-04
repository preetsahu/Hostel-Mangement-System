Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class myreport
    Public sid As Integer
    Public paydate As Date
 

    'Dim con As New OleDbConnection
    '    con = connectTOhms()
    '    Try
    '        con.Open()
    ''    Dim query As String = "SELECT RoomAllotment.NAME, RoomAllotment.CONTACT, FeePayment.PaymentType, FeePayment.PAYED_AMOUNT, FeePayment.PAYMENT_DATE, FeePayment.REMAINING_AMOUNT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR FROM (FeePayment INNER JOIN  RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID) Where RoomAllotment.S_ID=? and FeePayment.PAYMENT_DATE=? "
    'Dim query As String = "SELECT RoomAllotment.NAME, RoomAllotment.S_ID, RoomAllotment.CONTACT, RoomAllotment.COURSE_YEAR, RoomAllotment.CLASS, FeePayment.PaymentType, FeePayment.Check_Number, FeePayment.PAYMENT_DATE, FeePayment.PAYED_AMOUNT, FeePayment.REMAINING_AMOUNT FROM  (FeePayment INNER JOIN  RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID) Where RoomAllotment.S_ID=? and FeePayment.PAYMENT_DATE=?"
    'Dim adptr As New OleDbDataAdapter(query, con)
    '        adptr.SelectCommand.Parameters.AddWithValue("@sid", sid)
    '        adptr.SelectCommand.Parameters.AddWithValue("@pdate", paydate)
    'Dim Dataset1 As New DataSet
    '        adptr.Fill(Dataset1, "Dataset1")
    '        Me.ReportViewer1.LocalReport.ReportPath = "report1.rdlc"
    '        Me.ReportViewer1.LocalReport.DataSources.Clear()
    '        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Dataset1", Dataset1.Tables("Dataset1")))
    '        Me.ReportViewer1.RefreshReport()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try

    Private Sub myreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsStudentBillpayment.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.dsStudentBillpayment.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class