<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button16 = New Button()
        DataGridView1 = New DataGridView()
        PRENOM = New DataGridViewTextBoxColumn()
        NOM = New DataGridViewTextBoxColumn()
        CIN = New DataGridViewTextBoxColumn()
        PROF = New DataGridViewTextBoxColumn()
        ETAT = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 50)
        Button2.TabIndex = 43
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1827, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(85, 45)
        Button16.TabIndex = 44
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = SystemColors.ButtonShadow
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PRENOM, NOM, CIN, PROF, ETAT, DAT})
        DataGridView1.Location = New Point(1087, 299)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(804, 384)
        DataGridView1.TabIndex = 45
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
        ' PROF
        ' 
        PROF.HeaderText = "Specialité"
        PROF.MinimumWidth = 6
        PROF.Name = "PROF"
        PROF.Width = 125
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
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.White
        RadioButton2.Font = New Font("Garamond", 13.8F, FontStyle.Bold)
        RadioButton2.Location = New Point(54, 157)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(203, 30)
        RadioButton2.TabIndex = 54
        RadioButton2.TabStop = True
        RadioButton2.Text = "afficher non payé"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.White
        RadioButton1.Font = New Font("Garamond", 13.8F, FontStyle.Bold)
        RadioButton1.Location = New Point(54, 121)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(152, 30)
        RadioButton1.TabIndex = 53
        RadioButton1.TabStop = True
        RadioButton1.Text = "afficher tout"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.MenuHighlight
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(841, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 68)
        Label1.TabIndex = 52
        Label1.Text = "Paiment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(54, 445)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 45)
        Label4.TabIndex = 51
        Label4.Text = "N CIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(54, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 45)
        Label3.TabIndex = 50
        Label3.Text = "Prenom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 45)
        Label2.TabIndex = 49
        Label2.Text = "Nom"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox3.Location = New Point(433, 438)
        TextBox3.MaxLength = 8
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(377, 52)
        TextBox3.TabIndex = 48
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox2.Location = New Point(433, 329)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(375, 52)
        TextBox2.TabIndex = 47
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox1.Location = New Point(431, 227)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(377, 52)
        TextBox1.TabIndex = 46
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Gainsboro
        Label5.Location = New Point(354, 600)
        Label5.Name = "Label5"
        Label5.Size = New Size(193, 43)
        Label5.TabIndex = 57
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(54, 598)
        Label6.Name = "Label6"
        Label6.Size = New Size(187, 45)
        Label6.TabIndex = 56
        Label6.Text = "Montant :"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(378, 807)
        Button1.Name = "Button1"
        Button1.Size = New Size(308, 62)
        Button1.TabIndex = 55
        Button1.Text = "Payer et continuer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Gainsboro
        Label7.Location = New Point(354, 700)
        Label7.Name = "Label7"
        Label7.Size = New Size(193, 43)
        Label7.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(54, 698)
        Label8.Name = "Label8"
        Label8.Size = New Size(273, 45)
        Label8.TabIndex = 58
        Label8.Text = "Montant total :"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(818, 807)
        Button3.Name = "Button3"
        Button3.Size = New Size(304, 62)
        Button3.TabIndex = 60
        Button3.Text = "Payer tout et continuer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.happy_employee_getting_salary_wages_260nw_2360035037_imgupscaler_ai_Beta_2K
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button3)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button16)
        Controls.Add(Button2)
        Name = "Form4"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents CIN As DataGridViewTextBoxColumn
    Friend WithEvents PROF As DataGridViewTextBoxColumn
    Friend WithEvents ETAT As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
End Class
