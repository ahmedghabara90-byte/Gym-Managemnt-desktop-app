<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label5 = New Label()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        ACT = New DataGridViewTextBoxColumn()
        COACH = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        TIME = New DataGridViewTextBoxColumn()
        SALLE = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label4 = New Label()
        TextBox6 = New TextBox()
        Button2 = New Button()
        Button16 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Linen
        Label5.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(658, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(568, 68)
        Label5.TabIndex = 47
        Label5.Text = "Gestion des planning"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(49, 854)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 48
        Button1.Text = "inscrire et continuer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ACT, COACH, DAT, TIME, SALLE})
        DataGridView1.Location = New Point(500, 385)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(679, 379)
        DataGridView1.TabIndex = 49
        ' 
        ' ACT
        ' 
        ACT.HeaderText = "Activité"
        ACT.MinimumWidth = 6
        ACT.Name = "ACT"
        ACT.Width = 125
        ' 
        ' COACH
        ' 
        COACH.HeaderText = "Coach"
        COACH.MinimumWidth = 6
        COACH.Name = "COACH"
        COACH.Width = 125
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 514)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 45)
        Label1.TabIndex = 50
        Label1.Text = "selectionner l'activité"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(49, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 45)
        Label4.TabIndex = 53
        Label4.Text = "N CIN"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Garamond", 24F, FontStyle.Bold)
        TextBox6.Location = New Point(428, 264)
        TextBox6.MaxLength = 8
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(377, 52)
        TextBox6.TabIndex = 52
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(49, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 50)
        Button2.TabIndex = 54
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1817, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(86, 45)
        Button16.TabIndex = 78
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pratiques_sportives_scaled_imgupscaler1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button16)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(TextBox6)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Name = "Form10"
        Text = "Form10"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ACT As DataGridViewTextBoxColumn
    Friend WithEvents COACH As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents SALLE As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button16 As Button
End Class
