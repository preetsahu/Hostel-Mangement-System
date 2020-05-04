Imports System.Data.OleDb

Public Class VisitorEntry
    Dim query As String
    Dim rowcount As Integer
    Dim querycomplete As String
    Private Sub dataGridRefresh()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from VisitorDetails "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            DTgridVisitorDetail.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If con.State = ConnectionState.Closed And Not txtVisitorName.Text = "" And Not txtVisitorAddress.Text = "" And Not txtVisitorContact.Text = "" And Not txtVisitorID.Text = "" Then
            Try
                con.Open()
                query = "update VisitorDetails set VISITORS_NAME = ?,VISITORS_ADDRESS = ?,VISITORS_CONTACT = ? where VISITOR_ID = ?;"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("vname", txtVisitorName.Text)
                cmd.Parameters.AddWithValue("vaddress", txtVisitorAddress.Text)
                cmd.Parameters.AddWithValue("Vcontact", txtVisitorContact.Text)
                cmd.Parameters.AddWithValue("Vid", Val(txtVisitorID.Text))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        ElseIf con.State = ConnectionState.Closed And Not cboVid.Text = "" Then
            Try
                con.Open()
                query = "insert into VisitorDetails (VISITOR_ID,VISITORS_NAME,VISITORS_ADDRESS,VISITORS_CONTACT) values(?,?,?,?)"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", Val(cboVid.Text))
                cmd.Parameters.AddWithValue("?", txtVisitorName.Text)
                cmd.Parameters.AddWithValue("?", txtVisitorAddress.Text)
                cmd.Parameters.AddWithValue("?", txtVisitorContact.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                txtVisitorID.Text = ""
                txtVisitorName.Text = ""
                txtVisitorContact.Text = ""
                txtVisitorAddress.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
        dataGridRefresh()
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''' load '''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub VisitorEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        cboVid.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from VisitorDetails "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboVid.DataSource = dt
            cboVid.DisplayMember = "VISITOR_ID"
            DTgridVisitorDetail.DataSource = dt
            ''''''''''''''''''''''''''''''''''''''''''''''''' sort grid data''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DTgridVisitorDetail.Sort(DTgridVisitorDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            adptr.Dispose()
            rowcount = dt.Rows.Count - 1                    'used to count number of records in visiterDetails table 
            txtVisitorID.Text = dt.Rows(rowcount).Item(0)
            cboVid.Text = dt.Rows(rowcount).Item(0)
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        gridFormat()
        clear()
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''' grid format ;;'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub gridFormat()
        DTgridVisitorDetail.GridColor = Color.Aqua
        DTgridVisitorDetail.BackgroundColor = Color.LightGray
        DTgridVisitorDetail.CellBorderStyle = DataGridViewCellBorderStyle.None
        DTgridVisitorDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DTgridVisitorDetail.DefaultCellStyle.SelectionBackColor = Color.Cyan
        DTgridVisitorDetail.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        DTgridVisitorDetail.RowsDefaultCellStyle.BackColor = Color.Bisque
        DTgridVisitorDetail.AllowUserToResizeRows = False
        DTgridVisitorDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update VisitorDetails set VISITORS_NAME = ?,VISITORS_ADDRESS = ?,VISITORS_CONTACT = ? where VISITOR_ID = ?;"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("vname", txtVisitorName.Text)
            cmd.Parameters.AddWithValue("vaddress", txtVisitorAddress.Text)
            cmd.Parameters.AddWithValue("Vcontact", txtVisitorContact.Text)
            cmd.Parameters.AddWithValue("Vid", Val(txtVisitorID.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        clear()
        dataGridRefresh()
        gridFormat()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtVisitorID.Text = "" And txtVisitorName.Text = "" Then
            MsgBox("Enter Visitor ID or Name Which you want to  remove")
            Dim response As String = MsgBox("Enter Visitor ID or Name Which you want to  remove", vbOKCancel)
            If response = vbOK Then
                txtVisitorID.Text = ""
                txtVisitorID.Focus()
            End If
        End If

        If Not txtVisitorID.Text = "" Then
            querycomplete = "where VISITOR_ID like '" + txtVisitorID.Text + "';"
        ElseIf Not txtVisitorName.Text = "" Then
            querycomplete = "where VISITORS_NAME like '" + Trim(txtVisitorName.Text) + "';"
        End If

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "delete from VisitorDetails " + querycomplete
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        clear()
        dataGridRefresh()
        gridFormat()
    End Sub
    Private Sub DTgridVisitorDetail_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Dim row As DataGridViewRow = DTgridVisitorDetail.CurrentRow
            txtVisitorID.Text = row.Cells("VISITOR_ID").Value.ToString
            txtVisitorName.Text = row.Cells("VISITORS_NAME").Value.ToString
            txtVisitorContact.Text = row.Cells("VISITORS_CONTACT").Value.ToString
            txtVisitorAddress.Text = row.Cells("VISITORS_ADDRESS").Value.ToString
            cboVid.Text = row.Cells("VISITOR_ID").Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        VisitingDetail.DataRefresh()
        VisitingDetail.DTgridVisitor.Refresh()
        'VisitingDetail.Show()
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''' subroutine comboIndexChanged ''''''''''''''''''''''''''''''''''''
    Private Sub comboIndexChange()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            Dim i As String = cboVid.Text
            If cboVid.Text = i Then
                query = "select * from VisitorDetails where VISITOR_ID like '" + cboVid.Text + "'"
                Dim adptr As New OleDbDataAdapter(query, con)
                Dim dt As New DataTable
                adptr.Fill(dt)
                txtVisitorName.Text = dt.Rows(0).Item(1)
                txtVisitorAddress.Text = dt.Rows(0).Item(2)
                txtVisitorContact.Text = dt.Rows(0).Item(3)
                txtVisitorID.Text = dt.Rows(0).Item(0)
                adptr.Dispose()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboVid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVid.SelectedIndexChanged
        comboIndexChange()
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''' clear subroutine ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub clear()
        cboVid.Text = ""
        txtVisitorID.Text = ""
        txtVisitorName.Text = ""
        txtVisitorContact.Text = ""
        txtVisitorAddress.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear()
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select max(VISITOR_ID) FROM VisitorDetails"
            Dim cmd As New OleDbCommand(query, CON)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                cboVid.Text = reader(0) + 1
            End While
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub '
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''' validation ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub txtVisitorName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVisitorName.KeyPress
        'If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
        '    e.Handled = True
        '    MsgBox("Name Doesn't contain alphabet", MsgBoxStyle.MsgBoxRtlReading)
        'End If
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
    Private Sub txtVisitorContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVisitorContact.KeyPress
        'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '    e.Handled = True
        '    MessageBox.Show("enter valid mobile number")
        'End If
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtVisitorID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVisitorID.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboVid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVid.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub
End Class