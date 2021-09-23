Imports System.Data.OleDb
Public Class F_manage_caunt
    Public id_user As Integer
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5_caunt_manage.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles but_save_manage_caunt.Click

        '/////////////////////شرط تحقق من الباسورد القديم\\\\\\\\\\\\\\\\\\\\\\\\
        cmd = New OleDbCommand("select * from t1_usert1 where  n_user=@n_user and Pass_user=@Pass_user", con)

        cmd.Parameters.Add(New OleDbParameter("@n_user", OleDbType.VarChar)).Value = Label5_caunt_manage.Text
        cmd.Parameters.Add(New OleDbParameter("@Pass_user", OleDbType.VarChar)).Value = txt_old_pass.Text
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
        Else
            MsgBox("الباسورد القديم غير صحيح", MsgBoxStyle.Exclamation, "معلومات خاطئة")
            txt_old_pass.Select()
            txt_old_pass.SelectAll()
            dr.Close()
            con.Close()
            Exit Sub
        End If
        dr.Close()
        con.Close()
        '/////////////////////شرط تحقق من الباسورد المكرر\\\\\\\\\\\\\\\\\\\\\\\\
        'اذا كان الباسورد الجديد لا يساوي الباسورد المكرر اوقف التنفيذ
        If txt_new_pass.Text <> txt_renew_pass.Text Then
            MsgBox("الباسورد المكرر غير صحيح", MsgBoxStyle.Exclamation, "معلومات خاطئة")
            txt_renew_pass.Select()
            txt_renew_pass.SelectAll()
            Exit Sub
        End If




        'ومن ثمة تعديل الباسورد

        'UPDATE
        '-----------------------هذا الكود خاص بالتعديل على قاعدة البيانات-------------------------
        Dim strQuery As String

        strQuery = "Update t1_usert1 set Pass_user = @Pass_user
                             Where ID = " & id_user  'شاهد-هذا متغير خزنة بية رقم المعرف الاي دي 
        'ملاحظة ياخذ رقم الايدي من الداتة من فورم الدخول 
        cmd = New OleDb.OleDbCommand(strQuery, con)

        cmd.Parameters.Add(New OleDbParameter("@Pass_user", OleDbType.VarChar)).Value = txt_new_pass.Text

        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("تم تغير الباسورد بنجاح", MsgBoxStyle.Information, "نجاح العملية")
        con.Close()
        '---------------------end----------------------------------------



        'ومن ثمة تفريغ البيانات

        txt_old_pass.Clear()
        txt_new_pass.Clear()
        txt_renew_pass.Clear()
    End Sub

    Private Sub F_manage_caunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5_caunt_manage.Text = My.Settings.us
    End Sub
End Class