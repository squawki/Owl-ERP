<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addCustomer
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
        btnAddCustomer = New Button()
        cmb_company = New ComboBox()
        txtFirstName = New TextBox()
        Label1 = New Label()
        txtLastName = New TextBox()
        txtCompany = New TextBox()
        txtPhoneNo = New TextBox()
        txtEmail = New TextBox()
        txt_addressline1 = New TextBox()
        txt_addressline2 = New TextBox()
        txt_addresslineCity = New TextBox()
        txt_addresslineState = New TextBox()
        txt_addresslinePostcode = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txt_addresslineCountry = New TextBox()
        SuspendLayout()
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Location = New Point(108, 393)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(232, 48)
        btnAddCustomer.TabIndex = 0
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' cmb_company
        ' 
        cmb_company.Font = New Font("Segoe UI", 12F)
        cmb_company.FormattingEnabled = True
        cmb_company.Location = New Point(108, 54)
        cmb_company.Name = "cmb_company"
        cmb_company.Size = New Size(264, 29)
        cmb_company.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 12F)
        txtFirstName.Location = New Point(108, 111)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(264, 29)
        txtFirstName.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(32, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 9
        Label1.Text = "Profile:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 12F)
        txtLastName.Location = New Point(108, 146)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(264, 29)
        txtLastName.TabIndex = 10
        ' 
        ' txtCompany
        ' 
        txtCompany.Font = New Font("Segoe UI", 12F)
        txtCompany.Location = New Point(108, 181)
        txtCompany.Name = "txtCompany"
        txtCompany.Size = New Size(264, 29)
        txtCompany.TabIndex = 11
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.Font = New Font("Segoe UI", 12F)
        txtPhoneNo.Location = New Point(108, 266)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.Size = New Size(264, 29)
        txtPhoneNo.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(108, 301)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(264, 29)
        txtEmail.TabIndex = 13
        ' 
        ' txt_addressline1
        ' 
        txt_addressline1.Font = New Font("Segoe UI", 12F)
        txt_addressline1.Location = New Point(595, 104)
        txt_addressline1.Name = "txt_addressline1"
        txt_addressline1.Size = New Size(264, 29)
        txt_addressline1.TabIndex = 14
        ' 
        ' txt_addressline2
        ' 
        txt_addressline2.Font = New Font("Segoe UI", 12F)
        txt_addressline2.Location = New Point(595, 139)
        txt_addressline2.Name = "txt_addressline2"
        txt_addressline2.Size = New Size(264, 29)
        txt_addressline2.TabIndex = 15
        ' 
        ' txt_addresslineCity
        ' 
        txt_addresslineCity.Font = New Font("Segoe UI", 12F)
        txt_addresslineCity.Location = New Point(595, 196)
        txt_addresslineCity.Name = "txt_addresslineCity"
        txt_addresslineCity.Size = New Size(264, 29)
        txt_addresslineCity.TabIndex = 16
        ' 
        ' txt_addresslineState
        ' 
        txt_addresslineState.Font = New Font("Segoe UI", 12F)
        txt_addresslineState.Location = New Point(595, 231)
        txt_addresslineState.Name = "txt_addresslineState"
        txt_addresslineState.Size = New Size(264, 29)
        txt_addresslineState.TabIndex = 17
        ' 
        ' txt_addresslinePostcode
        ' 
        txt_addresslinePostcode.Font = New Font("Segoe UI", 12F)
        txt_addresslinePostcode.Location = New Point(595, 266)
        txt_addresslinePostcode.Name = "txt_addresslinePostcode"
        txt_addresslinePostcode.Size = New Size(264, 29)
        txt_addresslinePostcode.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(13, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 19
        Label2.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(15, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 20
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(20, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 21
        Label4.Text = "Company:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(22, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 21)
        Label5.TabIndex = 22
        Label5.Text = "PhoneNo:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(49, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 21)
        Label6.TabIndex = 23
        Label6.Text = "Email:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(478, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 21)
        Label7.TabIndex = 24
        Label7.Text = "Address Line1:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(478, 142)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 21)
        Label8.TabIndex = 25
        Label8.Text = "Address Line2:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(549, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 21)
        Label9.TabIndex = 26
        Label9.Text = "City:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(542, 234)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 21)
        Label10.TabIndex = 27
        Label10.Text = "State:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(509, 269)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 21)
        Label11.TabIndex = 28
        Label11.Text = "Post Code:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(520, 304)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 21)
        Label12.TabIndex = 30
        Label12.Text = "Country:"
        ' 
        ' txt_addresslineCountry
        ' 
        txt_addresslineCountry.Font = New Font("Segoe UI", 12F)
        txt_addresslineCountry.Location = New Point(595, 301)
        txt_addresslineCountry.Name = "txt_addresslineCountry"
        txt_addresslineCountry.Size = New Size(264, 29)
        txt_addresslineCountry.TabIndex = 29
        ' 
        ' frm_addCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(922, 485)
        Controls.Add(Label12)
        Controls.Add(txt_addresslineCountry)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_addresslinePostcode)
        Controls.Add(txt_addresslineState)
        Controls.Add(txt_addresslineCity)
        Controls.Add(txt_addressline2)
        Controls.Add(txt_addressline1)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNo)
        Controls.Add(txtCompany)
        Controls.Add(txtLastName)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(cmb_company)
        Controls.Add(btnAddCustomer)
        Name = "frm_addCustomer"
        Text = "Add Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents cmb_company As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txt_addressline1 As TextBox
    Friend WithEvents txt_addressline2 As TextBox
    Friend WithEvents txt_addresslineCity As TextBox
    Friend WithEvents txt_addresslineState As TextBox
    Friend WithEvents txt_addresslinePostcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_addresslineCountry As TextBox
End Class
