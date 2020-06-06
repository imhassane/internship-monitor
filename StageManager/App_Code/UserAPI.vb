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
        Public Shared Function AuthenticateWithEmailAndPassword(ByVal email As String, ByVal password As String) As Dictionary(Of String, String)
            Using connection As SqlConnection = TH.DBApi.GetConnection
                connection.Open()

                Dim query = "SELECT
                                cre.cre_id,
                                mem_first_name, mem_last_name
                            FROM t_credentials_cre as cre
                            JOIN t_member_mem as mem ON cre.cre_id = mem.cre_id
                            WHERE cre_email = @Email AND cre_password = HASHBYTES('SHA2_256', @Password)"

                Dim params(1) As SqlParameter
                params(0) = New SqlParameter() With {
                    .ParameterName = "@Email", .DbType = Data.SqlDbType.VarChar, .Value = email
                }

                params(1) = New SqlParameter() With {
                    .ParameterName = "@Password", .DbType = Data.SqlDbType.VarChar, .Value = password
                }

                Dim result As New Dictionary(Of String, String)
                Dim reader As SqlDataReader = TH.DBApi.GetDataReader(connection, query, params)
                reader.Read()

                result.Add("id", reader(0))
                result.Add("first_name", IIf(IsDBNull(reader(1)), Nothing, reader(1)))
                result.Add("last_name", IIf(IsDBNull(reader(2)), Nothing, reader(2)))

                reader.Close()
                ' Getting the user's total internships.
                query = "SELECT COUNT(int_id) FROM t_internship_int WHERE cre_id = " & result("id")
                reader = DBApi.GetDataReader(connection, query)
                reader.Read()
                result.Add("total_internships", IIf(IsDBNull(reader(0)), "0", reader(0).ToString))
                reader.Close()

                ' Getting the user's total projects.
                query = "SELECT
                            COUNT(pro.pro_id)
                        FROM t_project_pro AS pro
                        JOIN t_internship_int as int ON int.int_id = pro.int_id
                        JOIN t_credentials_cre as cre ON cre.cre_id = int.cre_id
                        WHERE cre.cre_id = " & result("id")
                reader = DBApi.GetDataReader(connection, query)
                reader.Read()
                result.Add("total_projects", IIf(IsDBNull(reader(0)), "0", reader(0).ToString))
                reader.Close()
                Return result
            End Using

            Return Nothing
        End Function
#End Region

    End Class

End Namespace