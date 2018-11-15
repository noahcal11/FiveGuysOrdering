Public Class frmFries
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes checkout form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnFries_Click(sender As Object, e As EventArgs) Handles btnFries.Click
        ' Calculates cost of fries, adds to order

        If radCajun.Checked = True Then
            If radLittle.Checked = True Then
                frmMainMenu.strProductName = "Little Cajun Fries"
                frmMainMenu.decAddedPrice = 3.49
            ElseIf radRegularSize.Checked = True Then
                frmMainMenu.strProductName = "Regular Cajun Fries"
                frmMainMenu.decAddedPrice = 4.49
            Else
                frmMainMenu.strProductName = "Large Cajun Fries"
                frmMainMenu.decAddedPrice = 6.19
            End If
        Else
            If radLittle.Checked = True Then
                frmMainMenu.strProductName = "Little Fries"
                frmMainMenu.decAddedPrice = 3.49
            ElseIf radRegularSize.Checked = True Then
                frmMainMenu.strProductName = "Regular Fries"
                frmMainMenu.decAddedPrice = 4.49
            Else
                frmMainMenu.strProductName = "Large Fries"
                frmMainMenu.decAddedPrice = 6.19
            End If
        End If
        AddToOrder.AddItem(ItemCost:=frmMainMenu.decAddedPrice, ItemName:=frmMainMenu.strProductName)
    End Sub
End Class