Public Class MainMenu

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        'Makes sure the count of purchased items and total cost is zero before hiding MainMenu and opening the Checkout form
        rowCount = 0
        totalcost = 0
        CheckOut.Show()
        Me.Hide()
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        'Hides MainMenu and opens the Inventory form
        InventoryEdit.Show()
        Me.Hide()
    End Sub

    Private Sub HelpClick(sender As Object, e As EventArgs) Handles HelpButton.Click
        Dim manual As String = "https://drive.google.com/open?id=0Bw9av9JEQx56M1hxRnBxcXlWY3c"
        Process.Start(manual)
    End Sub
End Class