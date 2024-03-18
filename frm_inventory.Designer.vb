<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventory
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
        dgv_inventory = New DataGridView()
        btnAddItem = New Button()
        lblInvoices = New Label()
        CType(dgv_inventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_inventory
        ' 
        dgv_inventory.AllowUserToAddRows = False
        dgv_inventory.AllowUserToDeleteRows = False
        dgv_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_inventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_inventory.Location = New Point(23, 97)
        dgv_inventory.MultiSelect = False
        dgv_inventory.Name = "dgv_inventory"
        dgv_inventory.ReadOnly = True
        dgv_inventory.ScrollBars = ScrollBars.Vertical
        dgv_inventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_inventory.Size = New Size(906, 489)
        dgv_inventory.TabIndex = 3
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(800, 64)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(129, 27)
        btnAddItem.TabIndex = 4
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' lblInvoices
        ' 
        lblInvoices.AutoSize = True
        lblInvoices.Font = New Font("Segoe UI", 20F)
        lblInvoices.Location = New Point(400, 27)
        lblInvoices.Name = "lblInvoices"
        lblInvoices.Size = New Size(128, 37)
        lblInvoices.TabIndex = 5
        lblInvoices.Text = "Inventory"
        ' 
        ' frm_inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(953, 598)
        Controls.Add(lblInvoices)
        Controls.Add(btnAddItem)
        Controls.Add(dgv_inventory)
        Name = "frm_inventory"
        Text = "Inventory"
        CType(dgv_inventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_inventory As DataGridView
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblInvoices As Label
End Class
