Public Class AdminDashboard

    Private Sub Count_Dashboard()
        openConnection()

        Dim admin As String = "Administrator"

        cmd.Connection = connection

        ' START of Counting of All Administrators

        cmd.CommandText = "SELECT COUNT(*) FROM users WHERE position=@position"

        cmd.Parameters.AddWithValue("@position", admin)

        Dim i As Integer = cmd.ExecuteScalar()

        lbl_Admin.Text = i

        ' START of Counting All Accounts

        cmd.CommandText = "SELECT COUNT(*) FROM users"

        Dim j As Integer = cmd.ExecuteScalar()

        lbl_Accounts.Text = j

        ' START of Counting All Users / Employees

        cmd.CommandText = "SELECT COUNT(*) FROM users WHERE position <> @position"

        Dim k As Integer = cmd.ExecuteScalar()

        lbl_Users.Text = k

        cmd.Parameters.Clear()

        connection.Close()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Count_Dashboard()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class