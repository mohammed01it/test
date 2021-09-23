Imports System.Data.OleDb
Module m1_tkhawel
    'طريقة الاتصال الاولى
    'Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\adb_tkhawel.accdb")
    ' طريقة الاتصال الطبيعية الثانية 
    'Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\tkhawel\tkhawel\bin\Debug\adb_tkhawel.accdb")
    'الاتصال الاولى مع باسورد قاعدة البيانات 
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\adb_tkhawel.accdb;user id=admin;jet oledb:database password=5554812345")
    Public cmd As New OleDbCommand
    Public adapter As OleDbDataAdapter
    Public dt As New DataTable
    Public newid As Integer
    Public new_id_3 As Integer
    Public dt8 As New DataTable
    Sub fillCB1n()
        Dim dtnuser As DataTable = dt.Copy
        adapter = New OleDb.OleDbDataAdapter("select * from t1_usert1", con)
        adapter.Fill(dtnuser)
        login_f1.CB1n.DataSource = dtnuser
        login_f1.CB1n.DisplayMember = "n_user"
    End Sub


    Sub Fillcontans() 'نملئ الداتة كرد فيو بالبيانات 
        dt.Rows.Clear() ' نقوم بتنظيف النتغير الذي يحوتي على البيانات لكي لايقوم بتكرار نفس المواد مرة اخرى
        ' adapter = New OleDb.OleDbDataAdapter("select * from t1_usert1", con)
        ' ID as [رقم التخويل],dt_book as [تاريخ التخويل],n_name as [الاسم],car_type as [نوع السيارة],car_no as [رقم السيارة],car_id as [رقم الشاصي],car_color as [لون السيارة],end_dt as [تاريخ انتهاء النفاذ],system_dt as [تاريخ النظام],emplooy_add as [منظم التخويل]
        'مع تغير اسماء الاعمدة
        adapter = New OleDbDataAdapter("select  ID as [رقم التخويل] , dt_book as [تاريخ التخويل] , n_name as [الاسم] , car_type as [نوع السيارة] , car_no as [رقم السيارة] , car_id as [رقم الشاصي] , car_color as [لون السيارة] , end_dt as [تاريخ انتهاء النفاذ] , system_dt as [تاريخ النظام] , emplooy_add as [منظم التخويل] , walet_address as [عنوان الواجب] , replace_name as [اسم البديل] from t4_cart4", con)
        'فائده الادبتر ياخذ نسخه من قاعده البيانات الصلية ويضعها بالداتة تيبل
        adapter.Fill(dt)
        'ومن ثمة الداتة تيبل يضعها بالداتة كرد فيو
        f6_db_car.DGV_car.DataSource = dt ' لكي يملئ الداته كرد فيو الموجوده بالفورم رقم 2 بالبيانات
    End Sub


    Sub Filldtselah() 'نملئ الداتة كرد فيو بالبيانات 
        ' dtbase.Rows.Clear() ' نقوم بتنظيف النتغير الذي يحوتي على البيانات لكي لايقوم بتكرار نفس المواد مرة اخرى
        ' adapter = New OleDb.OleDbDataAdapter("select * from t3_selaht3", con)
        dt8.Rows.Clear()
        'مع تغير اسماء الاعمدة
        adapter = New OleDbDataAdapter("select ID_3 as [رقم عدد التخويل] , dt_selahtt3 as [تاريخ التخويل] , n_tkhoel3 as [اسم صاحب التخويل] , selah_no3 as [رقم السلاح] , selah_name3 as [اسم السلاح] , add_emplooyt3 as [منظم التخويل] , dt_end3 as [تاريخ النفاذ] from t3_selaht3", con)
        'فائده الادبتر ياخذ نسخه من قاعده البيانات الصلية ويضعها بالداتة تيبل
        adapter.Fill(dt8)
        'ومن ثمة الداتة تيبل يضعها بالداتة كرد فيو
        f7_db_selah.DGV_selah.DataSource = dt8 ' لكي يملئ الداته كرد فيو الموجوده بالفورم رقم 2 بالبيانات
    End Sub

    Sub code_ge()
        Dim td As New DataTable
        Dim da As New OleDbDataAdapter("select max(ID) from t4_cart4", con) 'add_emplooyt3 as [منظم التخويل]
        da.Fill(td)
        If IsDBNull(td(0)(0)) = True Then
            newid = 1
        Else
            newid = td(0)(0) + 1
        End If
    End Sub
    Sub generation_f5_s()
        Dim td5 As New DataTable
        Dim da5 As New OleDbDataAdapter("select max(ID_3) from t3_selaht3", con)
        da5.Fill(td5)
        If IsDBNull(td5(0)(0)) = True Then
            new_id_3 = 1
        Else
            new_id_3 = td5(0)(0) + 1
        End If
    End Sub
    Sub fillcb1ncar_f4()
        Dim kml As DataTable = dt.Copy
        kml.Rows.Clear()
        adapter = New OleDbDataAdapter("select ID as [التسلسل] , n_emploe5 as [الاسم] , id_name2 as [2] from t5_name_emplooyt5", con)
        adapter.Fill(kml)
        car_f4.ComboBox1_ncar.DataSource = kml
        car_f4.ComboBox1_ncar.DisplayMember = "الاسم"
        car_f4.ComboBox1_ncar.ValueMember = "2"
        selah_f5.cb_n_f5.DataSource = kml
        selah_f5.cb_n_f5.DisplayMember = "الاسم"
        F8_do1_p2.cb_n_p2.DataSource = kml
        F8_do1_p2.cb_n_p2.DisplayMember = "الاسم"
        F88_d2.cb_f88_n_d2.DataSource = kml
        F88_d2.cb_f88_n_d2.DisplayMember = "الاسم"
        Form88_reporting2.cb_rep_form88_n.DataSource = kml
        Form88_reporting2.cb_rep_form88_n.DisplayMember = "الاسم"
    End Sub

End Module
