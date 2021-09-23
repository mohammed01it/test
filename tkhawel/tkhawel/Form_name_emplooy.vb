Imports System.Data.OleDb
Public Class Form_name_emplooy
    Dim dtemploe As New DataTable
    Sub FillD1VG() 'نملئ الداتة كرد فيو بالبيانات 
        dtemploe.Rows.Clear() ' نقوم بتنظيف المتغير الذي يحوتي على البيانات لكي لايقوم بتكرار نفس المواد مرة اخرى
        ' يجلب اسماء الاعمدة كما هية بدون تغير تسميتهاوايضا يجلب جميع الاعمدة الموجودة
        'adapter = New OleDb.OleDbDataAdapter("select * from tbl_products", con)

        '
        'مع تغير اسماء الاعمدة
        adapter = New OleDb.OleDbDataAdapter("select ID as [التسلسل], n_emploe5 as [الاسم] from t5_name_emplooyt5", con)
        adapter.Fill(dtemploe)
        DataGridView1.DataSource = dtemploe



    End Sub
    Private Sub Form_name_emplooy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillD1VG()
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 200
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        If MsgBox("هل انت متاكد من التغييرات", MsgBoxStyle.YesNo, "تنبيه") = MsgBoxResult.Yes Then
            Dim cmemploe As OleDbCommandBuilder
            cmemploe = New OleDbCommandBuilder(adapter)
            'يعمل تحديث لداتة تيبل الخاصه بالعملاء الكوستمرز
            adapter.Update(dtemploe)
            FillD1VG()
        Else
            Exit Sub
        End If
    End Sub
End Class