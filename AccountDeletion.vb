Imports MySql.Data.MySqlClient
Public Class AccountDeletion

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        LN_Deletion = ""
        Me.Close()
    End Sub

    Private Sub PasswordConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_LoanNumber.Text = LN_Deletion.ToString()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If Convert.ToString(txtbox_pn.Text) = LN_Password.ToString() Then
            del()
            Me.Close()
            Dashboard.openChildForm(New LoanAccounts())
        Else
            MsgBox("Wrong password!")
        End If
    End Sub

    Private Sub del()
        Dim msgresult As DialogResult
        If current_branch = "rodolfo_sanchez" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from rodolfo_sanchez where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "credit_care" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from credit_care where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "golden_silver" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from golden_silver where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "hitrust_financing_corp" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from hitrust_financing_corp where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "goldstar" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from goldstar where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "right_choice_finance" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from right_choice_finance where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        ElseIf current_branch = "asiagroup_finance" Then
            msgresult = MessageBox.Show("Are you sure you want to delete " & lbl_LoanNumber.Text & "?", "DELETE ACCOUNT", MessageBoxButtons.YesNo)
            If msgresult = DialogResult.Yes Then
                connection.Open()
                cmd = connection.CreateCommand
                cmd.CommandText = "delete from asiagroup_finance where loan_no=@loan_no;"
                cmd.Parameters.AddWithValue("loan_no", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()

                cmd.CommandText = "delete from financing_payment where loan_number=@loan_number;"
                cmd.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                cmd.ExecuteNonQuery()
                connection.Close()
                connection.Open()
                Dim d As MySqlCommand
                d = connection.CreateCommand
                d.CommandText = "delete from request_for_restructing_migration where loan_number=@loan_number;"
                d.Parameters.AddWithValue("loan_number", lbl_LoanNumber.Text)
                d.ExecuteNonQuery()
                connection.Close()
                MsgBox("DELETED")
                connection.Close()
            Else
                connection.Close()
            End If
        End If

    End Sub

    Private Sub AccountDeletion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LN_Deletion = ""
    End Sub
End Class