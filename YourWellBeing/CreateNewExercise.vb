Imports YourWellBeingDAL

Public Class CreateNewExercise
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub CreateNewExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DDLExerciseType.SelectedItem = "Cardiovascular"
        GroupBox2.Visible = False
    End Sub

    Private Sub DDLExerciseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLExerciseType.SelectedIndexChanged
        If DDLExerciseType.Text = "Strength Training" Then
            GroupBox2.Location = New Point(17, 107)
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        Else
            GroupBox1.Location = New Point(17, 107)
            GroupBox2.Visible = False
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (ValidateFiels()) Then
                Dim ExerciseName As String = txtExerciseName.Text.Trim
                Dim ExerciseType As String = DDLExerciseType.SelectedItem.ToString.Trim
                'Cardiovascular
                Dim Howlong As Int32 = Convert.ToInt32(txtHowlong.Text.Trim)
                Dim CaloriesBurned As Int32 = Convert.ToInt32(txtCaloriesBurned.Text.Trim)
                'Strength Training
                Dim Sets As Int32 = Convert.ToInt32(txtSet.Text.Trim)
                Dim Repetitions_Sets As Int32 = Convert.ToInt32(txtRepetitionsSets.Text.Trim)
                Dim WeightSets As Int32 = Convert.ToInt32(txtWeightSet.Text.Trim)

                Dim IsCreated As Boolean = WBDAL.CreateNewExercise(ExerciseName, ExerciseType, Howlong, CaloriesBurned, Sets, Repetitions_Sets, WeightSets)
                If IsCreated Then
                    ClearFields()
                    MessageBox.Show("Data save successfully.", "Create New Exercise")
                Else
                    MessageBox.Show("Error Occured!", "Create New Exercise")
                End If
            End If

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Public Function ValidateFiels() As Boolean
        If txtExerciseName.Text.Trim = "" Then
            MessageBox.Show("Exercise Name is required!", "Create New Exercise")
            txtExerciseName.Focus()
            Return False
        ElseIf DDLExerciseType.SelectedItem.ToString.Trim = "" Then
            MessageBox.Show("Kindly select the exercise type!", "Create New Exercise")
            DDLExerciseType.Focus()
            Return False
        End If
        'Cardiovascular
        If txtHowlong.Text.Trim = "" Then
            txtHowlong.Text = "0"
        End If
        If txtCaloriesBurned.Text.Trim = "" Then
            txtCaloriesBurned.Text = "0"
        End If
        'Strength Training
        If lblset.Text.Trim = "" Then
            lblset.Text = "0"
        End If
        If txtRepetitionsSets.Text.Trim = "" Then
            txtRepetitionsSets.Text = "0"
        End If
        If txtWeightSet.Text.Trim = "" Then
            txtWeightSet.Text = "0"
        End If

        Return True
    End Function

    Public Sub ClearFields()
        txtExerciseName.Text = ""
        txtHowlong.Text = "0"
        txtCaloriesBurned.Text = "0"
        txtSet.Text = "0"
        txtRepetitionsSets.Text = "0"
        txtWeightSet.Text = "0"
    End Sub
End Class