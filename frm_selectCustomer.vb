Imports System.Data.SQLite


Public Class frm_selectCustomer
    Dim selected_customer As New List(Of select_customer)()
    Dim customer As New select_customer

    Public Property selectedcus As select_customer

    Private Sub frm_selectCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Customers For:  " & globalvariables.selectedcompany_name.ToUpper
        lblcustomers.Text = Me.Text

        customer.ID = 0
        customer.Name = "Name Not Set"
        customer.Company = "Company Not Set"
        selectedcus = customer


        LoadCustomers()
    End Sub
    Private Sub dgv_customers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_customers.CellDoubleClick
        If dgv_customers.SelectedRows.Count > 0 Then
            ' Get the value of the cell in the first column of the selected row
            Dim customerID As String = dgv_customers.SelectedRows(0).Cells(0).Value?.ToString()
            customer.ID = dgv_customers.SelectedRows(0).Cells(0).Value?.ToString()
            customer.Name = dgv_customers.SelectedRows(0).Cells(1).Value?.ToString()
            customer.Company = dgv_customers.SelectedRows(0).Cells(2).Value?.ToString()
            If customerID IsNot Nothing Then

                Me.Close()
            End If
        Else

        End If
    End Sub
    Public Sub LoadCustomers()


        ' Set up the SQL query
        Dim query As String = "select customerid, (customerfname ||' ' || customerlname) as 'Customer Name', customercompany from customers where assignedCompany = @SelectedCompany and customerActive = 1;"

        dgv_customers.DataSource = Nothing

        selected_customer.Clear()
        ' Create a list to store names retrieved from the database

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@SelectedCompany", globalvariables.selectedcompany)


                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()

                        selected_customer.Add(New select_customer With {.ID = reader("customerid"), .Name = reader("Customer Name"), .Company = reader("customercompany")})


                    End While


                End Using

            End Using

        End Using


        dgv_customers.DataSource = selected_customer



    End Sub
    Public Class select_customer
        Public Property ID As Integer
        Public Property Name As String
        Public Property Company As String
    End Class

    Private Sub btn_newcustomer_Click(sender As Object, e As EventArgs) Handles btn_newcustomer.Click
        frm_addCustomer.ShowDialog()

        LoadCustomers()
    End Sub
End Class