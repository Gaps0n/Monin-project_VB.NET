Imports MONIN_CONTACT.dbconnect
Imports MONIN_CONTACT.FrmContact
Imports System.Data.SqlClient
Public Class FrmAddContact
    Dim IdEnt As Integer
    Dim TContact As String


    Private Sub FrmAddContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''ComboBoxEntrepriseDisplay'''''''''''''
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
        ''''''''''''''''''''''''END ComboBoxEntrepriseDisplay''''''''''''''
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale = '" & cbEntreprise.Text & "'"
        reader = cmd.ExecuteReader()
        reader.Read()

        IdEnt = reader.GetValue(0)

        reader.Close()
        cnn.Close()

        If tbNom.Text = "" Or tbPrenom.Text = "" Or tbMail.Text = "" Or tbTelInterne.Text = "" Or cbEntreprise.Text = "" Or cbTitre.Text = "" Then
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

            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "INSERT INTO CONTACT(Titre, NomContact, PrenomContact, MailCOntact, TelInterneContact, TelPortable, idEntreprise)
                               VALUES('" & TContact & "','" & tbNom.Text & "',
                                      '" & tbPrenom.Text & "','" & tbMail.Text & "',
                                      '" & tbTelInterne.Text & "','" & tbTelPortable.Text & "',
                                      '" & IdEnt & "')"
                cmd.ExecuteNonQuery()
                cnn.Close()

                MsgBox("Ajout réussi", vbOKOnly & vbInformation, "Information")
                FrmContact.RefreshContact()
                tbNom.Clear()
                cbTitre.Text = ""
                tbPrenom.Clear()
                tbMail.Clear()
                tbTelInterne.Clear()
                tbTelPortable.Clear()
                cbEntreprise.Text = ""
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub cbTitre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTitre.SelectedIndexChanged
        If cbTitre.Text = "Monsieur" Then
            TContact = "Mr"
        Else
            TContact = "Mme"
        End If
    End Sub
End Class