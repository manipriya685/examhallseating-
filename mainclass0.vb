Imports System.Data.SqlClient
Imports System.IO
Public Class mainclass0
    Dim conn As New SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Public dr1 As SqlDataReader
    Public dr As SqlDataReader
    Dim i As Integer
    Dim dt As New DataTable
    Public ms As MemoryStream

    Sub connect()
        conn.ConnectionString = "data source = bmw-groups\sqlexpress;initial catalog = examcellbd;integrated security = true"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub
    Sub read(ByVal s As String)
        cmd = New SqlCommand(s, conn)
        dr = cmd.ExecuteReader

    End Sub
    Sub insert(sql As String)
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

    End Sub
    Sub update(sql As String)
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub delete(sql As String)
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

    End Sub
End Class
