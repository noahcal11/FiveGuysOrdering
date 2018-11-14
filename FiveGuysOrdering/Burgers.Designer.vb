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
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBurgers)
        Me.Controls.Add(Me.btnEntrees)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBurgers"
        Me.Text = "Five Guys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnEntrees As Button
    Friend WithEvents lblBurgers As Label
End Class
