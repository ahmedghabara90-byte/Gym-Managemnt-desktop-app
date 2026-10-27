<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        ACTIVITE = New DataGridViewTextBoxColumn()
        TYPE = New DataGridViewTextBoxColumn()
        AGE = New DataGridViewTextBoxColumn()
        GENDRE = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Button1 = New Button()
        Button16 = New Button()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = SystemColors.ActiveCaption
        RadioButton1.Font = New Font("Garamond", 24F, FontStyle.Bold)
        RadioButton1.Location = New Point(91, 672)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(155, 49)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Cardio"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = SystemColors.ActiveCaption
        RadioButton2.Font = New Font("Garamond", 24F, FontStyle.Bold)
        RadioButton2.Location = New Point(246, 672)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(480, 49)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Renforcement musculaire"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = SystemColors.ActiveCaption
        RadioButton3.Font = New Font("Garamond", 24F, FontStyle.Bold)
        RadioButton3.Location = New Point(726, 672)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(286, 49)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Cours collectif"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(91, 570)
        Label4.Name = "Label4"
        Label4.Size = New Size(344, 45)
        Label4.TabIndex = 35
        Label4.Text = "Gendre recomendé"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 461)
        Label3.Name = "Label3"
        Label3.Size = New Size(286, 45)
        Label3.TabIndex = 34
        Label3.Text = "Age recomendé"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(91, 366)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 45)
        Label2.TabIndex = 33
        Label2.Text = "Activité"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox1.Location = New Point(468, 352)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(377, 52)
        TextBox1.TabIndex = 30
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.Items.AddRange(New Object() {"Homme", "Femme", "N'importe"})
        ComboBox1.Location = New Point(468, 562)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(377, 53)
        ComboBox1.TabIndex = 36
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ACTIVITE, TYPE, AGE, GENDRE})
        DataGridView1.Location = New Point(1267, 352)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(555, 468)
        DataGridView1.TabIndex = 38
        ' 
        ' ACTIVITE
        ' 
        ACTIVITE.HeaderText = "Activité"
        ACTIVITE.MinimumWidth = 6
        ACTIVITE.Name = "ACTIVITE"
        ACTIVITE.Width = 125
        ' 
        ' TYPE
        ' 
        TYPE.HeaderText = "Type"
        TYPE.MinimumWidth = 6
        TYPE.Name = "TYPE"
        TYPE.Width = 125
        ' 
        ' AGE
        ' 
        AGE.HeaderText = "Agr recomendé"
        AGE.MinimumWidth = 6
        AGE.Name = "AGE"
        AGE.Width = 125
        ' 
        ' GENDRE
        ' 
        GENDRE.HeaderText = "Gendre recomendé"
        GENDRE.MinimumWidth = 6
        GENDRE.Name = "GENDRE"
        GENDRE.Width = 125
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(35, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 50)
        Button2.TabIndex = 39
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(91, 830)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 40
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1805, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(107, 45)
        Button16.TabIndex = 42
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(588, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(794, 68)
        Label1.TabIndex = 43
        Label1.Text = "Gestion des activités sportives"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox3.Location = New Point(468, 454)
        TextBox3.MaxLength = 2
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(152, 52)
        TextBox3.TabIndex = 45
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox4.Location = New Point(693, 454)
        TextBox4.MaxLength = 2
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(152, 52)
        TextBox4.TabIndex = 46
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(642, 461)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 45)
        Label5.TabIndex = 47
        Label5.Text = "-"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pratiques_sportives_scaled
        ClientSize = New Size(1924, 977)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(Button16)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Name = "Form6"
        Text = "Form6"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ACTIVITE As DataGridViewTextBoxColumn
    Friend WithEvents TYPE As DataGridViewTextBoxColumn
    Friend WithEvents AGE As DataGridViewTextBoxColumn
    Friend WithEvents GENDRE As DataGridViewTextBoxColumn
End Class
