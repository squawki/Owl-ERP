Imports System
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class form1





    Private Sub frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "OWL ERP  v" & globalvariables.versionno




        TestConnection()


    End Sub


    Private Sub TestConnection()
        Try
            Using conn As New SQLiteConnection(globalvariables.connectionString)
                conn.Open()
                GetSetCompaines()
            End Using
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message)
        End Try


    End Sub


    Private Sub GetSetCompaines()

        ' Set up the SQL query
        Dim query As String = "select companyid, companyname from compaines;"


        ' Create a list to store names retrieved from the database

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()

                        globalvariables.compaines.Add(New Company() With {.CompanyName = reader("companyname"), .CompanyID = reader("companyid")})

                    End While


                End Using

            End Using
        End Using


        cmb_company.DataSource = globalvariables.compaines
        cmb_company.DisplayMember = "companyname"
        cmb_company.ValueMember = "companyid"

        globalvariables.selectedcompany = cmb_company.SelectedValue.ToString
        globalvariables.selectedcompany_name = cmb_company.Text


    End Sub

    Private Sub cmb_company_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_company.SelectedValueChanged
        globalvariables.selectedcompany = cmb_company.SelectedValue.ToString
        globalvariables.selectedcompany_name = cmb_company.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_openInvoices.Click
        invoices.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_opencustomers.Click
        frm_customers.Show()
    End Sub

    Private Sub btn_newcustomer_Click(sender As Object, e As EventArgs) Handles btn_newcustomer.Click
        frm_addCustomer.Show()
    End Sub

    Private Sub btn_newInvoice_Click(sender As Object, e As EventArgs) Handles btn_newInvoice.Click

        Dim invform As New frm_createinvoice
        invform.formtype = "I"
        invform.Show()
    End Sub

    Private Sub btnNewQuote_Click(sender As Object, e As EventArgs) Handles btnNewQuote.Click
        Dim invform As New frm_createinvoice
        invform.formtype = "Q"
        invform.Show()
    End Sub

    Private Sub btn_Inventory_Click(sender As Object, e As EventArgs) Handles btn_Inventory.Click

        frm_inventory.Show()
    End Sub
End Class
