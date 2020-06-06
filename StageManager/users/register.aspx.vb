Public Class register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("USER_ID") Then
            Response.Redirect("/dashboard")
        End If
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs)
        Dim email As String = EmailTextBox.Text.Trim
        Dim password As String = PasswordTextBox.Text.Trim
        Dim repeat As String = RepeatTextBox.Text.Trim

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

        If Not [String].Equals(password, repeat) Or repeat.Length < 8 Then
            formError = True
            ErrorRepeat.Visible = True
        Else
            ErrorRepeat.Visible = False
        End If

        If Not formError Then
            Dim userID As Integer = TH.UserAPI.NewCredentials(email, password)

            If userID > 0 Then
                ' Initialization of user's session.
                Session("USER_ID") = userID
                Session("TOTAL_INTERNSHIPS") = 0
                Session("TOTAL_PROJECTS") = 0

                Response.Redirect("/dashboard")
            Else
                ErrorSubmit.Visible = True
            End If
        End If
    End Sub
End Class