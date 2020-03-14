<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurnChange))
        Me.lblannounce = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.btngo = New System.Windows.Forms.Button()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblannounce
        '
        Me.lblannounce.AutoSize = True
        Me.lblannounce.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblannounce.Location = New System.Drawing.Point(114, 209)
        Me.lblannounce.Name = "lblannounce"
        Me.lblannounce.Size = New System.Drawing.Size(284, 43)
        Me.lblannounce.TabIndex = 0
        Me.lblannounce.Text = "Player x, your turn!"
        '
        'piclogo
        '
        Me.piclogo.Image = Global.HIT_OR_MISS.My.Resources.Resources.hitormisslogo
        Me.piclogo.Location = New System.Drawing.Point(132, 66)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(236, 126)
        Me.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogo.TabIndex = 1
        Me.piclogo.TabStop = False
        '
        'btngo
        '
        Me.btngo.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.Location = New System.Drawing.Point(181, 301)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(132, 59)
        Me.btngo.TabIndex = 2
        Me.btngo.Text = "Click to start your turn!"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'TurnChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 468)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.lblannounce)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TurnChange"
        Me.Text = "It's Player X's turn!"
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblannounce As System.Windows.Forms.Label
    Friend WithEvents piclogo As System.Windows.Forms.PictureBox
    Friend WithEvents btngo As System.Windows.Forms.Button
End Class
