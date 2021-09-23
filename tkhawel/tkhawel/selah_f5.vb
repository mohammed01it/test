Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class selah_f5
    Public ID3_selh As Integer
    Dim selahadd As String
    Private Sub gen_f5_s()
        generation_f5_s()
        txt1_f5_s.Text = new_id_3
        fillcb1ncar_f4()
        txt_name_f5_s.Clear()
        txt_no_f5_s.Clear()
        dtp1_f5_s.Value = Now.Date
        dtp2_f5_s.Value = Now.Date
        cb_n_f5.Select()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_name_f5_s_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt1_f5_s_Click(sender As Object, e As EventArgs) Handles bt1_f5_s.Click
        gen_f5_s()
        bt4_f5_s.Visible = False
        bt2_f5_s.Visible = True
        GroupBox2.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub bt2_f5_s_Click(sender As Object, e As EventArgs) Handles bt2_f5_s.Click

        'زر الحفظ
        If txt1_f5_s.Text = "" Then
            MsgBox("يجب الضغط على زر " & vbNewLine & "(انشاء تخويل جديد)", MsgBoxStyle.Exclamation, "تنبية")
            Exit Sub
        End If
        If cb_n_f5.Text = "" Then
            MsgBox("لايمكن ترك حقل الاسم فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb_n_f5.Focus()
            Exit Sub
        End If
        If txt_name_f5_s.Text = "" Then
            MsgBox("يجب ادخال اسم السلاح ", MsgBoxStyle.Exclamation, "تنبيه")
            txt_name_f5_s.Focus()
            Exit Sub
        End If
        If txt_no_f5_s.Text = "" Then
            MsgBox("يجب اخال رقم السلاح", MsgBoxStyle.Exclamation, "تنبيه")
            txt_no_f5_s.Focus()
            Exit Sub
        End If
        selahadd = "Insert Into t3_selaht3( ID_3 , dt_selahtt3 , add_emplooyt3 , selah_no3 , selah_name3 , n_tkhoel3 , dt_end3 )
                               values( @ID_3 , @dt_selahtt3 , @add_emplooyt3 , @selah_no3 , @selah_name3 , @n_tkhoel3 , @dt_end3 )"
        cmd = New OleDbCommand(selahadd, con)
        cmd.Parameters.Add(New OleDbParameter("@ID_3", OleDbType.Integer)).Value = txt1_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@dt_selahtt3", OleDbType.Date)).Value = dtp1_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@add_emplooyt3", OleDbType.VarChar)).Value = L7_F5_S.Text
        cmd.Parameters.Add(New OleDbParameter("@selah_no3", OleDbType.VarChar)).Value = txt_no_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@selah_name3", OleDbType.VarChar)).Value = txt_name_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@n_tkhoel3", OleDbType.VarChar)).Value = cb_n_f5.Text
        cmd.Parameters.Add(New OleDbParameter("@dt_end3", OleDbType.Date)).Value = dtp2_f5_s.Text
        con.Open()
        cmd.ExecuteNonQuery()
        selahadd = "update t5_name_emplooyt5 set id_name3 = @id_name3
                               where ID = " & cb_n_f5.SelectedIndex + 1
        cmd = New OleDbCommand(selahadd, con)
        cmd.Parameters.Add(New OleDbParameter("@id_name3", OleDbType.VarChar)).Value = txt1_f5_s.Text
        cmd.ExecuteNonQuery()
        MsgBox("تم الحفظ بنجاح", MsgBoxStyle.Information, "ادخال التخويل")
        con.Close()
        bt2_f5_s.Visible = False
        bt4_f5_s.Visible = True
        fillcb6_test_s()
        GroupBox2.Visible = True
        Button1.Visible = True

    End Sub
    Sub fillcb6_test_s()
        Dim kml As DataTable = dt.Copy
        kml.Rows.Clear()
        adapter = New OleDbDataAdapter("select  n_emploe5 as [الاسم] , id_name3 as [3] from t5_name_emplooyt5", con)
        adapter.Fill(kml)
        cb6_test_s.DataSource = kml
        cb6_test_s.DisplayMember = "الاسم"
        cb6_test_s.ValueMember = "3"
    End Sub
    Private Sub selah_f5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bt3_f5_s.Visible = False
        txt1_f5_s.Enabled = False
        dtp1_f5_s.Enabled = False
        dtp3_f5_s.Enabled = False
        bt4_f5_s.Visible = False
        L7_F5_S.Text = My.Settings.us
        fillcb6_test_s()
    End Sub

    Private Sub bt3_f5_s_Click(sender As Object, e As EventArgs) Handles bt3_f5_s.Click
        'زر التعديل
        If txt1_f5_s.Text = "" Then
            MsgBox("لايمكن ترك حقل الاسم فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            txt1_f5_s.Focus()
            Exit Sub
        End If
        If cb_n_f5.Text = "" Then
            MsgBox("لايمكن ترك حقل نوع السيارة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            cb_n_f5.Focus()
            Exit Sub
        End If
        If txt_name_f5_s.Text = "" Then
            MsgBox("لايمكن ترك حقل لون السيارة فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            txt_name_f5_s.Focus()
            Exit Sub
        End If
        If txt_no_f5_s.Text = "" Then
            MsgBox("يجب ادخال رقم السلاح", MsgBoxStyle.Exclamation, "تنبيه")
            txt_no_f5_s.Select()
            Exit Sub
        End If
        '  شرط  تحقق هل تريد الالغاء بالفعل فاذا ضغط  نعم سوفة ينفذ والا لابفعل شئ
        If MsgBox("هل انت متاكد من تعديل هذة البيانات", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        'UPDATE
        '-----------------------هذا الكود خاص بالتعديل على قاعدة البيانات-------------------------
        Dim selah_Query As String
        selah_Query = "Update t3_selaht3 set selah_no3 = @selah_no3 , selah_name3=@selah_name3 , n_tkhoel3=@n_tkhoel3 , dt_end3=@dt_end3
                             Where ID_3 = " & ID3_selh  'شاهد-هذا متغير خزنة بية رقم المعرف الاي دي 
        'ملاحظة ياخذ رقم الايدي من الداتة من فورم الدخول 
        cmd = New OleDb.OleDbCommand(selah_Query, con)
        cmd.Parameters.Add(New OleDbParameter("@selah_no3", OleDbType.VarChar)).Value = txt_no_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@selah_name3", OleDbType.VarChar)).Value = txt_name_f5_s.Text
        cmd.Parameters.Add(New OleDbParameter("@n_tkhoel3", OleDbType.VarChar)).Value = cb_n_f5.Text
        cmd.Parameters.Add(New OleDbParameter("@dt_end3", OleDbType.Date)).Value = dtp2_f5_s.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        bt4_f5_s.Visible = True
        Filldtselah()
    End Sub

    Private Sub bt4_f5_s_Click(sender As Object, e As EventArgs) Handles bt4_f5_s.Click
        F88_d2.stat_report_selah = "one_d_selah"
        F88_d2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'زر فحص يمتلك تخويل ام لا
        Try
            Label7.Text = ""
            Label14.Text = ""
            Label7.Visible = False
            Label14.Visible = False
            Dim aa = Now.Date
            cmd = New OleDbCommand("select * from t3_selaht3 where ID_3 = " & cb6_test_s.SelectedValue, con)
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim dateEnd As Date
                dateEnd = dr("dt_end3")
                ' Label11.Text = dateEnd
                '  dr.Close()
                'يجيك اذا تخويل القديم اكبر من تاريخ اليوم يظهر مسج انه يمتلك تخويل نافذ
                If dateEnd > Now.Date.ToShortDateString Then
                    Label7.Visible = True
                    Label14.Visible = True
                    Label7.Text = "يمتلك تخويل نافذ ينتهي في     " & dateEnd
                    Label14.Text = "عدد الايام المتبقية للنفاذ    " & (dateEnd - aa).Days & " يوم  "
                Else
                    Label7.Visible = False
                    Label14.Visible = True
                    Label14.Text = "لايمتلك تخويل نافذ"
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("لا يمتلك تخويل سابق", MsgBoxStyle.Information, "*_*")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cb6_test_s_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb6_test_s.SelectedIndexChanged

    End Sub
End Class