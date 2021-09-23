Imports System.Data.OleDb




Public Class login_f1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCB1n()
        txtpassf1.Select()
    End Sub

    Private Sub b1f1_Click(sender As Object, e As EventArgs) Handles b1f1.Click
        'زر تسجيل الدخول
        ' Try

        cmd = New OleDbCommand("select * from t1_usert1 where  n_user=@n_user and Pass_user=@Pass_user", con)

            cmd.Parameters.Add(New OleDbParameter("@n_user", OleDbType.VarChar)).Value = CB1n.Text
            cmd.Parameters.Add(New OleDbParameter("@Pass_user", OleDbType.VarChar)).Value = txtpassf1.Text
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
            MsgBox(" تم تسجيل الدخول بواسطة" & vbNewLine & CB1n.Text & " : الموظف", MsgBoxStyle.Information, "*_*")




            'لكي يظهر اسم من قامة بسجيل الدخول في فورم اخر
            'car_f4.L1f4.Text = dr("n_user")
            'main_f3.L1f3.Text = dr("n_user")

            My.Settings.us = dr("n_user")

            My.Settings.Save()

            '  Form12_MANAG_CAOUNT_USER.ID_User = dr("ID")
            F_manage_caunt.id_user = dr("ID")

            Me.Hide()

                main_f3.Show()
            Else
                MsgBox("معلومات الدخول غير صحيحة", MsgBoxStyle.Exclamation, "فشل تسجيل الدخول")

                txtpassf1.Focus()
            txtpassf1.Select(0, txtpassf1.Text.Length) 'لكي يقوم بتضليل الرقم
        End If


            dr.Close()



        ' Catch ex As Exception

        ' Finally
        con.Close()
        ' End Try

    End Sub


    Private Sub b3f1_Click(sender As Object, e As EventArgs) Handles b3f1.Click
        creaet_user_f2.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassf1.PasswordChar = ""
        Else
            txtpassf1.PasswordChar = "*" 'يقوم بوضع رمز لباسورد لكي يجعلة غير مرئي
        End If
    End Sub

    Private Sub b2f1_Click(sender As Object, e As EventArgs) Handles b2f1.Click
        End

    End Sub

    Private Sub CB1n_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1n.SelectedIndexChanged

    End Sub

    Private Sub txtpassf1_TextChanged(sender As Object, e As EventArgs) Handles txtpassf1.TextChanged



    End Sub

    Private Sub txtpassf1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassf1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'زر تسجيل الدخول
            ' Try

            cmd = New OleDbCommand("select * from t1_usert1 where  n_user=@n_user and Pass_user=@Pass_user", con)

            cmd.Parameters.Add(New OleDbParameter("@n_user", OleDbType.VarChar)).Value = CB1n.Text
            cmd.Parameters.Add(New OleDbParameter("@Pass_user", OleDbType.VarChar)).Value = txtpassf1.Text
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox(" تم تسجيل الدخول بواسطة" & vbNewLine & CB1n.Text & " : الموظف", MsgBoxStyle.Information, "*_*")




                'لكي يظهر اسم من قامة بسجيل الدخول في فورم اخر
                'car_f4.L1f4.Text = dr("n_user")
                'main_f3.L1f3.Text = dr("n_user")

                My.Settings.us = dr("n_user")

                My.Settings.Save()
                '  Form12_MANAG_CAOUNT_USER.ID_User = dr("ID")
                F_manage_caunt.id_user = dr("ID")

                Me.Hide()

                main_f3.Show()
            Else
                MsgBox("معلومات الدخول غير صحيحة", MsgBoxStyle.Exclamation, "فشل تسجيل الدخول")

                txtpassf1.Focus()
                txtpassf1.Select(0, txtpassf1.Text.Length) 'لكي يقوم بتضليل الرقم
            End If


            dr.Close()



            ' Catch ex As Exception

            ' Finally
            con.Close()
            ' End Try
        End If
    End Sub
End Class
