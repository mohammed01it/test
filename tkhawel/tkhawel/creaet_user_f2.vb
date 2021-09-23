Imports System.Data.OleDb
Public Class creaet_user_f2
    Private Sub b4f2_Click(sender As Object, e As EventArgs) Handles b4f2.Click


        If txt1n.Text = "" Then
            MsgBox("لايمكن ترك حقل الاسم فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            txt1n.Focus()
            Exit Sub
        End If
        If txt2p.Text = "" Then
                MsgBox(" لايمكن ترك حقل الباسورد فارغ", MsgBoxStyle.Exclamation, "تنبيه")
                txt2p.Focus()

                Exit Sub
            End If
        If txt3m.Text = "" Then
            MsgBox("لايمكن ترك حقل رقم الموبايل فارغ", MsgBoxStyle.Exclamation, "تنبيه")
            txt3m.Focus()
            Exit Sub
        End If
        If txt_me_sys.Text = "" Then
            MsgBox("يجب مصادقة مدير النظام", MsgBoxStyle.Exclamation, "تنبيه")
            txt_me_sys.Focus()
            Exit Sub
        End If

        'زر انشاء حساب جديد
        ' Try
        If txt_me_sys.Text = "ramiit12345" Then
            cmd = New OleDbCommand("INSERT INTO t1_usert1 (n_user, Pass_user, mobil_user, brith_user)
                                                            values (@n_user, @Pass_user, @mobil_user, @brith_user)", con)
            cmd.Parameters.Add(New OleDbParameter("@n_user", OleDbType.VarChar)).Value = txt1n.Text
            cmd.Parameters.Add(New OleDbParameter("@Pass_user", OleDbType.VarChar)).Value = txt2p.Text
            cmd.Parameters.Add(New OleDbParameter("@mobil_user", OleDbType.VarChar)).Value = txt3m.Text
            cmd.Parameters.Add(New OleDbParameter("@brith_user", OleDbType.Date)).Value = DTP1.Text
            '   cmd.Parameters.Add(New OleDbParameter("@hestory", OleDbType.VarChar)).Value = WinuserComboBox1.SelectedIndex + 1 'لتحديد نوع الصلاحيات
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم انشاء حساب جديد بنجاح", MsgBoxStyle.Information, "نسجيل البيانات")
            'تحميل اسماء المستخدمين
            'لكي يقوم بنقل المعلومات لحساب الجديد الكوبو بوكس الخاصة بتسجيل الدخول
            'جعلنا المستخدم يدخل من هناك لكي نعرف من هوه قام بتسجيل الدخول الى الحساب
            txt1n.Clear()
            txt2p.Clear()
            txt3m.Clear()
            ' AgeuserDateTimePicker.Clear()
            con.Close()
            ' Catch ex As Exception
            '  Finally
            con.Close()
            ' End Try
            login_f1.Show()
            Me.Close()
            fillCB1n()
        Else
            MsgBox("رمز المصادقة خطأ", MsgBoxStyle.Exclamation, "انتباه")
            txt_me_sys.SelectAll()
            Exit Sub
        End If
    End Sub

    Private Sub creaet_user_f2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1n.Focus()
    End Sub

    Private Sub b5f2_Click(sender As Object, e As EventArgs) Handles b5f2.Click
        Me.Close()
    End Sub

    Private Sub txt_me_sys_TextChanged(sender As Object, e As EventArgs) Handles txt_me_sys.TextChanged
        If CheckBox1.Checked = True Then
            If txt_me_sys.Text = "ramiit12345" Then
                main_f3.Show()
                Form1_buck_up.but3_system_3.Visible = True
            Else
                MsgBox("خطأ في الرمز")
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class