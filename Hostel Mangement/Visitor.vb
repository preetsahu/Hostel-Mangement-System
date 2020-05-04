Imports System.Data
Imports System.Data.OleDb
Public Class Visitor
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hms\hms.accdb")
    Dim Query As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Visitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            Query = "SELECT r.CLASS,r.NAME,v.IN_DATE_TIME,v.VISITORS_NAME,v.VISITORS_RELATION,v.VISITORS_ADDRESS,v.VISITORS_CONTACT,v.PURPOSE,v.OUT_DATE_TIME " _
                    + "FROM RoomAllotment r INNER JOIN Visitors v ON r.S_ID = v.S_ID;"

            da = New OleDbDataAdapter(Query, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            con.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hms\hms.accdb"
            con.Open()
            Query = "insert into Visitors (S_ID,IN_DATE_TIME,VISITORS_NAME,VISITORS_RELATION,VISITORS_ADDRESS,VISITORS_CONTACT,PURPOSE,OUT_DATE_TIME) values (@id,@inDT,@vName,@vRelation,@vAdd,@vContact,@vPurpose,@outDT)"
            cmd.CommandText = Query
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@id", Val(txtStudentID.Text))
            cmd.Parameters.AddWithValue("@inDT", Convert.ToDateTime(DTPickerIN.Value.ToString))
            cmd.Parameters.AddWithValue("@vName", txtVisitorname.Text)
            cmd.Parameters.AddWithValue("@vRelation", txtVisitorRelation.Text)
            cmd.Parameters.AddWithValue("@vAdd", txtVisitorAddress.Text)
            cmd.Parameters.AddWithValue("@vContact", txtVisitorContact.Text)
            cmd.Parameters.AddWithValue("@vPurpose", txtVisitorPurpose.Text)
            cmd.Parameters.AddWithValue("@outDT", Convert.ToDateTime(DTPickerOUT.Value.ToString))
            cmd.ExecuteNonQuery()
            ' refreshdatalist()
            con.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub refreshdatalist()
        ' If Not con.State = ConnectionState.Open Then
        'open connection
        '  con.Open()
        ' End If
        '  Dim da As New OleDb.OleDbDataAdapter("select * from Visitors", con)
        ' Dim dt As New DataTable
        'fill data to database
        ' da.Fill(dt)

        'offer data in data table into datagrid
        '  Me.DataGridView1.DataSource = dt
        ' con.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.VisitorsTableAdapter.Fill(Me.HmsDataSet.Visitors)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function VisitorsTableAdapter() As Object
        Throw New NotImplementedException
    End Function

    Private Function HmsDataSet() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class