<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        DataGridView1 = New DataGridView()
        ACT = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        TIME = New DataGridViewTextBoxColumn()
        SALLE = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        Button16 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ACT, DAT, TIME, SALLE})
        DataGridView1.Location = New Point(1170, 366)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(554, 379)
        DataGridView1.TabIndex = 45
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(736, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(674, 68)
        Label5.TabIndex = 67
        Label5.Text = "Consultation des coaches"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(241, 593)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 45)
        Label2.TabIndex = 68
        Label2.Text = "CIN"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(542, 593)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 45)
        Label1.TabIndex = 69
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.LightGray
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(542, 366)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 45)
        Label3.TabIndex = 71
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(241, 366)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 45)
        Label4.TabIndex = 70
        Label4.Text = "Nom"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.LightGray
        Label6.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(542, 472)
        Label6.Name = "Label6"
        Label6.Size = New Size(304, 45)
        Label6.TabIndex = 73
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(241, 472)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 45)
        Label7.TabIndex = 72
        Label7.Text = "Prenom"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(112, 192)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 45)
        Label9.TabIndex = 74
        Label9.Text = "Coach"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(112, 820)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 77
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1814, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(86, 45)
        Button16.TabIndex = 78
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button16)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Name = "Form12"
        Text = "Form12"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ACT As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents SALLE As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button16 As Button
End Class
