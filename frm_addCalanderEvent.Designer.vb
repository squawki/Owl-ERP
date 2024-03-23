<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addCalanderEvent
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
        txtNotes = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        chk_privateNote = New CheckBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(36, 200)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(387, 251)
        txtNotes.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = """dd'/'MM'/'yyyy"""
        DateTimePicker1.Font = New Font("Segoe UI", 20F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(121, 88)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 43)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(121, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 37)
        Label1.TabIndex = 3
        Label1.Text = "Calander Entry"
        ' 
        ' chk_privateNote
        ' 
        chk_privateNote.AutoSize = True
        chk_privateNote.Font = New Font("Segoe UI", 16F)
        chk_privateNote.Location = New Point(121, 149)
        chk_privateNote.Name = "chk_privateNote"
        chk_privateNote.Size = New Size(152, 34)
        chk_privateNote.TabIndex = 4
        chk_privateNote.Text = "Private Note"
        chk_privateNote.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 12F)
        btnSubmit.Location = New Point(121, 471)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(211, 54)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' frm_addCalanderEvent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 557)
        Controls.Add(btnSubmit)
        Controls.Add(chk_privateNote)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtNotes)
        Name = "frm_addCalanderEvent"
        Text = "New Calander Entry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNotes As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_privateNote As CheckBox
    Friend WithEvents btnSubmit As Button
End Class
