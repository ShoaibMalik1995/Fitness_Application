Imports YourWellBeingEntities
Imports YourWellBeingDAL

Public Class MainDashboard
    Dim WBDAL As WellBeingDAL = New WellBeingDAL()

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set User Calories Goal Values
        SetUserDailyGaolValues()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim loginform As LoginForm = New LoginForm()
        Me.Hide()
        loginform.Show()
    End Sub

    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        'Create New Food
        Dim foodform As AddDailyFood = New AddDailyFood()
        foodform.Show()
        foodform.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
        'Create New Exercise
        Dim exerciseform As AddDailyExercise = New AddDailyExercise()
        exerciseform.Show()
        exerciseform.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If e.Node.Text = "Dashboard" Then
            'Dashboard
            Me.Show()
            SetUserDailyGaolValues()
            Me.TopMost = True
        ElseIf e.Node.Text = "Set Your Goal" Then
            'Define Your Goal
            Dim dfgoal As DefineYourGoal = New DefineYourGoal()
            dfgoal.Show()
            dfgoal.TopMost = True
            Me.TopMost = False
        ElseIf e.Node.Text = "Add Food" Then
            'Create New Food
            Dim foodform As AddFood = New AddFood()
            foodform.Show()
            foodform.TopMost = True
            Me.TopMost = False
        ElseIf e.Node.Text = "Food List" Then
            'View The List Of Food
            Dim foodlist As FoodList = New FoodList()
            foodlist.Show()
            foodlist.TopMost = True
            Me.TopMost = False
        ElseIf e.Node.Text = "Create New Exercise" Then
            'Create New Exercise
            Dim exerciseform As CreateNewExercise = New CreateNewExercise()
            exerciseform.Show()
            exerciseform.TopMost = True
            Me.TopMost = False
        ElseIf e.Node.Text = "Exercise List" Then
            'Create New Exercise
            Dim ExerciseList As ExerciseList = New ExerciseList()
            ExerciseList.Show()
            ExerciseList.TopMost = True
            Me.TopMost = False
        ElseIf e.Node.Text = "Standard Unit" Then
            'Create New Exercise
            Dim StandardUnits As StandardUnits = New StandardUnits()
            StandardUnits.Show()
            StandardUnits.TopMost = True
            Me.TopMost = False
        End If


    End Sub

    Private Sub lnkbtnSetgoal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkbtnSetgoal.LinkClicked
        'Create New Exercise
        Dim SYDGoal As SetYourDailyGoal = New SetYourDailyGoal()
        SYDGoal.Show()
        SYDGoal.TopMost = True
        Me.TopMost = False
    End Sub

    Public Sub SetUserDailyGaolValues()
        'Get User Daily Calories Goal Data
        lblFoodCount.Text = WBDAL.GetUserDailyFoodCalories(M_UId, DateTime.Now).ToString()
        lblExerCount.Text = WBDAL.GetUserDailyExerciseCalories(M_UId, DateTime.Now).ToString()

        Dim dtResult As DataTable = WBDAL.GetUserDailyCaloriesGoal(M_UId)
        UDGC_UId = M_UId
        If dtResult.Rows.Count > 0 Then
            UDGC_Id = Convert.ToInt32(dtResult.Rows(0)("Id"))
            UDGC_GoalType = dtResult.Rows(0)("GoalType")
            UDGC_NumberOfCalories = dtResult.Rows(0)("NumberOfCalories")
        End If
        lblRemainingCalories.Text = UDGC_NumberOfCalories
        lblgoalCount.Text = UDGC_NumberOfCalories

        lblNetCount.Text = Convert.ToDouble(lblFoodCount.Text) - Convert.ToDouble(lblExerCount.Text)
        lblRemainingCalories.Text = Convert.ToDouble(lblRemainingCalories.Text) - Convert.ToDouble(lblNetCount.Text)
    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click
        If Me.TabIndex = 0 Then
            'Dashboard
            Me.Show()
            SetUserDailyGaolValues()
            Me.TopMost = True
        End If
    End Sub
End Class