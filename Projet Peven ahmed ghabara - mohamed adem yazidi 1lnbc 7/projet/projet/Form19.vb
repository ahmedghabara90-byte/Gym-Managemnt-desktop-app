Imports System.IO

Public Class Form19

    Dim abonnPath As String = "abonn.txt"
    Dim insPlanPath As String = "insplan.txt"
    Dim paiementPath As String = "paiment.txt"

    Private cinRecu As String

    Public Sub SetCIN(cin As String)
        cinRecu = cin
    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerAbonne()
        ChargerInscription()
        ChargerPaiement()
    End Sub

    Sub ChargerAbonne()
        Dim fs As New FileStream(abonnPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek <> -1
            Dim ligne As String = sr.ReadLine()
            Dim t() As String = ligne.Split("#"c)
            If t.Length >= 7 AndAlso t(2) = cinRecu Then
                Label3.Text = t(0)
                Label6.Text = t(1)
                Label1.Text = t(2)
                Label11.Text = t(5)
                Label8.Text = t(6)
                Label13.Text = t(3)
                Exit While
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Sub ChargerInscription()
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("act", "Activité")
        DataGridView1.Columns.Add("date", "Date")
        DataGridView1.Columns.Add("heure", "Heure")
        DataGridView1.Columns.Add("salle", "Salle")

        Dim fs As New FileStream(insPlanPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek <> -1
            Dim ligne As String = sr.ReadLine()
            Dim t() As String = ligne.Split("#"c)
            If t.Length >= 6 AndAlso t(0) = cinRecu Then
                DataGridView1.Rows.Add(t(2), t(4), t(5), t(3))
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Sub ChargerPaiement()
        DataGridView2.Rows.Clear()
        DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("dp", "Date paiement")
        DataGridView2.Columns.Add("df", "Date fin")
        DataGridView2.Columns.Add("mt", "Montant")
        DataGridView2.Columns.Add("at", "Autre")

        Dim fs As New FileStream(paiementPath, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek <> -1
            Dim ligne As String = sr.ReadLine()
            Dim t() As String = ligne.Split("#"c)
            If t.Length >= 5 AndAlso t(0) = cinRecu Then
                DataGridView2.Rows.Add(t(2), t(3), t(4), "____")
            End If
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class
