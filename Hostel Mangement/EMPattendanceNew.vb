Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design.ToolboxItem
Public Class EmpAttendancenew
    Dim query As String
    Dim i As Integer
    Dim ds As New DataSet
    Dim AVAILstaTus As String
    Private Sub AddElement()
        Dim line As Integer = 1
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            While reader.Read
                Dim lblEmpName As New Label
                lblEmpName.Name = reader(0).ToString
                lblEmpName.AutoSize = New AutoSizeMode()
                lblEmpName.Location = New Point(50, line * 20)                    'creating dynamic label
                lblEmpName.Text = reader(1).ToString
                'Me.Controls.Add(lblEmpName)
                GroupBox1.Controls.Add(lblEmpName)
                '   MsgBox(reader(0))

                Dim chkbox As New CheckBox
                chkbox.Name = reader(0).ToString   '"checkbox" & i
                chkbox.Size = New Size(150, 20)                                  'creating dynamic checkbox
                chkbox.Location = New Point(200, line * 20)
                chkbox.Checked = False
                ' Me.Controls.Add(chkbox)
                GroupBox1.Controls.Add(chkbox)
                i = i + 1
                line = line + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub checkbox_checked(ByVal sender As Object, ByVal e As Object)
        Dim mycheck As CheckBox = TryCast(sender, CheckBox)
    End Sub
    Private Sub btnTakeAttendance_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub gridFormat()
        dtgridEmpAttendance.GridColor = Color.Aqua
        dtgridEmpAttendance.BackgroundColor = Color.LightGray
        dtgridEmpAttendance.CellBorderStyle = DataGridViewCellBorderStyle.None
        dtgridEmpAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        dtgridEmpAttendance.DefaultCellStyle.SelectionBackColor = Color.Cyan
        dtgridEmpAttendance.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        dtgridEmpAttendance.RowsDefaultCellStyle.BackColor = Color.Bisque
        dtgridEmpAttendance.AllowUserToResizeRows = False
        dtgridEmpAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Private Sub EMPattendanceNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddElement()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT ED.EMPLOYEE_ID,ED.EMPLOYEE_NAME ,Ea.Available,Ea.A_DATE,Ea.REMARKS FROM Eattendance Ea INNER JOIN EmployeeDetails ED ON Ea.EMPLOYEE_ID = ED.EMPLOYEE_ID;"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtgridEmpAttendance.DataSource = dt
            gridFormat()
            For x As Integer = 0 To dtgridEmpAttendance.Rows.Count - 1
                dtgridEmpAttendance.Rows(x).Cells(3).Value = Today   ''''for changing a_date columns date to current date view in datagrid
                dtgridEmpAttendance.Rows(x).Cells(3).ReadOnly = True
            Next
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

        ''''''''''''''''''''''''''''''''''''''' Work As --------------------------------------------------------
        Try
            con.Open()
            query = "select * from DayCount"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboMonth.DataSource = dt
            cboMonth.DisplayMember = "MONTH"
            'cboMonthIndex.DataSource = dt
            'cboMonthIndex.DisplayMember = "MONTH_INDEX"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Dim atdate As Date
        atdate = Date.Today
        Dim E_ID As Integer
        Dim avail As Boolean
        Dim REMARK As String
        Try
            con.Open()
            For x As Integer = 0 To dtgridEmpAttendance.Rows.Count - 1
                E_ID = dtgridEmpAttendance.Rows(x).Cells(0).Value
                avail = dtgridEmpAttendance.Rows(x).Cells(2).Value
                atdate = dtgridEmpAttendance.Rows(x).Cells(3).Value
                REMARK = dtgridEmpAttendance.Rows(x).Cells(4).Value.ToString
                '  dtgridEmpAttendance.CommitEdit(False)
                query = "insert into Eattendance (EMPLOYEE_ID,Available,A_DATE,REMARKS) values (@eid,@avail,@adate,@remarks)"
                Dim cmd As New OleDb.OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("@eid", E_ID)
                cmd.Parameters.AddWithValue("@avail", avail)
                cmd.Parameters.AddWithValue("@adate", Convert.ToDateTime(atdate))
                cmd.Parameters.AddWithValue("@remarks", REMARK)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                dtgridEmpAttendance.Update()
                dtgridEmpAttendance.RefreshEdit()
            Next
            MessageBox.Show("Registered Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        dtgridEmpAttendance.Update()
    End Sub
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Function Label(ByVal i As Integer) As Control
        Throw New NotImplementedException
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            For Each mycheck In GroupBox1.Controls.OfType(Of CheckBox)()
                If mycheck.Checked = True Then
                    AVAILstaTus = "YES"
                    Dim query1 As String = "insert into DailyStudentAttendance (S_ID,Check_Mode,BUS_ID,Attendance_Date) values (?,?,?,?)"
                    Dim CMD1 As New OleDbCommand(query1, con)
                    CMD1.Parameters.AddWithValue("@sid", Val(mycheck.Name))
                    ' CMD1.Parameters.AddWithValue("@eid", Val(lblEmpName.Text))         '''USED TO INSERT ATTENDANCE
                    CMD1.Parameters.AddWithValue("@chkMode", AVAILstaTus)
                    CMD1.Parameters.AddWithValue("@busid", Convert.ToDateTime(DateTimePicker1.Value).ToString)
                    CMD1.Parameters.AddWithValue("@adate", DateTimePicker1.Text)
                    CMD1.ExecuteNonQuery()
                    CMD1.Dispose()
                    ' MessageBox.Show(mycheck.Name + "present")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
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
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSaveWorkDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateWorkDay.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update DayCount set WORK_DAY=? WHERE MONTH='" + cboMonth.Text + "'"
            Dim CMD As New OleDbCommand(query, con)
            CMD.Parameters.AddWithValue("?", txtwORKdAYS.Text)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("WORK DAYS UPDATED")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub dtgridEmpAttendance_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridEmpAttendance.CellContentClick

    End Sub
End Class