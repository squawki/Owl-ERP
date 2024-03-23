<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_selectCustomer
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
        lblcustomers = New Label()
        dgv_customers = New DataGridView()
        btn_newcustomer = New Button()
        CType(dgv_customers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblcustomers
        ' 
        lblcustomers.AutoSize = True
        lblcustomers.Font = New Font("Segoe UI", 20F)
        lblcustomers.Location = New Point(59, 9)
        lblcustomers.Name = "lblcustomers"
        lblcustomers.Size = New Size(402, 37)
        lblcustomers.TabIndex = 5
        lblcustomers.Text = "Customers For #############"
        ' 
        ' dgv_customers
        ' 
        dgv_customers.AllowUserToAddRows = False
        dgv_customers.AllowUserToDeleteRows = False
        dgv_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_customers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_customers.Location = New Point(12, 84)
        dgv_customers.MultiSelect = False
        dgv_customers.Name = "dgv_customers"
        dgv_customers.ReadOnly = True
        dgv_customers.ScrollBars = ScrollBars.Vertical
        dgv_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_customers.Size = New Size(514, 514)
        dgv_customers.TabIndex = 4
        ' 
        ' btn_newcustomer
        ' 
        btn_newcustomer.Location = New Point(419, 49)
        btn_newcustomer.Name = "btn_newcustomer"
        btn_newcustomer.Size = New Size(107, 30)
        btn_newcustomer.TabIndex = 6
        btn_newcustomer.Text = "New Customer"
        btn_newcustomer.UseVisualStyleBackColor = True
        ' 
        ' frm_selectCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 624)
        Controls.Add(btn_newcustomer)
        Controls.Add(lblcustomers)
        Controls.Add(dgv_customers)
        Name = "frm_selectCustomer"
        Text = "Select Customer"
        CType(dgv_customers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcustomers As Label
    Friend WithEvents dgv_customers As DataGridView
    Friend WithEvents btn_newcustomer As Button
End Class
