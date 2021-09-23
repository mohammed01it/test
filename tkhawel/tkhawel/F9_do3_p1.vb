Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class F9_do3_p1
    Private Sub F9_do3_p1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet5_f9_d3.t4_cart4' table. You can move, or remove it, as needed.
        ' Me.t4_cart4TableAdapter.Fill(Me.DataSet5_f9_d3.t4_cart4)
        Try
            adapter = New OleDb.OleDbDataAdapter("SELECT ID,dt_book, n_name, car_type, car_no, car_id, car_color, emplooy_add , end_dt , replace_name
                                                           FROM     t4_cart4 
                                                           WHERE ID=" & car_f4.txt1.Text, con)
            '                                              القيمة التي تاتي من الداتة كرد فيو المختارة التي يراد عرضها' WHERE ID=" & car_f4.txt1.Text
            Dim DS As New DataSet

            adapter.Fill(DS, 0)
            'اسناد مصدر بيانات من الداتة تيبل التي اخذناها من جملة سلكت ونفرغا بال الداتة تيبل الموجوده بالداتة سيت الخاصة بالطباعة
            '|vاسم الداتة تيبل الموجود بالداتة سيت|
            t4_cart4BindingSource.DataSource = DS.Tables(0)
            Me.ReportViewer1.Dock = DockStyle.Fill
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("لا توجد تخاويل")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class