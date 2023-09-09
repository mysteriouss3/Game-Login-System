<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaddersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaddersForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Datas = New System.Windows.Forms.DataGridView()
        Me.PlayerNick = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_won = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Match = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Datas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Datas
        '
        Me.Datas.AllowUserToAddRows = False
        Me.Datas.AllowUserToDeleteRows = False
        Me.Datas.AllowUserToResizeColumns = False
        Me.Datas.AllowUserToResizeRows = False
        Me.Datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Datas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Datas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Datas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Datas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.Datas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Datas.ColumnHeadersHeight = 40
        Me.Datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlayerNick, Me.Point, Me.Total_won, Me.Total_Match})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datas.DefaultCellStyle = DataGridViewCellStyle2
        Me.Datas.EnableHeadersVisualStyles = False
        Me.Datas.GridColor = System.Drawing.Color.White
        Me.Datas.Location = New System.Drawing.Point(139, 101)
        Me.Datas.MultiSelect = False
        Me.Datas.Name = "Datas"
        Me.Datas.ReadOnly = True
        Me.Datas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Datas.RowHeadersVisible = False
        Me.Datas.RowHeadersWidth = 45
        Me.Datas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.Datas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Datas.RowTemplate.Height = 26
        Me.Datas.ShowRowErrors = False
        Me.Datas.Size = New System.Drawing.Size(657, 425)
        Me.Datas.TabIndex = 10
        '
        'PlayerNick
        '
        Me.PlayerNick.DataPropertyName = "name"
        Me.PlayerNick.Frozen = True
        Me.PlayerNick.HeaderText = "Oyuncu Nick"
        Me.PlayerNick.Name = "PlayerNick"
        Me.PlayerNick.ReadOnly = True
        Me.PlayerNick.Width = 133
        '
        'Point
        '
        Me.Point.DataPropertyName = "point"
        Me.Point.HeaderText = "Oyuncu Puan"
        Me.Point.Name = "Point"
        Me.Point.ReadOnly = True
        Me.Point.Width = 137
        '
        'Total_won
        '
        Me.Total_won.DataPropertyName = "total_won"
        Me.Total_won.HeaderText = "Toplam Zafer Sayisi"
        Me.Total_won.Name = "Total_won"
        Me.Total_won.ReadOnly = True
        Me.Total_won.Width = 185
        '
        'Total_Match
        '
        Me.Total_Match.DataPropertyName = "total_match"
        Me.Total_Match.HeaderText = "Toplam Maç Sayisi"
        Me.Total_Match.Name = "Total_Match"
        Me.Total_Match.ReadOnly = True
        Me.Total_Match.Width = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(251, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "1 VS 1 OYUNCU İSTATİSTİKLERİ"
        '
        'LaddersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(935, 568)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Datas)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaddersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Datas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BtnClose As Button
    Friend WithEvents Datas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayerNick As DataGridViewTextBoxColumn
    Friend WithEvents Point As DataGridViewTextBoxColumn
    Friend WithEvents Total_won As DataGridViewTextBoxColumn
    Friend WithEvents Total_Match As DataGridViewTextBoxColumn
End Class
