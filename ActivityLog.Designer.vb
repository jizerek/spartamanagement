<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityLog))
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.btn_login = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(37, 100)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1000, 10)
        Me.GunaSeparator1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 33)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Activity Log"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(93, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(433, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "To:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePicker1.BorderSize = 3
        Me.DateTimePicker1.CustomFormat = Nothing
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(170, 144)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Radius = 8
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 30)
        Me.DateTimePicker1.TabIndex = 74
        Me.DateTimePicker1.Text = "7/26/2021"
        Me.DateTimePicker1.Value = New Date(2021, 7, 26, 0, 37, 22, 732)
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.BorderSize = 3
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(488, 144)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Radius = 8
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(215, 30)
        Me.GunaDateTimePicker1.TabIndex = 75
        Me.GunaDateTimePicker1.Text = "7/26/2021"
        Me.GunaDateTimePicker1.Value = New Date(2021, 7, 26, 0, 37, 22, 732)
        '
        'btn_login
        '
        Me.btn_login.ActiveBorderThickness = 1
        Me.btn_login.ActiveCornerRadius = 20
        Me.btn_login.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.ActiveForecolor = System.Drawing.Color.White
        Me.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.White
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.ButtonText = "SEARCH"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.IdleBorderThickness = 3
        Me.btn_login.IdleCornerRadius = 20
        Me.btn_login.IdleFillColor = System.Drawing.Color.White
        Me.btn_login.IdleForecolor = System.Drawing.Color.Black
        Me.btn_login.IdleLineColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(866, 130)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(110, 53)
        Me.btn_login.TabIndex = 77
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_cancel.Location = New System.Drawing.Point(739, 130)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 53)
        Me.btn_cancel.TabIndex = 76
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(97, 219)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(879, 459)
        Me.ListView1.TabIndex = 78
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 748)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GunaDateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActivityLog"
        Me.Text = "ActivityLog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ListView1 As ListView
End Class
