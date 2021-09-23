Imports System.ComponentModel
Imports System.Data.OleDb




Public Class f6_db_car
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_f3.Show()
        Me.Close()
    End Sub

    Sub ReSet_Sort()
        DGV_car.Sort(DGV_car.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub f6_db_car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillcontans()
        DGV_car.Columns(0).Width = 100
        DGV_car.Columns(1).Width = 110
        DGV_car.Columns(2).Width = 150
        DGV_car.Columns(3).Width = 150
        DGV_car.Columns(4).Width = 100
        DGV_car.Columns(5).Width = 140
        DGV_car.Columns(6).Width = 120
        DGV_car.Columns(7).Width = 120
        DGV_car.Columns(8).Width = 110
        DGV_car.Columns(9).Width = 100
        DGV_car.Columns(11).Width = 150
        ReSet_Sort()
    End Sub



    Private Sub DGV_car_DoubleClick(sender As Object, e As EventArgs) Handles DGV_car.DoubleClick
        'حدث الدبل كليك لاسترجاع البيانات الى فورم تخويل
        Try

            If My.Settings.us = DGV_car.CurrentRow.Cells(9).Value Then

            Else
                MsgBox(" ليس انت من قام بتنظيم هذا التخويل فلا يحق لك التعديل علية " & vbNewLine & " التخويل تم تنظيمه من قبل الموظف  " & vbNewLine & DGV_car.CurrentRow.Cells(9).Value, MsgBoxStyle.Exclamation, "تنبية")

                Exit Sub

            End If
            fillcb1ncar_f4()
            car_f4.txt1.Text = DGV_car(0, DGV_car.CurrentRow.Index).Value
            car_f4.ComboBox1_ncar.Text = Me.DGV_car.CurrentRow.Cells(2).Value 'هذه طريقة او 
            car_f4.cb2_c_n_ct4.Text = DGV_car(3, DGV_car.CurrentRow.Index).Value 'هذه طريقة
            car_f4.txtnocar.Text = DGV_car(4, DGV_car.CurrentRow.Index).Value
            car_f4.txtidcar.Text = DGV_car(5, DGV_car.CurrentRow.Index).Value
            car_f4.cb3_color_cart4.Text = DGV_car(6, DGV_car.CurrentRow.Index).Value
            car_f4.DateTimePicker3.Value = DGV_car(7, DGV_car.CurrentRow.Index).Value
            car_f4.txt_walet_addr.Text = Me.DGV_car.CurrentRow.Cells(10).Value
            If Me.DGV_car.CurrentRow.Cells(11).Value <> "لا يوجد" Then
                car_f4.CheckBox1.Checked = True
                car_f4.cb2ncar_replace.Text = Me.DGV_car.CurrentRow.Cells(11).Value
            Else
            End If
            car_f4.butsacar.Visible = False
            car_f4.Button2.Visible = False
            car_f4.Button3.Visible = True
            car_f4.txt1.Enabled = False
            car_f4.Show()
            car_f4.Button3.Text = "حفظ التغييرات"
            car_f4.Button3.BackColor = Color.Aqua
            car_f4.txt_print_car.Visible = True
            car_f4.TopMost = True
            car_f4.TopMost = False
            car_f4.GroupBox2.Visible = False
            car_f4.Button1.Visible = False

        Catch ex As Exception
            MsgBox("لا توجد بيانات")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DGV_car_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_car.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'زر الحذف
        Try

            For i As Integer = 0 To DGV_car.Rows.Count - 1
                'اخر رقم تخويل تم الوصل الية ناقص  عدد احنة نحدد= >رقم التخويل الذي اختارة المستخدم لتعديله 

                If Me.DGV_car.CurrentRow.Cells(0).Value <= DGV_car.Rows(i).Cells(0).Value - 12 Then


                    MsgBox("لايمكن حذف التخاويل القديمة ", MsgBoxStyle.Exclamation, "تنبية")
                    Exit Sub

                End If

            Next

            If My.Settings.us = DGV_car.CurrentRow.Cells(9).Value Then

            Else
                MsgBox(" ليس انت من قام بتنظيم هذا التخويل فلا يحق لك الحذف " & vbNewLine & " التخويل الذي تود حذفه لقد تم تنظيمه من قبل الموظف  " & vbNewLine & DGV_car.CurrentRow.Cells(9).Value, MsgBoxStyle.Exclamation, "تنبية")

                Exit Sub
            End If


            '  شرط  تحقق هل تريد الالغاء بالفعل فاذا ضغط  نعم سوفة ينفذ والا لابفعل شئ
            If MsgBox("هل انت متاكد بانك تريد حذف هذة البيانات", MsgBoxStyle.YesNo, "تاكيد") = MsgBoxResult.Yes Then

            Else
                Exit Sub
            End If

            cmd = New OleDb.OleDbCommand("Delete from t4_cart4 where ID = " & DGV_car.CurrentRow.Cells(0).Value, con)

            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم الحذف بنجاح", MsgBoxStyle.Information, "الحذف")
            Fillcontans()

            con.Close()
            Exit Sub
        Catch ex As Exception
            MsgBox("لاتوجد بيانات")
        Finally
            con.Close()
        End Try

    End Sub


End Class