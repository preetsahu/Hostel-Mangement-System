Imports System.Data.OleDb
Imports System.Data
Public Class Attendance_View
    Dim query As String
    Private Sub Attendance_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select distinct[WORK_AS] from EmployeeDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboSearchBy.DataSource = dt
            cboSearchBy.DisplayMember = "WORK_AS"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails where WORK_AS LIKE '" + cboSearchBy.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboSelected.DataSource = dt
            cboSelected.DisplayMember = "EMPLOYEE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboSelected_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelected.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails where EMPLOYEE_NAME Like '" + cboSelected.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                TextBox1.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT ed.EMPLOYEE_NAME,ed.EMPLOYEE_ID,e.Available,e.A_DATE FROM Eattendance e INNER JOIN EmployeeDetails ed ON e.EMPLOYEE_ID = ed.EMPLOYEE_ID where ed.EMPLOYEE_ID =?  AND e.A_DATE BETWEEN ? AND ?"
            ' Dim cmd As New OleDbCommand(query, con)
            'cmd.Parameters.AddWithValue("?", TextBox1.Text)
            'cmd.Parameters.AddWithValue("?", dtPickerStart.Text)
            'cmd.Parameters.AddWithValue("?", dtPickerEnd.Text)
            'cmd.ExecuteNonQuery()
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("?", TextBox1.Text)
            adptr.SelectCommand.Parameters.AddWithValue("?", dtPickerStart.Text)
            adptr.SelectCommand.Parameters.AddWithValue("?", dtPickerEnd.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim dt As New DataTable
            adptr.Fill(dt)
            MetroGrid1.DataSource = dt
            adptr.Dispose()
            ' cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    'Dim cmd As New OleDbCommand(query, con)
    'Dim reader As OleDbDataReader = cmd.ExecuteReader
    '        MonthCalendar1.SelectionStart = dtPickerStart.Text
    '        MonthCalendar1.SelectionEnd = dtPickerEnd.Text
    'Dim days As Integer = DateDiff(DateInterval.Day, dtPickerStart.Value, dtPickerEnd.Value)
    'Dim i As Integer = 1
    '        While reader.Read
    '            For i = 1 To days Step i = i + 1

    '            Next
    '        End While
End Class