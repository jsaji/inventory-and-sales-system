<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.customerCash = New System.Windows.Forms.MaskedTextBox()
        Me.BillBox = New System.Windows.Forms.GroupBox()
        Me.FinalCheckout = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.confirm = New System.Windows.Forms.Button()
        Me.NextCheckout = New System.Windows.Forms.Button()
        Me.CancelPayment = New System.Windows.Forms.Button()
        Me.ChangeOwed = New System.Windows.Forms.Label()
        Me.AmountDue = New System.Windows.Forms.Label()
        Me.AmountPaid = New System.Windows.Forms.Label()
        Me.ReturnScreen = New System.Windows.Forms.Button()
        Me.SortBy = New System.Windows.Forms.Button()
        Me.BillBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'customerCash
        '
        Me.customerCash.AsciiOnly = True
        Me.customerCash.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerCash.Location = New System.Drawing.Point(291, 295)
        Me.customerCash.Name = "customerCash"
        Me.customerCash.ShortcutsEnabled = False
        Me.customerCash.Size = New System.Drawing.Size(123, 54)
        Me.customerCash.TabIndex = 25
        '
        'BillBox
        '
        Me.BillBox.Controls.Add(Me.FinalCheckout)
        Me.BillBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BillBox.Location = New System.Drawing.Point(635, 12)
        Me.BillBox.Name = "BillBox"
        Me.BillBox.Size = New System.Drawing.Size(617, 535)
        Me.BillBox.TabIndex = 24
        Me.BillBox.TabStop = False
        Me.BillBox.Text = "Final Checkout List"
        '
        'FinalCheckout
        '
        Me.FinalCheckout.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductName, Me.Size, Me.Price})
        Me.FinalCheckout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalCheckout.FullRowSelect = True
        Me.FinalCheckout.GridLines = True
        Me.FinalCheckout.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.FinalCheckout.HideSelection = False
        Me.FinalCheckout.Location = New System.Drawing.Point(6, 26)
        Me.FinalCheckout.Name = "FinalCheckout"
        Me.FinalCheckout.Size = New System.Drawing.Size(605, 503)
        Me.FinalCheckout.TabIndex = 18
        Me.FinalCheckout.UseCompatibleStateImageBehavior = False
        Me.FinalCheckout.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "ID"
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 333
        '
        'Size
        '
        Me.Size.Text = "Size"
        Me.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Size.Width = 90
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Price.Width = 90
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.LightGreen
        Me.confirm.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.Location = New System.Drawing.Point(420, 295)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(123, 54)
        Me.confirm.TabIndex = 23
        Me.confirm.Text = "OK"
        Me.confirm.UseVisualStyleBackColor = False
        '
        'NextCheckout
        '
        Me.NextCheckout.BackColor = System.Drawing.Color.LightSkyBlue
        Me.NextCheckout.Enabled = False
        Me.NextCheckout.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextCheckout.Location = New System.Drawing.Point(952, 569)
        Me.NextCheckout.Name = "NextCheckout"
        Me.NextCheckout.Size = New System.Drawing.Size(300, 100)
        Me.NextCheckout.TabIndex = 22
        Me.NextCheckout.Text = "Next Customer Checkout"
        Me.NextCheckout.UseVisualStyleBackColor = False
        '
        'CancelPayment
        '
        Me.CancelPayment.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPayment.Location = New System.Drawing.Point(12, 569)
        Me.CancelPayment.Name = "CancelPayment"
        Me.CancelPayment.Size = New System.Drawing.Size(300, 100)
        Me.CancelPayment.TabIndex = 21
        Me.CancelPayment.Text = "Return To Main Menu"
        Me.CancelPayment.UseVisualStyleBackColor = True
        '
        'ChangeOwed
        '
        Me.ChangeOwed.AutoSize = True
        Me.ChangeOwed.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeOwed.Location = New System.Drawing.Point(56, 440)
        Me.ChangeOwed.Name = "ChangeOwed"
        Me.ChangeOwed.Size = New System.Drawing.Size(239, 46)
        Me.ChangeOwed.TabIndex = 20
        Me.ChangeOwed.Text = "Change Owed:"
        '
        'AmountDue
        '
        Me.AmountDue.AutoSize = True
        Me.AmountDue.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDue.Location = New System.Drawing.Point(56, 160)
        Me.AmountDue.Name = "AmountDue"
        Me.AmountDue.Size = New System.Drawing.Size(218, 46)
        Me.AmountDue.TabIndex = 19
        Me.AmountDue.Text = "Amount Due:"
        '
        'AmountPaid
        '
        Me.AmountPaid.AutoSize = True
        Me.AmountPaid.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountPaid.Location = New System.Drawing.Point(56, 300)
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.Size = New System.Drawing.Size(247, 46)
        Me.AmountPaid.TabIndex = 18
        Me.AmountPaid.Text = "Amount Paid: $"
        '
        'ReturnScreen
        '
        Me.ReturnScreen.BackColor = System.Drawing.Color.LightCoral
        Me.ReturnScreen.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnScreen.Location = New System.Drawing.Point(12, 12)
        Me.ReturnScreen.Name = "ReturnScreen"
        Me.ReturnScreen.Size = New System.Drawing.Size(300, 100)
        Me.ReturnScreen.TabIndex = 26
        Me.ReturnScreen.Text = "Return to Checkout"
        Me.ReturnScreen.UseVisualStyleBackColor = False
        '
        'SortBy
        '
        Me.SortBy.BackColor = System.Drawing.Color.LightGreen
        Me.SortBy.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortBy.Location = New System.Drawing.Point(635, 569)
        Me.SortBy.Name = "SortBy"
        Me.SortBy.Size = New System.Drawing.Size(300, 100)
        Me.SortBy.TabIndex = 27
        Me.SortBy.Text = "Sort By Price"
        Me.SortBy.UseVisualStyleBackColor = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SortBy)
        Me.Controls.Add(Me.ReturnScreen)
        Me.Controls.Add(Me.customerCash)
        Me.Controls.Add(Me.BillBox)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.NextCheckout)
        Me.Controls.Add(Me.CancelPayment)
        Me.Controls.Add(Me.ChangeOwed)
        Me.Controls.Add(Me.AmountDue)
        Me.Controls.Add(Me.AmountPaid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.BillBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerCash As MaskedTextBox
    Friend WithEvents BillBox As GroupBox
    Friend WithEvents confirm As Button
    Friend WithEvents NextCheckout As Button
    Friend WithEvents CancelPayment As Button
    Friend WithEvents ChangeOwed As Label
    Friend WithEvents AmountDue As Label
    Friend WithEvents AmountPaid As Label
    Friend WithEvents ReturnScreen As Button
    Friend WithEvents FinalCheckout As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents SortBy As Button
End Class
