Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class frm_addCalanderEvent
    Public selectedday As String
    Private Sub frm_addCalanderEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt_converted As String = selectedday 'dt.ToString("dd'/'MM'/'yyyy")
        cmbday.Value = dt_converted
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            Dim privateType As Integer = 0
            If chk_privateNote.Checked = True Then privateType = 1 Else privateType = 0


            ' create a command to insert
            'Dim command As New MySqlCommand("INSERT INTO calendar(date, message, user, status, type) VALUES (@date, @message, @user, @status, @type)", globalvariables.connection)


            Dim query As String = "insert into calendar (item_date, added_date, message, user, status, type ) values 
(@item_date, @added_date, @message, @user, @status, @type);"
            Dim rowsaffected As Integer
            Using conn As New SQLiteConnection(globalvariables.connectionString)
                conn.Open()

                Using cmd As New SQLiteCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@item_date", Format(cmbDay.Value, "dd'/'MM'/'yyyy"))
                    cmd.Parameters.AddWithValue("@added_date", Format(DateTime.Now, "dd'/'MM'/'yyyy hh:mm:ss"))
                    cmd.Parameters.AddWithValue("@message", txtNotes.Text)
                    cmd.Parameters.AddWithValue("@user", "Default")   '<-----When User Auth added, signed in user goes here
                    cmd.Parameters.AddWithValue("@status", "Current")
                    cmd.Parameters.AddWithValue("@type", privateType) '<----- Only user who created note can see it


                    ' Execute the INSERT query
                    rowsaffected = cmd.ExecuteNonQuery()

                End Using
            End Using

            If rowsaffected > 0 Then

                Me.Close()
            Else
                MsgBox("Error Writing Data - Try Again")
            End If


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally


        End Try
    End Sub
End Class