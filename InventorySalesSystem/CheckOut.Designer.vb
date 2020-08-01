<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Me.RemoveProduct = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InventoryList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InventoryGrid = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemListBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet = New InventorySalesSystem.InventoryDataSet()
        Me.AddProduct = New System.Windows.Forms.Button()
        Me.CancelCheckout = New System.Windows.Forms.Button()
        Me.ProceedPayment = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckoutList = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalShow = New System.Windows.Forms.Label()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New InventorySalesSystem.InventoryDataSetTableAdapters.ItemListTableAdapter()
        Me.ItemListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.InventoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemoveProduct
        '
        Me.RemoveProduct.BackColor = System.Drawing.Color.LightCoral
        Me.RemoveProduct.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveProduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RemoveProduct.Location = New System.Drawing.Point(6, 475)
        Me.RemoveProduct.Name = "RemoveProduct"
        Me.RemoveProduct.Size = New System.Drawing.Size(603, 70)
        Me.RemoveProduct.TabIndex = 22
        Me.RemoveProduct.Text = "Remove Product From Checkout"
        Me.RemoveProduct.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InventoryList)
        Me.GroupBox1.Controls.Add(Me.InventoryGrid)
        Me.GroupBox1.Controls.Add(Me.AddProduct)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 551)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory"
        '
        'InventoryList
        '
        Me.InventoryList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.InventoryList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InventoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.InventoryList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryList.FullRowSelect = True
        Me.InventoryList.GridLines = True
        Me.InventoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.InventoryList.HideSelection = False
        Me.InventoryList.Location = New System.Drawing.Point(6, 26)
        Me.InventoryList.Name = "InventoryList"
        Me.InventoryList.Size = New System.Drawing.Size(603, 443)
        Me.InventoryList.TabIndex = 23
        Me.InventoryList.UseCompatibleStateImageBehavior = False
        Me.InventoryList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 330
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 90
        '
        'InventoryGrid
        '
        Me.InventoryGrid.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.SizegDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.InventoryGrid.DataSource = Me.ItemListBindingSource2
        Me.InventoryGrid.Location = New System.Drawing.Point(6, 26)
        Me.InventoryGrid.Name = "InventoryGrid"
        Me.InventoryGrid.Size = New System.Drawing.Size(603, 443)
        Me.InventoryGrid.TabIndex = 10
        Me.InventoryGrid.Visible = False
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Width = 85
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 270
        '
        'SizegDataGridViewTextBoxColumn
        '
        Me.SizegDataGridViewTextBoxColumn.DataPropertyName = "Size (g)"
        Me.SizegDataGridViewTextBoxColumn.HeaderText = "Size (g)"
        Me.SizegDataGridViewTextBoxColumn.Name = "SizegDataGridViewTextBoxColumn"
        Me.SizegDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizegDataGridViewTextBoxColumn.Width = 90
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price ($)"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price ($)"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 90
        '
        'ItemListBindingSource2
        '
        Me.ItemListBindingSource2.DataMember = "ItemList"
        Me.ItemListBindingSource2.DataSource = Me.InventoryDataSet
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "InventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddProduct
        '
        Me.AddProduct.BackColor = System.Drawing.Color.LightGreen
        Me.AddProduct.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProduct.Location = New System.Drawing.Point(6, 475)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(603, 70)
        Me.AddProduct.TabIndex = 19
        Me.AddProduct.Text = "Add Product To Checkout"
        Me.AddProduct.UseVisualStyleBackColor = False
        '
        'CancelCheckout
        '
        Me.CancelCheckout.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelCheckout.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelCheckout.Location = New System.Drawing.Point(12, 569)
        Me.CancelCheckout.Name = "CancelCheckout"
        Me.CancelCheckout.Size = New System.Drawing.Size(300, 100)
        Me.CancelCheckout.TabIndex = 18
        Me.CancelCheckout.Text = "Return To Main Menu"
        Me.CancelCheckout.UseVisualStyleBackColor = False
        '
        'ProceedPayment
        '
        Me.ProceedPayment.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ProceedPayment.Enabled = False
        Me.ProceedPayment.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProceedPayment.Location = New System.Drawing.Point(952, 569)
        Me.ProceedPayment.Name = "ProceedPayment"
        Me.ProceedPayment.Size = New System.Drawing.Size(300, 100)
        Me.ProceedPayment.TabIndex = 17
        Me.ProceedPayment.Text = "Proceed to Payment"
        Me.ProceedPayment.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemoveProduct)
        Me.GroupBox2.Controls.Add(Me.CheckoutList)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(637, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 551)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Checkout"
        '
        'CheckoutList
        '
        Me.CheckoutList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.CheckoutList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductName, Me.Size, Me.Price})
        Me.CheckoutList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutList.FullRowSelect = True
        Me.CheckoutList.GridLines = True
        Me.CheckoutList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.CheckoutList.HideSelection = False
        Me.CheckoutList.Location = New System.Drawing.Point(6, 26)
        Me.CheckoutList.Name = "CheckoutList"
        Me.CheckoutList.Size = New System.Drawing.Size(603, 443)
        Me.CheckoutList.TabIndex = 18
        Me.CheckoutList.UseCompatibleStateImageBehavior = False
        Me.CheckoutList.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "ID"
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 330
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
        'TotalShow
        '
        Me.TotalShow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalShow.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalShow.Location = New System.Drawing.Point(0, 560)
        Me.TotalShow.Name = "TotalShow"
        Me.TotalShow.Size = New System.Drawing.Size(1264, 121)
        Me.TotalShow.TabIndex = 17
        Me.TotalShow.Text = "Total: $"
        Me.TotalShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.InventoryDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemListBindingSource1
        '
        Me.ItemListBindingSource1.DataMember = "ItemList"
        Me.ItemListBindingSource1.DataSource = Me.InventoryDataSet
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelCheckout)
        Me.Controls.Add(Me.ProceedPayment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TotalShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "CheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.InventoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InventoryDataSet As InventoryDataSet
    Friend WithEvents ItemListBindingSource As BindingSource
    Friend WithEvents ItemListTableAdapter As InventoryDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents ItemListBindingSource1 As BindingSource
    Friend WithEvents ItemListBindingSource2 As BindingSource
    Friend WithEvents RemoveProduct As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddProduct As Button
    Friend WithEvents CancelCheckout As Button
    Friend WithEvents ProceedPayment As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckoutList As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents TotalShow As Label
    Friend WithEvents InventoryList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents InventoryGrid As DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
