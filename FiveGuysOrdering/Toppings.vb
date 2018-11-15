Public Class frmToppings
    Private Sub btnToppingsConfirm_Click(sender As Object, e As EventArgs) Handles btnToppingsConfirm.Click
        ' Adds toppings and burger/sandwich to receipt, closes form

        Dim element As Control
        AddToOrder.AddItem(ItemCost:=frmMainMenu.decAddedPrice, ItemName:=frmMainMenu.strProductName)
        For Each element In pnlToppings.Controls
            If TypeOf element Is CheckBox Then
                If DirectCast(element, CheckBox).Checked = True Then
                    frmMainMenu.lstMainMenu.Items.Add(" " & element.Text)
                    frmCheckout.lstCheckout.Items.Add(" " & element.Text)
                End If
            End If
        Next

        ' Clears all checkboxes
        For Each element In pnlToppings.Controls
            DirectCast(element, CheckBox).Checked = False
        Next
        Me.Hide()
    End Sub
End Class