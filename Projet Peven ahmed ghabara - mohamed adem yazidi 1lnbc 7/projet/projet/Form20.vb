Imports System.IO

Public Class Form20

    Dim chemin As String = "abonn.txt"

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox6.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False

        ChargerAbonnes()
    End Sub

    Private Sub ChargerAbonnes()
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("Nom", "Nom")
        DataGridView1.Columns.Add("Prenom", "Prénom")
        DataGridView1.Columns.Add("CIN", "CIN")
        DataGridView1.Columns.Add("DN", "Date Naissance")
        DataGridView1.Columns.Add("Sexe", "Sexe")
        DataGridView1.Columns.Add("Adresse", "Adresse")
        DataGridView1.Columns.Add("Tel", "Téléphone")

        Dim fs As New FileStream(chemin, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim l As String = sr.ReadLine()
            If l.Trim() <> "" Then
                Dim t() As String = l.Split("#"c)
                DataGridView1.Rows.Add(t(0), t(1), t(2), t(3), t(4), t(5), t(6))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim r As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        TextBox1.Text = r.Cells(0).Value.ToString()
        TextBox2.Text = r.Cells(1).Value.ToString()
        TextBox6.Text = r.Cells(2).Value.ToString()
        DateTimePicker1.Value = Date.Parse(r.Cells(3).Value.ToString())
        ComboBox1.Text = r.Cells(4).Value.ToString()
        TextBox3.Text = r.Cells(5).Value.ToString()
        TextBox4.Text = r.Cells(6).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Sélectionnez un abonné à supprimer", vbCritical, "Erreur")
            Exit Sub
        End If

        Dim cin As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()

        If MsgBox("Confirmer la suppression de l'abonné CIN : " & cin & " ?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then Exit Sub

        Dim lines() As String = {}
        Dim count As Integer = 0

        Dim fsRead As New FileStream(chemin, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fsRead)
        While sr.Peek() <> -1
            Dim l As String = sr.ReadLine()
            If l.Trim() <> "" Then
                Dim t() As String = l.Split("#"c)
                If t(2) <> cin Then
                    ReDim Preserve lines(count)
                    lines(count) = l
                    count += 1
                End If
            End If
        End While
        sr.Close()
        fsRead.Close()

        Dim fsWrite As New FileStream(chemin, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fsWrite)
        For i As Integer = 0 To lines.Length - 1
            sw.WriteLine(lines(i))
        Next
        sw.Close()
        fsWrite.Close()

        MsgBox("Abonné supprimé avec succès", vbInformation, "Succès")

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1

        ChargerAbonnes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub
End Class
