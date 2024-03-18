Imports Owl_ERP.frm_inventory
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Linq


Public Class frm_inventoryItem
    Public Property inventoryitem_code As String
    Private Sub frm_inventoryItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_company.DataSource = globalvariables.compaines
        cmb_company.DisplayMember = "companyname"
        cmb_company.ValueMember = "companyid"

        If inventoryitem_code = "N" Then
            cmb_company.SelectedValue = globalvariables.selectedcompany
            cmb_company.Text = globalvariables.selectedcompany_name
            Me.Text = "Add New Inventory Item"
        End If

        'If Numeric ItemID, based on incrementing primarykey which gets passed
        If IsNumeric(inventoryitem_code) Then
            If inventoryitem_code > 0 Then
                Me.Text = "Edit Inventory Item: " & inventoryitem_code

                ' Set up the SQL query
                Dim query As String = "select company, inventorycode, description, taxrate, price_extax, qty_available from inventory where id = @ID;"



                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", inventoryitem_code)


                        Using reader As SQLiteDataReader = cmd.ExecuteReader()

                            ' Add all the names from the database to the list
                            While reader.Read()
                                cmb_company.SelectedValue = reader("company")
                                cmb_company.Text = globalvariables.GetCompanyNameById(reader("company"))
                                txtItemCode.Text = reader("inventorycode")
                                txtDescription.Text = reader("description")
                                txtTaxrate.Text = reader("taxrate")
                                txtpriceexgst.Text = reader("price_extax")
                                txtAvailableQty.Text = reader("qty_available")
                            End While
                        End Using
                    End Using
                End Using
            End If
        End If


    End Sub


End Class