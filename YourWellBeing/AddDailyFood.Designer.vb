<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDailyFood
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
        Me.DDLFoodType = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YourWellBeingDataSet2 = New YourWellBeing.YourWellBeingDataSet2()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchFood = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFDF = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FoodTableAdapter = New YourWellBeing.YourWellBeingDataSet2TableAdapters.FoodTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourWellBeingDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DDLFoodType)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearchFood)
        Me.Panel1.Controls.Add(Me.DateTimePickerFDF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 400)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(515, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hint: Select Diet Type From Dropdown and Double click on Food to add you diet"
        '
        'DDLFoodType
        '
        Me.DDLFoodType.FormattingEnabled = True
        Me.DDLFoodType.Items.AddRange(New Object() {"Breakfast", "Lunch", "Dinner", "Snacks"})
        Me.DDLFoodType.Location = New System.Drawing.Point(347, 47)
        Me.DDLFoodType.Name = "DDLFoodType"
        Me.DDLFoodType.Size = New System.Drawing.Size(121, 21)
        Me.DDLFoodType.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.CaloriesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 296)
        Me.DataGridView1.TabIndex = 9
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        '
        'FoodBindingSource
        '
        Me.FoodBindingSource.DataMember = "Food"
        Me.FoodBindingSource.DataSource = Me.YourWellBeingDataSet2
        '
        'YourWellBeingDataSet2
        '
        Me.YourWellBeingDataSet2.DataSetName = "YourWellBeingDataSet2"
        Me.YourWellBeingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(180, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchFood
        '
        Me.txtSearchFood.Location = New System.Drawing.Point(32, 48)
        Me.txtSearchFood.Name = "txtSearchFood"
        Me.txtSearchFood.Size = New System.Drawing.Size(142, 20)
        Me.txtSearchFood.TabIndex = 7
        '
        'DateTimePickerFDF
        '
        Me.DateTimePickerFDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerFDF.Location = New System.Drawing.Point(282, 11)
        Me.DateTimePickerFDF.Name = "DateTimePickerFDF"
        Me.DateTimePickerFDF.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFDF.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(28, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(475, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Your Food Diary : "
        '
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'AddDailyFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddDailyFood"
        Me.Text = "AddDailyFood"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourWellBeingDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerFDF As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchFood As TextBox
    Friend WithEvents YourWellBeingDataSet2 As YourWellBeingDataSet2
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodTableAdapter As YourWellBeingDataSet2TableAdapters.FoodTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DDLFoodType As ComboBox
    Friend WithEvents Label3 As Label
End Class
