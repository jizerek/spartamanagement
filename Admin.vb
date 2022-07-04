Public Class Admin

    Dim button2Yes As Boolean = False

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            button2Yes = True
            Form1.Show()
            Me.Close()
        Else
            button2Yes = False
        End If
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        currentForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_acc_Click(sender As Object, e As EventArgs) Handles btn_acc.Click
        openChildForm(New Accounts())
    End Sub

    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        openChildForm(New AdminDashboard())
    End Sub

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        openChildForm(New Registration())
    End Sub

    Private Sub btn_act_Click(sender As Object, e As EventArgs) Handles btn_act.Click
        openChildForm(New ActivityLog())
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        openChildForm(New Update_DeleteAcc())
    End Sub

    Private Sub btn_archives_Click(sender As Object, e As EventArgs) Handles btn_archives.Click
        openChildForm(New Archive())
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        openChildForm(New About())
    End Sub

    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not button2Yes Then
            If Not MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                e.Cancel = True
            Else
                Form1.Show()
            End If
        End If
    End Sub
End Class