Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class frm_opencal
    Public CalID As Integer

    Private Sub frm_opencal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CalID < 1 Then
            MsgBox("Calendar Entry Not Set - Exiting")
            Me.Close()
        End If

        Me.Text = "Calendar Entry " & CalID
        lblCalEntry.Text = CalID
        LoadCalItem()

    End Sub
    Private Sub LoadCalItem()

        If IsNumeric(CalID) Then
            If CalID > 0 Then

                ' Set up the SQL query
                Dim query As String = "select message, type, item_date from calendar WHERE calid= @calID;"
                Dim type As Integer


                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@calID", CalID)


                        Using reader As SQLiteDataReader = cmd.ExecuteReader()

                            ' Add all the names from the database to the list
                            While reader.Read()
                                txtNotes.Text = If(Convert.IsDBNull(reader("message")), String.Empty, reader("message"))
                                type = If(Convert.IsDBNull(reader("type")), String.Empty, reader("type"))

                                cmbday.Text = If(Convert.IsDBNull(reader("item_date")), String.Empty, reader("item_date"))
                                If type = 1 Then chk_privateNote.Checked = True Else chk_privateNote.Checked = False
                            End While

                        End Using
                    End Using
                End Using
            End If
        End If

    End Sub

    Private Sub btnMarkComplete_Click(sender As Object, e As EventArgs) Handles btnMarkComplete.Click

        Dim type As Integer
        If chk_privateNote.Checked Then Type = 1 Else Type = 0


        Dim rowsaffected As Integer = 0
        If IsNumeric(CalID) Then
            If CalID > 0 Then

                Dim query As String = "update calendar set message= @message , type = @type, item_date = @item_date, status = 'Complete' WHERE calid= @calid;"

                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@calid", CalID)

                        cmd.Parameters.AddWithValue("@message", txtNotes.Text)
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.Parameters.AddWithValue("@item_date", Format(cmbday.Value, "dd'/'MM'/'yyyy"))


                        ' Execute the INSERT query
                        rowsaffected = cmd.ExecuteNonQuery()

                    End Using
                End Using
                If rowsaffected > 0 Then
                    Me.Close()
                Else
                    MsgBox("Error Writing Data - Try Again")
                End If



            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim type As Integer
        If chk_privateNote.Checked Then type = 1 Else type = 0


        Dim rowsaffected As Integer = 0
        If IsNumeric(CalID) Then
            If CalID > 0 Then

                Dim query As String = "update calendar set message= @message , type = @type, item_date = @item_date WHERE calid= @calid;"

                ' Create a list to store names retrieved from the database

                Using conn As New SQLiteConnection(globalvariables.connectionString)
                    conn.Open()

                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@calid", CalID)

                        cmd.Parameters.AddWithValue("@message", txtNotes.Text)
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.Parameters.AddWithValue("@item_date", Format(cmbday.Value, "dd'/'MM'/'yyyy"))


                        ' Execute the INSERT query
                        rowsaffected = cmd.ExecuteNonQuery()

                    End Using
                End Using
                If rowsaffected > 0 Then
                    Me.Close()
                Else
                    MsgBox("Error Writing Data - Try Again")
                End If



            End If
        End If
    End Sub
End Class