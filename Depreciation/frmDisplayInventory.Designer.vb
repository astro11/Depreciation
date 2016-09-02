<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        Me.picMan2 = New System.Windows.Forms.PictureBox()
        Me.lblSortedInventory = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.picMan2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMan2
        '
        Me.picMan2.Image = Global.Depreciation.My.Resources.Resources.Logo
        Me.picMan2.Location = New System.Drawing.Point(0, 12)
        Me.picMan2.Name = "picMan2"
        Me.picMan2.Size = New System.Drawing.Size(109, 90)
        Me.picMan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMan2.TabIndex = 0
        Me.picMan2.TabStop = False
        '
        'lblSortedInventory
        '
        Me.lblSortedInventory.AutoSize = True
        Me.lblSortedInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortedInventory.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSortedInventory.Location = New System.Drawing.Point(115, 33)
        Me.lblSortedInventory.Name = "lblSortedInventory"
        Me.lblSortedInventory.Size = New System.Drawing.Size(278, 25)
        Me.lblSortedInventory.TabIndex = 1
        Me.lblSortedInventory.Text = "Trends Menswear Inventory"
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.Gray
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Items.AddRange(New Object() {"Chairs", "End Cap Displays", "Hangers", "Mannequins", "Office Computers", "Point of Sale Registers", "Sofas", "Store Display Racks"})
        Me.lstDisplay.Location = New System.Drawing.Point(120, 94)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(207, 164)
        Me.lstDisplay.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Gray
        Me.btnReturn.Location = New System.Drawing.Point(120, 301)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(207, 49)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmDisplayInventory
        '
        Me.AcceptButton = Me.btnReturn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(405, 381)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblSortedInventory)
        Me.Controls.Add(Me.picMan2)
        Me.Name = "frmDisplayInventory"
        Me.Text = "Sorted Inventory Listing"
        CType(Me.picMan2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMan2 As PictureBox
    Friend WithEvents lblSortedInventory As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnReturn As Button
End Class
