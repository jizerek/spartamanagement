<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archive
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtpTo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtpFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvArchives = New System.Windows.Forms.DataGridView()
        CType(Me.dgvArchives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(115, 236)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(879, 459)
        Me.ListView1.TabIndex = 87
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
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
        Me.btn_search.Location = New System.Drawing.Point(884, 148)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(110, 53)
        Me.btn_search.TabIndex = 86
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_reset
        '
        Me.btn_reset.ActiveBorderThickness = 1
        Me.btn_reset.ActiveCornerRadius = 20
        Me.btn_reset.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reset.ActiveForecolor = System.Drawing.Color.White
        Me.btn_reset.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reset.BackColor = System.Drawing.Color.White
        Me.btn_reset.BackgroundImage = CType(resources.GetObject("btn_reset.BackgroundImage"), System.Drawing.Image)
        Me.btn_reset.ButtonText = "RELOAD"
        Me.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reset.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.IdleBorderThickness = 3
        Me.btn_reset.IdleCornerRadius = 20
        Me.btn_reset.IdleFillColor = System.Drawing.Color.White
        Me.btn_reset.IdleForecolor = System.Drawing.Color.Black
        Me.btn_reset.IdleLineColor = System.Drawing.Color.Black
        Me.btn_reset.Location = New System.Drawing.Point(757, 148)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(110, 53)
        Me.btn_reset.TabIndex = 85
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTo
        '
        Me.dtpTo.BackColor = System.Drawing.Color.Transparent
        Me.dtpTo.BaseColor = System.Drawing.Color.White
        Me.dtpTo.BorderColor = System.Drawing.Color.Silver
        Me.dtpTo.BorderSize = 3
        Me.dtpTo.CustomFormat = Nothing
        Me.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.ForeColor = System.Drawing.Color.Black
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(506, 162)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpTo.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpTo.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTo.Radius = 8
        Me.dtpTo.Size = New System.Drawing.Size(215, 30)
        Me.dtpTo.TabIndex = 84
        Me.dtpTo.Text = "8/30/2021"
        Me.dtpTo.Value = New Date(2021, 8, 30, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.BackColor = System.Drawing.Color.Transparent
        Me.dtpFrom.BaseColor = System.Drawing.Color.White
        Me.dtpFrom.BorderColor = System.Drawing.Color.Silver
        Me.dtpFrom.BorderSize = 3
        Me.dtpFrom.CustomFormat = Nothing
        Me.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(188, 162)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpFrom.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpFrom.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFrom.Radius = 8
        Me.dtpFrom.Size = New System.Drawing.Size(215, 30)
        Me.dtpFrom.TabIndex = 83
        Me.dtpFrom.Text = "8/30/2021"
        Me.dtpFrom.Value = New Date(2021, 8, 30, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(451, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 23)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(111, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "From:"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(55, 117)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1000, 10)
        Me.GunaSeparator1.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(77, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 33)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Archives"
        '
        'dgvArchives
        '
        Me.dgvArchives.AllowUserToAddRows = False
        Me.dgvArchives.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvArchives.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArchives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArchives.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvArchives.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvArchives.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchives.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArchives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArchives.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArchives.EnableHeadersVisualStyles = False
        Me.dgvArchives.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvArchives.Location = New System.Drawing.Point(115, 236)
        Me.dgvArchives.MultiSelect = False
        Me.dgvArchives.Name = "dgvArchives"
        Me.dgvArchives.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchives.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvArchives.RowHeadersVisible = False
        Me.dgvArchives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvArchives.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvArchives.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArchives.Size = New System.Drawing.Size(879, 459)
        Me.dgvArchives.TabIndex = 100
        '
        'Archive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 748)
        Me.Controls.Add(Me.dgvArchives)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Archive"
        Me.Text = "Archive"
        CType(Me.dgvArchives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dtpTo As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtpFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvArchives As DataGridView
End Class
