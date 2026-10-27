Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3

    Private paimentPath As String = "paiment.txt"
    Private abonnPath As String = "abonn.txt"
    Private actPath As String = "act.txt"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Dim fs As New FileStream(paimentPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim fs1 As New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
        Dim sr1 As New StreamReader(fs1)
        Dim s, s1 As String
        Dim t(), t1() As String
        DataGridView1.Rows.Clear()
        TextBox6.Clear()
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            sr1.Close()
            fs1.Close()
            fs1 = New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
            sr1 = New StreamReader(fs1)
            While sr1.Peek > -1
                s1 = sr1.ReadLine
                t1 = s1.Split("#")
                If t1(2) = t(0) Then
                    DataGridView1.Rows.Add(t1(0), t1(1), t(0), t1(3), t1(4), t(1), t(2), t(3))
                End If
            End While
        End While
        sr.Close()
        fs.Close()
        sr1.Close()
        fs1.Close()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Dim fs As New FileStream(paimentPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim fs1 As New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
        Dim sr1 As New StreamReader(fs1)
        Dim s, s1 As String
        Dim t(), t1() As String
        TextBox6.Clear()
        DataGridView1.Rows.Clear()
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            sr1.Close()
            fs1.Close()
            fs1 = New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
            sr1 = New StreamReader(fs1)
            While sr1.Peek > -1
                s1 = sr1.ReadLine
                t1 = s1.Split("#")
                If t1(2) = t(0) Then
                    If t(1).ToLower() = "nonpayé" Then
                        DataGridView1.Rows.Add(t1(0), t1(1), t(0), t1(4), t1(5), t(1), t(2), t(3))
                    End If
                End If
            End While
        End While
        sr.Close()
        fs.Close()
        sr1.Close()
        fs1.Close()
    End Sub

    Private Sub UpdateTotal()
        Dim tot As Double = 60
        Dim pr As Double
        For Each ctrl As Control In GroupBox4.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim checkbo As CheckBox = CType(ctrl, CheckBox)
                If checkbo.Checked Then tot += 10
            ElseIf TypeOf ctrl Is GroupBox Then
                For Each subCtrl As Control In ctrl.Controls
                    If TypeOf subCtrl Is CheckBox Then
                        Dim checkbo As CheckBox = CType(subCtrl, CheckBox)
                        If checkbo.Checked Then tot += 10
                    End If
                Next
            End If
        Next
        For Each ctrl As Control In GroupBox3.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim checkbo As CheckBox = CType(ctrl, CheckBox)
                If checkbo.Checked Then tot += 30
            End If
        Next
        If RadioButton1.Checked Then
            pr = tot * 1
        ElseIf RadioButton2.Checked Then
            pr = tot * 2.7
        ElseIf RadioButton3.Checked Then
            pr = tot * 5.3
        ElseIf RadioButton4.Checked Then
            pr = tot * 10
        End If
        Label5.Text = pr.ToString()
    End Sub

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged, CheckBox13.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox6.Text = "" Then
            MsgBox("Entrer CIN", MsgBoxStyle.Critical, "Attention")
            Exit Sub
        End If
        Dim fs As New FileStream(paimentPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim lines() As String = {}
        Dim s As String
        Dim t() As String
        Dim val As Integer = 0
        Dim count As Integer = 0
        While sr.Peek > -1
            s = sr.ReadLine()
            ReDim Preserve lines(count)
            lines(count) = s
            t = s.Split("#")
            If TextBox6.Text = t(0) And t(1).ToLower() = "payé" Then
                val = 2
            ElseIf TextBox6.Text = t(0) And t(1).ToLower() = "nonpayé" Then
                val = 1
            End If
            count += 1
        End While
        sr.Close()
        fs.Close()
        If val = 2 Then
            MsgBox("Abonnement déjà payé", MsgBoxStyle.Critical, "Attention")
            Exit Sub
        ElseIf val = 0 Then
            MsgBox("CIN non abonnée", MsgBoxStyle.Critical, "Attention")
            Exit Sub
        End If
        Dim today As Date = Date.Today
        Dim duree As Integer = 1
        If RadioButton1.Checked Then duree = 1
        If RadioButton2.Checked Then duree = 3
        If RadioButton3.Checked Then duree = 6
        If RadioButton4.Checked Then duree = 12
        Dim endDate As Date = today.AddMonths(duree)
        Dim montant As Double
        Double.TryParse(Label5.Text, montant)
        For i As Integer = 0 To lines.Length - 1
            t = lines(i).Split("#")
            If TextBox6.Text = t(0) Then
                t(1) = "payé"
                t(2) = today.ToShortDateString()
                t(3) = endDate.ToShortDateString()
                If t.Length >= 5 Then
                    t(4) = montant.ToString()
                Else
                    ReDim Preserve t(4)
                    t(4) = montant.ToString()
                End If
                lines(i) = t(0) & "#" & t(1) & "#" & t(2) & "#" & t(3) & "#" & t(4)
                Exit For
            End If
        Next
        Dim fs9 As New FileStream(paimentPath, FileMode.Create, FileAccess.Write)
        Dim sw9 As New StreamWriter(fs9)
        For i As Integer = 0 To lines.Length - 1
            sw9.WriteLine(lines(i))
        Next
        sw9.Close()
        fs9.Close()
        MsgBox("Paiement validé !", MsgBoxStyle.Information, "Succès")
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub LoadActivityCheckBoxes()
        Dim fs As New FileStream(actPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim startX As Integer = 20
        Dim startY As Integer = 30
        Dim x As Integer = startX
        Dim y As Integer = startY
        Dim countInRow As Integer = 0
        Dim maxPerRow As Integer = 4
        Dim spacingY As Integer = 50
        Dim spacingX As Integer = 200
        While sr.Peek > -1
            Dim line As String = sr.ReadLine()
            Dim t() As String = line.Split("#")
            Dim activityName As String = t(0)
            Dim chk As New CheckBox()
            chk.Text = activityName
            chk.AutoSize = True
            chk.Location = New Point(x, y)
            chk.Font = New Font("Garamond", 16, FontStyle.Bold)
            AddHandler chk.CheckedChanged, AddressOf CheckBoxes_CheckedChanged
            GroupBox2.Controls.Add(chk)
            countInRow += 1
            If countInRow >= maxPerRow Then
                countInRow = 0
                x = startX
                y += spacingY
            Else
                x += spacingX
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActivityCheckBoxes()
        RadioButton1.Checked = True
        RadioButton5.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            TextBox6.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then
            For Each c As Control In GroupBox2.Controls
                If TypeOf c Is CheckBox Then
                    CType(c, CheckBox).Checked = False
                End If
            Next
            For Each c As Control In GroupBox3.Controls
                If TypeOf c Is CheckBox Then
                    CType(c, CheckBox).Checked = False
                End If
            Next
        End If
        TextBox6.Clear()
        Label5.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

End Class
