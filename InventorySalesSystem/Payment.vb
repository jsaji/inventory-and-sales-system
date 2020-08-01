Public Class Payment
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelPayment.Click
        'Cancels the whole checkout, clearing the items chosen and the cost calculated - goes back to MainMenu : first gets confirmation from user
        If MsgBox("Are you sure you want to return to the Main Menu and clear the checkout?", vbYesNo, "Confirmation") = DialogResult.Yes Then
            FinalCheckout.Items.Clear()
            'CheckOut.CheckoutList.Items.Clear()
            CheckOut.Close()    'Closes the checkout form, which had been hidden, allowing it to be reopened
            rowCount = 0
            totalcost = 0
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub NewCheckOut(sender As Object, e As EventArgs) Handles NextCheckout.Click
        'Opens the way for a new checkout, clearing the data from the previous checkout
        'CheckOut.CheckoutList.Items.Clear()
        CheckOut.Close()    'Closes the checkout form, which had been hidden, allowing it to be reopened
        FinalCheckout.Items.Clear()
        rowCount = 0
        totalcost = 0
        customerCash.Text = ""
        CheckOut.Show()   'Reopens checkout form anew and closes the payment form
        Me.Close()
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmountDue.Text = "Amount due: $" & totalcost.ToString("N2")
        ChangeOwed.Text = "Change due: -$" & CStr(totalcost.ToString("N2"))

        'Clones the data from the checkout listview on CheckOut.form to the final bill listview
        For i = 0 To rowCount
            FinalCheckout.Items.Add(CheckOut.CheckoutList.Items(i).Clone())
        Next

        'New Feature (15/5/17): Orders the inventory alphabetically for ease of navigation
        For q = 0 To FinalCheckout.Items.Count - 2
            For k = 0 To FinalCheckout.Items.Count - 2
                Dim CompareVar1 = FinalCheckout.Items(k).SubItems(1).Text
                Dim CompareVar2 = FinalCheckout.Items(k + 1).SubItems(1).Text

                If (CompareVar1) > (CompareVar2) Then 'If Name of the kth item is further in the alphabet than the name of the (k + 1)th item, they are switched
                    Dim TempID = FinalCheckout.Items(k).SubItems(0)
                    Dim TempName = FinalCheckout.Items(k).SubItems(1)
                    Dim TempSize = FinalCheckout.Items(k).SubItems(2)
                    Dim TempPrice = FinalCheckout.Items(k).SubItems(3)

                    'Switches the Subitems of the different rows
                    FinalCheckout.Items(k).SubItems(0) = FinalCheckout.Items(k + 1).SubItems(0)
                    FinalCheckout.Items(k).SubItems(1) = FinalCheckout.Items(k + 1).SubItems(1)
                    FinalCheckout.Items(k).SubItems(2) = FinalCheckout.Items(k + 1).SubItems(2)
                    FinalCheckout.Items(k).SubItems(3) = FinalCheckout.Items(k + 1).SubItems(3)
                    FinalCheckout.Items(k + 1).SubItems(0) = TempID
                    FinalCheckout.Items(k + 1).SubItems(1) = TempName
                    FinalCheckout.Items(k + 1).SubItems(2) = TempSize
                    FinalCheckout.Items(k + 1).SubItems(3) = TempPrice
                End If
            Next
        Next

    End Sub

    Private Sub ConfirmPayment(sender As Object, e As EventArgs) Handles confirm.Click
        'Calculates the change due when the OK button is pressed
        Try
            Dim userInput As String = (customerCash.Text)
            Dim change As Decimal = -(totalcost - CDec(userInput))
            If change >= 0 Then
                ChangeOwed.Text = "Change due: $" & CStr(change.ToString("N2"))
                NextCheckout.Enabled = True
            Else 'If change is -ve, as in, the customer owes the store money, they cannot procees until change is either zero or +ve
                Dim additional As Decimal = Math.Abs(change)
                MsgBox("An additonal $" & CStr(additional.ToString("N2")) & " is required. Re-enter new payment.", vbExclamation, "Attention!")
                customerCash.Text = ""
                ChangeOwed.Text = "Change due: -$" & CStr(totalcost.ToString("N2"))
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid value.", vbCritical, "Error")   'Prevents crash when pressing ok when there is nothing in the text box
        End Try
    End Sub

    Private Sub ReturnScreen_Click(sender As Object, e As EventArgs) Handles ReturnScreen.Click
        'Returns to  CheckOut.form, so changes can be made to the list of purchased items
        CheckOut.Show()
        Me.Close()
    End Sub

    Private Sub SortCheckout(sender As Object, e As EventArgs) Handles SortBy.Click
        'New Function (16/5/17): Sorts Final Bill by price or alphabetically

        'When the button is first clicked, it sorts the Final Bill in descending cost
        If SortBy.Text = "Sort By Price" Then
            For q = 0 To rowCount
                For k = 0 To rowCount - 1
                    Dim rawVar1 = FinalCheckout.Items(k).SubItems(3).Text
                    Dim CompareVar1 As Decimal = Replace(rawVar1, "$", "")
                    Dim rawVar2 = FinalCheckout.Items(k + 1).SubItems(3).Text
                    Dim CompareVar2 As Decimal = Replace(rawVar2, "$", "")

                    If (CompareVar1) < (CompareVar2) Then  'If Price of the kth item is less than the price of the (k + 1)th item, they are switched
                        'Assigns the subitems to temporary variables
                        Dim TempID = FinalCheckout.Items(k).SubItems(0)
                        Dim TempName = FinalCheckout.Items(k).SubItems(1)
                        Dim TempSize = FinalCheckout.Items(k).SubItems(2)
                        Dim TempPrice = FinalCheckout.Items(k).SubItems(3)

                        'Switches the Subitems of the different rows
                        FinalCheckout.Items(k).SubItems(0) = FinalCheckout.Items(k + 1).SubItems(0)
                        FinalCheckout.Items(k).SubItems(1) = FinalCheckout.Items(k + 1).SubItems(1)
                        FinalCheckout.Items(k).SubItems(2) = FinalCheckout.Items(k + 1).SubItems(2)
                        FinalCheckout.Items(k).SubItems(3) = FinalCheckout.Items(k + 1).SubItems(3)
                        FinalCheckout.Items(k + 1).SubItems(0) = TempID
                        FinalCheckout.Items(k + 1).SubItems(1) = TempName
                        FinalCheckout.Items(k + 1).SubItems(2) = TempSize
                        FinalCheckout.Items(k + 1).SubItems(3) = TempPrice
                    End If
                Next
                SortBy.Text = " Sort By Name"
            Next

            'if necessary, after sorting by price, the user can sort by name, so as to read the checkout list in alphabetical order
        ElseIf SortBy.Text = " Sort By Name" Then
            For q = 0 To rowCount
                For k = 0 To rowCount - 1
                    Dim CompareVar1 = LCase(FinalCheckout.Items(k).SubItems(1).Text)
                    Dim CompareVar2 = LCase(FinalCheckout.Items(k + 1).SubItems(1).Text)

                    If (CompareVar1) > (CompareVar2) Then 'If Name of the kth item is further in the alphabet than the name of the (k + 1)th item, they are switched
                        Dim TempID = FinalCheckout.Items(k).SubItems(0)
                        Dim TempName = FinalCheckout.Items(k).SubItems(1)
                        Dim TempSize = FinalCheckout.Items(k).SubItems(2)
                        Dim TempPrice = FinalCheckout.Items(k).SubItems(3)

                        'Switches the Subitems of the different rows
                        FinalCheckout.Items(k).SubItems(0) = FinalCheckout.Items(k + 1).SubItems(0)
                        FinalCheckout.Items(k).SubItems(1) = FinalCheckout.Items(k + 1).SubItems(1)
                        FinalCheckout.Items(k).SubItems(2) = FinalCheckout.Items(k + 1).SubItems(2)
                        FinalCheckout.Items(k).SubItems(3) = FinalCheckout.Items(k + 1).SubItems(3)
                        FinalCheckout.Items(k + 1).SubItems(0) = TempID
                        FinalCheckout.Items(k + 1).SubItems(1) = TempName
                        FinalCheckout.Items(k + 1).SubItems(2) = TempSize
                        FinalCheckout.Items(k + 1).SubItems(3) = TempPrice
                    End If
                Next
                SortBy.Text = "Sort By Price"
            Next
        End If

    End Sub
End Class