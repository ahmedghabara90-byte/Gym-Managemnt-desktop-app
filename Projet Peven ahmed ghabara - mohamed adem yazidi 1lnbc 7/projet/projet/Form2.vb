Imports System.IO

Public Class Form2
    Dim filePath As String = "abonn.txt"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ResetColors()
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()

        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        Dim line As String
        Dim parts() As String

        While sr.Peek() <> -1
            line = sr.ReadLine()
            parts = line.Split("#"c)

            If parts.Length >= 7 Then
                DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4), parts(6), parts(5))
            End If
        End While

        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()
        Dim errors As New List(Of String)

        If TextBox1.Text.Trim() = "" Then
            errors.Add("Nom vide")
            TextBox1.BackColor = Color.MistyRose
        ElseIf Not TextBox1.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors.Add("Nom invalide")
            TextBox1.BackColor = Color.MistyRose
        End If
        If TextBox2.Text.Trim() = "" Then
            errors.Add("Prénom vide")
            TextBox2.BackColor = Color.MistyRose
        ElseIf Not TextBox2.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors.Add("Prénom invalide")
            TextBox2.BackColor = Color.MistyRose
        End If

        If TextBox6.Text.Trim() = "" Then
            errors.Add("CIN vide")
            TextBox6.BackColor = Color.MistyRose
        ElseIf Not TextBox6.Text.All(AddressOf Char.IsDigit) Then
            errors.Add("CIN doit contenir uniquement des chiffres")
            TextBox6.BackColor = Color.MistyRose
        ElseIf TextBox6.Text.Length <> 8 Then
            errors.Add("CIN doit avoir 8 chiffres")
            TextBox6.BackColor = Color.MistyRose
        ElseIf CINExists(TextBox6.Text) Then
            errors.Add("CIN déjà inscrit")
            TextBox6.BackColor = Color.MistyRose
        End If

        Dim age As Integer = DateDiff(DateInterval.Year, DateTimePicker1.Value, Today)
        If DateTimePicker1.Value > Today.AddYears(-age) Then age -= 1
        If age < 15 Then
            errors.Add("L'abonné doit avoir au moins 15 ans")
            DateTimePicker1.BackColor = Color.MistyRose
        End If

        If ComboBox1.SelectedIndex = -1 Then
            errors.Add("Genre non sélectionné")
            ComboBox1.BackColor = Color.MistyRose
        End If

        If TextBox3.Text.Trim() = "" Then
            errors.Add("Adresse vide")
            TextBox3.BackColor = Color.MistyRose
        ElseIf Not TextBox3.Text.All(Function(c) Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c)) Then
            errors.Add("Adresse invalide")
            TextBox3.BackColor = Color.MistyRose
        End If

        If TextBox4.Text.Trim() = "" Then
            errors.Add("Téléphone vide")
            TextBox4.BackColor = Color.MistyRose
        ElseIf Not TextBox4.Text.All(AddressOf Char.IsDigit) Then
            errors.Add("Téléphone doit contenir uniquement des chiffres")
            TextBox4.BackColor = Color.MistyRose
        ElseIf TextBox4.Text.Length <> 8 Then
            errors.Add("Téléphone doit avoir 8 chiffres")
            TextBox4.BackColor = Color.MistyRose
        End If

        If errors.Count > 0 Then
            MsgBox(String.Join(vbCrLf, errors), vbCritical, "Erreurs")
            Exit Sub
        End If

        Dim newLine As String = TextBox1.Text.Trim() & "#" & TextBox2.Text.Trim() & "#" & TextBox6.Text.Trim() & "#" & DateTimePicker1.Value.ToShortDateString() & "#" & ComboBox1.Text & "#" & TextBox3.Text.Trim() & "#" & TextBox4.Text.Trim()

        Dim fs As New FileStream(filePath, FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)

        sw.WriteLine(newLine)

        sw.Close()
        fs.Close()

        MsgBox("Abonné ajouté avec succès !", vbInformation)
        ClearInputs()
        LoadGrid()
    End Sub
    Private Function CINExists(cin As String) As Boolean
        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        Dim line As String
        Dim parts() As String

        While sr.Peek() <> -1
            line = sr.ReadLine()
            parts = line.Split("#"c)

            If parts.Length >= 3 AndAlso parts(2) = cin Then
                sr.Close()
                fs.Close()
                Return True
            End If
        End While

        sr.Close()
        fs.Close()
        Return False
    End Function

    Private Sub ClearInputs()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        DateTimePicker1.Value = Today
        ComboBox1.SelectedIndex = -1
        ResetColors()
    End Sub

    Private Sub ResetColors()
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox6.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        DateTimePicker1.BackColor = Color.White
        ComboBox1.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub
End Class
