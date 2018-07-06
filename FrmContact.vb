Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmContact
    Dim IdEnt As Integer
    Dim RS As String
    Dim dgActionIndex As DataGridViewRow
    Private Sub FrmContact_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''' DataGridView Contact '''
        dgContact.ColumnCount = 8
        dgContact.ColumnHeadersVisible = True
        dgContact.Columns(0).Visible = False

        dgContact.Columns(1).Name = "Titre"
        dgContact.Columns(2).Name = "Nom"
        dgContact.Columns(3).Name = "Prénom"
        dgContact.Columns(4).Name = "Mail"
        dgContact.Columns(5).Name = "Tel interne"
        dgContact.Columns(6).Name = "Tel portable"
        dgContact.Columns(7).Name = "Entreprise"
        '''End DataGridView Contact '''

        ''' DataGridView Action '''
        dgAction.ColumnCount = 6
        dgAction.ColumnHeadersVisible = True
        dgAction.Columns(0).Visible = False

        dgAction.Columns(1).Name = "Date Action"
        dgAction.Columns(2).Name = "Commentaire"
        dgAction.Columns(3).Name = "A Relancer"
        dgAction.Columns(4).Name = "Date de Relance"
        dgAction.Columns(5).Name = "Type D'action"
        '''End DataGridView Action '''

        RefreshContact()
        cboEntreprise.Text = "Tous les contacts"

        ''' CbEntreprise load content '''
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cboEntreprise.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()
        '''END CbEntreprise load content '''

        '''LoadAction '''
        If (cnn.State = ConnectionState.Closed) Then
            dgAction.Rows.Clear()
            dgAction.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While

            dgAction.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
        '''END LoadAction '''
    End Sub
    ''' Filtre combobox entreprise '''
    Private Sub cboEntreprise_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
    '''End Filtre combobox entreprise '''

    ''' Sub refresh datagridview '''
    Public Sub RefreshContact()
        cnn = New SqlConnection(connectionString)
        dgContact.Rows.Clear()
        dgContact.Refresh()
        dgAction.Rows.Clear()
        cnn.Close()

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdContact, Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise"
        reader = cmd.ExecuteReader()

        While reader.Read
            dgContact.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
        End While

        reader.Close()
        cnn.Close()
    End Sub
    ''' End Sub refresh datagridview '''

    ''' Search txtBox contact '''
    Private Sub tbClient_TextChanged(sender As Object, e As EventArgs) Handles tbClient.TextChanged
        cboEntreprise.Text = "Tous les contacts"
        dgContact.Rows.Clear()
        dgContact.Refresh()
        dgAction.Rows.Clear()
        dgAction.Refresh()

        If (cnn.State = ConnectionState.Closed) Then
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdContact, Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise AND NomContact like '" & tbClient.Text & "%'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgContact.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
            End While

            reader.Close()
            cnn.Close()
        End If

        If (cnn.State = ConnectionState.Closed And dgContact.RowCount > 0) Then
            dgAction.Rows.Clear()
            dgAction.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While

            dgAction.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
    End Sub
    ''' End Search txtBox contact '''

    ''' Remove Filtre Entreprise '''
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        cboEntreprise.Text = ""
        RefreshContact()
    End Sub
    '''End Remove Filtre Entreprise '''

    ''' On select row on datagridview contact '''
    Private Sub dgContact_SelectionChanged(sender As Object, e As EventArgs) Handles dgContact.SelectionChanged
        If (cnn.State = ConnectionState.Closed) Then
            dgAction.Rows.Clear()
            dgAction.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While

            dgAction.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
    End Sub
    ''' End On select row on datagridview contact '''

    ''' Btn Add Contact '''
    Private Sub btnAddContact_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click
        FrmAddContact.Show()
    End Sub
    ''' End Btn Add Contact '''

    ''' Btn Update Contact '''
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgContact.RowCount > 0 Then
            FrmUpdateContact.Show()
        Else
            MsgBox("Veuillez sélectionné un contact", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Update Contact '''

    ''' Btn Del Contact '''
    Private Sub btnDelContact_Click(sender As Object, e As EventArgs) Handles btnDelContact.Click
        If dgContact.RowCount > 0 Then
            Dim response = MsgBox("Voulez-vous vraiment supprimer le contact ?", vbCritical + vbYesNo, "Attention /!\")
            If (response = vbYes) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM CONTACT WHERE IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
                cmd.ExecuteNonQuery()
                cnn.Close()
                RefreshContact()
            End If
        Else
            MsgBox("Veuillez sélectionné un contact", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Del Contact '''

    '''Btn Add Action '''
    Private Sub btnAddAction_Click(sender As Object, e As EventArgs) Handles btnAddAction.Click
        FrmAddAction.Show()
    End Sub
    ''' End Btn Add Action '''

    ''' Btn Del Action '''
    Private Sub BtnDelAction_Click(sender As Object, e As EventArgs) Handles BtnDelAction.Click
        If dgAction.RowCount > 0 Then
            Dim response = MsgBox("Voulez-vous vraiment supprimer l'action sélectionné ?", vbCritical + vbYesNo, "Attention /!\")
            If (response = vbYes) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM ACTION WHERE IdAction = '" & dgAction.CurrentRow.Cells(0).Value & "'"
                cmd.ExecuteNonQuery()
                cnn.Close()
                dgActionIndex = dgAction.CurrentRow
                dgAction.Rows.Remove(dgActionIndex)
            End If
        Else
            MsgBox("Veuillez sélectionné une action", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Del Action '''

    Private Sub dgContact_Click(sender As Object, e As EventArgs) Handles dgContact.Click
        If (cnn.State = ConnectionState.Closed) Then
            dgAction.Rows.Clear()
            dgAction.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While

            dgAction.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
    End Sub
    ''' Btn Update Contact '''
    Private Sub btnEditAction_Click(sender As Object, e As EventArgs) Handles btnEditAction.Click
        If dgAction.RowCount > 0 Then
            FrmUpdateAction.Show()
        Else
            MsgBox("Veuillez sélectionné une action", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub

    Private Sub cboEntreprise_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboEntreprise.SelectedIndexChanged
        dgContact.Rows.Clear()
        dgContact.Refresh()
        dgAction.Rows.Clear()
        dgAction.Refresh()
        If cboEntreprise.Text = "Tous les contacts" Then
            RefreshContact()
        Else
            '''SELECT IdEnt '''
            Try
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale = '" & cboEntreprise.Text & "'"
                reader = cmd.ExecuteReader()
                reader.Read()
                IdEnt = reader.GetValue(0)
                reader.Close()
                cnn.Close()
            Catch ex As Exception

            End Try
            '''END SELECT IdEnt '''

            '''Content datagridview contact '''
            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT IdContact, Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise AND C.IdEntreprise = '" & IdEnt & "'"
                reader = cmd.ExecuteReader()

                While (reader.Read)
                    dgContact.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
                End While
                reader.Close()
                cnn.Close()
            End If
            '''END Content datagridview contact '''

            '''Content datagridview action '''
            If (cnn.State = ConnectionState.Closed) Then

                Try
                    dgAction.Rows.Clear()
                    dgAction.Refresh()
                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & dgContact.CurrentRow.Cells(0).Value & "'"
                    reader = cmd.ExecuteReader()

                    While reader.Read
                        dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
                    End While

                    dgAction.AutoResizeColumns()
                    reader.Close()
                    cnn.Close()
                Catch ex As Exception

                End Try
            End If
            '''END Content datagridview action '''
        End If
    End Sub
    ''' End Btn Update Contact '''
End Class