Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Imports MONIN_CONTACT.FrmEntreprise
Public Class FrmAddEntreprise
    Dim CodePays As String
    Private Sub FrmAddEntreprise_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''''''''''''''''''''''''ComboBoxPaysDisplay'''''''''''''
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libPays FROM PAYS"
        reader = cmd.ExecuteReader()

        While (reader.Read)
            cbPays.Items.Add(reader.GetValue(0))
        End While

        reader.Close()
        cnn.Close()
        ''''''''''''''''''''''''END ComboBoxPaysDisplay''''''''''''''
    End Sub

    ''''''''''''''''''''''''AddEntreprise''''''''''''''''''''''''
    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        If tbNom.Text = "" Or tbAdr.Text = "" Or tbCp.Text = "" Or tbMail.Text = "" Or tbVille.Text = "" Or tbTel.Text = "" Or cbPays.Text = "" Then
            lblMsg.Text = "Erreur : Champs vides"
            lblMsg.ForeColor = Color.Red
        ElseIf IsEmail(tbMail.Text) = False Then
            lblMsg.Text = "Erreur : Le format du mail est invalide (mail@mail.com)"
            lblMsg.ForeColor = Color.Red
        Else
            tbNom.Text = tbNom.Text.Replace("'", "''")
            tbAdr.Text = tbAdr.Text.Replace("'", "''")
            tbMail.Text = tbMail.Text.Replace("'", "''")
            tbCp.Text = tbCp.Text.Replace("'", "''")
            tbVille.Text = tbVille.Text.Replace("'", "''")
            tbTel.Text = tbTel.Text.Replace("'", "''")

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO ENTREPRISE(RaisonSociale, AdresseRue, CodePostal, Ville, TelStandard, Mail, CodePays)
                               VALUES('" & tbNom.Text & "','" & tbAdr.Text & "',
                                      '" & tbCp.Text & "','" & tbVille.Text & "',
                                      '" & tbTel.Text & "','" & tbMail.Text & "',
                                      '" & CodePays & "')"
            cmd.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Ajout réussi", vbOKOnly & vbInformation, "Information")
            FrmEntreprise.RefreshEntreprise()

            tbNom.Clear()
            tbAdr.Clear()
            tbCp.Clear()
            tbVille.Clear()
            tbTel.Clear()
            tbMail.Clear()
            cbPays.Text = ""
            Me.Hide()
        End If
    End Sub
    '''''''''''''''''''''''' END AddEntreprise''''''''''''''''''''''''

    '''''''''''''''''''''''SelectCodePaysOflibPays''''''''''''''''''''
    Private Sub cbPays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPays.SelectedIndexChanged
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT CodePays FROM PAYS WHERE libPays = '" & cbPays.Text & "'"
        reader = cmd.ExecuteReader()
        reader.Read()

        CodePays = reader.GetValue(0)

        reader.Close()
        cnn.Close()
    End Sub
    '''''''''''''''''''''''END SelectCodePaysOflibPays''''''''''''''''

End Class