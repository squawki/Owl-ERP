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
            ' Check if the cell in the second column is not empty
            Dim cellValue As String = row.Cells(2).Value?.ToString()
            If Not row.IsNewRow Then

                If Not String.IsNullOrWhiteSpace(cellValue) Then
                    ' Try parsing the cell value to an decimal
                    Dim number As Decimal
                    If Decimal.TryParse(cellValue, number) Then
                        ' If successful, add the number to the total sum
                        rowCount += number
                    Else
                        ' Handle parsing failure if needed
                        'MessageBox.Show("Invalid number in row " & row.Index + 1)
                    End If
                End If
            End If
        Next

        lblItems.Text = rowCount

    End Sub

    Private Sub dgv_invoice_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_invoice.CellEndEdit
        calculateLineTotal()
        countItems()
        calculateTotal()


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
End Class