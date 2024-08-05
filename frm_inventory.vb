Imports System.Data.SQLite

Public Class frm_inventory
    Dim inventory_results As New List(Of inventory_result)()

    Private Sub frm_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Public Sub LoadInventory()


        ' Set up the SQL query
        Dim query As String = "select id, companyName, inventorycode, description, price_extax, qty_available from inventory join compaines on inventory.company=compaines.companyID;"



        ' Create a list to store names retrieved from the database
        dgv_inventory.DataSource = Nothing

        inventory_results.Clear()

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()

                        inventory_results.Add(New inventory_result With {.ID = reader("id"), .Company = reader("companyName"), .Code = reader("inventorycode"), .Description = reader("description"), .Price_exGST = reader("price_extax"), .Qty = reader("qty_available")})


                    End While


                End Using

            End Using

        End Using

        'dgv_inventory.DataSource = Nothing

        dgv_inventory.DataSource = inventory_results


    End Sub
    Public Class inventory_result
        Public Property ID As Integer
        Public Property Company As String
        Public Property Code As String
        Public Property Description As String
        Public Property Price_exGST As String

        Public Property Qty As String
    End Class

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim frm_invitm As New frm_inventoryItem
        frm_invitm.inventoryitem_code = "N" 'N for New Item
        frm_invitm.Show()

    End Sub

    Private Sub dgv_inventory_DoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_inventory.DoubleClick
        If dgv_inventory.SelectedRows.Count > 0 Then
            ' Get the value of the cell in the first column of the selected row
            Dim itemid As String = dgv_inventory.SelectedRows(0).Cells(0).Value?.ToString()

            ' Check Inventory ID for is not null
            If itemid IsNot Nothing Then
                Dim frm_invitm As New frm_inventoryItem
                frm_invitm.inventoryitem_code = itemid 'N for New Item
                frm_invitm.Show()
            End If
        Else

        End If
    End Sub
End Class