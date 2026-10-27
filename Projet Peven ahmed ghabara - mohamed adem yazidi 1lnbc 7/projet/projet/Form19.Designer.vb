<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
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
        Label9 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        ACT = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        TIME = New DataGridViewTextBoxColumn()
        SALLE = New DataGridViewTextBoxColumn()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        DataGridView2 = New DataGridView()
        p1 = New DataGridViewTextBoxColumn()
        p2 = New DataGridViewTextBoxColumn()
        p3 = New DataGridViewTextBoxColumn()
        autre = New DataGridViewTextBoxColumn()
        Button16 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(86, 164)
        Label9.Name = "Label9"
        Label9.Size = New Size(152, 45)
        Label9.TabIndex = 83
        Label9.Text = "Abonné"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.LightGray
        Label6.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(483, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(304, 45)
        Label6.TabIndex = 82
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(151, 362)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 45)
        Label7.TabIndex = 81
        Label7.Text = "Prenom"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.LightGray
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(483, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 45)
        Label3.TabIndex = 80
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(151, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 45)
        Label4.TabIndex = 79
        Label4.Text = "Nom"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(483, 483)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 45)
        Label1.TabIndex = 78
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(151, 483)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 45)
        Label2.TabIndex = 77
        Label2.Text = "CIN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(759, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(684, 68)
        Label5.TabIndex = 76
        Label5.Text = "Consultation des abonnes"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ACT, DAT, TIME, SALLE})
        DataGridView1.Location = New Point(944, 256)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(554, 272)
        DataGridView1.TabIndex = 75
        ' 
        ' ACT
        ' 
        ACT.HeaderText = "Activité"
        ACT.MinimumWidth = 6
        ACT.Name = "ACT"
        ACT.Width = 125
        ' 
        ' DAT
        ' 
        DAT.HeaderText = "Date"
        DAT.MinimumWidth = 6
        DAT.Name = "DAT"
        DAT.Width = 125
        ' 
        ' TIME
        ' 
        TIME.HeaderText = "Heur"
        TIME.MinimumWidth = 6
        TIME.Name = "TIME"
        TIME.Width = 125
        ' 
        ' SALLE
        ' 
        SALLE.HeaderText = "Salle"
        SALLE.MinimumWidth = 6
        SALLE.Name = "SALLE"
        SALLE.Width = 125
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.LightGray
        Label8.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(483, 696)
        Label8.Name = "Label8"
        Label8.Size = New Size(304, 45)
        Label8.TabIndex = 89
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(151, 696)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 45)
        Label10.TabIndex = 88
        Label10.Text = "Tel"
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.LightGray
        Label11.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(483, 590)
        Label11.Name = "Label11"
        Label11.Size = New Size(304, 45)
        Label11.TabIndex = 87
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(151, 590)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 45)
        Label12.TabIndex = 86
        Label12.Text = "Adresse"
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.LightGray
        Label13.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(483, 805)
        Label13.Name = "Label13"
        Label13.Size = New Size(304, 45)
        Label13.TabIndex = 91
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(151, 805)
        Label14.Name = "Label14"
        Label14.Size = New Size(328, 45)
        Label14.TabIndex = 90
        Label14.Text = "Date de naissance"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {p1, p2, p3, autre})
        DataGridView2.Location = New Point(944, 590)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(554, 272)
        DataGridView2.TabIndex = 92
        ' 
        ' p1
        ' 
        p1.HeaderText = "Date de paiment"
        p1.MinimumWidth = 6
        p1.Name = "p1"
        p1.Width = 125
        ' 
        ' p2
        ' 
        p2.HeaderText = "Date de fin "
        p2.MinimumWidth = 6
        p2.Name = "p2"
        p2.Width = 125
        ' 
        ' p3
        ' 
        p3.HeaderText = "Montant"
        p3.MinimumWidth = 6
        p3.Name = "p3"
        p3.Width = 125
        ' 
        ' autre
        ' 
        autre.HeaderText = "Autre"
        autre.MinimumWidth = 6
        autre.Name = "autre"
        autre.Width = 125
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1853, 995)
        Button16.Name = "Button16"
        Button16.Size = New Size(86, 45)
        Button16.TabIndex = 94
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(151, 895)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 93
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1830, 920)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 45)
        Button2.TabIndex = 95
        Button2.Text = "Quit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form19
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._196583481_fitness_man_training_in_gym_with_personal_trainer_coach_making_training_plan_cartoon_vector_imgupscaler_ai_Bet
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button2)
        Controls.Add(Button16)
        Controls.Add(Button1)
        Controls.Add(DataGridView2)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label8)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Name = "Form19"
        Text = "Form19"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ACT As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents SALLE As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents p1 As DataGridViewTextBoxColumn
    Friend WithEvents p2 As DataGridViewTextBoxColumn
    Friend WithEvents p3 As DataGridViewTextBoxColumn
    Friend WithEvents autre As DataGridViewTextBoxColumn
    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
