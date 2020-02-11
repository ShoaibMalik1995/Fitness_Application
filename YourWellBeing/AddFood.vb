Imports YourWellBeingDAL

Public Class AddFood
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub AddFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (ValidateFields()) Then
                Dim FoodName As String = txtFoodName.Text.Trim
                Dim Protein As Int32 = Convert.ToInt32(txtProtein.Text.Trim)
                Dim Calories As Int32 = Convert.ToInt32(txtCalories.Text.Trim)
                Dim Fat As Int32 = Convert.ToInt32(txtFat.Text.Trim)
                Dim Sugar As Int32 = Convert.ToInt32(txtSugar.Text.Trim)
                Dim Crabs As Int32 = Convert.ToInt32(txtCrabs.Text.Trim)
                Dim Sodium As Int32 = Convert.ToInt32(txtSodium.Text.Trim)
                Dim Desc As String = txtDescription.Text.Trim

                Dim IsInserted As Boolean = WBDAL.AddNewFood(FoodName, Protein, Calories, Fat, Sugar, Crabs, Sodium, Desc)
                If IsInserted Then
                    MessageBox.Show("Data save successfully.", "Create New Food")
                Else
                    MessageBox.Show("error occurred.", "Create New Food")
                End If
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Create New Food")
        End Try
    End Sub

    Public Function ValidateFields() As Boolean
        If txtFoodName.Text = "" Then
            MessageBox.Show("Food name is required!")
            txtFoodName.Focus()
            Return False
        ElseIf txtCalories.Text = "" Then
            MessageBox.Show("Calories is required !")
            txtCalories.Focus()
            Return False
        ElseIf txtProtein.Text = "" Then
            MessageBox.Show("Protein is required !")
            txtProtein.Focus()
            Return False
        ElseIf txtCrabs.Text = "" Then
            MessageBox.Show("Crabs is required !")
            txtCrabs.Focus()
            Return False
        ElseIf txtFat.Text = "" Then
            MessageBox.Show("Fat is required !")
            txtFat.Focus()
            Return False
        ElseIf txtSodium.Text = "" Then
            MessageBox.Show("Sodium is required !")
            txtSodium.Focus()
            Return False
        ElseIf txtSugar.Text = "" Then
            MessageBox.Show("Sugar is required !")
            txtSugar.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub ClearFields()
        txtFoodName.Text = ""
        txtCalories.Text = ""
        txtProtein.Text = ""
        txtCrabs.Text = ""
        txtFat.Text = ""
        txtSodium.Text = ""
        txtSugar.Text = ""
        txtDescription.Text = ""

    End Sub

End Class