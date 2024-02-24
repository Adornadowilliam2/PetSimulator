<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.btnFish = New System.Windows.Forms.Button()
        Me.btnHuman = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnWaste)
        Me.Panel1.Controls.Add(Me.btnFish)
        Me.Panel1.Controls.Add(Me.btnHuman)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 161)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Wastes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fishes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Humans"
        '
        'btnWaste
        '
        Me.btnWaste.BackgroundImage = Global.WindowsApp5.My.Resources.Resources.YWaste
        Me.btnWaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWaste.Location = New System.Drawing.Point(246, 25)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Size = New System.Drawing.Size(111, 93)
        Me.btnWaste.TabIndex = 2
        Me.btnWaste.UseVisualStyleBackColor = True
        '
        'btnFish
        '
        Me.btnFish.BackgroundImage = Global.WindowsApp5.My.Resources.Resources.YFishs
        Me.btnFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFish.Location = New System.Drawing.Point(129, 25)
        Me.btnFish.Name = "btnFish"
        Me.btnFish.Size = New System.Drawing.Size(111, 93)
        Me.btnFish.TabIndex = 1
        Me.btnFish.UseVisualStyleBackColor = True
        '
        'btnHuman
        '
        Me.btnHuman.BackgroundImage = Global.WindowsApp5.My.Resources.Resources.YHumans
        Me.btnHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHuman.Location = New System.Drawing.Point(12, 25)
        Me.btnHuman.Name = "btnHuman"
        Me.btnHuman.Size = New System.Drawing.Size(111, 93)
        Me.btnHuman.TabIndex = 0
        Me.btnHuman.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 161)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWaste As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFish As Button
    Friend WithEvents btnHuman As Button
End Class
