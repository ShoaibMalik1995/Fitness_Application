Imports YourWellBeingDAL

Public Class ExerciseList
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub ExerciseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DDLExerciseType.SelectedItem = "All"
        'TODO: This line of code loads data into the 'YourWellBeingDataSet1.Exercises' table. You can move, or remove it, as needed.
        Me.ExercisesTableAdapter.Fill(Me.YourWellBeingDataSet1.Exercises)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim dtExerciseList As DataTable = New DataTable()
            dtExerciseList = WBDAL.SearchExerciseByType(DDLExerciseType.SelectedItem.Trim)

            DataGridView1.DataSource = dtExerciseList

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub
End Class