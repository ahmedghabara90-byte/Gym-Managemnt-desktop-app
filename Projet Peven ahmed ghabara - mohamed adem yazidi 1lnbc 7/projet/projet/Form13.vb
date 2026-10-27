Imports System.IO

Public Class Form13

    Dim filePath As String = "staff.txt"
    Dim selectedCIN As String = ""

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearInputs()

        TextBoxName.ReadOnly = True
        TextBoxLastName.ReadOnly = True
        TextBoxCIN.ReadOnly = True
        TextBoxPhone.ReadOnly = True

        ComboBoxGender.Enabled = False
        ComboBoxSpeciality.Enabled = False

        DateTimePickerDOB.Enabled = False
    End Sub


    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        While sr.Peek() <> -1
            Dim parts() As String = sr.ReadLine().Split(";"c)
            If parts.Length = 7 Then
                DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4), parts(5), parts(6))
            End If
        End While

        sr.Close()
        fs.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub

        TextBoxName.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        TextBoxLastName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        TextBoxCIN.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        TextBoxPhone.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        DateTimePickerDOB.Value = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString())
        ComboBoxGender.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        ComboBoxSpeciality.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()

        selectedCIN = TextBoxCIN.Text
        TextBoxCIN.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedCIN = "" Then
            MsgBox("Sélectionner un staff à supprimer", vbCritical)
            Exit Sub
        End If

        Dim result = MsgBox("Voulez-vous vraiment supprimer ce staff ?", vbYesNo + vbQuestion, "Confirmer la suppression")
        If result = vbNo Then Exit Sub

        Dim lines As New List(Of String)
        Dim fslire As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)

        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine().Trim()
            If line = "" Then Continue While
            Dim parts() As String = line.Split(";"c)
            If parts.Length > 2 AndAlso parts(2) <> selectedCIN Then
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

        MsgBox("Staff supprimé avec succès", vbInformation)

        TextBoxCIN.Enabled = True
        selectedCIN = ""
        ClearInputs()
        LoadGrid()
    End Sub

    Private Sub ClearInputs()
        TextBoxName.Clear()
        TextBoxLastName.Clear()
        TextBoxCIN.Clear()
        TextBoxPhone.Clear()
        ComboBoxGender.SelectedIndex = -1
        ComboBoxSpeciality.SelectedIndex = -1
        DateTimePickerDOB.Value = Today
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
