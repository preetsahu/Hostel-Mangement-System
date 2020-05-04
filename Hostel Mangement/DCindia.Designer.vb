<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DCindia
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
        Dim WebBrowser1 As System.Windows.Forms.WebBrowser
        WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        WebBrowser1.Location = New System.Drawing.Point(0, 0)
        WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        WebBrowser1.Name = "WebBrowser1"
        WebBrowser1.Size = New System.Drawing.Size(901, 389)
        WebBrowser1.TabIndex = 0
        WebBrowser1.Url = New System.Uri("http://www.dcindia.in/", System.UriKind.Absolute)
        WebBrowser1.WebBrowserShortcutsEnabled = False
        AddHandler WebBrowser1.DocumentCompleted, AddressOf Me.WebBrowser1_DocumentCompleted_1
        '
        'DCindia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 389)
        Me.Controls.Add(WebBrowser1)
        Me.Name = "DCindia"
        Me.Text = "DCindia"
        Me.ResumeLayout(False)

    End Sub
End Class
