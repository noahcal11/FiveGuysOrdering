<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSandwiches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSandwiches))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnEntrees = New System.Windows.Forms.Button()
        Me.lblSandwiches = New System.Windows.Forms.Label()
        Me.lblVeggie = New System.Windows.Forms.Label()
        Me.lblGrilledCheese = New System.Windows.Forms.Label()
        Me.lblBLT = New System.Windows.Forms.Label()
        Me.picBLT = New System.Windows.Forms.PictureBox()
        Me.picGrilledCheese = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnGrilledCheese = New System.Windows.Forms.Button()
        Me.btnBLT = New System.Windows.Forms.Button()
        Me.lblVeggiePrice = New System.Windows.Forms.Label()
        Me.lblGrilledCheesePrice = New System.Windows.Forms.Label()
        Me.lblBLTPrice = New System.Windows.Forms.Label()
        Me.chkVeggieCheese = New System.Windows.Forms.CheckBox()
        CType(Me.picBLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrilledCheese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Black
        Me.btnMainMenu.Font = New System.Drawing.Font("Tekton Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(670, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(118, 57)
        Me.btnMainMenu.TabIndex = 10
        Me.btnMainMenu.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnEntrees
        '
        Me.btnEntrees.BackColor = System.Drawing.Color.Black
        Me.btnEntrees.Font = New System.Drawing.Font("Tekton Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntrees.ForeColor = System.Drawing.Color.White
        Me.btnEntrees.Location = New System.Drawing.Point(670, 75)
        Me.btnEntrees.Name = "btnEntrees"
        Me.btnEntrees.Size = New System.Drawing.Size(118, 57)
        Me.btnEntrees.TabIndex = 11
        Me.btnEntrees.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ENTREES"
        Me.btnEntrees.UseVisualStyleBackColor = False
        '
        'lblSandwiches
        '
        Me.lblSandwiches.AutoSize = True
        Me.lblSandwiches.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSandwiches.ForeColor = System.Drawing.Color.White
        Me.lblSandwiches.Location = New System.Drawing.Point(204, 9)
        Me.lblSandwiches.Name = "lblSandwiches"
        Me.lblSandwiches.Size = New System.Drawing.Size(393, 68)
        Me.lblSandwiches.TabIndex = 12
        Me.lblSandwiches.Text = "SANDWICHES"
        '
        'lblVeggie
        '
        Me.lblVeggie.AutoSize = True
        Me.lblVeggie.Font = New System.Drawing.Font("Perpetua Titling MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblVeggie.ForeColor = System.Drawing.Color.Black
        Me.lblVeggie.Location = New System.Drawing.Point(2, 100)
        Me.lblVeggie.Name = "lblVeggie"
        Me.lblVeggie.Size = New System.Drawing.Size(290, 32)
        Me.lblVeggie.TabIndex = 13
        Me.lblVeggie.Text = "Veggie Sandwich"
        '
        'lblGrilledCheese
        '
        Me.lblGrilledCheese.AutoSize = True
        Me.lblGrilledCheese.Font = New System.Drawing.Font("Perpetua Titling MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrilledCheese.ForeColor = System.Drawing.Color.Black
        Me.lblGrilledCheese.Location = New System.Drawing.Point(298, 100)
        Me.lblGrilledCheese.Name = "lblGrilledCheese"
        Me.lblGrilledCheese.Size = New System.Drawing.Size(251, 32)
        Me.lblGrilledCheese.TabIndex = 14
        Me.lblGrilledCheese.Text = "Grilled Cheese"
        '
        'lblBLT
        '
        Me.lblBLT.AutoSize = True
        Me.lblBLT.Font = New System.Drawing.Font("Perpetua Titling MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBLT.ForeColor = System.Drawing.Color.Black
        Me.lblBLT.Location = New System.Drawing.Point(589, 100)
        Me.lblBLT.Name = "lblBLT"
        Me.lblBLT.Size = New System.Drawing.Size(69, 32)
        Me.lblBLT.TabIndex = 15
        Me.lblBLT.Text = "BLT"
        '
        'picBLT
        '
        Me.picBLT.Image = Global.FiveGuysOrdering.My.Resources.Resources.FiveGuysBLT
        Me.picBLT.Location = New System.Drawing.Point(544, 148)
        Me.picBLT.Name = "picBLT"
        Me.picBLT.Size = New System.Drawing.Size(159, 155)
        Me.picBLT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBLT.TabIndex = 18
        Me.picBLT.TabStop = False
        '
        'picGrilledCheese
        '
        Me.picGrilledCheese.Image = Global.FiveGuysOrdering.My.Resources.Resources.GrilledCheeseButton
        Me.picGrilledCheese.Location = New System.Drawing.Point(319, 148)
        Me.picGrilledCheese.Name = "picGrilledCheese"
        Me.picGrilledCheese.Size = New System.Drawing.Size(208, 155)
        Me.picGrilledCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGrilledCheese.TabIndex = 17
        Me.picGrilledCheese.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Image = Global.FiveGuysOrdering.My.Resources.Resources.FiveGuysVeggie
        Me.picVeggie.Location = New System.Drawing.Point(32, 148)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(231, 155)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVeggie.TabIndex = 16
        Me.picVeggie.TabStop = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.Color.Black
        Me.btnVeggie.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnVeggie.ForeColor = System.Drawing.Color.White
        Me.btnVeggie.Location = New System.Drawing.Point(62, 336)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(170, 33)
        Me.btnVeggie.TabIndex = 19
        Me.btnVeggie.Text = "Select Toppings"
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'btnGrilledCheese
        '
        Me.btnGrilledCheese.BackColor = System.Drawing.Color.Black
        Me.btnGrilledCheese.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnGrilledCheese.ForeColor = System.Drawing.Color.White
        Me.btnGrilledCheese.Location = New System.Drawing.Point(354, 336)
        Me.btnGrilledCheese.Name = "btnGrilledCheese"
        Me.btnGrilledCheese.Size = New System.Drawing.Size(138, 33)
        Me.btnGrilledCheese.TabIndex = 20
        Me.btnGrilledCheese.Text = "Add to Order"
        Me.btnGrilledCheese.UseVisualStyleBackColor = False
        '
        'btnBLT
        '
        Me.btnBLT.BackColor = System.Drawing.Color.Black
        Me.btnBLT.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnBLT.ForeColor = System.Drawing.Color.White
        Me.btnBLT.Location = New System.Drawing.Point(554, 336)
        Me.btnBLT.Name = "btnBLT"
        Me.btnBLT.Size = New System.Drawing.Size(138, 33)
        Me.btnBLT.TabIndex = 21
        Me.btnBLT.Text = "Add to Order"
        Me.btnBLT.UseVisualStyleBackColor = False
        '
        'lblVeggiePrice
        '
        Me.lblVeggiePrice.AutoSize = True
        Me.lblVeggiePrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeggiePrice.ForeColor = System.Drawing.Color.White
        Me.lblVeggiePrice.Location = New System.Drawing.Point(109, 381)
        Me.lblVeggiePrice.Name = "lblVeggiePrice"
        Me.lblVeggiePrice.Size = New System.Drawing.Size(75, 29)
        Me.lblVeggiePrice.TabIndex = 22
        Me.lblVeggiePrice.Text = "$4.19"
        '
        'lblGrilledCheesePrice
        '
        Me.lblGrilledCheesePrice.AutoSize = True
        Me.lblGrilledCheesePrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrilledCheesePrice.ForeColor = System.Drawing.Color.White
        Me.lblGrilledCheesePrice.Location = New System.Drawing.Point(388, 381)
        Me.lblGrilledCheesePrice.Name = "lblGrilledCheesePrice"
        Me.lblGrilledCheesePrice.Size = New System.Drawing.Size(75, 29)
        Me.lblGrilledCheesePrice.TabIndex = 23
        Me.lblGrilledCheesePrice.Text = "$4.89"
        '
        'lblBLTPrice
        '
        Me.lblBLTPrice.AutoSize = True
        Me.lblBLTPrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBLTPrice.ForeColor = System.Drawing.Color.White
        Me.lblBLTPrice.Location = New System.Drawing.Point(586, 381)
        Me.lblBLTPrice.Name = "lblBLTPrice"
        Me.lblBLTPrice.Size = New System.Drawing.Size(75, 29)
        Me.lblBLTPrice.TabIndex = 24
        Me.lblBLTPrice.Text = "$6.09"
        '
        'chkVeggieCheese
        '
        Me.chkVeggieCheese.AutoSize = True
        Me.chkVeggieCheese.Font = New System.Drawing.Font("Tekton Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVeggieCheese.ForeColor = System.Drawing.Color.White
        Me.chkVeggieCheese.Location = New System.Drawing.Point(46, 309)
        Me.chkVeggieCheese.Name = "chkVeggieCheese"
        Me.chkVeggieCheese.Size = New System.Drawing.Size(202, 27)
        Me.chkVeggieCheese.TabIndex = 25
        Me.chkVeggieCheese.Text = "With Cheese? ($0.80)"
        Me.chkVeggieCheese.UseVisualStyleBackColor = True
        '
        'frmSandwiches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkVeggieCheese)
        Me.Controls.Add(Me.lblBLTPrice)
        Me.Controls.Add(Me.lblGrilledCheesePrice)
        Me.Controls.Add(Me.lblVeggiePrice)
        Me.Controls.Add(Me.btnBLT)
        Me.Controls.Add(Me.btnGrilledCheese)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.picBLT)
        Me.Controls.Add(Me.picGrilledCheese)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.lblBLT)
        Me.Controls.Add(Me.lblGrilledCheese)
        Me.Controls.Add(Me.lblVeggie)
        Me.Controls.Add(Me.lblSandwiches)
        Me.Controls.Add(Me.btnEntrees)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSandwiches"
        Me.Text = "Five Guys"
        CType(Me.picBLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrilledCheese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnEntrees As Button
    Friend WithEvents lblSandwiches As Label
    Friend WithEvents lblVeggie As Label
    Friend WithEvents lblGrilledCheese As Label
    Friend WithEvents lblBLT As Label
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents picGrilledCheese As PictureBox
    Friend WithEvents picBLT As PictureBox
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnGrilledCheese As Button
    Friend WithEvents btnBLT As Button
    Friend WithEvents lblVeggiePrice As Label
    Friend WithEvents lblGrilledCheesePrice As Label
    Friend WithEvents lblBLTPrice As Label
    Friend WithEvents chkVeggieCheese As CheckBox
End Class
