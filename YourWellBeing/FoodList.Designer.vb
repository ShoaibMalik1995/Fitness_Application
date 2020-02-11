<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodList))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrabsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProteinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SodiumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YourWellBeingDataSet = New YourWellBeing.YourWellBeingDataSet()
        Me.FoodTableAdapter = New YourWellBeing.YourWellBeingDataSetTableAdapters.FoodTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourWellBeingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(721, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Food List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(129, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(Search By Name)"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(21, 53)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(307, 20)
        Me.txtSearch.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Green
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(334, 43)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 39)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.CaloriesDataGridViewTextBoxColumn, Me.CrabsDataGridViewTextBoxColumn, Me.FatDataGridViewTextBoxColumn, Me.ProteinDataGridViewTextBoxColumn, Me.SodiumDataGridViewTextBoxColumn, Me.SugarDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(741, 198)
        Me.DataGridView1.TabIndex = 7
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
        'CrabsDataGridViewTextBoxColumn
        '
        Me.CrabsDataGridViewTextBoxColumn.DataPropertyName = "Crabs"
        Me.CrabsDataGridViewTextBoxColumn.HeaderText = "Crabs"
        Me.CrabsDataGridViewTextBoxColumn.Name = "CrabsDataGridViewTextBoxColumn"
        '
        'FatDataGridViewTextBoxColumn
        '
        Me.FatDataGridViewTextBoxColumn.DataPropertyName = "Fat"
        Me.FatDataGridViewTextBoxColumn.HeaderText = "Fat"
        Me.FatDataGridViewTextBoxColumn.Name = "FatDataGridViewTextBoxColumn"
        '
        'ProteinDataGridViewTextBoxColumn
        '
        Me.ProteinDataGridViewTextBoxColumn.DataPropertyName = "Protein"
        Me.ProteinDataGridViewTextBoxColumn.HeaderText = "Protein"
        Me.ProteinDataGridViewTextBoxColumn.Name = "ProteinDataGridViewTextBoxColumn"
        '
        'SodiumDataGridViewTextBoxColumn
        '
        Me.SodiumDataGridViewTextBoxColumn.DataPropertyName = "Sodium"
        Me.SodiumDataGridViewTextBoxColumn.HeaderText = "Sodium"
        Me.SodiumDataGridViewTextBoxColumn.Name = "SodiumDataGridViewTextBoxColumn"
        '
        'SugarDataGridViewTextBoxColumn
        '
        Me.SugarDataGridViewTextBoxColumn.DataPropertyName = "Sugar"
        Me.SugarDataGridViewTextBoxColumn.HeaderText = "Sugar"
        Me.SugarDataGridViewTextBoxColumn.Name = "SugarDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'FoodBindingSource
        '
        Me.FoodBindingSource.DataMember = "Food"
        Me.FoodBindingSource.DataSource = Me.YourWellBeingDataSet
        '
        'YourWellBeingDataSet
        '
        Me.YourWellBeingDataSet.DataSetName = "YourWellBeingDataSet"
        Me.YourWellBeingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'FoodList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 298)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FoodList"
        Me.Text = "FoodList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourWellBeingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents YourWellBeingDataSet As YourWellBeingDataSet
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodTableAdapter As YourWellBeingDataSetTableAdapters.FoodTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CrabsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProteinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SodiumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
