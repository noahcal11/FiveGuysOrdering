<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnEntrees = New System.Windows.Forms.Button()
        Me.btnFries = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnGoToCheckout = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.lstMainMenu = New System.Windows.Forms.ListBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEntrees
        '
        Me.btnEntrees.BackColor = System.Drawing.Color.Black
        Me.btnEntrees.Font = New System.Drawing.Font("Tekton Pro", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntrees.ForeColor = System.Drawing.Color.White
        Me.btnEntrees.Location = New System.Drawing.Point(275, 176)
        Me.btnEntrees.Name = "btnEntrees"
        Me.btnEntrees.Size = New System.Drawing.Size(146, 77)
        Me.btnEntrees.TabIndex = 1
        Me.btnEntrees.Text = "Entrees"
        Me.btnEntrees.UseVisualStyleBackColor = False
        '
        'btnFries
        '
        Me.btnFries.BackColor = System.Drawing.Color.Black
        Me.btnFries.Font = New System.Drawing.Font("Tekton Pro", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnFries.ForeColor = System.Drawing.Color.White
        Me.btnFries.Location = New System.Drawing.Point(454, 176)
        Me.btnFries.Name = "btnFries"
        Me.btnFries.Size = New System.Drawing.Size(146, 77)
        Me.btnFries.TabIndex = 2
        Me.btnFries.Text = "Fries"
        Me.btnFries.UseVisualStyleBackColor = False
        '
        'btnDrinks
        '
        Me.btnDrinks.BackColor = System.Drawing.Color.Black
        Me.btnDrinks.Font = New System.Drawing.Font("Tekton Pro", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnDrinks.ForeColor = System.Drawing.Color.White
        Me.btnDrinks.Location = New System.Drawing.Point(633, 176)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(146, 77)
        Me.btnDrinks.TabIndex = 3
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = False
        '
        'btnGoToCheckout
        '
        Me.btnGoToCheckout.BackColor = System.Drawing.Color.Black
        Me.btnGoToCheckout.Font = New System.Drawing.Font("Tekton Pro", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnGoToCheckout.ForeColor = System.Drawing.Color.White
        Me.btnGoToCheckout.Location = New System.Drawing.Point(365, 287)
        Me.btnGoToCheckout.Name = "btnGoToCheckout"
        Me.btnGoToCheckout.Size = New System.Drawing.Size(146, 77)
        Me.btnGoToCheckout.TabIndex = 4
        Me.btnGoToCheckout.Text = "Go To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Checkout"
        Me.btnGoToCheckout.UseVisualStyleBackColor = False
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.Color.Black
        Me.btnCancelOrder.Font = New System.Drawing.Font("Tekton Pro", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnCancelOrder.Location = New System.Drawing.Point(545, 287)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(146, 77)
        Me.btnCancelOrder.TabIndex = 5
        Me.btnCancelOrder.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'lstMainMenu
        '
        Me.lstMainMenu.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMainMenu.FormattingEnabled = True
        Me.lstMainMenu.ItemHeight = 17
        Me.lstMainMenu.Location = New System.Drawing.Point(22, 126)
        Me.lstMainMenu.Name = "lstMainMenu"
        Me.lstMainMenu.Size = New System.Drawing.Size(224, 293)
        Me.lstMainMenu.TabIndex = 6
        '
        'picLogo
        '
        Me.picLogo.Image = Global.FiveGuysOrdering.My.Resources.Resources.FiveGuysLogo__2_
        Me.picLogo.Location = New System.Drawing.Point(257, 21)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(286, 75)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstMainMenu)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnGoToCheckout)
        Me.Controls.Add(Me.btnDrinks)
        Me.Controls.Add(Me.btnFries)
        Me.Controls.Add(Me.btnEntrees)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "Five Guys"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnEntrees As Button
    Friend WithEvents btnFries As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnGoToCheckout As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents lstMainMenu As ListBox
End Class
