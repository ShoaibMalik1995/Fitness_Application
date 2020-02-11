Imports YourWellBeingDAL

Public Class AddDailyFood
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub AddDailyFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YourWellBeingDataSet2.Food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.YourWellBeingDataSet2.Food)
        DDLFoodType.SelectedItem = "Breakfast"

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim dtFoodList As DataTable = New DataTable()
            dtFoodList = WBDAL.SearchFoodByName(txtSearchFood.Text.Trim)

            DataGridView1.DataSource = dtFoodList

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(0).Value > 0 AndAlso DDLFoodType.SelectedText IsNot Nothing Then
                Dim _Id As Int32 = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                Dim _FoodName As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                Dim _Calories As Double = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Dim Date_Time As DateTime = DateTimePickerFDF.Value
                Dim _FoodType As String = DDLFoodType.SelectedItem.ToString()

                Dim isInserted As Boolean = WBDAL.AddDailyFoodDetails(M_UId, _Id, _FoodType, Date_Time)
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