<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dashboard")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Your Goal")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Food")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Food List")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Food", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create New Exercise")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exercise List")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exercise", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Standard Unit")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings", New System.Windows.Forms.TreeNode() {TreeNode9})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.logoBox = New System.Windows.Forms.PictureBox()
        Me.lbllogoText = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TopHeaderPanel = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainContentPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lnkbtnSetgoal = New System.Windows.Forms.LinkLabel()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblNetCount = New System.Windows.Forms.Label()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblExercise = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.lblExerCount = New System.Windows.Forms.Label()
        Me.lblFoodCount = New System.Windows.Forms.Label()
        Me.lblgoalCount = New System.Windows.Forms.Label()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.btnAddExercise = New System.Windows.Forms.Button()
        Me.lblRemainingCalories = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DailyProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeftPanel.SuspendLayout()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopHeaderPanel.SuspendLayout()
        Me.MainContentPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.SystemColors.WindowText
        Me.LeftPanel.Controls.Add(Me.TreeView1)
        Me.LeftPanel.Controls.Add(Me.logoBox)
        Me.LeftPanel.Controls.Add(Me.lbllogoText)
        Me.LeftPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(153, 450)
        Me.LeftPanel.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.Black
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(7, 103)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "DashBoad"
        TreeNode1.Text = "Dashboard"
        TreeNode1.ToolTipText = "Dashboard"
        TreeNode2.Name = "SetYourGoal"
        TreeNode2.Text = "Set Your Goal"
        TreeNode3.Name = "AddFood"
        TreeNode3.Text = "Add Food"
        TreeNode4.Name = "FoodList"
        TreeNode4.Text = "Food List"
        TreeNode5.Name = "Food"
        TreeNode5.Text = "Food"
        TreeNode6.Name = "AddExercise"
        TreeNode6.Text = "Create New Exercise"
        TreeNode7.Name = "ExerciseList"
        TreeNode7.Text = "Exercise List"
        TreeNode8.Name = "Exercise"
        TreeNode8.Text = "Exercise"
        TreeNode9.Name = "StandardUnits"
        TreeNode9.Text = "Standard Unit"
        TreeNode10.Name = "Settings"
        TreeNode10.Text = "Settings"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode5, TreeNode8, TreeNode10})
        Me.TreeView1.Size = New System.Drawing.Size(135, 347)
        Me.TreeView1.TabIndex = 5
        '
        'logoBox
        '
        Me.logoBox.Image = CType(resources.GetObject("logoBox.Image"), System.Drawing.Image)
        Me.logoBox.Location = New System.Drawing.Point(7, 47)
        Me.logoBox.Name = "logoBox"
        Me.logoBox.Size = New System.Drawing.Size(140, 50)
        Me.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoBox.TabIndex = 1
        Me.logoBox.TabStop = False
        '
        'lbllogoText
        '
        Me.lbllogoText.AutoSize = True
        Me.lbllogoText.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogoText.ForeColor = System.Drawing.Color.Transparent
        Me.lbllogoText.Location = New System.Drawing.Point(40, 10)
        Me.lbllogoText.Name = "lbllogoText"
        Me.lbllogoText.Size = New System.Drawing.Size(79, 37)
        Me.lbllogoText.TabIndex = 0
        Me.lbllogoText.Text = "YWB"
        '
        'TopHeaderPanel
        '
        Me.TopHeaderPanel.BackColor = System.Drawing.Color.White
        Me.TopHeaderPanel.Controls.Add(Me.btnclose)
        Me.TopHeaderPanel.Controls.Add(Me.Label1)
        Me.TopHeaderPanel.Location = New System.Drawing.Point(153, 0)
        Me.TopHeaderPanel.Name = "TopHeaderPanel"
        Me.TopHeaderPanel.Size = New System.Drawing.Size(711, 75)
        Me.TopHeaderPanel.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnclose.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclose.Location = New System.Drawing.Point(671, 7)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(31, 27)
        Me.btnclose.TabIndex = 1
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'MainContentPanel
        '
        Me.MainContentPanel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MainContentPanel.Controls.Add(Me.Panel2)
        Me.MainContentPanel.Controls.Add(Me.Panel1)
        Me.MainContentPanel.Location = New System.Drawing.Point(159, 81)
        Me.MainContentPanel.Name = "MainContentPanel"
        Me.MainContentPanel.Size = New System.Drawing.Size(696, 465)
        Me.MainContentPanel.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.lnkbtnSetgoal)
        Me.Panel2.Controls.Add(Me.lblNet)
        Me.Panel2.Controls.Add(Me.lblNetCount)
        Me.Panel2.Controls.Add(Me.lblEqual)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblExercise)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblGoal)
        Me.Panel2.Controls.Add(Me.lblExerCount)
        Me.Panel2.Controls.Add(Me.lblFoodCount)
        Me.Panel2.Controls.Add(Me.lblgoalCount)
        Me.Panel2.Controls.Add(Me.btnAddFood)
        Me.Panel2.Controls.Add(Me.btnAddExercise)
        Me.Panel2.Controls.Add(Me.lblRemainingCalories)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.DailyProgressBar1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(13, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 229)
        Me.Panel2.TabIndex = 1
        '
        'lnkbtnSetgoal
        '
        Me.lnkbtnSetgoal.ActiveLinkColor = System.Drawing.Color.Green
        Me.lnkbtnSetgoal.AutoSize = True
        Me.lnkbtnSetgoal.Location = New System.Drawing.Point(169, 14)
        Me.lnkbtnSetgoal.Name = "lnkbtnSetgoal"
        Me.lnkbtnSetgoal.Size = New System.Drawing.Size(73, 13)
        Me.lnkbtnSetgoal.TabIndex = 18
        Me.lnkbtnSetgoal.TabStop = True
        Me.lnkbtnSetgoal.Text = "Set Your Goal"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(414, 151)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(32, 13)
        Me.lblNet.TabIndex = 17
        Me.lblNet.Text = "NET"
        '
        'lblNetCount
        '
        Me.lblNetCount.AutoSize = True
        Me.lblNetCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNetCount.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetCount.ForeColor = System.Drawing.Color.Black
        Me.lblNetCount.Location = New System.Drawing.Point(415, 119)
        Me.lblNetCount.Name = "lblNetCount"
        Me.lblNetCount.Size = New System.Drawing.Size(24, 29)
        Me.lblNetCount.TabIndex = 16
        Me.lblNetCount.Text = "0"
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqual.Location = New System.Drawing.Point(355, 124)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(25, 25)
        Me.lblEqual.TabIndex = 15
        Me.lblEqual.Text = "="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(224, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 25)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "-"
        '
        'lblExercise
        '
        Me.lblExercise.AutoSize = True
        Me.lblExercise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExercise.Location = New System.Drawing.Point(274, 151)
        Me.lblExercise.Name = "lblExercise"
        Me.lblExercise.Size = New System.Drawing.Size(68, 13)
        Me.lblExercise.TabIndex = 13
        Me.lblExercise.Text = "EXERCISE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(156, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "FOOD"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.Location = New System.Drawing.Point(47, 151)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(40, 13)
        Me.lblGoal.TabIndex = 11
        Me.lblGoal.Text = "GOAL"
        '
        'lblExerCount
        '
        Me.lblExerCount.AutoSize = True
        Me.lblExerCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblExerCount.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExerCount.ForeColor = System.Drawing.Color.Black
        Me.lblExerCount.Location = New System.Drawing.Point(272, 119)
        Me.lblExerCount.Name = "lblExerCount"
        Me.lblExerCount.Size = New System.Drawing.Size(24, 29)
        Me.lblExerCount.TabIndex = 10
        Me.lblExerCount.Text = "0"
        '
        'lblFoodCount
        '
        Me.lblFoodCount.AutoSize = True
        Me.lblFoodCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFoodCount.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodCount.ForeColor = System.Drawing.Color.Black
        Me.lblFoodCount.Location = New System.Drawing.Point(154, 119)
        Me.lblFoodCount.Name = "lblFoodCount"
        Me.lblFoodCount.Size = New System.Drawing.Size(24, 29)
        Me.lblFoodCount.TabIndex = 9
        Me.lblFoodCount.Text = "0"
        '
        'lblgoalCount
        '
        Me.lblgoalCount.AutoSize = True
        Me.lblgoalCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblgoalCount.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgoalCount.ForeColor = System.Drawing.Color.Black
        Me.lblgoalCount.Location = New System.Drawing.Point(48, 119)
        Me.lblgoalCount.Name = "lblgoalCount"
        Me.lblgoalCount.Size = New System.Drawing.Size(24, 29)
        Me.lblgoalCount.TabIndex = 8
        Me.lblgoalCount.Text = "0"
        '
        'btnAddFood
        '
        Me.btnAddFood.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFood.Location = New System.Drawing.Point(490, 43)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(140, 38)
        Me.btnAddFood.TabIndex = 7
        Me.btnAddFood.Text = "Add Food"
        Me.btnAddFood.UseVisualStyleBackColor = True
        '
        'btnAddExercise
        '
        Me.btnAddExercise.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddExercise.Location = New System.Drawing.Point(324, 43)
        Me.btnAddExercise.Name = "btnAddExercise"
        Me.btnAddExercise.Size = New System.Drawing.Size(140, 38)
        Me.btnAddExercise.TabIndex = 6
        Me.btnAddExercise.Text = "Add Exercise"
        Me.btnAddExercise.UseVisualStyleBackColor = True
        '
        'lblRemainingCalories
        '
        Me.lblRemainingCalories.AutoSize = True
        Me.lblRemainingCalories.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRemainingCalories.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingCalories.ForeColor = System.Drawing.Color.Lime
        Me.lblRemainingCalories.Location = New System.Drawing.Point(47, 34)
        Me.lblRemainingCalories.Name = "lblRemainingCalories"
        Me.lblRemainingCalories.Size = New System.Drawing.Size(53, 55)
        Me.lblRemainingCalories.TabIndex = 5
        Me.lblRemainingCalories.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(589, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "---------------------------------"
        '
        'DailyProgressBar1
        '
        Me.DailyProgressBar1.Location = New System.Drawing.Point(44, 180)
        Me.DailyProgressBar1.Name = "DailyProgressBar1"
        Me.DailyProgressBar1.Size = New System.Drawing.Size(586, 11)
        Me.DailyProgressBar1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(42, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Calories Remaining"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(638, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Streak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(638, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DAY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(617, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your Daily Summary"
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 450)
        Me.Controls.Add(Me.MainContentPanel)
        Me.Controls.Add(Me.TopHeaderPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainDashboard"
        Me.Text = "MainDashboard"
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopHeaderPanel.ResumeLayout(False)
        Me.TopHeaderPanel.PerformLayout()
        Me.MainContentPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TopHeaderPanel As Panel
    Friend WithEvents MainContentPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbllogoText As Label
    Friend WithEvents logoBox As PictureBox
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DailyProgressBar1 As ProgressBar
    Friend WithEvents lblRemainingCalories As Label
    Friend WithEvents btnAddExercise As Button
    Friend WithEvents btnAddFood As Button
    Friend WithEvents lblExerCount As Label
    Friend WithEvents lblFoodCount As Label
    Friend WithEvents lblgoalCount As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblExercise As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblGoal As Label
    Friend WithEvents lblEqual As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblNetCount As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents lnkbtnSetgoal As LinkLabel
End Class
