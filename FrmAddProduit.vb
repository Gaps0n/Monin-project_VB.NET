Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect

Public Class FrmAddProduit
    Dim a As String
    Dim EtatPhoto As Boolean = False
    Private Sub FrmAddProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM GAMME"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cbGamme.Items.Add(reader.GetValue(1))
        End While
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        Dim IdGamme As Integer

        If tbNom.Text = "" Or tbDesc.Text = "" Or tbPrix.Text = "" Or cbGamme.Text = "" Then
            lblMsg.Text = "Erreur : Champs vides"
            lblMsg.ForeColor = Color.Red
        ElseIf IsNumeric(tbPrix.Text) = False Then
            lblMsg.Text = "Erreur : Le champ prix doit être un numérique"
            lblMsg.ForeColor = Color.Red
        ElseIf PictureBox1.ImageLocation = "" Then
            lblMsg.Text = "Erreur : Veuillez sélectionner une photo"
            lblMsg.ForeColor = Color.Red
        Else
            tbNom.Text = tbNom.Text.Replace("'", "''")
            tbDesc.Text = tbDesc.Text.Replace("'", "''")
            tbPrix.Text = tbPrix.Text.Replace("'", "''")

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT idGamme FROM GAMME WHERE libGamme = '" & cbGamme.Text & "'"
            reader = cmd.ExecuteReader()
            reader.Read()
            IdGamme = reader.GetValue(0)
            reader.Close()
            cnn.Close()

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO PRODUIT (libProduit, descProduit, photo, PUProduit, idGamme) Values('" & tbNom.Text & "','" & tbDesc.Text & "','" & Dir(a) & "'," & tbPrix.Text & "," & IdGamme & ")"
            cmd.ExecuteNonQuery()

            reader.Close()
            cnn.Close()

            MsgBox("Ajout réussi", vbOKOnly & vbInformation, "Information")
            FrmProduit.RefreshProduit()
            Me.Close()
        End If
    End Sub

    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Choisissez une image"
        openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.ShowDialog()
        a = openFileDialog1.FileName
        If a <> "" Then
            My.Computer.FileSystem.CopyFile(a, path & Dir(a), overwrite:=True)
            PictureBox1.ImageLocation = path & Dir(a)
        End If
    End Sub
End Class