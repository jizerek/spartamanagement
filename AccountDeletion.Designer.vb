<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDeletion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountDeletion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_pn = New System.Windows.Forms.TextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.lbl_LoanNumber = New System.Windows.Forms.Label()
        Me.btn_del = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(74, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Confirmation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loan Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(68, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password:"
        '
        'txtbox_pn
        '
        Me.txtbox_pn.BackColor = System.Drawing.Color.White
        Me.txtbox_pn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pn.ForeColor = System.Drawing.Color.Black
        Me.txtbox_pn.Location = New System.Drawing.Point(166, 165)
        Me.txtbox_pn.Name = "txtbox_pn"
        Me.txtbox_pn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pn.Size = New System.Drawing.Size(215, 27)
        Me.txtbox_pn.TabIndex = 8
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(26, 79)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(400, 10)
        Me.GunaSeparator1.TabIndex = 21
        '
        'lbl_LoanNumber
        '
        Me.lbl_LoanNumber.AutoSize = True
        Me.lbl_LoanNumber.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoanNumber.ForeColor = System.Drawing.Color.Blue
        Me.lbl_LoanNumber.Location = New System.Drawing.Point(162, 119)
        Me.lbl_LoanNumber.Name = "lbl_LoanNumber"
        Me.lbl_LoanNumber.Size = New System.Drawing.Size(16, 19)
        Me.lbl_LoanNumber.TabIndex = 22
        Me.lbl_LoanNumber.Text = "-"
        '
        'btn_del
        '
        Me.btn_del.ActiveBorderThickness = 1
        Me.btn_del.ActiveCornerRadius = 20
        Me.btn_del.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_del.ActiveForecolor = System.Drawing.Color.White
        Me.btn_del.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_del.BackColor = System.Drawing.Color.White
        Me.btn_del.BackgroundImage = CType(resources.GetObject("btn_del.BackgroundImage"), System.Drawing.Image)
        Me.btn_del.ButtonText = "DELETE"
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Black
        Me.btn_del.IdleBorderThickness = 3
        Me.btn_del.IdleCornerRadius = 20
        Me.btn_del.IdleFillColor = System.Drawing.Color.White
        Me.btn_del.IdleForecolor = System.Drawing.Color.Black
        Me.btn_del.IdleLineColor = System.Drawing.Color.Black
        Me.btn_del.Location = New System.Drawing.Point(241, 217)
        Me.btn_del.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(150, 55)
        Me.btn_del.TabIndex = 134
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_cancel.Location = New System.Drawing.Point(64, 217)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(150, 55)
        Me.btn_cancel.TabIndex = 133
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccountDeletion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 311)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_LoanNumber)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_pn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountDeletion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT DELETION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_pn As TextBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents lbl_LoanNumber As Label
    Friend WithEvents btn_del As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
End Class
