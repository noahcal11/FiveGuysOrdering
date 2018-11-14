Public Class frmEntrees
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes checkout form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnBurgers_Click(sender As Object, e As EventArgs) Handles btnBurgers.Click
        ' Closes entrees form, opens burgers form

        Me.Hide()
        frmBurgers.Show()

    End Sub

    Private Sub btnHotDogs_Click(sender As Object, e As EventArgs) Handles btnHotDogs.Click
        ' Closes entrees form, opens hot dogs form

        Me.Hide()
        frmHotDogs.Show()

    End Sub

    Private Sub btnSandwiches_Click(sender As Object, e As EventArgs) Handles btnSandwiches.Click
        ' Closes entrees form, opens sandwiches form

        Me.Hide()
        frmSandwiches.Show()

    End Sub
End Class