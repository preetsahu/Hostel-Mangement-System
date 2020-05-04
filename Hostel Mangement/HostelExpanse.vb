Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Imports System.Data
Public Class HostelExpanse
    Dim query As String
    Dim qc As String
    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT SUM(AMOUNT) FROM ExapanseDetails where Expanse_Category=? AND Expanse_Date between ? and ?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", MetroComboBox1.Text)
            cmd.Parameters.AddWithValue("?", dtPickerStart.Text)
            cmd.Parameters.AddWithValue("?", dtPickerEnd.Text)
            cmd.ExecuteNonQuery()
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                TextBox1.Text = reader(0).ToString
                MetroTile1.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()

        '------------------------------------------------------- INSERT -----------------------------------------------------
        Try
            con.Open()
            query = "insert into ExapanseDetails(Expanse_Date,Expanse_Category,DESCRIPTION,AMOUNT,BILL_NUMBER) values (?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", dtExpanse.Text)
            cmd.Parameters.AddWithValue("?", mtExpType.Text)
            cmd.Parameters.AddWithValue("?", txtExpDescription.Text)
            cmd.Parameters.AddWithValue("?", txtAmount.Text)
            cmd.Parameters.AddWithValue("?", txtBillno.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Expanse of Date " + dtExpanse.Text + " is sucessfully saved of category : " + mtExpType.Text)
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub clear()
        txtAmount.Text = ""
        txtBillno.Text = ""
        mtExpType.Text = ""
        txtExpDescription.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = " SELECT SUM(AMOUNT) FROM ExapanseDetails where Expanse_Date between ? and ?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", dtp1Monthly.Text)
            cmd.Parameters.AddWithValue("?", dtp2Monthly.Text)
            cmd.ExecuteNonQuery()
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                MetroLabel2.Text = reader(0).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewReport.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT ITEM_ID, Expanse_Date, Expanse_Category, DESCRIPTION, AMOUNT, BILL_NUMBER FROM ViewExpanseJoin WHERE month(Expanse_Date)=? and year(Expanse_Date)=?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("@mnt", MetroComboBox2.Text)
            adptr.SelectCommand.Parameters.AddWithValue("@year", Val(TxtYear.Text))
            adptr.SelectCommand.ExecuteNonQuery()
            Dim dt As New DataSet
            adptr.Fill(dt)
            ReportViewer1.LocalReport.ReportPath = "ReportViewerExpanse.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt.Tables(0)))
            ReportViewer1.RefreshReport()
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If cboMonth.SelectedIndex = 0 Then
            MetroComboBox2.Text = 1
        ElseIf cboMonth.SelectedIndex = 1 Then
            MetroComboBox2.Text = 2
        ElseIf cboMonth.SelectedIndex = 2 Then
            MetroComboBox2.Text = 3
        ElseIf cboMonth.SelectedIndex = 3 Then
            MetroComboBox2.Text = 4
        ElseIf cboMonth.SelectedIndex = 4 Then
            MetroComboBox2.Text = 5
        ElseIf cboMonth.SelectedIndex = 5 Then
            MetroComboBox2.Text = 6
        ElseIf cboMonth.SelectedIndex = 6 Then
            MetroComboBox2.Text = 7
        ElseIf cboMonth.SelectedIndex = 7 Then
            MetroComboBox2.Text = 8
        ElseIf cboMonth.SelectedIndex = 8 Then
            MetroComboBox2.Text = 9
        ElseIf cboMonth.SelectedIndex = 9 Then
            MetroComboBox2.Text = 10
        ElseIf cboMonth.SelectedIndex = 10 Then
            MetroComboBox2.Text = 11
        ElseIf cboMonth.SelectedIndex = 11 Then
            MetroComboBox2.Text = 12
        End If
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub
End Class
