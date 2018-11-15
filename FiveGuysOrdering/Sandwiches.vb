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

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        ' Opens toppings form, defines name and cost for toppings form

        frmToppings.Show()

        frmMainMenu.strProductName = "Veggie Sandwich"
        If chkVeggieCheese.Checked = True Then
            frmMainMenu.decAddedPrice = 4.89
        Else
            frmMainMenu.decAddedPrice = 4.19
        End If
    End Sub

    Private Sub btnGrilledCheese_Click(sender As Object, e As EventArgs) Handles btnGrilledCheese.Click
        ' Adds grilled cheese to order

        AddToOrder.AddItem(ItemCost:=4.89, ItemName:="Grilled Cheese")

    End Sub

    Private Sub btnBLT_Click(sender As Object, e As EventArgs) Handles btnBLT.Click
        ' Adds BLT to order

        AddToOrder.AddItem(ItemCost:=6.09, ItemName:="BLT")

    End Sub
End Class