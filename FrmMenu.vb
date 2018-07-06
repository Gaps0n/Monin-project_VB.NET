Public Class FrmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmContact.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmEntreprise.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmProduit.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmRecette.Show()
    End Sub
End Class