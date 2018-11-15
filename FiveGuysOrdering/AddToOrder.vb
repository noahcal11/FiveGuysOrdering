Public Class AddToOrder
    ' Add purchased item to receipt, add cost to total cost



    ' Public subroutine to add item to order
    Public Shared Sub AddItem(ByVal ItemCost As Decimal, ByVal ItemName As String)
        frmMainMenu.decAddedPrice = ItemCost
        frmMainMenu.strProductName = ItemName

        ' Adds cost of item to total cost
        frmMainMenu.decTotal += frmMainMenu.decAddedPrice
        frmCheckout.lblTotal.Text = "Total: " & frmMainMenu.decTotal.ToString("C")

        ' Adds item name to listbox
        frmMainMenu.lstMainMenu.Items.Add(ItemName & " " & ItemCost)
        frmCheckout.lstCheckout.Items.Add(ItemName & " " & ItemCost)

        ' Displays messagebox as confirmation
        MsgBox("Successfully added " & ItemName & " to order.", MsgBoxStyle.OkOnly, "Item added")
    End Sub

    ' Gets checkboxes from toppings form
    Public Shared Sub getcheckme(ByVal element As Control)
        If TypeOf element Is CheckBox Then
            If DirectCast(element, CheckBox).Checked = True Then
                frmMainMenu.lstMainMenu.Items.Add(" " & element.Text)
                frmCheckout.lstCheckout.Items.Add(" " & element.Text)
            End If
        End If
    End Sub
End Class
