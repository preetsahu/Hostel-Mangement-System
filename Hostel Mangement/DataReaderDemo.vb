Imports System.Data.OleDb

Public Class DataReaderDemo
    Dim query As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        con = connect()
        Try
            con.Open()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataReaderDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con = connect()
        Try
            con.Open()
            query = "SELECT c.city_id, c.city_name, s.statename FROM state AS s INNER JOIN city AS c ON c.stateid = '" + Val(TextBox1.Text) + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                'TextBox1.Text = reader("city_id").ToString
                TextBox3.Text = reader("statename").ToString
                TextBox3.Text = reader("city_name").ToString
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class