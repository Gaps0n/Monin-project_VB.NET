Imports MONIN_CONTACT.dbconnect
Imports MONIN_CONTACT.FrmContact
Imports System.Data.SqlClient
Public Class FrmUpdateAction
    Dim IdT As Integer
    Private Sub FrmUpdateAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION T WHERE A.IdTypeAction = T.IdTypeAction AND IdAction ='" & FrmContact.dgAction.CurrentRow.Cells(0).Value & "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        tbCom.Text = reader.GetValue(1)
        cbTypeAction.Text = reader.GetValue(4)
        cbARelancer.Text = reader.GetValue(2)
        DateTimePicker1.Value = reader.GetValue(3)

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
            cmd.CommandText = "SELECT A.IdTypeAction FROM ACTION A, TYPE_ACTION T WHERE T.IdTypeAction = A.IdTypeAction AND LibTypeAction = '" & cbTypeAction.Text & "'"
            reader = cmd.ExecuteReader()
            reader.Read()
            IdT = reader.GetValue(0)
            reader.Close()
            cnn.Close()

            cnn.Open()
            cmd = New SqlCommand()
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE ACTION SET dateAction = '" & DateTime.Today & "' , Commentaire = '" & tbCom.Text & "', ARelancer = '" & cbARelancer.Text & "', DateRelance = '" & DateTimePicker1.Value.Date & "', IdContact = '" & FrmContact.dgContact.CurrentRow.Cells(0).Value & "', IdTypeAction = '" & IdT & "' WHERE IdAction = '" & FrmContact.dgAction.CurrentRow.Cells(0).Value & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Modification de l'action réussi", vbOKOnly & vbInformation, "Information")
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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Date < DateTime.Today Then
            lblMsg.Text = "Erreur : La date ne peut pas être inférieur à la date d'aujourd'hui"
            lblMsg.ForeColor = Color.Red
            DateTimePicker1.Value = DateTime.Today
        End If
    End Sub
End Class