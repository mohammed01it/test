Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class Form88_reporting2
    Private max_3id As Integer
    Private max_3dt As Date
    Private min_3dt As Date
    Private Sub Form88_reporting2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3_f88_rep2.t3_selaht3' table. You can move, or remove it, as needed.
        ' Me.t3_selaht3TableAdapter.Fill(Me.DataSet3_f88_rep2.t3_selaht3)
        Try
            txt_first_f88.Text = 1
            con.Open()
            cmd = New OleDb.OleDbCommand("Select max(ID_3),max(dt_selahtt3),min(dt_selahtt3) From t3_selaht3", con)
            Dim zx As OleDb.OleDbDataReader = cmd.ExecuteReader
            zx.Read()
            max_3id = zx(0)
            txt_last_f88.Text = zx(0)
            max_3dt = zx(1)
            dtp2_f88.Value = zx(1)
            min_3dt = zx(2)
            dtp1_f88.Value = zx(2)
            zx.Close()
            con.Close()
            fillcb1ncar_f4()
            adapter = New OleDb.OleDbDataAdapter("SELECT ID_3, n_tkhoel3, selah_name3, selah_no3 , dt_selahtt3 , add_emplooyt3, dt_end3 
                                              FROM     t3_selaht3", con)
            '                                                                      القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
            Dim DS As New DataSet

            adapter.Fill(DS, 0)
            'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
            '|vاسم الداتة تيبل الموجود بالداتة سيت|
            t3_selaht3BindingSource.DataSource = DS.Tables(0)
            Dim addre As New ReportParameter("RP1_report_title", My.Settings.us)
            ReportViewer1_f88_rep2.LocalReport.SetParameters(addre)
            Me.ReportViewer1_f88_rep2.RefreshReport()
        Catch ex As Exception
            MsgBox("لا توجد تقارير")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ReportViewer1_f88_rep2_Load(sender As Object, e As EventArgs) Handles ReportViewer1_f88_rep2.Load

    End Sub

    Private Sub but_serch_selah_Click(sender As Object, e As EventArgs) Handles but_serch_selah.Click
        'زر التصفية حسب الشروط المدخلة من يوزر
        'ينع ترك حقل التخويل الاول فارغ
        If txt_first_f88.Text = "" Then
            ' MsgBox("لايمكن ترك خانة التخويل الاول فارغ", MsgBoxStyle.Exclamation, "خطأ")
            txt_first_f88.Text = 1
            txt_first_f88.SelectAll()
            Exit Sub
        End If
        'ينع ترك حقل التخويل الاخير فارغ
        If txt_last_f88.Text = "" Then
            '  MsgBox("لايمكن ترك خانة التخويل الاخير فارغ :-", MsgBoxStyle.Exclamation, "خطأ")
            txt_last_f88.Text = max_3id
            txt_last_f88.SelectAll()
            Exit Sub
        End If
        'يمنع اخيار لالتخويل الاول اقل من واحد
        If txt_first_f88.Text < 1 Then
            txt_first_f88.SelectAll()
            ' MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt_first_f88.Text = 1
            Exit Sub
        End If
        'يمنع اخيار لتخويل الاخير اقل من واحد
        If txt_last_f88.Text < 1 Then
            txt_last_f88.SelectAll()
            ' MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt_last_f88.Text = max_3id
            Exit Sub
        End If
        'يمنع استخدام الرقم الاول قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_first_f88.Text > max_3id Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_3id, MsgBoxStyle.Exclamation, "خطأ")
            txt_first_f88.Text = max_3id
            Exit Sub
        End If
        'يمنع استخدام الرقم الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_last_f88.Text > max_3id Then
            MsgBox("اكبر رقم تخويل موجود هو :-" & max_3id, MsgBoxStyle.Exclamation, "خطأ")
            txt_last_f88.Text = max_3id
            Exit Sub
        End If
        'يمنع استخدام التاريخ  الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If dtp2_f88.Value > max_3dt Then
            MsgBox("اكبر تاريخ موجود هو :-" & max_3dt, MsgBoxStyle.Exclamation, "خطأ")
            dtp2_f88.Value = max_3dt
            Exit Sub
        End If
        If txt1_title.Text = "" Then
            txt1_title.Text = "لم يتم ادخال عنوان للتقرير"
        End If

        adapter = New OleDbDataAdapter("Select ID_3, dt_selahtt3, add_emplooyt3, selah_no3, selah_name3, n_tkhoel3, dt_end3
                                             From t3_selaht3
                                             Where (ID_3 BETWEEN @first_f88 And @last_f88) And (dt_selahtt3 BETWEEN @f88_dt1 And @f88_dt2) And (add_emplooyt3 Like '%' + e + '%')
                                                                          AND (selah_no3 LIKE '%' + o + '%') AND (selah_name3 Like '%' + ns + '%')
                                                                          AND (n_tkhoel3 LIKE '%' + n + '%')", con)
        adapter.SelectCommand.Parameters.AddWithValue("@first_f88", txt_first_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@last_f88", txt_last_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@f88_dt1", dtp1_f88.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@f88_dt2", dtp2_f88.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("e", txt_emp_add.Text)
        adapter.SelectCommand.Parameters.AddWithValue("o", txt_no_selah.Text)
        adapter.SelectCommand.Parameters.AddWithValue("ns", txt_name_selah.Text)
        adapter.SelectCommand.Parameters.AddWithValue("n", cb_rep_form88_n.Text)
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        '-------------------نرسل عنوان التقرير ببرميتر الى التقرير -----------------------
        t3_selaht3BindingSource.DataSource = DS.Tables(0)
        Dim addre As New ReportParameter("rp2_title_f88", txt1_title.Text)
        ReportViewer1_f88_rep2.LocalReport.SetParameters(addre)
        ' Me.ReportViewer1.ZoomPercent = 150
        Me.ReportViewer1_f88_rep2.RefreshReport()


    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adapter = New OleDb.OleDbDataAdapter("SELECT ID_3, n_tkhoel3, selah_name3, selah_no3 , dt_selahtt3 , add_emplooyt3, dt_end3 
                                              FROM     t3_selaht3", con)
        '                                                                      القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
        Dim DS As New DataSet

        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t3_selaht3BindingSource.DataSource = DS.Tables(0)
        Dim addre As New ReportParameter("RP1_report_title", My.Settings.us)
        ReportViewer1_f88_rep2.LocalReport.SetParameters(addre)
        Me.ReportViewer1_f88_rep2.RefreshReport()
        txt1_title.Clear()
        txt_first_f88.Text = 1
        txt_last_f88.Text = max_3id
        dtp1_f88.Value = min_3dt
        dtp2_f88.Value = max_3dt
        txt_name_selah.Clear()
        txt_no_selah.Clear()
        fillcb1ncar_f4()
        txt_emp_add.Clear()
    End Sub
End Class