<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_manage_caunt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.but_save_manage_caunt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5_caunt_manage = New System.Windows.Forms.Label()
        Me.txt_old_pass = New System.Windows.Forms.TextBox()
        Me.txt_new_pass = New System.Windows.Forms.TextBox()
        Me.txt_renew_pass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'but_save_manage_caunt
        '
        Me.but_save_manage_caunt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_save_manage_caunt.ForeColor = System.Drawing.Color.Blue
        Me.but_save_manage_caunt.Location = New System.Drawing.Point(189, 331)
        Me.but_save_manage_caunt.Name = "but_save_manage_caunt"
        Me.but_save_manage_caunt.Size = New System.Drawing.Size(120, 42)
        Me.but_save_manage_caunt.TabIndex = 0
        Me.but_save_manage_caunt.Text = "حفظ"
        Me.but_save_manage_caunt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "اسم الحساب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الباسورد القديم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "الباسورد الجديد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "اعادة الباسورد الجديد"
        '
        'Label5_caunt_manage
        '
        Me.Label5_caunt_manage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5_caunt_manage.ForeColor = System.Drawing.Color.Red
        Me.Label5_caunt_manage.Location = New System.Drawing.Point(42, 80)
        Me.Label5_caunt_manage.Name = "Label5_caunt_manage"
        Me.Label5_caunt_manage.Size = New System.Drawing.Size(180, 32)
        Me.Label5_caunt_manage.TabIndex = 5
        Me.Label5_caunt_manage.Text = "Label5"
        Me.Label5_caunt_manage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_old_pass
        '
        Me.txt_old_pass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_pass.ForeColor = System.Drawing.Color.Red
        Me.txt_old_pass.Location = New System.Drawing.Point(42, 115)
        Me.txt_old_pass.Name = "txt_old_pass"
        Me.txt_old_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_old_pass.Size = New System.Drawing.Size(180, 27)
        Me.txt_old_pass.TabIndex = 6
        Me.txt_old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_new_pass
        '
        Me.txt_new_pass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_pass.ForeColor = System.Drawing.Color.Red
        Me.txt_new_pass.Location = New System.Drawing.Point(42, 192)
        Me.txt_new_pass.Name = "txt_new_pass"
        Me.txt_new_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_pass.Size = New System.Drawing.Size(183, 27)
        Me.txt_new_pass.TabIndex = 7
        Me.txt_new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_renew_pass
        '
        Me.txt_renew_pass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_renew_pass.ForeColor = System.Drawing.Color.Red
        Me.txt_renew_pass.Location = New System.Drawing.Point(42, 228)
        Me.txt_renew_pass.Name = "txt_renew_pass"
        Me.txt_renew_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_renew_pass.Size = New System.Drawing.Size(183, 27)
        Me.txt_renew_pass.TabIndex = 8
        Me.txt_renew_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_manage_caunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.txt_renew_pass)
        Me.Controls.Add(Me.txt_new_pass)
        Me.Controls.Add(Me.txt_old_pass)
        Me.Controls.Add(Me.Label5_caunt_manage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.but_save_manage_caunt)
        Me.Name = "F_manage_caunt"
        Me.Text = "ادارة الحساب الشخصي"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents but_save_manage_caunt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5_caunt_manage As Label
    Friend WithEvents txt_old_pass As TextBox
    Friend WithEvents txt_new_pass As TextBox
    Friend WithEvents txt_renew_pass As TextBox
End Class
