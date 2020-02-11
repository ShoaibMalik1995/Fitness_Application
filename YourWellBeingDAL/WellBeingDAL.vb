Imports System.Data.SqlClient
Imports System.Text
Imports YourWellBeingEntities

Public Class WellBeingDAL
    Dim connection As New SqlConnection("Data Source=HASSNII2\SQL2014;Initial Catalog=YourWellBeing;Integrated Security=True")

    Public Function RegisterUser(ByVal fname As String, ByVal lname As String, ByVal username As String, ByVal email As String, ByVal password As String) As Boolean
        Dim IsInsert As Boolean = False

        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Users]([FirstName],[LastName],[UserName],[Email],[Password]) VALUES (@FirstName,@LastName,@UserName,@Email,@Password)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = fname.Trim
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lname.Trim
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username.Trim
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.Trim
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password.Trim
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If

        Catch ex As Exception
            Dim exp As String = ex.Message
            connection.Close()
        End Try

        Return IsInsert
    End Function

    Public Function UserLogin(ByVal username As String, ByVal password As String, ByRef UserInfo As User) As Boolean
        Dim isValid As Boolean = False
        Dim dt As DataTable = New DataTable()
        'Dim UserInfo As User = New User()
        Try
            Dim cmd As New SqlCommand("SELECT Top 1 * FROM Users WHERE (UserName = @UserName OR Email = @UserName) AND Password = @Password", connection)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username.Trim
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            connection.Close()
            If dt.Rows.Count > 0 Then
                isValid = True
                UserInfo.Id = Convert.ToInt32(dt.Rows(0)("Id"))
                UserInfo.FirstName = dt.Rows(0)("FirstName")
                UserInfo.LastName = dt.Rows(0)("LastName")
                UserInfo.UserName = dt.Rows(0)("UserName")
                UserInfo.Email = dt.Rows(0)("Email")
                UserInfo.Password = dt.Rows(0)("Password")
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            connection.Close()
        End Try

        Return isValid
    End Function

    Public Function CreateProfile(ByVal id As Int32, ByVal CWeight As Int32, ByVal height As Int32,
                                  ByVal gWeight As Int32, ByVal gender As String, ByVal DOB As DateTime,
                                  ByVal country As String, ByVal Zip As String, ByVal username As String,
                                  ByVal DailyActivity As String, ByVal wday As Int32, ByVal wMins As Int32,
                                  ByVal goalDesc As String) As Boolean
        Dim isCreated As Boolean = False
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[UserGoalProfile] ([UId] ,[CurrentWeight] ,[Height] ,[GoalWeight] ,[Gender] ,[DOB] ,[Country],[Zip],[UserName],[DailyActivity],[NoOfWorkoutDays],[WorkoutMins],[GoalDescription]) VALUES (@UId, @CurrentWeight, @Height, @GoalWeight, @Gender, @DOB, @Country, @Zip, @UserName, @DailyActivity,@NoOfWorkoutDays, @WorkoutMins, @GoalDescription)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@UId", SqlDbType.Int).Value = id
            cmd.Parameters.Add("@CurrentWeight", SqlDbType.Decimal).Value = CWeight
            cmd.Parameters.Add("@Height", SqlDbType.Decimal).Value = height
            cmd.Parameters.Add("@GoalWeight", SqlDbType.Decimal).Value = gWeight
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender.Trim
            cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = country.Trim
            cmd.Parameters.Add("@Zip", SqlDbType.VarChar).Value = Zip.Trim
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username.Trim
            cmd.Parameters.Add("@DailyActivity", SqlDbType.NVarChar).Value = DailyActivity.Trim
            cmd.Parameters.Add("@NoOfWorkoutDays", SqlDbType.Int).Value = wday
            cmd.Parameters.Add("@WorkoutMins", SqlDbType.Decimal).Value = wMins
            cmd.Parameters.Add("@GoalDescription", SqlDbType.NVarChar).Value = goalDesc.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                isCreated = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            connection.Close()
        End Try

        Return isCreated
    End Function

    Public Function UpdateProfile(ByVal id As Int32, ByVal CWeight As Double, ByVal height As Double,
                                  ByVal gWeight As Double, ByVal gender As String, ByVal DOB As DateTime,
                                  ByVal country As String, ByVal Zip As String, ByVal username As String,
                                  ByVal DailyActivity As String, ByVal wday As Int32, ByVal wMins As Double,
                                  ByVal goalDesc As String) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[UserGoalProfile] SET [CurrentWeight] = @CurrentWeight ,[Height] = @Height,[GoalWeight] = @GoalWeight,[Gender] = @Gender,[DOB] = @DOB,[Country] = @Country, [Zip] = @Zip,[UserName] = @UserName,[DailyActivity] = @DailyActivity,[NoOfWorkoutDays] = @NoOfWorkoutDays,[WorkoutMins] = @WorkoutMins,[GoalDescription] = @GoalDescription WHERE UId = @UId", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@UId", SqlDbType.Int).Value = id
            cmd.Parameters.Add("@CurrentWeight", SqlDbType.Decimal).Value = CWeight
            cmd.Parameters.Add("@Height", SqlDbType.Decimal).Value = height
            cmd.Parameters.Add("@GoalWeight", SqlDbType.Decimal).Value = gWeight
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender.Trim
            cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = country.Trim
            cmd.Parameters.Add("@Zip", SqlDbType.VarChar).Value = Zip.Trim
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username.Trim
            cmd.Parameters.Add("@DailyActivity", SqlDbType.VarChar).Value = DailyActivity.Trim
            cmd.Parameters.Add("@NoOfWorkoutDays", SqlDbType.Int).Value = wday
            cmd.Parameters.Add("@WorkoutMins", SqlDbType.Decimal).Value = wMins
            cmd.Parameters.Add("@GoalDescription", SqlDbType.NVarChar).Value = goalDesc.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                isUpdated = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            connection.Close()
        End Try

        Return isUpdated
    End Function

    Public Function GetUserGoalProfileById(ByVal iId As Int32) As UserGoalProfile
        Dim UserProfile As UserGoalProfile = New UserGoalProfile()
        Dim dt As DataTable = New DataTable()
        Try
            Dim cmd As New SqlCommand("SELECT Top 1 * FROM UserGoalProfile WHERE UId = @iId", connection)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@iId", SqlDbType.Int).Value = iId

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            connection.Close()
            If dt.Rows.Count > 0 Then
                UserProfile.Id = dt.Rows(0)("Id")
                UserProfile.UId = dt.Rows(0)("UId")
                UserProfile.CurrentWeight = dt.Rows(0)("CurrentWeight")
                UserProfile.Height = dt.Rows(0)("Height")
                UserProfile.GoalWeight = dt.Rows(0)("GoalWeight")
                UserProfile.Gender = dt.Rows(0)("Gender")
                UserProfile.DOB = dt.Rows(0)("DOB")
                UserProfile.Country = dt.Rows(0)("Country")
                UserProfile.Zip = dt.Rows(0)("Zip")
                UserProfile.UserName = dt.Rows(0)("UserName")
                UserProfile.DailyActivity = dt.Rows(0)("DailyActivity")
                UserProfile.NoOfWorkoutDays = dt.Rows(0)("NoOfWorkoutDays")
                UserProfile.WorkoutMins = dt.Rows(0)("WorkoutMins")
                UserProfile.GoalDescription = dt.Rows(0)("GoalDescription")

            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            connection.Close()
        End Try

        Return UserProfile
    End Function

    Public Function AddNewFood(ByVal FoodName As String, ByVal Protein As Int32, ByVal Calories As Int32, ByVal Fat As Int32, ByVal Sugar As Int32, ByVal Crabs As Int32, ByVal Sodium As Int32, ByVal Desc As String) As Boolean
        Dim IsInsert As Boolean = False
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Food] ([FoodName],[Calories],[Crabs],[Fat],[Protein],[Sodium],[Sugar],[Description]) VALUES (@FoodName,@Calories,@Crabs,@Fat,@Protein,@Sodium,@Sugar,@Desc)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@FoodName", SqlDbType.VarChar).Value = FoodName
            cmd.Parameters.Add("@Protein", SqlDbType.Int).Value = Protein
            cmd.Parameters.Add("@Calories", SqlDbType.Int).Value = Calories
            cmd.Parameters.Add("@Fat", SqlDbType.Int).Value = Fat
            cmd.Parameters.Add("@Sugar", SqlDbType.Int).Value = Sugar
            cmd.Parameters.Add("@Sodium", SqlDbType.Int).Value = Sodium
            cmd.Parameters.Add("@Crabs", SqlDbType.Int).Value = Crabs
            cmd.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = Desc

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return IsInsert
    End Function

    Public Function SearchFoodByName(ByVal name As String) As DataTable
        Dim dtFoodList As DataTable = New DataTable()

        Try
            Dim cmd As New SqlCommand("SELECT * FROM Food WHERE (FoodName like  @FoodName OR @FoodName = '')", connection)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@FoodName", SqlDbType.VarChar).Value = name.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dtFoodList)

        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try

        Return dtFoodList
    End Function

    Public Function CreateNewExercise(ByVal ExerciseName As String, ByVal ExerciseType As String, ByVal Howlong As Int32, ByVal CaloriesBurned As Int32, ByVal Sets As Int32, ByVal Repetitions_Sets As Int32, ByVal WeightSets As Int32) As Boolean
        Dim IsInsert As Boolean = False
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Exercises] ([ExerciseName],[ExerciseType],[Howlong],[CaloriesBurned],[Sets],[Repetitions_Set],[WeightSet]) VALUES(@ExerciseName,@ExerciseType,@Howlong,@CaloriesBurned,@Sets,@Repetitions_Set,@WeightSet)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@ExerciseName", SqlDbType.VarChar).Value = ExerciseName
            cmd.Parameters.Add("@ExerciseType", SqlDbType.VarChar).Value = ExerciseType
            cmd.Parameters.Add("@Howlong", SqlDbType.Int).Value = Howlong
            cmd.Parameters.Add("@CaloriesBurned", SqlDbType.Int).Value = CaloriesBurned
            cmd.Parameters.Add("@Sets", SqlDbType.Int).Value = Sets
            cmd.Parameters.Add("@Repetitions_Set", SqlDbType.Int).Value = Repetitions_Sets
            cmd.Parameters.Add("@WeightSet", SqlDbType.Int).Value = WeightSets

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return IsInsert
    End Function

    Public Function SearchExerciseByType(ByVal ExerciseType As String) As DataTable
        Dim dtExerciseList As DataTable = New DataTable()

        Try
            Dim cmd As New SqlCommand("SELECT * FROM Exercises WHERE (ExerciseType = @ExerciseType OR @ExerciseType = 'All')", connection)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@ExerciseType", SqlDbType.VarChar).Value = ExerciseType.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dtExerciseList)

        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try

        Return dtExerciseList
    End Function

    Public Function SearchExercise(ByVal name As String, ByVal ExerciseType As String) As DataTable
        Dim dtExerciseList As DataTable = New DataTable()

        Try
            Dim cmd As New SqlCommand("SELECT * FROM Exercises WHERE (ExerciseType = @ExerciseType) AND ExerciseName like ('%" + name + "%')", connection)
            cmd.CommandType = CommandType.Text
            'cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Trim
            cmd.Parameters.Add("@ExerciseType", SqlDbType.VarChar).Value = ExerciseType.Trim

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dtExerciseList)

        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try

        Return dtExerciseList
    End Function

    Public Function GetUserDailyCaloriesGoal(ByVal UId As Int32) As DataTable
        Dim dtGoalCalories As DataTable = New DataTable()

        Try
            Dim cmd As New SqlCommand("Select [Id],[UId],[GoalType],[NumberOfCalories]  FROM [dbo].[DailyCaloriesGoal] WHERE UId = @UId", connection)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@UId", SqlDbType.Int).Value = UId

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dtGoalCalories)

        Catch ex As Exception
            Dim exp As String = ex.Message
        End Try

        Return dtGoalCalories
    End Function

    Public Function CreateUpdateUserDailyGoal(ByVal Id As Int32, ByVal UId As Int32, ByVal GoalType As String, ByVal NumberOFCalories As Int32) As Boolean
        Dim IsInsert As Boolean = False
        Dim cmd As SqlCommand
        Try
            If Id < 1 Then
                cmd = New SqlCommand("INSERT INTO [dbo].[DailyCaloriesGoal] ([UId],[GoalType],[NumberOfCalories]) VALUES (@UId,@GoalType,@NumberOfCalories)", connection)

                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("@UId", SqlDbType.Int).Value = UId
                cmd.Parameters.Add("@GoalType", SqlDbType.VarChar).Value = GoalType
                cmd.Parameters.Add("@NumberOFCalories", SqlDbType.Int).Value = NumberOFCalories
            Else
                cmd = New SqlCommand("UPDATE [dbo].[DailyCaloriesGoal] SET [GoalType] = @GoalType ,[NumberOfCalories] = @NumberOfCalories WHERE Id =@Id AND UId =@UId", connection)

                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@UId", SqlDbType.Int).Value = UId
                cmd.Parameters.Add("@GoalType", SqlDbType.VarChar).Value = GoalType
                cmd.Parameters.Add("@NumberOFCalories", SqlDbType.Int).Value = NumberOFCalories

            End If

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return IsInsert
    End Function

    Public Function AddDailyFoodDetails(ByVal UId As Int32, ByVal FId As Int32, ByVal FoodType As String, ByVal Date_Time As DateTime) As Boolean
        Dim IsInsert As Boolean = False
        Dim cmd As SqlCommand
        Try
            cmd = New SqlCommand("INSERT INTO [dbo].[DailyFoodDetails] ([U_Id],[F_Id],[FoodType],[Date_Time]) VALUES (@U_Id,@F_Id,@FoodType,@Date_Time)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@U_Id", SqlDbType.Int).Value = UId
            cmd.Parameters.Add("@F_Id", SqlDbType.Int).Value = FId
            cmd.Parameters.Add("@FoodType", SqlDbType.VarChar).Value = FoodType
            cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = Date_Time

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return IsInsert
    End Function

    Public Function AddDailyExerciseDetails(ByVal UId As Int32, ByVal EId As Int32, ByVal ExerciseType As String, ByVal Date_Time As DateTime) As Boolean
        Dim IsInsert As Boolean = False
        Dim cmd As SqlCommand
        Try
            cmd = New SqlCommand("INSERT INTO [dbo].[DailyExerciseDetails] ([U_Id],[E_Id],[ExerciseType],[DateTime]) VALUES (@U_Id,@E_Id,@ExerciseType,@Date_Time)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@U_Id", SqlDbType.Int).Value = UId
            cmd.Parameters.Add("@E_Id", SqlDbType.Int).Value = EId
            cmd.Parameters.Add("@ExerciseType", SqlDbType.VarChar).Value = ExerciseType
            cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = Date_Time

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim i As Int32 = cmd.ExecuteNonQuery()
            connection.Close()
            If i > 0 Then
                IsInsert = True
            End If
        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return IsInsert
    End Function

    Public Function GetUserDailyFoodCalories(ByVal UId As Int32, ByVal Date_Time As DateTime) As Double
        Dim dt As DataTable = New DataTable()
        Dim FoodCaloriesCount As Double = 0.00
        Dim cmd As SqlCommand
        Try
            cmd = New SqlCommand("SELECT SUM(F.Calories) FoodCaloriesCount  FROM DailyFoodDetails DFD INNER JOIN Food F ON F.Id = DFD.F_Id WHERE DFD.U_Id = @U_Id AND CAST(DFD.Date_Time AS DATE) = CAST(@Date_Time AS DATE)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@U_Id", SqlDbType.Int).Value = UId
            cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = Date_Time

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            If dt.Rows.Count > 0 Then
                FoodCaloriesCount = dt.Rows(0)("FoodCaloriesCount")
            End If

        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return FoodCaloriesCount
    End Function

    Public Function GetUserDailyExerciseCalories(ByVal UId As Int32, ByVal Date_Time As DateTime) As Double
        Dim dt As DataTable = New DataTable()
        Dim BurnedCaloriesCount As Double = 0.00
        Dim cmd As SqlCommand
        Try
            cmd = New SqlCommand("SELECT SUM(E.CaloriesBurned) BurnedCaloriesCount FROM [dbo].[Exercises] E INNER JOIN DailyExerciseDetails DED ON E.Id = DED.E_Id  WHERE DED.U_Id = @U_Id AND CAST(DED.DateTime AS date) = CAST(@Date_Time AS date)", connection)

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@U_Id", SqlDbType.Int).Value = UId
            cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = Date_Time

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            If dt.Rows.Count > 0 Then
                BurnedCaloriesCount = dt.Rows(0)("BurnedCaloriesCount")
            End If

        Catch ex As Exception
            Dim exp As String = ex.Message
            Return False
        End Try

        Return BurnedCaloriesCount
    End Function


End Class
