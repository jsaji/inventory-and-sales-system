<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckOutButton
        '
        Me.CheckOutButton.BackColor = System.Drawing.Color.LightGreen
        Me.CheckOutButton.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutButton.Location = New System.Drawing.Point(365, 237)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(550, 150)
        Me.CheckOutButton.TabIndex = 0
        Me.CheckOutButton.Text = "Checkout"
        Me.CheckOutButton.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.InventoryButton.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.Location = New System.Drawing.Point(365, 429)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(550, 150)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventory"
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1201, 652)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "v1.1.7"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Tomato
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1264, 178)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HONEYDUKES' GROCERY SHOP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.Color.LightCoral
        Me.HelpButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton.Location = New System.Drawing.Point(14, 615)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(164, 54)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InventoryButton)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckOutButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpButton As Button
End Class
