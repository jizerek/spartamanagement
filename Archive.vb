Public Class Archive
    Private Sub Archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV()

        dtpFrom.Value = DateTime.Now
        dtpTo.Value = DateTime.Now
    End Sub

    Private Sub FillDGV()
        openConnection()
        Try
            cmd.Connection = connection

            cmd.Parameters.Clear()

            cmd.CommandText = "SELECT ID, id_number, date_deactivated, full_name, birthdate, department, position, contact_number FROM users WHERE status=@status"

            cmd.Parameters.AddWithValue("@status", "Inactive")

            adapter.SelectCommand = cmd

            table = New DataTable

            adapter.Fill(table)

            dgvArchives.DataSource = table

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            Dim bs As New BindingSource
            bs.DataSource = dgvArchives.DataSource
            bs.Filter = String.Format("date_deactivated >= #{0:yyyy/MM/dd}# And date_deactivated <= #{1:yyyy/MM/dd}#", dtpFrom.Value, dtpTo.Value)
            dgvArchives.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Please check the date.")
        End Try
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim bs As New BindingSource
        bs.DataSource = dgvArchives.DataSource
        bs.RemoveFilter()
        FillDGV()
    End Sub
End Class