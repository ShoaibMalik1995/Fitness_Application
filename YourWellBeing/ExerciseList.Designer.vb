<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExerciseList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExerciseList))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DDLExerciseType = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.YourWellBeingDataSet1 = New YourWellBeing.YourWellBeingDataSet1()
        Me.ExercisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExercisesTableAdapter = New YourWellBeing.YourWellBeingDataSet1TableAdapters.ExercisesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExerciseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExerciseTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HowlongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesBurnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepetitionsSetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightSetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourWellBeingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExercisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Green
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(200, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 39)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(165, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "(Search By Exercise Type)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(721, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Exercises List"
        '
        'DDLExerciseType
        '
        Me.DDLExerciseType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DDLExerciseType.FormattingEnabled = True
        Me.DDLExerciseType.Items.AddRange(New Object() {"All", "Cardiovascular", "Strength Training"})
        Me.DDLExerciseType.Location = New System.Drawing.Point(21, 55)
        Me.DDLExerciseType.Name = "DDLExerciseType"
        Me.DDLExerciseType.Size = New System.Drawing.Size(173, 21)
        Me.DDLExerciseType.TabIndex = 50
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ExerciseNameDataGridViewTextBoxColumn, Me.ExerciseTypeDataGridViewTextBoxColumn, Me.HowlongDataGridViewTextBoxColumn, Me.CaloriesBurnedDataGridViewTextBoxColumn, Me.SetsDataGridViewTextBoxColumn, Me.RepetitionsSetDataGridViewTextBoxColumn, Me.WeightSetDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExercisesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(734, 200)
        Me.DataGridView1.TabIndex = 51
        '
        'YourWellBeingDataSet1
        '
        Me.YourWellBeingDataSet1.DataSetName = "YourWellBeingDataSet1"
        Me.YourWellBeingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExercisesBindingSource
        '
        Me.ExercisesBindingSource.DataMember = "Exercises"
        Me.ExercisesBindingSource.DataSource = Me.YourWellBeingDataSet1
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
        'ExerciseTypeDataGridViewTextBoxColumn
        '
        Me.ExerciseTypeDataGridViewTextBoxColumn.DataPropertyName = "ExerciseType"
        Me.ExerciseTypeDataGridViewTextBoxColumn.HeaderText = "ExerciseType"
        Me.ExerciseTypeDataGridViewTextBoxColumn.Name = "ExerciseTypeDataGridViewTextBoxColumn"
        '
        'HowlongDataGridViewTextBoxColumn
        '
        Me.HowlongDataGridViewTextBoxColumn.DataPropertyName = "Howlong"
        Me.HowlongDataGridViewTextBoxColumn.HeaderText = "Howlong"
        Me.HowlongDataGridViewTextBoxColumn.Name = "HowlongDataGridViewTextBoxColumn"
        '
        'CaloriesBurnedDataGridViewTextBoxColumn
        '
        Me.CaloriesBurnedDataGridViewTextBoxColumn.DataPropertyName = "CaloriesBurned"
        Me.CaloriesBurnedDataGridViewTextBoxColumn.HeaderText = "CaloriesBurned"
        Me.CaloriesBurnedDataGridViewTextBoxColumn.Name = "CaloriesBurnedDataGridViewTextBoxColumn"
        '
        'SetsDataGridViewTextBoxColumn
        '
        Me.SetsDataGridViewTextBoxColumn.DataPropertyName = "Sets"
        Me.SetsDataGridViewTextBoxColumn.HeaderText = "Sets"
        Me.SetsDataGridViewTextBoxColumn.Name = "SetsDataGridViewTextBoxColumn"
        '
        'RepetitionsSetDataGridViewTextBoxColumn
        '
        Me.RepetitionsSetDataGridViewTextBoxColumn.DataPropertyName = "Repetitions_Set"
        Me.RepetitionsSetDataGridViewTextBoxColumn.HeaderText = "Repetitions_Set"
        Me.RepetitionsSetDataGridViewTextBoxColumn.Name = "RepetitionsSetDataGridViewTextBoxColumn"
        '
        'WeightSetDataGridViewTextBoxColumn
        '
        Me.WeightSetDataGridViewTextBoxColumn.DataPropertyName = "WeightSet"
        Me.WeightSetDataGridViewTextBoxColumn.HeaderText = "WeightSet"
        Me.WeightSetDataGridViewTextBoxColumn.Name = "WeightSetDataGridViewTextBoxColumn"
        '
        'ExerciseList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 307)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DDLExerciseType)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ExerciseList"
        Me.Text = "ExerciseList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourWellBeingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExercisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DDLExerciseType As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents YourWellBeingDataSet1 As YourWellBeingDataSet1
    Friend WithEvents ExercisesBindingSource As BindingSource
    Friend WithEvents ExercisesTableAdapter As YourWellBeingDataSet1TableAdapters.ExercisesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExerciseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExerciseTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HowlongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesBurnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SetsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepetitionsSetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightSetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
