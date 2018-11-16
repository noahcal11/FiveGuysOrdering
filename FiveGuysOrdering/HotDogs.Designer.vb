<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotDogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotDogs))
        Me.lblHotDogs = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnEntrees = New System.Windows.Forms.Button()
        Me.gbxHotDogs = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.btnHotDogs = New System.Windows.Forms.Button()
        Me.picHotDog2 = New System.Windows.Forms.PictureBox()
        Me.picHotDog = New System.Windows.Forms.PictureBox()
        Me.lblHotDogPrice = New System.Windows.Forms.Label()
        Me.gbxHotDogs.SuspendLayout()
        CType(Me.picHotDog2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHotDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHotDogs
        '
        Me.lblHotDogs.AutoSize = True
        Me.lblHotDogs.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotDogs.ForeColor = System.Drawing.Color.White
        Me.lblHotDogs.Location = New System.Drawing.Point(245, 9)
        Me.lblHotDogs.Name = "lblHotDogs"
        Me.lblHotDogs.Size = New System.Drawing.Size(311, 136)
        Me.lblHotDogs.TabIndex = 8
        Me.lblHotDogs.Text = "KOSHER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HOT DOGS"
        Me.lblHotDogs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Black
        Me.btnMainMenu.Font = New System.Drawing.Font("Tekton Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(670, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(118, 57)
        Me.btnMainMenu.TabIndex = 9
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
        Me.btnEntrees.TabIndex = 10
        Me.btnEntrees.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ENTREES"
        Me.btnEntrees.UseVisualStyleBackColor = False
        '
        'gbxHotDogs
        '
        Me.gbxHotDogs.Controls.Add(Me.chkBacon)
        Me.gbxHotDogs.Controls.Add(Me.chkCheese)
        Me.gbxHotDogs.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.gbxHotDogs.Location = New System.Drawing.Point(288, 181)
        Me.gbxHotDogs.Name = "gbxHotDogs"
        Me.gbxHotDogs.Size = New System.Drawing.Size(200, 100)
        Me.gbxHotDogs.TabIndex = 11
        Me.gbxHotDogs.TabStop = False
        Me.gbxHotDogs.Text = "Extras"
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
        'btnHotDogs
        '
        Me.btnHotDogs.BackColor = System.Drawing.Color.Black
        Me.btnHotDogs.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnHotDogs.ForeColor = System.Drawing.Color.White
        Me.btnHotDogs.Location = New System.Drawing.Point(303, 320)
        Me.btnHotDogs.Name = "btnHotDogs"
        Me.btnHotDogs.Size = New System.Drawing.Size(170, 33)
        Me.btnHotDogs.TabIndex = 20
        Me.btnHotDogs.Text = "Select Toppings"
        Me.btnHotDogs.UseVisualStyleBackColor = False
        '
        'picHotDog2
        '
        Me.picHotDog2.Image = Global.FiveGuysOrdering.My.Resources.Resources.FiveGuysHotDog
        Me.picHotDog2.Location = New System.Drawing.Point(494, 225)
        Me.picHotDog2.Name = "picHotDog2"
        Me.picHotDog2.Size = New System.Drawing.Size(288, 166)
        Me.picHotDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHotDog2.TabIndex = 13
        Me.picHotDog2.TabStop = False
        '
        'picHotDog
        '
        Me.picHotDog.Image = Global.FiveGuysOrdering.My.Resources.Resources.HotDogButton
        Me.picHotDog.Location = New System.Drawing.Point(12, 148)
        Me.picHotDog.Name = "picHotDog"
        Me.picHotDog.Size = New System.Drawing.Size(250, 189)
        Me.picHotDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHotDog.TabIndex = 12
        Me.picHotDog.TabStop = False
        '
        'lblHotDogPrice
        '
        Me.lblHotDogPrice.AutoSize = True
        Me.lblHotDogPrice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotDogPrice.ForeColor = System.Drawing.Color.White
        Me.lblHotDogPrice.Location = New System.Drawing.Point(351, 386)
        Me.lblHotDogPrice.Name = "lblHotDogPrice"
        Me.lblHotDogPrice.Size = New System.Drawing.Size(75, 29)
        Me.lblHotDogPrice.TabIndex = 21
        Me.lblHotDogPrice.Text = "$5.29"
        '
        'frmHotDogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHotDogPrice)
        Me.Controls.Add(Me.btnHotDogs)
        Me.Controls.Add(Me.picHotDog2)
        Me.Controls.Add(Me.picHotDog)
        Me.Controls.Add(Me.gbxHotDogs)
        Me.Controls.Add(Me.btnEntrees)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblHotDogs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotDogs"
        Me.Text = "Five Guys"
        Me.gbxHotDogs.ResumeLayout(False)
        Me.gbxHotDogs.PerformLayout()
        CType(Me.picHotDog2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHotDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHotDogs As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnEntrees As Button
    Friend WithEvents gbxHotDogs As GroupBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents picHotDog As PictureBox
    Friend WithEvents picHotDog2 As PictureBox
    Friend WithEvents btnHotDogs As Button
    Friend WithEvents lblHotDogPrice As Label
End Class
