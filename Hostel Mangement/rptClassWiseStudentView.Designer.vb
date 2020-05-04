<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptClassWiseStudentView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet2 = New Hostel_Mangement.DataSet2()
        Me.RoomAllotmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomAllotmentTableAdapter = New Hostel_Mangement.DataSet2TableAdapters.RoomAllotmentTableAdapter()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomAllotmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.RoomAllotmentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hostel_Mangement.ReportViewerClasswiseStudentList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(770, 354)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomAllotmentBindingSource
        '
        Me.RoomAllotmentBindingSource.DataMember = "RoomAllotment"
        Me.RoomAllotmentBindingSource.DataSource = Me.DataSet2
        '
        'RoomAllotmentTableAdapter
        '
        Me.RoomAllotmentTableAdapter.ClearBeforeFill = True
        '
        'rptClassWiseStudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 354)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptClassWiseStudentView"
        Me.Text = "Classwise Student View"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomAllotmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RoomAllotmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As Hostel_Mangement.DataSet2
    Friend WithEvents RoomAllotmentTableAdapter As Hostel_Mangement.DataSet2TableAdapters.RoomAllotmentTableAdapter
End Class
