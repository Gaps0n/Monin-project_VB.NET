Imports System.IO
Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect

Public Class FrmImage
    Private Sub FrmImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT LibProduit FROM PRODUIT"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            ComboBox1.Items.Add(reader.GetValue(0))
        End While
        reader.Close()
        cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim a As String
        openFileDialog1.Title = "Choisissez une image"
        openFileDialog1.Filter = "Tous(*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.ShowDialog()

        a = openFileDialog1.FileName

        My.Computer.FileSystem.CopyFile(a, "C:\Users\jason_000\Desktop\Images\" & Dir(a), overwrite:=False)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim path As String
        Dim IdProd As Integer

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT idProduit FROM PRODUIT WHERE libProduit = '" & ComboBox1.Text & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        IdProd = reader.GetValue(0)
        reader.Close()
        cnn.Close()

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT photo FROM PRODUIT WHERE idProduit = '" & IdProd & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        path = "C:\Users\jason_000\Desktop\Images\" & reader.GetValue(0)
        reader.Close()
        cnn.Close()

        PictureBox1.ImageLocation = path
    End Sub
End Class