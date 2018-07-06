Imports System.Data.SqlClient
Imports MONIN_CONTACT.dbconnect
Imports MONIN_CONTACT.FrmContact
Public Class FrmAddAction
    Dim IdType As String
    Private Sub FrmAddAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT * FROM TYPE_ACTION"
        reader = cmd.ExecuteReader()
        While (reader.Read)
            cbTypeAction.Items.Add(reader.GetValue(1))
        End While
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnValidAction_Click(sender As Object, e As EventArgs) Handles btnValidAction.Click
        If tbCom.Text = "" Or cbARelancer.Text = "" Or cbTypeAction.Text = "" Then
            lblMsg.Text = "Erreur : Champs vides"
            lblMsg.ForeColor = Color.Red
        Else
            tbCom.Text = tbCom.Text.Replace("'", "''")
            cbARelancer.Text = cbARelancer.Text.Replace("'", "''")
            cbTypeAction.Text = cbTypeAction.Text.Replace("'", "''")

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO ACTION(dateAction, Commentaire, ARelancer, DateRelance, IdContact, IdTypeAction)
                               VALUES('" & DateTime.Today & "','" & tbCom.Text & "',
                                      '" & cbARelancer.Text & "','" & DateTimePicker1.Value.Date & "',
                                      '" & FrmContact.dgContact.CurrentRow.Cells(0).Value & "','" & IdType & "')"
            cmd.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Ajout réussi", vbOKOnly & vbInformation, "Information")
            FrmContact.dgAction.Rows.Clear()
            FrmContact.dgAction.Refresh()
            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdContact = '" & FrmContact.dgContact.CurrentRow.Cells(0).Value & "'"
            reader = cmd.ExecuteReader()

            While reader.Read
                FrmContact.dgAction.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5))
            End While

            FrmContact.dgAction.AutoResizeColumns()
            reader.Close()
            cnn.Close()

            tbCom.Clear()
            cbTypeAction.Text = ""
            cbARelancer.Text = ""
            DateTimePicker1.ResetText()
            Me.Close()

        End If

    End Sub

    Private Sub cbTypeAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTypeAction.SelectedIndexChanged
        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdTypeAction FROM TYPE_ACTION WHERE LibTypeAction = '" & cbTypeAction.Text & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        IdType = reader.GetValue(0)
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Date < DateTime.Today Then
            lblMsg.Text = "Erreur : La date ne peut pas être anterieure à celle d'aujourd'hui"
            lblMsg.ForeColor = Color.Red
            DateTimePicker1.Value = DateTime.Today
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class