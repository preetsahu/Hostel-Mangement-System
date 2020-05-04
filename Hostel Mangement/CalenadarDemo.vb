Imports System.Drawing
Imports System.Data.OleDb
Imports System.Drawing.Design
Imports System.Drawing.Graphics
Imports System.DateTime

Public Class CalenadarDemo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim gMonthCalendar As Graphics = MonthCalendar1.CreateGraphics()            'Enable   Drawing(Capabilities)
        'Dim oHTIMonths As MonthCalendar.HitTestInfo                                  'Get HitTestInfo
        'Dim arrDates As New ArrayList()                                                 'ArrayList For Dates
        'For intRows As Integer = 1 To MonthCalendar1.Size.Width - 1                      'Loop Through Width ( Rows )
        '    For intCols As Integer = 1 To MonthCalendar1.Size.Height - 1                  'Loop Through Columns()
        '        oHTIMonths = MonthCalendar1.HitTest(intRows, intCols)                   'Get Hit Info
        '        If oHTIMonths.HitArea = MonthCalendar.HitArea.Date Then                  'Is It A Date That Was Clicked On?
        '            If Not arrDates.Contains(oHTIMonths.Time) Then
        '                arrDates.Add(oHTIMonths.Time)
        '                gMonthCalendar.DrawRectangle(New Pen(Brushes.Blue, 2), intRows, intCols, 24, 15)   'Draw Rectangle Around
        '            End If
        '        End If
        '    Next intCols
        'Next intRows
    End Sub
    Dim query As String
    '  Dim dtArrSpecialDates As Date
    Private Sub CalenadarDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Dim dtArrSpecialDates As Date = New Date()
        Try
            con.Open()
            query = "SELECT ed.EMPLOYEE_NAME,ed.EMPLOYEE_ID,e.Available,e.A_DATE FROM Eattendance e INNER JOIN EmployeeDetails ed ON e.EMPLOYEE_ID = ed.EMPLOYEE_ID where ed.EMPLOYEE_ID =?  AND e.A_DATE BETWEEN ? AND ?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            cmd.Parameters.AddWithValue("?", dtPickerStart.Text)
            cmd.Parameters.AddWithValue("?", dtPickerEnd.Text)
            cmd.ExecuteNonQuery()
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                ' MsgBox(reader(3))
                dtArrSpecialDates = reader(3)           ' {#7/27/2017#, #8/24/2017#, #10/17/2017#}
                ' MonthCalendar1.BoldedDates = {reader(3)}                ' {dtArrSpecialDates}
                MonthCalendar1.AddBoldedDate(dtArrSpecialDates)
                MonthCalendar1.UpdateBoldedDates()
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'Highlight Important Dates
        '    Dim dtArrSpecialDates() As Date = New Date() {#7/27/2017#, #8/24/2017#, #10/17/2017#}
        '   MonthCalendar1.BoldedDates = dtArrSpecialDates
        MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)
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
End Class