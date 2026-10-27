Imports System.IO

Public Class Form5

    Private path As String = "staff.txt"

    Private Sub Form5_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadGrid()
        ClearInputs()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ResetColors()
        Dim errors As String = ""

        Dim name As String = TextBoxName.Text.Trim()
        Dim lastname As String = TextBoxLastName.Text.Trim()
        Dim cin As String = TextBoxCIN.Text.Trim()
        Dim phone As String = TextBoxPhone.Text.Trim()
        Dim dob As Date = DateTimePickerDOB.Value
        Dim gender As String = ComboBoxGender.Text
        Dim speciality As String = ComboBoxSpeciality.Text

        If name = "" Or Not name.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors &= "- Nom invalide (lettres et espaces uniquement)" & vbCrLf
            TextBoxName.BackColor = Color.MistyRose
        End If

        If lastname = "" Or Not lastname.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            errors &= "- Prénom invalide (lettres et espaces uniquement)" & vbCrLf
            TextBoxLastName.BackColor = Color.MistyRose
        End If

        If cin.Length <> 8 Or Not cin.All(AddressOf Char.IsDigit) Then
            errors &= "- CIN : 8 chiffres" & vbCrLf
            TextBoxCIN.BackColor = Color.MistyRose
        End If

        If phone.Length <> 8 Or Not phone.All(AddressOf Char.IsDigit) Then
            errors &= "- Telephone : 8 chiffres" & vbCrLf
            TextBoxPhone.BackColor = Color.MistyRose
        End If

        Dim age As Integer = DateDiff(DateInterval.Year, dob, Today)
        If dob > Today.AddYears(-age) Then age -= 1

        If age < 18 Then
            errors &= "- Age minimum 18 ans" & vbCrLf
            DateTimePickerDOB.CalendarMonthBackground = Color.MistyRose
        End If

        If gender = "" Then
            errors &= "- Choisir le genre" & vbCrLf
            ComboBoxGender.BackColor = Color.MistyRose
        End If

        If speciality = "" Then
            errors &= "- Choisir la specialite" & vbCrLf
            ComboBoxSpeciality.BackColor = Color.MistyRose
        End If

        If errors <> "" Then
            MsgBox(errors, vbCritical, "Erreurs de saisie")
            Exit Sub
        End If

        Dim fslire As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)

        While sr.Peek() <> -1
            Dim p() As String = sr.ReadLine().Split(";"c)
            If p.Length > 2 AndAlso p(2) = cin Then
                TextBoxCIN.BackColor = Color.MistyRose
                sr.Close()
                fslire.Close()
                MsgBox("CIN deja existant", vbCritical, "Erreur")
                Exit Sub
            End If
        End While

        sr.Close()
        fslire.Close()

        Dim record As String = name & ";" & lastname & ";" & cin & ";" & phone & ";" & dob.ToShortDateString() & ";" & gender & ";" & speciality

        Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(record)
        sw.Close()
        fs.Close()

        MsgBox("Staff ajoute avec succes", vbInformation, "Succes")

        LoadGrid()
        ClearInputs()

    End Sub

    Private Sub LoadGrid()

        DataGridView1.Rows.Clear()

        Dim fs As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        While sr.Peek() <> -1
            Dim p() As String = sr.ReadLine().Split(";"c)
            If p.Length = 7 Then
                DataGridView1.Rows.Add(p(0), p(1), p(2), p(3), p(4), p(5), p(6))
            End If
        End While

        sr.Close()
        fs.Close()

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

    Private Sub ResetColors()

        TextBoxName.BackColor = Color.White
        TextBoxLastName.BackColor = Color.White
        TextBoxCIN.BackColor = Color.White
        TextBoxPhone.BackColor = Color.White
        ComboBoxGender.BackColor = Color.White
        ComboBoxSpeciality.BackColor = Color.White

    End Sub

    Private Sub LettersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) _
    Handles TextBoxName.KeyPress, TextBoxLastName.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



    Private Sub NumbersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles TextBoxCIN.KeyPress, TextBoxPhone.KeyPress

        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ChrW(8) Then
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
