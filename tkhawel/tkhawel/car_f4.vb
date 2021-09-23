Imports System.Data.OleDb

Public Class car_f4
    Dim caradd As String
    Dim idupdate As Integer

    Public Sub gen_new_code()
        'سب خاص بتوليد الكود الجديد وتنضيف التيكستات
        code_ge()
        txt1.Text = newid
        ComboBox1_ncar.Text = ""
        cb2_c_n_ct4.Text = ""
        txtnocar.Clear()
        txtidcar.Clear()
        cb3_color_cart4.Text = ""
        txt_walet_addr.Clear()
        DateTimePicker3.Value = Now.Date
        ComboBox1_ncar.Select()

    End Sub


    Private Sub butsacar_Click(sender As Object, e As EventArgs) Handles butsacar.Click


        'زر الحفظ
        If txt1.Text = "" Then
            MsgBox("يجب الضغط على زر " & vbNewLine & "(انشاء تخويل جديد)", MsgBoxStyle.Exclamation, "تنبية")
            Exit Sub
        End If
        If ComboBox1_ncar.Text = "" Then
            MsgBox("لايمكن ترك حقل الاسم فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            ComboBox1_ncar.Focus()
            Exit Sub
        End If
        If cb2_c_n_ct4.Text = "" Then
            MsgBox("لايمكن ترك حقل اسم العجلة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb2_c_n_ct4.Focus()
            Exit Sub
        End If
        If txtnocar.Text = "" Then
            If MsgBox("هل تريد اخال رقم العجلة", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then
                Exit Sub
            Else
                txtnocar.Text = "لايوجد"
                txtnocar.Focus()
            End If
        End If
        If txtidcar.Text = "" Then
            If MsgBox("هل تريد اخال رقم شاصي / ID العجلة", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then
                Exit Sub
            Else
                txtidcar.Text = "لايوجد"
                txtidcar.Focus()
            End If
        End If
        If cb3_color_cart4.Text = "" Then
            MsgBox("لايمكن ترك حقل لون العجللة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb3_color_cart4.Focus()
            Exit Sub
        End If
        If txt_walet_addr.Text = "" Then
            MsgBox("يجب ادخال عنوان الواجب", MsgBoxStyle.Exclamation, "تنبيه")
            txt_walet_addr.Focus()
            Exit Sub
        End If



        caradd = "Insert Into t4_cart4(ID,dt_book,n_name,car_type,car_no,car_id,car_color,end_dt,system_dt,emplooy_add,walet_address,replace_name)
                               values(@ID,@dt_book,@n_name,@car_type,@car_no,@car_id,@car_color,@end_dt,@system_dt,@emplooy_add,@walet_address,@replace_name)"
        cmd = New OleDbCommand(caradd, con)
        cmd.Parameters.Add(New OleDbParameter("@ID", OleDbType.VarChar)).Value = txt1.Text
        cmd.Parameters.Add(New OleDbParameter("@dt_book", OleDbType.Date)).Value = DateTimePicker1.Text
        cmd.Parameters.Add(New OleDbParameter("@n_name", OleDbType.VarChar)).Value = ComboBox1_ncar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_type", OleDbType.VarChar)).Value = cb2_c_n_ct4.Text
        cmd.Parameters.Add(New OleDbParameter("@car_no", OleDbType.VarChar)).Value = txtnocar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_id", OleDbType.VarChar)).Value = txtidcar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_color", OleDbType.VarChar)).Value = cb3_color_cart4.Text
        cmd.Parameters.Add(New OleDbParameter("@end_dt", OleDbType.Date)).Value = DateTimePicker3.Text
        cmd.Parameters.Add(New OleDbParameter("@system_dt", OleDbType.Date)).Value = DateTimePicker2.Text
        cmd.Parameters.Add(New OleDbParameter("@emplooy_add", OleDbType.VarChar)).Value = L1f4.Text
        cmd.Parameters.Add(New OleDbParameter("@walet_address", OleDbType.VarChar)).Value = txt_walet_addr.Text
        If CheckBox1.Checked = True Then
            cmd.Parameters.Add(New OleDbParameter("@replace_name", OleDbType.VarChar)).Value = cb2ncar_replace.Text
        Else
            cmd.Parameters.Add(New OleDbParameter("@replace_name", OleDbType.VarChar)).Value = "لا يوجد"
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        caradd = "update t5_name_emplooyt5 set id_name2 = @id_name2
                               where ID = " & ComboBox1_ncar.SelectedIndex + 1
        cmd = New OleDbCommand(caradd, con)
        cmd.Parameters.Add(New OleDbParameter("@id_name2", OleDbType.VarChar)).Value = txt1.Text
        cmd.ExecuteNonQuery()
        MsgBox("تم الحفظ بنجاح", MsgBoxStyle.Information, "ادخال التخويل")
        ' gen_new_code()
        con.Close()
        butsacar.Visible = False
        txt_print_car.Visible = True
        fillcb1_test()
        cb5_test.Visible = True
        Button1.Visible = True
        GroupBox2.Visible = True
        Label14.Text = ""
        Label16.Text = ""
        Label19.Text = ""
    End Sub

    Private Sub L1f4_Click(sender As Object, e As EventArgs) Handles L1f4.Click

    End Sub
    Sub fillcb1_test()
        Dim kml As DataTable = dt.Copy
        kml.Rows.Clear()
        adapter = New OleDbDataAdapter("select  n_emploe5 as [الاسم] , id_name2 as [2] from t5_name_emplooyt5", con)
        adapter.Fill(kml)
        cb5_test.DataSource = kml
        cb5_test.DisplayMember = "الاسم"
        cb5_test.ValueMember = "2"

    End Sub
    Private Sub car_f4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'code_ge()
        ' txt1.Text = newid
        txt_print_car.Visible = False
        L1f4.Text = My.Settings.us
        fillcb1_test()
    End Sub

    Sub fillcb2_c_n_c_t4()
        Dim cnct4 As New DataTable
        cnct4.Rows.Clear()
        adapter = New OleDbDataAdapter("select * from carname_cart4", con)
        adapter.Fill(cnct4)
        cb2_c_n_ct4.DataSource = cnct4
        cb2_c_n_ct4.DisplayMember = "c_n_ct4"
    End Sub
    Sub fillcb3_color_cart4()
        Dim cct4 As New DataTable
        cct4.Clear()
        adapter = New OleDbDataAdapter("select * from color_cart4", con)
        adapter.Fill(cct4)
        cb3_color_cart4.DataSource = cct4
        cb3_color_cart4.DisplayMember = "color_n_cart4"
    End Sub
    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        code_ge()
        txt1.Text = newid
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gen_new_code()
        fillcb1ncar_f4()
        fillcb2_c_n_c_t4()
        fillcb3_color_cart4()
        cb5_test.Visible = False
        Button1.Visible = False
        GroupBox2.Visible = False
        CheckBox1.Checked = False
        butsacar.Visible = True
        txt_print_car.Visible = False
        ComboBox1_ncar.SelectAll()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'زر التعديل
        If ComboBox1_ncar.Text = "" Then
            MsgBox("لايمكن ترك حقل الاسم فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            ComboBox1_ncar.Focus()
            Exit Sub
        End If
        If cb2_c_n_ct4.Text = "" Then
            MsgBox("لايمكن ترك حقل نوع العجلة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb2_c_n_ct4.Focus()
            Exit Sub
        End If
        If cb3_color_cart4.Text = "" Then
            MsgBox("لايمكن ترك حقل لون العجلة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb3_color_cart4.Focus()
            Exit Sub
        End If
        '  شرط  تحقق هل تريد الالغاء بالفعل فاذا ضغط  نعم سوفة ينفذ والا لابفعل شئ
        If MsgBox("هل انت متاكد من تعديل هذة البيانات", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        cmd = New OleDb.OleDbCommand("Delete from t4_cart4 where ID = " & f6_db_car.DGV_car.CurrentRow.Cells(0).Value, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        caradd = "Insert Into t4_cart4(ID,dt_book,n_name,car_type,car_no,car_id,car_color,end_dt,system_dt,emplooy_add,walet_address,replace_name)
                               values(@ID,@dt_book,@n_name,@car_type,@car_no,@car_id,@car_color,@end_dt,@system_dt,@emplooy_add,@walet_address,@replace_name)"
        cmd = New OleDbCommand(caradd, con)
        cmd.Parameters.Add(New OleDbParameter("@ID", OleDbType.VarChar)).Value = txt1.Text
        cmd.Parameters.Add(New OleDbParameter("@dt_book", OleDbType.Date)).Value = DateTimePicker1.Text
        cmd.Parameters.Add(New OleDbParameter("@n_name", OleDbType.VarChar)).Value = ComboBox1_ncar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_type", OleDbType.VarChar)).Value = cb2_c_n_ct4.Text
        cmd.Parameters.Add(New OleDbParameter("@car_no", OleDbType.VarChar)).Value = txtnocar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_id", OleDbType.VarChar)).Value = txtidcar.Text
        cmd.Parameters.Add(New OleDbParameter("@car_color", OleDbType.VarChar)).Value = cb3_color_cart4.Text
        cmd.Parameters.Add(New OleDbParameter("@end_dt", OleDbType.Date)).Value = DateTimePicker3.Text
        cmd.Parameters.Add(New OleDbParameter("@system_dt", OleDbType.Date)).Value = DateTimePicker2.Text
        cmd.Parameters.Add(New OleDbParameter("@emplooy_add", OleDbType.VarChar)).Value = main_f3.L1f3.Text
        cmd.Parameters.Add(New OleDbParameter("@walet_address", OleDbType.VarChar)).Value = txt_walet_addr.Text
        cmd.Parameters.Add(New OleDbParameter("@replace_name", OleDbType.VarChar)).Value = cb2ncar_replace.Text
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("تم التعديل بنجاح", MsgBoxStyle.Information, "التعديل")
        Fillcontans()
        ' Me.Close()
        con.Close()
    End Sub

    Private Sub txt_print_car_Click(sender As Object, e As EventArgs) Handles txt_print_car.Click
        If CheckBox1.Checked = True Then
            F9_do3_p1.Show()
            F9_do3_p1.ReportViewer1.RefreshReport()
        Else
            F8_do1_p2.stat_report_car = "one_d_car"
            F8_do1_p2.Show()
            F8_do1_p2.ReportViewer1.RefreshReport()
        End If
        ' F8_do1_p2.ReportViewer1.Dock = DockStyle.Fill
    End Sub
    Private Sub cb1ncar_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub txttypecar_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        'زر فحص يمتلك تخويل ام لا

        Try
            Label14.Text = ""
            Label16.Text = ""
            Label19.Text = ""
            Label14.Visible = False
            Label16.Visible = False
            Label19.Visible = False
            Dim aa = Now.Date
            cmd = New OleDbCommand("select * from t4_cart4 where ID = " & cb5_test.SelectedValue, con)
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim dateEnd As Date
                dateEnd = dr("end_dt")
                Dim n_rep As String = dr("replace_name")
                ' Label11.Text = dateEnd
                '  dr.Close()
                'يجيك اذا تخويل القديم اكبر من تاريخ اليوم يظهر مسج انه يمتلك تخويل نافذ
                If dateEnd > Now.Date.ToShortDateString Then
                    Label14.Visible = True
                    Label16.Visible = True
                    Label14.Text = "يمتلك تخويل نافذ ينتهي في     " & dateEnd
                    Label16.Text = "عدد الايام المتبقية للنفاذ     " & (dateEnd - aa).Days & "يوم   "
                    If n_rep = "لا يوجد" Then
                        Label19.Text = ""
                    Else
                        Label19.Visible = True
                        Label19.Text = "وبديله     " & n_rep
                    End If
                Else
                    Label16.Visible = False
                    Label14.Visible = True
                    Label14.Text = "لايمتلك تخويل نافذ"
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("لايمتلك تخويل سابق", MsgBoxStyle.Information, "*_*")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        F9_do3_p1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label18.BackColor = Color.Red
            cb2ncar_replace.Visible = True
            fillcb2ncar_replace()
        Else
            Label18.BackColor = Color.Black
            cb2ncar_replace.Visible = False
            cb2ncar_replace.Text = "لا يوجد"
        End If
    End Sub
    Sub fillcb2ncar_replace()
        Dim kml As DataTable = dt.Copy
        kml.Rows.Clear()
        adapter = New OleDbDataAdapter("select  n_emploe5 as [الاسم] from t5_name_emplooyt5", con)
        adapter.Fill(kml)
        cb2ncar_replace.DataSource = kml
        cb2ncar_replace.DisplayMember = "الاسم"

    End Sub

    Private Sub cb5_test_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb5_test.SelectedIndexChanged

    End Sub
End Class