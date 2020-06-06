Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("USER_ID") Then
            Response.Redirect("/dashboard")
        End If
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs)
        Dim email As String = EmailTextBox.Text.Trim
        Dim password As String = PasswordTextBox.Text.Trim

        Dim formError = False

        If email.Length < 5 Then
            formError = True
            ErrorEmail.Visible = True
        Else
            ErrorEmail.Visible = False
        End If

        If password.Length < 8 Then
            formError = True
            ErrorPassword.Visible = True
        Else
            ErrorPassword.Visible = False
        End If

        If Not formError Then
            Dim userInfos As Dictionary(Of String, String) =
                TH.UserAPI.AuthenticateWithEmailAndPassword(email, password)

            If userInfos Is Nothing Then
                ErrorSubmit.Visible = True
            Else
                Session("USER_ID") = userInfos("id")
                Session("USER_FIRST_NAME") = userInfos("first_name")
                Session("USER_LAST_NAME") = userInfos("last_name")
                Session("TOTAL_INTERNSHIPS") = userInfos("total_internships")
                Session("TOTAL_PROJECTS") = userInfos("total_projects")

                Response.Redirect("/dashboard")
            End If
        End If
    End Sub
End Class