<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Pnelbar = New System.Windows.Forms.Panel()
        Me.BtnMininize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Kayit_upass = New System.Windows.Forms.TextBox()
        Me.Kayit_e_posta = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Kayit_nick = New System.Windows.Forms.TextBox()
        Me.kayit_uname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Pnelbar.SuspendLayout()
        CType(Me.BtnMininize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnelbar
        '
        Me.Pnelbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Pnelbar.Controls.Add(Me.BtnMininize)
        Me.Pnelbar.Controls.Add(Me.BtnClose)
        Me.Pnelbar.Controls.Add(Me.PictureBox5)
        Me.Pnelbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnelbar.Location = New System.Drawing.Point(0, 0)
        Me.Pnelbar.Name = "Pnelbar"
        Me.Pnelbar.Size = New System.Drawing.Size(403, 53)
        Me.Pnelbar.TabIndex = 1
        '
        'BtnMininize
        '
        Me.BtnMininize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMininize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMininize.Image = CType(resources.GetObject("BtnMininize.Image"), System.Drawing.Image)
        Me.BtnMininize.Location = New System.Drawing.Point(333, 12)
        Me.BtnMininize.Name = "BtnMininize"
        Me.BtnMininize.Size = New System.Drawing.Size(24, 24)
        Me.BtnMininize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMininize.TabIndex = 95
        Me.BtnMininize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(363, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 94
        Me.BtnClose.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Aefnet_Login_System.My.Resources.Resources.aefnetlogo
        Me.PictureBox5.Location = New System.Drawing.Point(3, -2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 83
        Me.PictureBox5.TabStop = False
        '
        'Kayit_upass
        '
        Me.Kayit_upass.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Kayit_upass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kayit_upass.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kayit_upass.ForeColor = System.Drawing.Color.Silver
        Me.Kayit_upass.Location = New System.Drawing.Point(94, 294)
        Me.Kayit_upass.MaxLength = 16
        Me.Kayit_upass.Name = "Kayit_upass"
        Me.Kayit_upass.Size = New System.Drawing.Size(211, 27)
        Me.Kayit_upass.TabIndex = 1
        Me.Kayit_upass.Text = "Parola"
        '
        'Kayit_e_posta
        '
        Me.Kayit_e_posta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Kayit_e_posta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kayit_e_posta.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kayit_e_posta.ForeColor = System.Drawing.Color.Silver
        Me.Kayit_e_posta.Location = New System.Drawing.Point(95, 348)
        Me.Kayit_e_posta.MaxLength = 50
        Me.Kayit_e_posta.Name = "Kayit_e_posta"
        Me.Kayit_e_posta.Size = New System.Drawing.Size(211, 27)
        Me.Kayit_e_posta.TabIndex = 2
        Me.Kayit_e_posta.Text = "E-Posta"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Location = New System.Drawing.Point(95, 381)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(211, 1)
        Me.Panel5.TabIndex = 86
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(95, 326)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(211, 1)
        Me.Panel4.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(96, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 1)
        Me.Panel3.TabIndex = 84
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Location = New System.Drawing.Point(95, 273)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(211, 1)
        Me.Panel6.TabIndex = 83
        '
        'Kayit_nick
        '
        Me.Kayit_nick.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Kayit_nick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kayit_nick.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kayit_nick.ForeColor = System.Drawing.Color.Silver
        Me.Kayit_nick.Location = New System.Drawing.Point(95, 404)
        Me.Kayit_nick.MaxLength = 12
        Me.Kayit_nick.Name = "Kayit_nick"
        Me.Kayit_nick.ShortcutsEnabled = False
        Me.Kayit_nick.Size = New System.Drawing.Size(210, 27)
        Me.Kayit_nick.TabIndex = 3
        Me.Kayit_nick.Text = "Oyuncu Nick"
        '
        'kayit_uname
        '
        Me.kayit_uname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.kayit_uname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kayit_uname.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kayit_uname.ForeColor = System.Drawing.Color.Silver
        Me.kayit_uname.Location = New System.Drawing.Point(94, 241)
        Me.kayit_uname.MaxLength = 12
        Me.kayit_uname.Name = "kayit_uname"
        Me.kayit_uname.ShortcutsEnabled = False
        Me.kayit_uname.Size = New System.Drawing.Size(211, 27)
        Me.kayit_uname.TabIndex = 0
        Me.kayit_uname.Text = "Kullanıcı Adı"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(96, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "KAYİT OL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aefnet_Login_System.My.Resources.Resources.aef_min
        Me.PictureBox2.Location = New System.Drawing.Point(60, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(287, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversion.ForeColor = System.Drawing.Color.Silver
        Me.lblversion.Location = New System.Drawing.Point(328, 612)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(63, 21)
        Me.lblversion.TabIndex = 91
        Me.lblversion.Text = "Version"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 642)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Kayit_upass)
        Me.Controls.Add(Me.Kayit_e_posta)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Kayit_nick)
        Me.Controls.Add(Me.kayit_uname)
        Me.Controls.Add(Me.Pnelbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Pnelbar.ResumeLayout(False)
        CType(Me.BtnMininize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pnelbar As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Kayit_upass As TextBox
    Friend WithEvents Kayit_e_posta As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Kayit_nick As TextBox
    Friend WithEvents kayit_uname As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblversion As Label
    Private WithEvents BtnMininize As PictureBox
    Private WithEvents BtnClose As PictureBox
End Class
