Imports Owl_ERP.frm_inventory
Imports System.Data.SQLite
Public Class frm_productSelect
    Dim inventory_results As New List(Of inventory_result)()
    Dim selectedProductID As Integer
    Private Sub frm_productSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Private Sub LoadInventory()


        ' Set up the SQL query
        Dim query As String = "select id, inventorycode, description, price_extax, qty_available from inventory where company = @SelectedCompany;"



        ' Create a list to store names retrieved from the database
        dgv_inventory.DataSource = Nothing

        inventory_results.Clear()

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@SelectedCompany", globalvariables.selectedcompany)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()

                        inventory_results.Add(New inventory_result With {.ID = reader("id"), .Code = reader("inventorycode"), .Description = reader("description"), .Price_exGST = reader("price_extax"), .Qty = reader("qty_available")})


                    End While


                End Using

            End Using

        End Using

        'dgv_inventory.DataSource = Nothing

        dgv_inventory.DataSource = inventory_results


    End Sub

    Private Sub dgv_inventory_DoubleClick(sender As Object, e As EventArgs) Handles dgv_inventory.DoubleClick

        If dgv_inventory.SelectedRows.Count > 0 Then
            ' Get the value of the cell in the first column of the selected row
            Dim itemid As Integer = dgv_inventory.SelectedRows(0).Cells(0).Value?.ToString()

            ' Check Inventory ID for is not null
            If IsNumeric(itemid) Then
                selectedProductID = itemid
                Me.DialogResult = DialogResult.OK
            End If
        Else

        End If





    End Sub

    Public Function GetSelectedProductID() As Integer
        Return selectedProductID
    End Function

End Class