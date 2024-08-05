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
            btnItemAction.Text = "Add Item"
        End If

        'If Numeric ItemID, based on incrementing primarykey which gets passed
        If IsNumeric(inventoryitem_code) Then
            If inventoryitem_code > 0 Then
                Me.Text = "Edit Inventory Item: " & inventoryitem_code
                btnItemAction.Text = "Edit Item"
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
                                cmb_company.SelectedValue = If(Convert.IsDBNull(reader("company")), DBNull.Value, reader("company"))
                                cmb_company.Text = globalvariables.GetCompanyNameById(If(Convert.IsDBNull(reader("company")), DBNull.Value, reader("company")))
                                txtItemCode.Text = If(Convert.IsDBNull(reader("inventorycode")), String.Empty, reader("inventorycode"))
                                txtDescription.Text = If(Convert.IsDBNull(reader("description")), String.Empty, reader("description"))
                                txtTaxrate.Text = If(Convert.IsDBNull(reader("taxrate")), String.Empty, reader("taxrate"))
                                txtpriceexgst.Text = If(Convert.IsDBNull(reader("price_extax")), String.Empty, reader("price_extax"))
                                txtAvailableQty.Text = If(Convert.IsDBNull(reader("qty_available")), String.Empty, reader("qty_available"))
                            End While
                        End Using
                    End Using
                End Using
            End If
        End If


    End Sub

    Private Sub btnItemAction_Click(sender As Object, e As EventArgs) Handles btnItemAction.Click
        Dim rowsaffected As Integer = 0
        If inventoryitem_code = "N" Then

            Dim query As String = "insert into inventory (company, inventorycode, description, taxrate, price_extax, qty_available) values (@company, @inventorycode, @description, @taxrate, @price_extax, @qty_available);"



            ' Create a list to store names retrieved from the database

            Using conn As New SQLiteConnection(globalvariables.connectionString)
                conn.Open()

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@company", cmb_company.SelectedValue)
                    cmd.Parameters.AddWithValue("@inventorycode", txtItemCode.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)

                    cmd.Parameters.AddWithValue("@taxrate", txtTaxrate.Text)
                    cmd.Parameters.AddWithValue("@price_extax", txtpriceexgst.Text)
                    cmd.Parameters.AddWithValue("@qty_available", txtAvailableQty.Text)

                    ' Execute the INSERT query
                    rowsaffected = cmd.ExecuteNonQuery()

                End Using
            End Using
            If rowsaffected > 0 Then
                frm_inventory.LoadInventory()
                MsgBox(rowsaffected)
                Me.Close()
            Else
                MsgBox("Error Writing Data - Try Again")
            End If


        End If


        'If Numeric ItemID, based on incrementing primarykey which gets passed
        If IsNumeric(inventoryitem_code) Then
            If inventoryitem_code > 0 Then 'Item then knows its in edit mode otherwise it would be "N"

                Dim query As String = "update inventory set company=@company, inventorycode=@inventorycode, description=@description, taxrate = @taxrate, price_extax = @price_extax, qty_available = @qty_available where id = @id;"

                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", inventoryitem_code)

                        cmd.Parameters.AddWithValue("@company", cmb_company.SelectedValue)
                        cmd.Parameters.AddWithValue("@inventorycode", txtItemCode.Text)
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text)

                        cmd.Parameters.AddWithValue("@taxrate", txtTaxrate.Text)
                        cmd.Parameters.AddWithValue("@price_extax", txtpriceexgst.Text)
                        cmd.Parameters.AddWithValue("@qty_available", txtAvailableQty.Text)

                        ' Execute the INSERT query
                        rowsaffected = cmd.ExecuteNonQuery()

                    End Using
                End Using
                If rowsaffected > 0 Then
                    frm_inventory.LoadInventory()
                    Me.Close()
                Else
                    MsgBox("Error Writing Data - Try Again")
                End If
            End If



        End If


    End Sub
End Class