Imports YourWellBeingDAL
Imports YourWellBeingEntities

Public Class LoginForm
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()
    Dim mainDashboard As MainDashboard = New MainDashboard()

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMsg.Text = ""
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_SignIN_Click(sender As Object, e As EventArgs) Handles Button_SignIN.Click
        Try
            Dim UserInfo As User = New User()
            Dim isValid As Boolean = False
            If (ValidateForm()) Then
                isValid = WBDAL.UserLogin(txtUserName.Text, txtPassword.Text, UserInfo)
                If (isValid) Then
                    ClearFields()
                    'Redirect TO Main Dashboard
                    M_UId = UserInfo.Id
                    M_UFName = UserInfo.FirstName
                    M_ULName = UserInfo.LastName
                    M_UserName = UserInfo.UserName
                    M_UEmail = UserInfo.Email
                    M_UPassword = UserInfo.Password
                    Me.Hide()
                    mainDashboard.Show()
                Else
                    lblMsg.Text = "Invalid UserName or Password !"
                    lblMsg.ForeColor = Color.Red
                End If

            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try
    End Sub

    Private Sub btnRegisterUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnRegisterUser.LinkClicked
        Dim RegForm As RegistrationForm = New RegistrationForm()
        Me.Hide()
        RegForm.Show()
    End Sub

    Public Function ValidateForm() As Boolean

        If String.IsNullOrEmpty(txtUserName.Text.Trim()) Then
            MessageBox.Show("Kindly fill the User Name!", "Login Error")
            txtUserName.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
            MessageBox.Show("Password is required.", "Login Error")
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub ClearFields()
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub

End Class