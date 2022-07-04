Imports MySql.Data.MySqlClient
Public Class FamilyBackground
    Private Sub FamilyBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox_flname.Text = father_lastname
        txtbox_ffname.Text = father_firstname
        txtbox_fmiddle.Text = father_middlename
        txtbox_ftel.Text = father_telephone
        txtbox_fphone.Text = father_phone
        txtbox_fsuffix.Text = father_suffix
        txtbox_fadd.Text = father_residential
        txtbox_fadd1.Text = father_provincial
        txtbox_lname.Text = mother_lastname
        txtbox_fname.Text = mother_firstname
        txtbox_middle.Text = mother_middlename
        txtbox_tel.Text = mother_telephone
        txtbox_phone.Text = mother_phone
        txtbox_suffix.Text = mother_suffix
        txtbox_add.Text = mother_residential
        txtbox_add1.Text = mother_provincial


    End Sub

    Private Sub txtbox_flname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_flname.TextChanged
        father_lastname = txtbox_flname.Text
    End Sub

    Private Sub txtbox_ffname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_ffname.TextChanged
        father_firstname = txtbox_ffname.Text
    End Sub

    Private Sub txtbox_fmiddle_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fmiddle.TextChanged
        father_middlename = txtbox_fmiddle.Text
    End Sub

    Private Sub txtbox_ftel_TextChanged(sender As Object, e As EventArgs) Handles txtbox_ftel.TextChanged
        father_telephone = txtbox_ftel.Text
    End Sub

    Private Sub txtbox_fphone_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fphone.TextChanged
        father_phone = txtbox_fphone.Text
    End Sub

    Private Sub txtbox_fsuffix_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fsuffix.TextChanged
        father_suffix = txtbox_fsuffix.Text
    End Sub

    Private Sub txtbox_fadd_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fadd.TextChanged
        father_residential = txtbox_fadd.Text
    End Sub

    Private Sub txtbox_fadd1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fadd1.TextChanged
        father_provincial = txtbox_fadd1.Text
    End Sub

    Private Sub txtbox_lname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_lname.TextChanged
        mother_lastname = txtbox_lname.Text
    End Sub

    Private Sub txtbox_tel_TextChanged(sender As Object, e As EventArgs) Handles txtbox_tel.TextChanged
        mother_telephone = txtbox_tel.Text
    End Sub

    Private Sub txtbox_fname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fname.TextChanged
        mother_firstname = txtbox_fname.Text
    End Sub

    Private Sub txtbox_phone_TextChanged(sender As Object, e As EventArgs) Handles txtbox_phone.TextChanged
        mother_phone = txtbox_phone.Text
    End Sub

    Private Sub txtbox_middle_TextChanged(sender As Object, e As EventArgs) Handles txtbox_middle.TextChanged
        mother_middlename = txtbox_middle.Text
    End Sub

    Private Sub txtbox_suffix_TextChanged(sender As Object, e As EventArgs) Handles txtbox_suffix.TextChanged
        mother_suffix = txtbox_suffix.Text
    End Sub

    Private Sub txtbox_add_TextChanged(sender As Object, e As EventArgs) Handles txtbox_add.TextChanged
        mother_residential = txtbox_add.Text
    End Sub

    Private Sub txtbox_add1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_add1.TextChanged
        mother_provincial = txtbox_add1.Text
    End Sub

    ' PREVENT MULTILINE
    Private Sub txtbox_flname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_flname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_ftel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_ftel.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_ffname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_ffname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fphone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fphone.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fmiddle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fmiddle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fsuffix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fsuffix.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fadd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fadd.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fadd1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fadd1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_lname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_lname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_tel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_tel.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_fname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_phone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_phone.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_middle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_middle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_suffix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_suffix.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_add_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_add.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_add1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_add1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class