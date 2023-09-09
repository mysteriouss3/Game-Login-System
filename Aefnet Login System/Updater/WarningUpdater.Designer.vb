<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarningUpdater
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
        Me.PanelBarr = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KodSend = New System.Windows.Forms.Button()
        Me.PanelBarr.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarr
        '
        Me.PanelBarr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBarr.Controls.Add(Me.Label3)
        Me.PanelBarr.Location = New System.Drawing.Point(-1, -3)
        Me.PanelBarr.Name = "PanelBarr"
        Me.PanelBarr.Size = New System.Drawing.Size(498, 55)
        Me.PanelBarr.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(118, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "AEFNET GÜNCELLEYİCİ SİSTEMİ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 36)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Label1"
        '
        'KodSend
        '
        Me.KodSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.KodSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.KodSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KodSend.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KodSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KodSend.Location = New System.Drawing.Point(378, 123)
        Me.KodSend.Name = "KodSend"
        Me.KodSend.Size = New System.Drawing.Size(106, 29)
        Me.KodSend.TabIndex = 93
        Me.KodSend.Text = "Güncelle"
        Me.KodSend.UseVisualStyleBackColor = False
        '
        'WarningUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 164)
        Me.Controls.Add(Me.KodSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelBarr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WarningUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelBarr.ResumeLayout(False)
        Me.PanelBarr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarr As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KodSend As Button
End Class
