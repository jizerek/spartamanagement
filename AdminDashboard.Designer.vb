<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_Admin = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Accounts = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_Users = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'lbl_Admin
        '
        Me.lbl_Admin.AutoSize = True
        Me.lbl_Admin.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_Admin.Location = New System.Drawing.Point(28, 69)
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(35, 38)
        Me.lbl_Admin.TabIndex = 6
        Me.lbl_Admin.Text = "0"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.PictureBox2)
        Me.GunaElipsePanel2.Controls.Add(Me.lbl_Admin)
        Me.GunaElipsePanel2.Controls.Add(Me.Label9)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(71, 170)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(278, 149)
        Me.GunaElipsePanel2.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(28, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Admin"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.GunaSeparator1.Location = New System.Drawing.Point(54, 108)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1000, 10)
        Me.GunaSeparator1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(76, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dashboard"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.PictureBox1)
        Me.GunaElipsePanel1.Controls.Add(Me.lbl_Accounts)
        Me.GunaElipsePanel1.Controls.Add(Me.Label3)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(414, 170)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(278, 149)
        Me.GunaElipsePanel1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(152, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbl_Accounts
        '
        Me.lbl_Accounts.AutoSize = True
        Me.lbl_Accounts.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Accounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_Accounts.Location = New System.Drawing.Point(28, 69)
        Me.lbl_Accounts.Name = "lbl_Accounts"
        Me.lbl_Accounts.Size = New System.Drawing.Size(35, 38)
        Me.lbl_Accounts.TabIndex = 6
        Me.lbl_Accounts.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Accounts"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.PictureBox3)
        Me.GunaElipsePanel3.Controls.Add(Me.lbl_Users)
        Me.GunaElipsePanel3.Controls.Add(Me.Label5)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(753, 170)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 10
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(278, 149)
        Me.GunaElipsePanel3.TabIndex = 17
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(152, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'lbl_Users
        '
        Me.lbl_Users.AutoSize = True
        Me.lbl_Users.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Users.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_Users.Location = New System.Drawing.Point(28, 69)
        Me.lbl_Users.Name = "lbl_Users"
        Me.lbl_Users.Size = New System.Drawing.Size(35, 38)
        Me.lbl_Users.TabIndex = 6
        Me.lbl_Users.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Users"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 748)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_Admin As Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label9 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Accounts As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_Users As Label
    Friend WithEvents Label5 As Label
End Class
