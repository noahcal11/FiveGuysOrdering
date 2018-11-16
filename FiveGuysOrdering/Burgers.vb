Public Class frmBurgers
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes burgers form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnEntrees_Click(sender As Object, e As EventArgs) Handles btnEntrees.Click
        ' Closes burgers form, opens entrees form

        Me.Hide()
        frmEntrees.Show()

    End Sub

    Private Sub btnLtlBurger_Click(sender As Object, e As EventArgs) Handles btnLtlBurger.Click
        ' Opens toppings form, defines name and cost for toppings form

        If chkCheese.Checked = True And chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Little Bacon Cheeseburger"
            frmMainMenu.decAddedPrice = 7.29
        ElseIf chkCheese.Checked = True Then
            frmMainMenu.strProductName = "Little Cheeseburger"
            frmMainMenu.decAddedPrice = 6.29
        ElseIf chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Little Bacon Burger"
            frmMainMenu.decAddedPrice = 6.59
        Else
            frmMainMenu.strProductName = "Little Hamburger"
            frmMainMenu.decAddedPrice = 5.59
        End If

        frmToppings.Show()

    End Sub

    Private Sub btnRegBurger_Click(sender As Object, e As EventArgs) Handles btnRegBurger.Click
        ' Opens toppings form, defines name and cost for toppings form

        If chkCheese.Checked = True And chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Bacon Cheeseburger"
            frmMainMenu.decAddedPrice = 9.29
        ElseIf chkCheese.Checked = True Then
            frmMainMenu.strProductName = "Cheeseburger"
            frmMainMenu.decAddedPrice = 8.29
        ElseIf chkBacon.Checked = True Then
            frmMainMenu.strProductName = "Bacon Burger"
            frmMainMenu.decAddedPrice = 8.59
        Else
            frmMainMenu.strProductName = "Hamburger"
            frmMainMenu.decAddedPrice = 7.59
        End If

        frmToppings.Show()

    End Sub
End Class