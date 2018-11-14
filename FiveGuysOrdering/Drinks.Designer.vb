<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrinks))
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnRegDrink = New System.Windows.Forms.Button()
        Me.lblRegDrink = New System.Windows.Forms.Label()
        Me.btnLgDrink = New System.Windows.Forms.Button()
        Me.btnWater = New System.Windows.Forms.Button()
        Me.lblLgDrink = New System.Windows.Forms.Label()
        Me.lblWater = New System.Windows.Forms.Label()
        Me.picWater = New System.Windows.Forms.PictureBox()
        Me.picLgDrink = New System.Windows.Forms.PictureBox()
        Me.picRegDrink = New System.Windows.Forms.PictureBox()
        Me.lblWaterPrice = New System.Windows.Forms.Label()
        Me.lblLgDrinkPrice = New System.Windows.Forms.Label()
        Me.lblRegDrinkPrice = New System.Windows.Forms.Label()
        CType(Me.picWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLgDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRegDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.ForeColor = System.Drawing.Color.White
        Me.lblDrinks.Location = New System.Drawing.Point(282, 9)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(237, 68)
        Me.lblDrinks.TabIndex = 2
        Me.lblDrinks.Text = "DRINKS"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Black
        Me.btnMainMenu.Font = New System.Drawing.Font("Tekton Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(670, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(118, 57)
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnRegDrink
        '
        Me.btnRegDrink.BackColor = System.Drawing.Color.Black
        Me.btnRegDrink.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegDrink.ForeColor = System.Drawing.Color.White
        Me.btnRegDrink.Location = New System.Drawing.Point(64, 358)
        Me.btnRegDrink.Name = "btnRegDrink"
        Me.btnRegDrink.Size = New System.Drawing.Size(138, 33)
        Me.btnRegDrink.TabIndex = 6
        Me.btnRegDrink.Text = "Add to Order"
        Me.btnRegDrink.UseVisualStyleBackColor = False
        '
        'lblRegDrink
        '
        Me.lblRegDrink.AutoSize = True
        Me.lblRegDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegDrink.Location = New System.Drawing.Point(24, 117)
        Me.lblRegDrink.Name = "lblRegDrink"
        Me.lblRegDrink.Size = New System.Drawing.Size(173, 29)
        Me.lblRegDrink.TabIndex = 8
        Me.lblRegDrink.Text = "Regular Drink"
        '
        'btnLgDrink
        '
        Me.btnLgDrink.BackColor = System.Drawing.Color.Black
        Me.btnLgDrink.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnLgDrink.ForeColor = System.Drawing.Color.White
        Me.btnLgDrink.Location = New System.Drawing.Point(319, 358)
        Me.btnLgDrink.Name = "btnLgDrink"
        Me.btnLgDrink.Size = New System.Drawing.Size(138, 33)
        Me.btnLgDrink.TabIndex = 9
        Me.btnLgDrink.Text = "Add to Order"
        Me.btnLgDrink.UseVisualStyleBackColor = False
        '
        'btnWater
        '
        Me.btnWater.BackColor = System.Drawing.Color.Black
        Me.btnWater.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnWater.ForeColor = System.Drawing.Color.White
        Me.btnWater.Location = New System.Drawing.Point(574, 358)
        Me.btnWater.Name = "btnWater"
        Me.btnWater.Size = New System.Drawing.Size(138, 33)
        Me.btnWater.TabIndex = 10
        Me.btnWater.Text = "Add to Order"
        Me.btnWater.UseVisualStyleBackColor = False
        '
        'lblLgDrink
        '
        Me.lblLgDrink.AutoSize = True
        Me.lblLgDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLgDrink.Location = New System.Drawing.Point(297, 117)
        Me.lblLgDrink.Name = "lblLgDrink"
        Me.lblLgDrink.Size = New System.Drawing.Size(148, 29)
        Me.lblLgDrink.TabIndex = 12
        Me.lblLgDrink.Text = "Large Drink"
        '
        'lblWater
        '
        Me.lblWater.AutoSize = True
        Me.lblWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWater.Location = New System.Drawing.Point(535, 117)
        Me.lblWater.Name = "lblWater"
        Me.lblWater.Size = New System.Drawing.Size(171, 29)
        Me.lblWater.TabIndex = 13
        Me.lblWater.Text = "Bottled Water"
        '
        'picWater
        '
        Me.picWater.Image = Global.FiveGuysOrdering.My.Resources.Resources.Dasani
        Me.picWater.Location = New System.Drawing.Point(607, 151)
        Me.picWater.Name = "picWater"
        Me.picWater.Size = New System.Drawing.Size(73, 201)
        Me.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWater.TabIndex = 14
        Me.picWater.TabStop = False
        '
        'picLgDrink
        '
        Me.picLgDrink.Image = Global.FiveGuysOrdering.My.Resources.Resources.LgDrink
        Me.picLgDrink.Location = New System.Drawing.Point(286, 170)
        Me.picLgDrink.Name = "picLgDrink"
        Me.picLgDrink.Size = New System.Drawing.Size(204, 154)
        Me.picLgDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLgDrink.TabIndex = 11
        Me.picLgDrink.TabStop = False
        '
        'picRegDrink
        '
        Me.picRegDrink.Image = Global.FiveGuysOrdering.My.Resources.Resources.RegDrink
        Me.picRegDrink.Location = New System.Drawing.Point(64, 151)
        Me.picRegDrink.Name = "picRegDrink"
        Me.picRegDrink.Size = New System.Drawing.Size(138, 201)
        Me.picRegDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRegDrink.TabIndex = 7
        Me.picRegDrink.TabStop = False
        '
        'lblWaterPrice
        '
        Me.lblWaterPrice.AutoSize = True
        Me.lblWaterPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWaterPrice.ForeColor = System.Drawing.Color.White
        Me.lblWaterPrice.Location = New System.Drawing.Point(598, 394)
        Me.lblWaterPrice.Name = "lblWaterPrice"
        Me.lblWaterPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblWaterPrice.TabIndex = 15
        Me.lblWaterPrice.Text = "$2.19"
        '
        'lblLgDrinkPrice
        '
        Me.lblLgDrinkPrice.AutoSize = True
        Me.lblLgDrinkPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLgDrinkPrice.ForeColor = System.Drawing.Color.White
        Me.lblLgDrinkPrice.Location = New System.Drawing.Point(336, 394)
        Me.lblLgDrinkPrice.Name = "lblLgDrinkPrice"
        Me.lblLgDrinkPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblLgDrinkPrice.TabIndex = 16
        Me.lblLgDrinkPrice.Text = "$2.79"
        '
        'lblRegDrinkPrice
        '
        Me.lblRegDrinkPrice.AutoSize = True
        Me.lblRegDrinkPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegDrinkPrice.ForeColor = System.Drawing.Color.White
        Me.lblRegDrinkPrice.Location = New System.Drawing.Point(88, 394)
        Me.lblRegDrinkPrice.Name = "lblRegDrinkPrice"
        Me.lblRegDrinkPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblRegDrinkPrice.TabIndex = 17
        Me.lblRegDrinkPrice.Text = "$2.49"
        '
        'frmDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRegDrinkPrice)
        Me.Controls.Add(Me.lblLgDrinkPrice)
        Me.Controls.Add(Me.lblWaterPrice)
        Me.Controls.Add(Me.picWater)
        Me.Controls.Add(Me.lblWater)
        Me.Controls.Add(Me.lblLgDrink)
        Me.Controls.Add(Me.picLgDrink)
        Me.Controls.Add(Me.btnWater)
        Me.Controls.Add(Me.btnLgDrink)
        Me.Controls.Add(Me.lblRegDrink)
        Me.Controls.Add(Me.picRegDrink)
        Me.Controls.Add(Me.btnRegDrink)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblDrinks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDrinks"
        Me.Text = "Five Guys"
        CType(Me.picWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLgDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRegDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDrinks As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnRegDrink As Button
    Friend WithEvents lblRegDrink As Label
    Friend WithEvents btnLgDrink As Button
    Friend WithEvents btnWater As Button
    Friend WithEvents picLgDrink As PictureBox
    Friend WithEvents lblLgDrink As Label
    Friend WithEvents lblWater As Label
    Friend WithEvents picRegDrink As PictureBox
    Friend WithEvents picWater As PictureBox
    Friend WithEvents lblWaterPrice As Label
    Friend WithEvents lblLgDrinkPrice As Label
    Friend WithEvents lblRegDrinkPrice As Label
End Class
