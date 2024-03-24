<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calandervb
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
        btn_newEntry = New Button()
        MonthCalendar1 = New MonthCalendar()
        dgv_cal = New DataGridView()
        btnBackDay = New Button()
        btnForwardDay = New Button()
        lblSelectedDay = New Label()
        lblSelectedDate = New Label()
        CType(dgv_cal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_newEntry
        ' 
        btn_newEntry.Location = New Point(783, 75)
        btn_newEntry.Name = "btn_newEntry"
        btn_newEntry.Size = New Size(227, 49)
        btn_newEntry.TabIndex = 0
        btn_newEntry.Text = "New Entry"
        btn_newEntry.UseVisualStyleBackColor = True
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(783, 136)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 1
        ' 
        ' dgv_cal
        ' 
        dgv_cal.AllowUserToAddRows = False
        dgv_cal.AllowUserToDeleteRows = False
        dgv_cal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_cal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_cal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_cal.Location = New Point(72, 75)
        dgv_cal.MultiSelect = False
        dgv_cal.Name = "dgv_cal"
        dgv_cal.ReadOnly = True
        dgv_cal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_cal.ShowEditingIcon = False
        dgv_cal.Size = New Size(643, 411)
        dgv_cal.TabIndex = 2
        ' 
        ' btnBackDay
        ' 
        btnBackDay.Location = New Point(72, 33)
        btnBackDay.Name = "btnBackDay"
        btnBackDay.Size = New Size(50, 36)
        btnBackDay.TabIndex = 3
        btnBackDay.Text = "<--"
        btnBackDay.UseVisualStyleBackColor = True
        ' 
        ' btnForwardDay
        ' 
        btnForwardDay.Location = New Point(248, 33)
        btnForwardDay.Name = "btnForwardDay"
        btnForwardDay.Size = New Size(50, 36)
        btnForwardDay.TabIndex = 4
        btnForwardDay.Text = "-->"
        btnForwardDay.UseVisualStyleBackColor = True
        ' 
        ' lblSelectedDay
        ' 
        lblSelectedDay.AutoSize = True
        lblSelectedDay.Font = New Font("Segoe UI", 14F)
        lblSelectedDay.Location = New Point(133, 19)
        lblSelectedDay.Name = "lblSelectedDay"
        lblSelectedDay.Size = New Size(89, 25)
        lblSelectedDay.TabIndex = 5
        lblSelectedDay.Text = "-- DAY --"
        ' 
        ' lblSelectedDate
        ' 
        lblSelectedDate.AutoSize = True
        lblSelectedDate.Font = New Font("Segoe UI", 14F)
        lblSelectedDate.Location = New Point(134, 44)
        lblSelectedDate.Name = "lblSelectedDate"
        lblSelectedDate.Size = New Size(80, 25)
        lblSelectedDate.TabIndex = 6
        lblSelectedDate.Text = "xx/xx/xx"
        ' 
        ' frm_calandervb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 543)
        Controls.Add(lblSelectedDate)
        Controls.Add(lblSelectedDay)
        Controls.Add(btnForwardDay)
        Controls.Add(btnBackDay)
        Controls.Add(dgv_cal)
        Controls.Add(MonthCalendar1)
        Controls.Add(btn_newEntry)
        Name = "frm_calandervb"
        Text = "Calander"
        CType(dgv_cal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_newEntry As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents dgv_cal As DataGridView
    Friend WithEvents btnBackDay As Button
    Friend WithEvents btnForwardDay As Button
    Friend WithEvents lblSelectedDay As Label
    Friend WithEvents lblSelectedDate As Label
End Class
