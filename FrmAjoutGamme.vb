Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Public Class FrmAjoutGamme
    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO Gamme(libGamme)
                               VALUES('" & TBAjout.Text & "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
        Me.Close()
        FrmGammes.Close()
    End Sub
End Class