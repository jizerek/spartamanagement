Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtbox_pass.Text = ""
        txtbox_user.Text = ""
    End Sub

    Private Sub txtbox_pass_OnValueChanged(sender As Object, e As EventArgs) Handles txtbox_pass.OnValueChanged
        txtbox_pass.isPassword = True
    End Sub

    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        pikit.Show()
        txtbox_pass.isPassword = True
        open.Hide()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles pikit.Click
        open.Show()
        txtbox_pass.isPassword = False
        pikit.Hide()
    End Sub
    'Sub user()
    '    Try


    '        cmd.CommandText = "Select * FROM users where user_name = '" & txtbox_user.Text & "'"
    '        reader = cmd.ExecuteReader
    '        If (reader.Read = True) Then
    '            username.Text = reader(1)
    '        ElseIf (reader.Read = False) Then
    '            username.Text = ""
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub ClearFields()
        txtbox_user.Text = ""
        txtbox_pass.Text = ""
        cmbo_financing.SelectedIndex = -1

        txtbox_user.Select()
    End Sub

    Private Sub login()
        openConnection()
        cmd = connection.CreateCommand

        cmd.CommandText = "SELECT * FROM users WHERE user_name=@user_name AND pass_word=@pass_word"

        cmd.Parameters.AddWithValue("@user_name", txtbox_user.Text)
        cmd.Parameters.AddWithValue("@pass_word", txtbox_pass.Text)

        reader = cmd.ExecuteReader
        If (reader.Read = True) Then

            reader.Close()

            ' START -> kukunin yung Position para icheck kung Administrator o Hindi
            Dim user As String = ""
            Dim check_status As String = ""
            Dim id_number As String = ""

            cmd.Connection = connection
            cmd.CommandText = "SELECT position, status, id_number, pass_word FROM users WHERE user_name=@user_name"

            reader = cmd.ExecuteReader()

            While reader.Read()

                user = reader.GetString(0)
                check_status = reader.GetString(1)
                id_number = reader.GetString(2)
                LN_Password = reader.GetString(3)

            End While

            If check_status = "Inactive" Then
                reader.Close()

                cmd.CommandText = "UPDATE users SET status=@status, date_deactivated=@date_deactivated WHERE id_number=@id_number"

                cmd.Parameters.AddWithValue("@id_number", id_number)
                cmd.Parameters.AddWithValue("@status", "Active")
                cmd.Parameters.AddWithValue("@date_deactivated", "")

                cmd.ExecuteNonQuery()

                connection.Close()
            End If

            If user = "Administrator" Then
                Admin.Show()
                Me.Hide()
                ClearFields()
            Else
                If cmbo_financing.SelectedIndex = -1 Then
                    MsgBox("Please select financing.")
                Else

                    check_branch = cmbo_financing.SelectedItem
                    checkBranch()
                    Dashboard.Show()
                    Me.Hide()
                    ClearFields()
                End If
            End If

            ' END -> checking

        ElseIf (reader.Read = False) Then
            MsgBox("Wrong credentials")
        End If

        reader.Close()
        connection.Close()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txtbox_user.Text.Trim = "" Or txtbox_pass.Text.Trim = "" Then
                'Add code here like errors (Optional)'
            Else
                login()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub txtbox_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub cmbo_financing_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbo_financing.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class
