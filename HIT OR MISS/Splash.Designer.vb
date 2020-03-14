<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrsplash = New System.Windows.Forms.Timer(Me.components)
        Me.picsplash = New System.Windows.Forms.PictureBox()
        CType(Me.picsplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrsplash
        '
        Me.tmrsplash.Enabled = True
        Me.tmrsplash.Interval = 300
        '
        'picsplash
        '
        Me.picsplash.Location = New System.Drawing.Point(2, 2)
        Me.picsplash.Name = "picsplash"
        Me.picsplash.Size = New System.Drawing.Size(700, 358)
        Me.picsplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsplash.TabIndex = 0
        Me.picsplash.TabStop = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 363)
        Me.Controls.Add(Me.picsplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picsplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picsplash As System.Windows.Forms.PictureBox
    Friend WithEvents tmrsplash As System.Windows.Forms.Timer
End Class
