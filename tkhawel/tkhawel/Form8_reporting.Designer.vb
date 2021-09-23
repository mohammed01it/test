<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8_reporting
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
        Me.DataSet1 = New tkhawel.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_adres_rep = New System.Windows.Forms.TextBox()
        Me.but8rep = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.but_return_serch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id_c = New System.Windows.Forms.TextBox()
        Me.txt_no_c = New System.Windows.Forms.TextBox()
        Me.dtp1_f8 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2_f8 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_exut_tkh = New System.Windows.Forms.TextBox()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fiest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t4_cart4TableAdapter = New tkhawel.DataSet1TableAdapters.t4_cart4TableAdapter()
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't4_cart4BindingSource
        '
        Me.t4_cart4BindingSource.DataMember = "t4_cart4"
        Me.t4_cart4BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t4_cart4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "tkhawel.Report1_book8.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 736)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_adres_rep
        '
        Me.txt_adres_rep.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adres_rep.Location = New System.Drawing.Point(6, 100)
        Me.txt_adres_rep.Multiline = True
        Me.txt_adres_rep.Name = "txt_adres_rep"
        Me.txt_adres_rep.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_adres_rep.Size = New System.Drawing.Size(228, 46)
        Me.txt_adres_rep.TabIndex = 1
        Me.txt_adres_rep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'but8rep
        '
        Me.but8rep.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.but8rep.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but8rep.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but8rep.ForeColor = System.Drawing.Color.Black
        Me.but8rep.Location = New System.Drawing.Point(194, 662)
        Me.but8rep.Name = "but8rep"
        Me.but8rep.Size = New System.Drawing.Size(95, 32)
        Me.but8rep.TabIndex = 2
        Me.but8rep.Text = "بحث"
        Me.but8rep.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.but_return_serch)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_id_c)
        Me.GroupBox1.Controls.Add(Me.txt_no_c)
        Me.GroupBox1.Controls.Add(Me.dtp1_f8)
        Me.GroupBox1.Controls.Add(Me.dtp2_f8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_exut_tkh)
        Me.GroupBox1.Controls.Add(Me.txt_last)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_fiest)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_adres_rep)
        Me.GroupBox1.Controls.Add(Me.but8rep)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1012, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 736)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات التصفية"
        '
        'but_return_serch
        '
        Me.but_return_serch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.but_return_serch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_return_serch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_return_serch.ForeColor = System.Drawing.Color.Black
        Me.but_return_serch.Location = New System.Drawing.Point(57, 662)
        Me.but_return_serch.Name = "but_return_serch"
        Me.but_return_serch.Size = New System.Drawing.Size(95, 32)
        Me.but_return_serch.TabIndex = 20
        Me.but_return_serch.Text = "الغاء البحث"
        Me.but_return_serch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(196, 478)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "رقم شاصي العجلة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(254, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "رقم العجلة"
        '
        'txt_id_c
        '
        Me.txt_id_c.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_c.Location = New System.Drawing.Point(6, 474)
        Me.txt_id_c.Name = "txt_id_c"
        Me.txt_id_c.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_id_c.Size = New System.Drawing.Size(187, 26)
        Me.txt_id_c.TabIndex = 17
        Me.txt_id_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_no_c
        '
        Me.txt_no_c.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_c.Location = New System.Drawing.Point(6, 422)
        Me.txt_no_c.Name = "txt_no_c"
        Me.txt_no_c.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_no_c.Size = New System.Drawing.Size(187, 26)
        Me.txt_no_c.TabIndex = 16
        Me.txt_no_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtp1_f8
        '
        Me.dtp1_f8.CalendarFont = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dtp1_f8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dtp1_f8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1_f8.Location = New System.Drawing.Point(6, 272)
        Me.dtp1_f8.Name = "dtp1_f8"
        Me.dtp1_f8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp1_f8.Size = New System.Drawing.Size(187, 26)
        Me.dtp1_f8.TabIndex = 15
        '
        'dtp2_f8
        '
        Me.dtp2_f8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2_f8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2_f8.Location = New System.Drawing.Point(6, 324)
        Me.dtp2_f8.Name = "dtp2_f8"
        Me.dtp2_f8.Size = New System.Drawing.Size(187, 26)
        Me.dtp2_f8.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(233, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "منظم التخويل"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(243, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "التاريخ الاخير"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(249, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "التاريخ الاول"
        '
        'txt_exut_tkh
        '
        Me.txt_exut_tkh.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exut_tkh.Location = New System.Drawing.Point(6, 371)
        Me.txt_exut_tkh.Name = "txt_exut_tkh"
        Me.txt_exut_tkh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_exut_tkh.Size = New System.Drawing.Size(187, 26)
        Me.txt_exut_tkh.TabIndex = 10
        Me.txt_exut_tkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_last
        '
        Me.txt_last.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last.Location = New System.Drawing.Point(6, 225)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_last.Size = New System.Drawing.Size(187, 26)
        Me.txt_last.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(235, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = " التخويل الاول"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(234, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "التخويل الاخير"
        '
        'txt_fiest
        '
        Me.txt_fiest.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fiest.Location = New System.Drawing.Point(4, 177)
        Me.txt_fiest.Name = "txt_fiest"
        Me.txt_fiest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_fiest.Size = New System.Drawing.Size(189, 26)
        Me.txt_fiest.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(154, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " عنوان التقرير"
        '
        't4_cart4TableAdapter
        '
        Me.t4_cart4TableAdapter.ClearBeforeFill = True
        '
        'Form8_reporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form8_reporting"
        Me.Text = "شاشة طباعة تقرير جداول للعجلات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.t4_cart4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t4_cart4BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents t4_cart4TableAdapter As DataSet1TableAdapters.t4_cart4TableAdapter
    Friend WithEvents txt_adres_rep As TextBox
    Friend WithEvents but8rep As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_fiest As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_last As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_exut_tkh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp1_f8 As DateTimePicker
    Friend WithEvents dtp2_f8 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id_c As TextBox
    Friend WithEvents txt_no_c As TextBox
    Friend WithEvents but_return_serch As Button
End Class
