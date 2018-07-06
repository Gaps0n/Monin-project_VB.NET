Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmUpdateEntreprise
    Dim codePays As String
    Dim idEnt As Integer
    Private Sub FrmUpdateEntreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM ENTREPRISE WHERE RaisonSociale = '" & FrmEntreprise.dgEntreprise.CurrentRow.Cells(1).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        idEnt = reader.GetValue(0)
        tbNom.Text = reader.GetValue(1)
        tbAdr.Text = reader.GetValue(2)
        tbCp.Text = reader.GetValue(3)
        tbVille.Text = reader.GetValue(4)
        tbTel.Text = reader.GetValue(5)
        tbMail.Text = reader.GetValue(6)
        codePays = reader.GetValue(7)

        reader.Close()
        cnn.Close()

        ''''''''''''''''''''''''ComboBoxPaysDisplay'''''''''''''
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

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libPays FROM PAYS WHERE CodePays = '" & codePays & "'"
        reader = cmd.ExecuteReader()
        reader.Read()

        cbPays.Text = reader.GetValue(0)

        reader.Close()
        cnn.Close()
        ''''''''''''''''''''''''END ComboBoxPaysDisplay''''''''''''''
    End Sub

    Private Sub btnValid_Click_1(sender As Object, e As EventArgs) Handles btnValid.Click
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
            cmd.CommandText = "UPDATE ENTREPRISE SET RaisonSociale = '" & tbNom.Text & "', AdresseRue = '" & tbAdr.Text & "',
                                                 CodePostal = '" & tbCp.Text & "', Ville = '" & tbVille.Text & "',
                                                 TelStandard = '" & tbTel.Text & "', Mail = '" & tbMail.Text & "',
                                                 CodePays = '" & codePays & "'
                                             WHERE IdEntreprise = '" & idEnt & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Modification réussi", vbOKOnly & vbInformation, "Information")
            FrmEntreprise.RefreshEntreprise()

            Me.Hide()
        End If
    End Sub
End Class