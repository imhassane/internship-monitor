Imports System.Data
Imports System.Data.SqlClient

Namespace TH

    Public Class DBApi

        Public Shared Function GetConnection() As SqlConnection
            Dim cString = ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString
            Return New SqlConnection(cString)
        End Function

        Public Shared Function GetDataReader(ByVal connection As SqlConnection, ByVal query As String) As SqlDataReader
            Dim command As SqlCommand = connection.CreateCommand()

            command.CommandText = query
            Return command.ExecuteReader()
        End Function

        Public Shared Function GetDataReader(ByVal connection As SqlConnection, ByVal query As String, ByVal params As SqlParameter()) As SqlDataReader
            Dim command As SqlCommand = connection.CreateCommand()

            command.CommandText = query
            command.Parameters.AddRange(params)

            Return command.ExecuteReader()
        End Function

        Public Shared Function GetDataReader(ByVal command As SqlCommand, ByVal query As String) As SqlDataReader
            command.CommandText = query

            Return command.ExecuteReader()
        End Function

        Public Shared Function GetDataReader(ByVal command As SqlCommand, ByVal query As String, ByVal params As SqlParameter()) As SqlDataReader
            command.CommandText = query
            command.Parameters.AddRange(params)

            Return command.ExecuteReader()
        End Function

        Public Shared Function RunQuery(ByVal connection As SqlConnection, ByVal query As String) As Integer
            Dim command As SqlCommand = connection.CreateCommand()
            command.Connection = connection

            Return DBApi.RunQuery(command, query)
        End Function

        Public Shared Function RunQuery(ByVal connection As SqlConnection, ByVal query As String, ByVal params As SqlParameter()) As Integer
            Dim command As SqlCommand = connection.CreateCommand()
            command.Connection = connection
            command.Parameters.AddRange(params)

            Return DBApi.RunQuery(command, query)
        End Function

        Public Shared Function RunQuery(ByRef command As SqlCommand, ByVal query As String) As Integer
            command.CommandText = query
            Return command.ExecuteScalar()
        End Function

        Public Shared Function RunQuery(ByRef command As SqlCommand, ByVal query As String, ByVal params As SqlParameter()) As Integer
            command.CommandText = query
            command.Parameters.AddRange(params)

            Return command.ExecuteScalar()
        End Function

    End Class

End Namespace

