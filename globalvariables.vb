
Public Class globalvariables
    Public Shared versionno As Decimal = 0.1
    Public Shared compaines As New List(Of Company)()
    Public Shared connectionString As String = "Data Source=main_db.db;Version=3;"

    Public Shared selectedcompany As String
    Public Shared selectedcompany_name As String
    Public Shared defaulttaxrate As Decimal = 10

    Public Shared Function GetCompanyNameById(ByVal companyId As Integer) As String
        ' Find the company with the specified ID
        Dim company As Company = compaines.FirstOrDefault(Function(c) c.CompanyID = companyId)

        ' Check if a matching company is found
        If company IsNot Nothing Then
            ' Return the company name
            Return company.CompanyName
        Else
            ' Company not found
            Return Nothing
        End If
    End Function




End Class
Public Class Company
    Public Property CompanyName As String
    Public Property CompanyID As Integer
End Class
