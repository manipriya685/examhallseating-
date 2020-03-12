Imports System.Data.SqlClient
Imports System.IO
Public Class class2
    Dim conn As New SqlConnection
    Dim cmd As SqlCommand
    Public dr As SqlDataReader
    Public ms As MemoryStream
    Sub connect()
        conn.ConnectionString = "data source = bmw-groups\sqlexpress;initial catalog = examcellbd;integrated security = true"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

End Class
