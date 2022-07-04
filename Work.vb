Imports MySql.Data.MySqlClient
Public Class Work
    Private Sub txtbox_employer_TextChanged(sender As Object, e As EventArgs) Handles txtbox_employer.TextChanged
        work_employer = txtbox_employer.Text
    End Sub

    Private Sub txtbox_address_TextChanged(sender As Object, e As EventArgs) Handles txtbox_address.TextChanged
        work_bsnsadd = txtbox_address.Text
    End Sub

    Private Sub txtbox_brgy_TextChanged(sender As Object, e As EventArgs) Handles txtbox_brgy.TextChanged
        work_district = txtbox_brgy.Text
    End Sub

    Private Sub cmbo_municipality_SelectedIndexChanged(sender As Object, e As EventArgs)
        work_municipality = municipality.Text
    End Sub

    Private Sub cmbo_province_SelectedIndexChanged(sender As Object, e As EventArgs)
        work_province = province.Text
    End Sub

    Private Sub txtbox_tel_TextChanged(sender As Object, e As EventArgs) Handles txtbox_tel.TextChanged
        work_telephone = txtbox_tel.Text
    End Sub

    Private Sub txtbox_phone_TextChanged(sender As Object, e As EventArgs) Handles txtbox_phone.TextChanged
        work_phone = txtbox_phone.Text
    End Sub

    Private Sub municipality_TextChanged(sender As Object, e As EventArgs) Handles municipality.TextChanged
        work_municipality = municipality.Text
    End Sub

    Private Sub province_TextChanged(sender As Object, e As EventArgs) Handles province.TextChanged
        work_province = province.Text
    End Sub
    Private Sub cmbo_pos_SelectedIndexChanged(sender As Object, e As EventArgs)
        work_position = position.Text
    End Sub
    Private Sub position_TextChanged(sender As Object, e As EventArgs) Handles position.TextChanged
        work_position = position.Text
    End Sub
    Private Sub txtbox_income_TextChanged(sender As Object, e As EventArgs) Handles txtbox_income.TextChanged
        work_income = txtbox_income.Text
    End Sub

    Private Sub txtbox_prc_TextChanged(sender As Object, e As EventArgs) Handles txtbox_prc.TextChanged
        id_prc = txtbox_prc.Text
    End Sub

    Private Sub txtbox_sss_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sss.TextChanged
        id_sss = txtbox_sss.Text
    End Sub

    Private Sub txtbox_driver_TextChanged(sender As Object, e As EventArgs) Handles txtbox_driver.TextChanged
        id_driver = txtbox_driver.Text
    End Sub

    Private Sub txtbox_tin_TextChanged(sender As Object, e As EventArgs) Handles txtbox_tin.TextChanged
        id_tin = txtbox_tin.Text
    End Sub

    Private Sub Work_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox_employer.Text = work_employer
        txtbox_address.Text = work_bsnsadd
        txtbox_brgy.Text = work_district
        municipality.Text = work_municipality
        province.Text = work_province
        txtbox_tel.Text = work_telephone
        txtbox_phone.Text = work_phone
        position.Text = work_position
        txtbox_income.Text = work_income
        txtbox_prc.Text = id_prc
        txtbox_sss.Text = id_sss
        txtbox_driver.Text = id_driver
        txtbox_tin.Text = id_tin
    End Sub

    ' PREVENT MULTILINE
    Private Sub txtbox_employer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_employer.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_address_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_address.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_brgy_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_brgy.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub municipality_KeyDown(sender As Object, e As KeyEventArgs) Handles municipality.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub province_KeyDown(sender As Object, e As KeyEventArgs) Handles province.KeyDown
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

    Private Sub txtbox_phone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_phone.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub position_KeyDown(sender As Object, e As KeyEventArgs) Handles position.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_income_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_income.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_prc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_prc.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_sss_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sss.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_driver_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_driver.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_tin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_tin.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class