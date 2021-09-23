<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form88_reporting2
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
        Me.DataSet3_f88_rep2 = New tkhawel.DataSet3_f88_rep2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_rep_form88_n = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.but_serch_selah = New System.Windows.Forms.Button()
        Me.txt_emp_add = New System.Windows.Forms.TextBox()
        Me.txt_no_selah = New System.Windows.Forms.TextBox()
        Me.txt_name_selah = New System.Windows.Forms.TextBox()
        Me.txt_last_f88 = New System.Windows.Forms.TextBox()
        Me.txt_first_f88 = New System.Windows.Forms.TextBox()
        Me.dtp2_f88 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1_f88 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1_title = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1_f88_rep2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.t3_selaht3TableAdapter = New tkhawel.DataSet3_f88_rep2TableAdapters.t3_selaht3TableAdapter()
        CType(Me.t3_selaht3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3_f88_rep2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't3_selaht3BindingSource
        '
        Me.t3_selaht3BindingSource.DataMember = "t3_selaht3"
        Me.t3_selaht3BindingSource.DataSource = Me.DataSet3_f88_rep2
        '
        'DataSet3_f88_rep2
        '
        Me.DataSet3_f88_rep2.DataSetName = "DataSet3_f88_rep2"
        Me.DataSet3_f88_rep2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cb_rep_form88_n)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.but_serch_selah)
        Me.GroupBox1.Controls.Add(Me.txt_emp_add)
        Me.GroupBox1.Controls.Add(Me.txt_no_selah)
        Me.GroupBox1.Controls.Add(Me.txt_name_selah)
        Me.GroupBox1.Controls.Add(Me.txt_last_f88)
        Me.GroupBox1.Controls.Add(Me.txt_first_f88)
        Me.GroupBox1.Controls.Add(Me.dtp2_f88)
        Me.GroupBox1.Controls.Add(Me.dtp1_f88)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt1_title)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1001, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 736)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات التصفية"
        '
        'cb_rep_form88_n
        '
        Me.cb_rep_form88_n.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_rep_form88_n.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_rep_form88_n.FormattingEnabled = True
        Me.cb_rep_form88_n.Location = New System.Drawing.Point(6, 333)
        Me.cb_rep_form88_n.Name = "cb_rep_form88_n"
        Me.cb_rep_form88_n.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_rep_form88_n.Size = New System.Drawing.Size(226, 27)
        Me.cb_rep_form88_n.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(36, 628)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "الغاء البحث"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'but_serch_selah
        '
        Me.but_serch_selah.BackColor = System.Drawing.Color.Maroon
        Me.but_serch_selah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_serch_selah.Location = New System.Drawing.Point(168, 628)
        Me.but_serch_selah.Name = "but_serch_selah"
        Me.but_serch_selah.Size = New System.Drawing.Size(103, 44)
        Me.but_serch_selah.TabIndex = 18
        Me.but_serch_selah.Text = "بحث"
        Me.but_serch_selah.UseVisualStyleBackColor = False
        '
        'txt_emp_add
        '
        Me.txt_emp_add.Location = New System.Drawing.Point(8, 482)
        Me.txt_emp_add.Name = "txt_emp_add"
        Me.txt_emp_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_emp_add.Size = New System.Drawing.Size(226, 27)
        Me.txt_emp_add.TabIndex = 17
        '
        'txt_no_selah
        '
        Me.txt_no_selah.Location = New System.Drawing.Point(8, 433)
        Me.txt_no_selah.Name = "txt_no_selah"
        Me.txt_no_selah.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_no_selah.Size = New System.Drawing.Size(226, 27)
        Me.txt_no_selah.TabIndex = 16
        '
        'txt_name_selah
        '
        Me.txt_name_selah.Location = New System.Drawing.Point(8, 382)
        Me.txt_name_selah.Name = "txt_name_selah"
        Me.txt_name_selah.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_name_selah.Size = New System.Drawing.Size(226, 27)
        Me.txt_name_selah.TabIndex = 15
        '
        'txt_last_f88
        '
        Me.txt_last_f88.Location = New System.Drawing.Point(8, 187)
        Me.txt_last_f88.Name = "txt_last_f88"
        Me.txt_last_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_last_f88.Size = New System.Drawing.Size(226, 27)
        Me.txt_last_f88.TabIndex = 13
        '
        'txt_first_f88
        '
        Me.txt_first_f88.Location = New System.Drawing.Point(8, 141)
        Me.txt_first_f88.Name = "txt_first_f88"
        Me.txt_first_f88.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_first_f88.Size = New System.Drawing.Size(226, 27)
        Me.txt_first_f88.TabIndex = 12
        '
        'dtp2_f88
        '
        Me.dtp2_f88.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2_f88.Location = New System.Drawing.Point(8, 283)
        Me.dtp2_f88.Name = "dtp2_f88"
        Me.dtp2_f88.Size = New System.Drawing.Size(226, 27)
        Me.dtp2_f88.TabIndex = 11
        '
        'dtp1_f88
        '
        Me.dtp1_f88.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1_f88.Location = New System.Drawing.Point(8, 233)
        Me.dtp1_f88.Name = "dtp1_f88"
        Me.dtp1_f88.Size = New System.Drawing.Size(226, 27)
        Me.dtp1_f88.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(244, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "منظم التخويل"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "رقم السلاح"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "اسم السلاح"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "صاحب التخويل"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "التاريخ الاخير"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "التاريخ الاول"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "التخويل الاخير"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "التخويل الاول"
        '
        'txt1_title
        '
        Me.txt1_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1_title.Location = New System.Drawing.Point(25, 57)
        Me.txt1_title.Multiline = True
        Me.txt1_title.Name = "txt1_title"
        Me.txt1_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt1_title.Size = New System.Drawing.Size(265, 62)
        Me.txt1_title.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "عنوان التقرير"
        '
        'ReportViewer1_f88_rep2
        '
        Me.ReportViewer1_f88_rep2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t3_selaht3BindingSource
        Me.ReportViewer1_f88_rep2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1_f88_rep2.LocalReport.ReportEmbeddedResource = "tkhawel.Report3_f88_rep2.rdlc"
        Me.ReportViewer1_f88_rep2.Location = New System.Drawing.Point(1, 3)
        Me.ReportViewer1_f88_rep2.Name = "ReportViewer1_f88_rep2"
        Me.ReportViewer1_f88_rep2.ServerReport.BearerToken = Nothing
        Me.ReportViewer1_f88_rep2.Size = New System.Drawing.Size(994, 736)
        Me.ReportViewer1_f88_rep2.TabIndex = 1
        '
        't3_selaht3TableAdapter
        '
        Me.t3_selaht3TableAdapter.ClearBeforeFill = True
        '
        'Form88_reporting2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.ReportViewer1_f88_rep2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form88_reporting2"
        Me.Text = "شاشة تقرير جداول السلاح"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.t3_selaht3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3_f88_rep2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReportViewer1_f88_rep2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt1_title As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_emp_add As TextBox
    Friend WithEvents txt_no_selah As TextBox
    Friend WithEvents txt_name_selah As TextBox
    Friend WithEvents txt_last_f88 As TextBox
    Friend WithEvents txt_first_f88 As TextBox
    Friend WithEvents dtp2_f88 As DateTimePicker
    Friend WithEvents dtp1_f88 As DateTimePicker
    Friend WithEvents but_serch_selah As Button
    Friend WithEvents t3_selaht3BindingSource As BindingSource
    Friend WithEvents DataSet3_f88_rep2 As DataSet3_f88_rep2
    Friend WithEvents t3_selaht3TableAdapter As DataSet3_f88_rep2TableAdapters.t3_selaht3TableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_rep_form88_n As ComboBox
End Class
