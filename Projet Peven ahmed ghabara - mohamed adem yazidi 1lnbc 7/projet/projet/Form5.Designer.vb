<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button2 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBoxGender = New ComboBox()
        DateTimePickerDOB = New DateTimePicker()
        TextBoxCIN = New TextBox()
        TextBoxName = New TextBox()
        TextBoxLastName = New TextBox()
        DataGridView1 = New DataGridView()
        PRENOM = New DataGridViewTextBoxColumn()
        NOM = New DataGridViewTextBoxColumn()
        CIN = New DataGridViewTextBoxColumn()
        TEL = New DataGridViewTextBoxColumn()
        DATEDENAISSANCE = New DataGridViewTextBoxColumn()
        GENDRE = New DataGridViewTextBoxColumn()
        SPECIALITE = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        ComboBoxSpeciality = New ComboBox()
        Button16 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        TextBoxPhone = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(35, 39)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 50)
        Button2.TabIndex = 33
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(55, 785)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 45)
        Label7.TabIndex = 32
        Label7.Text = "Specialite"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(57, 703)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 45)
        Label6.TabIndex = 31
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(55, 613)
        Label5.Name = "Label5"
        Label5.Size = New Size(340, 45)
        Label5.TabIndex = 30
        Label5.Text = "Date de Naissance"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 446)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 45)
        Label4.TabIndex = 29
        Label4.Text = "N CIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(55, 365)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 45)
        Label3.TabIndex = 28
        Label3.Text = "Prenom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 45)
        Label2.TabIndex = 27
        Label2.Text = "Nom"
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxGender.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxGender.Items.AddRange(New Object() {"Homme", "Femme"})
        ComboBoxGender.Location = New Point(434, 696)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(377, 53)
        ComboBoxGender.TabIndex = 26
        ' 
        ' DateTimePickerDOB
        ' 
        DateTimePickerDOB.CalendarFont = New Font("Garamond", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePickerDOB.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePickerDOB.Format = DateTimePickerFormat.Short
        DateTimePickerDOB.Location = New Point(434, 613)
        DateTimePickerDOB.Name = "DateTimePickerDOB"
        DateTimePickerDOB.Size = New Size(377, 38)
        DateTimePickerDOB.TabIndex = 25
        ' 
        ' TextBoxCIN
        ' 
        TextBoxCIN.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBoxCIN.Location = New Point(434, 439)
        TextBoxCIN.MaxLength = 8
        TextBoxCIN.Name = "TextBoxCIN"
        TextBoxCIN.Size = New Size(377, 52)
        TextBoxCIN.TabIndex = 24
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBoxName.Location = New Point(434, 358)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(375, 52)
        TextBoxName.TabIndex = 22
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBoxLastName.Location = New Point(432, 278)
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(377, 52)
        TextBoxLastName.TabIndex = 21
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PRENOM, NOM, CIN, TEL, DATEDENAISSANCE, GENDRE, SPECIALITE})
        DataGridView1.Location = New Point(967, 226)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(925, 581)
        DataGridView1.TabIndex = 20
        ' 
        ' PRENOM
        ' 
        PRENOM.HeaderText = "Prenom"
        PRENOM.MinimumWidth = 6
        PRENOM.Name = "PRENOM"
        PRENOM.Width = 125
        ' 
        ' NOM
        ' 
        NOM.HeaderText = "Nom"
        NOM.MinimumWidth = 6
        NOM.Name = "NOM"
        NOM.Width = 125
        ' 
        ' CIN
        ' 
        CIN.HeaderText = "CIN"
        CIN.MaxInputLength = 8
        CIN.MinimumWidth = 6
        CIN.Name = "CIN"
        CIN.Width = 125
        ' 
        ' TEL
        ' 
        TEL.HeaderText = "Tel"
        TEL.MinimumWidth = 6
        TEL.Name = "TEL"
        TEL.Width = 125
        ' 
        ' DATEDENAISSANCE
        ' 
        DATEDENAISSANCE.HeaderText = "Date de Naissance"
        DATEDENAISSANCE.MinimumWidth = 6
        DATEDENAISSANCE.Name = "DATEDENAISSANCE"
        DATEDENAISSANCE.Width = 125
        ' 
        ' GENDRE
        ' 
        GENDRE.HeaderText = "Gendre"
        GENDRE.MinimumWidth = 6
        GENDRE.Name = "GENDRE"
        GENDRE.Width = 125
        ' 
        ' SPECIALITE
        ' 
        SPECIALITE.HeaderText = "Specialite"
        SPECIALITE.MinimumWidth = 6
        SPECIALITE.Name = "SPECIALITE"
        SPECIALITE.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(476, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(779, 68)
        Label1.TabIndex = 19
        Label1.Text = "Gestion des membres de staff"
        ' 
        ' ComboBoxSpeciality
        ' 
        ComboBoxSpeciality.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxSpeciality.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxSpeciality.Items.AddRange(New Object() {"Manager", "Coach", "Nutritionniste", "Réceptionniste", "Technicien", "Infirmier"})
        ComboBoxSpeciality.Location = New Point(432, 777)
        ComboBoxSpeciality.Name = "ComboBoxSpeciality"
        ComboBoxSpeciality.Size = New Size(377, 53)
        ComboBoxSpeciality.TabIndex = 34
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1818, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(94, 45)
        Button16.TabIndex = 35
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(55, 880)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 36
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(55, 523)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 45)
        Label8.TabIndex = 38
        Label8.Text = "tel"
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBoxPhone.Location = New Point(434, 516)
        TextBoxPhone.MaxLength = 8
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(377, 52)
        TextBoxPhone.TabIndex = 37
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gym_rooms_interior_on_white_260nw_1323447797_imgupscaler_ai_Beta_4K
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Label8)
        Controls.Add(TextBoxPhone)
        Controls.Add(Button1)
        Controls.Add(Button16)
        Controls.Add(ComboBoxSpeciality)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBoxGender)
        Controls.Add(DateTimePickerDOB)
        Controls.Add(TextBoxCIN)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxLastName)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxCIN As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSpeciality As ComboBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents CIN As DataGridViewTextBoxColumn
    Friend WithEvents TEL As DataGridViewTextBoxColumn
    Friend WithEvents DATEDENAISSANCE As DataGridViewTextBoxColumn
    Friend WithEvents GENDRE As DataGridViewTextBoxColumn
    Friend WithEvents SPECIALITE As DataGridViewTextBoxColumn
End Class
