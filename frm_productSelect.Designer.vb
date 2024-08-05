<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productSelect
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
        dgv_inventory.Location = New Point(23, 108)
        dgv_inventory.MultiSelect = False
        dgv_inventory.Name = "dgv_inventory"
        dgv_inventory.ReadOnly = True
        dgv_inventory.ScrollBars = ScrollBars.Vertical
        dgv_inventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_inventory.Size = New Size(458, 478)
        dgv_inventory.TabIndex = 4
        ' 
        ' frm_productSelect
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 607)
        Controls.Add(dgv_inventory)
        Name = "frm_productSelect"
        Text = "frm_productSelect"
        CType(dgv_inventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_inventory As DataGridView
End Class
