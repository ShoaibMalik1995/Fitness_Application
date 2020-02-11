Imports YourWellBeingDAL

Public Class AddDailyExercise
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub AddDailyExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YourWellBeingDataSet4.Exercises' table. You can move, or remove it, as needed.
        'Me.ExercisesTableAdapter1.Fill(Me.YourWellBeingDataSet4.Exercises)
        'TODO: This line of code loads data into the 'YourWellBeingDataSet3.Exercises' table. You can move, or remove it, as needed.
        DDLExerciseType.SelectedItem = "Cardiovascular"

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim dtExerciseList As DataTable = New DataTable()
            dtExerciseList = WBDAL.SearchExercise(txtSearchExercise.Text.Trim, DDLExerciseType.SelectedItem.Trim)

            DataGridView1.DataSource = dtExerciseList

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(0).Value > 0 AndAlso DDLExerciseType.SelectedText IsNot Nothing Then
                Dim _Id As Int32 = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                Dim _ExerciseName As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                Dim _Calories As Double = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Dim Date_Time As DateTime = DateTimePickerDED.Value
                Dim _ExerciseType As String = DDLExerciseType.SelectedItem.ToString()

                Dim isInserted As Boolean = WBDAL.AddDailyExerciseDetails(M_UId, _Id, _ExerciseType, Date_Time)
                If isInserted Then
                    MessageBox.Show("Data save successfully", "Success")
                Else
                    MessageBox.Show("Error Occurred!", "Error")
                End If
            Else
                MessageBox.Show("No record is selected.", "Add Daily Food")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class