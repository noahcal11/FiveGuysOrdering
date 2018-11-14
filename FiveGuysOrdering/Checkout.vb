Public Class frmCheckout
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Displays message box, disables checkout button

        MsgBox("Your total is " & frmMainMenu.decTotal.ToString("C") & ". Thank you for eating at Five Guys!", , "Order Complete")
        Me.btnCheckout.Enabled = False

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Closes checkout form, opens main menu form

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        ' Enables checkout button, clears everything, switches to main menu button

        Me.btnCheckout.Enabled = True
        frmMainMenu.decTotal = 0
        Me.lblTotal.Text = "Total: " & frmMainMenu.decTotal.ToString("C")
        Me.lstCheckout.Items.Clear()
        frmMainMenu.lstMainMenu.Items.Clear()
        Me.Hide()
        frmMainMenu.Show()

    End Sub
End Class