<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_opencal
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
        btnMarkComplete = New Button()
        chk_privateNote = New CheckBox()
        Label1 = New Label()
        cmbday = New DateTimePicker()
        txtNotes = New TextBox()
        btnUpdate = New Button()
        lblCalEntry = New Label()
        SuspendLayout()
        ' 
        ' btnMarkComplete
        ' 
        btnMarkComplete.Font = New Font("Segoe UI", 12F)
        btnMarkComplete.Location = New Point(115, 475)
        btnMarkComplete.Name = "btnMarkComplete"
        btnMarkComplete.Size = New Size(211, 28)
        btnMarkComplete.TabIndex = 10
        btnMarkComplete.Text = "Mark Complete"
        btnMarkComplete.UseVisualStyleBackColor = True
        ' 
        ' chk_privateNote
        ' 
        chk_privateNote.AutoSize = True
        chk_privateNote.Font = New Font("Segoe UI", 16F)
        chk_privateNote.Location = New Point(115, 151)
        chk_privateNote.Name = "chk_privateNote"
        chk_privateNote.Size = New Size(152, 34)
        chk_privateNote.TabIndex = 9
        chk_privateNote.Text = "Private Note"
        chk_privateNote.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(84, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 37)
        Label1.TabIndex = 8
        Label1.Text = "Calander Entry: #"
        ' 
        ' cmbday
        ' 
        cmbday.CustomFormat = """dd'/'MM'/'yyyy"""
        cmbday.Font = New Font("Segoe UI", 20F)
        cmbday.Format = DateTimePickerFormat.Short
        cmbday.Location = New Point(115, 90)
        cmbday.Name = "cmbday"
        cmbday.Size = New Size(200, 43)
        cmbday.TabIndex = 7
        ' 
        ' txtNotes
        ' 
        txtNotes.Font = New Font("Segoe UI", 12F)
        txtNotes.Location = New Point(30, 202)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(387, 251)
        txtNotes.TabIndex = 6
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 12F)
        btnUpdate.Location = New Point(115, 509)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(211, 52)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' lblCalEntry
        ' 
        lblCalEntry.AutoSize = True
        lblCalEntry.Font = New Font("Segoe UI", 20F)
        lblCalEntry.Location = New Point(298, 18)
        lblCalEntry.Name = "lblCalEntry"
        lblCalEntry.Size = New Size(39, 37)
        lblCalEntry.TabIndex = 12
        lblCalEntry.Text = "--"
        ' 
        ' frm_opencal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 573)
        Controls.Add(lblCalEntry)
        Controls.Add(btnUpdate)
        Controls.Add(btnMarkComplete)
        Controls.Add(chk_privateNote)
        Controls.Add(Label1)
        Controls.Add(cmbday)
        Controls.Add(txtNotes)
        Name = "frm_opencal"
        Text = "frm_opencal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMarkComplete As Button
    Friend WithEvents chk_privateNote As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbday As DateTimePicker
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCalEntry As Label
End Class
