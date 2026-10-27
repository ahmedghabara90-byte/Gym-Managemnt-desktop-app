<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        DataGridView1 = New DataGridView()
        PRENOM = New DataGridViewTextBoxColumn()
        NOM = New DataGridViewTextBoxColumn()
        CIN = New DataGridViewTextBoxColumn()
        DAT4 = New DataGridViewTextBoxColumn()
        GENDRE = New DataGridViewTextBoxColumn()
        ETAT = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        DATT = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        TextBox6 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button16 = New Button()
        Button2 = New Button()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        CheckBox13 = New CheckBox()
        CheckBox14 = New CheckBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PRENOM, NOM, CIN, DAT4, GENDRE, ETAT, DAT, DATT})
        DataGridView1.Location = New Point(848, 221)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1056, 696)
        DataGridView1.TabIndex = 2
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
        ' DAT4
        ' 
        DAT4.HeaderText = "Date de naissance"
        DAT4.MinimumWidth = 6
        DAT4.Name = "DAT4"
        DAT4.Width = 125
        ' 
        ' GENDRE
        ' 
        GENDRE.HeaderText = "Gendre"
        GENDRE.MinimumWidth = 6
        GENDRE.Name = "GENDRE"
        GENDRE.Width = 125
        ' 
        ' ETAT
        ' 
        ETAT.HeaderText = "Etat"
        ETAT.MinimumWidth = 6
        ETAT.Name = "ETAT"
        ETAT.Width = 125
        ' 
        ' DAT
        ' 
        DAT.HeaderText = "Date de paiment"
        DAT.MinimumWidth = 6
        DAT.Name = "DAT"
        DAT.Width = 125
        ' 
        ' DATT
        ' 
        DATT.HeaderText = "Date de fin"
        DATT.MinimumWidth = 6
        DATT.Name = "DATT"
        DATT.Width = 125
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 45)
        Label4.TabIndex = 18
        Label4.Text = "N CIN"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(349, 259)
        TextBox6.MaxLength = 8
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(377, 45)
        TextBox6.TabIndex = 15
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(27, 51)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(114, 35)
        RadioButton1.TabIndex = 19
        RadioButton1.TabStop = True
        RadioButton1.Text = "1 Mois"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(28, 92)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(116, 35)
        RadioButton2.TabIndex = 20
        RadioButton2.TabStop = True
        RadioButton2.Text = "3 Mois"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(28, 133)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(116, 35)
        RadioButton3.TabIndex = 21
        RadioButton3.TabStop = True
        RadioButton3.Text = "6 Mois"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(28, 174)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(81, 35)
        RadioButton4.TabIndex = 22
        RadioButton4.TabStop = True
        RadioButton4.Text = "1 an"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Garamond", 16.2F, FontStyle.Bold)
        GroupBox1.Location = New Point(6, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(322, 215)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Abonnement"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(50, 883)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 62)
        Button1.TabIndex = 24
        Button1.Text = "Payer et continuer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Font = New Font("Garamond", 16.2F, FontStyle.Bold)
        GroupBox2.Location = New Point(6, 248)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(785, 215)
        GroupBox2.TabIndex = 37
        GroupBox2.TabStop = False
        GroupBox2.Text = "Activités"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(50, 821)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 45)
        Label1.TabIndex = 38
        Label1.Text = "Montant :"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Gainsboro
        Label5.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(320, 821)
        Label5.Name = "Label5"
        Label5.Size = New Size(193, 43)
        Label5.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.MenuHighlight
        Label6.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(815, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 68)
        Label6.TabIndex = 40
        Label6.Text = "Paiment"
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1804, 923)
        Button16.Name = "Button16"
        Button16.Size = New Size(103, 45)
        Button16.TabIndex = 41
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(41, 25)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 50)
        Button2.TabIndex = 42
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.BackColor = Color.White
        RadioButton5.Font = New Font("Garamond", 13.8F, FontStyle.Bold)
        RadioButton5.Location = New Point(53, 143)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(152, 30)
        RadioButton5.TabIndex = 43
        RadioButton5.TabStop = True
        RadioButton5.Text = "afficher tout"
        RadioButton5.UseVisualStyleBackColor = False
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.BackColor = Color.White
        RadioButton6.Font = New Font("Garamond", 13.8F, FontStyle.Bold)
        RadioButton6.Location = New Point(53, 179)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(203, 30)
        RadioButton6.TabIndex = 44
        RadioButton6.TabStop = True
        RadioButton6.Text = "afficher non payé"
        RadioButton6.UseVisualStyleBackColor = False
        ' 
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox13.Location = New Point(6, 138)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(206, 35)
        CheckBox13.TabIndex = 45
        CheckBox13.Text = "Nutritionniste"
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox14
        ' 
        CheckBox14.AutoSize = True
        CheckBox14.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox14.Location = New Point(6, 56)
        CheckBox14.Name = "CheckBox14"
        CheckBox14.Size = New Size(111, 35)
        CheckBox14.TabIndex = 46
        CheckBox14.Text = "Coach"
        CheckBox14.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveCaption
        GroupBox3.Controls.Add(CheckBox14)
        GroupBox3.Controls.Add(CheckBox13)
        GroupBox3.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(424, 26)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(367, 215)
        GroupBox3.TabIndex = 47
        GroupBox3.TabStop = False
        GroupBox3.Text = "Autres"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(GroupBox3)
        GroupBox4.Controls.Add(GroupBox2)
        GroupBox4.Controls.Add(GroupBox1)
        GroupBox4.Location = New Point(8, 330)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(797, 469)
        GroupBox4.TabIndex = 48
        GroupBox4.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1919, 977)
        Controls.Add(GroupBox4)
        Controls.Add(RadioButton6)
        Controls.Add(RadioButton5)
        Controls.Add(Button2)
        Controls.Add(Button16)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox6)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents CIN As DataGridViewTextBoxColumn
    Friend WithEvents DAT4 As DataGridViewTextBoxColumn
    Friend WithEvents GENDRE As DataGridViewTextBoxColumn
    Friend WithEvents ETAT As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
    Friend WithEvents DATT As DataGridViewTextBoxColumn
End Class
