Imports System.IO

Public Class Form18

    Dim filePath As String = "abonn.txt"
    Private selectedCIN As String = ""

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearInputs()
        Button3.Visible = False
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim parts() As String = sr.ReadLine().Split("#"c)
            If parts.Length >= 7 Then
                DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4), parts(5), parts(6))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub
    Private Sub ClearInputs()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = Today
        selectedCIN = ""
        Button3.Visible = False
        ResetColors()
        TextBox6.Enabled = False
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 OrElse e.RowIndex >= DataGridView1.Rows.Count Then Exit Sub
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(0).Value?.ToString()
        TextBox2.Text = row.Cells(1).Value?.ToString()
        TextBox6.Text = row.Cells(2).Value?.ToString()
        DateTimePicker1.Value = DateTime.Parse(row.Cells(3).Value?.ToString())
        ComboBox1.Text = row.Cells(4).Value?.ToString()
        TextBox3.Text = row.Cells(5).Value?.ToString()
        TextBox4.Text = row.Cells(6).Value?.ToString()
        selectedCIN = TextBox6.Text
        Button3.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()
        If selectedCIN = "" Then
            MsgBox("Sélectionner un abonné depuis le tableau", vbCritical)
            Exit Sub
        End If
        Dim errors As New List(Of String)
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            errors.Add("Nom vide")
            TextBox1.BackColor = Color.MistyRose
        ElseIf Not TextBox1.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors.Add("Nom invalide")
            TextBox1.BackColor = Color.MistyRose
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            errors.Add("Prénom vide")
            TextBox2.BackColor = Color.MistyRose
        ElseIf Not TextBox2.Text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors.Add("Prénom invalide")
            TextBox2.BackColor = Color.MistyRose
        End If
        If String.IsNullOrWhiteSpace(TextBox6.Text) Then
            errors.Add("CIN vide")
            TextBox6.BackColor = Color.MistyRose
        ElseIf TextBox6.Text.Length <> 8 Or Not TextBox6.Text.All(AddressOf Char.IsDigit) Then
            errors.Add("CIN invalide")
            TextBox6.BackColor = Color.MistyRose
        End If
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            errors.Add("Adresse vide")
            TextBox3.BackColor = Color.MistyRose
        End If
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            errors.Add("Téléphone vide")
            TextBox4.BackColor = Color.MistyRose
        ElseIf TextBox4.Text.Length <> 8 Or Not TextBox4.Text.All(AddressOf Char.IsDigit) Then
            errors.Add("Téléphone invalide")
            TextBox4.BackColor = Color.MistyRose
        End If
        Dim age As Integer = DateDiff(DateInterval.Year, DateTimePicker1.Value, Today)
        If DateTimePicker1.Value > Today.AddYears(-age) Then age -= 1
        If age < 15 Then
            errors.Add("Âge inférieur à 15 ans")
            DateTimePicker1.BackColor = Color.MistyRose
        End If
        If ComboBox1.SelectedIndex = -1 Then
            errors.Add("Genre non sélectionné")
            ComboBox1.BackColor = Color.MistyRose
        End If
        If errors.Count > 0 Then
            Dim msg As String = ""
            For Each err As String In errors
                msg &= err & vbCrLf
            Next
            MsgBox(msg, vbCritical)
            Exit Sub
        End If
        Dim lines() As String = {}
        Dim count As Integer = 0

        Dim fslire As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)
        While sr.Peek() <> -1
            ReDim Preserve lines(count)
            lines(count) = sr.ReadLine()
            count += 1
        End While
        sr.Close()
        fslire.Close()

        For i As Integer = 0 To lines.Length - 1
            Dim parts() As String = lines(i).Split("#"c)
            If parts.Length >= 7 AndAlso parts(2) = selectedCIN Then
                parts(0) = TextBox1.Text
                parts(1) = TextBox2.Text
                parts(3) = DateTimePicker1.Value.ToShortDateString()
                parts(4) = ComboBox1.Text
                parts(5) = TextBox3.Text
                parts(6) = TextBox4.Text
                lines(i) = parts(0) & "#" & parts(1) & "#" & parts(2) & "#" & parts(3) & "#" & parts(4) & "#" & parts(5) & "#" & parts(6)
                Exit For
            End If
        Next

        Dim fs As New FileStream(filePath, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        For i As Integer = 0 To lines.Length - 1
            sw.WriteLine(lines(i))
        Next
        sw.Close()
        fs.Close()
        MsgBox("Modification réussie", vbInformation)
        ClearInputs()
        LoadGrid()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        SearchGrid()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        SearchGrid()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        SearchGrid()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        SearchGrid()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SearchGrid()
    End Sub

    Private Sub SearchGrid()
        DataGridView1.Rows.Clear()

        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        While sr.Peek() <> -1
            Dim parts() As String = sr.ReadLine().Split("#"c)
            If parts.Length >= 7 Then
                If parts(0).ToLower().Contains(TextBox1.Text.ToLower()) AndAlso parts(1).ToLower().Contains(TextBox2.Text.ToLower()) AndAlso parts(5).ToLower().Contains(TextBox3.Text.ToLower()) AndAlso parts(6).Contains(TextBox4.Text) AndAlso (ComboBox1.SelectedIndex = -1 OrElse parts(4).ToLower() = ComboBox1.Text.ToLower()) Then
                    DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4), parts(5), parts(6))
                End If
            End If
        End While

        sr.Close()
        fs.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Form19
        f.Owner = Me
        f.SetCIN(selectedCIN)
        f.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadGrid()
        ResetColors()
        ClearInputs()
        Button3.Visible = False
    End Sub
End Class
