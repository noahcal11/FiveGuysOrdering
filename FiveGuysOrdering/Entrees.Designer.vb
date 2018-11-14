<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntrees))
        Me.lblEntrees = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnBurgers = New System.Windows.Forms.Button()
        Me.btnHotDogs = New System.Windows.Forms.Button()
        Me.btnSandwiches = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEntrees
        '
        Me.lblEntrees.AutoSize = True
        Me.lblEntrees.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrees.ForeColor = System.Drawing.Color.White
        Me.lblEntrees.Location = New System.Drawing.Point(260, 9)
        Me.lblEntrees.Name = "lblEntrees"
        Me.lblEntrees.Size = New System.Drawing.Size(281, 68)
        Me.lblEntrees.TabIndex = 2
        Me.lblEntrees.Text = "ENTREES"
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
        'btnBurgers
        '
        Me.btnBurgers.BackColor = System.Drawing.Color.Black
        Me.btnBurgers.BackgroundImage = Global.FiveGuysOrdering.My.Resources.Resources.BurgerButton
        Me.btnBurgers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBurgers.Font = New System.Drawing.Font("Tekton Pro", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnBurgers.ForeColor = System.Drawing.Color.Black
        Me.btnBurgers.Location = New System.Drawing.Point(42, 167)
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(233, 165)
        Me.btnBurgers.TabIndex = 6
        Me.btnBurgers.Text = "Burgers"
        Me.btnBurgers.UseVisualStyleBackColor = False
        '
        'btnHotDogs
        '
        Me.btnHotDogs.BackColor = System.Drawing.Color.Black
        Me.btnHotDogs.BackgroundImage = Global.FiveGuysOrdering.My.Resources.Resources.HotDogButton
        Me.btnHotDogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHotDogs.Font = New System.Drawing.Font("Tekton Pro", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHotDogs.ForeColor = System.Drawing.Color.White
        Me.btnHotDogs.Location = New System.Drawing.Point(291, 167)
        Me.btnHotDogs.Name = "btnHotDogs"
        Me.btnHotDogs.Size = New System.Drawing.Size(226, 165)
        Me.btnHotDogs.TabIndex = 7
        Me.btnHotDogs.Text = "Hot Dogs"
        Me.btnHotDogs.UseVisualStyleBackColor = False
        '
        'btnSandwiches
        '
        Me.btnSandwiches.BackColor = System.Drawing.Color.Black
        Me.btnSandwiches.BackgroundImage = Global.FiveGuysOrdering.My.Resources.Resources.GrilledCheeseButton
        Me.btnSandwiches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSandwiches.Font = New System.Drawing.Font("Tekton Pro", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btnSandwiches.ForeColor = System.Drawing.Color.Black
        Me.btnSandwiches.Location = New System.Drawing.Point(533, 167)
        Me.btnSandwiches.Name = "btnSandwiches"
        Me.btnSandwiches.Size = New System.Drawing.Size(226, 165)
        Me.btnSandwiches.TabIndex = 8
        Me.btnSandwiches.Text = "Sandwiches"
        Me.btnSandwiches.UseVisualStyleBackColor = False
        '
        'frmEntrees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSandwiches)
        Me.Controls.Add(Me.btnHotDogs)
        Me.Controls.Add(Me.btnBurgers)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblEntrees)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntrees"
        Me.Text = "Five Guys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEntrees As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnBurgers As Button
    Friend WithEvents btnHotDogs As Button
    Friend WithEvents btnSandwiches As Button
End Class
