Imports System.IO

Public Class Form16

    Dim filePathPlan As String = "plan.txt"
    Dim filePathStaff As String = "staff.txt"
    Dim filePathAct As String = "act.txt"
    Dim selectedPlan As String = ""

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlan()
        LoadAllCoaches()
        LoadAllActivities()
        ListBox1.SelectionMode = SelectionMode.One
        ListBox2.SelectionMode = SelectionMode.One
        ListBox1.Enabled = False
        ListBox2.Enabled = False
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub LoadPlan()
        DataGridView1.Rows.Clear()
        Dim fs As New FileStream(filePathPlan, FileMode.OpenOrCreate, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim parts() As String = sr.ReadLine().Split("#"c)
            If parts.Length = 5 Then
                Dim planDate As Date = Date.Parse(parts(3))
                Dim planTime As Date = Date.Parse(parts(4))
                If planDate > Today Or (planDate = Today And planTime.TimeOfDay >= Now.TimeOfDay) Then
                    DataGridView1.Rows.Add(parts(0), parts(1), parts(2), parts(3), parts(4))
                End If
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub LoadAllCoaches()
        ListBox1.Items.Clear()
        Dim fs As New FileStream(filePathStaff, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim t() As String = sr.ReadLine().Split(";"c)
            If t.Length = 7 And t(6) = "Coach" Then
                ListBox1.Items.Add(t(0) & " " & t(1))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub LoadAllActivities()
        ListBox2.Items.Clear()
        Dim fs As New FileStream(filePathAct, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim parts() As String = sr.ReadLine().Split("#"c)
            If parts.Length = 4 And parts(1) = "Cours collectif" Then
                ListBox2.Items.Add(parts(0))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub

        selectedPlan = DataGridView1.Rows(e.RowIndex).Cells(0).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(2).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(3).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(4).Value

        Dim coach = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        Dim act = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim salle = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        Dim planDate = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString())
        Dim planTime = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString())

        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).ToString() = coach Then
                ListBox1.SelectedIndex = i
                Exit For
            End If
        Next

        For i = 0 To ListBox2.Items.Count - 1
            If ListBox2.Items(i).ToString() = act Then
                ListBox2.SelectedIndex = i
                Exit For
            End If
        Next

        ComboBox1.Text = salle
        DateTimePicker1.Value = planDate
        DateTimePicker2.Value = planTime
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedPlan = "" Then
            MsgBox("Sélectionner un planning à supprimer.", vbCritical)
            Exit Sub
        End If

        Dim result = MsgBox("Voulez-vous vraiment supprimer ce planning ?", vbYesNo + vbQuestion)
        If result = vbNo Then Exit Sub

        Dim lines() As String = {}
        Dim count As Integer = 0

        Dim fslire As New FileStream(filePathPlan, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fslire)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            If line.Trim() <> selectedPlan Then
                ReDim Preserve lines(count)
                lines(count) = line
                count += 1
            End If
        End While
        sr.Close()
        fslire.Close()

        Dim fs As New FileStream(filePathPlan, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        For Each l As String In lines
            sw.WriteLine(l)
        Next
        sw.Close()
        fs.Close()

        MsgBox("Planning supprimé avec succès.", vbInformation)
        selectedPlan = ""
        LoadPlan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
