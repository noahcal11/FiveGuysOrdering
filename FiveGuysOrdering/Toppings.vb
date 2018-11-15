Public Class frmToppings
    Private Sub btnToppingsConfirm_Click(sender As Object, e As EventArgs) Handles btnToppingsConfirm.Click
        ' Adds toppings and burger/sandwich to receipt, closes form

        AddToOrder.AddItem(ItemCost:=frmMainMenu.decAddedPrice, ItemName:=frmMainMenu.strProductName)
        AddToOrder.getcheckme()
        Me.Hide()

    End Sub
End Class