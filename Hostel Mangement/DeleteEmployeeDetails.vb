Imports System.Data.OleDb
Public Class DeleteEmployeeDetails
    Dim query As String
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "delete from EmployeeDetails where EMPLOYEE_ID =?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", cboEID.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Employee record deleted", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DeleteEmployeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            query = "select * from EmployeeDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboEID.DataSource = dt
            cboEID.DisplayMember = "EMPLOYEE_ID"
            cboWorkAS.DataSource = dt
            cboWorkAS.DisplayMember = "WORK_AS"
            cboEname.DataSource = dt
            cboEname.DisplayMember = "EMPLOYEE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboEID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEID.SelectedIndexChanged

    End Sub
End Class