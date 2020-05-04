Imports System.Data.OleDb
Imports System.Data
Public Class StudemtCheckInOutEntry
    Dim query As String
    Dim mode As String
    Dim querycomplete As String
    Private Sub gridFormat()
        DtGridView.GridColor = Color.Aqua
        DtGridView.BackgroundColor = Color.LightGray
        DtGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
        DtGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        DtGridView.DefaultCellStyle.SelectionBackColor = Color.Cyan
        DtGridView.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        DtGridView.RowsDefaultCellStyle.BackColor = Color.Bisque
        DtGridView.AllowUserToResizeRows = False
        DtGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Public Sub dataGridRefresh()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from StudentAttendance"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        gridFormat()
    End Sub
    Private Sub studentattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        dataGridRefresh()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboClass.DataSource = dt
            cboClass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboClass.Text = ""
        cboYear.Text = ""
        txtGaurdOnDuty.Text = Gaurd_View.StatusStrip.Items(1).ToString
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from StudentAttendance " + querycomplete
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            DtGridView.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub comboClassFill()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClass.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboYear.DataSource = dt
            cboYear.DisplayMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClass.SelectedIndexChanged
        comboClassFill()
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
            cboStudentName.DataSource = dt
            cboStudentName.DisplayMember = "NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        viewStudent()
        cboYear.Text = ""
        cboStudentName.Text = ""
        TXTsid.Text = ""
    End Sub
    Private Sub GetStudentID()
        TXTsid.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where NAME like '" + cboStudentName.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                TXTsid.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboStudentName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStudentName.SelectedIndexChanged
        GetStudentID()
    End Sub
    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub mtGoingWith_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtGoingWith.SelectedIndexChanged
        If mtGoingWith.SelectedIndex = 0 Then
            Vname.Text = "Friend Name"
        ElseIf mtGoingWith.SelectedIndex = 1 Then
            Vname.Text = "Parent Name"
        End If
    End Sub

    Private Sub rdoCHKin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCHKin.CheckedChanged
        If rdoCHKin.Checked = True Then
            txtpurpose.Text = ""
            txtpurpose.Enabled = False
            DateTimePicker1.Enabled = False
            '    txtvehicle.Enabled = False
            txtvehicle.Text = ""
            VisitWith.Text = "Come With"
            Vname.Text = "Name"
            txtName.Text = ""
            mtGoingWith.Text = ""
            TextBox1.Text = ""
            txtRemark.Text = ""
        End If
    End Sub

    Private Sub rdochkOUT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdochkOUT.CheckedChanged
        txtpurpose.Text = ""
        txtpurpose.Enabled = True
        DateTimePicker1.Enabled = True
        txtvehicle.Enabled = True
        VisitWith.Text = "Went With"
        Vname.Text = "Name"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con As OleDbConnection
        con = connectTOhms()

        If rdoCHKin.Checked = True Then
            mode = "Check IN"
        ElseIf rdochkOUT.Checked = True Then
            mode = "Check OUT"
        End If
        Try
            con.Open()
            query = "insert into StudentAttendance (S_ID,CLASS,COURSE_YEAR,CHECK_MODE,DATE_TIME,VISIT_WITH,VISIT_NAME,VISIT_CONTACT,PURPOSE,VEHICLE_NUMBER,REMARKS,GAURD_ON_DUTY,CURRENT_AVAIL_STATUS_IN_HOSTEL) values (?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@sid", Val(TXTsid.Text))
            cmd.Parameters.AddWithValue("@cls", cboClass.Text)
            cmd.Parameters.AddWithValue("@year", cboYear.Text)
            cmd.Parameters.AddWithValue("@chkmode", mode)
            cmd.Parameters.AddWithValue("@Dtime", Convert.ToDateTime(dtp1.Text).ToString)
            '  cmd.Parameters.AddWithValue("@Vtime", Convert.ToDateTime(DateTimePicker1.Value).ToString)
            cmd.Parameters.AddWithValue("@VwITH", mtGoingWith.Text)
            cmd.Parameters.AddWithValue("@VwithName", txtName.Text)
            cmd.Parameters.AddWithValue("@VwITHcontact", TextBox1.Text)
            cmd.Parameters.AddWithValue("@purpose", txtpurpose.Text)
            cmd.Parameters.AddWithValue("@vechicleNO", txtvehicle.Text)
            cmd.Parameters.AddWithValue("@Remarks", txtRemark.Text)
            cmd.Parameters.AddWithValue("@GaurdOnduty", txtGaurdOnDuty.Text)
            cmd.Parameters.AddWithValue("@CavailStatus", "NO")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Entry Saved")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "the id must have unique")
        Finally
            con.Close()
        End Try
        dataGridRefresh()
    End Sub

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT ra.NAME,ra.CONTACT,sa.CHECK_MODE,sa.DATE_TIME,sa.SPENT_DAY_TIME,sa.VISIT_WITH,sa.VISIT_NAME,sa.VISIT_CONTACT,sa.PURPOSE,sa.VEHICLE_NUMBER,sa.REMARKS,sa.GAURD_ON_DUTY,sa.CURRENT_AVAIL_STATUS_IN_HOSTEL,ra.CLASS,ra.COURSE_YEAR,ra.ROOM_ID,ra.BED_ID FROM RoomAllotment ra INNER JOIN StudentAttendance sa ON ra.S_ID = sa.S_ID WHERE ra.S_ID Like ? And sa.DATE_TIME Between ? And ?"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.Parameters.AddWithValue("?", TXTsid.Text)
            adptr.SelectCommand.Parameters.AddWithValue("?", dtPickerStart.Text)
            adptr.SelectCommand.Parameters.AddWithValue("?", dtPickerEnd.Text)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim dt As New DataTable
            adptr.Fill(dt)
            DtGridView.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboVisitingByClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        comboClassFill()
    End Sub

    Private Sub cboVisitingByYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        viewStudent()
        cboYear.Text = ""
        cboStudentName.Text = ""
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click

    End Sub
End Class