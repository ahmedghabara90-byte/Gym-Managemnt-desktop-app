Imports System.IO

Public Class Form10

    Dim planPath As String = "plan.txt"
    Dim abonnPath As String = "abonn.txt"
    Dim insPlanPath As String = "insplan.txt"

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlan()
        TextBox6.Text = ""
    End Sub

    Private Sub LoadPlan()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(planPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim t() As String = line.Split("#"c)
            If t.Length >= 5 Then
                DataGridView1.Rows.Add(t(0), t(1), t(2), t(3), t(4))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Function CINExists(cin As String) As Boolean
        Dim fs As New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim t() As String = line.Split("#"c)
            If t.Length >= 3 AndAlso t(2) = cin Then
                sr.Close()
                fs.Close()
                Return True
            End If
        End While
        sr.Close()
        fs.Close()
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cin As String = TextBox6.Text.Trim()
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
        If Not CINExists(cin) Then
            MsgBox("CIN non inscrit dans la liste des abonnés.", vbCritical, "Erreur")
            TextBox6.BackColor = Color.MistyRose
            Exit Sub
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Veuillez sélectionner un plan d'activité.", vbCritical, "Erreur")
            Exit Sub
        End If

        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim act As String = row.Cells(0).Value.ToString()
        Dim coach As String = row.Cells(1).Value.ToString()
        Dim dateAct As String = row.Cells(2).Value.ToString()
        Dim heur As String = row.Cells(3).Value.ToString()
        Dim salle As String = row.Cells(4).Value.ToString()

        Dim fs As New FileStream(insPlanPath, FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(cin & "#" & act & "#" & coach & "#" & dateAct & "#" & heur & "#" & salle)
        sw.Close()
        fs.Close()

        MsgBox("Planification enregistrée avec succès !", vbInformation, "Succès")
        TextBox6.Clear()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
