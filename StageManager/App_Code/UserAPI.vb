Imports System.Data.SqlClient

Namespace TH
    Public Class UserAPI

#Region "New user"
        Public Shared Function NewCredentials(ByVal email As String, ByVal password As String) As Integer
            Dim result = -1

            Using connection As SqlConnection = TH.DBApi.GetConnection()
                connection.Open()

                Dim params(1) As SqlParameter
                Dim emailParam As New SqlParameter() With
                {
                    .ParameterName = "@Email",
                    .DbType = Data.SqlDbType.VarChar,
                    .Value = email
                }
                Dim passwordParam As New SqlParameter() With
                {
                    .ParameterName = "@Password",
                    .DbType = Data.SqlDbType.VarChar,
                    .Value = password
                }

                params(0) = emailParam
                params(1) = passwordParam

                Dim transaction = connection.BeginTransaction("Credentials")
                Dim command = connection.CreateCommand()

                command.Connection = connection
                command.Transaction = transaction

                Try
                    ' Creating user's credentials
                    Dim query = "
                        INSERT INTO t_credentials_cre(cre_email, cre_password)
                        VALUES (@Email, HASHBYTES('SHA2_256', @Password))"
                    result = DBApi.RunQuery(command, query, params)

                    ' Then creating user's profile
                    query = "INSERT INTO t_member_mem(cre_id) VALUES (" & result & ")"
                    DBApi.RunQuery(command, query)

                    transaction.Commit()
                Catch ex As Exception
                    Try
                        transaction.Rollback()
                    Catch ex2 As Exception
                        result = -1
                    End Try
                    result = -1
                End Try
            End Using

            Return result
        End Function
#End Region

#Region "Authenticating user"
        Public Shared Function AuthenticateWithEmailAndPassword(ByVal email As String, ByVal password As String) As Integer
            Using connection As SqlConnection = TH.DBApi.GetConnection

                Dim query = "SELECT
                                cre.cre_id,
                                mem_first_name, mem_last_name
                            FROM t_credentials_cre as cre
                            JOIN t_member_mem as mem ON cre.cre_id = mem.cre_id
                            WHERE cre_email = @Email AND cre_password = @Password"
                Dim params(2) As SqlParameter
                params(0) = New SqlParameter() With {
                    .ParameterName = "@Email", .DbType = Data.SqlDbType.VarChar, .Value = email
                }

                params(1) = New SqlParameter() With {
                    .ParameterName = "@Password", .DbType = Data.SqlDbType.VarChar, .Value = password
                }
                Dim result = Nothing
                Dim reader As SqlDataReader = TH.DBApi.GetDataReader(connection, query)
                reader.Read()
                result = reader(0)
                reader.Close()

                Return result
            End Using
            Return -1
        End Function
#End Region

    End Class

End Namespace