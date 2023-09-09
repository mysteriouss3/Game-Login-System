<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.Menum = New System.Windows.Forms.Timer(Me.components)
        Me.Menu2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBar = New System.Windows.Forms.Panel()
        Me.BtnMininize = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LinkLabelEditProfile = New System.Windows.Forms.LinkLabel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnOff = New System.Windows.Forms.PictureBox()
        Me.BtnMyİnfo = New System.Windows.Forms.Button()
        Me.BtnStatus = New System.Windows.Forms.Button()
        Me.BtnTop5 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PanelTool = New System.Windows.Forms.Panel()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.BtnHome = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Ana_Panel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBar.SuspendLayout()
        CType(Me.BtnMininize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTool.SuspendLayout()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menum
        '
        Me.Menum.Interval = 30
        '
        'Menu2
        '
        Me.Menu2.Interval = 30
        '
        'PanelBar
        '
        Me.PanelBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelBar.Controls.Add(Me.BtnMininize)
        Me.PanelBar.Controls.Add(Me.PictureBox1)
        Me.PanelBar.Controls.Add(Me.BtnClose)
        Me.PanelBar.Controls.Add(Me.Label4)
        Me.PanelBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelBar.Name = "PanelBar"
        Me.PanelBar.Size = New System.Drawing.Size(1200, 55)
        Me.PanelBar.TabIndex = 2
        '
        'BtnMininize
        '
        Me.BtnMininize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMininize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMininize.Image = CType(resources.GetObject("BtnMininize.Image"), System.Drawing.Image)
        Me.BtnMininize.Location = New System.Drawing.Point(1124, 12)
        Me.BtnMininize.Name = "BtnMininize"
        Me.BtnMininize.Size = New System.Drawing.Size(30, 30)
        Me.BtnMininize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMininize.TabIndex = 91
        Me.BtnMininize.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aefnet_Login_System.My.Resources.Resources.aefnetlogo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1158, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 90
        Me.BtnClose.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(70, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "AEFNET SİSTEM"
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.ProfilePanel)
        Me.panelMenu.Controls.Add(Me.PictureBox12)
        Me.panelMenu.Controls.Add(Me.PictureBox11)
        Me.panelMenu.Controls.Add(Me.PictureBox10)
        Me.panelMenu.Controls.Add(Me.PictureBox9)
        Me.panelMenu.Controls.Add(Me.Label5)
        Me.panelMenu.Controls.Add(Me.BtnOff)
        Me.panelMenu.Controls.Add(Me.BtnMyİnfo)
        Me.panelMenu.Controls.Add(Me.BtnStatus)
        Me.panelMenu.Controls.Add(Me.BtnTop5)
        Me.panelMenu.Controls.Add(Me.Button9)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 55)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(265, 645)
        Me.panelMenu.TabIndex = 3
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ProfilePanel.Controls.Add(Me.MenuButton)
        Me.ProfilePanel.Controls.Add(Me.lblUser)
        Me.ProfilePanel.Controls.Add(Me.lblRank)
        Me.ProfilePanel.Controls.Add(Me.lblNick)
        Me.ProfilePanel.Controls.Add(Me.PictureBox5)
        Me.ProfilePanel.Controls.Add(Me.LinkLabelEditProfile)
        Me.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(265, 149)
        Me.ProfilePanel.TabIndex = 0
        '
        'MenuButton
        '
        Me.MenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.ErrorImage = Nothing
        Me.MenuButton.Image = Global.Aefnet_Login_System.My.Resources.Resources.Menu_min
        Me.MenuButton.InitialImage = CType(resources.GetObject("MenuButton.InitialImage"), System.Drawing.Image)
        Me.MenuButton.Location = New System.Drawing.Point(219, 3)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(43, 37)
        Me.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuButton.TabIndex = 12
        Me.MenuButton.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.lblUser.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUser.Location = New System.Drawing.Point(57, 35)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(80, 19)
        Me.lblUser.TabIndex = 14
        Me.lblUser.Text = "Kullanıcı adı"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.lblRank.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRank.Location = New System.Drawing.Point(57, 90)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(45, 19)
        Me.lblRank.TabIndex = 13
        Me.lblRank.Text = "Rütbe"
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.lblNick.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblNick.Location = New System.Drawing.Point(58, 64)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(35, 19)
        Me.lblNick.TabIndex = 15
        Me.lblNick.Text = "Nick"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Aefnet_Login_System.My.Resources.Resources.profile_min
        Me.PictureBox5.Location = New System.Drawing.Point(5, 35)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(47, 74)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'LinkLabelEditProfile
        '
        Me.LinkLabelEditProfile.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.LinkLabelEditProfile.AutoSize = True
        Me.LinkLabelEditProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabelEditProfile.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LinkLabelEditProfile.LinkColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LinkLabelEditProfile.Location = New System.Drawing.Point(180, 122)
        Me.LinkLabelEditProfile.Name = "LinkLabelEditProfile"
        Me.LinkLabelEditProfile.Size = New System.Drawing.Size(79, 15)
        Me.LinkLabelEditProfile.TabIndex = 16
        Me.LinkLabelEditProfile.TabStop = True
        Me.LinkLabelEditProfile.Text = "Nick Değiştir"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox12.Image = Global.Aefnet_Login_System.My.Resources.Resources.status_min
        Me.PictureBox12.Location = New System.Drawing.Point(5, 323)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(47, 40)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 91
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = Global.Aefnet_Login_System.My.Resources.Resources.game_min
        Me.PictureBox11.Location = New System.Drawing.Point(5, 252)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 91
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = Global.Aefnet_Login_System.My.Resources.Resources.top5_min
        Me.PictureBox10.Location = New System.Drawing.Point(5, 385)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(47, 41)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 93
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Image = Global.Aefnet_Login_System.My.Resources.Resources.info_min
        Me.PictureBox9.Location = New System.Drawing.Point(5, 182)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 91
        Me.PictureBox9.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(194, 614)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Version"
        '
        'BtnOff
        '
        Me.BtnOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOff.Image = Global.Aefnet_Login_System.My.Resources.Resources.off_min
        Me.BtnOff.Location = New System.Drawing.Point(5, 581)
        Me.BtnOff.Name = "BtnOff"
        Me.BtnOff.Size = New System.Drawing.Size(47, 55)
        Me.BtnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnOff.TabIndex = 13
        Me.BtnOff.TabStop = False
        '
        'BtnMyİnfo
        '
        Me.BtnMyİnfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMyİnfo.FlatAppearance.BorderSize = 0
        Me.BtnMyİnfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnMyİnfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnMyİnfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMyİnfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMyİnfo.ForeColor = System.Drawing.Color.Silver
        Me.BtnMyİnfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMyİnfo.Location = New System.Drawing.Point(5, 182)
        Me.BtnMyİnfo.Name = "BtnMyİnfo"
        Me.BtnMyİnfo.Size = New System.Drawing.Size(223, 46)
        Me.BtnMyİnfo.TabIndex = 10
        Me.BtnMyİnfo.Text = "BİLGİLERİM"
        Me.BtnMyİnfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMyİnfo.UseVisualStyleBackColor = True
        '
        'BtnStatus
        '
        Me.BtnStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatus.FlatAppearance.BorderSize = 0
        Me.BtnStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatus.ForeColor = System.Drawing.Color.Silver
        Me.BtnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStatus.Location = New System.Drawing.Point(5, 319)
        Me.BtnStatus.Name = "BtnStatus"
        Me.BtnStatus.Size = New System.Drawing.Size(241, 44)
        Me.BtnStatus.TabIndex = 8
        Me.BtnStatus.Text = "İSTATİSTİKLER"
        Me.BtnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStatus.UseVisualStyleBackColor = True
        '
        'BtnTop5
        '
        Me.BtnTop5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTop5.FlatAppearance.BorderSize = 0
        Me.BtnTop5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnTop5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BtnTop5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTop5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTop5.ForeColor = System.Drawing.Color.Silver
        Me.BtnTop5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTop5.Location = New System.Drawing.Point(3, 385)
        Me.BtnTop5.Name = "BtnTop5"
        Me.BtnTop5.Size = New System.Drawing.Size(253, 41)
        Me.BtnTop5.TabIndex = 6
        Me.BtnTop5.Text = "EN İYİ 5 OYUNCU"
        Me.BtnTop5.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Silver
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(5, 253)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(251, 42)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "  TÜM OYUNCULAR"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PanelTool
        '
        Me.PanelTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PanelTool.Controls.Add(Me.lblHome)
        Me.PanelTool.Controls.Add(Me.BtnHome)
        Me.PanelTool.Controls.Add(Me.BtnStart)
        Me.PanelTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTool.Location = New System.Drawing.Point(265, 623)
        Me.PanelTool.Name = "PanelTool"
        Me.PanelTool.Size = New System.Drawing.Size(935, 77)
        Me.PanelTool.TabIndex = 6
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblHome.Location = New System.Drawing.Point(63, 29)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(82, 20)
        Me.lblHome.TabIndex = 95
        Me.lblHome.Text = "Ana Menü"
        '
        'BtnHome
        '
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.Image = Global.Aefnet_Login_System.My.Resources.Resources.Home_min
        Me.BtnHome.Location = New System.Drawing.Point(20, 15)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(40, 44)
        Me.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnHome.TabIndex = 90
        Me.BtnHome.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(775, 21)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(148, 41)
        Me.BtnStart.TabIndex = 82
        Me.BtnStart.Text = "OYUNU BASLAT"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'Ana_Panel
        '
        Me.Ana_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Ana_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ana_Panel.Location = New System.Drawing.Point(265, 55)
        Me.Ana_Panel.Name = "Ana_Panel"
        Me.Ana_Panel.Size = New System.Drawing.Size(935, 568)
        Me.Ana_Panel.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 3500
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.Ana_Panel)
        Me.Controls.Add(Me.PanelTool)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.PanelBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(680, 500)
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Profile"
        Me.PanelBar.ResumeLayout(False)
        Me.PanelBar.PerformLayout()
        CType(Me.BtnMininize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.ProfilePanel.ResumeLayout(False)
        Me.ProfilePanel.PerformLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTool.ResumeLayout(False)
        Me.PanelTool.PerformLayout()
        CType(Me.BtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menum As Timer
    Friend WithEvents Menu2 As Timer
    Private WithEvents PanelBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label4 As Label
    Friend WithEvents panelMenu As Panel
    Friend WithEvents LinkLabelEditProfile As LinkLabel
    Friend WithEvents Label5 As Label
    Private WithEvents MenuButton As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Private WithEvents BtnOff As PictureBox
    Private WithEvents BtnMyİnfo As Button
    Friend WithEvents lblRank As Label
    Private WithEvents BtnStatus As Button
    Friend WithEvents lblUser As Label
    Private WithEvents BtnTop5 As Button
    Private WithEvents Button9 As Button
    Private WithEvents PanelTool As Panel
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnHome As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents lblHome As Label
    Private WithEvents BtnMininize As PictureBox
    Private WithEvents BtnClose As PictureBox
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents Ana_Panel As Panel
    Public WithEvents lblNick As Label
    Friend WithEvents Timer1 As Timer
End Class
