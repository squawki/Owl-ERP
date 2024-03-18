<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_createinvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgv_invoice = New DataGridView()
        lbl_currentcompany = New Label()
        Label1 = New Label()
        lblGrandTotal = New Label()
        lblItems = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_createInvoice = New Button()
        line_code = New DataGridViewTextBoxColumn()
        line_description = New DataGridViewTextBoxColumn()
        item_qty = New DataGridViewTextBoxColumn()
        item_taxrate = New DataGridViewTextBoxColumn()
        item_unitcost = New DataGridViewTextBoxColumn()
        line_amount = New DataGridViewTextBoxColumn()
        CType(dgv_invoice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_invoice
        ' 
        dgv_invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_invoice.Columns.AddRange(New DataGridViewColumn() {line_code, line_description, item_qty, item_taxrate, item_unitcost, line_amount})
        dgv_invoice.Location = New Point(94, 100)
        dgv_invoice.Name = "dgv_invoice"
        dgv_invoice.Size = New Size(898, 392)
        dgv_invoice.TabIndex = 0
        ' 
        ' lbl_currentcompany
        ' 
        lbl_currentcompany.AutoSize = True
        lbl_currentcompany.Font = New Font("Segoe UI", 20F)
        lbl_currentcompany.Location = New Point(416, 9)
        lbl_currentcompany.Name = "lbl_currentcompany"
        lbl_currentcompany.Size = New Size(225, 37)
        lbl_currentcompany.TabIndex = 4
        lbl_currentcompany.Text = "#############"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(810, 538)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 37)
        Label1.TabIndex = 5
        Label1.Text = "Total:"
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.AutoSize = True
        lblGrandTotal.Font = New Font("Segoe UI", 20F)
        lblGrandTotal.Location = New Point(896, 538)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(68, 37)
        lblGrandTotal.TabIndex = 6
        lblGrandTotal.Text = "0.00"
        ' 
        ' lblItems
        ' 
        lblItems.AutoSize = True
        lblItems.Font = New Font("Segoe UI", 18F)
        lblItems.Location = New Point(896, 501)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(27, 32)
        lblItems.TabIndex = 8
        lblItems.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F)
        Label4.Location = New Point(803, 501)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 32)
        Label4.TabIndex = 7
        Label4.Text = "Items:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 30)
        Label2.TabIndex = 9
        Label2.Text = "Customer:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(195, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 25)
        Label3.TabIndex = 10
        Label3.Text = "<---Select-->"
        ' 
        ' btn_createInvoice
        ' 
        btn_createInvoice.Location = New Point(802, 647)
        btn_createInvoice.Name = "btn_createInvoice"
        btn_createInvoice.Size = New Size(154, 35)
        btn_createInvoice.TabIndex = 11
        btn_createInvoice.Text = "Create Invoice"
        btn_createInvoice.UseVisualStyleBackColor = True
        ' 
        ' line_code
        ' 
        line_code.HeaderText = "Code"
        line_code.MaxInputLength = 25
        line_code.Name = "line_code"
        ' 
        ' line_description
        ' 
        line_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        line_description.HeaderText = "Description"
        line_description.MaxInputLength = 100
        line_description.MinimumWidth = 250
        line_description.Name = "line_description"
        ' 
        ' item_qty
        ' 
        item_qty.HeaderText = "Qty"
        item_qty.Name = "item_qty"
        ' 
        ' item_taxrate
        ' 
        item_taxrate.HeaderText = "VAT (%)"
        item_taxrate.MaxInputLength = 2
        item_taxrate.MinimumWidth = 75
        item_taxrate.Name = "item_taxrate"
        item_taxrate.Width = 75
        ' 
        ' item_unitcost
        ' 
        item_unitcost.HeaderText = "Unit Cost"
        item_unitcost.Name = "item_unitcost"
        ' 
        ' line_amount
        ' 
        line_amount.HeaderText = "Amount"
        line_amount.MaxInputLength = 7
        line_amount.MinimumWidth = 75
        line_amount.Name = "line_amount"
        line_amount.ReadOnly = True
        line_amount.Width = 75
        ' 
        ' frm_createinvoice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1112, 694)
        Controls.Add(btn_createInvoice)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblItems)
        Controls.Add(Label4)
        Controls.Add(lblGrandTotal)
        Controls.Add(Label1)
        Controls.Add(lbl_currentcompany)
        Controls.Add(dgv_invoice)
        Name = "frm_createinvoice"
        Text = "frm_createinvoice"
        CType(dgv_invoice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_invoice As DataGridView
    Friend WithEvents lbl_currentcompany As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_createInvoice As Button
    Friend WithEvents line_code As DataGridViewTextBoxColumn
    Friend WithEvents line_description As DataGridViewTextBoxColumn
    Friend WithEvents item_qty As DataGridViewTextBoxColumn
    Friend WithEvents item_taxrate As DataGridViewTextBoxColumn
    Friend WithEvents item_unitcost As DataGridViewTextBoxColumn
    Friend WithEvents line_amount As DataGridViewTextBoxColumn
End Class
