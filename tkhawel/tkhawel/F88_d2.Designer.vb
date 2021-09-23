<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F88_d2
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
        Me.t3_selaht3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet4_f88_do2 = New tkhawel.DataSet4_f88_do2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_f88_n_d2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_no_selah_f88 = New System.Windows.Forms.TextBox()
        Me.txt_n_selah_f88 = New System.Windows.Forms.TextBox()
        Me.txt_add_emplo_f88 = New System.Windows.Forms.TextBox()
        Me.txt2_do2_f88 = New System.Windows.Forms.TextBox()
        Me.txt1_do2_f88 = New System.Windows.Forms.TextBox()
        Me.dtp2_do2_f88 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1_do2_f88 = New System.Windows.Forms.DateTimePicker()
        Me.but_ser_selah_f88 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.t3_selaht3TableAdapter = New tkhawel.DataSet4_f88_do2TableAdapters.t3_selaht3TableAdapter()
        CType(Me.t3_selaht3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4_f88_do2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't3_selaht3BindingSource
        '
        Me.t3_selaht3BindingSource.DataMember = "t3_selaht3"
        Me.t3_selaht3BindingSource.DataSource = Me.DataSet4_f88_do2
        '
        'DataSet4_f88_do2
        '
        Me.DataSet4_f88_do2.DataSetName = "DataSet4_f88_do2"
        Me.DataSet4_f88_do2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cb_f88_n_d2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_no_selah_f88)
        Me.GroupBox1.Controls.Add(Me.txt_n_selah_f88)
        Me.GroupBox1.Controls.Add(Me.txt_add_emplo_f88)
        Me.GroupBox1.Controls.Add(Me.txt2_do2_f88)
        Me.GroupBox1.Controls.Add(Me.txt1_do2_f88)
        Me.GroupBox1.Controls.Add(Me.dtp2_do2_f88)
        Me.GroupBox1.Controls.Add(Me.dtp1_do2_f88)
        Me.GroupBox1.Controls.Add(Me.but_ser_selah_f88)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1018, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 743)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات التصفية"
        '
        'cb_f88_n_d2
        '
        Me.cb_f88_n_d2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_f88_n_d2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_f88_n_d2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_f88_n_d2.FormattingEnabled = True
        Me.cb_f88_n_d2.Location = New System.Drawing.Point(6, 469)
        Me.cb_f88_n_d2.Name = "cb_f88_n_d2"
        Me.cb_f88_n_d2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_f88_n_d2.Size = New System.Drawing.Size(211, 27)
        Me.cb_f88_n_d2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "الغاء البحث"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_no_selah_f88
        '
        Me.txt_no_selah_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_selah_f88.Location = New System.Drawing.Point(6, 410)
        Me.txt_no_selah_f88.Name = "txt_no_selah_f88"
        Me.txt_no_selah_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_no_selah_f88.Size = New System.Drawing.Size(211, 27)
        Me.txt_no_selah_f88.TabIndex = 15
        '
        'txt_n_selah_f88
        '
        Me.txt_n_selah_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n_selah_f88.Location = New System.Drawing.Point(6, 350)
        Me.txt_n_selah_f88.Name = "txt_n_selah_f88"
        Me.txt_n_selah_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_n_selah_f88.Size = New System.Drawing.Size(211, 27)
        Me.txt_n_selah_f88.TabIndex = 14
        '
        'txt_add_emplo_f88
        '
        Me.txt_add_emplo_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_emplo_f88.Location = New System.Drawing.Point(6, 297)
        Me.txt_add_emplo_f88.Name = "txt_add_emplo_f88"
        Me.txt_add_emplo_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_add_emplo_f88.Size = New System.Drawing.Size(211, 27)
        Me.txt_add_emplo_f88.TabIndex = 13
        '
        'txt2_do2_f88
        '
        Me.txt2_do2_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2_do2_f88.Location = New System.Drawing.Point(6, 142)
        Me.txt2_do2_f88.Name = "txt2_do2_f88"
        Me.txt2_do2_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt2_do2_f88.Size = New System.Drawing.Size(211, 27)
        Me.txt2_do2_f88.TabIndex = 12
        '
        'txt1_do2_f88
        '
        Me.txt1_do2_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1_do2_f88.Location = New System.Drawing.Point(6, 93)
        Me.txt1_do2_f88.Name = "txt1_do2_f88"
        Me.txt1_do2_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt1_do2_f88.Size = New System.Drawing.Size(211, 27)
        Me.txt1_do2_f88.TabIndex = 11
        '
        'dtp2_do2_f88
        '
        Me.dtp2_do2_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2_do2_f88.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2_do2_f88.Location = New System.Drawing.Point(6, 243)
        Me.dtp2_do2_f88.Name = "dtp2_do2_f88"
        Me.dtp2_do2_f88.Size = New System.Drawing.Size(211, 27)
        Me.dtp2_do2_f88.TabIndex = 10
        '
        'dtp1_do2_f88
        '
        Me.dtp1_do2_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1_do2_f88.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1_do2_f88.Location = New System.Drawing.Point(6, 191)
        Me.dtp1_do2_f88.Name = "dtp1_do2_f88"
        Me.dtp1_do2_f88.Size = New System.Drawing.Size(211, 27)
        Me.dtp1_do2_f88.TabIndex = 9
        '
        'but_ser_selah_f88
        '
        Me.but_ser_selah_f88.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_ser_selah_f88.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_ser_selah_f88.Location = New System.Drawing.Point(197, 622)
        Me.but_ser_selah_f88.Name = "but_ser_selah_f88"
        Me.but_ser_selah_f88.Size = New System.Drawing.Size(93, 33)
        Me.but_ser_selah_f88.TabIndex = 8
        Me.but_ser_selah_f88.Text = "بحث"
        Me.but_ser_selah_f88.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(229, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "صاحب التخويل"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "رقم السلاح"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "اسم السلاح"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "منظم التخويل"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "التاريخ الاخير"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "التاريخ الاول"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "التخويل الاخير"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "التخويل الاول"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t3_selaht3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "tkhawel.Report4_f88_do2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1010, 743)
        Me.ReportViewer1.TabIndex = 1
        '
        't3_selaht3TableAdapter
        '
        Me.t3_selaht3TableAdapter.ClearBeforeFill = True
        '
        'F88_d2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F88_d2"
        Me.Text = "شاشة طباعة تخويل السلاح"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.t3_selaht3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4_f88_do2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents but_ser_selah_f88 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_no_selah_f88 As TextBox
    Friend WithEvents txt_n_selah_f88 As TextBox
    Friend WithEvents txt_add_emplo_f88 As TextBox
    Friend WithEvents txt2_do2_f88 As TextBox
    Friend WithEvents txt1_do2_f88 As TextBox
    Friend WithEvents dtp2_do2_f88 As DateTimePicker
    Friend WithEvents dtp1_do2_f88 As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t3_selaht3BindingSource As BindingSource
    Friend WithEvents DataSet4_f88_do2 As DataSet4_f88_do2
    Friend WithEvents t3_selaht3TableAdapter As DataSet4_f88_do2TableAdapters.t3_selaht3TableAdapter
    Friend WithEvents cb_f88_n_d2 As ComboBox
    Friend WithEvents Button1 As Button
End Class
