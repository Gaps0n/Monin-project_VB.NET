Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect

Public Class FrmUpdateProduit
    Dim PhotoLib As String
    Dim a As String
    Private Sub FrmUpdateProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libProduit, descProduit, PUProduit, libGamme, photo FROM PRODUIT P, GAMME G WHERE P.idGamme = G.idGamme AND P.idProduit = '" & FrmProduit.dgProduit.CurrentRow.Cells(0).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        tbNom.Text = reader.GetValue(0)
        tbDesc.Text = reader.GetValue(1)
        tbPrix.Text = reader.GetValue(2)
        cbGamme.Text = reader.GetValue(3)
        PhotoLib = reader.GetValue(4)

        reader.Close()
        cnn.Close()

        PictureBox1.ImageLocation = path & PhotoLib
    End Sub

    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Reset()
        openFileDialog1.Title = "Choisissez une image"
        openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.ShowDialog()
        a = openFileDialog1.FileName
        If a <> "" Then
            PhotoLib = Dir(a)
            My.Computer.FileSystem.CopyFile(a, path & PhotoLib, overwrite:=True)
            PictureBox1.ImageLocation = path & PhotoLib
        End If
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
            cmd.CommandText = "UPDATE PRODUIT SET libProduit = '" & tbNom.Text & "' , descProduit = '" & tbDesc.Text & "', photo = '" & PhotoLib & "', PUProduit = '" & tbPrix.Text & "', idGamme = '" & IdGamme & "' WHERE idProduit = '" & FrmProduit.dgProduit.CurrentRow.Cells(0).Value & "'"
            cmd.ExecuteNonQuery()
            reader.Close()
            cnn.Close()

            MsgBox("Modification réussi", vbOKOnly & vbInformation, "Information")
            FrmProduit.RefreshProduit()
            Me.Close()
        End If
    End Sub
End Class