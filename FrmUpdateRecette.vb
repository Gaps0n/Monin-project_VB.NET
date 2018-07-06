Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmUpdateRecette
    Dim nbRow As Integer
    Dim idR As Integer
    Dim idProd As Integer
    Private Sub FrmUpdateRecette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libRecette, descRecette FROM RECETTE WHERE libRecette = '" & FrmRecette.dgRecette.CurrentRow.Cells(1).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        tbNomRecette.Text = reader.GetValue(0)
        tbDesc.Text = reader.GetValue(1)

        reader.Close()
        cnn.Close()

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

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libProduit FROM PRODUIT P, RECETTE R, COMPOSITION C WHERE C.idRecette = R.idRecette AND C.idProduit = P.idProduit AND C.idRecette = '" & FrmRecette.dgRecette.CurrentRow.Cells(0).Value & "'"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            lbCompo.Items.Add(reader.GetValue(0))
            lbProduit.Items.Remove(lbCompo.Items(0))
        End While
        reader.Close()
        cnn.Close()


    End Sub
    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        If lbProduit.Items.Count <> 0 Then
            lbCompo.Items.Add(lbProduit.Text)
            lbProduit.Items.RemoveAt(lbProduit.SelectedIndex)
            If lbCompo.Items.Count <> 0 And lbProduit.Items.Count <> 0 Then
                lbCompo.SetSelected(0, True)
                lbProduit.SetSelected(0, True)
            End If
        End If
    End Sub

    Private Sub btnLess_Click(sender As Object, e As EventArgs) Handles btnLess.Click
        If lbCompo.Items.Count <> 0 Then
            lbProduit.Items.Add(lbCompo.Text)
            lbCompo.Items.RemoveAt(lbCompo.SelectedIndex)
            If lbCompo.Items.Count <> 0 And lbProduit.Items.Count <> 0 Then
                lbCompo.SetSelected(0, True)
                lbProduit.SetSelected(0, True)
            End If
        End If
    End Sub
    Private Sub btnValid_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnValid_Click_1(sender As Object, e As EventArgs) Handles btnValid.Click
        nbRow = lbCompo.Items.Count
        Dim Comp(5) As String
        Dim i As Integer
        i = 0

        If tbNomRecette.Text <> "" Or tbDesc.Text <> "" Then
            If lbCompo.Items.Count <> 0 Then
                tbNomRecette.Text = tbNomRecette.Text.Replace("'", "''")
                tbDesc.Text = tbDesc.Text.Replace("'", "''")
                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "SELECT idRecette FROM RECETTE WHERE libRecette = '" & tbNomRecette.Text & "'"
                reader = cmd.ExecuteReader()
                reader.Read()
                idR = reader.GetValue(0)

                reader.Close()
                cnn.Close()

                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "UPDATE RECETTE SET libRecette = '" & tbNomRecette.Text & "', descRecette = '" & tbDesc.Text & "'
                                             WHERE IdRecette = '" & idR & "'"

                cmd.ExecuteReader()

                reader.Close()
                cnn.Close()

                cnn.Open()
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM COMPOSITION WHERE idRecette = '" & idR & "'"

                cmd.ExecuteReader()

                reader.Close()
                cnn.Close()

                While i < nbRow

                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "SELECT idProduit FROM PRODUIT WHERE libProduit = '" & lbCompo.GetItemText(lbCompo.Items(i)) & "'"
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    idProd = reader.GetValue(0)

                    reader.Close()
                    cnn.Close()


                    cnn.Open()
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "INSERT INTO COMPOSITION(idRecette, idProduit) Values('" & idR & "', '" & idProd & "')"
                    cmd.ExecuteReader()

                    reader.Close()
                    cnn.Close()

                    i = i + 1
                End While
                MsgBox("Modification réussi", vbOKOnly & vbInformation, "Information")
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