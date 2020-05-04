<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AeroForm
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RoomAllotmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet6 = New Hostel_Mangement.DataSet6()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RoomAllotmentTableAdapter = New Hostel_Mangement.DataSet6TableAdapters.RoomAllotmentTableAdapter()
        CType(Me.RoomAllotmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoomAllotmentBindingSource
        '
        Me.RoomAllotmentBindingSource.DataMember = "RoomAllotment"
        Me.RoomAllotmentBindingSource.DataSource = Me.DataSet6
        '
        'DataSet6
        '
        Me.DataSet6.DataSetName = "DataSet6"
        Me.DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet6"
        ReportDataSource3.Value = Me.RoomAllotmentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hostel_Mangement.ReportViewerStudentIndividualDetails.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 112)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(986, 332)
        Me.ReportViewer1.TabIndex = 0
        '
        'RoomAllotmentTableAdapter
        '
        Me.RoomAllotmentTableAdapter.ClearBeforeFill = True
        '
        'AeroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1010, 456)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.Name = "AeroForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Fix_soft_Aero_Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RoomAllotmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RoomAllotmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet6 As Hostel_Mangement.DataSet6
    Friend WithEvents RoomAllotmentTableAdapter As Hostel_Mangement.DataSet6TableAdapters.RoomAllotmentTableAdapter



End Class
