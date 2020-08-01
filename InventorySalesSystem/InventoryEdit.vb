Public Class InventoryEdit

    'Private Sub ItemListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
    '    Me.Validate()
    '    Me.ItemListBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.InventoryDataSet)
    'End Sub

    Private Sub InventoryEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads data from database into the datagrid
        Me.ItemListTableAdapter.Fill(Me.InventoryDataSet.ItemList)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        'Opens MainMenu when clicking the home button, closing the inventory form
        Dim choice As DialogResult = MsgBox("Would you like to save before returning to the Main Menu?", vbYesNoCancel, "Attention!")  'Asks users if they want to save before exiting
        If choice = DialogResult.No Then   'If they say no, it does not save before exiting
            MainMenu.Show()
            Me.Close()
        ElseIf choice = DialogResult.Yes Then   'If they say yes, it saves and exits if it can. If it can't save, it won't exit.

            'Update (19/5/17): Tests that all the rows in the data grid have a value and are not empty
            Dim convert As Boolean = True
            'Checks that each cell in every row has a value
            Dim empty As String = ""
            For i = 0 To ItemListGrid.RowCount - 2
                If IsDBNull(ItemListGrid.Item(1, i).Value) = True Or IsDBNull(ItemListGrid.Item(2, i).Value) = True Or IsDBNull(ItemListGrid.Item(3, i).Value) = True Then  'Checks for null cells
                    convert = False
                    Exit For
                ElseIf empty = CStr(ItemListGrid.Item(1, i).Value) Or empty = CStr(ItemListGrid.Item(2, i).Value) Or empty = CStr(ItemListGrid.Item(3, i).Value) Then  'Checks for empty cells
                    convert = False
                    Exit For
                End If
            Next

            If convert = True Then 'If there are no issues with data, it proceeds to save
                Try
                    ItemListBindingSource.EndEdit()
                    ItemListTableAdapter.Update(InventoryDataSet.ItemList)
                    MsgBox("Save Successful!", vbInformation, "Inventory Saved")
                    MainMenu.Show()
                    Me.Close()
                Catch ex As Exception    'Making sure it saves properly and the program doesn't just break instead
                    MsgBox("Save Failed! Check for any inconsistencies in the changes made.", vbCritical, "Error")
                End Try
            Else 'Else, it does not save
                MsgBox("Save Failed! Make sure all boxes are filled in properly.", vbCritical, "Error")
            End If

        End If   'Choosing cancel will let users remain on the inventory screen
    End Sub

    Private Sub New_Entry(sender As Object, e As EventArgs) Handles NewEntry.Click
        'Adds new entry to the database
        ItemListBindingSource.AddNew()
        Dim row As Integer = (ItemListGrid.RowCount - 3)
        ProductIDTextBox.Text = (ItemListGrid.Item(0, row).Value + 1)        'Makes sure the product ID of the new entry is the next in order
    End Sub

    Private Sub Delete_Entry(sender As Object, e As EventArgs) Handles DeleteEntry.Click
        'Removes selected entry to the database
        If MsgBox("Are you sure you want to remove the item from the inventory?", vbYesNo, "Deletion Confirmation") = DialogResult.Yes Then
            If ItemListGrid.RowCount > 1 Then
                ItemListBindingSource.RemoveCurrent()
                MsgBox("Item successfully removed!", vbInformation, "Item Removed")
            Else
                MsgBox("There are no items left to delete.", vbExclamation, "Attention!")
            End If
        End If
    End Sub

    Private Sub Save_Entry(sender As Object, e As EventArgs) Handles SaveEntry.Click
        'Change (19/5/17): Tests that ALL the cells in the data grid have a value and are not empty

        Dim convert As Boolean = True
        'Checks that each cell in every row has a value
        Dim empty As String = ""
        For i = 0 To ItemListGrid.RowCount - 2
            If IsDBNull(ItemListGrid.Item(1, i).Value) = True Or IsDBNull(ItemListGrid.Item(2, i).Value) = True Or IsDBNull(ItemListGrid.Item(3, i).Value) = True Then  'Checks for null cells
                convert = False
                Exit For
            ElseIf empty = CStr(ItemListGrid.Item(1, i).Value) Or empty = CStr(ItemListGrid.Item(2, i).Value) Or empty = CStr(ItemListGrid.Item(3, i).Value) Then  'Checks for empty cells
                convert = False
                Exit For
            End If
        Next

        If convert = True Then 'If there are no issues with data, it proceeds to save
            Try
                ItemListBindingSource.EndEdit()
                ItemListTableAdapter.Update(InventoryDataSet.ItemList)
                MsgBox("Save Successful!", vbInformation, "Inventory Saved")
            Catch ex As Exception    'Making sure it saves properly and the program doesn't just break instead
                MsgBox("Save Failed! Remove any inconsistencies/duplicates in the data.", vbCritical, "Error")
            End Try
        Else 'Else, it does not save
            MsgBox("Save Failed! Make sure all boxes are filled in properly.", vbCritical, "Error")
        End If

    End Sub

End Class