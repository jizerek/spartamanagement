Imports MySql.Data.MySqlClient
Public Class Accounts

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lvAccounts.Columns.Add("#", 30)
        'lvAccounts.Columns.Add("ID Number", 100)
        'lvAccounts.Columns.Add("First Name", 100)
        'lvAccounts.Columns.Add("Middle Name", 100)
        'lvAccounts.Columns.Add("Last Name", 100)
        'lvAccounts.Columns.Add("Birthdate", 100)
        'lvAccounts.Columns.Add("Department", 160)
        'lvAccounts.Columns.Add("Position", 160)
        'lvAccounts.Columns.Add("Contact Number", 100)

        txtbox_id.Focus()

        'FillListView()
        FillDGV()
    End Sub

    Private Sub FillListView()
        openConnection()
        Try
            cmd.Connection = connection
            cmd.CommandText = "SELECT * FROM users"
            adapter.SelectCommand = cmd

            table = New DataTable

            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                'Add Item to ListView.
                Dim item As ListViewItem = New ListViewItem(row("ID").ToString())
                item.SubItems.Add(row("id_number").ToString())
                lvAccounts.Items.Add(item)
            Next

            lvAccounts.View = View.List

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FillDGV()
        openConnection()
        Try
            cmd.Connection = connection

            cmd.Parameters.Clear()

            cmd.CommandText = "SELECT ID, id_number, full_name, birthdate, department, position, contact_number FROM users WHERE status=@status"

            cmd.Parameters.AddWithValue("@status", "Active")

            adapter.SelectCommand = cmd

            table = New DataTable

            adapter.Fill(table)

            dgvAccounts.DataSource = table

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Search()
        openConnection()
        Try
            cmd.Connection = connection

            cmd.Parameters.Clear()

            cmd.CommandText = "SELECT * FROM users WHERE id_number=@id_number"

            cmd.Parameters.AddWithValue("@id_number", txtbox_id.Text)

            adapter.SelectCommand = cmd
            data.Clear()
            adapter.Fill(data, "List")

            txtbox_name.DataBindings.Add("Text", data, "List.full_name")
            txtbox_name.DataBindings.Clear()

            cmbo_gender.DataBindings.Add("Text", data, "List.gender")
            cmbo_gender.DataBindings.Clear()

            txtbox_contact.DataBindings.Add("Text", data, "List.contact_number")
            txtbox_contact.DataBindings.Clear()

            dtpBirthdate.DataBindings.Add("Value", data, "List.birthdate")
            dtpBirthdate.DataBindings.Clear()

            Dim yearMinus As DateTime
            yearMinus = DateTime.Now.AddYears(-1)

            If txtbox_name.Text = "" Then
                txtbox_age.Clear()
            ElseIf dtpBirthdate.Value > yearMinus Then
                txtbox_age.Text = 0
            Else
                Dim ts As TimeSpan = (DateTime.Now.Date - dtpBirthdate.Value)
                txtbox_age.Text = String.Format("{0:n0}", (ts.Days / 365))
            End If

            txtbox_user.DataBindings.Add("Text", data, "List.user_name")
            txtbox_user.DataBindings.Clear()

            txtbox_pass.DataBindings.Add("Text", data, "List.pass_word")
            txtbox_pass.DataBindings.Clear()

            cmbo_position.DataBindings.Add("Text", data, "List.position")
            cmbo_position.DataBindings.Clear()

            pbImage.DataBindings.Add("ImageLocation", data, "List.image_path", True)
            pbImage.DataBindings.Clear()

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearFields()
        txtbox_id.Clear()
        txtbox_name.Clear()
        cmbo_gender.SelectedIndex = -1
        txtbox_contact.Clear()
        txtbox_age.Clear()
        txtbox_user.Clear()
        cmbo_position.SelectedIndex = -1
        txtbox_pass.Clear()
        pbImage.Image = Nothing
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txtbox_id.Text = "" Then
            ClearFields()

            dgvAccounts.ClearSelection()
            dgvAccounts.CurrentCell = Nothing
        Else
            Search()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ClearFields()

        dgvAccounts.ClearSelection()
        dgvAccounts.CurrentCell = Nothing
    End Sub

    Private Sub txtbox_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_search_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick
        Try
            If dgvAccounts.Rows.Count > 0 Then
                If dgvAccounts.SelectedRows.Count > 0 Then
                    ClearFields()
                    txtbox_id.Text = dgvAccounts.SelectedRows(0).Cells(1).Value
                    Search()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtbox_id_TextChanged(sender As Object, e As EventArgs) Handles txtbox_id.TextChanged
        If txtbox_id.Text = "" Then
            ClearFields()
        End If
    End Sub
End Class