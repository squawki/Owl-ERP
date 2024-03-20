Imports System.Data.SQLite

Public Class frm_openCustomer
    Public Property customerID As Integer

    Private Sub frm_openCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        Me.Text = "[" & cmb_company.Text & " Customer] : " & txtFirstName.Text & " " & txtLastName.Text & "  #" & customerID

    End Sub

    Private Sub LoadCustomer()

        cmb_company.DataSource = globalvariables.compaines
        cmb_company.DisplayMember = "companyname"
        cmb_company.ValueMember = "companyid"

        'If Numeric ItemID, based on incrementing primarykey which gets passed
        If IsNumeric(customerID) Then
            If customerID > 0 Then

                ' Set up the SQL query
                Dim query As String = "select assignedCompany, customerFname, customerLname, customerCompany, customerEmail, customerPhoneNo, address_line1, address_line2, address_city, address_state, address_postcode, address_country from customers where customerID = @ID;"



                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", customerID)


                        Using reader As SQLiteDataReader = cmd.ExecuteReader()

                            ' Add all the names from the database to the list
                            While reader.Read()
                                cmb_company.SelectedValue = If(Convert.IsDBNull(reader("assignedCompany")), DBNull.Value, reader("assignedCompany"))
                                cmb_company.Text = globalvariables.GetCompanyNameById(If(Convert.IsDBNull(reader("assignedCompany")), DBNull.Value, reader("assignedCompany")))

                                txtFirstName.Text = If(Convert.IsDBNull(reader("customerFname")), String.Empty, reader("customerFname"))
                                txtLastName.Text = If(Convert.IsDBNull(reader("customerLname")), String.Empty, reader("customerLname"))
                                txtCompany.Text = If(Convert.IsDBNull(reader("customerCompany")), String.Empty, reader("customerCompany"))
                                txtEmail.Text = If(Convert.IsDBNull(reader("customerEmail")), String.Empty, reader("customerEmail"))
                                txtPhoneNo.Text = If(Convert.IsDBNull(reader("customerPhoneNo")), String.Empty, reader("customerPhoneNo"))

                                txt_addressline1.Text = If(Convert.IsDBNull(reader("address_line1")), String.Empty, reader("address_line1"))
                                txt_addressline2.Text = If(Convert.IsDBNull(reader("address_line2")), String.Empty, reader("address_line2"))
                                txt_addresslineState.Text = If(Convert.IsDBNull(reader("address_state")), String.Empty, reader("address_state"))
                                txt_addresslineCity.Text = If(Convert.IsDBNull(reader("address_city")), String.Empty, reader("address_city"))
                                txt_addresslinePostcode.Text = If(Convert.IsDBNull(reader("address_postcode")), String.Empty, reader("address_postcode"))
                                txt_addresslineCountry.Text = If(Convert.IsDBNull(reader("address_country")), String.Empty, reader("address_country"))
                            End While

                        End Using
                    End Using
                End Using
            End If
        End If
    End Sub
End Class