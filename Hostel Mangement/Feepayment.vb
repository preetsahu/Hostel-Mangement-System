Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Public Class Feepayment
    Dim query As String
    Private Sub Feepayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        txttotalFees.Text = 50000
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
        txtStudentID.Text = ""
        cboSelected.Text = ""
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If rdoCash.Checked = True Then
            Try
                con.Open()
                query = "insert into FeePayment (S_ID,Payment_Type,Check_Number,PAYED_AMOUNT,PAYMENT_DATE,REMAINING_AMOUNT) values (?,?,?,?,?,?)"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", txtStudentID.Text)
                cmd.Parameters.AddWithValue("?", rdoCash.Text)
                cmd.Parameters.AddWithValue("?", txtCheckNumber.Text)
                cmd.Parameters.AddWithValue("?", txtPayingAmount.Text)
                cmd.Parameters.AddWithValue("?", dtp1.Text)
                cmd.Parameters.AddWithValue("?", txtremaining.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("PAYMENT DONE BY : " + cboSelected.Text)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        ElseIf rdoCheck.Checked = True Then
            Try
                con.Open()
                query = "insert into FeePayment (S_ID,PaymentType,Check_Number,PAYED_AMOUNT,PAYMENT_DATE,REMAINING_AMOUNT) values (?,?,?,?,?,?)"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", txtStudentID.Text)
                cmd.Parameters.AddWithValue("?", rdoCheck.Text)
                cmd.Parameters.AddWithValue("?", txtCheckNumber.Text)
                cmd.Parameters.AddWithValue("?", txtPayingAmount.Text)
                cmd.Parameters.AddWithValue("?", dtp1.Text)
                cmd.Parameters.AddWithValue("?", txtremaining.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("PAYMENT DONE BY : " + cboSelected.Text)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End If

       
        '''''''''''''''''''''''''''''''''''' genrating bill ''''''''''''''''''''''''''''''''''''''''''''
       
    End Sub
    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPayingAmount.Text = ""
    End Sub
    Dim paidamount As Integer
    Dim cal As String
    Private Sub txtpaidamount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpaidamount.TextChanged
        Dim CON As OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select SUM(PAYED_AMOUNT) from FeePayment where S_ID=?"
            Dim cmd As New OleDbCommand(query, CON)
            cmd.Parameters.AddWithValue("?", Val(txtStudentID.Text))
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                paidamount = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            '   MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CON.Close()
        End Try

    End Sub
    Dim querycomplete As String

    Private Sub Cboclass_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cboclass.SelectedIndexChanged
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
        txtStudentID.Text = ""
        cboSelected.Text = ""
        cboYear.Text = ""
        txtPayingAmount.Text = ""
    End Sub
    Dim pa As Integer
    Private Sub cboSelected_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelected.SelectedIndexChanged
        txtpaidamount.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where NAME like '" + cboSelected.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtStudentID.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "select sum(PAYED_AMOUNT) from FeePayment where S_ID=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", Val(txtStudentID.Text))
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                pa = reader(0)
                txtpaidamount.Text = reader(0).ToString
            End While
        Catch ex As Exception
            '  MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        If pa = 0 Then
            txtremaining.Text = txttotalFees.Text
        End If
    End Sub
    Private Sub viewStudent()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboYear.Text + "' and ROOM_ID <> '' AND BED_ID <> '' "
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
    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        viewStudent()
        cboSelected.Text = ""
        txtStudentID.Text = ""
        txtpaidamount.Text = ""
        txtremaining.Text = ""
    End Sub
    Private Sub txtPayingAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayingAmount.TextChanged
        cal = Val(txttotalFees.Text) - Val(txtpaidamount.Text) - Val(txtPayingAmount.Text)
        If cal < 0 Then
            MsgBox("not possible,payment amount exceeds")
            txtPayingAmount.Text = ""
        Else
            txtremaining.Text = cal
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'rptStudentBillPayment.paydate = dtp1.Text
        'rptStudentBillPayment.sid = Val(txtStudentID.Text)
        'rptStudentBillPayment.Show()
        'rptStudentBillPayment.Dock = DockStyle.Fill
        'rptStudentBillPayment.MdiParent = Hostel_Management_System
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            ' Dim query As String = "SELECT  RoomAllotment.NAME, RoomAllotment.CONTACT, RoomAllotment.CLASS, RoomAllotment.COURSE_YEAR, FeePayment.PAYED_AMOUNT, FeePayment.PAYMENT_DATE, FeePayment.Payment_Type, FeePayment.REMAINING_AMOUNT, FeePayment.Check_Number FROM   (FeePayment INNER JOIN RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID)"
            Dim query As String = "SELECT RoomAllotment.NAME, RoomAllotment.S_ID, RoomAllotment.CONTACT, RoomAllotment.COURSE_YEAR, RoomAllotment.CLASS, FeePayment.Payment_Type, FeePayment.PAYED_AMOUNT, Feepayment.PAYMENT_DATE, Feepayment.REMAINING_AMOUNT, Feepayment.Check_Number FROM (FeePayment INNER JOIN RoomAllotment ON FeePayment.S_ID = RoomAllotment.S_ID) WHERE RoomAllotment.S_ID=? AND FeePayment.PAYMENT_DATE=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@sid", Val(txtStudentID.Text))
            adptr.SelectCommand.Parameters.AddWithValue("@pdate", dtp1.Text)
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

    Private Sub cboPayMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cboPayMode.SelectedIndex = 1 Then
        '    txtCheckNumber.Enabled = True
        'ElseIf cboPayMode.SelectedIndex = 0 Then
        '    txtCheckNumber.Enabled = False
        'End If
    End Sub
    Private Sub rdoCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCash.CheckedChanged
        If rdoCash.Checked = True Then
            txtCheckNumber.Enabled = False
        ElseIf rdoCash.Checked = False Then
            txtCheckNumber.Enabled = True
        End If
    End Sub

    Private Sub rdoCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCheck.CheckedChanged
        If rdoCheck.Checked = True Then
            txtCheckNumber.Enabled = True
        ElseIf rdoCheck.Checked = False Then
            txtCheckNumber.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class