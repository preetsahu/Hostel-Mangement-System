Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class VisitingDetail
    Dim cmd As OleDbCommand
    Dim adptr As OleDbDataAdapter
    Dim con As OleDbConnection
    Dim query As String
    Dim querycomplete As String

    '''''''''''''''''''''''''''''''''' '''''Subroutine for refresh''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub DataRefresh()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            adptr.Dispose()
            Me.DTgridStudent.DataSource = dt    'load the data to datagrid when form loads
            cboClass.DataSource = dt
            cboClass.DisplayMember = "CLASS"
            cboClass.ValueMember = "CLASS"

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If con.State = ConnectionState.Open Then
                query = "SELECT vd.VISITOR_ID, v.VISITORS_NAME,r.S_ID, r.NAME, r.CLASS, v.VISITORS_ADDRESS, v.VISITORS_CONTACT, vd.VISITING_PURPOSE, vd.IN_DATE_TIME, vd.OUT_DATE_TIME, vd.REMARKS FROM RoomAllotment as r INNER JOIN (VisitorDetails as v INNER JOIN VisitingDetails as vd ON v.VISITOR_ID = vd.VISITOR_ID) ON r.S_ID = vd.S_ID;"
                Dim adptr1 As New OleDbDataAdapter(query, con)
                Dim dt1 As New DataTable
                adptr1.Fill(dt1)
                adptr1.Dispose()
                Me.DTgridVisitor.DataSource = dt1
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If con.State = ConnectionState.Open Then
                query = "select * from VisitorDetails"
                Dim adptr2 As New OleDbDataAdapter(query, con)
                Dim dt2 As New DataTable
                adptr2.Fill(dt2)
                adptr2.Dispose()
                cboVisitorID.DataSource = dt2
                cboVisitorID.DisplayMember = "VISITOR_ID"
                cboVisitorName.DataSource = dt2
                cboVisitorName.DisplayMember = "VISITORS_NAME"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    'the following code used to select particular cell and insert its value in control like textbox etc
    Private Sub DTgridStudent_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTgridStudent.CellClick
        Dim i As Integer
        With DTgridStudent
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                If DTgridStudent.RowCount >= 0 Then
                    'data grid store first column then row i.e. [j,i] format
                    'currentrow used to selcet the value of current clicked row
                    Dim myimagebyte() As Byte = DTgridStudent.Item(4, DTgridStudent.CurrentRow.Index).Value
                    Dim memstream As New MemoryStream(myimagebyte)
                    PictureBox1.Image = Image.FromStream(memstream)            'load picture for memory stream
                End If
                txtStudentName.Text = .Rows(i).Cells("NAME").Value.ToString
                cboClass.Text = .Rows(i).Cells("CLASS").Value.ToString
                txtStudentID.Text = .Rows(i).Cells("S_ID").Value.ToString
                txtClass.Text = .Rows(i).Cells("CLASS").Value.ToString
            End If
        End With
    End Sub
    Private Sub studentGridView()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select S_ID,NAME,CLASS,CONTACT,PHOTO,FATHERS_NAME,FATHERS_CONTACT,ROOM_ID,BED_ID from RoomAllotment where ROOM_ID<>'' "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            adptr.Dispose()
            Me.DTgridStudent.DataSource = dt    'load the data to datagrid when form loads
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub visitoGridView()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT vd.VISITOR_ID, v.VISITORS_NAME,r.S_ID as STUDENT_ID, r.NAME AS Student_Name, r.CLASS, v.VISITORS_ADDRESS, v.VISITORS_CONTACT, vd.VISITING_PURPOSE, vd.IN_DATE_TIME, vd.OUT_DATE_TIME, vd.REMARKS FROM RoomAllotment as r INNER JOIN (VisitorDetails as v INNER JOIN VisitingDetails as vd ON v.VISITOR_ID = vd.VISITOR_ID) ON r.S_ID = vd.S_ID;"
            Dim adptr1 As New OleDbDataAdapter(query, con)
            Dim dt1 As New DataTable
            adptr1.Fill(dt1)
            adptr1.Dispose()
            Me.DTgridVisitor.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub comboDataLoad()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            query = "select * from VisitorDetails"
            Dim adptr2 As New OleDbDataAdapter(query, con)
            Dim dt2 As New DataTable
            adptr2.Fill(dt2)
            adptr2.Dispose()
            cboVisitorID.DataSource = dt2
            cboVisitorID.DisplayMember = "VISITOR_ID"
            cboVisitorName.DataSource = dt2
            cboVisitorName.DisplayMember = "VISITORS_NAME"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub visitorDataGridFormat()
        DTgridVisitor.GridColor = Color.Aqua
        DTgridVisitor.BackgroundColor = Color.LightGray
        DTgridVisitor.CellBorderStyle = DataGridViewCellBorderStyle.None
        DTgridVisitor.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        DTgridVisitor.DefaultCellStyle.SelectionBackColor = Color.Cyan
        DTgridVisitor.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        DTgridVisitor.RowsDefaultCellStyle.BackColor = Color.Bisque
        DTgridVisitor.AllowUserToResizeRows = False
        DTgridVisitor.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Private Sub studentDataGridFormat()
        DTgridStudent.GridColor = Color.Aqua
        DTgridStudent.BackgroundColor = Color.LightGray
        DTgridStudent.CellBorderStyle = DataGridViewCellBorderStyle.None
        DTgridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        DTgridStudent.DefaultCellStyle.SelectionBackColor = Color.Cyan
        DTgridStudent.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        DTgridStudent.RowsDefaultCellStyle.BackColor = Color.Bisque
        DTgridStudent.AllowUserToResizeRows = False
        DTgridStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Private Sub VisitorDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        studentGridView()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        visitoGridView()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        comboDataLoad()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        studentDataGridFormat()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        visitorDataGridFormat()
    End Sub

    Private Sub txtsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveVisitingDetail.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim cmd As New OleDbCommand
            query = "insert into VisitingDetails (S_ID,VISITOR_ID,VISITING_PURPOSE,IN_DATE_TIME,OUT_DATE_TIME,REMARKS) values(?,?,?,?,?,?)"
            cmd.CommandText = query
            cmd.Connection = con
            cmd.Parameters.AddWithValue("?", Val(txtStudentID.Text))
            cmd.Parameters.AddWithValue("?", Val(cboVisitorID.Text))
            cmd.Parameters.AddWithValue("?", txtPurpose.Text)
            cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtPickerIN.Value.ToString))
            cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtPickerOUT.Value.AddMinutes(30).ToString))
            cmd.Parameters.AddWithValue("?", txtRemarks.Text)
            cmd.ExecuteNonQuery()
            con.Dispose()
            MsgBox("visiting Details saved")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        visitoGridView()
        Timer1.Start()
        If Timer1.Interval = 2000 Then
            MsgBox("Visiting time off")
        End If
    End Sub

    Private Sub DTgridVisitor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTgridVisitor.CellClick
        Dim i As Integer
        With DTgridVisitor
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                'cboVisitorName.Text = .Rows(i).Cells("VISITORS_NAME").Value.ToString
                cboVisitorID.Text = .Rows(i).Cells("VISITOR_ID").Value.ToString
                dtPickerIN.Text = .Rows(i).Cells("IN_DATE_TIME").Value.ToString
                dtPickerOUT.Text = .Rows(i).Cells("OUT_DATE_TIME").Value.ToString
                txtRemarks.Text = .Rows(i).Cells("REMARKS").Value.ToString
                txtPurpose.Text = .Rows(i).Cells("VISITING_PURPOSE").Value.ToString
            End If
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewVisitor.Click
        VisitorEntry.Show() '
        VisitorEntry.MdiParent = Hostel_Management_System
        VisitorEntry.Dock = DockStyle.Fill
    End Sub

    Private Sub btnFindVisitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindVisitor.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT vd.VISITOR_ID, v.VISITORS_NAME,r.S_ID as STUDENT_ID, r.NAME AS Student_Name, r.CLASS, v.VISITORS_ADDRESS, v.VISITORS_CONTACT, vd.VISITING_PURPOSE, vd.IN_DATE_TIME, vd.OUT_DATE_TIME, vd.REMARKS FROM RoomAllotment as r INNER JOIN (VisitorDetails as v INNER JOIN VisitingDetails as vd ON v.VISITOR_ID = vd.VISITOR_ID) ON r.S_ID = vd.S_ID WHERE v.VISITORS_NAME LIKE '" + cboVisitorName.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            DTgridVisitor.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            'con.Open()
            'query = "select * from VisitingDetails where VISITOR_ID like '" + cboVisitorID.Text + "';"              'VISITORS_NAME like '" + cboVisitorName.Text + "' AND 
            'Dim adptr As New OleDbDataAdapter(query, con)
            'Dim dt As New DataTable
            'adptr.Fill(dt)
            'DTgridVisitor.DataSource = dt
            'Dim curRow As DataGridViewRow = DTgridVisitor.CurrentRow
            'txtPurpose.Text = curRow.Cells(2).Value.ToString
            'dtPickerIN.Text = curRow.Cells(3).Value.ToString
            'dtPickerOUT.Text = curRow.Cells(4).Value.ToString
            'txtPurpose.Text = curRow.Cells(2).Value.ToString
            'txtRemarks.Text = curRow.Cells(5).Value.ToString
            'adptr.Dispose()

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            '  con.Close()
        End Try
    End Sub
    Private Sub txtStudentName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentName.KeyPress
        If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            e.Handled = True
            MessageBox.Show("cannot enter DIGIT here")
        End If
    End Sub

    Private Sub txtEnter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            e.Handled = True
            MessageBox.Show("cannot enter DIGIT here")
        End If
    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select S_ID,NAME,CLASS,COURSE_YEAR,CONTACT,PHOTO,FATHERS_NAME,FATHERS_CONTACT,ROOM_ID,BED_ID from RoomAllotment where ROOM_ID<>'' "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)

            If cboSearchBy.SelectedIndex = 0 Then
                cboYear.Enabled = True
                cboClass.Text = ""
                Try
                    query = "select distinct[COURSE_NAME] from CourseDetails"
                    Dim adptr1 As New OleDbDataAdapter(query, con)
                    Dim dt1 As New DataTable
                    adptr1.Fill(dt1)
                    cboSelected.DataSource = dt1
                    cboSelected.DisplayMember = "COURSE_NAME"
                    adptr1.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                Finally
                    con.Close()
                End Try
                txtStudentName.Text = ""
                txtStudentID.Text = ""
                txtClass.Text = ""
                Try
                    query = "select CLASS from RoomAllotment where CLASS like '" + cboSelected.Text + "'"
                    Dim adptr3 As New OleDbDataAdapter(query, con)
                    Dim dt3 As New DataTable
                    adptr3.Fill(dt3)
                    cboClass.DataSource = dt3
                    cboClass.DisplayMember = "CLASS"
                    adptr3.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                Finally
                    con.Close()
                End Try
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                txtClass.Text = ""
                txtStudentID.Text = ""
                txtStudentName.Text = ""
                cboYear.Text = ""
                cboYear.Enabled = False
                cboSelected.DataSource = dt
                cboSelected.DisplayMember = "NAME"
                'Try
                '    query = "select COURSE_YEAR,CLASS,S_ID from RoomAllotment where NAME like '" + cboSelected.Text + "'  "
                '    Dim adptr2 As New OleDbDataAdapter(query, con)
                '    Dim dt2 As New DataTable
                '    adptr2.Fill(dt2)
                '    'cboYear.DataSource = dt2
                '    'cboYear.DisplayMember = "COURSE_YEAR"
                '    Dim cmd2 As New OleDbCommand(query, con)
                '    Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
                '    While reader2.Read
                '        ' cboYear.Text = reader2(0).ToString
                '        txtClass.Text = reader2(1).ToString
                '        txtStudentID.Text = reader2(2).ToString
                '    End While
                '    cmd2.Dispose()
                '    adptr2.Dispose()
                'Catch ex As Exception
                '    MsgBox(ex.Message, MsgBoxStyle.Information)
                'Finally
                '    con.Close()
                'End Try
                adptr.Dispose()
                Dim row As DataGridViewRow = DTgridStudent.CurrentRow
                txtClass.Text = row.Cells("CLASS").Value
                cboClass.Text = row.Cells("CLASS").Value
                txtStudentID.Text = row.Cells("S_ID").Value
                txtStudentName.Text = row.Cells("NAME").Value
            ElseIf cboSearchBy.SelectedIndex = 3 Then
                DTgridStudent.DataSource = dt
                DTgridStudent.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        cboYear.Text = ""
    End Sub

    Private Sub cboSelected_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSelected.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()

        ''''''''''''''''''''''''''''''''''''''''''''''
        If cboSearchBy.SelectedIndex = 1 Then
            txtStudentName.Text = cboSelected.Text
            Try
                con.Open()
                query = "select COURSE_YEAR,CLASS,S_ID,NAME from RoomAllotment where NAME like '" + cboSelected.Text + "' and ROOM_ID<>'' "
                Dim cmd As New OleDbCommand(query, con)
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                While reader.Read
                    cboYear.Text = reader(0).ToString
                    txtClass.Text = reader(1).ToString
                    txtStudentName.Text = reader(3).ToString
                    txtStudentID.Text = reader(2).ToString
                End While
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        ElseIf cboSearchBy.SelectedIndex = 0 Then
            Try
                con.Open()
                query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboSelected.Text + "'"
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
            cboClass.Text = cboSelected.Text
        End If



        Try
            con.Open()
            If cboSearchBy.SelectedIndex = 1 Then
                query = "select S_ID,NAME,CLASS,CONTACT,PHOTO,FATHERS_NAME,FATHERS_CONTACT,ROOM_ID,BED_ID from RoomAllotment where NAME like '" + cboSelected.Text + "';"
            ElseIf cboSearchBy.SelectedIndex = 0 Then
                query = "select S_ID,NAME,CLASS,CONTACT,PHOTO,FATHERS_NAME,FATHERS_CONTACT,ROOM_ID,BED_ID from RoomAllotment where CLASS like '" + cboSelected.Text + "';"
            End If

            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cboClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClass.SelectedIndexChanged
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
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
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
    Dim st As String = ""
    Dim st1 As String = ""

    Private Sub txtStudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentID.TextChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        MsgBox(DateAndTime.Today)
        Try
            con.Open()
            query = "SELECT last(DailyAttendance.Check_Mode) as Check_Mode FROM DailyAttendance Where Attendance_date=? and DailyAttendance.S_ID=?;"
            'query = "SELECT last(DailyAttendance.S_ID) as S_ID,Last(DailyAttendance.Attendance_date) as Attendance_date ,last(DailyAttendance.Check_Mode) as Check_Mode  FROM DailyAttendance GROUP BY S_ID having last(DailyAttendance.Attendance_date)=Format(?,""DD/MM/YYYY"") and last(DailyAttendance.S_ID)=?;"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@dtim", DateAndTime.Today)
            cmd.Parameters.AddWithValue("@sid", Val(txtStudentID.Text))
            cmd.ExecuteNonQuery()
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                st1 = reader(0).ToString
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        ''''''''''''''''''''''
        MsgBox(st1)

        If st1 = "Check out" Then
            MetroLabel1.Text = "Not yet at hostel"
        ElseIf st1 = "Check in" Then
            Try
                con.Open()
                query = "SELECT last(CHECK_MODE) as Status FROM StudentAttendance where S_ID=? And DATE_TIME=?;"
                ' query = "SELECT Last(StudentAttendance.S_ID) AS S_ID, Last(StudentAttendance.CLASS) AS CLASS, Last(StudentAttendance.COURSE_YEAR) AS COURSE_YEAR,last(DATE_TIME) AS dateT,last(CHECK_MODE) as Status FROM StudentAttendance GROUP BY S_ID having Last(StudentAttendance.CLASS)=? And Last(StudentAttendance.COURSE_YEAR)='I-year' and last(DATE_TIME)=#02-11-2017# and Last(StudentAttendance.S_ID)=?;"
                Dim cmd1 As New OleDbCommand(query, con)
                ' cmd1.Parameters.AddWithValue("@st", txtClass.Text)
                '  cmd1.Parameters.AddWithValue("@year", cboYear.Text)
                cmd1.Parameters.AddWithValue("@sid", Val(txtStudentID.Text))
                cmd1.Parameters.AddWithValue("@date", DateTime.Today)
                cmd1.ExecuteNonQuery()
                Dim reader1 As OleDbDataReader = cmd1.ExecuteReader
                While reader1.Read
                    st = reader1(0).ToString
                End While
                reader1.Close()
                cmd1.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            MsgBox(st)
            If st = "Check IN" Then
                MetroLabel1.Text = ""
                MetroLabel1.Text = "Present in hostel"
            ElseIf st = "" Then
                MetroLabel1.Text = ""
                MetroLabel1.Text = "Present in hostel"
            ElseIf st = "Check OUT" Then
                MetroLabel1.Text = ""
                MetroLabel1.Text = "Not yet at hostel"
            End If
        End If
    End Sub
    '''----------------------------------------------- Search or Find Student --------------------------------------------------------- 
    Private Sub btnFindStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindStudent.Click
        If DTgridStudent.RowCount >= 0 Then
            'data grid store first column then row i.e. [j,i] format
            'currentrow used to selcet the value of current clicked row
            Dim myimagebyte() As Byte = DTgridStudent.Item(4, DTgridStudent.CurrentRow.Index).Value
            Dim memstream As New MemoryStream(myimagebyte)
            PictureBox1.Image = Image.FromStream(memstream)            'load picture for memory stream
        End If

        If cboSearchBy.SelectedIndex = 0 Then
            querycomplete = "where CLASS like '" + cboSelected.Text + "' and COURSE_YEAR='" + cboYear.Text + "' and ROOM_ID<>'';"
        ElseIf cboSearchBy.SelectedIndex = 1 Then
            querycomplete = "where NAME like '" + cboSelected.Text + "' and ROOM_ID<>'';"
        ElseIf cboSearchBy.SelectedIndex = 2 Then
            querycomplete = "where S_ID like '" + cboSelected.Text + "' and ROOM_ID<>'' ;"
        End If

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment " + querycomplete
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            adptr.Dispose()
            DTgridStudent.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txtClass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClass.TextChanged

    End Sub

    Private Sub DTgridStudent_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTgridStudent.CellContentClick

    End Sub
End Class