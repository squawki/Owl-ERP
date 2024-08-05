Imports System.Data.SQLite

Public Class frm_addCustomer


    Private Sub frm_addCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        cmb_company.DataSource = globalvariables.compaines
        cmb_company.DisplayMember = "companyname"
        cmb_company.ValueMember = "companyid"
        cmb_company.SelectedValue = globalvariables.selectedcompany
        cmb_company.Text = globalvariables.selectedcompany_name
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        Dim query As String = "insert into customers (assignedCompany, customerFname, customerLname, customerCompany, customerEmail, customerPhoneNo, address_line1, address_line2, address_city, address_state, address_postcode, address_country, customeractive) values (@companyID, @firstName, @lastName, @company, @email, @phone, @address_line1, @address_line2, @address_city, @address_state, @address_postcode, @address_country, 1);"
        Dim rowsaffected As Integer
        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("@companyID", cmb_company.SelectedValue)
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@company", txtCompany.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhoneNo.Text)

                cmd.Parameters.AddWithValue("@address_line1", txt_addressline1.Text)
                cmd.Parameters.AddWithValue("@address_line2", txt_addressline2.Text)
                cmd.Parameters.AddWithValue("@address_city", txt_addresslineCity.Text)
                cmd.Parameters.AddWithValue("@address_state", txt_addresslineState.Text)
                cmd.Parameters.AddWithValue("@address_postcode", txt_addresslinePostcode.Text)
                cmd.Parameters.AddWithValue("@address_country", txt_addresslineCountry.Text)




                ' Execute the INSERT query
                rowsaffected = cmd.ExecuteNonQuery()

            End Using
        End Using

        If rowsaffected > 0 Then

            Me.Close()
        Else
            MsgBox("Error Writing Data - Try Again")
        End If

    End Sub
End Class