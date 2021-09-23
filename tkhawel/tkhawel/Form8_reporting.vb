Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class Form8_reporting
    Private max_id As Integer
    Private Max_dt As Date
    Private min_dt As Date
    Private Sub Form8_reporting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.t4_cart4' table. You can move, or remove it, as needed.
        'Me.t4_cart4TableAdapter.Fill(Me.DataSet1.t4_cart4)
        'نسند اعلى قيمة تخويل واعلى تاريخ موجودات في قاعدة البيانات الى متغيرات لحفظ القيمة
        Try
            txt_fiest.Text = 1
            con.Open()
            cmd = New OleDb.OleDbCommand("Select max(ID),max(dt_book),min(dt_book) From t4_cart4", con)
            Dim zx As OleDb.OleDbDataReader = cmd.ExecuteReader
            zx.Read()
            max_id = zx(0)
            txt_last.Text = zx(0)
            Max_dt = zx(1)
            dtp2_f8.Value = zx(1)
            min_dt = zx(2)
            dtp1_f8.Value = zx(2)
            zx.Close()
            con.Close()
            adapter = New OleDb.OleDbDataAdapter("SELECT ID, n_name, car_type, car_no, car_id, car_color, end_dt, emplooy_add, dt_book, walet_address, replace_name
                                              FROM     t4_cart4", con)
            '                                                                      القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
            Dim DS As New DataSet

            adapter.Fill(DS, 0)
            'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
            '|vاسم الداتة تيبل الموجود بالداتة سيت|
            t4_cart4BindingSource.DataSource = DS.Tables(0)
            'نرسل اسم المستخدم ببرميتر الى منظم التقرير
            'القيمة المرسلة للبرميتر'     اسم البرميتر الموجود داخل تصميم الريبورت فيور    
            Dim emp_exut As New ReportParameter("rp2_emp_exut", My.Settings.us)
            ReportViewer1.LocalReport.SetParameters(emp_exut)
            ' Me.ReportViewer1.ZoomPercent = 120
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("لا توجد تقارير")
        Finally
            con.Close()
        End Try

    End Sub



    Private Sub but8rep_Click(sender As Object, e As EventArgs) Handles but8rep.Click
        'زر التصفية حسب الشروط المدخلة من يوزر
        'ينع ترك حقل التخويل الاول فارغ
        If txt_fiest.Text = "" Then
            ' MsgBox("لايمكن ترك خانة التخويل الاول فارغ", MsgBoxStyle.Exclamation, "خطأ")
            txt_fiest.Text = 1
            txt_fiest.SelectAll()
            Exit Sub
        End If
        'ينع ترك حقل التخويل الاخير فارغ
        If txt_last.Text = "" Then
            ' MsgBox("لايمكن ترك خانة التخويل الاخير فارغ :-", MsgBoxStyle.Exclamation, "خطأ")
            txt_last.Text = max_id
            txt_last.SelectAll()
            Exit Sub
        End If
        'يمنع اخيار لالتخويل الاول اقل من واحد
        If txt_fiest.Text < 1 Then
            txt_fiest.SelectAll()
            ' MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt_fiest.Text = 1
            Exit Sub
        End If
        'يمنع اخيار لتخويل الاخير اقل من واحد
        If txt_last.Text < 1 Then
            txt_last.SelectAll()
            '  MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt_last.Text = max_id
            Exit Sub
        End If
        'يمنع استخدام الرقم الاول قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_fiest.Text > max_id Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id, MsgBoxStyle.Exclamation, "خطأ")
            txt_fiest.Text = max_id
            Exit Sub
        End If
        'يمنع استخدام الرقم الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_last.Text > max_id Then
            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id, MsgBoxStyle.Exclamation, "خطأ")
            txt_last.Text = max_id
            Exit Sub
        End If
        'يمنع استخدام التاريخ  الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If dtp2_f8.Value > Max_dt Then
            MsgBox("اكبر تاريخ موجود هو :-" & Max_dt, MsgBoxStyle.Exclamation, "خطأ")
            dtp2_f8.Value = Max_dt
            Exit Sub
        End If
        If txt_adres_rep.Text = "" Then
            txt_adres_rep.Text = "لم يتم ادخال عنوان للتقرير"
        End If
        adapter = New OleDbDataAdapter("SELECT        ID, n_name, car_type, car_no, car_id, car_color, end_dt, emplooy_add, dt_book
                                        FROM            t4_cart4
                                        WHERE        (ID BETWEEN @last AND  @fiest) AND (emplooy_add LIKE '%' + ? + '%') AND (dt_book BETWEEN ? AND ?) AND (car_id LIKE '%' + @idcar + '%') AND (car_no LIKE '%' + @nocar + '%') ", con)
        adapter.SelectCommand.Parameters.AddWithValue("@fiest", txt_fiest.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@last", txt_last.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@emp_ad", txt_exut_tkh.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@dpt1", dtp1_f8.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@dpt2", dtp2_f8.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@idcar", txt_id_c.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@nocar", txt_no_c.Text)
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        '-------------------نرسل عنوان التقرير ببرميتر الى التقرير -----------------------
        t4_cart4BindingSource.DataSource = DS.Tables(0)
        Dim addres As New ReportParameter("RP1_report_addres", txt_adres_rep.Text)
        ReportViewer1.LocalReport.SetParameters(addres)
        ' Me.ReportViewer1.ZoomPercent = 150
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtp2_f8_ValueChanged(sender As Object, e As EventArgs) Handles dtp2_f8.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles but_return_serch.Click
        adapter = New OleDb.OleDbDataAdapter("SELECT ID, n_name, car_type, car_no, car_id, car_color, end_dt, emplooy_add, dt_book, walet_address
                                              FROM     t4_cart4", con)
        '                                                                      القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
        Dim DS As New DataSet

        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t4_cart4BindingSource.DataSource = DS.Tables(0)
        'نرسل اسم المستخدم ببرميتر الى منظم التقرير
        'القيمة المرسلة للبرميتر'     اسم البرميتر الموجود داخل تصميم الريبورت فيور    
        Dim emp_exut As New ReportParameter("rp2_emp_exut", My.Settings.us)
        ReportViewer1.LocalReport.SetParameters(emp_exut)
        ' Me.ReportViewer1.ZoomPercent = 120
        Me.ReportViewer1.RefreshReport()
        txt_fiest.Text = 1
        txt_last.Text = max_id
        dtp1_f8.Value = min_dt
        dtp2_f8.Value = Max_dt
        txt_adres_rep.Clear()
        txt_exut_tkh.Clear()
        txt_no_c.Clear()
        txt_id_c.Clear()
    End Sub
End Class