Imports Owl_ERP.frm_inventory
Imports System.Data.Entity.Core
Imports System.Data.SQLite

Public Class frm_createinvoice
    Public Property formtype As String = "I"
    Dim companyid As Integer
    Dim customerid As Integer

    Private Sub frm_createinvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formtypetext As String = ""
        If formtype = "Q" Then formtypetext = "Quote"
        If formtype = "I" Then formtypetext = "Invoice"

        Me.Text = formtypetext & " (" & globalvariables.selectedcompany_name.ToUpper & ")"
        lbl_currentcompany.Text = Me.Text
        companyid = globalvariables.selectedcompany
        addrow()

        PrefillNewRow()
    End Sub



    Private Sub calculateTotal()

        Dim totalSum As Decimal = 0.00


        For Each row As DataGridViewRow In dgv_invoice.Rows
            ' Check if the row is not the blank add new row
            If Not row.IsNewRow Then
                ' Check if the cell in the second column is not empty
                Dim cellValue As String = row.Cells(5).Value?.ToString()
                If Not String.IsNullOrWhiteSpace(cellValue) Then
                    ' Try parsing the cell value to an decimal
                    Dim number As Decimal
                    If Decimal.TryParse(cellValue, number) Then
                        ' If successful, add the number to the total sum
                        totalSum += number
                    Else
                        ' Handle parsing failure if needed
                        'MessageBox.Show("Invalid number in row " & row.Index + 1)
                    End If
                End If
            End If
        Next

        lblGrandTotal.Text = totalSum.ToString("0.00")

    End Sub

    Private Sub countItems()
        Dim rowCount As Decimal = 0

        For Each row As DataGridViewRow In dgv_invoice.Rows
            ' Check if the row is not the blank add new row
            If Not row.IsNewRow Then
                ' Get the value of the first column and the item code column
                Dim firstColumnValue As String = row.Cells(0).Value?.ToString()
                Dim itemCode As String = row.Cells(1).Value?.ToString()
                Dim cellValue As String = row.Cells(2).Value?.ToString()

                ' Check if the first column is not empty and the item code has at least one character
                If Not String.IsNullOrWhiteSpace(firstColumnValue) AndAlso Not String.IsNullOrWhiteSpace(itemCode) AndAlso itemCode.Length > 0 Then
                    ' Check if the cell in the third column is not empty
                    If Not String.IsNullOrWhiteSpace(cellValue) Then
                        ' Try parsing the cell value to a decimal
                        Dim number As Decimal
                        If Decimal.TryParse(cellValue, number) Then
                            ' If successful, add the number to the total sum
                            rowCount += number
                        Else
                            ' Handle parsing failure if needed
                            ' MessageBox.Show("Invalid number in row " & row.Index + 1)
                        End If
                    End If
                End If
            End If
        Next

        lblItems.Text = rowCount.ToString()
    End Sub

    Private Sub dgv_invoice_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_invoice.CellEndEdit
        calculateLineTotal()
        countItems()
        calculateTotal()
        addrow()
        PrefillNewRow()
    End Sub

    Private Sub calculateLineTotal()


        For Each row As DataGridViewRow In dgv_invoice.Rows
            ' Check if the row is not the blank add new row
            Dim qtyValue As Decimal = row.Cells(2).Value?.ToString()
            Dim unitCost As Decimal = row.Cells(4).Value?.ToString()


            If Not row.IsNewRow Then

                If Not String.IsNullOrWhiteSpace(qtyValue) And Not String.IsNullOrWhiteSpace(unitCost) Then
                    ' Try parsing the cell value to an decimal
                    Dim number As Decimal
                    If Decimal.TryParse(qtyValue, number) Then
                        ' If successful, add the number to the total sum
                        row.Cells(5).Value = (qtyValue * unitCost).ToString("0.00")
                    Else
                        ' Handle parsing failure if needed
                        'MessageBox.Show("Invalid number in row " & row.Index + 1)
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub PrefillNewRow()
        ' Get the index of the new row
        Dim newRowIdx As Integer = dgv_invoice.Rows.Count - 1

        ' Set default values for each cell in the new row
        For Each cell As DataGridViewCell In dgv_invoice.Rows(newRowIdx).Cells
            ' Set default value based on column index or any other logic
            Select Case cell.ColumnIndex

                Case 2 'Default Qty
                    cell.Value = "1"
                Case 3 'Default Tax Rate
                    cell.Value = globalvariables.defaulttaxrate
                Case 4 'Default Tax Rate
                    cell.Value = "0.00"
                Case 5 'Default Tax Rate
                    cell.Value = "0.00"
            End Select
        Next
    End Sub

    Private Sub dgv_invoice_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_invoice.RowsAdded
        PrefillNewRow()

    End Sub

    Private Sub lblSelectCustomer_Click(sender As Object, e As EventArgs) Handles lblSelectCustomer.Click
        Dim selected_id As Integer
        Dim selected_name As String
        Dim selected_company As String

        Dim frm_selCustomer As New frm_selectCustomer
        frm_selCustomer.ShowDialog()

        Try

            If frm_selCustomer.selectedcus.ID > 0 Then


                selected_id = frm_selCustomer.selectedcus.ID
                selected_name = frm_selCustomer.selectedcus.Name
                selected_company = frm_selCustomer.selectedcus.Company
                customerid = selected_id
                lblSelectCustomer.Text = selected_name & " (" & selected_company & ")"
            End If
        Catch ex As NullReferenceException

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_invoice_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_invoice.CellMouseUp
        ' Check if the right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Check if the clicked cell is the first cell of any row
            If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
                ' Display a message box with the value of the clicked cell

                Dim frm_selprod As New frm_productSelect
                If frm_selprod.ShowDialog() = DialogResult.OK Then

                    Dim selectedProductID As String = frm_selprod.GetSelectedProductID()

                    'MsgBox(selectedProductID)
                    LoadInItemNo(selectedProductID, e.RowIndex.ToString)
                End If
            End If
        End If



    End Sub

    Private Sub LoadInItemNo(ByVal _item As Integer, ByVal _row As Integer)

        If dgv_invoice.IsCurrentCellInEditMode Then
            ' End the edit mode and commit the changes
            dgv_invoice.EndEdit()
        End If

        Dim inventory_results As New List(Of inventory_result)()







        Dim query As String = "select inventorycode, description, price_extax, taxrate from inventory where id = @id;"

        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", _item)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    ' Add all the names from the database to the list
                    While reader.Read()
                        'inventory_results.Add(New inventory_result With {.Code = reader("inventorycode"), .Description = reader("description"), .Price_exGST = reader("price_extax"), .Qty = reader("qty_available")})
                        dgv_invoice.Rows(_row).Cells(0).Value = reader("inventorycode")
                        dgv_invoice.Rows(_row).Cells(1).Value = reader("description")
                        dgv_invoice.Rows(_row).Cells(3).Value = reader("taxrate")
                        dgv_invoice.Rows(_row).Cells(4).Value = reader("price_extax")
                        addrow()
                    End While
                End Using
            End Using
        End Using
        PrefillNewRow()
        calculateLineTotal()
        countItems()
        calculateTotal()

    End Sub

    Private Sub addrow()
        Dim canAddRow As Boolean = True

        ' Iterate through all existing rows in the DataGridView
        For Each row As DataGridViewRow In dgv_invoice.Rows
            ' Skip the new row placeholder
            If Not row.IsNewRow Then
                ' Get the values of the first column and item code column
                Dim firstColumnValue As String = row.Cells(0).Value?.ToString()
                Dim itemCode As String = row.Cells(1).Value?.ToString()

                ' Check if the first column is empty or item code is less than 1 character
                If String.IsNullOrWhiteSpace(firstColumnValue) OrElse String.IsNullOrWhiteSpace(itemCode) OrElse itemCode.Length < 1 Then
                    ' Set the flag to false as a row with invalid data is found
                    canAddRow = False
                    Exit For ' Exit the loop as an empty row already txists
                End If
            End If
        Next

        ' Add a new row only if all existing rows are valid
        If canAddRow Then
            dgv_invoice.Rows.Add()
        Else

        End If
    End Sub
End Class

