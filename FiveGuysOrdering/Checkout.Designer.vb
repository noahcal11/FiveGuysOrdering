<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Me.lstCheckout = New System.Windows.Forms.ListBox()
        Me.lblCheckout = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCheckout
        '
        Me.lstCheckout.Font = New System.Drawing.Font("OCR A Extended", 12.0!)
        Me.lstCheckout.FormattingEnabled = True
        Me.lstCheckout.ItemHeight = 17
        Me.lstCheckout.Location = New System.Drawing.Point(288, 80)
        Me.lstCheckout.Name = "lstCheckout"
        Me.lstCheckout.Size = New System.Drawing.Size(224, 293)
        Me.lstCheckout.TabIndex = 0
        '
        'lblCheckout
        '
        Me.lblCheckout.AutoSize = True
        Me.lblCheckout.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckout.ForeColor = System.Drawing.Color.White
        Me.lblCheckout.Location = New System.Drawing.Point(235, 9)
        Me.lblCheckout.Name = "lblCheckout"
        Me.lblCheckout.Size = New System.Drawing.Size(331, 68)
        Me.lblCheckout.TabIndex = 1
        Me.lblCheckout.Text = "CHECKOUT"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Black
        Me.btnCheckout.Font = New System.Drawing.Font("Tekton Pro", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(412, 387)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(167, 39)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tekton Pro", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(201, 389)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(170, 36)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total $0.00"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Black
        Me.btnMainMenu.Font = New System.Drawing.Font("Tekton Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(670, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(118, 57)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "BACK TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.Black
        Me.btnNewOrder.Font = New System.Drawing.Font("Tekton Pro", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewOrder.ForeColor = System.Drawing.Color.White
        Me.btnNewOrder.Location = New System.Drawing.Point(640, 95)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(148, 35)
        Me.btnNewOrder.TabIndex = 5
        Me.btnNewOrder.Text = "NEW ORDER"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblCheckout)
        Me.Controls.Add(Me.lstCheckout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheckout"
        Me.Text = "Five Guys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCheckout As ListBox
    Friend WithEvents lblCheckout As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnNewOrder As Button
End Class
