Imports System.Data.SqlClient

Public Class frm_calandervb

    Public dt As Date = Date.Today
    Dim dt_converted As String = dt.ToString("dd'/'MM'/'yyyy")
    Private Sub frm_calandervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScrollDate()
    End Sub
    Private Sub ScrollDate()

        dt_converted = dt.ToString("dd/MM/yyyy")
        lblSelectedDate.Text = dt_converted
        lblSelectedDay.Text = dt.ToString("dddd")

        MonthCalendar1.SelectionStart = dt_converted
        MonthCalendar1.SelectionEnd = dt_converted
        'PopulateCalenderEvents()
    End Sub

    Private Sub btnBackDay_Click(sender As Object, e As EventArgs) Handles btnBackDay.Click
        dt = dt.AddDays(-1)
        ScrollDate()
    End Sub

    Private Sub btnForwardDay_Click(sender As Object, e As EventArgs) Handles btnForwardDay.Click
        dt = dt.AddDays(+1)
        ScrollDate()
    End Sub
    Public Sub PopulateCalenderEvents()
        Dim table As New DataTable()
        Dim data
        Dim i = 0
        'Dim ViewParameter As String = "%"
        'Dim command As MySqlCommand = New MySqlCommand("SELECT  calID,Left(message, 86) as 'Entry', Status from calendar WHERE date = @appDate and type = 0 or date = @appDate and type = 1 and user = @user;", globalvariables.connection)
        'command.Parameters.Add("@appDate", MySqlDbType.VarChar).Value = dt_converted
        'command.Parameters.Add("@user", MySqlDbType.VarChar).Value = globalvariables.loggedinUser
        'Dim adapter As New MySqlDataAdapter(command)

        'adapter.Fill(table)

        dgv_cal.DataSource = table
        dgv_cal.Columns(0).Visible = False

        For Each row In dgv_cal.Rows
            data = row.Cells(2).Value.ToString
            'MsgBox(data)

            Select Case data
                Case "Current"
                    dgv_cal.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue



                Case "Complete"
                    dgv_cal.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen



            End Select
            i = i + 1
        Next
    End Sub

    Private Sub btn_newEntry_Click(sender As Object, e As EventArgs) Handles btn_newEntry.Click
        Dim frm_newcal As New frm_addCalanderEvent
        frm_newcal.selectedday = dt_converted
        frm_newcal.ShowDialog()
    End Sub
End Class