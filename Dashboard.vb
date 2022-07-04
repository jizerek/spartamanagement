Imports MySql.Data.MySqlClient
Public Class Dashboard

    Dim button2Yes As Boolean = False

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        lbl_branch.Text = check_branch 'from Sparta_Module
    End Sub

    Private Sub ResetColor()
        ' RESETS button.BaseColor = Color.FromArgb(249, 175, 64) to button.BaseColor = Color.FromArgb(209, 210, 212)

        ' LOAN TAB
        btn_borrow.BaseColor = Color.FromArgb(209, 210, 212)
        btn_UBI.BaseColor = Color.FromArgb(209, 210, 212)
        btn_LA.BaseColor = Color.FromArgb(209, 210, 212)

        ' FINANCING TAB
        btn_new.BaseColor = Color.FromArgb(209, 210, 212)
        btn_newfinancing.BaseColor = Color.FromArgb(209, 210, 212)

        ' COLLECTIONS TAB


        ' SHARED REPORTS TAB
        btn_soa.BaseColor = Color.FromArgb(209, 210, 212)
        btn_sched.BaseColor = Color.FromArgb(209, 210, 212)

    End Sub

    Private Sub Activities()
        openConnection()
        Try

            'Parametized query to prevent sql injection.

            cmd.Connection = connection

            cmd.CommandText = "INSERT INTO users (user, click, button) VALUES(?id_number, ?user_name)"
            cmd.Parameters.AddWithValue("?user", Pangalan.Text)
            cmd.Parameters.AddWithValue("?click", "Clicked")



            cmd.ExecuteNonQuery()

            MsgBox("ACT LOG")
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub hideSubmenu()
        PanelLoanSubMenu.Visible = False
        PanelFinancingSubMenu.Visible = False

        PanelSharedSubMenu.Visible = False
        PanelCusSubMenu.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btn_loan_Click(sender As Object, e As EventArgs) Handles btn_loan.Click
        showSubmenu(PanelLoanSubMenu)
    End Sub

    Private Sub btn_financing_Click(sender As Object, e As EventArgs) Handles btn_financing.Click
        showSubmenu(PanelFinancingSubMenu)
    End Sub


    Private Sub btn_shared_Click(sender As Object, e As EventArgs) Handles btn_shared.Click
        showSubmenu(PanelSharedSubMenu)
    End Sub

    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        currentForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_borrow_Click(sender As Object, e As EventArgs) Handles btn_borrow.Click
        openChildForm(New Borrower())
        ResetColor()
        btn_borrow.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        openChildForm(New About())
    End Sub


    Private Sub btn_soa_Click(sender As Object, e As EventArgs) Handles btn_soa.Click
        openChildForm(New StatementOfAccount())
        'SOA.ShowDialog()
        ResetColor()
        btn_soa.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub

    Private Sub btn_sched_Click(sender As Object, e As EventArgs) Handles btn_sched.Click
        openChildForm(New ScheduleOfAmortization())
        ResetColor()
        btn_sched.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub

    Private Sub btn_UBI_Click(sender As Object, e As EventArgs) Handles btn_UBI.Click
        openChildForm(New UpdateBorrower())
        ResetColor()
        btn_UBI.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub

    Private Sub btn_newfinancing_Click(sender As Object, e As EventArgs) Handles btn_newfinancing.Click
        openChildForm(New NewFinancing())
        ResetColor()
        btn_newfinancing.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        openChildForm(New RFRM())
        ResetColor()
        btn_new.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub



    'Private Sub btn_new_Click(sender As Object, e As EventArgs)
    '    openChildForm(New RFRM())
    'End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            button2Yes = True
            LN_Password = ""
            Form1.Show()
            Me.Close()
        Else
            button2Yes = False
        End If
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not button2Yes Then
            If Not MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                e.Cancel = True
            Else
                LN_Password = ""
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub btn_LA_Click(sender As Object, e As EventArgs) Handles btn_LA.Click
        openChildForm(New LoanAccounts())
        ResetColor()
        btn_LA.BaseColor = Color.FromArgb(249, 175, 64)
    End Sub
End Class