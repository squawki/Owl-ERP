
Public Class globalvariables
    Public Shared versionno As Decimal = 0.1
    Public Shared compaines As New List(Of Company)()
    Public Shared connectionString As String = "Data Source=main_db.db;Version=3;"

    Public Shared selectedcompany As String
    Public Shared selectedcompany_name As String







End Class
Public Class Company
    Public Property CompanyName As String
    Public Property CompanyID As Integer
End Class
