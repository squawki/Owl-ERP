<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_openInvoices = New Button()
        btn_opencustomers = New Button()
        btn_newInvoice = New Button()
        btn_newcustomer = New Button()
        Button5 = New Button()
        btnNewQuote = New Button()
        cmb_company = New ComboBox()
        btn_Inventory = New Button()
        btn_calander = New Button()
        SuspendLayout()
        ' 
        ' btn_openInvoices
        ' 
        btn_openInvoices.Location = New Point(21, 123)
        btn_openInvoices.Name = "btn_openInvoices"
        btn_openInvoices.Size = New Size(243, 41)
        btn_openInvoices.TabIndex = 0
        btn_openInvoices.Text = "Invoices"
        btn_openInvoices.UseVisualStyleBackColor = True
        ' 
        ' btn_opencustomers
        ' 
        btn_opencustomers.Location = New Point(21, 324)
        btn_opencustomers.Name = "btn_opencustomers"
        btn_opencustomers.Size = New Size(243, 41)
        btn_opencustomers.TabIndex = 1
        btn_opencustomers.Text = "Customers"
        btn_opencustomers.UseVisualStyleBackColor = True
        ' 
        ' btn_newInvoice
        ' 
        btn_newInvoice.Location = New Point(21, 170)
        btn_newInvoice.Name = "btn_newInvoice"
        btn_newInvoice.Size = New Size(151, 41)
        btn_newInvoice.TabIndex = 2
        btn_newInvoice.Text = "New Invoice"
        btn_newInvoice.UseVisualStyleBackColor = True
        ' 
        ' btn_newcustomer
        ' 
        btn_newcustomer.Location = New Point(21, 371)
        btn_newcustomer.Name = "btn_newcustomer"
        btn_newcustomer.Size = New Size(151, 41)
        btn_newcustomer.TabIndex = 3
        btn_newcustomer.Text = "New Customer"
        btn_newcustomer.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(378, 599)
        Button5.Name = "Button5"
        Button5.Size = New Size(151, 41)
        Button5.TabIndex = 4
        Button5.Text = "Settings"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btnNewQuote
        ' 
        btnNewQuote.Location = New Point(21, 217)
        btnNewQuote.Name = "btnNewQuote"
        btnNewQuote.Size = New Size(151, 41)
        btnNewQuote.TabIndex = 5
        btnNewQuote.Text = "New Quote"
        btnNewQuote.UseVisualStyleBackColor = True
        ' 
        ' cmb_company
        ' 
        cmb_company.Font = New Font("Segoe UI", 14F)
        cmb_company.FormattingEnabled = True
        cmb_company.Location = New Point(12, 12)
        cmb_company.Name = "cmb_company"
        cmb_company.Size = New Size(264, 33)
        cmb_company.TabIndex = 6
        ' 
        ' btn_Inventory
        ' 
        btn_Inventory.Location = New Point(21, 456)
        btn_Inventory.Name = "btn_Inventory"
        btn_Inventory.Size = New Size(243, 41)
        btn_Inventory.TabIndex = 7
        btn_Inventory.Text = "Inventory"
        btn_Inventory.UseVisualStyleBackColor = True
        ' 
        ' btn_calander
        ' 
        btn_calander.Location = New Point(334, 324)
        btn_calander.Name = "btn_calander"
        btn_calander.Size = New Size(243, 41)
        btn_calander.TabIndex = 8
        btn_calander.Text = "Calander"
        btn_calander.UseVisualStyleBackColor = True
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(btn_calander)
        Controls.Add(btn_Inventory)
        Controls.Add(cmb_company)
        Controls.Add(btnNewQuote)
        Controls.Add(Button5)
        Controls.Add(btn_newcustomer)
        Controls.Add(btn_newInvoice)
        Controls.Add(btn_opencustomers)
        Controls.Add(btn_openInvoices)
        Name = "form1"
        Text = "Owl ERP v1.00"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_openInvoices As Button
    Friend WithEvents btn_opencustomers As Button
    Friend WithEvents btn_newInvoice As Button
    Friend WithEvents btn_newcustomer As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnNewQuote As Button
    Friend WithEvents cmb_company As ComboBox
    Friend WithEvents btn_Inventory As Button
    Friend WithEvents btn_calander As Button

End Class
