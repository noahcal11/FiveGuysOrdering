<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFries))
        Me.lblFries = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.pnlStyle = New System.Windows.Forms.Panel()
        Me.radCajun = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.pnlSize = New System.Windows.Forms.Panel()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radRegularSize = New System.Windows.Forms.RadioButton()
        Me.radLittle = New System.Windows.Forms.RadioButton()
        Me.picFries2 = New System.Windows.Forms.PictureBox()
        Me.picFries1 = New System.Windows.Forms.PictureBox()
        Me.btnFries = New System.Windows.Forms.Button()
        Me.pnlStyle.SuspendLayout()
        Me.pnlSize.SuspendLayout()
        CType(Me.picFries2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFries1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFries
        '
        Me.lblFries.AutoSize = True
        Me.lblFries.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFries.ForeColor = System.Drawing.Color.White
        Me.lblFries.Location = New System.Drawing.Point(307, 9)
        Me.lblFries.Name = "lblFries"
        Me.lblFries.Size = New System.Drawing.Size(187, 68)
        Me.lblFries.TabIndex = 2
        Me.lblFries.Text = "FRIES"
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
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblStyle.Location = New System.Drawing.Point(108, 128)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(80, 31)
        Me.lblStyle.TabIndex = 9
        Me.lblStyle.Text = "Style"
        '
        'pnlStyle
        '
        Me.pnlStyle.Controls.Add(Me.radCajun)
        Me.pnlStyle.Controls.Add(Me.radRegular)
        Me.pnlStyle.Location = New System.Drawing.Point(103, 166)
        Me.pnlStyle.Name = "pnlStyle"
        Me.pnlStyle.Size = New System.Drawing.Size(105, 76)
        Me.pnlStyle.TabIndex = 10
        '
        'radCajun
        '
        Me.radCajun.AutoSize = True
        Me.radCajun.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.radCajun.Location = New System.Drawing.Point(3, 40)
        Me.radCajun.Name = "radCajun"
        Me.radCajun.Size = New System.Drawing.Size(78, 31)
        Me.radCajun.TabIndex = 1
        Me.radCajun.TabStop = True
        Me.radCajun.Text = "Cajun"
        Me.radCajun.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.radRegular.Location = New System.Drawing.Point(3, 3)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(98, 31)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSize.Location = New System.Drawing.Point(327, 128)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(71, 31)
        Me.lblSize.TabIndex = 11
        Me.lblSize.Text = "Size"
        '
        'pnlSize
        '
        Me.pnlSize.Controls.Add(Me.radLarge)
        Me.pnlSize.Controls.Add(Me.radRegularSize)
        Me.pnlSize.Controls.Add(Me.radLittle)
        Me.pnlSize.Location = New System.Drawing.Point(273, 169)
        Me.pnlSize.Name = "pnlSize"
        Me.pnlSize.Size = New System.Drawing.Size(182, 113)
        Me.pnlSize.TabIndex = 12
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.radLarge.Location = New System.Drawing.Point(3, 77)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(158, 31)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large ($6.19)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radRegularSize
        '
        Me.radRegularSize.AutoSize = True
        Me.radRegularSize.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.radRegularSize.Location = New System.Drawing.Point(3, 40)
        Me.radRegularSize.Name = "radRegularSize"
        Me.radRegularSize.Size = New System.Drawing.Size(177, 31)
        Me.radRegularSize.TabIndex = 1
        Me.radRegularSize.TabStop = True
        Me.radRegularSize.Text = "Regular ($4.49)"
        Me.radRegularSize.UseVisualStyleBackColor = True
        '
        'radLittle
        '
        Me.radLittle.AutoSize = True
        Me.radLittle.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.radLittle.Location = New System.Drawing.Point(3, 3)
        Me.radLittle.Name = "radLittle"
        Me.radLittle.Size = New System.Drawing.Size(156, 31)
        Me.radLittle.TabIndex = 0
        Me.radLittle.TabStop = True
        Me.radLittle.Text = "Little ($3.49)"
        Me.radLittle.UseVisualStyleBackColor = True
        '
        'picFries2
        '
        Me.picFries2.Image = Global.FiveGuysOrdering.My.Resources.Resources.Fries
        Me.picFries2.Location = New System.Drawing.Point(459, 184)
        Me.picFries2.Name = "picFries2"
        Me.picFries2.Size = New System.Drawing.Size(327, 215)
        Me.picFries2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFries2.TabIndex = 14
        Me.picFries2.TabStop = False
        '
        'picFries1
        '
        Me.picFries1.Image = Global.FiveGuysOrdering.My.Resources.Resources.CajunFries
        Me.picFries1.Location = New System.Drawing.Point(51, 263)
        Me.picFries1.Name = "picFries1"
        Me.picFries1.Size = New System.Drawing.Size(187, 155)
        Me.picFries1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFries1.TabIndex = 13
        Me.picFries1.TabStop = False
        '
        'btnFries
        '
        Me.btnFries.BackColor = System.Drawing.Color.Black
        Me.btnFries.Font = New System.Drawing.Font("Tekton Pro", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnFries.ForeColor = System.Drawing.Color.White
        Me.btnFries.Location = New System.Drawing.Point(295, 309)
        Me.btnFries.Name = "btnFries"
        Me.btnFries.Size = New System.Drawing.Size(138, 33)
        Me.btnFries.TabIndex = 15
        Me.btnFries.Text = "Add to Order"
        Me.btnFries.UseVisualStyleBackColor = False
        '
        'frmFries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFries)
        Me.Controls.Add(Me.picFries2)
        Me.Controls.Add(Me.picFries1)
        Me.Controls.Add(Me.pnlSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.pnlStyle)
        Me.Controls.Add(Me.lblStyle)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblFries)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFries"
        Me.Text = "Five Guys"
        Me.pnlStyle.ResumeLayout(False)
        Me.pnlStyle.PerformLayout()
        Me.pnlSize.ResumeLayout(False)
        Me.pnlSize.PerformLayout()
        CType(Me.picFries2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFries1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFries As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblStyle As Label
    Friend WithEvents pnlStyle As Panel
    Friend WithEvents radCajun As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents lblSize As Label
    Friend WithEvents pnlSize As Panel
    Friend WithEvents radRegularSize As RadioButton
    Friend WithEvents radLittle As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents picFries1 As PictureBox
    Friend WithEvents picFries2 As PictureBox
    Friend WithEvents btnFries As Button
End Class
