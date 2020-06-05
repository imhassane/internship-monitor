Imports System.Data
Imports System.Data.SqlClient

Namespace TH

    Public Class DBApi

        Public Shared Function GetConnection() As SqlConnection
            Dim cString = ConfigurationManager.ConnectionStrings("").ConnectionString
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
            command.CommandText = query
            command.Connection = connection

            command.Parameters.Add("@RETURN", SqlDbType.Int)
            command.Parameters("@RETURN").Direction = ParameterDirection.ReturnValue
            command.ExecuteNonQuery()

            Return command.Parameters("@RETURN").Value
        End Function

        Public Shared Function RunQuery(ByVal connection As SqlConnection, ByVal query As String, ByVal params As SqlParameter()) As Integer
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = query
            command.Connection = connection
            command.Parameters.AddRange(params)

            command.Parameters.Add("@RETURN", SqlDbType.Int)
            command.Parameters("@RETURN").Direction = ParameterDirection.ReturnValue
            command.ExecuteNonQuery()

            Return command.Parameters("@RETURN").Value
        End Function

        Public Shared Function RunQuery(ByVal command As SqlCommand, ByVal query As String) As Integer
            command.CommandText = query

            command.Parameters.Add("@RETURN", SqlDbType.Int)
            command.Parameters("@RETURN").Direction = ParameterDirection.ReturnValue
            command.ExecuteNonQuery()

            Return command.Parameters("@RETURN").Value
        End Function

        Public Shared Function RunQuery(ByVal command As SqlCommand, ByVal query As String, ByVal params As SqlParameter()) As Integer
            command.CommandText = query
            command.Parameters.AddRange(params)

            command.Parameters.Add("@RETURN", SqlDbType.Int)
            command.Parameters("@RETURN").Direction = ParameterDirection.ReturnValue
            command.ExecuteNonQuery()

            Return command.Parameters("@RETURN").Value
        End Function

    End Class

End Namespace

