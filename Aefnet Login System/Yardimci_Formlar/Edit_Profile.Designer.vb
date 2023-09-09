<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Profile
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Profile))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotalmatch = New System.Windows.Forms.Label()
        Me.lbltotalwon = New System.Windows.Forms.Label()
        Me.lblpoint = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelEditProfile = New System.Windows.Forms.LinkLabel()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblnick = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureRutbe = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRutbe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.PictureRutbe)
        Me.Panel3.Controls.Add(Me.BtnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(935, 568)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbltotalmatch)
        Me.GroupBox2.Controls.Add(Me.lbltotalwon)
        Me.GroupBox2.Controls.Add(Me.lblpoint)
        Me.GroupBox2.Location = New System.Drawing.Point(483, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 199)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(34, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 19)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Toplam Savaşlarim :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(37, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Toplam Zaferlerim :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(118, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Puanim :"
        '
        'lbltotalmatch
        '
        Me.lbltotalmatch.AutoSize = True
        Me.lbltotalmatch.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbltotalmatch.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltotalmatch.Location = New System.Drawing.Point(199, 81)
        Me.lbltotalmatch.Name = "lbltotalmatch"
        Me.lbltotalmatch.Size = New System.Drawing.Size(100, 21)
        Me.lbltotalmatch.TabIndex = 107
        Me.lbltotalmatch.Text = "Mac Adres :"
        '
        'lbltotalwon
        '
        Me.lbltotalwon.AutoSize = True
        Me.lbltotalwon.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbltotalwon.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltotalwon.Location = New System.Drawing.Point(199, 40)
        Me.lbltotalwon.Name = "lbltotalwon"
        Me.lbltotalwon.Size = New System.Drawing.Size(100, 21)
        Me.lbltotalwon.TabIndex = 105
        Me.lbltotalwon.Text = "Mac Adres :"
        '
        'lblpoint
        '
        Me.lblpoint.AutoSize = True
        Me.lblpoint.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblpoint.ForeColor = System.Drawing.SystemColors.Control
        Me.lblpoint.Location = New System.Drawing.Point(199, 124)
        Me.lblpoint.Name = "lblpoint"
        Me.lblpoint.Size = New System.Drawing.Size(100, 21)
        Me.lblpoint.TabIndex = 106
        Me.lblpoint.Text = "Mac Adres :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(321, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 47)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Oyuncu Bilgileri"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabelEditProfile)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.lblusername)
        Me.GroupBox1.Controls.Add(Me.lblnick)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 199)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        '
        'LinkLabelEditProfile
        '
        Me.LinkLabelEditProfile.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.LinkLabelEditProfile.AutoSize = True
        Me.LinkLabelEditProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabelEditProfile.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LinkLabelEditProfile.LinkColor = System.Drawing.Color.Red
        Me.LinkLabelEditProfile.Location = New System.Drawing.Point(295, 172)
        Me.LinkLabelEditProfile.Name = "LinkLabelEditProfile"
        Me.LinkLabelEditProfile.Size = New System.Drawing.Size(95, 15)
        Me.LinkLabelEditProfile.TabIndex = 113
        Me.LinkLabelEditProfile.TabStop = True
        Me.LinkLabelEditProfile.Text = "Şifremi Değiştir"
        '
        'lblemail
        '
        Me.lblemail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblemail.ForeColor = System.Drawing.SystemColors.Control
        Me.lblemail.Location = New System.Drawing.Point(153, 124)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(242, 44)
        Me.lblemail.TabIndex = 107
        Me.lblemail.Text = "Mac Adres :"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.Control
        Me.lblusername.Location = New System.Drawing.Point(153, 40)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(100, 21)
        Me.lblusername.TabIndex = 106
        Me.lblusername.Text = "Mac Adres :"
        '
        'lblnick
        '
        Me.lblnick.AutoSize = True
        Me.lblnick.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblnick.ForeColor = System.Drawing.SystemColors.Control
        Me.lblnick.Location = New System.Drawing.Point(153, 83)
        Me.lblnick.Name = "lblnick"
        Me.lblnick.Size = New System.Drawing.Size(100, 21)
        Me.lblnick.TabIndex = 105
        Me.lblnick.Text = "Mac Adres :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(33, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Oyuncu Nick :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(72, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "E-Posta :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(38, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 19)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Kullanici Adi :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aefnet_Login_System.My.Resources.Resources.aef_min
        Me.PictureBox2.Location = New System.Drawing.Point(262, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(399, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'PictureRutbe
        '
        Me.PictureRutbe.BackColor = System.Drawing.Color.Transparent
        Me.PictureRutbe.Image = Global.Aefnet_Login_System.My.Resources.Resources.badge_default_min
        Me.PictureRutbe.Location = New System.Drawing.Point(754, 21)
        Me.PictureRutbe.Name = "PictureRutbe"
        Me.PictureRutbe.Size = New System.Drawing.Size(146, 141)
        Me.PictureRutbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureRutbe.TabIndex = 101
        Me.PictureRutbe.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(12, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(29, 25)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Edit_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(935, 568)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Profile"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRutbe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BtnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureRutbe As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblnick As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabelEditProfile As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotalmatch As Label
    Friend WithEvents lbltotalwon As Label
    Friend WithEvents lblpoint As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
