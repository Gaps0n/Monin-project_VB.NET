Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmRecette
    Dim IdProd As Integer
    Private Sub FrmRecette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''' DataGridView Rectte '''
        dgRecette.ColumnCount = 3
        dgRecette.ColumnHeadersVisible = True
        dgRecette.Columns(0).Visible = False
        dgRecette.Columns(1).Name = "Nom de la recette"
        dgRecette.Columns(2).Name = "Description"

        '''End DataGridView Recette '''

        ''' DataGridView Compo '''
        dgCompo.ColumnCount = 6
        dgCompo.ColumnHeadersVisible = True
        dgCompo.Columns(0).Visible = False
        dgCompo.Columns(1).Name = "Nom du produit"

        '''End DataGridView Compo '''

        RefreshRecette()

        ''' cbProduit load content '''
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libProduit FROM PRODUIT"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cbProduit.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()
        '''END cbProduit load content '''
        cbProduit.Text = "Toutes les recettes"
        '''LoadCompo '''
        If (cnn.State = ConnectionState.Closed) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT P.IdProduit, libProduit FROM PRODUIT P, COMPOSITION C WHERE P.idProduit = C.idProduit AND idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
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

    Public Sub RefreshRecette()
        cnn = New SqlConnection(connectionString)
        dgRecette.Rows.Clear()
        dgRecette.Refresh()
        dgCompo.Rows.Clear()
        dgCompo.Refresh()

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM RECETTE"
        reader = cmd.ExecuteReader()

        While reader.Read
            dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
        End While

        reader.Close()
        cnn.Close()
    End Sub

    Private Sub cbProduit_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbNomRecette_TextChanged(sender As Object, e As EventArgs) Handles tbNomRecette.TextChanged
        cbProduit.Text = "Toutes les recettes"
        If tbNomRecette.Text = "" Then
            RefreshRecette()
        Else
            dgRecette.Rows.Clear()
            dgRecette.Refresh()
            dgCompo.Rows.Clear()
            dgCompo.Refresh()

            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT idRecette, libRecette, descRecette FROM RECETTE WHERE libRecette like '" & tbNomRecette.Text & "%'"
                reader = cmd.ExecuteReader()

                While reader.Read
                    dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
                End While

                reader.Close()
                cnn.Close()
            End If

            If (cnn.State = ConnectionState.Closed And dgRecette.RowCount > 0) Then
                dgCompo.Rows.Clear()
                dgCompo.Refresh()
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT P.IdProduit, libProduit FROM PRODUIT P, COMPOSITION C WHERE P.idProduit = C.idProduit AND idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
                reader = cmd.ExecuteReader()

                While reader.Read
                    dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
                End While

                dgCompo.AutoResizeColumns()
                reader.Close()
                cnn.Close()
            End If

        End If

    End Sub

    Private Sub dgRecette_SelectionChanged(sender As Object, e As EventArgs) Handles dgRecette.SelectionChanged
        If (cnn.State = ConnectionState.Closed) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT P.IdProduit, libProduit FROM PRODUIT P, COMPOSITION C WHERE P.idProduit = C.idProduit AND idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If
    End Sub

    Private Sub dgRecette_Click(sender As Object, e As EventArgs) Handles dgRecette.Click
        If (cnn.State = ConnectionState.Closed) Then
            dgCompo.Rows.Clear()
            dgCompo.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT P.IdProduit, libProduit FROM PRODUIT P, COMPOSITION C WHERE P.idProduit = C.idProduit AND idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
            End While

            dgCompo.AutoResizeColumns()
            reader.Close()
            cnn.Close()
        End If

    End Sub

    Private Sub btnAddRecette_Click(sender As Object, e As EventArgs) Handles btnAddRecette.Click
        FrmAddRecette.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        FrmUpdateRecette.Show()
    End Sub

    Private Sub btnDelRecette_Click(sender As Object, e As EventArgs) Handles btnDelRecette.Click
        Dim response = MsgBox("Voulez-vous vraiment supprimer la recette " & dgRecette.CurrentRow.Cells(1).Value & " ?", vbCritical + vbYesNo, "Attention /!\")
        If (response = vbYes) Then
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "DELETE FROM RECETTE WHERE IdRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()
            RefreshRecette()
        End If
    End Sub

    Private Sub cbProduit_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbProduit.SelectedIndexChanged
        dgRecette.Rows.Clear()
        dgRecette.Refresh()
        dgCompo.Rows.Clear()
        dgCompo.Refresh()


        If cbProduit.Text = "Toutes les recettes" Then
            RefreshRecette()
        Else
            If (cnn.State = ConnectionState.Closed) Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT idProduit FROM PRODUIT WHERE libProduit = '" & cbProduit.Text & "'"
                reader = cmd.ExecuteReader()
                reader.Read()
                IdProd = reader.GetValue(0)
                reader.Close()
                cnn.Close()


                '''Content datagridview contact '''
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT R.idRecette, libRecette, descRecette FROM RECETTE R, COMPOSITION C WHERE C.idRecette = R.idRecette AND C.idProduit = '" & IdProd & "'"
                reader = cmd.ExecuteReader()

                While (reader.Read)
                    dgRecette.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
                End While
                reader.Close()
                cnn.Close()
                '''END Content datagridview contact '''

                '''Content datagridview action '''
                If (cnn.State = ConnectionState.Closed) Then

                    Try
                        dgCompo.Rows.Clear()
                        dgCompo.Refresh()
                        cnn.Open()
                        cmd = New SqlCommand()
                        cmd.Connection = cnn
                        cmd.CommandText = "SELECT P.IdProduit, libProduit FROM PRODUIT P, COMPOSITION C WHERE P.idProduit = C.idProduit AND idRecette = '" & dgRecette.CurrentRow.Cells(0).Value & "'"
                        reader = cmd.ExecuteReader()

                        While reader.Read
                            dgCompo.Rows.Add(reader.GetValue(0), reader.GetValue(1))
                        End While

                        dgCompo.AutoResizeColumns()
                        reader.Close()
                        cnn.Close()
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If

    End Sub
End Class