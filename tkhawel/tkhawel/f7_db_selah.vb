Imports System.ComponentModel
Imports System.Data.OleDb



Public Class f7_db_selah
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_f3.Show()
        Me.Close()
    End Sub

    Private Sub f7_db_selah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filldtselah()
        DGV_selah.Columns(0).Width = 100
        DGV_selah.Columns(1).Width = 200
        DGV_selah.Columns(2).Width = 200
        DGV_selah.Columns(3).Width = 200
        DGV_selah.Columns(4).Width = 200
        DGV_selah.Columns(5).Width = 200
        DGV_selah.Columns(6).Width = 220
        ReSet_Sort()
    End Sub

    Sub ReSet_Sort()
        DGV_selah.Sort(DGV_selah.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'زر الحذف
        Try

            For i As Integer = 0 To DGV_selah.Rows.Count - 1
                'اخر رقم تخويل تم الوصل الية ناقص  عدد احنة نحدد= >رقم التخويل الذي اختارة المستخدم لتعديله 

                If Me.DGV_selah.CurrentRow.Cells(0).Value <= DGV_selah.Rows(i).Cells(0).Value - 12 Then


                    MsgBox("لايمكن حذف التخاويل القديمة ", MsgBoxStyle.Exclamation, "تنبية")
                    Exit Sub

                End If

            Next

            If My.Settings.us = DGV_selah.CurrentRow.Cells(5).Value Then

            Else
                MsgBox(" ليس انت من قام بتنظيم هذا التخويل فلا يحق لك الحذف " & vbNewLine & " التخويل الذي تود حذفه لقد تم تنظيمه من قبل الموظف  " & vbNewLine & DGV_selah.CurrentRow.Cells(5).Value, MsgBoxStyle.Exclamation, "تنبية")

                Exit Sub
            End If
            '  شرط  تحقق هل تريد الالغاء بالفعل فاذا ضغط  نعم سوفة ينفذ والا لابفعل شئ
            If MsgBox("هل انت متاكد بانك تريد حذف هذة البيانات", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then

            Else
                Exit Sub
            End If
            cmd = New OleDb.OleDbCommand("Delete from t3_selaht3 where ID_3 = " & DGV_selah.CurrentRow.Cells(0).Value, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم الحذف بنجاح", MsgBoxStyle.Information, "الحذف")
            Filldtselah()
            con.Close()

        Catch ex As Exception
            MsgBox("لا توجد بيانات")
        Finally
            con.Close()
        End Try
        Exit Sub

    End Sub

    Private Sub DGV_selah_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_selah.CellContentClick

    End Sub

    Private Sub DGV_selah_DoubleClick(sender As Object, e As EventArgs) Handles DGV_selah.DoubleClick
        Try

            'حدث الدبل كليك لاسترجاع البيانات الى فورم تخويل
            If My.Settings.us = DGV_selah.CurrentRow.Cells(5).Value Then
            Else
                MsgBox(" ليس انت من قام بتنظيم هذا التخويل فلا يحق لك التعديل علية " & vbNewLine & " التخويل تم تنظيمه من قبل الموظف  " & vbNewLine & DGV_selah.CurrentRow.Cells(5).Value, MsgBoxStyle.Exclamation, "تنبية")
                Exit Sub
            End If
            fillcb1ncar_f4()
            selah_f5.txt1_f5_s.Text = DGV_selah(0, DGV_selah.CurrentRow.Index).Value
            selah_f5.dtp1_f5_s.Value = Me.DGV_selah.CurrentRow.Cells(1).Value 'هذه طريقة او 
            selah_f5.cb_n_f5.Text = DGV_selah(2, DGV_selah.CurrentRow.Index).Value 'هذه طريقة
            selah_f5.txt_no_f5_s.Text = DGV_selah(3, DGV_selah.CurrentRow.Index).Value
            selah_f5.txt_name_f5_s.Text = DGV_selah(4, DGV_selah.CurrentRow.Index).Value
            selah_f5.L7_F5_S.Text = DGV_selah(5, DGV_selah.CurrentRow.Index).Value
            selah_f5.dtp2_f5_s.Value = DGV_selah(6, DGV_selah.CurrentRow.Index).Value
            selah_f5.cb_n_f5.Select()
            selah_f5.bt1_f5_s.Visible = False
            selah_f5.bt2_f5_s.Visible = False
            selah_f5.Show()
            selah_f5.TopMost = True
            selah_f5.TopMost = False
            selah_f5.bt3_f5_s.Text = "حفظ التغييرات"
            selah_f5.bt3_f5_s.BackColor = Color.Blue
            selah_f5.bt3_f5_s.Visible = True
            selah_f5.bt4_f5_s.Visible = True
            cmd = New OleDbCommand("select * from t3_selaht3 where  ID_3=@ID_3", con)
            cmd.Parameters.Add(New OleDbParameter("@ID_3", OleDbType.VarChar)).Value = Me.DGV_selah.CurrentRow.Cells(0).Value
            con.Open()
            Dim dr_selh As OleDbDataReader = cmd.ExecuteReader
            dr_selh.Read()
            selah_f5.ID3_selh = dr_selh("ID_3")
            dr_selh.Close()
            con.Close()
            selah_f5.GroupBox2.Visible = False
            selah_f5.Button1.Visible = False

        Catch ex As Exception
            MsgBox("لا توجد بيانات")
        Finally
            con.Close()
        End Try
    End Sub
End Class