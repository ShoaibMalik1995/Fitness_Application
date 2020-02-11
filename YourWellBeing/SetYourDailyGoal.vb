Imports YourWellBeingDAL

Public Class SetYourDailyGoal
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub SetYourDailyGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCaloriesCount.Text = UDGC_NumberOfCalories
        DDLCType.SelectedItem = UDGC_GoalType
        txtdailyCalories.Text = UDGC_NumberOfCalories
    End Sub

    Private Sub btnSaveGoal_Click(sender As Object, e As EventArgs) Handles btnSaveGoal.Click
        Try
            Dim isSuccess As Boolean = WBDAL.CreateUpdateUserDailyGoal(UDGC_Id, UDGC_UId, DDLCType.SelectedItem.ToString.Trim, txtdailyCalories.Text.Trim)
            If (isSuccess) Then
                MessageBox.Show("Data save successfully.", "Success Message")
                lblCaloriesCount.Text = txtdailyCalories.Text.Trim
                UDGC_NumberOfCalories = txtdailyCalories.Text.Trim
                UDGC_GoalType = DDLCType.SelectedItem.ToString.Trim

            Else
                MessageBox.Show("Error Occured.", "Error Message")
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show("Error Occured.", "Error Message")
        End Try
    End Sub

End Class