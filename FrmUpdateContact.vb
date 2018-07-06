Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Imports MONIN_CONTACT.FrmContact

Public Class FrmUpdateContact
    Dim IdContact As Integer
    Dim IdEnt As Integer
    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        If tbNom.Text = "" Or tbPrenom.Text = "" Or tbMail.Text = "" Or tbTelInterne.Text = "" Or tbTelPortable.Text = "" Or cbEntreprise.Text = "" Or cbTitre.Text = "" Then
            lblMsg.Text = "Erreur : Champs vides"
            lblMsg.ForeColor = Color.Red
        ElseIf IsEmail(tbMail.Text) = False Then
            lblMsg.Text = "Erreur : Le format du mail est invalide (mail@mail.com)"
            lblMsg.ForeColor = Color.Red
        Else
            tbNom.Text = tbNom.Text.Replace("'", "''")
            tbPrenom.Text = tbPrenom.Text.Replace("'", "''")
            tbMail.Text = tbMail.Text.Replace("'", "''")
            tbTelInterne.Text = tbTelInterne.Text.Replace("'", "''")
            tbTelPortable.Text = tbTelPortable.Text.Replace("'", "''")

            cnn = New SqlConnection(connectionString)

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale = '" & cbEntreprise.Text & "'"
            reader = cmd.ExecuteReader()
            reader.Read()
            IdEnt = reader.GetValue(0)
            reader.Close()
            cnn.Close()


            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE CONTACT SET Titre = '" & cbTitre.Text & "', NomContact = '" & tbNom.Text & "',
                                                 PrenomContact = '" & tbPrenom.Text & "', MailContact = '" & tbMail.Text & "',
                                                 TelInterneContact = '" & tbTelInterne.Text & "', TelPortable = '" & tbTelPortable.Text & "',
                                                 IdEntreprise = '" & IdEnt & "'
                                             WHERE IdContact = '" & IdContact & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Modification réussi", vbOKOnly & vbInformation, "Information")
            FrmContact.RefreshContact()
            tbNom.Text = ""
            tbPrenom.Text = ""
            tbMail.Text = ""
            tbTelInterne.Text = ""
            tbTelPortable.Text = ""
            cbEntreprise.Text = ""
            cbTitre.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub FrmUpdateContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cbEntreprise.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdContact, Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE E.IdEntreprise = C.IdEntreprise AND IdContact = '" & FrmContact.dgContact.CurrentRow.Cells(0).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        IdContact = reader.GetValue(0)
        cbTitre.Text = reader.GetValue(1)
        tbNom.Text = reader.GetValue(2)
        tbPrenom.Text = reader.GetValue(3)
        tbMail.Text = reader.GetValue(4)
        tbTelInterne.Text = reader.GetValue(5)
        tbTelPortable.Text = reader.GetValue(6)
        cbEntreprise.Text = reader.GetValue(7)

        reader.Close()
        cnn.Close()

    End Sub
End Class