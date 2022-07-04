<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btn_mini = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_maxi = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_logout = New Guna.UI.WinForms.GunaButton()
        Me.btn_about = New Guna.UI.WinForms.GunaButton()
        Me.btn_archives = New Guna.UI.WinForms.GunaButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_acc = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_update = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_reg = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_dash = New Guna.UI.WinForms.GunaButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImageHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btn_exit = New Guna.UI.WinForms.GunaControlBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.btn_act = New Guna.UI.WinForms.GunaButton()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_mini
        '
        Me.btn_mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mini.AnimationHoverSpeed = 0.07!
        Me.btn_mini.AnimationSpeed = 0.03!
        Me.btn_mini.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btn_mini.IconColor = System.Drawing.Color.White
        Me.btn_mini.IconSize = 10.0!
        Me.btn_mini.Location = New System.Drawing.Point(953, 1)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mini.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_mini.OnPressedColor = System.Drawing.Color.White
        Me.btn_mini.Size = New System.Drawing.Size(45, 38)
        Me.btn_mini.TabIndex = 6
        '
        'btn_maxi
        '
        Me.btn_maxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maxi.AnimationHoverSpeed = 0.07!
        Me.btn_maxi.AnimationSpeed = 0.03!
        Me.btn_maxi.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.btn_maxi.IconColor = System.Drawing.Color.White
        Me.btn_maxi.IconSize = 10.0!
        Me.btn_maxi.Location = New System.Drawing.Point(1004, 1)
        Me.btn_maxi.Name = "btn_maxi"
        Me.btn_maxi.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_maxi.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_maxi.OnPressedColor = System.Drawing.Color.White
        Me.btn_maxi.Size = New System.Drawing.Size(45, 38)
        Me.btn_maxi.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btn_logout)
        Me.Panel7.Controls.Add(Me.btn_about)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 688)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(260, 100)
        Me.Panel7.TabIndex = 9
        '
        'btn_logout
        '
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_logout.Location = New System.Drawing.Point(6, 52)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_logout.OnHoverImage = CType(resources.GetObject("btn_logout.OnHoverImage"), System.Drawing.Image)
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Radius = 10
        Me.btn_logout.Size = New System.Drawing.Size(245, 42)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "LOG-OUT"
        Me.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_about
        '
        Me.btn_about.AnimationHoverSpeed = 0.07!
        Me.btn_about.AnimationSpeed = 0.03!
        Me.btn_about.BackColor = System.Drawing.Color.Transparent
        Me.btn_about.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.BorderColor = System.Drawing.Color.Black
        Me.btn_about.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_about.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.ForeColor = System.Drawing.Color.White
        Me.btn_about.Image = CType(resources.GetObject("btn_about.Image"), System.Drawing.Image)
        Me.btn_about.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_about.Location = New System.Drawing.Point(6, 8)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_about.OnHoverImage = Global.SPARTA.My.Resources.Resources.icons8_info_20
        Me.btn_about.OnPressedColor = System.Drawing.Color.Black
        Me.btn_about.Radius = 10
        Me.btn_about.Size = New System.Drawing.Size(245, 42)
        Me.btn_about.TabIndex = 5
        Me.btn_about.Text = "ABOUT"
        Me.btn_about.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_archives
        '
        Me.btn_archives.AnimationHoverSpeed = 0.07!
        Me.btn_archives.AnimationSpeed = 0.03!
        Me.btn_archives.BackColor = System.Drawing.Color.Transparent
        Me.btn_archives.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_archives.BorderColor = System.Drawing.Color.Black
        Me.btn_archives.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_archives.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_archives.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archives.ForeColor = System.Drawing.Color.White
        Me.btn_archives.Image = CType(resources.GetObject("btn_archives.Image"), System.Drawing.Image)
        Me.btn_archives.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_archives.Location = New System.Drawing.Point(6, 13)
        Me.btn_archives.Name = "btn_archives"
        Me.btn_archives.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_archives.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_archives.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_archives.OnHoverImage = CType(resources.GetObject("btn_archives.OnHoverImage"), System.Drawing.Image)
        Me.btn_archives.OnPressedColor = System.Drawing.Color.Black
        Me.btn_archives.Radius = 10
        Me.btn_archives.Size = New System.Drawing.Size(245, 42)
        Me.btn_archives.TabIndex = 4
        Me.btn_archives.Text = "ARCHIVES"
        Me.btn_archives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_archives)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 381)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(260, 55)
        Me.Panel5.TabIndex = 7
        '
        'btn_acc
        '
        Me.btn_acc.AnimationHoverSpeed = 0.07!
        Me.btn_acc.AnimationSpeed = 0.03!
        Me.btn_acc.BackColor = System.Drawing.Color.Transparent
        Me.btn_acc.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_acc.BorderColor = System.Drawing.Color.Black
        Me.btn_acc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_acc.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_acc.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acc.ForeColor = System.Drawing.Color.White
        Me.btn_acc.Image = CType(resources.GetObject("btn_acc.Image"), System.Drawing.Image)
        Me.btn_acc.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_acc.Location = New System.Drawing.Point(6, 6)
        Me.btn_acc.Name = "btn_acc"
        Me.btn_acc.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_acc.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_acc.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_acc.OnHoverImage = CType(resources.GetObject("btn_acc.OnHoverImage"), System.Drawing.Image)
        Me.btn_acc.OnPressedColor = System.Drawing.Color.Black
        Me.btn_acc.Radius = 10
        Me.btn_acc.Size = New System.Drawing.Size(245, 42)
        Me.btn_acc.TabIndex = 3
        Me.btn_acc.Text = "ACCOUNTS"
        Me.btn_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_acc)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 326)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 55)
        Me.Panel4.TabIndex = 6
        '
        'btn_update
        '
        Me.btn_update.AnimationHoverSpeed = 0.07!
        Me.btn_update.AnimationSpeed = 0.03!
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.BorderColor = System.Drawing.Color.Black
        Me.btn_update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_update.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_update.Location = New System.Drawing.Point(6, 7)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_update.OnHoverImage = CType(resources.GetObject("btn_update.OnHoverImage"), System.Drawing.Image)
        Me.btn_update.OnPressedColor = System.Drawing.Color.Black
        Me.btn_update.Radius = 10
        Me.btn_update.Size = New System.Drawing.Size(245, 42)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "UPDATE / DELETE ACC"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_update)
        Me.Panel3.Controls.Add(Me.btn_act)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 271)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 55)
        Me.Panel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_reg)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 55)
        Me.Panel2.TabIndex = 4
        '
        'btn_reg
        '
        Me.btn_reg.AnimationHoverSpeed = 0.07!
        Me.btn_reg.AnimationSpeed = 0.03!
        Me.btn_reg.BackColor = System.Drawing.Color.Transparent
        Me.btn_reg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reg.BorderColor = System.Drawing.Color.Black
        Me.btn_reg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_reg.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reg.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg.ForeColor = System.Drawing.Color.White
        Me.btn_reg.Image = CType(resources.GetObject("btn_reg.Image"), System.Drawing.Image)
        Me.btn_reg.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_reg.Location = New System.Drawing.Point(6, 7)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reg.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reg.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_reg.OnHoverImage = CType(resources.GetObject("btn_reg.OnHoverImage"), System.Drawing.Image)
        Me.btn_reg.OnPressedColor = System.Drawing.Color.Black
        Me.btn_reg.Radius = 10
        Me.btn_reg.Size = New System.Drawing.Size(245, 42)
        Me.btn_reg.TabIndex = 3
        Me.btn_reg.Text = "REGISTRATION"
        Me.btn_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_dash)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 55)
        Me.Panel1.TabIndex = 3
        '
        'btn_dash
        '
        Me.btn_dash.AnimationHoverSpeed = 0.07!
        Me.btn_dash.AnimationSpeed = 0.03!
        Me.btn_dash.BackColor = System.Drawing.Color.Transparent
        Me.btn_dash.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_dash.BorderColor = System.Drawing.Color.Black
        Me.btn_dash.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_dash.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_dash.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash.ForeColor = System.Drawing.Color.White
        Me.btn_dash.Image = CType(resources.GetObject("btn_dash.Image"), System.Drawing.Image)
        Me.btn_dash.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_dash.Location = New System.Drawing.Point(6, 7)
        Me.btn_dash.Name = "btn_dash"
        Me.btn_dash.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_dash.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_dash.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_dash.OnHoverImage = CType(resources.GetObject("btn_dash.OnHoverImage"), System.Drawing.Image)
        Me.btn_dash.OnPressedColor = System.Drawing.Color.Black
        Me.btn_dash.Radius = 10
        Me.btn_dash.Size = New System.Drawing.Size(245, 42)
        Me.btn_dash.TabIndex = 2
        Me.btn_dash.Text = "DASHBOARD"
        Me.btn_dash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(260, 161)
        Me.PanelLogo.TabIndex = 0
        '
        'ImageHome
        '
        Me.ImageHome.Image = CType(resources.GetObject("ImageHome.Image"), System.Drawing.Image)
        Me.ImageHome.Location = New System.Drawing.Point(0, 0)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(260, 162)
        Me.ImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageHome.TabIndex = 0
        Me.ImageHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btn_mini)
        Me.PanelTitleBar.Controls.Add(Me.btn_maxi)
        Me.PanelTitleBar.Controls.Add(Me.btn_exit)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(260, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1103, 40)
        Me.PanelTitleBar.TabIndex = 4
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.AnimationHoverSpeed = 0.07!
        Me.btn_exit.AnimationSpeed = 0.03!
        Me.btn_exit.IconColor = System.Drawing.Color.White
        Me.btn_exit.IconSize = 10.0!
        Me.btn_exit.Location = New System.Drawing.Point(1055, 1)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_exit.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_exit.OnPressedColor = System.Drawing.Color.White
        Me.btn_exit.Size = New System.Drawing.Size(45, 38)
        Me.btn_exit.TabIndex = 5
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.GunaSeparator1)
        Me.PanelMenu.Controls.Add(Me.Panel7)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(260, 788)
        Me.PanelMenu.TabIndex = 3
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.White
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(260, 40)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1103, 748)
        Me.PanelDesktop.TabIndex = 5
        '
        'btn_act
        '
        Me.btn_act.AnimationHoverSpeed = 0.07!
        Me.btn_act.AnimationSpeed = 0.03!
        Me.btn_act.BackColor = System.Drawing.Color.Transparent
        Me.btn_act.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_act.BorderColor = System.Drawing.Color.Black
        Me.btn_act.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_act.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_act.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_act.ForeColor = System.Drawing.Color.White
        Me.btn_act.Image = CType(resources.GetObject("btn_act.Image"), System.Drawing.Image)
        Me.btn_act.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_act.Location = New System.Drawing.Point(6, 7)
        Me.btn_act.Name = "btn_act"
        Me.btn_act.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_act.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_act.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_act.OnHoverImage = CType(resources.GetObject("btn_act.OnHoverImage"), System.Drawing.Image)
        Me.btn_act.OnPressedColor = System.Drawing.Color.Black
        Me.btn_act.Radius = 10
        Me.btn_act.Size = New System.Drawing.Size(245, 42)
        Me.btn_act.TabIndex = 4
        Me.btn_act.Text = "ACTIVITY LOG"
        Me.btn_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_act.Visible = False
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(12, 442)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(225, 10)
        Me.GunaSeparator1.TabIndex = 10
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 788)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_mini As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_maxi As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_about As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_archives As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_acc As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_update As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_reg As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_dash As Guna.UI.WinForms.GunaButton
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents btn_exit As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btn_act As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
End Class
