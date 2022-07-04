<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Del
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Del))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbo_financing = New Guna.UI.WinForms.GunaComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.btn_ok = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.btn_close = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RETRIEVE DELINQUENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Retrieve Delinquent Records"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(21, 95)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(330, 10)
        Me.GunaSeparator1.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(44, 114)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 20)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By Zone"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbo_financing)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(44, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 59)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Zone"
        '
        'cmbo_financing
        '
        Me.cmbo_financing.BackColor = System.Drawing.Color.Transparent
        Me.cmbo_financing.BaseColor = System.Drawing.Color.White
        Me.cmbo_financing.BorderColor = System.Drawing.Color.Silver
        Me.cmbo_financing.BorderSize = 3
        Me.cmbo_financing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_financing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_financing.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbo_financing.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbo_financing.ForeColor = System.Drawing.Color.Black
        Me.cmbo_financing.FormattingEnabled = True
        Me.cmbo_financing.Location = New System.Drawing.Point(22, 20)
        Me.cmbo_financing.Name = "cmbo_financing"
        Me.cmbo_financing.OnHoverItemBaseColor = System.Drawing.Color.Silver
        Me.cmbo_financing.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.cmbo_financing.Radius = 8
        Me.cmbo_financing.Size = New System.Drawing.Size(245, 27)
        Me.cmbo_financing.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GunaComboBox1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(44, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 59)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Area"
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.BorderSize = 3
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaComboBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Location = New System.Drawing.Point(22, 20)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.Radius = 8
        Me.GunaComboBox1.Size = New System.Drawing.Size(245, 27)
        Me.GunaComboBox1.TabIndex = 7
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(44, 212)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Area"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(44, 315)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 59)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Month Delinquent"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(22, 23)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(245, 22)
        Me.NumericUpDown1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "As of"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(91, 385)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 23)
        Me.DateTimePicker1.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(259, 376)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 20)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "EOM"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(44, 423)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(97, 20)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "All Branches"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(154, 423)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(170, 20)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Direct to Print (All Areas)"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.ActiveBorderThickness = 1
        Me.btn_ok.ActiveCornerRadius = 20
        Me.btn_ok.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.ActiveForecolor = System.Drawing.Color.White
        Me.btn_ok.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.BackColor = System.Drawing.Color.DarkGray
        Me.btn_ok.BackgroundImage = CType(resources.GetObject("btn_ok.BackgroundImage"), System.Drawing.Image)
        Me.btn_ok.ButtonText = "OK"
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.IdleBorderThickness = 3
        Me.btn_ok.IdleCornerRadius = 20
        Me.btn_ok.IdleFillColor = System.Drawing.Color.White
        Me.btn_ok.IdleForecolor = System.Drawing.Color.Black
        Me.btn_ok.IdleLineColor = System.Drawing.Color.Black
        Me.btn_ok.Location = New System.Drawing.Point(205, 472)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 50)
        Me.btn_ok.TabIndex = 17
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.ActiveBorderThickness = 1
        Me.btn_cancel.ActiveCornerRadius = 20
        Me.btn_cancel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.ButtonText = "CANCEL"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 3
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(83, 472)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(99, 50)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator2.Location = New System.Drawing.Point(24, 458)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(330, 10)
        Me.GunaSeparator2.TabIndex = 18
        '
        'btn_close
        '
        Me.btn_close.ActiveBorderThickness = 1
        Me.btn_close.ActiveCornerRadius = 20
        Me.btn_close.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_close.ActiveForecolor = System.Drawing.Color.White
        Me.btn_close.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_close.BackColor = System.Drawing.Color.DarkGray
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.ButtonText = "CLOSE"
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.IdleBorderThickness = 3
        Me.btn_close.IdleCornerRadius = 20
        Me.btn_close.IdleFillColor = System.Drawing.Color.White
        Me.btn_close.IdleForecolor = System.Drawing.Color.Black
        Me.btn_close.IdleLineColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(325, 1)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(50, 40)
        Me.btn_close.TabIndex = 19
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(377, 537)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GunaSeparator2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Del"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Del"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbo_financing As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents btn_ok As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuThinButton2
End Class
