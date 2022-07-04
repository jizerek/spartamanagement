<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbox_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cmbo_financing = New Guna.UI.WinForms.GunaComboBox()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_login = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_close = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.open = New System.Windows.Forms.PictureBox()
        Me.pikit = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pikit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FINANCING:"
        '
        'txtbox_user
        '
        Me.txtbox_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbox_user.ForeColor = System.Drawing.Color.Black
        Me.txtbox_user.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_user.HintText = ""
        Me.txtbox_user.isPassword = False
        Me.txtbox_user.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_user.LineIdleColor = System.Drawing.Color.Black
        Me.txtbox_user.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txtbox_user.LineThickness = 4
        Me.txtbox_user.Location = New System.Drawing.Point(383, 54)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(215, 33)
        Me.txtbox_user.TabIndex = 4
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbox_pass.ForeColor = System.Drawing.Color.Black
        Me.txtbox_pass.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_pass.HintText = ""
        Me.txtbox_pass.isPassword = False
        Me.txtbox_pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_pass.LineIdleColor = System.Drawing.Color.Black
        Me.txtbox_pass.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txtbox_pass.LineThickness = 4
        Me.txtbox_pass.Location = New System.Drawing.Point(383, 95)
        Me.txtbox_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(215, 33)
        Me.txtbox_pass.TabIndex = 5
        Me.txtbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.cmbo_financing.Items.AddRange(New Object() {"RODOLFO SANCHEZ", "CREDIT CARE", "GOLDEN SILVER", "HITRUST FINANCING CORP.", "GOLDSTAR", "RIGHT CHOICE FINANCE", "ASIAGROUP FINANCE"})
        Me.cmbo_financing.Location = New System.Drawing.Point(382, 153)
        Me.cmbo_financing.Name = "cmbo_financing"
        Me.cmbo_financing.OnHoverItemBaseColor = System.Drawing.Color.Silver
        Me.cmbo_financing.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.cmbo_financing.Radius = 8
        Me.cmbo_financing.Size = New System.Drawing.Size(215, 27)
        Me.cmbo_financing.TabIndex = 6
        '
        'btn_cancel
        '
        Me.btn_cancel.ActiveBorderThickness = 1
        Me.btn_cancel.ActiveCornerRadius = 20
        Me.btn_cancel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.ButtonText = "CLEAR"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 3
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(361, 200)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 53)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.ActiveBorderThickness = 1
        Me.btn_login.ActiveCornerRadius = 20
        Me.btn_login.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.ActiveForecolor = System.Drawing.Color.White
        Me.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.ButtonText = "LOG-IN"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.IdleBorderThickness = 3
        Me.btn_login.IdleCornerRadius = 20
        Me.btn_login.IdleFillColor = System.Drawing.Color.White
        Me.btn_login.IdleForecolor = System.Drawing.Color.Black
        Me.btn_login.IdleLineColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(488, 200)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(110, 53)
        Me.btn_login.TabIndex = 8
        Me.btn_login.TabStop = False
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_close
        '
        Me.btn_close.ActiveBorderThickness = 1
        Me.btn_close.ActiveCornerRadius = 20
        Me.btn_close.ActiveFillColor = System.Drawing.Color.Red
        Me.btn_close.ActiveForecolor = System.Drawing.Color.White
        Me.btn_close.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.ButtonText = "X"
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.IdleBorderThickness = 3
        Me.btn_close.IdleCornerRadius = 20
        Me.btn_close.IdleFillColor = System.Drawing.Color.White
        Me.btn_close.IdleForecolor = System.Drawing.Color.Black
        Me.btn_close.IdleLineColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(578, 1)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(49, 38)
        Me.btn_close.TabIndex = 9
        Me.btn_close.TabStop = False
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'open
        '
        Me.open.Image = CType(resources.GetObject("open.Image"), System.Drawing.Image)
        Me.open.Location = New System.Drawing.Point(567, 101)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(29, 21)
        Me.open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.open.TabIndex = 17
        Me.open.TabStop = False
        Me.open.Visible = False
        '
        'pikit
        '
        Me.pikit.Image = CType(resources.GetObject("pikit.Image"), System.Drawing.Image)
        Me.pikit.Location = New System.Drawing.Point(567, 101)
        Me.pikit.Name = "pikit"
        Me.pikit.Size = New System.Drawing.Size(29, 21)
        Me.pikit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pikit.TabIndex = 18
        Me.pikit.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(269, 172)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 286)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.pikit)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.cmbo_financing)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.open, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pikit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cmbo_financing As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtbox_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbox_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents open As PictureBox
    Friend WithEvents pikit As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
