<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbox_contact = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbo_position = New Guna.UI.WinForms.GunaComboBox()
        Me.txtbox_age = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbo_gender = New Guna.UI.WinForms.GunaComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_name = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lvAccounts = New System.Windows.Forms.ListView()
        Me.btn_search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(49, 109)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1000, 10)
        Me.GunaSeparator1.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(75, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 33)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Accounts"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpBirthdate)
        Me.GroupBox1.Controls.Add(Me.txtbox_pass)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtbox_user)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtbox_contact)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbo_position)
        Me.GroupBox1.Controls.Add(Me.txtbox_age)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbo_gender)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtbox_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbox_name)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 239)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CustomFormat = ""
        Me.dtpBirthdate.Location = New System.Drawing.Point(32471, 32513)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(212, 27)
        Me.dtpBirthdate.TabIndex = 112
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.Color.White
        Me.txtbox_pass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.ForeColor = System.Drawing.Color.Black
        Me.txtbox_pass.Location = New System.Drawing.Point(468, 190)
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.ReadOnly = True
        Me.txtbox_pass.Size = New System.Drawing.Size(212, 32)
        Me.txtbox_pass.TabIndex = 111
        Me.txtbox_pass.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(357, 198)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 19)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Password:"
        '
        'txtbox_user
        '
        Me.txtbox_user.BackColor = System.Drawing.Color.White
        Me.txtbox_user.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_user.ForeColor = System.Drawing.Color.Black
        Me.txtbox_user.Location = New System.Drawing.Point(468, 149)
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.ReadOnly = True
        Me.txtbox_user.Size = New System.Drawing.Size(212, 32)
        Me.txtbox_user.TabIndex = 109
        Me.txtbox_user.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(357, 159)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 19)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Username:"
        '
        'txtbox_contact
        '
        Me.txtbox_contact.BackColor = System.Drawing.Color.White
        Me.txtbox_contact.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_contact.ForeColor = System.Drawing.Color.Black
        Me.txtbox_contact.Location = New System.Drawing.Point(468, 106)
        Me.txtbox_contact.Multiline = True
        Me.txtbox_contact.Name = "txtbox_contact"
        Me.txtbox_contact.ReadOnly = True
        Me.txtbox_contact.Size = New System.Drawing.Size(212, 32)
        Me.txtbox_contact.TabIndex = 107
        Me.txtbox_contact.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(357, 115)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 19)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "Contact No.:"
        '
        'cmbo_position
        '
        Me.cmbo_position.BackColor = System.Drawing.Color.Transparent
        Me.cmbo_position.BaseColor = System.Drawing.Color.White
        Me.cmbo_position.BorderColor = System.Drawing.Color.Silver
        Me.cmbo_position.BorderSize = 3
        Me.cmbo_position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_position.Enabled = False
        Me.cmbo_position.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbo_position.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbo_position.ForeColor = System.Drawing.Color.Black
        Me.cmbo_position.FormattingEnabled = True
        Me.cmbo_position.Items.AddRange(New Object() {"Administrator", "Tele Collector", "Collection Assistant", "Legal Assistant"})
        Me.cmbo_position.Location = New System.Drawing.Point(124, 196)
        Me.cmbo_position.Name = "cmbo_position"
        Me.cmbo_position.OnHoverItemBaseColor = System.Drawing.Color.Silver
        Me.cmbo_position.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.cmbo_position.Radius = 8
        Me.cmbo_position.Size = New System.Drawing.Size(215, 27)
        Me.cmbo_position.TabIndex = 105
        Me.cmbo_position.TabStop = False
        '
        'txtbox_age
        '
        Me.txtbox_age.BackColor = System.Drawing.Color.White
        Me.txtbox_age.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_age.ForeColor = System.Drawing.Color.Black
        Me.txtbox_age.Location = New System.Drawing.Point(124, 150)
        Me.txtbox_age.Multiline = True
        Me.txtbox_age.Name = "txtbox_age"
        Me.txtbox_age.ReadOnly = True
        Me.txtbox_age.Size = New System.Drawing.Size(212, 32)
        Me.txtbox_age.TabIndex = 103
        Me.txtbox_age.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(15, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Position:"
        '
        'cmbo_gender
        '
        Me.cmbo_gender.BackColor = System.Drawing.Color.Transparent
        Me.cmbo_gender.BaseColor = System.Drawing.Color.White
        Me.cmbo_gender.BorderColor = System.Drawing.Color.Silver
        Me.cmbo_gender.BorderSize = 3
        Me.cmbo_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_gender.Enabled = False
        Me.cmbo_gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbo_gender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbo_gender.ForeColor = System.Drawing.Color.Black
        Me.cmbo_gender.FormattingEnabled = True
        Me.cmbo_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbo_gender.Location = New System.Drawing.Point(124, 111)
        Me.cmbo_gender.Name = "cmbo_gender"
        Me.cmbo_gender.OnHoverItemBaseColor = System.Drawing.Color.Silver
        Me.cmbo_gender.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.cmbo_gender.Radius = 8
        Me.cmbo_gender.Size = New System.Drawing.Size(215, 27)
        Me.cmbo_gender.TabIndex = 101
        Me.cmbo_gender.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 118)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Gender:"
        '
        'txtbox_id
        '
        Me.txtbox_id.BackColor = System.Drawing.Color.White
        Me.txtbox_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_id.ForeColor = System.Drawing.Color.Black
        Me.txtbox_id.Location = New System.Drawing.Point(124, 26)
        Me.txtbox_id.Multiline = True
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.Size = New System.Drawing.Size(212, 32)
        Me.txtbox_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "ID Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Name:"
        '
        'txtbox_name
        '
        Me.txtbox_name.BackColor = System.Drawing.Color.White
        Me.txtbox_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_name.ForeColor = System.Drawing.Color.Black
        Me.txtbox_name.Location = New System.Drawing.Point(124, 69)
        Me.txtbox_name.Multiline = True
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.ReadOnly = True
        Me.txtbox_name.Size = New System.Drawing.Size(337, 32)
        Me.txtbox_name.TabIndex = 99
        Me.txtbox_name.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbImage)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(716, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 170)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(21, 32)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(151, 119)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'lvAccounts
        '
        Me.lvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAccounts.Location = New System.Drawing.Point(75, 396)
        Me.lvAccounts.MultiSelect = False
        Me.lvAccounts.Name = "lvAccounts"
        Me.lvAccounts.Size = New System.Drawing.Size(932, 211)
        Me.lvAccounts.TabIndex = 79
        Me.lvAccounts.UseCompatibleStateImageBehavior = False
        Me.lvAccounts.View = System.Windows.Forms.View.Details
        Me.lvAccounts.Visible = False
        '
        'btn_search
        '
        Me.btn_search.ActiveBorderThickness = 1
        Me.btn_search.ActiveCornerRadius = 20
        Me.btn_search.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_search.ActiveForecolor = System.Drawing.Color.White
        Me.btn_search.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_search.BackColor = System.Drawing.Color.White
        Me.btn_search.BackgroundImage = CType(resources.GetObject("btn_search.BackgroundImage"), System.Drawing.Image)
        Me.btn_search.ButtonText = "SEARCH"
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.IdleBorderThickness = 3
        Me.btn_search.IdleCornerRadius = 20
        Me.btn_search.IdleFillColor = System.Drawing.Color.White
        Me.btn_search.IdleForecolor = System.Drawing.Color.Black
        Me.btn_search.IdleLineColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(836, 621)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(171, 53)
        Me.btn_search.TabIndex = 98
        Me.btn_search.TabStop = False
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.ActiveBorderThickness = 1
        Me.btn_cancel.ActiveCornerRadius = 20
        Me.btn_cancel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.BackColor = System.Drawing.Color.White
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.ButtonText = "CANCEL"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 3
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(643, 621)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(171, 53)
        Me.btn_cancel.TabIndex = 97
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccounts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAccounts.EnableHeadersVisualStyles = False
        Me.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvAccounts.Location = New System.Drawing.Point(75, 396)
        Me.dgvAccounts.MultiSelect = False
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvAccounts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccounts.Size = New System.Drawing.Size(932, 211)
        Me.dgvAccounts.TabIndex = 99
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 709)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lvAccounts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents txtbox_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents txtbox_age As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbo_gender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbo_position As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_contact As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lvAccounts As ListView
    Friend WithEvents btn_search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents dgvAccounts As DataGridView
End Class
