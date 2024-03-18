<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers
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
        lblInvoices = New Label()
        dgv_customers = New DataGridView()
        CType(dgv_customers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblInvoices
        ' 
        lblInvoices.AutoSize = True
        lblInvoices.Font = New Font("Segoe UI", 20F)
        lblInvoices.Location = New Point(341, 19)
        lblInvoices.Name = "lblInvoices"
        lblInvoices.Size = New Size(402, 37)
        lblInvoices.TabIndex = 3
        lblInvoices.Text = "Customers For #############"
        ' 
        ' dgv_customers
        ' 
        dgv_customers.AllowUserToAddRows = False
        dgv_customers.AllowUserToDeleteRows = False
        dgv_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_customers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_customers.Location = New Point(33, 75)
        dgv_customers.MultiSelect = False
        dgv_customers.Name = "dgv_customers"
        dgv_customers.ReadOnly = True
        dgv_customers.ScrollBars = ScrollBars.Vertical
        dgv_customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_customers.Size = New Size(1071, 535)
        dgv_customers.TabIndex = 2
        ' 
        ' frm_customers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 668)
        Controls.Add(lblInvoices)
        Controls.Add(dgv_customers)
        Name = "frm_customers"
        Text = "frm_customers"
        CType(dgv_customers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInvoices As Label
    Friend WithEvents dgv_customers As DataGridView
End Class
