<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Button16 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Turquoise
        Label1.Location = New Point(601, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(711, 68)
        Label1.TabIndex = 0
        Label1.Text = "Gestion de la salle de sport"
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.Location = New Point(1835, 920)
        Button16.Name = "Button16"
        Button16.Size = New Size(72, 45)
        Button16.TabIndex = 6
        Button16.Text = "Quit"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1201, 484)
        Button1.Name = "Button1"
        Button1.Size = New Size(483, 121)
        Button1.TabIndex = 7
        Button1.Text = "Gestion de la salle de sport"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Garamond", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(234, 484)
        Button2.Name = "Button2"
        Button2.Size = New Size(483, 121)
        Button2.TabIndex = 8
        Button2.Text = "Gestion des abonements"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1919, 977)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button16)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "+- "
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
