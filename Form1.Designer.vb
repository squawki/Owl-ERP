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
        Button3 = New Button()
        btn_newcustomer = New Button()
        Button5 = New Button()
        Button6 = New Button()
        cmb_company = New ComboBox()
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
        ' Button3
        ' 
        Button3.Location = New Point(21, 170)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 41)
        Button3.TabIndex = 2
        Button3.Text = "New Invoice"
        Button3.UseVisualStyleBackColor = True
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
        Button5.Location = New Point(21, 519)
        Button5.Name = "Button5"
        Button5.Size = New Size(151, 41)
        Button5.TabIndex = 4
        Button5.Text = "Settings"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(21, 217)
        Button6.Name = "Button6"
        Button6.Size = New Size(151, 41)
        Button6.TabIndex = 5
        Button6.Text = "New Quote"
        Button6.UseVisualStyleBackColor = True
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
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(cmb_company)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(btn_newcustomer)
        Controls.Add(Button3)
        Controls.Add(btn_opencustomers)
        Controls.Add(btn_openInvoices)
        Name = "form1"
        Text = "Owl ERP v1.00"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_openInvoices As Button
    Friend WithEvents btn_opencustomers As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_newcustomer As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cmb_company As ComboBox

End Class
