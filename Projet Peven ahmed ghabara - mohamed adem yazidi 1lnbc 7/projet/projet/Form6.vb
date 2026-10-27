Imports System.IO

Public Class Form6

    Dim filePath As String = "act.txt"

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearInputs()
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()
        Dim errors() As String = {}
        Dim errCount As Integer = 0

        If TextBox1.Text = "" Or Not TextBox1.Text.All(Function(c) Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c)) Then
            ReDim Preserve errors(errCount)
            errors(errCount) = "Nom de l'activité invalide"
            errCount += 1
            TextBox1.BackColor = Color.MistyRose
        End If

        If ComboBox1.SelectedIndex = -1 Then
            ReDim Preserve errors(errCount)
            errors(errCount) = "Sélectionner le genre recommandé"
            errCount += 1
            ComboBox1.BackColor = Color.MistyRose
        End If

        If Not RadioButton1.Checked And Not RadioButton2.Checked And Not RadioButton3.Checked Then
            ReDim Preserve errors(errCount)
            errors(errCount) = "Sélectionner le type d'activité"
            errCount += 1
            RadioButton1.BackColor = Color.MistyRose
            RadioButton2.BackColor = Color.MistyRose
            RadioButton3.BackColor = Color.MistyRose
        End If

        Dim minAge As Integer
        Dim maxAge As Integer
        If Not Integer.TryParse(TextBox3.Text, minAge) Or minAge < 15 Then
            ReDim Preserve errors(errCount)
            errors(errCount) = "Âge minimum invalide"
            errCount += 1
            TextBox3.BackColor = Color.MistyRose
        End If

        If Not Integer.TryParse(TextBox4.Text, maxAge) Or maxAge < minAge Then
            ReDim Preserve errors(errCount)
            errors(errCount) = "Âge maximum invalide"
            errCount += 1
            TextBox4.BackColor = Color.MistyRose
        End If

        If errCount > 0 Then
            Dim msg As String = ""
            For i = 0 To errors.Length - 1
                msg &= errors(i) & vbCrLf
            Next
            MsgBox(msg, vbCritical)
            Exit Sub
        End If

        Dim fsCheck As New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read)
        Dim srCheck As New StreamReader(fsCheck)
        While srCheck.Peek() <> -1
            Dim line As String = srCheck.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If parts.Length >= 1 AndAlso parts(0).ToLower() = TextBox1.Text.Trim.ToLower() Then
                srCheck.Close()
                fsCheck.Close()
                MsgBox("Cette activité existe déjà.", vbCritical)
                Exit Sub
            End If
        End While
        srCheck.Close()
        fsCheck.Close()

        Dim typeAct As String = If(RadioButton1.Checked, "Cardio", If(RadioButton3.Checked, "Cours collectif", "Renforcement musculaire"))
        Dim fsWrite As New FileStream(filePath, FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fsWrite)
        sw.WriteLine(TextBox1.Text.Trim & "#" & typeAct & "#" & TextBox3.Text.Trim & "-" & TextBox4.Text.Trim & "#" & ComboBox1.Text)
        sw.Close()
        fsWrite.Close()

        MsgBox("Activité ajoutée avec succès.", vbInformation)
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

    Private Sub ResetColors()
        TextBox1.BackColor = Color.White
        ComboBox1.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        RadioButton1.BackColor = Color.Transparent
        RadioButton2.BackColor = Color.Transparent
        RadioButton3.BackColor = Color.Transparent
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
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

End Class
