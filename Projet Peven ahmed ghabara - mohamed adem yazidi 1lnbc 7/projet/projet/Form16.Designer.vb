<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Button16 = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ListBox2 = New ListBox()
        DateTimePicker2 = New DateTimePicker()
        ACT = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        COACH = New DataGridViewTextBoxColumn()
        DAT = New DataGridViewTextBoxColumn()
        TIME = New DataGridViewTextBoxColumn()
        SALLE = New DataGridViewTextBoxColumn()
        ListBox1 = New ListBox()
        Label3 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1807, 909)
        Button16.Name = "Button16"
        Button16.Size = New Size(86, 45)
        Button16.TabIndex = 77
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(35, 847)
        Button1.Name = "Button1"
        Button1.Size = New Size(340, 70)
        Button1.TabIndex = 76
        Button1.Text = "Supprimer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.Items.AddRange(New Object() {"Salle 01", "Salle 02", "Salle 03", "Salle 04", "Salle 05", "Salle 06", "Salle 07"})
        ComboBox1.Location = New Point(680, 613)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(341, 53)
        ComboBox1.TabIndex = 75
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(680, 373)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(341, 52)
        DateTimePicker1.TabIndex = 73
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(383, 362)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(231, 290)
        ListBox2.TabIndex = 72
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "HH:mm"
        DateTimePicker2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(680, 448)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(341, 52)
        DateTimePicker2.TabIndex = 74
        ' 
        ' ACT
        ' 
        ACT.HeaderText = "Activité"
        ACT.MinimumWidth = 6
        ACT.Name = "ACT"
        ACT.Width = 125
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ACT, COACH, DAT, TIME, SALLE})
        DataGridView1.Location = New Point(1205, 303)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(679, 379)
        DataGridView1.TabIndex = 78
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
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(94, 362)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(231, 290)
        ListBox1.TabIndex = 71
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(680, 556)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 45)
        Label3.TabIndex = 84
        Label3.Text = "Salle"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(413, 303)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 45)
        Label1.TabIndex = 82
        Label1.Text = "Activité"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(129, 303)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 45)
        Label7.TabIndex = 81
        Label7.Text = "Coach"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Linen
        Label5.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(592, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(568, 68)
        Label5.TabIndex = 80
        Label5.Text = "Gestion des planning"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(32, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 50)
        Button2.TabIndex = 79
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(673, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 45)
        Label2.TabIndex = 83
        Label2.Text = "Date"
        ' 
        ' Form16
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 977)
        Controls.Add(Button16)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ListBox2)
        Controls.Add(DateTimePicker2)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Name = "Form16"
        Text = "Form16"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ACT As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents COACH As DataGridViewTextBoxColumn
    Friend WithEvents DAT As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents SALLE As DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
