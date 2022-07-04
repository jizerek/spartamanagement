Imports MySql.Data.MySqlClient
Public Class Borrower

    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        currentForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelBody.Controls.Add(childForm)
        PanelBody.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_family_Click(sender As Object, e As EventArgs) Handles btn_family.Click
        openChildForm(New FamilyBackground())

    End Sub

    Private Sub btn_work_Click(sender As Object, e As EventArgs) Handles btn_work.Click
        openChildForm(New Work())
    End Sub

    Private Sub btn_advance_Click(sender As Object, e As EventArgs) Handles btn_advance.Click
        'openChildForm(New Borrower())
    End Sub

    Private Sub btn_advance_CheckedChanged(sender As Object, e As EventArgs) Handles btn_advance.CheckedChanged
        If btn_advance.Checked Then
            PanelAdvance.BringToFront()
        End If
    End Sub

    Private Sub rodolfo_sanchez()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM rodolfo_sanchez WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO rodolfo_sanchez (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)

            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub credit_care()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM credit_care WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO credit_care (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub golden_silver()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM golden_silver WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO golden_silver (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub hitrust_financing_corp()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM hitrust_financing_corp WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO hitrust_financing_corp (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub goldstar()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM goldstar WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO goldstar (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub right_choice_finance()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM right_choice_finance WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO right_choice_finance (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub asiagroup_finance()
        openConnection()
        Try
            cmd.Connection = connection

            'Check if Loan Number already exist. Loan Number should be unique.
            cmd.CommandText = "SELECT * FROM asiagroup_finance WHERE loan_no=@loan_no"

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@loan_no", txtbox_reference.Text)

            reader = cmd.ExecuteReader

            If (reader.Read = True) Then

                reader.Close()
                'connection.Close()

                Generate_Reference()
            ElseIf (reader.Read = False) Then
                'connection.Close()
                reader.Close()

                ' DO NOTHING
            End If

            cmd.CommandText = "INSERT INTO asiagroup_finance (loan_no, title, lastname, firstname, middlename, suffix, birthdate, gender, civil_status, maiden_name, advance_tel, advance_phone, advance_residence, advance_nationality, advance_email, advance_education, advance_course, spouse_lastname, spouse_firstname, spouse_middlename, spouse_suffix, spouse_telephone, spouse_phone, spouse_residential, spouse_permanent, father_lastname, father_firstname, father_middle, father_suffix, father_residential, father_provincial, father_telephone, father_phone, mother_lastname, mother_firstname, mother_middlename, mother_suffix, mother_residential, mother_provincial, mother_telephone, mother_phone, work_bsnsname, work_bsnsaddress, work_district, work_municipality, work_province, work_telephone, work_phone, work_position, work_income, id_prc, id_driver, id_sss, id_tin) VALUES (?loan_no, ?title, ?lastname, ?firstname, ?middlename, ?suffix, ?birthdate, ?gender, ?civil_status, ?maiden_name, ?advance_tel, ?advance_phone, ?advance_residence, ?advance_nationality, ?advance_email, ?advance_education, ?advance_course, ?spouse_lastname, ?spouse_firstname, ?spouse_middlename, ?spouse_suffix, ?spouse_telephone, ?spouse_phone, ?spouse_residential, ?spouse_permanent, ?father_lastname, ?father_firstname, ?father_middle, ?father_suffix, ?father_residential, ?father_provincial, ?father_telephone, ?father_phone, ?mother_lastname, ?mother_firstname, ?mother_middlename, ?mother_suffix, ?mother_residential, ?mother_provincial, ?mother_telephone, ?mother_phone, ?work_bsnsname, ?work_bsnsaddress, ?work_district, ?work_municipality, ?work_province, ?work_telephone, ?work_phone, ?work_position, ?work_income, ?id_prc, ?id_driver, ?id_sss, ?id_tin) "

            cmd.Parameters.Clear()

            ' PERSONAL INFORMATION
            cmd.Parameters.AddWithValue("?loan_no", txtbox_reference.Text)
            cmd.Parameters.AddWithValue("?title", personal_title)
            cmd.Parameters.AddWithValue("?lastname", personal_lastname)
            cmd.Parameters.AddWithValue("?firstname", personal_firstname)
            cmd.Parameters.AddWithValue("?middlename", personal_middlename)
            cmd.Parameters.AddWithValue("?suffix", personal_suffix)
            cmd.Parameters.AddWithValue("?birthdate", personal_birthdate)
            cmd.Parameters.AddWithValue("?gender", personal_gender)
            cmd.Parameters.AddWithValue("?civil_status", personal_civil)
            cmd.Parameters.AddWithValue("?maiden_name", personal_maiden)

            ' ADVANCE INFORMATION TAB
            cmd.Parameters.AddWithValue("?advance_tel", borrower_telephone)
            cmd.Parameters.AddWithValue("?advance_phone", borrower_phone)
            cmd.Parameters.AddWithValue("?advance_residence", borrower_residence)
            cmd.Parameters.AddWithValue("?advance_nationality", borrower_nationality)
            cmd.Parameters.AddWithValue("?advance_email", borrower_email)
            cmd.Parameters.AddWithValue("?advance_education", borrower_education)
            cmd.Parameters.AddWithValue("?advance_course", borrower_course)

            cmd.Parameters.AddWithValue("?spouse_lastname", spouse_lastname)
            cmd.Parameters.AddWithValue("?spouse_firstname", spouse_firstname)
            cmd.Parameters.AddWithValue("?spouse_middlename", spouse_middlename)
            cmd.Parameters.AddWithValue("?spouse_suffix", spouse_suffix)
            cmd.Parameters.AddWithValue("?spouse_telephone", spouse_telephone)
            cmd.Parameters.AddWithValue("?spouse_phone", spouse_phone)
            cmd.Parameters.AddWithValue("?spouse_residential", spouse_residential)
            cmd.Parameters.AddWithValue("?spouse_permanent", spouse_permanent)

            ' FAMILY BACKGROUND TAB
            cmd.Parameters.AddWithValue("?father_lastname", father_lastname)
            cmd.Parameters.AddWithValue("?father_firstname", father_firstname)
            cmd.Parameters.AddWithValue("?father_middle", father_middlename)
            cmd.Parameters.AddWithValue("?father_suffix", father_suffix)
            cmd.Parameters.AddWithValue("?father_residential", father_residential)
            cmd.Parameters.AddWithValue("?father_provincial", father_provincial)
            cmd.Parameters.AddWithValue("?father_telephone", father_telephone)
            cmd.Parameters.AddWithValue("?father_phone", father_phone)

            cmd.Parameters.AddWithValue("?mother_lastname", mother_lastname)
            cmd.Parameters.AddWithValue("?mother_firstname", mother_firstname)
            cmd.Parameters.AddWithValue("?mother_middlename", mother_middlename)
            cmd.Parameters.AddWithValue("?mother_suffix", mother_suffix)
            cmd.Parameters.AddWithValue("?mother_residential", mother_residential)
            cmd.Parameters.AddWithValue("?mother_provincial", mother_provincial)
            cmd.Parameters.AddWithValue("?mother_telephone", mother_telephone)
            cmd.Parameters.AddWithValue("?mother_phone", mother_phone)

            ' WORK TAB
            cmd.Parameters.AddWithValue("?work_bsnsname", work_employer)
            cmd.Parameters.AddWithValue("?work_bsnsaddress", work_bsnsadd)
            cmd.Parameters.AddWithValue("?work_district", work_district)
            cmd.Parameters.AddWithValue("?work_municipality", work_municipality)
            cmd.Parameters.AddWithValue("?work_province", work_province)
            cmd.Parameters.AddWithValue("?work_telephone", work_telephone)
            cmd.Parameters.AddWithValue("?work_phone", work_telephone)
            cmd.Parameters.AddWithValue("?work_position", work_position)
            cmd.Parameters.AddWithValue("?work_income", work_income)

            cmd.Parameters.AddWithValue("?id_prc", id_prc)
            cmd.Parameters.AddWithValue("?id_driver", id_driver)
            cmd.Parameters.AddWithValue("?id_sss", id_sss)
            cmd.Parameters.AddWithValue("?id_tin", id_tin)

            cmd.ExecuteNonQuery()   ' EXECUTE INSERT QUERY!

            MsgBox("LOAN NO.:" & txtbox_reference.Text)
            connection.Close()

            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Generate_Reference()
        ' current_branch PUBLIC STRING is inside the checkBranch() it is used during logging in

        If current_branch = "rodolfo_sanchez" Then
            rodolfo_sanchez()            ' INSERT TO rodolfo_sanchez TABLE
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "credit_care" Then
            credit_care()                ' ...
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "golden_silver" Then
            golden_silver()              ' ...
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "hitrust_financing_corp" Then
            hitrust_financing_corp()     ' ...
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "goldstar" Then
            goldstar()                   ' ...
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "right_choice_finance" Then
            right_choice_finance()     ' ...
            Dashboard.openChildForm(New Borrower())
        ElseIf current_branch = "asiagroup_finance" Then
            asiagroup_finance()     ' ...
            Dashboard.openChildForm(New Borrower())
        Else
            MsgBox("No database found.")
        End If

        Generate_Reference()
    End Sub

    Private Sub cmbo_title_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_title.SelectedIndexChanged
        personal_title = cmbo_title.Text

    End Sub

    Private Sub txtbox_lname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_lname.TextChanged
        personal_lastname = txtbox_lname.Text
    End Sub

    Private Sub txtbox_fname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_fname.TextChanged
        personal_firstname = txtbox_fname.Text
    End Sub

    Private Sub txtbox_mid_TextChanged(sender As Object, e As EventArgs) Handles txtbox_mid.TextChanged
        personal_middlename = txtbox_mid.Text
    End Sub

    Private Sub txtbox_suffix_TextChanged(sender As Object, e As EventArgs) Handles txtbox_suffix.TextChanged
        personal_suffix = txtbox_suffix.Text
    End Sub
    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        personal_birthdate = birthday.Value.ToShortDateString
    End Sub

    Private Sub cmbo_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_gender.SelectedIndexChanged
        personal_gender = cmbo_gender.Text
    End Sub

    Private Sub cmbo_civil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_civil.SelectedIndexChanged
        personal_civil = cmbo_civil.Text
    End Sub

    Private Sub txtbox_maiden_TextChanged(sender As Object, e As EventArgs) Handles txtbox_maiden.TextChanged
        personal_maiden = txtbox_maiden.Text
    End Sub

    Private Sub txtbox_tel_TextChanged(sender As Object, e As EventArgs) Handles txtbox_tel.TextChanged
        borrower_telephone = txtbox_tel.Text
    End Sub

    Private Sub txtbox_phone_TextChanged(sender As Object, e As EventArgs) Handles txtbox_phone.TextChanged
        borrower_phone = txtbox_phone.Text
    End Sub

    Private Sub txtbox_add_TextChanged(sender As Object, e As EventArgs) Handles txtbox_add.TextChanged
        borrower_residence = txtbox_add.Text
    End Sub

    Private Sub cmbo_nat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_nat.SelectedIndexChanged
        borrower_nationality = cmbo_nat.Text
    End Sub

    Private Sub txtbox_email_TextChanged(sender As Object, e As EventArgs) Handles txtbox_email.TextChanged
        borrower_email = txtbox_email.Text
    End Sub

    Private Sub cmbo_educ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_educ.SelectedIndexChanged
        borrower_education = cmbo_educ.Text
    End Sub

    Private Sub txt_school_TextChanged(sender As Object, e As EventArgs) Handles txt_school.TextChanged
        borrower_course = txt_school.Text
    End Sub

    Private Sub txtbox_slname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_slname.TextChanged
        spouse_lastname = txtbox_slname.Text
    End Sub

    Private Sub txtbox_sfname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sfname.TextChanged
        spouse_firstname = txtbox_sfname.Text
    End Sub

    Private Sub txtbox_smi_TextChanged(sender As Object, e As EventArgs) Handles txtbox_smi.TextChanged
        spouse_middlename = txtbox_smi.Text
    End Sub

    Private Sub txtbox_ssuffix_TextChanged(sender As Object, e As EventArgs) Handles txtbox_ssuffix.TextChanged
        spouse_suffix = txtbox_ssuffix.Text
    End Sub

    Private Sub txtbox_stel_TextChanged(sender As Object, e As EventArgs) Handles txtbox_stel.TextChanged
        spouse_telephone = txtbox_stel.Text
    End Sub

    Private Sub txtbox_sphone_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sphone.TextChanged
        spouse_phone = txtbox_sphone.Text
    End Sub

    Private Sub txtbox_sadd_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sadd.TextChanged
        spouse_residential = txtbox_sadd.Text
    End Sub

    Private Sub txtbox_sper_TextChanged(sender As Object, e As EventArgs) Handles txtbox_sper.TextChanged
        spouse_permanent = txtbox_sper.Text
    End Sub

    Private Sub txtbox_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_lname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtbox_fname.Focus()
        End If
        If Asc(e.KeyChar) = 11 Then
            e.Handled = True
            txtbox_fname.Focus()
        End If
    End Sub

    Private Sub txtbox_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_fname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtbox_mid.Focus()
        End If
        If Asc(e.KeyChar) = 11 Then
            e.Handled = True
            txtbox_mid.Focus()
        End If
    End Sub

    Private Sub txtbox_mid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_mid.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtbox_suffix.Focus()
        End If
        If Asc(e.KeyChar) = 11 Then
            e.Handled = True
            txtbox_suffix.Focus()
        End If
    End Sub

    Private Sub txtbox_suffix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_suffix.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtbox_maiden.Focus()
        End If
        If Asc(e.KeyChar) = 11 Then
            e.Handled = True
            txtbox_maiden.Focus()
        End If
    End Sub

    Private Sub txtbox_maiden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_maiden.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtbox_tel.Focus()
        End If
    End Sub

    Public Sub clear()
        ' PERSONAL INFORMATION
        cmbo_title.SelectedIndex = -1
        txtbox_lname.Text = ""
        txtbox_fname.Text = ""
        txtbox_mid.Text = ""
        txtbox_suffix.Text = ""
        birthday.Value = Date.Now
        cmbo_gender.SelectedIndex = -1
        cmbo_civil.SelectedIndex = -1
        txtbox_maiden.Text = ""

        ' ADVANCE INFORMATION
        txtbox_tel.Text = ""
        txtbox_phone.Text = ""
        txtbox_add.Text = ""
        cmbo_nat.SelectedIndex = -1
        txtbox_email.Text = ""
        cmbo_educ.SelectedIndex = -1
        txt_school.Text = ""

        ' SPOUSE INFORMATION
        txtbox_slname.Text = ""
        txtbox_sfname.Text = ""
        txtbox_smi.Text = ""
        txtbox_ssuffix.Text = ""
        txtbox_stel.Text = ""
        txtbox_sphone.Text = ""
        txtbox_sadd.Text = ""
        txtbox_sper.Text = ""

        clear_borrower()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clear()
        Dashboard.openChildForm(New Borrower())
    End Sub

    Private Sub Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_borrower()
        Generate_Reference()
        '' PERSONAL INFORMATION
        'cmbo_title.Text = personal_title
        'txtbox_lname.Text = personal_lastname
        'txtbox_fname.Text = personal_firstname
        'txtbox_mid.Text = personal_middlename
        'txtbox_suffix.Text = personal_suffix
        birthday.Value = DateTime.Now
        'cmbo_gender.Text = personal_gender
        'cmbo_civil.Text = personal_civil
        'txtbox_maiden.Text = personal_maiden

        '' ADVANCE INFORMATION TAB
        'txtbox_tel.Text = borrower_telephone
        'txtbox_phone.Text = borrower_phone
        'txtbox_add.Text = borrower_residence
        'cmbo_nat.Text = borrower_nationality
        'txtbox_email.Text = borrower_email
        'cmbo_educ.Text = borrower_education
        'txt_school.Text = borrower_course

        ''SPOUSE INFORMATION
        'txtbox_slname.Text = spouse_lastname
        'txtbox_sfname.Text = spouse_firstname
        'txtbox_smi.Text = spouse_middlename
        'txtbox_ssuffix.Text = spouse_suffix
        'txtbox_stel.Text = spouse_telephone
        'txtbox_sphone.Text = spouse_phone
        'txtbox_sadd.Text = spouse_residential
        'txtbox_sper.Text = spouse_permanent
    End Sub

    Private Sub Generate_Reference()

        openConnection()

        Try

            cmd.Connection = connection

            ' current_branch PUBLIC STRING is inside the checkBranch() it is used during logging in

            If current_branch = "rodolfo_sanchez" Then
                cmd.CommandText = "SELECT max(ID) as ID from rodolfo_sanchez" ' SELECT max ID from rodolfo_sanchez table

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "RS" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "RS" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "credit_care" Then
                cmd.CommandText = "SELECT max(ID) as ID from credit_care"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "CC" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "CC" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "golden_silver" Then
                cmd.CommandText = "SELECT max(ID) as ID from golden_silver"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "GS" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "GS" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "hitrust_financing_corp" Then
                cmd.CommandText = "SELECT max(ID) as ID from hitrust_financing_corp"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "HFC" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "HFC" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "goldstar" Then
                cmd.CommandText = "SELECT max(ID) as ID from goldstar"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "GT" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "GT" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "right_choice_finance" Then
                cmd.CommandText = "SELECT max(ID) as ID from right_choice_finance"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "RCF" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "RCF" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            ElseIf current_branch = "asiagroup_finance" Then
                cmd.CommandText = "SELECT max(ID) as ID from asiagroup_finance"

                reader = cmd.ExecuteReader
                reader.Read()

                If Not reader.HasRows Or IsDBNull(reader.Item("ID")) Then
                    txtbox_reference.Text = "AF" & "0000"
                Else
                    Dim newID As Integer = CInt(reader.Item("ID"))
                    newID += 1
                    txtbox_reference.Text = "AF" & newID.ToString("0000")
                End If

                reader.Close()
                connection.Close()

            Else
                MsgBox("No database found.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' PREVENT MULTILINE
    Private Sub txtbox_reference_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_reference.KeyDown
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

    Private Sub txtbox_fname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_fname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_mid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_mid.KeyDown
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

    Private Sub txtbox_maiden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_maiden.KeyDown
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

    Private Sub txtbox_add_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_add.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_email_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txt_school_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_school.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_slname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_slname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_sfname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sfname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_smi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_smi.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_ssuffix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_ssuffix.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_stel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_stel.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_sphone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sphone.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_sadd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sadd.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtbox_sper_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sper.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' No MultiLine
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

End Class