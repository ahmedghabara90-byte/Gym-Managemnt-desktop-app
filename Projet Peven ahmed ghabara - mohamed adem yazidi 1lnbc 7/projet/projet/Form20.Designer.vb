<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
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
        Label8 = New Label()
        TextBox4 = New TextBox()
        Button2 = New Button()
        Button16 = New Button()
        Button1 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox6 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ADRESSE = New DataGridViewTextBoxColumn()
        TEL = New DataGridViewTextBoxColumn()
        GENDRE = New DataGridViewTextBoxColumn()
        DATEDENAISSANCE = New DataGridViewTextBoxColumn()
        CIN = New DataGridViewTextBoxColumn()
        NOM = New DataGridViewTextBoxColumn()
        PRENOM = New DataGridViewTextBoxColumn()
        TextBox3 = New TextBox()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(38, 697)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 45)
        Label8.TabIndex = 39
        Label8.Text = "tel"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox4.Location = New Point(415, 683)
        TextBox4.MaxLength = 8
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(377, 52)
        TextBox4.TabIndex = 38
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(16, 14)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 50)
        Button2.TabIndex = 37
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1825, 918)
        Button16.Name = "Button16"
        Button16.Size = New Size(84, 45)
        Button16.TabIndex = 36
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(36, 875)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 35
        Button1.Text = "Supprimer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(36, 600)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 45)
        Label7.TabIndex = 34
        Label7.Text = "Adresse"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(36, 788)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 45)
        Label6.TabIndex = 33
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(36, 491)
        Label5.Name = "Label5"
        Label5.Size = New Size(340, 45)
        Label5.TabIndex = 32
        Label5.Text = "Date de Naissance"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 45)
        Label4.TabIndex = 31
        Label4.Text = "N CIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 45)
        Label3.TabIndex = 30
        Label3.Text = "Prenom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 45)
        Label2.TabIndex = 29
        Label2.Text = "Nom"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.Items.AddRange(New Object() {"Homme", "Femme"})
        ComboBox1.Location = New Point(413, 781)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(377, 53)
        ComboBox1.TabIndex = 28
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Garamond", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(415, 491)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(377, 38)
        DateTimePicker1.TabIndex = 27
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox6.Location = New Point(417, 393)
        TextBox6.MaxLength = 8
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(377, 52)
        TextBox6.TabIndex = 26
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox2.Location = New Point(417, 298)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(375, 52)
        TextBox2.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox1.Location = New Point(415, 201)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(377, 52)
        TextBox1.TabIndex = 23
        ' 
        ' ADRESSE
        ' 
        ADRESSE.HeaderText = "Adresse"
        ADRESSE.MinimumWidth = 6
        ADRESSE.Name = "ADRESSE"
        ADRESSE.Width = 125
        ' 
        ' TEL
        ' 
        TEL.HeaderText = "Tel"
        TEL.MinimumWidth = 6
        TEL.Name = "TEL"
        TEL.Width = 125
        ' 
        ' GENDRE
        ' 
        GENDRE.HeaderText = "Gendre"
        GENDRE.MinimumWidth = 6
        GENDRE.Name = "GENDRE"
        GENDRE.Width = 125
        ' 
        ' DATEDENAISSANCE
        ' 
        DATEDENAISSANCE.HeaderText = "Date de Naissance"
        DATEDENAISSANCE.MinimumWidth = 6
        DATEDENAISSANCE.Name = "DATEDENAISSANCE"
        DATEDENAISSANCE.Width = 125
        ' 
        ' CIN
        ' 
        CIN.HeaderText = "CIN"
        CIN.MaxInputLength = 8
        CIN.MinimumWidth = 6
        CIN.Name = "CIN"
        CIN.Width = 125
        ' 
        ' NOM
        ' 
        NOM.HeaderText = "Nom"
        NOM.MinimumWidth = 6
        NOM.Name = "NOM"
        NOM.Width = 125
        ' 
        ' PRENOM
        ' 
        PRENOM.HeaderText = "Prenom"
        PRENOM.MinimumWidth = 6
        PRENOM.Name = "PRENOM"
        PRENOM.Width = 125
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(415, 586)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(377, 52)
        TextBox3.TabIndex = 25
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PRENOM, NOM, CIN, DATEDENAISSANCE, GENDRE, TEL, ADRESSE})
        DataGridView1.Location = New Point(941, 201)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(930, 711)
        DataGridView1.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(761, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(554, 68)
        Label1.TabIndex = 21
        Label1.Text = "Gestion des abonnés"
        ' 
        ' Form20
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gym_rooms_interior_on_white_260nw_1323447797_imgupscaler2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Button2)
        Controls.Add(Button16)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(TextBox3)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form20"
        Text = "Form20"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ADRESSE As DataGridViewTextBoxColumn
    Friend WithEvents TEL As DataGridViewTextBoxColumn
    Friend WithEvents GENDRE As DataGridViewTextBoxColumn
    Friend WithEvents DATEDENAISSANCE As DataGridViewTextBoxColumn
    Friend WithEvents CIN As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
