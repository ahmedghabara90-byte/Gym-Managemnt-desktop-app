Imports System.Globalization
Imports System.IO

Public Class Form17

    Dim abonnPath As String = "abonn.txt"
    Dim insPlanPath As String = "insplan.txt"

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cin As String = TextBox6.Text.Trim()
        DataGridView1.Rows.Clear()
        If cin = "" Then
            MsgBox("Veuillez entrer un CIN.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If
        If cin.Length <> 8 Then
            MsgBox("Le CIN doit contenir exactement 8 chiffres.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If

        Dim fs1 As New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
        Dim sr1 As New StreamReader(fs1)
        Dim foundInAbonn As Boolean = False
        While sr1.Peek() <> -1
            Dim line As String = sr1.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If parts.Length >= 3 AndAlso parts(2) = cin Then
                foundInAbonn = True
                Exit While
            End If
        End While
        sr1.Close()
        fs1.Close()

        If Not foundInAbonn Then
            MsgBox("Le CIN n'est pas inscrit.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If

        Dim fs2 As New FileStream(insPlanPath, FileMode.Open, FileAccess.Read)
        Dim sr2 As New StreamReader(fs2)
        Dim today As Date = Date.Today
        Dim hasPlan As Boolean = False
        While sr2.Peek() <> -1
            Dim line As String = sr2.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If parts.Length >= 6 AndAlso parts(0) = cin Then
                Dim plandate As Date
                Dim day As Integer = CInt(parts(4).Substring(0, 2))
                Dim month As Integer = CInt(parts(4).Substring(3, 2))
                Dim year As Integer = 2000 + CInt(parts(4).Substring(6, 2))
                plandate = New Date(year, month, day)
                If plandate >= today Then
                    DataGridView1.Rows.Add(parts(2), parts(3), parts(0), parts(4), parts(5))
                    hasPlan = True
                End If
            End If
        End While
        sr2.Close()
        fs2.Close()

        If Not hasPlan Then
            MsgBox("Aucun plan à venir trouvé pour ce CIN.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If
        TextBox6.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedCin As String = TextBox6.Text.Trim()
        If selectedCin = "" Then
            MsgBox("Veuillez entrer un CIN.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If
        If selectedCin.Length <> 8 Then
            MsgBox("Le CIN doit contenir exactement 8 chiffres.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Veuillez sélectionner un plan à supprimer.", vbCritical, "Erreur")
            Exit Sub
        End If

        Dim selectedPlan As String() = {
            DataGridView1.SelectedRows(0).Cells(0).Value.ToString(),
            DataGridView1.SelectedRows(0).Cells(1).Value.ToString(),
            DataGridView1.SelectedRows(0).Cells(2).Value.ToString(),
            DataGridView1.SelectedRows(0).Cells(3).Value.ToString(),
            DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        }

        Dim lines() As String = {}
        Dim count As Integer = 0
        Dim fs As New FileStream(insPlanPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If Not (parts.Length >= 6 AndAlso parts(0) = selectedCin AndAlso parts(1) = selectedPlan(0) AndAlso parts(2) = selectedPlan(1) AndAlso parts(3) = selectedPlan(2)) Then
                ReDim Preserve lines(count)
                lines(count) = line
                count += 1
            End If
        End While
        sr.Close()
        fs.Close()

        Dim fsWrite As New FileStream(insPlanPath, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fsWrite)
        For i As Integer = 0 To lines.Length - 1
            sw.WriteLine(lines(i))
        Next
        sw.Close()
        fsWrite.Close()

        MsgBox("Plan supprimé avec succès.", vbInformation, "Succès")
        DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        TextBox6.BackColor = Color.White
    End Sub

End Class
