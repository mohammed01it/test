Imports System.IO
Public Class Form1_buck_up
    Public name_user_pc As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'زر تصدير قاعدة البيانات
        'نفس الطريقة التي في الاعلى لكن هنا المستخدم هوه من يختار مكان حفظ النسخة الاحتياطية
        'اذا اردنا المستخدم هوة من يقوم بتحديد مكان حفظ النسخة الاحتياطية اي المسار الجديد لحفظ قاعدة البيانات
        'هذا المتغير نخزن بة مسار قاعدة البيانات الصلية
        Dim dbPath As String = Application.StartupPath & "\adb_tkhawel.accdb"
        Dim destinationPath_Out As String 'هذا المتغير نخزن بة المكان الذي سوفة نخزن بة قاعدة البيانات
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Access DB |*.accdb" 'نفلتر جميع الملفات واضهار فقط ملفات الاكسس 
        sfd.ShowDialog()
        TextBox1.Text = sfd.FileName
        destinationPath_Out = sfd.FileName & Now.Year & "-" & Now.Month & "-" & Now.Day
        'عملية النسخ من مسار الاصلي الى المسار الجديد
        If MsgBox("هل انت متأكد من تصدير قاعدة البيانات", MsgBoxStyle.YesNo, "تنبيه") = MsgBoxResult.Yes Then
            '            لتاكد اذا كان الملف موجود       اسم الملف الذي نريد الحفظ بة        مسار الذي نريد بة الحفظ           مسار وجود قاعدة البيانات الصلية 
            My.Computer.FileSystem.CopyFile(dbPath, destinationPath_Out + "\adb_tkhawel.accdb", FileIO.UIOption.AllDialogs)
        Else
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Form1_buck_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'زر عمل نسخة احتاطية
        'تحديد المسار الذي نحفظ بة قاعدة البيانات الاصلية
        'هذا المتغير نخزن بة مسار قاعدة البيانات الصلية
        Dim dbPath As String = Application.StartupPath & "\adb_tkhawel.accdb"
        Dim destinationPath As String 'هذا المتغير نخزن بة المكان الذي سوفة نخزن بة قاعدة البيانات
        '            يجلب مسار البرنامج لحد ملف ديبوك    
        '                                                    تسمية النسخة الاحتياطية التي تحتوي على اسم المقر والتاريخ
        destinationPath = Application.StartupPath & "\backUP\" & Now.Year & "-" & Now.Month & "-" & Now.Day   'تحديد المسار الجديد الذي سوفة نحفظ بة قاعدة البيانات
        'عملية النسخ من مسار الاصلي الى المسار الجديد
        '            لتاكد اذا كان الملف موجود       اسم الملف الذي نريد الحفظ بة        مسار الذي نريد بة الحفظ           مسار وجود قاعدة البيانات الصلية 
        My.Computer.FileSystem.CopyFile(dbPath, destinationPath + "\adb_tkhawel.accdb", FileIO.UIOption.OnlyErrorDialogs)
        MsgBox("تم عمل نسخة احتياطية بالبرنامج")
    End Sub

    Private Sub but3_system_3_Click(sender As Object, e As EventArgs) Handles but3_system_3.Click
        'زر استيراد قاعده البيانات
        '  شرط  تحقق هل تريد الالغاء بالفعل فاذا ضغط  نعم سوفة ينفذ والا لابفعل شئ
        If MsgBox(" انتباه الاستيراد سوفة يحذف قاعده البيانات القديمة هل ترغب بالاستمرار", MsgBoxStyle.YesNo, "تنبية") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        'لتاكيد الدخول من قبل مدير النظام
        Dim x As String = InputBox("ادخل الرمز", Title:="كود تاكيد الدخول")
        'اذا كان الرمز المدخل يساوي رمز مصادقة مدير النظام الموجود بالمتغير للبروجكت البرنامج يسمح لة بفتح الفورم والا  يغلق الفورم
        If "ramiit12345" = x Then
        Else
            MsgBox("الرمز خطأ", MsgBoxStyle.Critical, "خطأ")
            Exit Sub
        End If
        '*******************اذا وضعنا قاعدة البيانات من ضمن المشروع**********************
        'هذا المتغير نخزن بة الملف الذي يخزن به قاعدة البيانات الاصلية
        Dim dbPath As String = Application.StartupPath & "\adb_tkhawel.accdb"
        'فائدة هذا الايعاز لكي يقوم بحفظ قاعدة البيانات بهذا الاسم مهما كانت التسمية التي تأتي من اوبن فايل دايلوك
        Dim comp_db_path As String
        '                                     هذة التسمية التي تثبت
        comp_db_path = Path.Combine(dbPath, "adb_tkhawel.accdb")
        Dim sorcePath_Out As String 'هذا المتغير نخزن بة المكان الذي سوفة نخزن بة قاعدة البيانات
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Access DB |*.accdb" 'نفلتر جميع الملفات واضهار فقط ملفات الاكسس 
        ofd.ShowDialog()
        sorcePath_Out = ofd.FileName
        '///////////////////////////////////عملية النسخ من مسار الاصلي الى المسار الجديد\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        If MsgBox("هل انت متأكد من استيراد قاعدة البيانات", MsgBoxStyle.YesNo, "تنبيه") = MsgBoxResult.Yes Then
            '            لكي لايظهر نافذة الاستبدال       اسم الملف الذي نريد الحفظ بة        مسار الذي نريد بة الحفظ           مسار وجود قاعدة البيانات الصلية 
            My.Computer.FileSystem.CopyFile(sorcePath_Out, comp_db_path, FileIO.UIOption.OnlyErrorDialogs)
        Else
        End If
    End Sub
End Class