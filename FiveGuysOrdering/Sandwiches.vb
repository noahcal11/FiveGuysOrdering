Public Class frmSandwiches
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes sandwiches form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnEntrees_Click(sender As Object, e As EventArgs) Handles btnEntrees.Click
        ' Closes hot dogs form, opens entrees form

        Me.Hide()
        frmEntrees.Show()

    End Sub
End Class