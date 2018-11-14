Public Class frmDrinks
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes checkout form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub
End Class