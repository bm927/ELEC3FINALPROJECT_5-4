<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.picwave2 = New System.Windows.Forms.PictureBox()
        Me.picwave1 = New System.Windows.Forms.PictureBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnabout = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        CType(Me.picwave2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwave1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picwave2
        '
        Me.picwave2.Image = CType(resources.GetObject("picwave2.Image"), System.Drawing.Image)
        Me.picwave2.Location = New System.Drawing.Point(1, 455)
        Me.picwave2.Margin = New System.Windows.Forms.Padding(4)
        Me.picwave2.Name = "picwave2"
        Me.picwave2.Size = New System.Drawing.Size(481, 220)
        Me.picwave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwave2.TabIndex = 10
        Me.picwave2.TabStop = False
        '
        'picwave1
        '
        Me.picwave1.Image = CType(resources.GetObject("picwave1.Image"), System.Drawing.Image)
        Me.picwave1.Location = New System.Drawing.Point(614, 455)
        Me.picwave1.Margin = New System.Windows.Forms.Padding(4)
        Me.picwave1.Name = "picwave1"
        Me.picwave1.Size = New System.Drawing.Size(460, 220)
        Me.picwave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwave1.TabIndex = 9
        Me.picwave1.TabStop = False
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(490, 619)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(116, 57)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnabout
        '
        Me.btnabout.Font = New System.Drawing.Font("Forte", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabout.Location = New System.Drawing.Point(490, 537)
        Me.btnabout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Size = New System.Drawing.Size(116, 57)
        Me.btnabout.TabIndex = 7
        Me.btnabout.Text = "About" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Hit or Miss"
        Me.btnabout.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Forte", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(490, 455)
        Me.btnstart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(116, 57)
        Me.btnstart.TabIndex = 6
        Me.btnstart.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 PlayerGame"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'piclogo
        '
        Me.piclogo.Image = Global.HIT_OR_MISS.My.Resources.Resources.hitormiss
        Me.piclogo.Location = New System.Drawing.Point(70, 42)
        Me.piclogo.Margin = New System.Windows.Forms.Padding(4)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(956, 385)
        Me.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogo.TabIndex = 11
        Me.piclogo.TabStop = False
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1097, 711)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.picwave2)
        Me.Controls.Add(Me.picwave1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnabout)
        Me.Controls.Add(Me.btnstart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hit or Miss"
        CType(Me.picwave2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwave1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picwave2 As PictureBox
    Friend WithEvents picwave1 As PictureBox
    Friend WithEvents btnexit As Button
    Friend WithEvents btnabout As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents piclogo As PictureBox
End Class
