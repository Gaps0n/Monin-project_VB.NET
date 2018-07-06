Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class Form_nouveauProduit

    Private Sub BtnAjout_Click(sender As Object, e As EventArgs) Handles BtnAjout.Click
        Dim cnn As SqlConnection
        Dim idGamme As Integer


        cnn.Open()
        'recupérer l'identifiant de la gamme choisie

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO PRODUIT (libProduit, descProduit, photo, PUProduit, idGamme) Values ('" & TBNom.Text & "','" & TBDesc.Text & "','" & TBPhoto.Text & "'," & TBPrix.Text & "," & idGamme & ")"
        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Close()
        cnn.Close()

        MessageBox.Show("Produit ajouté")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select idGamme From Gamme where libGamme like'" & CBGamme2.Text & "'"
        Dim reader = cmd.ExecuteReader()
        reader.Read()

        idGamme = reader.GetValue(0)

        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Close()
    End Sub

    Private Sub Form_nouveauProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select libGamme FROM GAMME "
        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            CBGamme2.Items.Add(JeuEnr.GetValue(0))
        End While

        cnn.Close()
    End Sub
End Class
