<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDailyExercise
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DDLExerciseType = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchExercise = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDED = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.YourWellBeingDataSet3 = New YourWellBeing.YourWellBeingDataSet3()
        Me.ExercisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExercisesTableAdapter = New YourWellBeing.YourWellBeingDataSet3TableAdapters.ExercisesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExerciseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesBurnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YourWellBeingDataSet4 = New YourWellBeing.YourWellBeingDataSet4()
        Me.ExercisesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExercisesTableAdapter1 = New YourWellBeing.YourWellBeingDataSet4TableAdapters.ExercisesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourWellBeingDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExercisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourWellBeingDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExercisesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DDLExerciseType)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearchExercise)
        Me.Panel1.Controls.Add(Me.DateTimePickerDED)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 407)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(570, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Hint: Select Exercise Type From Dropdown and Double click on Exercise to add you " &
    "diet"
        '
        'DDLExerciseType
        '
        Me.DDLExerciseType.FormattingEnabled = True
        Me.DDLExerciseType.Items.AddRange(New Object() {"All", "Cardiovascular", "Strength Training"})
        Me.DDLExerciseType.Location = New System.Drawing.Point(336, 48)
        Me.DDLExerciseType.Name = "DDLExerciseType"
        Me.DDLExerciseType.Size = New System.Drawing.Size(121, 21)
        Me.DDLExerciseType.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(169, 45)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchExercise
        '
        Me.txtSearchExercise.Location = New System.Drawing.Point(21, 49)
        Me.txtSearchExercise.Name = "txtSearchExercise"
        Me.txtSearchExercise.Size = New System.Drawing.Size(142, 20)
        Me.txtSearchExercise.TabIndex = 15
        '
        'DateTimePickerDED
        '
        Me.DateTimePickerDED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerDED.Location = New System.Drawing.Point(284, 12)
        Me.DateTimePickerDED.Name = "DateTimePickerDED"
        Me.DateTimePickerDED.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDED.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(475, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Your Daily Exercise Diary : "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ExerciseNameDataGridViewTextBoxColumn, Me.CaloriesBurnedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExercisesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 294)
        Me.DataGridView1.TabIndex = 19
        '
        'YourWellBeingDataSet3
        '
        Me.YourWellBeingDataSet3.DataSetName = "YourWellBeingDataSet3"
        Me.YourWellBeingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExercisesBindingSource
        '
        Me.ExercisesBindingSource.DataMember = "Exercises"
        Me.ExercisesBindingSource.DataSource = Me.YourWellBeingDataSet3
        '
        'ExercisesTableAdapter
        '
        Me.ExercisesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExerciseNameDataGridViewTextBoxColumn
        '
        Me.ExerciseNameDataGridViewTextBoxColumn.DataPropertyName = "ExerciseName"
        Me.ExerciseNameDataGridViewTextBoxColumn.HeaderText = "ExerciseName"
        Me.ExerciseNameDataGridViewTextBoxColumn.Name = "ExerciseNameDataGridViewTextBoxColumn"
        '
        'CaloriesBurnedDataGridViewTextBoxColumn
        '
        Me.CaloriesBurnedDataGridViewTextBoxColumn.DataPropertyName = "CaloriesBurned"
        Me.CaloriesBurnedDataGridViewTextBoxColumn.HeaderText = "CaloriesBurned"
        Me.CaloriesBurnedDataGridViewTextBoxColumn.Name = "CaloriesBurnedDataGridViewTextBoxColumn"
        '
        'YourWellBeingDataSet4
        '
        Me.YourWellBeingDataSet4.DataSetName = "YourWellBeingDataSet4"
        Me.YourWellBeingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExercisesBindingSource1
        '
        Me.ExercisesBindingSource1.DataMember = "Exercises"
        Me.ExercisesBindingSource1.DataSource = Me.YourWellBeingDataSet4
        '
        'ExercisesTableAdapter1
        '
        Me.ExercisesTableAdapter1.ClearBeforeFill = True
        '
        'AddDailyExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddDailyExercise"
        Me.Text = "AddDailyExercise"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourWellBeingDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExercisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourWellBeingDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExercisesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DDLExerciseType As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchExercise As TextBox
    Friend WithEvents DateTimePickerDED As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents YourWellBeingDataSet3 As YourWellBeingDataSet3
    Friend WithEvents ExercisesBindingSource As BindingSource
    Friend WithEvents ExercisesTableAdapter As YourWellBeingDataSet3TableAdapters.ExercisesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExerciseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesBurnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YourWellBeingDataSet4 As YourWellBeingDataSet4
    Friend WithEvents ExercisesBindingSource1 As BindingSource
    Friend WithEvents ExercisesTableAdapter1 As YourWellBeingDataSet4TableAdapters.ExercisesTableAdapter
End Class
