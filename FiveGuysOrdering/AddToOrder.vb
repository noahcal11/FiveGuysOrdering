Public Class AddToOrder
    ' Add purchased item to receipt, add cost to total cost

    ' Defining variables
    Public decAddedPrice As Decimal
    Public strProductName As String

    ' Public subroutine to add item to order
    Public Sub AddItem(ByVal ItemCost As Decimal, ByVal ItemName As String)
        decAddedPrice = ItemCost
        strProductName = ItemName

        ' Adds cost of item to total cost
        frmMainMenu.decTotal += decAddedPrice
        frmCheckout.lblTotal.Text = "Total: " & frmMainMenu.decTotal.ToString("C")

        ' Adds item name to listbox
        frmMainMenu.lstMainMenu.Items.Add(ItemName & " " & ItemCost)
        frmCheckout.lstCheckout.Items.Add(ItemName & " " & ItemCost)

        ' Displays messagebox as confirmation
        MsgBox("Successfully added " & ItemName & " to order.", MsgBoxStyle.OkOnly, "Item added")
    End Sub
End Class
