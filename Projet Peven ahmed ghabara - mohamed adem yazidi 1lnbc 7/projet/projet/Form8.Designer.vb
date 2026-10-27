<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        GroupBox5 = New GroupBox()
        Button13 = New Button()
        GroupBox4 = New GroupBox()
        Button10 = New Button()
        Button11 = New Button()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = SystemColors.ButtonShadow
        GroupBox5.Controls.Add(Button13)
        GroupBox5.Font = New Font("Garamond", 19.8000011F, FontStyle.Bold)
        GroupBox5.Location = New Point(486, 805)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(952, 112)
        GroupBox5.TabIndex = 11
        GroupBox5.TabStop = False
        GroupBox5.Text = "Gestion des abonnements et paiements"
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(266, 44)
        Button13.Name = "Button13"
        Button13.Size = New Size(376, 45)
        Button13.TabIndex = 2
        Button13.Text = "Renouvler abonnement"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ActiveCaption
        GroupBox4.Controls.Add(Button10)
        GroupBox4.Controls.Add(Button11)
        GroupBox4.Font = New Font("Garamond", 19.8000011F, FontStyle.Bold)
        GroupBox4.Location = New Point(486, 585)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(952, 111)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Gestion des plannings"
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(137, 44)
        Button10.Name = "Button10"
        Button10.Size = New Size(197, 45)
        Button10.TabIndex = 2
        Button10.Text = "Inscrire"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(600, 44)
        Button11.Name = "Button11"
        Button11.Size = New Size(197, 45)
        Button11.TabIndex = 1
        Button11.Text = "Désinscrire "
        Button11.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button15)
        GroupBox1.Controls.Add(Button16)
        GroupBox1.Font = New Font("Garamond", 19.8000011F, FontStyle.Bold)
        GroupBox1.Location = New Point(486, 347)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(952, 106)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gestion des abonnés"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(33, 44)
        Button5.Name = "Button5"
        Button5.Size = New Size(197, 45)
        Button5.TabIndex = 2
        Button5.Text = "Ajouter"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(718, 44)
        Button15.Name = "Button15"
        Button15.Size = New Size(197, 45)
        Button15.TabIndex = 1
        Button15.Text = "Supprimer"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(371, 44)
        Button16.Name = "Button16"
        Button16.Size = New Size(197, 45)
        Button16.TabIndex = 0
        Button16.Text = "Modifier"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Turquoise
        Label1.Location = New Point(623, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(685, 68)
        Label1.TabIndex = 6
        Label1.Text = "Gestion des abonnements"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(39, 34)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 50)
        Button2.TabIndex = 44
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1826, 920)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 45)
        Button1.TabIndex = 79
        Button1.Text = "Quit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._360_F_209469658_ec4kTKmE12PDeXsjcsd2ADI42EQlrXwM_imgupscaler_ai_Beta_2K
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "Form8"
        WindowState = FormWindowState.Maximized
        GroupBox5.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button13 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
