Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class F8_do1_p2

    Private max_id_p2 As Integer
    Private Max_dt_p2 As Date
    Private min_dt_p2 As Date
    Public stat_report_car As String
    Private Sub F8_do1_p2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2_d1_p2.t4_cart4' table. You can move, or remove it, as needed.
        ' Me.t4_cart4TableAdapter.Fill(Me.DataSet2_d1_p2.t4_cart4)
        Try
            txt_first_p2.Text = 1
            con.Open()
            cmd = New OleDb.OleDbCommand("Select max(ID),max(dt_book),min(dt_book) From t4_cart4", con)
            Dim zx_p2 As OleDb.OleDbDataReader = cmd.ExecuteReader
            zx_p2.Read()
            max_id_p2 = zx_p2(0)
            txt_last_p2.Text = zx_p2(0)
            Max_dt_p2 = zx_p2(1)
            dtp2_p2.Value = zx_p2(1)
            min_dt_p2 = zx_p2(2)
            dtp1_p2.Value = zx_p2(2)
            zx_p2.Close()

            con.Close()
            If stat_report_car = "one_d_car" Then
                adapter = New OleDb.OleDbDataAdapter("SELECT ID,dt_book, n_name, car_type, car_no, car_id, car_color, emplooy_add , end_dt
                                                           FROM     t4_cart4
                                                           WHERE ID=" & car_f4.txt1.Text, con)
                '                                              القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
                Dim DS As New DataSet

                adapter.Fill(DS, 0)
                'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
                '|vاسم الداتة تيبل الموجود بالداتة سيت|
                t4_cart4BindingSource.DataSource = DS.Tables(0)
                Me.ReportViewer1.Dock = DockStyle.Fill
                GroupBox1.Visible = False
            Else
                fillcb1ncar_f4()
                adapter = New OleDb.OleDbDataAdapter("SELECT ID , dt_book , n_name , car_type , car_no , car_id , car_color , emplooy_add , end_dt
                                                           FROM     t4_cart4 ", con)
                '                                              القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
                Dim DS As New DataSet

                adapter.Fill(DS, 0)
                'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
                '|vاسم الداتة تيبل الموجود بالداتة سيت|
                t4_cart4BindingSource.DataSource = DS.Tables(0)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("لا توجد تخاويل")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub but_serch_p2_Click(sender As Object, e As EventArgs) Handles but_serch_p2.Click
        'زر التصفية حسب الشروط المدخلة من يوزر
        'ينع ترك حقل التخويل الاول فارغ
        If txt_first_p2.Text = "" Then

            MsgBox("لايمكن ترك خانة التخويل الاول فارغ", MsgBoxStyle.Exclamation, "خطأ")
            txt_first_p2.Text = 1
            txt_first_p2.SelectAll()
            Exit Sub
        End If
        'ينع ترك حقل التخويل الاخير فارغ
        If txt_last_p2.Text = "" Then

            MsgBox("لايمكن ترك خانة التخويل الاخير فارغ :-", MsgBoxStyle.Exclamation, "خطأ")
            txt_last_p2.Text = max_id_p2
            txt_last_p2.SelectAll()
            Exit Sub
        End If



        'يمنع اخيار لالتخويل الاول اقل من واحد
        If txt_first_p2.Text < 1 Then
            txt_first_p2.SelectAll()
            MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt_first_p2.Text = 1
            Exit Sub
        End If

        'يمنع اخيار لتخويل الاخير اقل من واحد
        If txt_last_p2.Text < 1 Then
            txt_last_p2.SelectAll()
            MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")

            txt_last_p2.Text = max_id_p2
            Exit Sub
        End If


        'يمنع استخدام الرقم الاول قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_first_p2.Text > max_id_p2 Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id_p2, MsgBoxStyle.Exclamation, "خطأ")
            txt_first_p2.Text = max_id_p2
            Exit Sub
        End If

        'يمنع استخدام الرقم الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If txt_last_p2.Text > max_id_p2 Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id_p2, MsgBoxStyle.Exclamation, "خطأ")
            txt_last_p2.Text = max_id_p2
            Exit Sub
        End If


        'يمنع استخدام التاريخ  الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If dtp2_p2.Value > Max_dt_p2 Then

            MsgBox("اكبر تاريخ موجود هو :-" & Max_dt_p2, MsgBoxStyle.Exclamation, "خطأ")
            dtp2_p2.Value = Max_dt_p2
            Exit Sub
        End If
        adapter = New OleDbDataAdapter("SELECT        ID , dt_book , n_name , car_type , car_no , car_id , car_color , end_dt , emplooy_add
                                        From t4_cart4
                                        Where (ID BETWEEN @fiest_2 And @last_2)
                                          And (dt_book BETWEEN ? And ?)
                                          And (n_name Like '%' + ? + '%')
                                          AND (car_no LIKE '%' + ? + '%')
                                          AND (car_id LIKE '%' + ? + '%')
                                          AND (emplooy_add Like '%' + ? + '%')", con)
        adapter.SelectCommand.Parameters.AddWithValue("@fiest_2", txt_first_p2.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@last_2", txt_last_p2.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@dpt1_2", dtp1_p2.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@dpt2_2", dtp2_p2.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@n_2", cb_n_p2.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@nocar_2", txt_no_p2.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@idcar_2", txt_id_p2.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@emp_ad_2", txt_exut_p2.Text)
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t4_cart4BindingSource.DataSource = DS.Tables(0)
        'لكي نقوم بعمل زوم للريبورت
        ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fillcb1ncar_f4()
        adapter = New OleDb.OleDbDataAdapter("SELECT ID , dt_book , n_name , car_type , car_no , car_id , car_color , emplooy_add , end_dt
                                                           FROM     t4_cart4 ", con)
        '                                              القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t4_cart4BindingSource.DataSource = DS.Tables(0)
        Me.ReportViewer1.RefreshReport()
        txt_first_p2.Text = 1
        txt_last_p2.Text = max_id_p2
        dtp2_p2.Value = Max_dt_p2
        dtp1_p2.Value = min_dt_p2
        txt_exut_p2.Clear()
        txt_no_p2.Clear()
        txt_id_p2.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class