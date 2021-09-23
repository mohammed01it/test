
Imports System.ComponentModel

Public Class main_f3
    Private Sub main_f3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L1f3.Text = "    اهلاً وسهلاً بك : " & My.Settings.us
        Timer1.Start()
        '  selah_f5.L7_F5_S.Text = My.Settings.us
    End Sub

    Private Sub main_f3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
    Private Sub تخويلالعجلاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تخويلالعجلاتToolStripMenuItem.Click
        car_f4.TopMost = True
        car_f4.TopMost = False
        car_f4.Show()
    End Sub

    Private Sub تخويلالسلاحToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تخويلالسلاحToolStripMenuItem.Click
        selah_f5.TopMost = True
        selah_f5.TopMost = False
        selah_f5.Show()
    End Sub

    Private Sub قاعدةبياناتالعجلاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قاعدةبياناتالعجلاتToolStripMenuItem.Click
        f6_db_car.TopMost = True
        f6_db_car.TopMost = False
        f6_db_car.Show()
    End Sub

    Private Sub قاعدةبياناتالسلاحToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قاعدةبياناتالسلاحToolStripMenuItem.Click
        f7_db_selah.TopMost = True
        f7_db_selah.TopMost = False
        f7_db_selah.Show()
    End Sub

    Private Sub تقريرالعجلاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تقريرالعجلاتToolStripMenuItem.Click

    End Sub

    Private Sub بشكلجداولToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بشكلجداولToolStripMenuItem.Click
        Form8_reporting.TopMost = True
        Form8_reporting.TopMost = False
        Form8_reporting.Show()
    End Sub

    Private Sub بشكلتخاويلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بشكلتخاويلToolStripMenuItem.Click
        F8_do1_p2.TopMost = True
        F8_do1_p2.TopMost = False
        F8_do1_p2.Show()
    End Sub

    Private Sub تغييركلمةالسرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تغييركلمةالسرToolStripMenuItem.Click
        F_manage_caunt.TopMost = True
        F_manage_caunt.TopMost = False
        F_manage_caunt.Show()
    End Sub

    Private Sub تقريرالسلاحToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تقريرالسلاحToolStripMenuItem.Click

    End Sub

    Private Sub بشكلجداولToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles بشكلجداولToolStripMenuItem1.Click
        Form88_reporting2.TopMost = True
        Form88_reporting2.TopMost = False
        Form88_reporting2.Show()
    End Sub

    Private Sub بشكلتخاويلToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles بشكلتخاويلToolStripMenuItem1.Click
        F88_d2.TopMost = True
        F88_d2.TopMost = False
        F88_d2.Show()
    End Sub

    Private Sub ادارةقاعدةالبياناتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادارةقاعدةالبياناتToolStripMenuItem.Click
        Form1_buck_up.TopMost = True
        Form1_buck_up.TopMost = False
        Form1_buck_up.Show()
    End Sub

    Private Sub ادارةاسماءالافرادToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادارةاسماءالافرادToolStripMenuItem.Click
        Form_name_emplooy.TopMost = True
        Form_name_emplooy.TopMost = False
        Form_name_emplooy.Show()
    End Sub

    Private Sub ملفToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ملفToolStripMenuItem1.Click
        '  Form11_internet.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'PictureBox2.Height = PictureBox2.Height + 1
        'L1f3.Width = L1f3.Width + 1
        'If PictureBox2.Height = 200 Then
        '    Timer1.Enabled = False
        'End If
        Label1.Height = Label1.Height + 1
        If Label1.Height = 400 Then
            Timer1.Enabled = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub L1f3_Click(sender As Object, e As EventArgs) Handles L1f3.Click

    End Sub

    Private Sub L1f3_MouseMove(sender As Object, e As MouseEventArgs) Handles L1f3.MouseMove
        L1f3.ForeColor = Color.Red
    End Sub
End Class