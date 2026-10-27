Imports System.IO

Public Class Form14

    Dim filePath As String = "act.txt"
    Dim selectedActivity As String = ""

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearInputs()

        TextBox1.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True

        ComboBox1.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If parts.Length = 4 Then
                DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        Dim type As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        RadioButton1.Checked = (type = "Cardio")
        RadioButton2.Checked = (type = "Cours collectif")
        RadioButton3.Checked = (type = "Renforcement musculaire")
        Dim ages() As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString().Split("-"c)
        If ages.Length = 2 Then
            TextBox3.Text = ages(0)
            TextBox4.Text = ages(1)
        End If
        selectedActivity = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedActivity = "" Then
            MsgBox("Sélectionner une activité à supprimer", vbCritical)
            Exit Sub
        End If

        Dim result = MsgBox("Voulez-vous vraiment supprimer cette activité ?", vbYesNo + vbQuestion, "Confirmer la suppression")
        If result = vbNo Then Exit Sub

        Dim lines As New List(Of String)
        Dim fslire As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)

        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine().Trim()
            Dim parts() As String = line.Split("#"c)
            If parts.Length > 0 AndAlso parts(0) <> selectedActivity Then
                lines.Add(line)
            End If
        End While

        sr.Close()
        fslire.Close()

        Dim fs As New FileStream(filePath, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        For Each l As String In lines
            sw.WriteLine(l)
        Next
        sw.Close()
        fs.Close()

        MsgBox("Activité supprimée avec succès.", vbInformation)
        ClearInputs()
        selectedActivity = ""
        LoadGrid()
    End Sub

    Private Sub ClearInputs()
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
