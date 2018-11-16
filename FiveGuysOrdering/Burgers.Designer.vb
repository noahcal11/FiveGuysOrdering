<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnEntrees = New System.Windows.Forms.Button()
        Me.lblBurgers = New System.Windows.Forms.Label()
        Me.gbxBurgerExtras = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.lblLtlBurger = New System.Windows.Forms.Label()
        Me.lblRegBurger = New System.Windows.Forms.Label()
        Me.picRegBurger = New System.Windows.Forms.PictureBox()
        Me.picLtlBurger = New System.Windows.Forms.PictureBox()
        Me.btnLtlBurger = New System.Windows.Forms.Button()
        Me.btnRegBurger = New System.Windows.Forms.Button()
        Me.lblLtlBurgerPrice = New System.Windows.Forms.Label()
        Me.lblRegBurgerPrice = New System.Windows.Forms.Label()
        Me.gbxBurgerExtras.SuspendLayout()
        CType(Me.picRegBurger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLtlBurger, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnMainMenu.TabIndex = 5
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
        Me.btnEntrees.TabIndex = 6
        Me.btnEntrees.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ENTREES"
        Me.btnEntrees.UseVisualStyleBackColor = False
        '
        'lblBurgers
        '
        Me.lblBurgers.AutoSize = True
        Me.lblBurgers.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBurgers.ForeColor = System.Drawing.Color.White
        Me.lblBurgers.Location = New System.Drawing.Point(256, 9)
        Me.lblBurgers.Name = "lblBurgers"
        Me.lblBurgers.Size = New System.Drawing.Size(288, 68)
        Me.lblBurgers.TabIndex = 7
        Me.lblBurgers.Text = "BURGERS"
        '
        'gbxBurgerExtras
        '
        Me.gbxBurgerExtras.Controls.Add(Me.chkBacon)
        Me.gbxBurgerExtras.Controls.Add(Me.chkCheese)
        Me.gbxBurgerExtras.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.gbxBurgerExtras.Location = New System.Drawing.Point(300, 217)
        Me.gbxBurgerExtras.Name = "gbxBurgerExtras"
        Me.gbxBurgerExtras.Size = New System.Drawing.Size(200, 100)
        Me.gbxBurgerExtras.TabIndex = 12
        Me.gbxBurgerExtras.TabStop = False
        Me.gbxBurgerExtras.Text = "Extras"
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Font = New System.Drawing.Font("Tekton Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBacon.ForeColor = System.Drawing.Color.White
        Me.chkBacon.Location = New System.Drawing.Point(6, 65)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(144, 27)
        Me.chkBacon.TabIndex = 1
        Me.chkBacon.Text = "Bacon ($1.00)"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Tekton Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.ForeColor = System.Drawing.Color.White
        Me.chkCheese.Location = New System.Drawing.Point(7, 32)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(153, 27)
        Me.chkCheese.TabIndex = 0
        Me.chkCheese.Text = "Cheese ($0.70)"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'lblLtlBurger
        '
        Me.lblLtlBurger.AutoSize = True
        Me.lblLtlBurger.Font = New System.Drawing.Font("Perpetua Titling MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblLtlBurger.Location = New System.Drawing.Point(21, 151)
        Me.lblLtlBurger.Name = "lblLtlBurger"
        Me.lblLtlBurger.Size = New System.Drawing.Size(241, 32)
        Me.lblLtlBurger.TabIndex = 13
        Me.lblLtlBurger.Text = "Little Burger"
        '
        'lblRegBurger
        '
        Me.lblRegBurger.AutoSize = True
        Me.lblRegBurger.Font = New System.Drawing.Font("Perpetua Titling MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegBurger.Location = New System.Drawing.Point(555, 151)
        Me.lblRegBurger.Name = "lblRegBurger"
        Me.lblRegBurger.Size = New System.Drawing.Size(206, 32)
        Me.lblRegBurger.TabIndex = 14
        Me.lblRegBurger.Text = "Hamburger"
        '
        'picRegBurger
        '
        Me.picRegBurger.Image = Global.FiveGuysOrdering.My.Resources.Resources.BurgerButton
        Me.picRegBurger.Location = New System.Drawing.Point(545, 186)
        Me.picRegBurger.Name = "picRegBurger"
        Me.picRegBurger.Size = New System.Drawing.Size(225, 164)
        Me.picRegBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegBurger.TabIndex = 16
        Me.picRegBurger.TabStop = False
        '
        'picLtlBurger
        '
        Me.picLtlBurger.Image = Global.FiveGuysOrdering.My.Resources.Resources.FiveGuysLtlBurger
        Me.picLtlBurger.Location = New System.Drawing.Point(27, 186)
        Me.picLtlBurger.Name = "picLtlBurger"
        Me.picLtlBurger.Size = New System.Drawing.Size(235, 164)
        Me.picLtlBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLtlBurger.TabIndex = 15
        Me.picLtlBurger.TabStop = False
        '
        'btnLtlBurger
        '
        Me.btnLtlBurger.BackColor = System.Drawing.Color.Black
        Me.btnLtlBurger.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnLtlBurger.ForeColor = System.Drawing.Color.White
        Me.btnLtlBurger.Location = New System.Drawing.Point(59, 366)
        Me.btnLtlBurger.Name = "btnLtlBurger"
        Me.btnLtlBurger.Size = New System.Drawing.Size(170, 33)
        Me.btnLtlBurger.TabIndex = 21
        Me.btnLtlBurger.Text = "Select Toppings"
        Me.btnLtlBurger.UseVisualStyleBackColor = False
        '
        'btnRegBurger
        '
        Me.btnRegBurger.BackColor = System.Drawing.Color.Black
        Me.btnRegBurger.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegBurger.ForeColor = System.Drawing.Color.White
        Me.btnRegBurger.Location = New System.Drawing.Point(572, 366)
        Me.btnRegBurger.Name = "btnRegBurger"
        Me.btnRegBurger.Size = New System.Drawing.Size(170, 33)
        Me.btnRegBurger.TabIndex = 22
        Me.btnRegBurger.Text = "Select Toppings"
        Me.btnRegBurger.UseVisualStyleBackColor = False
        '
        'lblLtlBurgerPrice
        '
        Me.lblLtlBurgerPrice.AutoSize = True
        Me.lblLtlBurgerPrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLtlBurgerPrice.ForeColor = System.Drawing.Color.White
        Me.lblLtlBurgerPrice.Location = New System.Drawing.Point(107, 412)
        Me.lblLtlBurgerPrice.Name = "lblLtlBurgerPrice"
        Me.lblLtlBurgerPrice.Size = New System.Drawing.Size(75, 29)
        Me.lblLtlBurgerPrice.TabIndex = 23
        Me.lblLtlBurgerPrice.Text = "$5.59"
        '
        'lblRegBurgerPrice
        '
        Me.lblRegBurgerPrice.AutoSize = True
        Me.lblRegBurgerPrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegBurgerPrice.ForeColor = System.Drawing.Color.White
        Me.lblRegBurgerPrice.Location = New System.Drawing.Point(620, 412)
        Me.lblRegBurgerPrice.Name = "lblRegBurgerPrice"
        Me.lblRegBurgerPrice.Size = New System.Drawing.Size(75, 29)
        Me.lblRegBurgerPrice.TabIndex = 24
        Me.lblRegBurgerPrice.Text = "$7.59"
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRegBurgerPrice)
        Me.Controls.Add(Me.lblLtlBurgerPrice)
        Me.Controls.Add(Me.btnRegBurger)
        Me.Controls.Add(Me.btnLtlBurger)
        Me.Controls.Add(Me.picRegBurger)
        Me.Controls.Add(Me.picLtlBurger)
        Me.Controls.Add(Me.lblRegBurger)
        Me.Controls.Add(Me.lblLtlBurger)
        Me.Controls.Add(Me.gbxBurgerExtras)
        Me.Controls.Add(Me.lblBurgers)
        Me.Controls.Add(Me.btnEntrees)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBurgers"
        Me.Text = "Five Guys"
        Me.gbxBurgerExtras.ResumeLayout(False)
        Me.gbxBurgerExtras.PerformLayout()
        CType(Me.picRegBurger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLtlBurger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnEntrees As Button
    Friend WithEvents lblBurgers As Label
    Friend WithEvents gbxBurgerExtras As GroupBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents lblLtlBurger As Label
    Friend WithEvents lblRegBurger As Label
    Friend WithEvents picLtlBurger As PictureBox
    Friend WithEvents picRegBurger As PictureBox
    Friend WithEvents btnLtlBurger As Button
    Friend WithEvents btnRegBurger As Button
    Friend WithEvents lblLtlBurgerPrice As Label
    Friend WithEvents lblRegBurgerPrice As Label
End Class
