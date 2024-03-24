Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class frm_calandervb

    Public dt As Date = Date.Today
    Dim dt_converted As String = dt.ToString("dd'/'MM'/'yyyy")
    Dim calander_items As New List(Of cal_item)()

    Private Sub frm_calandervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScrollDate()
    End Sub
    Private Sub ScrollDate()

        dt_converted = dt.ToString("dd/MM/yyyy")
        lblSelectedDate.Text = dt_converted
        lblSelectedDay.Text = dt.ToString("dddd")

        MonthCalendar1.SelectionStart = dt_converted
        MonthCalendar1.SelectionEnd = dt_converted
        PopulateCalenderEvents()
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
        Dim data
        Dim i = 0


        Dim query As String = "SELECT calID, substr(message, 1, 86) as 'Entry', Status from calendar WHERE item_date = @appDate and type = 0 or item_date = @appDate and type = 1 and user = @user;"



        ' Create a list to calander events names retrieved from the database
        calander_items.Clear()
        dgv_cal.DataSource = Nothing
        Using conn As New SQLiteConnection(globalvariables.connectionString)
            conn.Open()

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@appDate", dt_converted)
                cmd.Parameters.AddWithValue("@user", "Default")

                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        calander_items.Add(New cal_item With {.calID = reader("calID"), .Entry = reader("Entry"), .Status = reader("Status")})


                    End While


                End Using

            End Using

        End Using


        dgv_cal.DataSource = calander_items
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
        PopulateCalenderEvents()
    End Sub

    Private Sub dgv_cal_DoubleClick(sender As Object, e As EventArgs) Handles dgv_cal.DoubleClick
        Dim rowvalue
        If dgv_cal.CurrentRow IsNot Nothing AndAlso dgv_cal.Rows(dgv_cal.CurrentRow.Index).Cells(0) IsNot Nothing AndAlso dgv_cal.Rows(dgv_cal.CurrentRow.Index).Cells(0).Value IsNot Nothing Then
            rowvalue = dgv_cal.Rows(dgv_cal.CurrentRow.Index).Cells(0).Value
        Else
            Exit Sub
        End If

        Try


            If rowvalue IsNot "" And Not IsDBNull(rowvalue) Then

                Dim frm_opcal As New frm_opencal
                frm_opcal.CalID = rowvalue
                frm_opcal.ShowDialog()
                PopulateCalenderEvents()

            Else
                Dim frm_addcal As New frm_addCalanderEvent
                frm_addcal.selectedday = dt_converted
                frm_addcal.ShowDialog()

            End If

        Catch ex As Exception

        End Try


    End Sub

End Class
Public Class cal_item
    Public Property calID As Integer
    Public Property Entry As String
    Public Property Status As String

End Class