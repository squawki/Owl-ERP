<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventoryItem
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
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtAvailableQty = New TextBox()
        txtpriceexgst = New TextBox()
        txtTaxrate = New TextBox()
        txtDescription = New TextBox()
        Label1 = New Label()
        txtItemCode = New TextBox()
        cmb_company = New ComboBox()
        btnItemAction = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(11, 282)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 21)
        Label6.TabIndex = 36
        Label6.Text = "Avilable Qty:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(5, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 21)
        Label5.TabIndex = 35
        Label5.Text = "Price (ex/tax):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(12, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 34
        Label4.Text = "Tax Rate (%):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(15, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 21)
        Label3.TabIndex = 33
        Label3.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(23, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 32
        Label2.Text = "Item Code:"
        ' 
        ' txtAvailableQty
        ' 
        txtAvailableQty.Font = New Font("Segoe UI", 12F)
        txtAvailableQty.Location = New Point(118, 274)
        txtAvailableQty.Name = "txtAvailableQty"
        txtAvailableQty.Size = New Size(264, 29)
        txtAvailableQty.TabIndex = 31
        ' 
        ' txtpriceexgst
        ' 
        txtpriceexgst.Font = New Font("Segoe UI", 12F)
        txtpriceexgst.Location = New Point(118, 213)
        txtpriceexgst.Name = "txtpriceexgst"
        txtpriceexgst.Size = New Size(264, 29)
        txtpriceexgst.TabIndex = 30
        ' 
        ' txtTaxrate
        ' 
        txtTaxrate.Font = New Font("Segoe UI", 12F)
        txtTaxrate.Location = New Point(118, 178)
        txtTaxrate.Name = "txtTaxrate"
        txtTaxrate.Size = New Size(264, 29)
        txtTaxrate.TabIndex = 29
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 12F)
        txtDescription.Location = New Point(118, 127)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(264, 29)
        txtDescription.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(49, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 27
        Label1.Text = "Profile:"
        ' 
        ' txtItemCode
        ' 
        txtItemCode.Font = New Font("Segoe UI", 12F)
        txtItemCode.Location = New Point(118, 92)
        txtItemCode.Name = "txtItemCode"
        txtItemCode.Size = New Size(264, 29)
        txtItemCode.TabIndex = 26
        ' 
        ' cmb_company
        ' 
        cmb_company.Font = New Font("Segoe UI", 12F)
        cmb_company.FormattingEnabled = True
        cmb_company.Location = New Point(118, 39)
        cmb_company.Name = "cmb_company"
        cmb_company.Size = New Size(264, 29)
        cmb_company.TabIndex = 25
        ' 
        ' btnItemAction
        ' 
        btnItemAction.Location = New Point(138, 361)
        btnItemAction.Name = "btnItemAction"
        btnItemAction.Size = New Size(232, 48)
        btnItemAction.TabIndex = 24
        btnItemAction.Text = "### Item"
        btnItemAction.UseVisualStyleBackColor = True
        ' 
        ' frm_inventoryItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(990, 585)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAvailableQty)
        Controls.Add(txtpriceexgst)
        Controls.Add(txtTaxrate)
        Controls.Add(txtDescription)
        Controls.Add(Label1)
        Controls.Add(txtItemCode)
        Controls.Add(cmb_company)
        Controls.Add(btnItemAction)
        Name = "frm_inventoryItem"
        Text = "frm_inventoryItem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAvailableQty As TextBox
    Friend WithEvents txtpriceexgst As TextBox
    Friend WithEvents txtTaxrate As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents cmb_company As ComboBox
    Friend WithEvents btnItemAction As Button
End Class
