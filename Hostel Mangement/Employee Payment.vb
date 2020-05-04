Imports System.Data
Imports System
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class Employee_Payment
    Dim query As String
    Dim querycomplete As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''' subroutine ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub workDayDisplay()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from DayCount"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboMonth.DataSource = dt
            cboMonth.DisplayMember = "MONTH"
            cboMonthIndex.DataSource = dt
            cboMonthIndex.DisplayMember = "MONTH_INDEX"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Employee_Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        empjoin()
        cboPayMode.Items.Add("CASH")
        cboPayMode.Items.Add("CHECK")
       
        Dim con As New OleDbConnection
        con = connectTOhms()
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
        workDayDisplay()    ''''''''''''''''''''''''''''''''' subroutine calling''''''''''''''''''''''''''
        cboEmpID.Text = ""
        cboEmpName.Text = ""
        cboPayMode.Text = ""
        txtPayingAmount.Text = ""
        txtRemainingFees.Text = ""
        txtsalary.Text = ""
    End Sub
    Private Sub empjoin()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            query = "SELECT ed.EMPLOYEE_ID, ed.EMPLOYEE_NAME, ed.WORK_AS, ed.SALARY, ep.PAYED_AMOUNT, ep.PAYMENT_DATE, ep.REMAINING_PAYMENT FROM EmployeeDetails AS ed INNER JOIN EmployeePayment AS ep ON ed.EMPLOYEE_ID = ep.EMPLOYEE_ID" ' WHERE ed.EMPLOYEE_ID='" + TextBox1.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboEmpID.DataSource = dt
            cboEmpID.DisplayMember = "EMPLOYEE_ID"
            cboEmpName.DataSource = dt
            cboEmpName.DisplayMember = "EMPLOYEE_NAME"
            'cboWorkAs.DataSource = dt
            'cboWorkAs.DisplayMember = "WORK_AS"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub cboWorkAs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub cboEmpID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim CON As New OleDbConnection
        'CON = connectTOhms()
        'Try
        '    CON.Open()
        '    query = "SELECT ed.EMPLOYEE_ID, ed.EMPLOYEE_NAME, ed.WORK_AS, ed.SALARY, ep.PAYED_AMOUNT, ep.PAYMENT_DATE, ep.REMAINING_PAYMENT, ep.PAYMENT_MODE , ed.ALLOTED_LEAVE FROM EmployeeDetails AS ed INNER JOIN EmployeePayment AS ep ON ed.EMPLOYEE_ID = ep.EMPLOYEE_ID WHERE ed.EMPLOYEE_ID=?"
        '    ' query = "select * from EmployeeDetails where EMPLOYEE_ID like ?"
        '    Dim CMD As New OleDbCommand(query, CON)
        '    CMD.Parameters.AddWithValue("?", Val(cboEmpID.Text))
        '    Dim READER As OleDbDataReader = CMD.ExecuteReader
        '    While READER.Read
        '        txtPaidAmount.Text = READER(4).ToString
        '        txtsalary.Text = READER(3).ToString
        '        DtP1.Text = READER(5).ToString
        '        txtRemainingFees.Text = READER(6).ToString
        '        cboPayMode.Text = READER(7).ToString
        '        txtAllotedLeave.Text = READER(8).ToString
        '    End While
        '    CMD.Dispose()
        'Catch EX As Exception
        '    MsgBox(EX.Message)
        'Finally
        '    CON.Close()
        'End Try

    End Sub

    Private Sub cboEmpID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtsalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub


    Private Sub txtPaidAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtRemainingFees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboEmpName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboPayMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboPayMode.Text = ""
        txtPayingAmount.Text = ""
        txtACno.Text = ""
        txtIFSCcode.Text = ""
        txtRemainingFees.Text = ""
        txtwORKdAYS.Text = ""
        txtAbsentdasy.Text = ""
        txtPaidAmount.Text = ""
        txtPayment.Text = ""
    End Sub

    Private Sub txtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim amountPayed As String = ""
        Dim CON As OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select SUM(PAYED_AMOUNT) from EmployeePayment where EMPLOYEE_ID=?"
            Dim cmd As New OleDbCommand(query, CON)
            cmd.Parameters.AddWithValue("?", Val(cboEmpID.Text))
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                amountPayed = reader(0).ToString
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CON.Close()
        End Try
        Dim cal As Integer = Val(amountPayed) - Val(txtPayingAmount.Text)
        txtRemainingFees.Text = Convert.ToString(cal)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim CON As OleDbConnection
        CON = connectTOhms()
        'If txtPayingAmount.Text = "" Then
        '    MsgBox("please enter paying amount")
        '    txtPayingAmount.Focus()
        'ElseIf txtRemainingFees.Text = "" Or txtRemainingFees.Text = "0" Then
        '    MsgBox("Not possible!you have already payed The Employee " + cboEmpName.Text + "  " + cboMonth.Text + " month payment, please pay for another month if you want to advance salary payment")
        '    cboMonth.Focus()
        'ElseIf Val(totabsentday) = 0 Then
        '    txtPayingAmount.Text = ""
        '    txtPayment.Text = 0
        '    btnSave.Focus()
        '    MsgBox("employee is not present in whole month of so his not gain any salary of this month is  " + txtPayment.Text, MsgBoxStyle.MsgBoxRight)
        'End If

        Try
            CON.Open()
            query = "insert into EmployeePayment (EMPLOYEE_ID,PAYMENT_MODE,PAYED_AMOUNT,PAYMENT_DATE,REMAINING_PAYMENT,BANK_AC_NO,IFSC_CODE) values (?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, CON)
            cmd.Parameters.AddWithValue("?", Val(cboEmpID.Text))
            cmd.Parameters.AddWithValue("?", cboPayMode.Text)
            cmd.Parameters.AddWithValue("?", Val(txtPayingAmount.Text))
            cmd.Parameters.AddWithValue("?", DtP1.Text)
            cmd.Parameters.AddWithValue("?", Val(txtRemainingFees.Text))
            cmd.Parameters.AddWithValue("?", txtACno.Text)
            cmd.Parameters.AddWithValue("?", txtIFSCcode.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Payment Done by : " + cboEmpName.Text + " of rupess : " + txtPayingAmount.Text + "")
            clearall()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CON.Close()
        End Try
    End Sub
    Private Sub clearall()
        txtPayingAmount.Text = ""
        txtRemainingFees.Text = ""
        ' txtsalary.Text = ""
        ' cboEmpID.Text = ""
        cboPayMode.Text = ""
        'cboEmpName.Text=""
    End Sub
    Dim workDays As Integer
    Dim totabsentday As Integer
    Dim perday As Integer

    Private Sub cboPayMode_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPayMode.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub cboPayMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPayMode.SelectedIndexChanged
        If cboPayMode.SelectedIndex = 0 Then
            grpBankDetails.Enabled = False
        ElseIf cboPayMode.SelectedIndex = 1 Then
            grpBankDetails.Enabled = True
        ElseIf cboPayMode.SelectedIndex = 2 Then
            grpBankDetails.Enabled = 3

        End If
    End Sub

    Private Sub cboWorkAs_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboWorkAs.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
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
        'cboPayMode.Text = ""
        'cboEmpName.Text = ""
        'txtPaidAmount.Text = " "
        ' cboEmpID.Text = ""
        'txtRemainingFees.Text = " "
        'txtsalary.Text = ""
    End Sub

    Private Sub cboEmpName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpName.SelectedIndexChanged
        loadEmpDetails()
    End Sub
    Private Sub loadEmpDetails()
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select SALARY,BANK_AC_NO,IFSC_CODE,ALLOTED_LEAVE from EmployeeDetails where EMPLOYEE_ID like ?"
            Dim CMD As New OleDbCommand(query, CON)
            CMD.Parameters.AddWithValue("?", Val(cboEmpID.Text))
            Dim READER As OleDbDataReader = CMD.ExecuteReader
            While READER.Read
                txtsalary.Text = READER(0).ToString
                txtAllotedLeave.Text = READER(3).ToString
                txtACno.Text = READER(1).ToString
                txtIFSCcode.Text = READER(2).ToString
            End While
            READER.Close()
            CMD.Dispose()
        Catch EX As Exception
            MsgBox(EX.Message)
        Finally
            CON.Close()
        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''' total payed gain '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'paidCalculate()
    End Sub

    Private Sub paidCalculate()
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select SUM(PAYED_AMOUNT) from EmployeePayment where month(PAYMENT_DATE)=? and Year(DATE()) and EMPLOYEE_ID=?"
            Dim cmd As New OleDbCommand(query, CON)
            cmd.Parameters.AddWithValue("?", Val(cboMonthIndex.Text))
            cmd.Parameters.AddWithValue("?", Val(cboEmpID.Text))
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtPaidAmount.Text = reader(0).ToString
                MsgBox(reader(0))
            End While

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try

    End Sub
    Private Sub txtACno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtACno.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''' calculate payment amount '''''''''''''''''''''''''''''''''''''''
    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
        paidCalculate()
        Dim presentdays As Integer
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT count( *) FROM Eattendance WHERE month(A_DATE) ='" + cboMonthIndex.Text + "' and year([A_DATE]) and Available='YES' and EMPLOYEE_ID =?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", Val(cboEmpID.Text))
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                presentdays = reader(0)
            End While
            reader.Close()
            ' cmd.ExecuteNonQuery()
            cmd.Dispose()
            txtAbsentdasy.Text = Val(txtwORKdAYS.Text) - Val(presentdays)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        perday = Val(txtsalary.Text) / Val(txtwORKdAYS.Text)
        If Val(txtAllotedLeave.Text) >= Val(txtAbsentdasy.Text) Then
            txtPayment.Text = txtsalary.Text
        ElseIf Val(txtAllotedLeave.Text) < Val(txtAbsentdasy.Text) Then
            totabsentday = Val(txtAbsentdasy.Text) - Val(txtAllotedLeave.Text)
            If Val(totabsentday) = 0 Then
                txtPayingAmount.Text = ""
                txtPayment.Text = 0
                btnSave.Focus()
                MsgBox("employee is not present in whole month of so his not gain any salary of this month is  " + txtPayment.Text, MsgBoxStyle.MsgBoxRight)
            Else
                txtPayment.Text = Val(txtsalary.Text) - (totabsentday * perday)
                MsgBox("employee is present for :" + Convert.ToString(presentdays) + " and his total salary of this month is: " + txtPayment.Text, MsgBoxStyle.MsgBoxRight)
            End If
        End If
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from DayCount where MONTH LIKE'" + cboMonth.Text + "'"
            Dim CMD As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = CMD.ExecuteReader
            While reader.Read
                txtwORKdAYS.Text = reader("WORK_DAY").ToString

            End While
            reader.Close()
            CMD.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        ' paidCalculate()
    End Sub

    Private Sub txtPayingAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayingAmount.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub
    '''''---------------------------------------------'''''''''''''''''
    Private Sub txtPayingAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPayingAmount.Leave
        If txtPayment.Text = "" Then
            btnCal.Focus()
            MsgBox("Please calculate Payment Amount First")
            txtPayingAmount.Text = ""
            txtRemainingFees.Text = ""
        End If
        If Val(txtPayment.Text) > Val(txtPayingAmount.Text) Then
            txtRemainingFees.Text = Val(txtPayment.Text) - Val(txtPayingAmount.Text)
        Else
            txtRemainingFees.Text = Val(txtPayingAmount.Text) - Val(txtPayment.Text)
        End If
    End Sub

    Private Sub txtPayingAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayingAmount.TextChanged

    End Sub
    Private Sub txtsalary_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAbsentdasy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbsentdasy.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAllotedLeave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllotedLeave.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPaidAmount_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaidAmount.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtRemainingFees_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemainingFees.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtwORKdAYS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwORKdAYS.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim query As String = "SELECT EmployeePayment.EMPLOYEE_ID, EmployeeDetails.EMPLOYEE_NAME, EmployeeDetails.PHOTO,EmployeeDetails.EMPLOYEE_CONTACT, EmployeeDetails.WORK_AS, EmployeeDetails.WORK_SHIFT, EmployeeDetails.SALARY,     EmployeePayment.PAYMENT_MODE, EmployeePayment.PAYED_AMOUNT, EmployeePayment.PAYMENT_DATE, EmployeePayment.REMAINING_PAYMENT, EmployeePayment.BANK_AC_NO AS Expr1,    EmployeePayment.IFSC_CODE FROM   (EmployeeDetails INNER JOIN  EmployeePayment ON EmployeeDetails.EMPLOYEE_ID = EmployeePayment.EMPLOYEE_ID) where EmployeeDetails.EMPLOYEE_ID=? and EmployeePayment.PAYMENT_DATE=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@cls", Val(cboEmpID.Text))
            adptr.SelectCommand.Parameters.AddWithValue("@pdate", DtP1.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim DataSet7 As New DataSet
            adptr.Fill(DataSet7, "DataSet7")
            Me.ReportViewer1.LocalReport.ReportPath = "ReportViewerEmpPaymentReceipt.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet7", DataSet7.Tables("DataSet7")))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class