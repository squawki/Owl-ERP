Imports System.Data.SQLite

Public Class frm_customers
    Dim customer_results As New List(Of customer_result)()
    Private Sub frm_customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Customers For:  " & globalvariables.selectedcompany_name.ToUpper
        lblInvoices.Text = Me.Text

        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()


        ' Set up the SQL query
        Dim query As String = "select customerid, (customerfname ||' ' || customerlname) as 'Customer Name', customercompany, customerPhoneNo, customerEmail from customers where assignedCompany = @SelectedCompany and customerActive = 1;"



        ' Create a list to store names retrieved from the database

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@SelectedCompany", globalvariables.selectedcompany)


                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()

                        customer_results.Add(New customer_result With {.ID = reader("customerid"), .Name = reader("Customer Name"), .Company = reader("customercompany"), .Phone = reader("customerPhoneNo"), .Email = reader("customerEmail")})


                    End While


                End Using

            End Using

        End Using


        dgv_customers.DataSource = customer_results



    End Sub



End Class
Public Class customer_result
    Public Property ID As Integer
    Public Property Name As String
    Public Property Company As String
    Public Property Phone As String
    Public Property Email As String
End Class