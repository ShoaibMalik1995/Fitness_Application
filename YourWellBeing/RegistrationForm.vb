Imports System.Text.RegularExpressions
Imports YourWellBeingDAL

Public Class RegistrationForm
    Dim loginform As LoginForm = New LoginForm()
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()
    Dim RegexExp As Regex = New Regex("^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$")

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMsg.Text = ""
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            Dim isInserted As Boolean = False
            If (ValidateForm()) Then
                isInserted = WBDAL.RegisterUser(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtEmail.Text, txtPassword.Text)
                If (isInserted) Then
                    ClearFields()
                    lblMsg.Text = "User Created Successfully"
                    lblMsg.ForeColor = Color.Green
                End If
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try
    End Sub

    Private Sub SignInLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLink.LinkClicked
        Me.Hide()
        LoginForm.Show()
    End Sub

    Public Function ValidateForm() As Boolean

        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Then
            MessageBox.Show("Kindly fill the first name!", "Registration Error")
            txtFirstName.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Kindly fill the last name!", "Registration Error")
            txtLastName.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtUserName.Text.Trim()) Then
            MessageBox.Show("Kindly fill the User Name!", "Registration Error")
            txtUserName.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtEmail.Text.Trim()) Then
            MessageBox.Show("Kindly fill the Email!", "Registration Error")
            txtEmail.Focus()
            Return False
        ElseIf (Not RegexExp.IsMatch(txtEmail.Text.Trim())) Then
            MessageBox.Show("E-mail address format is not correct!", "Registration Error")
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim()) Or String.IsNullOrEmpty(txtConfirmPassword.Text.Trim()) Then
            MessageBox.Show("Password is required.", "Registration Error")
            txtPassword.Focus()
            Return False
        ElseIf txtPassword.Text.Trim() <> txtConfirmPassword.Text.Trim Then
            MessageBox.Show("Password is not matched!", "Registration Error")
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub ClearFields()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtUserName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

End Class