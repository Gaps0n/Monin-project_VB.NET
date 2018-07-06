Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmGammes
    Private Sub FrmGammes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT libGamme FROM GAMME"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            CBGamme.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub CBGamme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGamme.SelectedIndexChanged
        TBGamme.Text = CBGamme.Text
    End Sub

    Private Sub BtnAjout_Click(sender As Object, e As EventArgs) Handles BtnAjout.Click
        FrmAjoutGamme.show()
    End Sub

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "UPDATE GAMME SET libGamme = '" & TBGamme.Text & "' WHERE libGamme = '" & CBGamme.Text & "'"
        cmd.ExecuteNonQuery()
        reader.Close()
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE FROM GAMME WHERE libGamme = '" & CBGamme.Text & "'"
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
End Class