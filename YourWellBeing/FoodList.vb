Imports YourWellBeingDAL

Public Class FoodList
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub FoodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YourWellBeingDataSet.Food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.YourWellBeingDataSet.Food)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim dtFoodList As DataTable = New DataTable()
            dtFoodList = WBDAL.SearchFoodByName(txtSearch.Text.Trim)

            DataGridView1.DataSource = dtFoodList

        Catch ex As Exception
            Dim exp As String = ex.Message
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class