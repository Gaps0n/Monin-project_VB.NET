Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmEntreprise
    Dim codePays As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''' DataGrid Entreprise '''''''''''''''''''''''''''
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM ENTREPRISE"
        reader = cmd.ExecuteReader()

        dgEntreprise.ColumnCount = 7
        dgEntreprise.ColumnHeadersVisible = True
        dgEntreprise.Columns(0).Visible = False
        dgEntreprise.Columns(1).Name = "Nom"
        dgEntreprise.Columns(2).Name = "Adresse"
        dgEntreprise.Columns(3).Name = "Code postal"
        dgEntreprise.Columns(4).Name = "Ville"
        dgEntreprise.Columns(5).Name = "Tel"
        dgEntreprise.Columns(6).Name = "Mail"

        While reader.Read
            dgEntreprise.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
        End While

        dgEntreprise.AutoResizeColumns()
        reader.Close()
        cnn.Close()
        ''''''''''''''''''''''''''' End DataGrid Entreprise '''''''''''''''''
        cbPays.Text = "Toutes les entreprises"
        ''''''''''''''''''''''''''' ComboBox Pays ''''''''''''''''''''''''''''''''
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libPays FROM PAYS"
        reader = cmd.ExecuteReader()

        While reader.Read
            cbPays.Items.Add(reader.GetValue(0))
        End While

        reader.Close()
        cnn.Close()
        ''''''''''''''''''''''''''' End ComboBox Pays '''''''''''''''''''''''''''
    End Sub

    ''''''''''''''''''''''''''' DataGrid Entreprise Filtre Pays '''''''''''''
    Private Sub cbPays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPays.SelectedIndexChanged
        If cbPays.Text = "Toutes les entreprises" Then
            RefreshEntreprise()
        Else
            cnn = New SqlConnection(connectionString)
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT CodePays FROM PAYS WHERE Libpays ='" & cbPays.Text & "'"
            reader = cmd.ExecuteReader()
            reader.Read()

            codePays = reader.GetValue(0)

            reader.Close()
            cnn.Close()

            dgEntreprise.Rows.Clear()
            dgEntreprise.Refresh()

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM ENTREPRISE WHERE CodePays = '" & codePays & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                dgEntreprise.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
            End While
            dgEntreprise.AutoSizeColumnsMode = 1

            reader.Close()
            cnn.Close()
        End If
    End Sub
    ''''''''''''''''''''''''''' End DataGrid Entreprise Filtre Pays '''''''''''''''

    ''''''''''''''''''''''''''' SubRefreshDataGridEntreprise ''''''''''''''''''''''
    Public Sub RefreshEntreprise()
        dgEntreprise.Rows.Clear()
        dgEntreprise.Refresh()
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM ENTREPRISE"
        reader = cmd.ExecuteReader()

        While reader.Read
            dgEntreprise.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
        End While

        reader.Close()
        cnn.Close()
    End Sub
    '''''''''''''''''''''''''''END SubRefreshDataGridEntreprise'''''''''''''''''''



    '''''''''''''''''''''''''''SearchFiltreEntreprise'''''''''''''''''''''''''''''
    Private Sub tbSearchEntreprise_TextChanged(sender As Object, e As EventArgs) Handles tbSearchEntreprise.TextChanged
        dgEntreprise.Rows.Clear()
        dgEntreprise.Refresh()

        cbPays.Text = "Toutes les entreprises"

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM ENTREPRISE WHERE RaisonSociale like '" & tbSearchEntreprise.Text & "%'"
        reader = cmd.ExecuteReader()

        While reader.Read
            dgEntreprise.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7))
        End While

        reader.Close()
        cnn.Close()
    End Sub
    '''''''''''''''''''''''''''END SearchFiltre'''''''''''''''''''''''''''''''''

    '''''''''''''''''''''''''''BtnAddEntreprise'''''''''''''''''''''''''''''''''
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmAddEntreprise.Show()
    End Sub
    '''''''''''''''''''''''''''BtnAddEntreprise'''''''''''''''''''''''''''''''''
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        FrmUpdateEntreprise.Show()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim response = MsgBox("Voulez-vous vraiment supprimer l'entreprise " & dgEntreprise.CurrentRow.Cells(1).Value & " ?", vbCritical + vbYesNo, "Attention /!\")
        If (response = vbYes) Then
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "DELETE FROM ENTREPRISE WHERE IdEntreprise = '" & dgEntreprise.CurrentRow.Cells(0).Value & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()
            RefreshEntreprise()
        End If
    End Sub
End Class
