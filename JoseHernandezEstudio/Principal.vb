Public Class Principal

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        frmclientes.ShowDialog()

    End Sub

    Private Sub btnContratistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContratistas.Click
        frmContratistas.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.ShowDialog()
    End Sub
End Class
