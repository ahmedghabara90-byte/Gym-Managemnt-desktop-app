Imports System.IO

Public Class Form11

    Dim filePath As String = "staff.txt"
    Private selectedCIN As String = ""

    Public ReadOnly Property StaffCIN As String
        Get
            Return selectedCIN
        End Get
    End Property

    Public ReadOnly Property StaffName As String
        Get
            Return TextBoxName.Text
        End Get
    End Property

    Public ReadOnly Property StaffLastName As String
        Get
            Return TextBoxLastName.Text
        End Get
    End Property

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearInputs()
        btn.Visible = False
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        If Not File.Exists(filePath) Then Exit Sub
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

        If e.RowIndex < 0 Or e.RowIndex >= DataGridView1.Rows.Count - 1 Then Exit Sub

        Dim row = DataGridView1.Rows(e.RowIndex)

        If row.IsNewRow Then Exit Sub

        TextBoxName.Text = row.Cells(0).Value?.ToString()
        TextBoxLastName.Text = row.Cells(1).Value?.ToString()
        TextBoxCIN.Text = row.Cells(2).Value?.ToString()
        TextBoxPhone.Text = row.Cells(3).Value?.ToString()
        DateTimePickerDOB.Value = If(row.Cells(4).Value IsNot Nothing, Date.Parse(row.Cells(4).Value.ToString()), Today)
        ComboBoxGender.Text = row.Cells(5).Value?.ToString()
        ComboBoxSpeciality.Text = row.Cells(6).Value?.ToString()

        selectedCIN = TextBoxCIN.Text
        TextBoxCIN.Enabled = False

        btn.Visible = (ComboBoxSpeciality.Text = "Coach")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()

        If selectedCIN = "" Then
            MsgBox("Sélectionner un staff", vbCritical)
            Exit Sub
        End If

        If Not ValidateInputs() Then Exit Sub

        Dim newLine As String = TextBoxName.Text & ";" & TextBoxLastName.Text & ";" & selectedCIN & ";" & TextBoxPhone.Text & ";" & DateTimePickerDOB.Value.ToShortDateString() & ";" & ComboBoxSpeciality.Text

        Dim oldLine As String = ""
        Dim fslire As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)
        Dim lines As New List(Of String)

        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim parts() As String = line.Split(";"c)
            If parts(2) = selectedCIN Then oldLine = line
            lines.Add(line)
        End While
        sr.Close()
        fslire.Close()

        If newLine = oldLine Then
            MsgBox("Aucune modification détectée.", vbInformation)
            Exit Sub
        End If

        For i = 0 To lines.Count - 1
            Dim parts() As String = lines(i).Split(";"c)
            If parts(2) = selectedCIN Then
                lines(i) = newLine
                Exit For
            End If
        Next

        Dim fs As New FileStream(filePath, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        For Each l As String In lines
            sw.WriteLine(l)
        Next
        sw.Close()
        fs.Close()

        MsgBox("Modification réussie", vbInformation)

        TextBoxCIN.Enabled = True
        selectedCIN = ""
        ClearInputs()
        LoadGrid()
        btn.Visible = False
    End Sub

    Private Function ValidateInputs() As Boolean
        If TextBoxName.Text = "" Or Not TextBoxName.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            MarkError(TextBoxName, "Nom invalide")
            Return False
        End If
        If TextBoxLastName.Text = "" Or Not TextBoxLastName.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            MarkError(TextBoxLastName, "Prénom invalide")
            Return False
        End If
        If TextBoxPhone.Text.Length <> 8 Or Not TextBoxPhone.Text.All(AddressOf Char.IsDigit) Then
            MarkError(TextBoxPhone, "Téléphone doit contenir 8 chiffres")
            Return False
        End If
        If ComboBoxGender.SelectedIndex = -1 Then
            MarkError(ComboBoxGender, "Choisir le genre")
            Return False
        End If
        If ComboBoxSpeciality.SelectedIndex = -1 Then
            MarkError(ComboBoxSpeciality, "Choisir la spécialité")
            Return False
        End If

        Dim age As Integer = DateDiff(DateInterval.Year, DateTimePickerDOB.Value, Today)
        If DateTimePickerDOB.Value > Today.AddYears(-age) Then age -= 1
        If age < 18 Then
            MarkError(DateTimePickerDOB, "Âge inférieur à 18 ans")
            Return False
        End If
        Return True
    End Function

    Private Sub MarkError(ctrl As Control, msg As String)
        ctrl.BackColor = Color.MistyRose
        MsgBox(msg, vbCritical)
    End Sub

    Private Sub ResetColors()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or TypeOf c Is DateTimePicker Then
                c.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub ClearInputs()
        TextBoxName.Clear()
        TextBoxLastName.Clear()
        TextBoxCIN.Clear()
        TextBoxPhone.Clear()
        ComboBoxGender.SelectedIndex = -1
        ComboBoxSpeciality.SelectedIndex = -1
        DateTimePickerDOB.Value = Today
        ResetColors()
    End Sub

    Private Sub TextBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub
    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        FilterGrid()
    End Sub

    Private Sub TextBoxLastName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLastName.TextChanged
        FilterGrid()
    End Sub

    Private Sub TextBoxCIN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCIN.TextChanged
        FilterGrid()
    End Sub

    Private Sub FilterGrid()
        Dim searchName As String = TextBoxName.Text.Trim().ToLower()
        Dim searchLastName As String = TextBoxLastName.Text.Trim().ToLower()
        Dim searchCIN As String = TextBoxCIN.Text.Trim()

        DataGridView1.Rows.Clear()

        If Not File.Exists(filePath) Then Exit Sub
        Dim lines() As String = File.ReadAllLines(filePath)

        For Each line As String In lines
            Dim parts() As String = line.Split(";"c)
            If parts.Length = 7 Then
                Dim nameMatch As Boolean = (searchName = "" OrElse parts(0).ToLower().Contains(searchName))
                Dim lastNameMatch As Boolean = (searchLastName = "" OrElse parts(1).ToLower().Contains(searchLastName))
                Dim cinMatch As Boolean = (searchCIN = "" OrElse parts(2).Contains(searchCIN))

                If nameMatch AndAlso lastNameMatch AndAlso cinMatch Then
                    DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4), parts(5), parts(6))
                End If
            End If
        Next
    End Sub


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim f12 As New Form12()
        f12.Owner = Me
        f12.Show()
    End Sub

End Class
