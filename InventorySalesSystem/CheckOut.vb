Public Class CheckOut

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelCheckout.Click
        'Cancels the checkout, closing the form and opening MainMenu : Asks for confirmation first
        If MsgBox("Are you sure you want to return to the Main Menu and clear the checkout?", vbYesNo, "Confirmation") = DialogResult.Yes Then
            totalcost = 0
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ProceedPayment_Click(sender As Object, e As EventArgs) Handles ProceedPayment.Click
        'Proceeds with the checkout. closing the form and opening the payment form
        Payment.Show()
        Me.Hide()
    End Sub

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads data from the database into the datagrid
        Me.ItemListTableAdapter.Fill(Me.InventoryDataSet.ItemList)

        'New Feature (17/5/17) - Database transfered data to data grid, so now the data can be put into a listview - More visually appealing and manage data w/out conflict
        For i = 0 To InventoryGrid.RowCount - 2
            Dim prodID = InventoryGrid.Item(0, i).Value      'Defines prodID as the first column (product ID) in the row selected
            Dim prodName = InventoryGrid.Item(1, i).Value      'Defines prodName as the second column (product name) in the row selected
            Dim prodSize = InventoryGrid.Item(2, i).Value      'Defines prodSize as the third column (size)  in the row selected
            Dim prodPrice As Decimal = InventoryGrid.Item(3, i).Value      'Defines ProdPrice as the fourth column (price) in the row selected

            'Compiles the prior variables into an array
            Dim details(3) As String
            details(0) = CStr(prodID)   'Converts ID from integer to string
            details(1) = prodName
            details(2) = CStr(prodSize) & "g"   'Converts size from integer to string and adds "g" to the end
            details(3) = "$" & CDec(prodPrice.ToString("N2"))   'Converts price from integer to string and adds "$' to the fron

            'Defines itm as a listviewitem, composed of the data from the array details and adds it to the InventoryList
            Dim itm = New ListViewItem(details)
            InventoryList.Items.Add(itm)
        Next

        'New Feature (15/5/17): Orders the inventory alphabetically for ease of navigation
        For q = 0 To InventoryList.Items.Count - 2
            For k = 0 To InventoryList.Items.Count - 2
                Dim CompareVar1 = LCase(InventoryList.Items(k).SubItems(1).Text)
                Dim CompareVar2 = LCase(InventoryList.Items(k + 1).SubItems(1).Text)

                If (CompareVar1) > (CompareVar2) Then 'If Name of the kth item is further in the alphabet than the name of the (k + 1)th item, they are switched
                    Dim TempID = InventoryList.Items(k).SubItems(0)
                    Dim TempName = InventoryList.Items(k).SubItems(1)
                    Dim TempSize = InventoryList.Items(k).SubItems(2)
                    Dim TempPrice = InventoryList.Items(k).SubItems(3)

                    'Switches the Subitems of the different rows
                    InventoryList.Items(k).SubItems(0) = InventoryList.Items(k + 1).SubItems(0)
                    InventoryList.Items(k).SubItems(1) = InventoryList.Items(k + 1).SubItems(1)
                    InventoryList.Items(k).SubItems(2) = InventoryList.Items(k + 1).SubItems(2)
                    InventoryList.Items(k).SubItems(3) = InventoryList.Items(k + 1).SubItems(3)
                    InventoryList.Items(k + 1).SubItems(0) = TempID
                    InventoryList.Items(k + 1).SubItems(1) = TempName
                    InventoryList.Items(k + 1).SubItems(2) = TempSize
                    InventoryList.Items(k + 1).SubItems(3) = TempPrice
                End If
            Next
        Next

        TotalShow.Text = "Total: $" & totalcost

    End Sub

    Private Sub AddProductToList_Click(sender As Object, e As EventArgs) Handles AddProduct.Click, InventoryList.DoubleClick
        Try

            Dim prodID = InventoryList.SelectedItems(0).SubItems(0).Text     'Defines prodID as the first column (product ID) in the row selected
            Dim prodName = InventoryList.SelectedItems(0).SubItems(1).Text      'Defines prodName as the second column (product name) in the row selected
            Dim prodSize = InventoryList.SelectedItems(0).SubItems(2).Text      'Defines prodSize as the third column (size)  in the row selected
            Dim prodPrice = InventoryList.SelectedItems(0).SubItems(3).Text      'Defines ProdPrice as the fourth column (price) in the row selected

            'Compiles the prior variables into an array
            Dim details(3) As String
            details(0) = prodID
            details(1) = prodName
            details(2) = prodSize
            details(3) = prodPrice

            'Defines itm as a listviewitem, composed of the data from the array details
            Dim itm = New ListViewItem(details)
            CheckoutList.Items.Add(itm)     'Adds itm to the checkout list

            'Keeps a record of the number of rows in the listview, starting at 0
            rowCount = CheckoutList.Items.Count - 1

            totalcost = totalcost + prodPrice   'Calculates total cost as it accumulates
            TotalShow.Text = "Total: $" & totalcost.ToString("N2")   'Displays total cost
            ProceedPayment.Enabled = True
        Catch ex As Exception 'Makes sure an item is selected before pressing the button - prevents crashing
            MsgBox("Click on an item in the Inventory List to add it.", vbExclamation, "Attention")
        End Try
    End Sub

    Private Sub RemoveProductFromList_Click(sender As Object, e As EventArgs) Handles RemoveProduct.Click, CheckoutList.DoubleClick
        'Allows the removal of products from the checkout list
        Try
            Dim i As ListViewItem
            Dim priceRed = CheckoutList.SelectedItems(0).SubItems(3).Text   'Gets the cost of the removed product
            i = CheckoutList.SelectedItems(0)   'Defines i as the selected row
            i.Remove()   'Removes the selected row
            rowCount = CheckoutList.Items.Count - 1   'Recalculates number of rows in the listview, starting at 0
            totalcost = totalcost - CDec(priceRed)   'Deducts the cost from the total cost
            TotalShow.Text = "Total: $" & totalcost.ToString("N2")   'Displays the new cosst
        Catch ex As Exception   'Makes sure an item is selected before pressing the button - prevents crashing
            MsgBox("Click on an item in the Checkout List to remove it.", vbExclamation, "Attention!")
        End Try

    End Sub


End Class