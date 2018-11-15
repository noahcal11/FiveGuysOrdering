Public Class frmDrinks
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes checkout form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnRegDrink_Click(sender As Object, e As EventArgs) Handles btnRegDrink.Click
        ' Adds Regular Drink to order

        AddToOrder.AddItem(ItemCost:=2.49, ItemName:="Regular Drink")

    End Sub

    Private Sub btnLgDrink_Click(sender As Object, e As EventArgs) Handles btnLgDrink.Click
        ' Adds Large Drink to order

        AddToOrder.AddItem(ItemCost:=2.79, ItemName:="Large Drink")

    End Sub

    Private Sub btnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        ' Adds Bottled Water to order

        AddToOrder.AddItem(ItemCost:=2.19, ItemName:="Bottled Water")

    End Sub
End Class