Public Class rptListOfWentStudents

    Private Sub rptListOfWentStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet5.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet5.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class