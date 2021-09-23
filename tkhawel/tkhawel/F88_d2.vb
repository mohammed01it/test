Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class F88_d2
    Private max_id_do2 As Integer
    Private Max_dt_do2 As Date
    Private min_dt_do2 As Date
    Public stat_report_selah As String
    Private Sub F88_d2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4_f88_do2.t3_selaht3' table. You can move, or remove it, as needed.
        ' Me.t3_selaht3TableAdapter.Fill(Me.DataSet4_f88_do2.t3_selaht3)
        Try
            txt1_do2_f88.Text = 1
            con.Open()
            cmd = New OleDb.OleDbCommand("Select max(ID_3),max(dt_selahtt3),min(dt_selahtt3) From t3_selaht3", con)
            Dim zx_do2 As OleDb.OleDbDataReader = cmd.ExecuteReader
            zx_do2.Read()
            max_id_do2 = zx_do2(0)
            txt2_do2_f88.Text = zx_do2(0)
            Max_dt_do2 = zx_do2(1)
            dtp2_do2_f88.Value = zx_do2(1)
            min_dt_do2 = zx_do2(2)
            dtp1_do2_f88.Value = zx_do2(2)
            zx_do2.Close()
            con.Close()
            If stat_report_selah = "one_d_selah" Then
                adapter = New OleDb.OleDbDataAdapter("SELECT  ID_3, dt_selahtt3, add_emplooyt3, selah_no3, selah_name3, n_tkhoel3, dt_end3
                                                           FROM     t3_selaht3
                                                           WHERE ID_3=" & selah_f5.txt1_f5_s.Text, con)
                '                                              القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها
                Dim DS As New DataSet

                adapter.Fill(DS, 0)
                'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
                '|vاسم الداتة تيبل الموجود بالداتة سيت|
                t3_selaht3BindingSource.DataSource = DS.Tables(0)
                Me.ReportViewer1.Dock = DockStyle.Fill
                GroupBox1.Visible = False
            Else
                fillcb1ncar_f4()
                adapter = New OleDb.OleDbDataAdapter("SELECT        ID_3, dt_selahtt3, add_emplooyt3, selah_no3, selah_name3, n_tkhoel3, dt_end3
                                              From t3_selaht3", con)
                Dim DS As New DataSet

                adapter.Fill(DS, 0)
                'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
                '|vاسم الداتة تيبل الموجود بالداتة سيت|
                t3_selaht3BindingSource.DataSource = DS.Tables(0)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("لا توجد تخاويل")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub but_ser_selah_f88_Click(sender As Object, e As EventArgs) Handles but_ser_selah_f88.Click
        'زر التصفية حسب الشروط المدخلة من يوزر
        'ينع ترك حقل التخويل الاول فارغ
        If txt1_do2_f88.Text = "" Then
            '  MsgBox("لايمكن ترك خانة التخويل الاول فارغ", MsgBoxStyle.Exclamation, "خطأ")
            txt1_do2_f88.Text = 1
            txt1_do2_f88.SelectAll()
            Exit Sub
        End If
        'ينع ترك حقل التخويل الاخير فارغ
        If txt2_do2_f88.Text = "" Then
            '  MsgBox("لايمكن ترك خانة التخويل الاخير فارغ :-", MsgBoxStyle.Exclamation, "خطأ")
            txt2_do2_f88.Text = max_id_do2
            txt2_do2_f88.SelectAll()
            Exit Sub
        End If



        'يمنع اخيار لالتخويل الاول اقل من واحد
        If txt1_do2_f88.Text < 1 Then
            txt1_do2_f88.SelectAll()
            MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")
            txt1_do2_f88.Text = 1
            Exit Sub
        End If

        'يمنع اخيار لتخويل الاخير اقل من واحد
        If txt2_do2_f88.Text < 1 Then
            txt2_do2_f88.SelectAll()
            MsgBox("لايمكن اختيار تخويل اقل من واحد", MsgBoxStyle.Exclamation, "خطأ")

            txt2_do2_f88.Text = max_id_do2
            Exit Sub
        End If


        'يمنع استخدام الرقم الاول قيمة اكبرمن الموجود في قاعدة البيانات
        If txt1_do2_f88.Text > max_id_do2 Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id_do2, MsgBoxStyle.Exclamation, "خطأ")
            txt1_do2_f88.Text = max_id_do2
            Exit Sub
        End If

        'يمنع استخدام الرقم الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If txt2_do2_f88.Text > max_id_do2 Then

            MsgBox("اكبر رقم تخويل موجود هو :-" & max_id_do2, MsgBoxStyle.Exclamation, "خطأ")
            txt2_do2_f88.Text = max_id_do2
            Exit Sub
        End If
        'يمنع استخدام التاريخ  الاخير قيمة اكبرمن الموجود في قاعدة البيانات
        If dtp2_do2_f88.Value > Max_dt_do2 Then

            MsgBox("اكبر تاريخ موجود هو :-" & Max_dt_do2, MsgBoxStyle.Exclamation, "خطأ")
            dtp2_do2_f88.Value = Max_dt_do2
            Exit Sub
        End If
        adapter = New OleDbDataAdapter("SELECT        ID_3, dt_selahtt3, add_emplooyt3, selah_no3, selah_name3, n_tkhoel3, dt_end3
                                        FROM            t3_selaht3
                                        WHERE        (ID_3 BETWEEN ? AND ?) AND (dt_selahtt3 BETWEEN ? AND ?) AND (add_emplooyt3 LIKE '%' + ? + '%')
                                          AND (selah_no3 LIKE '%' + ? + '%')  AND (selah_name3 LIKE '%' + ? + '%') AND (n_tkhoel3 LIKE '%' + ? + '%')", con)
        adapter.SelectCommand.Parameters.AddWithValue("@t1_f88", txt1_do2_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@t2_f88", txt2_do2_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("d1_f88", dtp1_do2_f88.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@d2_f88", dtp2_do2_f88.Value.Date)
        adapter.SelectCommand.Parameters.AddWithValue("@add_f88", txt_add_emplo_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@no_f88", txt_no_selah_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@name", txt_n_selah_f88.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@n", cb_f88_n_d2.Text)
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t3_selaht3BindingSource.DataSource = DS.Tables(0)
        'لكي نقوم بعمل زوم للريبورت
        ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fillcb1ncar_f4()
        adapter = New OleDb.OleDbDataAdapter("SELECT        ID_3, dt_selahtt3, add_emplooyt3, selah_no3, selah_name3, n_tkhoel3, dt_end3
                                              From t3_selaht3", con)
        Dim DS As New DataSet
        adapter.Fill(DS, 0)
        'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
        '|vاسم الداتة تيبل الموجود بالداتة سيت|
        t3_selaht3BindingSource.DataSource = DS.Tables(0)
        Me.ReportViewer1.RefreshReport()
        txt1_do2_f88.Text = 1
        txt2_do2_f88.Text = max_id_do2
        dtp1_do2_f88.Value = min_dt_do2
        dtp2_do2_f88.Value = Max_dt_do2
        txt_add_emplo_f88.Clear()
        txt_n_selah_f88.Clear()
        txt_no_selah_f88.Clear()
    End Sub
End Class