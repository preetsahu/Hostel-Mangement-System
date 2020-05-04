Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design.ToolboxItem
Public Class StudentCurrentStatus
    Dim query As String
    Dim i As Integer = 0
    Dim st1 As String = ""
    Dim st As String = ""
    Private Sub CurrentAvailability()
        Dim con As OleDbConnection
        con = connectTOhms()
        Dim LINE As Integer = 1
        Try
            con.Open()
            query = "select NAME,S_ID,CONTACT,CLASS,COURSE_YEAR from RoomAllotment where ROOM_ID <> ''"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            Dim space As Integer
            space = 70
            While reader.Read
                If i Mod 3 = 1 Then
                    space = 30
                    LINE = LINE + 1
                ElseIf i Mod 3 = 2 Then
                    space = 390
                Else
                    space = 750
                End If
                Dim lblRoom As New Label
                lblRoom.Name = "lbl" & i
                lblRoom.Size = New Size(340, 25)
                lblRoom.Location = New Point(space, LINE * 30)
                lblRoom.Text = reader(0).ToString + " Student ID : " + reader(1).ToString + " Class : " + reader(3).ToString + reader(4).ToString + ""
                lblRoom.BackColor = Color.White
                lblRoom.ForeColor = Color.Black
                Me.Controls.Add(lblRoom)
                i = i + 1
                Dim sid As Integer = reader(1)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Try
                    Dim query1 = "SELECT last(DailyAttendance.Check_Mode) as Check_Mode FROM DailyAttendance Where Attendance_date=? and DailyAttendance.S_ID=?;"
                    Dim cmd1 As New OleDbCommand(query1, con)
                    cmd1.Parameters.AddWithValue("@dtim", DateAndTime.Today)
                    cmd1.Parameters.AddWithValue("@s1id", sid)
                    cmd1.ExecuteNonQuery()
                    Dim reader1 As OleDbDataReader = cmd1.ExecuteReader
                    While reader1.Read
                        st1 = reader1(0).ToString
                    End While
                    reader1.Close()
                    cmd1.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                End Try

                If st1 = "Check out" Then
                    lblRoom.BackColor = Color.Red
                    lblRoom.ForeColor = Color.White
                ElseIf st1 = "Check in" Then
                    Try
                        Dim query3 = "SELECT last(CHECK_MODE) as Status FROM StudentAttendance where S_ID=? And DATE_TIME=?;"
                        Dim cmd2 As New OleDbCommand(query3, con)
                        cmd2.Parameters.AddWithValue("@s2id", sid)
                        cmd2.Parameters.AddWithValue("@date", DateTime.Today)
                        cmd2.ExecuteNonQuery()
                        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
                        While reader2.Read
                            st = reader2(0).ToString
                        End While
                        reader2.Close()
                        cmd2.Dispose()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                    End Try

                    If st = "Check IN" Then
                        lblRoom.BackColor = Color.Green
                        lblRoom.ForeColor = Color.White
                    ElseIf st = "" Then
                        lblRoom.BackColor = Color.Green
                        lblRoom.ForeColor = Color.White
                    ElseIf st = "Check OUT" Then
                        lblRoom.BackColor = Color.Red
                        lblRoom.ForeColor = Color.White
                    End If
                End If

                '''''''''''''''''''''''''''''''''''''''
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub StudentCurrentStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            LoginForm.Hide()
            Me.Show()
            Me.Visible = True
        ElseIf loginAuthetication = 0 Then
            Me.Hide()
            LoginForm.Show()
        End If
        CurrentAvailability()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each ctrl In Me.Controls.OfType(Of Label)()
            ctrl.Hide()
        Next
        CurrentAvailability()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class