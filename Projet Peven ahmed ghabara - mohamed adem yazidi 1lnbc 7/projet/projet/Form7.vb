Imports System.IO

Public Class Form7

    Dim filePathPlan As String = "plan.txt"
    Dim filePathStaff As String = "staff.txt"
    Dim filePathAct As String = "act.txt"

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetColors()
        Dim errors As New List(Of String)

        If ListBox1.SelectedIndex = -1 Then
            ListBox1.BackColor = Color.MistyRose
            errors.Add("Sélectionner un coach.")
        End If
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.BackColor = Color.MistyRose
            errors.Add("Sélectionner une activité.")
        End If
        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.BackColor = Color.MistyRose
            errors.Add("Sélectionner une salle.")
        End If

        Dim selDate As Date = DateTimePicker1.Value.Date
        Dim selTime As Date = DateTimePicker2.Value

        If selDate < Today Then
            DateTimePicker1.CalendarMonthBackground = Color.MistyRose
            errors.Add("La date ne peut pas être dans le passé.")
        End If
        If selDate = Today And selTime.TimeOfDay < Now.TimeOfDay Then
            DateTimePicker2.CalendarMonthBackground = Color.MistyRose
            errors.Add("L'heure ne peut pas être dans le passé.")
        End If
        If selTime.Hour >= 0 And selTime.Hour < 5 Then
            DateTimePicker2.CalendarMonthBackground = Color.MistyRose
            errors.Add("L'heure ne peut pas être entre 00:00 et 05:00.")
        End If

        If errors.Count > 0 Then
            Dim msg As String = ""
            For Each err As String In errors
                msg &= err & vbCrLf
            Next
            MsgBox(msg, vbCritical)
            Exit Sub
        End If

        Dim fs As New FileStream(filePathPlan, FileMode.OpenOrCreate, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            Dim parts() As String = line.Split("#"c)
            If parts.Length = 5 Then
                Dim existingDate As Date = Date.Parse(parts(3))
                Dim existingTime As Date = Date.Parse(parts(4))
                Dim existingSalle As String = parts(2)
                If existingSalle = ComboBox1.Text And existingDate = selDate And existingTime.TimeOfDay = selTime.TimeOfDay Then
                    sr.Close()
                    fs.Close()
                    MsgBox("Cette salle est déjà occupée à cette date et heure.", vbCritical)
                    Exit Sub
                End If
            End If
        End While
        sr.Close()
        fs.Close()

        Dim fsWrite As New FileStream(filePathPlan, FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fsWrite)
        sw.WriteLine(ListBox1.SelectedItem & "#" & ListBox2.SelectedItem & "#" & ComboBox1.Text & "#" & selDate.ToShortDateString() & "#" & selTime.ToShortTimeString())
        sw.Close()
        fsWrite.Close()

        MsgBox("Planning ajouté avec succès.", vbInformation)
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
