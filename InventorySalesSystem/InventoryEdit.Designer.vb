<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryEdit
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
        Me.components = New System.ComponentModel.Container()
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim Size__g_Label As System.Windows.Forms.Label
        Dim Price____Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryEdit))
        Me.InventoryDataSet = New InventorySalesSystem.InventoryDataSet()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New InventorySalesSystem.InventoryDataSetTableAdapters.ItemListTableAdapter()
        Me.TableAdapterManager = New InventorySalesSystem.InventoryDataSetTableAdapters.TableAdapterManager()
        Me.ItemListGrid = New System.Windows.Forms.DataGridView()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.Size__g_TextBox = New System.Windows.Forms.TextBox()
        Me.Price____TextBox = New System.Windows.Forms.TextBox()
        Me.Home = New System.Windows.Forms.Button()
        Me.NewEntry = New System.Windows.Forms.Button()
        Me.DeleteEntry = New System.Windows.Forms.Button()
        Me.SaveEntry = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        Size__g_Label = New System.Windows.Forms.Label()
        Price____Label = New System.Windows.Forms.Label()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.Location = New System.Drawing.Point(58, 56)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(117, 30)
        ProductIDLabel.TabIndex = 2
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(58, 106)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(152, 30)
        ProductNameLabel.TabIndex = 4
        ProductNameLabel.Text = "Product Name:"
        '
        'Size__g_Label
        '
        Size__g_Label.AutoSize = True
        Size__g_Label.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Size__g_Label.Location = New System.Drawing.Point(58, 156)
        Size__g_Label.Name = "Size__g_Label"
        Size__g_Label.Size = New System.Drawing.Size(85, 30)
        Size__g_Label.TabIndex = 6
        Size__g_Label.Text = "Size (g):"
        '
        'Price____Label
        '
        Price____Label.AutoSize = True
        Price____Label.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Price____Label.Location = New System.Drawing.Point(58, 206)
        Price____Label.Name = "Price____Label"
        Price____Label.Size = New System.Drawing.Size(92, 30)
        Price____Label.TabIndex = 8
        Price____Label.Text = "Price ($):"
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "InventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = InventorySalesSystem.InventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemListGrid
        '
        Me.ItemListGrid.AllowUserToDeleteRows = False
        Me.ItemListGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ItemListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemListGrid.AutoGenerateColumns = False
        Me.ItemListGrid.BackgroundColor = System.Drawing.Color.White
        Me.ItemListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemListGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemListGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ItemListGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemListGrid.DataSource = Me.ItemListBindingSource
        Me.ItemListGrid.Location = New System.Drawing.Point(3, 3)
        Me.ItemListGrid.Name = "ItemListGrid"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ItemListGrid.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ItemListGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemListGrid.Size = New System.Drawing.Size(637, 493)
        Me.ItemListGrid.TabIndex = 1
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(223, 56)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(312, 35)
        Me.ProductIDTextBox.TabIndex = 3
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(223, 106)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(312, 35)
        Me.ProductNameTextBox.TabIndex = 5
        '
        'Size__g_TextBox
        '
        Me.Size__g_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "Size (g)", True))
        Me.Size__g_TextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size__g_TextBox.Location = New System.Drawing.Point(223, 156)
        Me.Size__g_TextBox.Name = "Size__g_TextBox"
        Me.Size__g_TextBox.Size = New System.Drawing.Size(312, 35)
        Me.Size__g_TextBox.TabIndex = 7
        '
        'Price____TextBox
        '
        Me.Price____TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "Price ($)", True))
        Me.Price____TextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price____TextBox.Location = New System.Drawing.Point(223, 206)
        Me.Price____TextBox.Name = "Price____TextBox"
        Me.Price____TextBox.Size = New System.Drawing.Size(312, 35)
        Me.Price____TextBox.TabIndex = 9
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(945, 553)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(300, 100)
        Me.Home.TabIndex = 10
        Me.Home.Text = "Return To Main Menu"
        Me.Home.UseVisualStyleBackColor = True
        '
        'NewEntry
        '
        Me.NewEntry.BackColor = System.Drawing.Color.LightGreen
        Me.NewEntry.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewEntry.Location = New System.Drawing.Point(63, 326)
        Me.NewEntry.Name = "NewEntry"
        Me.NewEntry.Size = New System.Drawing.Size(472, 75)
        Me.NewEntry.TabIndex = 11
        Me.NewEntry.Text = "Add New Item"
        Me.NewEntry.UseVisualStyleBackColor = False
        '
        'DeleteEntry
        '
        Me.DeleteEntry.BackColor = System.Drawing.Color.LightCoral
        Me.DeleteEntry.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteEntry.Location = New System.Drawing.Point(63, 436)
        Me.DeleteEntry.Name = "DeleteEntry"
        Me.DeleteEntry.Size = New System.Drawing.Size(472, 75)
        Me.DeleteEntry.TabIndex = 12
        Me.DeleteEntry.Text = "Delete Item"
        Me.DeleteEntry.UseVisualStyleBackColor = False
        '
        'SaveEntry
        '
        Me.SaveEntry.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SaveEntry.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveEntry.Location = New System.Drawing.Point(63, 546)
        Me.SaveEntry.Name = "SaveEntry"
        Me.SaveEntry.Size = New System.Drawing.Size(472, 75)
        Me.SaveEntry.TabIndex = 13
        Me.SaveEntry.Text = "Save Inventory"
        Me.SaveEntry.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ItemListGrid)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(602, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 499)
        Me.Panel1.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 330
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Size (g)"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "#g"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price ($)"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'InventoryEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1257, 665)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SaveEntry)
        Me.Controls.Add(Me.DeleteEntry)
        Me.Controls.Add(Me.NewEntry)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Size__g_Label)
        Me.Controls.Add(Me.Size__g_TextBox)
        Me.Controls.Add(Price____Label)
        Me.Controls.Add(Me.Price____TextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1262, 669)
        Me.Name = "InventoryEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InventoryDataSet As InventoryDataSet
    Friend WithEvents ItemListBindingSource As BindingSource
    Friend WithEvents ItemListTableAdapter As InventoryDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As InventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListGrid As DataGridView
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Size__g_TextBox As TextBox
    Friend WithEvents Price____TextBox As TextBox
    Friend WithEvents Home As Button
    Friend WithEvents NewEntry As Button
    Friend WithEvents DeleteEntry As Button
    Friend WithEvents SaveEntry As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
