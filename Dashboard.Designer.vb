<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.PanelSharedSubMenu = New System.Windows.Forms.Panel()
        Me.btn_sched = New Guna.UI.WinForms.GunaButton()
        Me.btn_soa = New Guna.UI.WinForms.GunaButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_shared = New Guna.UI.WinForms.GunaButton()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_about = New Guna.UI.WinForms.GunaButton()
        Me.btn_logout = New Guna.UI.WinForms.GunaButton()
        Me.PanelFinancingSubMenu = New System.Windows.Forms.Panel()
        Me.btn_new = New Guna.UI.WinForms.GunaButton()
        Me.btn_newfinancing = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_financing = New Guna.UI.WinForms.GunaButton()
        Me.PanelCusSubMenu = New System.Windows.Forms.Panel()
        Me.btn_cus = New Guna.UI.WinForms.GunaButton()
        Me.PanelLoanSubMenu = New System.Windows.Forms.Panel()
        Me.btn_LA = New Guna.UI.WinForms.GunaButton()
        Me.btn_UBI = New Guna.UI.WinForms.GunaButton()
        Me.btn_borrow = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_loan = New Guna.UI.WinForms.GunaButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Pangalan = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_branch = New System.Windows.Forms.Label()
        Me.btn_mini = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_exit = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_maxi = New Guna.UI.WinForms.GunaControlBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelSharedSubMenu.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelFinancingSubMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelCusSubMenu.SuspendLayout()
        Me.PanelLoanSubMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.PanelSharedSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.Panel7)
        Me.PanelSideMenu.Controls.Add(Me.GunaSeparator1)
        Me.PanelSideMenu.Controls.Add(Me.Panel5)
        Me.PanelSideMenu.Controls.Add(Me.PanelFinancingSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.Panel4)
        Me.PanelSideMenu.Controls.Add(Me.PanelCusSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.PanelLoanSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.Panel3)
        Me.PanelSideMenu.Controls.Add(Me.PanelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(295, 788)
        Me.PanelSideMenu.TabIndex = 0
        '
        'PanelSharedSubMenu
        '
        Me.PanelSharedSubMenu.Controls.Add(Me.btn_sched)
        Me.PanelSharedSubMenu.Controls.Add(Me.btn_soa)
        Me.PanelSharedSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSharedSubMenu.Location = New System.Drawing.Point(0, 629)
        Me.PanelSharedSubMenu.Name = "PanelSharedSubMenu"
        Me.PanelSharedSubMenu.Size = New System.Drawing.Size(278, 94)
        Me.PanelSharedSubMenu.TabIndex = 13
        '
        'btn_sched
        '
        Me.btn_sched.AnimationHoverSpeed = 0.07!
        Me.btn_sched.AnimationSpeed = 0.03!
        Me.btn_sched.BackColor = System.Drawing.Color.Transparent
        Me.btn_sched.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_sched.BorderColor = System.Drawing.Color.Black
        Me.btn_sched.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sched.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_sched.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sched.ForeColor = System.Drawing.Color.Black
        Me.btn_sched.Image = Nothing
        Me.btn_sched.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_sched.Location = New System.Drawing.Point(18, 47)
        Me.btn_sched.Name = "btn_sched"
        Me.btn_sched.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_sched.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_sched.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sched.OnHoverImage = Nothing
        Me.btn_sched.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sched.Radius = 10
        Me.btn_sched.Size = New System.Drawing.Size(230, 42)
        Me.btn_sched.TabIndex = 9
        Me.btn_sched.Text = "Deliquency"
        Me.btn_sched.TextOffsetX = 10
        '
        'btn_soa
        '
        Me.btn_soa.AnimationHoverSpeed = 0.07!
        Me.btn_soa.AnimationSpeed = 0.03!
        Me.btn_soa.BackColor = System.Drawing.Color.Transparent
        Me.btn_soa.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_soa.BorderColor = System.Drawing.Color.Black
        Me.btn_soa.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_soa.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_soa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_soa.ForeColor = System.Drawing.Color.Black
        Me.btn_soa.Image = Nothing
        Me.btn_soa.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_soa.Location = New System.Drawing.Point(18, 3)
        Me.btn_soa.Name = "btn_soa"
        Me.btn_soa.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_soa.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_soa.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_soa.OnHoverImage = Nothing
        Me.btn_soa.OnPressedColor = System.Drawing.Color.Black
        Me.btn_soa.Radius = 10
        Me.btn_soa.Size = New System.Drawing.Size(230, 42)
        Me.btn_soa.TabIndex = 8
        Me.btn_soa.Text = "Statement of Account"
        Me.btn_soa.TextOffsetX = 10
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btn_shared)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 574)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(278, 55)
        Me.Panel7.TabIndex = 12
        '
        'btn_shared
        '
        Me.btn_shared.AnimationHoverSpeed = 0.07!
        Me.btn_shared.AnimationSpeed = 0.03!
        Me.btn_shared.BackColor = System.Drawing.Color.Transparent
        Me.btn_shared.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_shared.BorderColor = System.Drawing.Color.Black
        Me.btn_shared.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_shared.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_shared.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_shared.ForeColor = System.Drawing.Color.Black
        Me.btn_shared.Image = CType(resources.GetObject("btn_shared.Image"), System.Drawing.Image)
        Me.btn_shared.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_shared.Location = New System.Drawing.Point(12, 6)
        Me.btn_shared.Name = "btn_shared"
        Me.btn_shared.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_shared.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_shared.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_shared.OnHoverImage = CType(resources.GetObject("btn_shared.OnHoverImage"), System.Drawing.Image)
        Me.btn_shared.OnPressedColor = System.Drawing.Color.Black
        Me.btn_shared.Radius = 10
        Me.btn_shared.Size = New System.Drawing.Size(246, 42)
        Me.btn_shared.TabIndex = 4
        Me.btn_shared.Text = "SHARED REPORTS"
        Me.btn_shared.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator1.Location = New System.Drawing.Point(15, 652)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(255, 10)
        Me.GunaSeparator1.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btn_about)
        Me.Panel5.Controls.Add(Me.btn_logout)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 723)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(278, 90)
        Me.Panel5.TabIndex = 9
        '
        'btn_about
        '
        Me.btn_about.AnimationHoverSpeed = 0.07!
        Me.btn_about.AnimationSpeed = 0.03!
        Me.btn_about.BackColor = System.Drawing.Color.Transparent
        Me.btn_about.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_about.BorderColor = System.Drawing.Color.Black
        Me.btn_about.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_about.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.ForeColor = System.Drawing.Color.Black
        Me.btn_about.Image = CType(resources.GetObject("btn_about.Image"), System.Drawing.Image)
        Me.btn_about.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_about.Location = New System.Drawing.Point(18, 1)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_about.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_about.OnHoverImage = CType(resources.GetObject("btn_about.OnHoverImage"), System.Drawing.Image)
        Me.btn_about.OnPressedColor = System.Drawing.Color.Black
        Me.btn_about.Radius = 10
        Me.btn_about.Size = New System.Drawing.Size(246, 42)
        Me.btn_about.TabIndex = 4
        Me.btn_about.Text = "ABOUT"
        Me.btn_about.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_logout
        '
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_logout.Location = New System.Drawing.Point(18, 47)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_logout.OnHoverImage = CType(resources.GetObject("btn_logout.OnHoverImage"), System.Drawing.Image)
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Radius = 10
        Me.btn_logout.Size = New System.Drawing.Size(246, 42)
        Me.btn_logout.TabIndex = 3
        Me.btn_logout.Text = "LOG-OUT"
        Me.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelFinancingSubMenu
        '
        Me.PanelFinancingSubMenu.Controls.Add(Me.btn_new)
        Me.PanelFinancingSubMenu.Controls.Add(Me.btn_newfinancing)
        Me.PanelFinancingSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFinancingSubMenu.Location = New System.Drawing.Point(0, 470)
        Me.PanelFinancingSubMenu.Name = "PanelFinancingSubMenu"
        Me.PanelFinancingSubMenu.Size = New System.Drawing.Size(278, 104)
        Me.PanelFinancingSubMenu.TabIndex = 7
        '
        'btn_new
        '
        Me.btn_new.AnimationHoverSpeed = 0.07!
        Me.btn_new.AnimationSpeed = 0.03!
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_new.BorderColor = System.Drawing.Color.Black
        Me.btn_new.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_new.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_new.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.Black
        Me.btn_new.Image = Nothing
        Me.btn_new.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_new.Location = New System.Drawing.Point(18, 7)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_new.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_new.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_new.OnHoverImage = Nothing
        Me.btn_new.OnPressedColor = System.Drawing.Color.Black
        Me.btn_new.Radius = 10
        Me.btn_new.Size = New System.Drawing.Size(230, 42)
        Me.btn_new.TabIndex = 7
        Me.btn_new.Text = "New Account"
        Me.btn_new.TextOffsetX = 10
        '
        'btn_newfinancing
        '
        Me.btn_newfinancing.AnimationHoverSpeed = 0.07!
        Me.btn_newfinancing.AnimationSpeed = 0.03!
        Me.btn_newfinancing.BackColor = System.Drawing.Color.Transparent
        Me.btn_newfinancing.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_newfinancing.BorderColor = System.Drawing.Color.Black
        Me.btn_newfinancing.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_newfinancing.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_newfinancing.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newfinancing.ForeColor = System.Drawing.Color.Black
        Me.btn_newfinancing.Image = Nothing
        Me.btn_newfinancing.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_newfinancing.Location = New System.Drawing.Point(18, 55)
        Me.btn_newfinancing.Name = "btn_newfinancing"
        Me.btn_newfinancing.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_newfinancing.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_newfinancing.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_newfinancing.OnHoverImage = Nothing
        Me.btn_newfinancing.OnPressedColor = System.Drawing.Color.Black
        Me.btn_newfinancing.Radius = 10
        Me.btn_newfinancing.Size = New System.Drawing.Size(230, 42)
        Me.btn_newfinancing.TabIndex = 6
        Me.btn_newfinancing.Text = "Update Account"
        Me.btn_newfinancing.TextOffsetX = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_financing)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 415)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 55)
        Me.Panel4.TabIndex = 6
        '
        'btn_financing
        '
        Me.btn_financing.AnimationHoverSpeed = 0.07!
        Me.btn_financing.AnimationSpeed = 0.03!
        Me.btn_financing.BackColor = System.Drawing.Color.Transparent
        Me.btn_financing.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_financing.BorderColor = System.Drawing.Color.Black
        Me.btn_financing.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_financing.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_financing.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_financing.ForeColor = System.Drawing.Color.Black
        Me.btn_financing.Image = CType(resources.GetObject("btn_financing.Image"), System.Drawing.Image)
        Me.btn_financing.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_financing.Location = New System.Drawing.Point(13, 7)
        Me.btn_financing.Name = "btn_financing"
        Me.btn_financing.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_financing.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_financing.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_financing.OnHoverImage = CType(resources.GetObject("btn_financing.OnHoverImage"), System.Drawing.Image)
        Me.btn_financing.OnPressedColor = System.Drawing.Color.Black
        Me.btn_financing.Radius = 10
        Me.btn_financing.Size = New System.Drawing.Size(246, 42)
        Me.btn_financing.TabIndex = 2
        Me.btn_financing.Text = "FINANCING"
        Me.btn_financing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelCusSubMenu
        '
        Me.PanelCusSubMenu.Controls.Add(Me.btn_cus)
        Me.PanelCusSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCusSubMenu.Location = New System.Drawing.Point(0, 360)
        Me.PanelCusSubMenu.Name = "PanelCusSubMenu"
        Me.PanelCusSubMenu.Size = New System.Drawing.Size(278, 55)
        Me.PanelCusSubMenu.TabIndex = 5
        '
        'btn_cus
        '
        Me.btn_cus.AnimationHoverSpeed = 0.07!
        Me.btn_cus.AnimationSpeed = 0.03!
        Me.btn_cus.BackColor = System.Drawing.Color.Transparent
        Me.btn_cus.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_cus.BorderColor = System.Drawing.Color.Black
        Me.btn_cus.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cus.ForeColor = System.Drawing.Color.Black
        Me.btn_cus.Image = CType(resources.GetObject("btn_cus.Image"), System.Drawing.Image)
        Me.btn_cus.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_cus.Location = New System.Drawing.Point(12, 7)
        Me.btn_cus.Name = "btn_cus"
        Me.btn_cus.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cus.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cus.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cus.OnHoverImage = CType(resources.GetObject("btn_cus.OnHoverImage"), System.Drawing.Image)
        Me.btn_cus.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cus.Radius = 10
        Me.btn_cus.Size = New System.Drawing.Size(246, 42)
        Me.btn_cus.TabIndex = 2
        Me.btn_cus.Text = "CUSTOMER ACCOUNTING"
        Me.btn_cus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelLoanSubMenu
        '
        Me.PanelLoanSubMenu.Controls.Add(Me.btn_LA)
        Me.PanelLoanSubMenu.Controls.Add(Me.btn_UBI)
        Me.PanelLoanSubMenu.Controls.Add(Me.btn_borrow)
        Me.PanelLoanSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLoanSubMenu.Location = New System.Drawing.Point(0, 217)
        Me.PanelLoanSubMenu.Name = "PanelLoanSubMenu"
        Me.PanelLoanSubMenu.Size = New System.Drawing.Size(278, 143)
        Me.PanelLoanSubMenu.TabIndex = 4
        '
        'btn_LA
        '
        Me.btn_LA.AnimationHoverSpeed = 0.07!
        Me.btn_LA.AnimationSpeed = 0.03!
        Me.btn_LA.BackColor = System.Drawing.Color.Transparent
        Me.btn_LA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_LA.BorderColor = System.Drawing.Color.Black
        Me.btn_LA.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_LA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LA.ForeColor = System.Drawing.Color.Black
        Me.btn_LA.Image = Nothing
        Me.btn_LA.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_LA.Location = New System.Drawing.Point(17, 99)
        Me.btn_LA.Name = "btn_LA"
        Me.btn_LA.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LA.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LA.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_LA.OnHoverImage = Nothing
        Me.btn_LA.OnPressedColor = System.Drawing.Color.Black
        Me.btn_LA.Radius = 10
        Me.btn_LA.Size = New System.Drawing.Size(249, 42)
        Me.btn_LA.TabIndex = 5
        Me.btn_LA.Text = "Loan Accounts"
        Me.btn_LA.TextOffsetX = 10
        '
        'btn_UBI
        '
        Me.btn_UBI.AnimationHoverSpeed = 0.07!
        Me.btn_UBI.AnimationSpeed = 0.03!
        Me.btn_UBI.BackColor = System.Drawing.Color.Transparent
        Me.btn_UBI.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_UBI.BorderColor = System.Drawing.Color.Black
        Me.btn_UBI.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_UBI.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_UBI.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UBI.ForeColor = System.Drawing.Color.Black
        Me.btn_UBI.Image = Nothing
        Me.btn_UBI.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_UBI.Location = New System.Drawing.Point(18, 51)
        Me.btn_UBI.Name = "btn_UBI"
        Me.btn_UBI.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_UBI.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_UBI.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_UBI.OnHoverImage = Nothing
        Me.btn_UBI.OnPressedColor = System.Drawing.Color.Black
        Me.btn_UBI.Radius = 10
        Me.btn_UBI.Size = New System.Drawing.Size(249, 42)
        Me.btn_UBI.TabIndex = 4
        Me.btn_UBI.Text = "Update Borrower Information"
        Me.btn_UBI.TextOffsetX = 10
        '
        'btn_borrow
        '
        Me.btn_borrow.AnimationHoverSpeed = 0.07!
        Me.btn_borrow.AnimationSpeed = 0.03!
        Me.btn_borrow.BackColor = System.Drawing.Color.Transparent
        Me.btn_borrow.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_borrow.BorderColor = System.Drawing.Color.Black
        Me.btn_borrow.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_borrow.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_borrow.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrow.ForeColor = System.Drawing.Color.Black
        Me.btn_borrow.Image = Nothing
        Me.btn_borrow.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_borrow.Location = New System.Drawing.Point(18, 4)
        Me.btn_borrow.Name = "btn_borrow"
        Me.btn_borrow.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_borrow.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_borrow.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_borrow.OnHoverImage = Nothing
        Me.btn_borrow.OnPressedColor = System.Drawing.Color.Black
        Me.btn_borrow.Radius = 10
        Me.btn_borrow.Size = New System.Drawing.Size(249, 42)
        Me.btn_borrow.TabIndex = 3
        Me.btn_borrow.Text = "Borrow Information"
        Me.btn_borrow.TextOffsetX = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_loan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 162)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 55)
        Me.Panel3.TabIndex = 3
        '
        'btn_loan
        '
        Me.btn_loan.AnimationHoverSpeed = 0.07!
        Me.btn_loan.AnimationSpeed = 0.03!
        Me.btn_loan.BackColor = System.Drawing.Color.Transparent
        Me.btn_loan.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_loan.BorderColor = System.Drawing.Color.Black
        Me.btn_loan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_loan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_loan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loan.ForeColor = System.Drawing.Color.Black
        Me.btn_loan.Image = CType(resources.GetObject("btn_loan.Image"), System.Drawing.Image)
        Me.btn_loan.ImageSize = New System.Drawing.Size(21, 21)
        Me.btn_loan.Location = New System.Drawing.Point(12, 6)
        Me.btn_loan.Name = "btn_loan"
        Me.btn_loan.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_loan.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_loan.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_loan.OnHoverImage = CType(resources.GetObject("btn_loan.OnHoverImage"), System.Drawing.Image)
        Me.btn_loan.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_loan.Radius = 10
        Me.btn_loan.Size = New System.Drawing.Size(246, 42)
        Me.btn_loan.TabIndex = 1
        Me.btn_loan.Text = "LOAN"
        Me.btn_loan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.Pangalan)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(278, 162)
        Me.PanelLogo.TabIndex = 0
        '
        'Pangalan
        '
        Me.Pangalan.AutoSize = True
        Me.Pangalan.Location = New System.Drawing.Point(0, 0)
        Me.Pangalan.Name = "Pangalan"
        Me.Pangalan.Size = New System.Drawing.Size(39, 13)
        Me.Pangalan.TabIndex = 1
        Me.Pangalan.Text = "Label1"
        Me.Pangalan.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_branch)
        Me.Panel2.Controls.Add(Me.btn_mini)
        Me.Panel2.Controls.Add(Me.btn_exit)
        Me.Panel2.Controls.Add(Me.btn_maxi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(295, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 41)
        Me.Panel2.TabIndex = 0
        '
        'lbl_branch
        '
        Me.lbl_branch.AutoSize = True
        Me.lbl_branch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch.ForeColor = System.Drawing.Color.Black
        Me.lbl_branch.Location = New System.Drawing.Point(16, 10)
        Me.lbl_branch.Name = "lbl_branch"
        Me.lbl_branch.Size = New System.Drawing.Size(79, 19)
        Me.lbl_branch.TabIndex = 4
        Me.lbl_branch.Text = "BRANCH"
        '
        'btn_mini
        '
        Me.btn_mini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mini.AnimationHoverSpeed = 0.07!
        Me.btn_mini.AnimationSpeed = 0.03!
        Me.btn_mini.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btn_mini.IconColor = System.Drawing.Color.Black
        Me.btn_mini.IconSize = 10.0!
        Me.btn_mini.Location = New System.Drawing.Point(918, 2)
        Me.btn_mini.Name = "btn_mini"
        Me.btn_mini.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_mini.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_mini.OnPressedColor = System.Drawing.Color.White
        Me.btn_mini.Size = New System.Drawing.Size(45, 38)
        Me.btn_mini.TabIndex = 3
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.AnimationHoverSpeed = 0.07!
        Me.btn_exit.AnimationSpeed = 0.03!
        Me.btn_exit.IconColor = System.Drawing.Color.Black
        Me.btn_exit.IconSize = 10.0!
        Me.btn_exit.Location = New System.Drawing.Point(1020, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_exit.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_exit.OnPressedColor = System.Drawing.Color.White
        Me.btn_exit.Size = New System.Drawing.Size(45, 38)
        Me.btn_exit.TabIndex = 2
        '
        'btn_maxi
        '
        Me.btn_maxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maxi.AnimationHoverSpeed = 0.07!
        Me.btn_maxi.AnimationSpeed = 0.03!
        Me.btn_maxi.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.btn_maxi.IconColor = System.Drawing.Color.Black
        Me.btn_maxi.IconSize = 10.0!
        Me.btn_maxi.Location = New System.Drawing.Point(969, 2)
        Me.btn_maxi.Name = "btn_maxi"
        Me.btn_maxi.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_maxi.OnHoverIconColor = System.Drawing.Color.White
        Me.btn_maxi.OnPressedColor = System.Drawing.Color.White
        Me.btn_maxi.Size = New System.Drawing.Size(45, 38)
        Me.btn_maxi.TabIndex = 1
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.White
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(295, 41)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(1068, 747)
        Me.PanelChildForm.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1363, 788)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelSharedSubMenu.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.PanelFinancingSubMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelCusSubMenu.ResumeLayout(False)
        Me.PanelLoanSubMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_mini As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_exit As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_maxi As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents lbl_branch As Label
    Friend WithEvents btn_loan As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelLoanSubMenu As Panel
    Friend WithEvents btn_borrow As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelCusSubMenu As Panel
    Friend WithEvents btn_cus As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelFinancingSubMenu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_financing As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_about As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_shared As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelSharedSubMenu As Panel
    Friend WithEvents btn_soa As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_sched As Guna.UI.WinForms.GunaButton
    Friend WithEvents Pangalan As Label
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents btn_UBI As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_newfinancing As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_new As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_LA As Guna.UI.WinForms.GunaButton
End Class
