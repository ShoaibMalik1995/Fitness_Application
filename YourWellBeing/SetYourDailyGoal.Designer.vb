<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetYourDailyGoal
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveGoal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCaloriesCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdailyCalories = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DDLCType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Set You Daily Calories Goal"
        '
        'btnSaveGoal
        '
        Me.btnSaveGoal.BackColor = System.Drawing.Color.Green
        Me.btnSaveGoal.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGoal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveGoal.Location = New System.Drawing.Point(13, 214)
        Me.btnSaveGoal.Name = "btnSaveGoal"
        Me.btnSaveGoal.Size = New System.Drawing.Size(257, 35)
        Me.btnSaveGoal.TabIndex = 37
        Me.btnSaveGoal.Text = "Save"
        Me.btnSaveGoal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Calories : "
        '
        'lblCaloriesCount
        '
        Me.lblCaloriesCount.AutoSize = True
        Me.lblCaloriesCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCaloriesCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaloriesCount.ForeColor = System.Drawing.Color.Lime
        Me.lblCaloriesCount.Location = New System.Drawing.Point(86, 51)
        Me.lblCaloriesCount.Name = "lblCaloriesCount"
        Me.lblCaloriesCount.Size = New System.Drawing.Size(26, 28)
        Me.lblCaloriesCount.TabIndex = 39
        Me.lblCaloriesCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number Calories"
        '
        'txtdailyCalories
        '
        Me.txtdailyCalories.Location = New System.Drawing.Point(15, 176)
        Me.txtdailyCalories.Name = "txtdailyCalories"
        Me.txtdailyCalories.Size = New System.Drawing.Size(174, 20)
        Me.txtdailyCalories.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calories"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Number Calories"
        '
        'DDLCType
        '
        Me.DDLCType.FormattingEnabled = True
        Me.DDLCType.Items.AddRange(New Object() {"Gain Calories", "Lose Calories"})
        Me.DDLCType.Location = New System.Drawing.Point(15, 123)
        Me.DDLCType.Name = "DDLCType"
        Me.DDLCType.Size = New System.Drawing.Size(170, 21)
        Me.DDLCType.TabIndex = 41
        '
        'SetYourDailyGoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.DDLCType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCaloriesCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSaveGoal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdailyCalories)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SetYourDailyGoal"
        Me.Text = "SetYourDailyGoal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveGoal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCaloriesCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdailyCalories As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DDLCType As ComboBox
End Class
