<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NickUpdate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NickUpdate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NickChange = New System.Windows.Forms.Button()
        Me.txtNickChange = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastPlayerNick = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblİnfo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NickChange)
        Me.GroupBox1.Controls.Add(Me.txtNickChange)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LastPlayerNick)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(245, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 239)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'NickChange
        '
        Me.NickChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NickChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NickChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NickChange.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NickChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NickChange.Location = New System.Drawing.Point(194, 162)
        Me.NickChange.Name = "NickChange"
        Me.NickChange.Size = New System.Drawing.Size(178, 42)
        Me.NickChange.TabIndex = 4
        Me.NickChange.Text = "Güncelle"
        Me.NickChange.UseVisualStyleBackColor = True
        '
        'txtNickChange
        '
        Me.txtNickChange.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtNickChange.Location = New System.Drawing.Point(194, 107)
        Me.txtNickChange.MaxLength = 12
        Me.txtNickChange.Name = "txtNickChange"
        Me.txtNickChange.ShortcutsEnabled = False
        Me.txtNickChange.Size = New System.Drawing.Size(178, 29)
        Me.txtNickChange.TabIndex = 3
        Me.txtNickChange.Text = "Nick Giriniz..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Mevcut Oyuncu Nick :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 19)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Yeni Oyuncu Nick : "
        '
        'LastPlayerNick
        '
        Me.LastPlayerNick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LastPlayerNick.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LastPlayerNick.FormattingEnabled = True
        Me.LastPlayerNick.Location = New System.Drawing.Point(194, 55)
        Me.LastPlayerNick.Name = "LastPlayerNick"
        Me.LastPlayerNick.Size = New System.Drawing.Size(178, 29)
        Me.LastPlayerNick.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 25)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblİnfo
        '
        Me.lblİnfo.AutoSize = True
        Me.lblİnfo.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.lblİnfo.ForeColor = System.Drawing.Color.White
        Me.lblİnfo.Location = New System.Drawing.Point(140, 226)
        Me.lblİnfo.Name = "lblİnfo"
        Me.lblİnfo.Size = New System.Drawing.Size(397, 21)
        Me.lblİnfo.TabIndex = 82
        Me.lblİnfo.Text = "Nickler Ayda Sadece Bir Kez Değişmektedir. Siz En Son : "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aefnet_Login_System.My.Resources.Resources.aef_min
        Me.PictureBox2.Location = New System.Drawing.Point(284, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(390, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NickUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(935, 568)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblİnfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NickUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NickUpdate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnClose As Button
    Friend WithEvents NickChange As Button
    Friend WithEvents txtNickChange As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LastPlayerNick As ComboBox
    Friend WithEvents lblİnfo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
