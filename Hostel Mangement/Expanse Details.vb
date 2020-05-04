Imports System.Data.OleDb
Imports System.Data
Public Class Expanse_Details
    Dim query As String
    Dim qc As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()

        '------------------------------------------------------- INSERT -----------------------------------------------------
        Try
            con.Open()
            query = "insert into ExapanseDetails(Expanse_Date,Expanse_Category,DESCRIPTION,AMOUNT,BILL_NUMBER) values (?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", dtExpanse.Text)
            cmd.Parameters.AddWithValue("?", mtExpType.Text)
            cmd.Parameters.AddWithValue("?", txtExpDescription.Text)
            cmd.Parameters.AddWithValue("?", txtAmount.Text)
            cmd.Parameters.AddWithValue("?", txtBillno.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Expanse of Date " + dtExpanse.Text + " is sucessfully saved of category : " + mtExpType.Text)
            clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub clear()
        txtAmount.Text = ""
        txtBillno.Text = ""
        mtExpType.Text = ""
        txtExpDescription.Text = ""
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Expanse_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class