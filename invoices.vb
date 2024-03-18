Public Class invoices
    Private Sub invoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Invoices For:  " & globalvariables.selectedcompany_name.ToUpper
        lblInvoices.Text = Me.Text

    End Sub
End Class