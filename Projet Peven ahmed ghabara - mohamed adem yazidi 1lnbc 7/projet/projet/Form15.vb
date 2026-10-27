Imports System.IO

Public Class Form15

    Dim filePathPlan As String = "plan.txt"
    Dim filePathStaff As String = "staff.txt"
    Dim filePathAct As String = "act.txt"
    Dim selectedPlan As String = ""

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCoaches()
        LoadActivities()
        LoadPlan()
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "HH:mm"
        DateTimePicker2.ShowUpDown = True
    End Sub

    Private Sub LoadCoaches()
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

    Private Sub LoadActivities()
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        ListBox1.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        ListBox2.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        DateTimePicker1.Value = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString())
        DateTimePicker2.Value = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString())
        selectedPlan = DataGridView1.Rows(e.RowIndex).Cells(0).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(2).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(3).Value & "#" & DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()
        If selectedPlan = "" Then
            MsgBox("Sélectionner un planning à modifier.", vbCritical)
            Exit Sub
        End If
        Dim errors As New List(Of String)

        If ListBox1.SelectedIndex = -1 Then
            errors.Add("Sélectionner un coach.")
            ListBox1.BackColor = Color.MistyRose
        End If
        If ListBox2.SelectedIndex = -1 Then
            errors.Add("Sélectionner une activité.")
            ListBox2.BackColor = Color.MistyRose
        End If
        If ComboBox1.SelectedIndex = -1 Then
            errors.Add("Sélectionner une salle.")
            ComboBox1.BackColor = Color.MistyRose
        End If

        Dim selDate As Date = DateTimePicker1.Value.Date
        Dim selTime As Date = DateTimePicker2.Value

        If selDate < Today Then
            errors.Add("La date ne peut pas être dans le passé.")
            DateTimePicker1.CalendarMonthBackground = Color.MistyRose
        End If
        If selDate = Today And selTime.TimeOfDay < Now.TimeOfDay Then
            errors.Add("L'heure ne peut pas être dans le passé.")
            DateTimePicker2.CalendarMonthBackground = Color.MistyRose
        End If
        If selTime.Hour >= 0 And selTime.Hour < 5 Then
            errors.Add("L'heure ne peut pas être entre 00:00 et 05:00.")
            DateTimePicker2.CalendarMonthBackground = Color.MistyRose
        End If

        If errors.Count > 0 Then
            MsgBox(String.Join(vbCrLf, errors), vbCritical)
            Exit Sub
        End If

        Dim newPlan As String = ListBox1.SelectedItem & "#" & ListBox2.SelectedItem & "#" & ComboBox1.Text & "#" & selDate.ToShortDateString() & "#" & selTime.ToShortTimeString()
        Dim lines As New List(Of String)
        Dim fs As New FileStream(filePathPlan, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If line = selectedPlan Then

            ElseIf parts.Length = 5 Then
                Dim eDate As Date = Date.Parse(parts(3))
                Dim eTime As Date = Date.Parse(parts(4))
                Dim eSalle As String = parts(2)
                If eSalle = ComboBox1.Text And eDate = selDate And eTime.TimeOfDay = selTime.TimeOfDay Then
                    sr.Close()
                    fs.Close()
                    MsgBox("Cette salle est déjà occupée à cette date et heure.", vbCritical)
                    Exit Sub
                End If
            End If
            lines.Add(line)
        End While
        sr.Close()
        fs.Close()

        For i = 0 To lines.Count - 1
            If lines(i) = selectedPlan Then
                lines(i) = newPlan
                Exit For
            End If
        Next

        Dim fs1 As New FileStream(filePathPlan, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs1)
        For Each l As String In lines
            sw.WriteLine(l)
        Next
        sw.Close()
        fs1.Close()

        MsgBox("Planning modifié avec succès.", vbInformation)
        LoadPlan()
    End Sub



    Private Sub ResetColors()
        ListBox1.BackColor = Color.White
        ListBox2.BackColor = Color.White
        ComboBox1.BackColor = Color.White
        DateTimePicker1.CalendarMonthBackground = Color.White
        DateTimePicker2.CalendarMonthBackground = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
