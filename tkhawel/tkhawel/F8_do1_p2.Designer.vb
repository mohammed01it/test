<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F8_do1_p2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.t4_cart4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2_d1_p2 = New tkhawel.DataSet2_d1_p2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_first_p2 = New System.Windows.Forms.TextBox()
        Me.txt_last_p2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_exut_p2 = New System.Windows.Forms.TextBox()
        Me.txt_no_p2 = New System.Windows.Forms.TextBox()
        Me.txt_id_p2 = New System.Windows.Forms.TextBox()
        Me.but_serch_p2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_n_p2 = New System.Windows.Forms.ComboBox()
        Me.dtp2_p2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1_p2 = New System.Windows.Forms.DateTimePicker()
        Me.t4_cart4TableAdapter = New tkhawel.DataSet2_d1_p2TableAdapters.t4_cart4TableAdapter()
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2_d1_p2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't4_cart4BindingSource
        '
        Me.t4_cart4BindingSource.DataMember = "t4_cart4"
        Me.t4_cart4BindingSource.DataSource = Me.DataSet2_d1_p2
        '
        'DataSet2_d1_p2
        '
        Me.DataSet2_d1_p2.DataSetName = "DataSet2_d1_p2"
        Me.DataSet2_d1_p2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t4_cart4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "tkhawel.Report2_do1_p2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 745)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_first_p2
        '
        Me.txt_first_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_first_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_p2.Location = New System.Drawing.Point(35, 77)
        Me.txt_first_p2.Name = "txt_first_p2"
        Me.txt_first_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_first_p2.Size = New System.Drawing.Size(235, 27)
        Me.txt_first_p2.TabIndex = 1
        '
        'txt_last_p2
        '
        Me.txt_last_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_last_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last_p2.Location = New System.Drawing.Point(35, 130)
        Me.txt_last_p2.Name = "txt_last_p2"
        Me.txt_last_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_last_p2.Size = New System.Drawing.Size(235, 27)
        Me.txt_last_p2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(328, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "التخويل الاول"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(322, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "التخويل الاخير"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(337, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "التاريخ الاول"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(331, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "التاريخ الاخير"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(321, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "منظم التخويل"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(304, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "رقم العجلة / ID"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(281, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "رقم شاصي العجلة"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(315, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "صاحب التخويل"
        '
        'txt_exut_p2
        '
        Me.txt_exut_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_exut_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exut_p2.Location = New System.Drawing.Point(35, 291)
        Me.txt_exut_p2.Name = "txt_exut_p2"
        Me.txt_exut_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_exut_p2.Size = New System.Drawing.Size(235, 27)
        Me.txt_exut_p2.TabIndex = 13
        '
        'txt_no_p2
        '
        Me.txt_no_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_no_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_p2.Location = New System.Drawing.Point(35, 347)
        Me.txt_no_p2.Name = "txt_no_p2"
        Me.txt_no_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_no_p2.Size = New System.Drawing.Size(235, 27)
        Me.txt_no_p2.TabIndex = 14
        '
        'txt_id_p2
        '
        Me.txt_id_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_p2.Location = New System.Drawing.Point(35, 402)
        Me.txt_id_p2.Name = "txt_id_p2"
        Me.txt_id_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_id_p2.Size = New System.Drawing.Size(235, 27)
        Me.txt_id_p2.TabIndex = 15
        '
        'but_serch_p2
        '
        Me.but_serch_p2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.but_serch_p2.BackColor = System.Drawing.Color.Lime
        Me.but_serch_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_serch_p2.Location = New System.Drawing.Point(243, 594)
        Me.but_serch_p2.Name = "but_serch_p2"
        Me.but_serch_p2.Size = New System.Drawing.Size(102, 38)
        Me.but_serch_p2.TabIndex = 17
        Me.but_serch_p2.Text = "بحث"
        Me.but_serch_p2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cb_n_p2)
        Me.GroupBox1.Controls.Add(Me.dtp2_p2)
        Me.GroupBox1.Controls.Add(Me.dtp1_p2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.but_serch_p2)
        Me.GroupBox1.Controls.Add(Me.txt_id_p2)
        Me.GroupBox1.Controls.Add(Me.txt_no_p2)
        Me.GroupBox1.Controls.Add(Me.txt_exut_p2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_last_p2)
        Me.GroupBox1.Controls.Add(Me.txt_first_p2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(929, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 745)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات التصفية"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(88, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "الغاء البحث"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cb_n_p2
        '
        Me.cb_n_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_n_p2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_n_p2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_n_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_n_p2.FormattingEnabled = True
        Me.cb_n_p2.Location = New System.Drawing.Point(35, 458)
        Me.cb_n_p2.Name = "cb_n_p2"
        Me.cb_n_p2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_n_p2.Size = New System.Drawing.Size(235, 27)
        Me.cb_n_p2.TabIndex = 20
        '
        'dtp2_p2
        '
        Me.dtp2_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp2_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2_p2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2_p2.Location = New System.Drawing.Point(35, 238)
        Me.dtp2_p2.Name = "dtp2_p2"
        Me.dtp2_p2.Size = New System.Drawing.Size(235, 27)
        Me.dtp2_p2.TabIndex = 19
        '
        'dtp1_p2
        '
        Me.dtp1_p2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp1_p2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1_p2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1_p2.Location = New System.Drawing.Point(35, 187)
        Me.dtp1_p2.Name = "dtp1_p2"
        Me.dtp1_p2.Size = New System.Drawing.Size(235, 27)
        Me.dtp1_p2.TabIndex = 18
        '
        't4_cart4TableAdapter
        '
        Me.t4_cart4TableAdapter.ClearBeforeFill = True
        '
        'F8_do1_p2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F8_do1_p2"
        Me.Text = "شاشة طباعة تخويل العجلات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2_d1_p2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t4_cart4BindingSource As BindingSource
    Friend WithEvents DataSet2_d1_p2 As DataSet2_d1_p2
    Friend WithEvents t4_cart4TableAdapter As DataSet2_d1_p2TableAdapters.t4_cart4TableAdapter
    Friend WithEvents txt_first_p2 As TextBox
    Friend WithEvents txt_last_p2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_exut_p2 As TextBox
    Friend WithEvents txt_no_p2 As TextBox
    Friend WithEvents txt_id_p2 As TextBox
    Friend WithEvents but_serch_p2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp2_p2 As DateTimePicker
    Friend WithEvents dtp1_p2 As DateTimePicker
    Friend WithEvents cb_n_p2 As ComboBox
    Friend WithEvents Button1 As Button
End Class
