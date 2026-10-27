Imports System.IO

Public Class Form12

    Private planPath As String = "plan.txt"

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffInfo()
        LoadStaffActivities()
    End Sub

    Private Sub LoadStaffInfo()
        If TypeOf Me.Owner Is Form11 Then
            Dim f11 As Form11 = CType(Me.Owner, Form11)
            Label1.Text = f11.StaffCIN
            Label3.Text = f11.StaffName
            Label6.Text = f11.StaffLastName
        End If
    End Sub

    Private Sub LoadStaffActivities()
        DataGridView1.Rows.Clear()

        Dim fs As New FileStream(planPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)

        Dim staffName As String = Label3.Text.Trim()
        Dim staffLastName As String = Label6.Text.Trim()

        While sr.Peek() <> -1
            Dim line As String = sr.ReadLine()
            If line = "" Then Continue While

            Dim parts() As String = line.Split("#"c)
            If parts.Length >= 5 Then
                Dim planNomPrenom As String = parts(0).Trim()
                Dim planNom As String = ""
                Dim planLastName As String = ""

                Dim splitName() As String = planNomPrenom.Split(" "c)
                If splitName.Length >= 2 Then
                    planNom = splitName(0)
                    planLastName = splitName(1)
                End If

                If planNom = staffName And planLastName = staffLastName Then
                    DataGridView1.Rows.Add(parts(1), parts(2), parts(3), parts(4))
                End If
            End If
        End While

        sr.Close()
        fs.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Application.Exit()
    End Sub

End Class
