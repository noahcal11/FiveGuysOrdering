' Program Name: Five Guys Ordering
' Developer:    Noah Calisti
' Date:         November 8, 2018
' Purpose:      Employee program that allows employees to order from the Five Guys Menu, calculates total of food with tax

Public Class frmMainMenu
    ' Total price variable
    Public decTotal As Decimal = 0
    Private Sub btnEntrees_Click(sender As Object, e As EventArgs) Handles btnEntrees.Click
        ' Opens entrees form, closes main menu form

        Me.Hide()
        frmEntrees.Show()

    End Sub

    Private Sub btnFries_Click(sender As Object, e As EventArgs) Handles btnFries.Click
        ' Opens fries form, closes main menu form

        Me.Hide()
        frmFries.Show()

    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        ' Opens drinks form, closes main menu form

        Me.Hide()
        frmDrinks.Show()

    End Sub

    Private Sub btnCompleteOrder_Click(sender As Object, e As EventArgs) Handles btnCompleteOrder.Click
        ' Opens checkout form, closes main menu form

        Me.Hide()
        frmCheckout.Show()

    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        ' Clears listboxes, clears total variable

        Me.lstMainMenu.Items.Clear()
        frmCheckout.lstCheckout.Items.Clear()
        decTotal = 0

    End Sub
End Class
