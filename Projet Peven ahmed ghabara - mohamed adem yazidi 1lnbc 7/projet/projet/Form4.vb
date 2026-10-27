Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form4

    Dim staffPath As String = "staff.txt"
    Dim payPath As String = "paystaff.txt"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        Dim payDict As New Dictionary(Of String, String)

        Dim fsPay As New FileStream(payPath, FileMode.Open, FileAccess.Read)
        Dim srPay As New StreamReader(fsPay)
        While srPay.Peek() <> -1
            Dim l As String = srPay.ReadLine()
            Dim p() As String = l.Split(";"c)
            If p.Length = 2 Then payDict(p(0)) = p(1)
        End While
        srPay.Close()
        fsPay.Close()

        Dim fsStaff As New FileStream(staffPath, FileMode.Open, FileAccess.Read)
        Dim srStaff As New StreamReader(fsStaff)
        While srStaff.Peek() <> -1
            Dim l As String = srStaff.ReadLine()
            Dim p() As String = l.Split(";"c)
            If p.Length < 7 Then Continue While

            Dim nom As String = p(0)
            Dim prenom As String = p(1)
            Dim cin As String = p(2)
            Dim prof As String = p(6)

            If TextBox1.Text <> "" AndAlso Not nom.ToLower.Contains(TextBox1.Text.ToLower) Then Continue While
            If TextBox2.Text <> "" AndAlso Not prenom.ToLower.Contains(TextBox2.Text.ToLower) Then Continue While
            If TextBox3.Text <> "" AndAlso Not cin.Contains(TextBox3.Text) Then Continue While

            Dim etat As String = "Non payé"
            Dim dateAff As String = "____"

            If payDict.ContainsKey(cin) AndAlso payDict(cin) = Today.ToString("MM/yyyy") Then
                etat = "Payé"
                dateAff = Today.ToString("MM/yyyy")
            End If

            If RadioButton2.Checked And etat = "Payé" Then Continue While

            DataGridView1.Rows.Add(nom, prenom, cin, prof, etat, dateAff)
        End While
        srStaff.Close()
        fsStaff.Close()

        UpdateTotal()
    End Sub

    Private Function Salary(prof As String) As Integer
        Select Case prof.ToLower
            Case "coach" : Return 1500
            Case "manager" : Return 1800
            Case "réceptionniste" : Return 1000
            Case "nutritionniste", "infirmier", "technicien" : Return 1200
        End Select
        Return 0
    End Function

    Private Sub UpdateTotal()
        Dim total As Integer = 0
        For Each r As DataGridViewRow In DataGridView1.Rows
            If r.Cells(4).Value = "Non payé" Then
                total += Salary(r.Cells(3).Value.ToString())
            End If
        Next
        Label7.Text = total & " DT"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim r = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = r.Cells(0).Value.ToString()
        TextBox2.Text = r.Cells(1).Value.ToString()
        TextBox3.Text = r.Cells(2).Value.ToString()
        Label5.Text = Salary(r.Cells(3).Value.ToString()) & " DT"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Sélectionner un staff", vbCritical)
            Exit Sub
        End If

        Dim r = DataGridView1.CurrentRow

        If r.Cells(4).Value.ToString() = "Payé" Then
            MsgBox("Ce staff est déjà payé pour ce mois", vbExclamation)
            ClearSelection()
            Exit Sub
        End If

        PayStaff(r.Cells(2).Value.ToString())
        MsgBox("Paiement effectué avec succès", vbInformation)
        LoadGrid()
        ClearSelection()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim found As Boolean = False

        For Each r As DataGridViewRow In DataGridView1.Rows
            If r.Cells(4).Value.ToString() = "Non payé" Then
                PayStaff(r.Cells(2).Value.ToString())
                found = True
            End If
        Next

        If Not found Then
            MsgBox("Aucun staff non payé", vbExclamation)
            ClearSelection()
            Exit Sub
        End If

        MsgBox("Tous les staffs affichés non payés ont été payés", vbInformation)
        LoadGrid()
        ClearSelection()
    End Sub

    Private Sub ClearSelection()
        DataGridView1.ClearSelection()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label5.Text = ""
    End Sub

    Private Sub PayStaff(cin As String)
        Dim lines As New List(Of String)

        Dim fsRead As New FileStream(payPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fsRead)
        While sr.Peek() <> -1
            Dim l As String = sr.ReadLine()
            If Not l.StartsWith(cin & ";") Then lines.Add(l)
        End While
        sr.Close()
        fsRead.Close()

        lines.Add(cin & ";" & Today.ToString("MM/yyyy"))

        Dim fsWrite As New FileStream(payPath, FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fsWrite)
        For Each l As String In lines
            sw.WriteLine(l)
        Next
        sw.Close()
        fsWrite.Close()
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) _
        Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
        LoadGrid()
    End Sub

    Private Sub TextBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles TextBox1.KeyPress, TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        LoadGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

End Class
