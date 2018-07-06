Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect

Public Class FrmAddRecette
    Dim nbRow As Integer
    Dim IdProd As Integer
    Dim IdRec As Integer
    Private Sub FrmAddRecette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection(connectionString)

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libProduit FROM PRODUIT"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            lbProduit.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()

        lbProduit.SetSelected(0, True)
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs)
        If lbProduit.Items.Count <> 0 Then
            lbCompo.Items.Add(lbProduit.Text)
            lbProduit.Items.RemoveAt(lbProduit.SelectedIndex)
            If lbCompo.Items.Count <> 0 And lbProduit.Items.Count <> 0 Then
                lbCompo.SetSelected(0, True)
                lbProduit.SetSelected(0, True)
            End If
        End If
    End Sub

    Private Sub btnLess_Click(sender As Object, e As EventArgs)
        If lbCompo.Items.Count <> 0 Then
            lbProduit.Items.Add(lbCompo.Text)
            lbCompo.Items.RemoveAt(lbCompo.SelectedIndex)
            If lbCompo.Items.Count <> 0 And lbProduit.Items.Count <> 0 Then
                lbCompo.SetSelected(0, True)
                lbProduit.SetSelected(0, True)
            End If
        End If
    End Sub

    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        nbRow = lbCompo.Items.Count
        Dim Comp(5) As String
        Dim i As Integer
        i = 0

        If tbNomRecette.Text <> "" Or tbDesc.Text <> "" Then
            If lbCompo.Items.Count <> 0 Then
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "INSERT INTO RECETTE(libRecette, descRecette) VALUES('" & tbNomRecette.Text & "', '" & tbDesc.Text & "')"
                cmd.ExecuteReader()

                reader.Close()
                cnn.Close()

                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT idRecette FROM RECETTE WHERE libRecette = '" & tbNomRecette.Text & "'"
                reader = cmd.ExecuteReader()
                reader.Read()
                IdRec = reader.GetValue(0)

                reader.Close()
                cnn.Close()


                While i < nbRow
                    Comp(i) = lbCompo.GetItemText(lbCompo.Items(i))

                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "SELECT idProduit FROM PRODUIT WHERE libProduit = '" & lbCompo.GetItemText(lbCompo.Items(i)) & "'"
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    IdProd = reader.GetValue(0)

                    reader.Close()
                    cnn.Close()

                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "INSERT INTO COMPOSITION(idRecette, idProduit) VALUES('" & IdRec & "', '" & IdProd & "')"
                    cmd.ExecuteReader()

                    reader.Close()
                    cnn.Close()

                    i = i + 1
                End While
                MsgBox("Ajout réussi", vbOKOnly & vbInformation, "Information")
                FrmRecette.RefreshRecette()
                Me.Close()
            Else
                lblMsg.Text = "Erreur : Veuillez ajouter au minimun 1 produit"
                lblMsg.ForeColor = Color.Red
            End If
        Else
            lblMsg.Text = "Erreur : Champs vides"
            lblMsg.ForeColor = Color.Red
        End If
    End Sub
End Class