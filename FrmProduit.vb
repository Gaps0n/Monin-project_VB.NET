Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmProduit
    Dim idGa As Integer
    Dim RS As String
    Dim dgRecetteIndex As DataGridViewRow
    Dim nomPhoto As String
    Private Sub Form_Produit_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''' DataGridView Produit '''
        dgProduit.ColumnCount = 6
        dgProduit.ColumnHeadersVisible = True
        dgProduit.Columns(0).Visible = False
        dgProduit.Columns(3).Visible = False

        dgProduit.Columns(1).Name = "Libellé"
        dgProduit.Columns(2).Name = "Description"
        dgProduit.Columns(3).Name = "Photo"
        dgProduit.Columns(4).Name = "Prix unitaire"
        dgProduit.Columns(5).Name = "Gamme"
        '''End DataGridView Produit '''

        ''' DataGridView Recette '''
        dgRecette.ColumnCount = 3
        dgRecette.ColumnHeadersVisible = True
        dgRecette.Columns(0).Visible = False

        dgRecette.Columns(1).Name = "Libellé"
        dgRecette.Columns(2).Name = "Description"
        '''End DataGridView Recette '''

        ''' DataGridView Composition '''
        dgCompo.ColumnCount = 2
        dgCompo.ColumnHeadersVisible = True
        dgCompo.Columns(0).Visible = False
        dgCompo.Columns(1).Name = "Nom du produit"
        '''End DataGridView Composition '''

        RefreshProduit()

        ''' CboGamme load content '''
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libGamme FROM GAMME"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cboGamme.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()
        '''END CboGamme load content '''

        '''LoadRecette '''
        If (cnn.State = ConnectionState.Closed) Then
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND P.idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
            End While

            dgRecette.AutoResizeColumns()
            reader.Close()
            cnn.Close()

            'Load Picture'
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()
            reader.Read()

            nomPhoto = reader.GetValue(0)

            reader.Close()
            cnn.Close()

            PictureBox1.ImageLocation = path & nomPhoto
            'End Load Picture'
        End If
        '''END LoadRecette '''

        '''LoadCompo '''
        If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
        '''END LoadRecette '''
    End Sub
    ''' Filtre combobox Gamme '''
    Private Sub cboGamme_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
    '''End Filtre combobox Gamme '''

    ''' Sub refresh datagridview '''
    Public Sub RefreshProduit()
        cnn = New SqlConnection(connectionString)
        dgProduit.Rows.Clear()
        dgProduit.Refresh()
        dgRecette.Rows.Clear()
        dgRecette.Refresh()
        dgCompo.Rows.Clear()
        dgCompo.Refresh()
        tbProduit.Text = ""
        cnn.Close()
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT idProduit, libProduit, descProduit, photo, PUProduit, libGamme FROM  PRODUIT P, GAMME G WHERE P.idGamme = G.idGamme"
        reader = cmd.ExecuteReader()

        While reader.Read
            dgProduit.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
        End While

        reader.Close()
        cnn.Close()

        'Load Picture'
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()

        nomPhoto = reader.GetValue(0)

        reader.Close()
        cnn.Close()

        PictureBox1.ImageLocation = path & nomPhoto
        'End Load Picture'
    End Sub
    ''' End Sub refresh datagridview '''

    ''' Search txtBox Produit '''
    Private Sub tbProduit_TextChanged(sender As Object, e As EventArgs) Handles tbProduit.TextChanged
        If tbProduit.Text = "" Then
            RefreshProduit()
        Else
            dgProduit.Rows.Clear()
            dgProduit.Refresh()
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            dgCompo.Rows.Clear()
            dgCompo.Refresh()

            cboGamme.Text = ""
            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT idProduit, libProduit, descProduit, photo, PUProduit, libGamme FROM  PRODUIT P, GAMME G WHERE P.idGamme = G.idGamme AND libProduit like '" & tbProduit.Text & "%'"
                reader = cmd.ExecuteReader()

                While reader.Read
                    dgProduit.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
                End While

                reader.Close()
                cnn.Close()
            End If

            If (cnn.State = ConnectionState.Closed And dgProduit.RowCount > 0) Then
                dgRecette.Rows.Clear()
                dgRecette.Refresh()
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
                reader = cmd.ExecuteReader()

                While reader.Read
                    dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
                End While

                dgRecette.AutoResizeColumns()
                reader.Close()
                cnn.Close()

                'Load Picture'
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
                reader = cmd.ExecuteReader()
                reader.Read()

                nomPhoto = reader.GetValue(0)

                reader.Close()
                cnn.Close()

                PictureBox1.ImageLocation = path & nomPhoto
                'End Load Picture'

            End If
            '''LoadCompo '''
            If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
                dgCompo.Rows.Clear()
                dgCompo.Refresh()
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
                reader = cmd.ExecuteReader()

                While reader.Read
                    dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
                End While

                dgCompo.AutoResizeColumns()
                reader.Close()
                cnn.Close()
            End If
            '''END LoadRecette '''
        End If
    End Sub
    ''' End Search txtBox Produit '''

    ''' Remove Filtre Entreprise '''
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cboGamme.Text = ""
        RefreshProduit()
    End Sub
    '''End Remove Filte Gamme  '''

    ''' On select row on datagridview contact '''
    Private Sub dgProduit_SelectionChanged(sender As Object, e As EventArgs) Handles dgProduit.SelectionChanged
        If (cnn.State = ConnectionState.Closed) Then
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
            End While

            dgRecette.AutoResizeColumns()
            reader.Close()
            cnn.Close()

            Try
                'Load Picture'
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
                reader = cmd.ExecuteReader()
                reader.Read()

                nomPhoto = reader.GetValue(0)

                reader.Close()
                cnn.Close()

                PictureBox1.ImageLocation = path & nomPhoto
                'End Load Picture'

            Catch ex As Exception

            End Try

            '''LoadCompo '''
            If (cnn.State = ConnectionState.Closed) Then
                dgCompo.Rows.Clear()
                dgCompo.Refresh()
                If dgRecette.RowCount > 0 Then
                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
                    reader = cmd.ExecuteReader()

                    While reader.Read
                        dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
                    End While

                    dgCompo.AutoResizeColumns()
                    reader.Close()
                    cnn.Close()
                End If
            End If
            '''END LoadCompo '''
        End If
    End Sub
    ''' End On select row on datagridview Produit '''



    ''' Btn Add Produit '''
    Private Sub btnAddProduit_Click(sender As Object, e As EventArgs) Handles btnAddProduit.Click
        FrmAddProduit.Show()
    End Sub
    ''' End Btn Add Produit '''

    ''' Btn Update Produit '''
    Private Sub btnEditProduit_Click(sender As Object, e As EventArgs) Handles btnEditProduit.Click
        If dgProduit.RowCount > 0 Then
            FrmUpdateProduit.Show()
        Else
            MsgBox("Veuillez sélectionner un produit", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Update Produit '''

    ''' Btn Del Produit '''
    Private Sub btnDelProduit_Click(sender As Object, e As EventArgs) Handles btnDelProduit.Click
        If dgProduit.RowCount > 0 Then
            Dim response = MsgBox("Voulez-vous vraiment supprimer le produit ?", vbCritical + vbYesNo, "Attention /!\")
            If (response = vbYes) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
                cmd.ExecuteNonQuery()
                cnn.Close()
                If (cnn.State = ConnectionState.Closed) Then
                    RefreshProduit()
                End If
            End If
        Else
            MsgBox("Veuillez sélectionner un produit", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Del Produit '''

    '''Btn Add Recette '''
    Private Sub btnAddRecette_Click(sender As Object, e As EventArgs)
        '' Form_Add_Recette.Show()
    End Sub
    ''' End Btn Add Recette '''

    ''' Btn Del Recette'''
    Private Sub BtnDelRecette_Click(sender As Object, e As EventArgs)
        If dgRecette.RowCount > 0 Then
            Dim response = MsgBox("Voulez-vous vraiment supprimer la recette sélectionnée ?", vbCritical + vbYesNo, "Attention /!\")
            If (response = vbYes) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM RECETTE WHERE idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
                cmd.ExecuteNonQuery()
                cnn.Close()
                dgRecetteIndex = dgRecette.CurrentRow
                dgRecette.Rows.Remove(dgRecetteIndex)
            End If
        Else
            MsgBox("Veuillez sélectionner une recette", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Del Recette '''

    Private Sub dgProduit_Click(sender As Object, e As EventArgs) Handles dgProduit.Click
        If (cnn.State = ConnectionState.Closed) Then
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
            End While

            dgRecette.AutoResizeColumns()
            reader.Close()
            cnn.Close()

            'Load Picture'
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()
            reader.Read()

            nomPhoto = reader.GetValue(0)

            reader.Close()
            cnn.Close()

            PictureBox1.ImageLocation = path & nomPhoto
            'End Load Picture'

        End If
    End Sub
    ''' Btn Update Recette '''
    Private Sub btnEditRecette_Click(sender As Object, e As EventArgs)
        If dgRecette.RowCount > 0 Then
            '' Form_Update_Recette.Show()
        Else
            MsgBox("Veuillez sélectionner une recette", vbOKOnly & vbCritical, "Impossible")
        End If
    End Sub
    ''' End Btn Update Recette '''
    ''' 
    Private Sub dgRecette_SelectionChanged(sender As Object, e As EventArgs) Handles dgRecette.SelectionChanged
        '''LoadCompo '''
        If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
        '''END LoadCompo '''
    End Sub

    Private Sub dgRecette_Click(sender As Object, e As EventArgs) Handles dgRecette.Click
        '''LoadCompo '''
        If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
        '''END LoadCompo '''
    End Sub

    Private Sub cboGamme_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboGamme.SelectedIndexChanged
        dgProduit.Rows.Clear()
        dgProduit.Refresh()
        dgRecette.Rows.Clear()
        dgRecette.Refresh()
        dgCompo.Rows.Clear()
        dgCompo.Refresh()

        tbProduit.Text = ""

        '''SELECT IdGa '''
        Try
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT idGamme FROM GAMME WHERE libGamme = '" & cboGamme.Text & "'"
            reader = cmd.ExecuteReader()
            reader.Read()
            idGa = reader.GetValue(0)
            reader.Close()
            cnn.Close()
        Catch ex As Exception

        End Try
        '''END SELECT IdGa '''

        '''Content datagridview Produit '''
        If (cnn.State = ConnectionState.Closed) Then
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT idProduit, libProduit, descProduit, photo, PUProduit, libGamme FROM  PRODUIT P, GAMME G WHERE P.idGamme = G.idGamme AND P.idGamme = '" & idGa & "'"
            reader = cmd.ExecuteReader()

            While (reader.Read)
                dgProduit.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While
            reader.Close()
            cnn.Close()
        End If
        '''END Content datagridview Produit '''

        '''Content datagridview Recette '''
        If (cnn.State = ConnectionState.Closed) Then
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
            End While

            dgRecette.AutoResizeColumns()
            reader.Close()
            cnn.Close()

            'Load Picture'
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & dgProduit.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()
            reader.Read()

            nomPhoto = reader.GetValue(0)

            reader.Close()
            cnn.Close()

            PictureBox1.ImageLocation = path & nomPhoto
            'End Load Picture'
        End If
        '''END Content datagridview Recette '''

        '''LoadCompo '''
        If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT R.idRecette, libProduit FROM RECETTE R, PRODUIT P, COMPOSITION C WHERE C.idProduit = P.idProduit AND C.idRecette = R.idRecette AND C.idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
        '''END LoadRecette '''
    End Sub

    Private Sub BtnGamme_Click(sender As Object, e As EventArgs) Handles BtnGamme.Click
        FrmGammes.Show()
    End Sub
End Class