Imports YourWellBeingDAL
Imports YourWellBeingEntities

Public Class DefineYourGoal
    Dim Gender As String = "Male"
    Dim Activity As String = ""
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()
    Dim UserGoalProfile As UserGoalProfile = New UserGoalProfile()

    Private Sub DefineYourGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = M_UserName
        btnSaveGoal.Text = "Save"
        UserGoalProfile = WBDAL.GetUserGoalProfileById(M_UId)
        If UserGoalProfile.UId > 0 Then
            btnSaveGoal.Text = "Update"
            txtCurrentWeight.Text = UserGoalProfile.CurrentWeight
            txtHeight.Text = UserGoalProfile.Height
            txtGWeight.Text = UserGoalProfile.GoalWeight
            DatePicker_DOB.Value = Convert.ToDateTime(UserGoalProfile.DOB)
            If UserGoalProfile.Gender = "Male" Then
                RBMale.Checked = True
                Gender = "Male"
            Else
                RBFemale.Checked = True
                Gender = "Female"
            End If
            DDLCountry.SelectedItem = UserGoalProfile.Country
            txtZipCode.Text = UserGoalProfile.Zip
            txtUserName.Text = UserGoalProfile.UserName
            DDLWODays.SelectedItem = UserGoalProfile.NoOfWorkoutDays.ToString()
            txtWOMins.Text = UserGoalProfile.WorkoutMins
            If UserGoalProfile.DailyActivity = "Sedentary: Spend most of the day sitting e.g. bank teller, desk job" Then
                RDBActivity1.Checked = True
                Activity = "Sedentary: Spend most of the day sitting e.g. bank teller, desk job"
            ElseIf UserGoalProfile.DailyActivity = "Lightly Active: Spend a good part of the day on your feet e.g. teacher, salesperson" Then
                RDBActivity2.Checked = True
                Activity = "Lightly Active: Spend a good part of the day on your feet e.g. teacher, salesperson"
            ElseIf UserGoalProfile.DailyActivity = "Active: Spend a good part of the day doing some physical activity e.g. food server, postal carrier" Then
                RDBActivity3.Checked = True
                Activity = "Active: Spend a good part of the day doing some physical activity e.g. food server, postal carrier"
            ElseIf UserGoalProfile.DailyActivity = "Very Active: Spend most of the day doing heavy physical activity e.g bike messanger, carpenter" Then
                RDBActivity4.Checked = True
                Activity = "Very Active: Spend most of the day doing heavy physical activity e.g bike messanger, carpenter"
            End If
            DDLGoals.SelectedItem = UserGoalProfile.GoalDescription
        Else

        End If
    End Sub

    Private Sub RBMale_CheckedChanged(sender As Object, e As EventArgs) Handles RBMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RBFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RBFemale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RDBActivity1_CheckedChanged(sender As Object, e As EventArgs) Handles RDBActivity1.CheckedChanged
        Activity = "Sedentary: Spend most of the day sitting e.g. bank teller, desk job"
    End Sub

    Private Sub RDBActivity2_CheckedChanged(sender As Object, e As EventArgs) Handles RDBActivity2.CheckedChanged
        Activity = "Lightly Active: Spend a good part of the day on your feet e.g. teacher, salesperson"

    End Sub

    Private Sub RDBActivity3_CheckedChanged(sender As Object, e As EventArgs) Handles RDBActivity3.CheckedChanged
        Activity = "Active: Spend a good part of the day doing some physical activity e.g. food server, postal carrier"
    End Sub

    Private Sub RDBActivity4_CheckedChanged(sender As Object, e As EventArgs) Handles RDBActivity4.CheckedChanged
        Activity = "Very Active: Spend most of the day doing heavy physical activity e.g bike messanger, carpenter"
    End Sub

    Private Sub btnSaveGoal_Click(sender As Object, e As EventArgs) Handles btnSaveGoal.Click
        Try
            Dim Id As Int32 = M_UId
            If btnSaveGoal.Text = "Save" Then
                Dim DOB As DateTime = Convert.ToDateTime(DatePicker_DOB.Text)

                Dim IsCreated As Boolean = WBDAL.CreateProfile(Id, txtCurrentWeight.Text, txtHeight.Text, txtGWeight.Text, Gender, DOB, DDLCountry.SelectedItem.ToString, txtZipCode.Text,
                                    txtUserName.Text, Activity, DDLWODays.SelectedItem, txtWOMins.Text, DDLGoals.SelectedItem.ToString())

                If IsCreated Then
                    MessageBox.Show("Data Save Successfully.", "User Goal Profile.")
                End If
            ElseIf btnSaveGoal.Text = "Update" Then
                Dim DOB As DateTime = Convert.ToDateTime(DatePicker_DOB.Text)

                Dim IsUpdate As Boolean = WBDAL.UpdateProfile(Id, txtCurrentWeight.Text, txtHeight.Text, txtGWeight.Text, Gender, DOB, DDLCountry.SelectedItem.ToString, txtZipCode.Text,
                                    txtUserName.Text, Activity, DDLWODays.SelectedItem, txtWOMins.Text, DDLGoals.SelectedItem.ToString())

                If IsUpdate Then
                    MessageBox.Show("Data Updated Successfully.", "User Goal Profile.")
                End If
            End If

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

End Class