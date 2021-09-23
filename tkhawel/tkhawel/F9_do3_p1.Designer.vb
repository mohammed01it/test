<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F9_do3_p1
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.t4_cart4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet5_f9_d3 = New tkhawel.DataSet5_f9_d3()
        Me.t4_cart4TableAdapter = New tkhawel.DataSet5_f9_d3TableAdapters.t4_cart4TableAdapter()
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet5_f9_d3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet5_d3_f9"
        ReportDataSource2.Value = Me.t4_cart4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "tkhawel.Report5_f9_d3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(893, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        't4_cart4BindingSource
        '
        Me.t4_cart4BindingSource.DataMember = "t4_cart4"
        Me.t4_cart4BindingSource.DataSource = Me.DataSet5_f9_d3
        '
        'DataSet5_f9_d3
        '
        Me.DataSet5_f9_d3.DataSetName = "DataSet5_f9_d3"
        Me.DataSet5_f9_d3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't4_cart4TableAdapter
        '
        Me.t4_cart4TableAdapter.ClearBeforeFill = True
        '
        'F9_do3_p1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F9_do3_p1"
        Me.Text = "شاشة طباعة التخويل وبديله"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet5_f9_d3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t4_cart4BindingSource As BindingSource
    Friend WithEvents DataSet5_f9_d3 As DataSet5_f9_d3
    Friend WithEvents t4_cart4TableAdapter As DataSet5_f9_d3TableAdapters.t4_cart4TableAdapter
End Class
