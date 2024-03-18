<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoices
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
        DataGridView1 = New DataGridView()
        lblInvoices = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(42, 77)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1071, 535)
        DataGridView1.TabIndex = 0
        ' 
        ' lblInvoices
        ' 
        lblInvoices.AutoSize = True
        lblInvoices.Font = New Font("Segoe UI", 20F)
        lblInvoices.Location = New Point(350, 21)
        lblInvoices.Name = "lblInvoices"
        lblInvoices.Size = New Size(372, 37)
        lblInvoices.TabIndex = 1
        lblInvoices.Text = "Invoices For #############"
        ' 
        ' invoices
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 839)
        Controls.Add(lblInvoices)
        Controls.Add(DataGridView1)
        Name = "invoices"
        Text = "Invoices"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblInvoices As Label
End Class
