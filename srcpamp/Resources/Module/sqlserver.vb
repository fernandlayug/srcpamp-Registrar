
Imports System.Data.SqlClient

Module sqlserver

    Public sqlconn As New SqlConnection

    Public sqlcmd As New SqlCommand

    Public sqldr As SqlDataReader

    Public strsql As String

    Public sqlda As New SqlDataAdapter

    Sub connect()
        If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        'sqlconn.ConnectionString = "Data Source=FERNAND-HP\SQLEXPRESS;Initial Catalog=src_db; user id = sa; password = masterfile"
        'sqlconn.ConnectionString = "Data Source=SRCSERV\SQLEXPRESS;Initial Catalog=src_db; user id = sa; password = masterfile"
        sqlconn.ConnectionString = "Data Source=DANL\SQLEXPRESS;Initial Catalog=src_db; user id = sa; password = masterfile"
        sqlconn.Open()
    End Sub
End Module

