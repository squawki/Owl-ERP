Imports System.Data.SqlClient

Public Class frm_addCalanderEvent
    Public selectedday As String
    Private Sub frm_addCalanderEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            Dim privateType As Integer = 0
            If chk_privateNote.Checked = True Then privateType = 1 Else privateType = 0


            ' create a command to insert
            'Dim command As New MySqlCommand("INSERT INTO calendar(date, message, user, status, type) VALUES (@date, @message, @user, @status, @type)", globalvariables.connection)


            MsgBox("Not Added - TODO")
            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally


        End Try
    End Sub
End Class