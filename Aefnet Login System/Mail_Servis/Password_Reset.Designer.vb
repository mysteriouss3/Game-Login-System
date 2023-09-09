<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forget_Password
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forget_Password))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Posta = New System.Windows.Forms.TextBox()
        Me.KodSend = New System.Windows.Forms.Button()
        Me.PanelBarr = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMininize = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PanelBarr.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(42, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "E-Posta :"
        '
        'Posta
        '
        Me.Posta.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Posta.Location = New System.Drawing.Point(125, 92)
        Me.Posta.MaxLength = 30
        Me.Posta.Name = "Posta"
        Me.Posta.Size = New System.Drawing.Size(267, 24)
        Me.Posta.TabIndex = 75
        '
        'KodSend
        '
        Me.KodSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.KodSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.KodSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KodSend.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.KodSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KodSend.Location = New System.Drawing.Point(326, 156)
        Me.KodSend.Name = "KodSend"
        Me.KodSend.Size = New System.Drawing.Size(113, 35)
        Me.KodSend.TabIndex = 77
        Me.KodSend.Text = "Gönder"
        Me.KodSend.UseVisualStyleBackColor = False
        '
        'PanelBarr
        '
        Me.PanelBarr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBarr.Controls.Add(Me.Label3)
        Me.PanelBarr.Controls.Add(Me.BtnClose)
        Me.PanelBarr.Controls.Add(Me.BtnMininize)
        Me.PanelBarr.Location = New System.Drawing.Point(-1, -1)
        Me.PanelBarr.Name = "PanelBarr"
        Me.PanelBarr.Size = New System.Drawing.Size(454, 53)
        Me.PanelBarr.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ŞİFRE KURTARMA İSTEĞİ"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Silver
        Me.BtnClose.Location = New System.Drawing.Point(415, 8)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(26, 33)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnMininize
        '
        Me.BtnMininize.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnMininize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMininize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnMininize.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnMininize.Location = New System.Drawing.Point(383, 8)
        Me.BtnMininize.Name = "BtnMininize"
        Me.BtnMininize.Size = New System.Drawing.Size(26, 33)
        Me.BtnMininize.TabIndex = 1
        Me.BtnMininize.Text = "_"
        Me.BtnMininize.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aefnet_Login_System.My.Resources.Resources.warning
        Me.PictureBox1.Location = New System.Drawing.Point(125, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(145, 126)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 16)
        Me.lblError.TabIndex = 92
        Me.lblError.Text = "Test"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 178)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(166, 13)
        Me.LinkLabel1.TabIndex = 93
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "E-Posta Adresimi Hatirlamiyorum?"
        '
        'Forget_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 203)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelBarr)
        Me.Controls.Add(Me.KodSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Posta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Forget_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PasswordForget"
        Me.PanelBarr.ResumeLayout(False)
        Me.PanelBarr.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Posta As TextBox
    Friend WithEvents KodSend As Button
    Friend WithEvents PanelBarr As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMininize As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblError As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
