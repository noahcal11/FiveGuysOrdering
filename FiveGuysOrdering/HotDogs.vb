Public Class frmHotDogs
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes hot dogs form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnEntrees_Click(sender As Object, e As EventArgs) Handles btnEntrees.Click
        ' Closes hot dogs form, opens entrees form

        Me.Hide()
        frmEntrees.Show()

    End Sub

    Private Sub btnHotDogs_Click(sender As Object, e As EventArgs) Handles btnHotDogs.Click
        ' Opens toppings form, defines name and cost for toppings form

        If chkCheese.Checked = True And chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Bacon Cheese Dog"
            frmMainMenu.decAddedPrice = 6.99
        ElseIf chkCheese.Checked = True Then
            frmMainMenu.strProductName = "Cheese Dog"
            frmMainMenu.decAddedPrice = 5.99
        ElseIf chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Bacon Dog"
            frmMainMenu.decAddedPrice = 6.29
        Else
            frmMainMenu.strProductName = "Hot Dog"
            frmMainMenu.decAddedPrice = 5.29
        End If

        frmToppings.Show()

    End Sub
End Class