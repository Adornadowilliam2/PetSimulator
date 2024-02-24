<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrgHappiness = New System.Windows.Forms.ProgressBar()
        Me.lbHappiness = New System.Windows.Forms.Label()
        Me.PrgEnergy = New System.Windows.Forms.ProgressBar()
        Me.lbEnergy = New System.Windows.Forms.Label()
        Me.PrgHungry = New System.Windows.Forms.ProgressBar()
        Me.lbHungry = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSleep = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnEat = New System.Windows.Forms.Button()
        Me.btnTalk = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pbresult = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pbresult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbOutput
        '
        Me.lbOutput.AutoSize = True
        Me.lbOutput.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOutput.Location = New System.Drawing.Point(13, 14)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(69, 23)
        Me.lbOutput.TabIndex = 13
        Me.lbOutput.Text = "Output"
        Me.lbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.lbOutput)
        Me.Panel2.Location = New System.Drawing.Point(195, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 100)
        Me.Panel2.TabIndex = 12
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Azure
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(252, 23)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 20)
        Me.lblname.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bloop", "Godzilla", "Kingkong", "Megalodon", "Trex"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 23)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        '
        'PrgHappiness
        '
        Me.PrgHappiness.Location = New System.Drawing.Point(140, 99)
        Me.PrgHappiness.Name = "PrgHappiness"
        Me.PrgHappiness.Size = New System.Drawing.Size(530, 38)
        Me.PrgHappiness.TabIndex = 9
        '
        'lbHappiness
        '
        Me.lbHappiness.AutoSize = True
        Me.lbHappiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHappiness.Location = New System.Drawing.Point(12, 102)
        Me.lbHappiness.Name = "lbHappiness"
        Me.lbHappiness.Size = New System.Drawing.Size(130, 20)
        Me.lbHappiness.TabIndex = 8
        Me.lbHappiness.Text = "Happiness Level:"
        '
        'PrgEnergy
        '
        Me.PrgEnergy.Location = New System.Drawing.Point(140, 55)
        Me.PrgEnergy.Name = "PrgEnergy"
        Me.PrgEnergy.Size = New System.Drawing.Size(530, 38)
        Me.PrgEnergy.TabIndex = 7
        '
        'lbEnergy
        '
        Me.lbEnergy.AutoSize = True
        Me.lbEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnergy.Location = New System.Drawing.Point(12, 58)
        Me.lbEnergy.Name = "lbEnergy"
        Me.lbEnergy.Size = New System.Drawing.Size(104, 20)
        Me.lbEnergy.TabIndex = 6
        Me.lbEnergy.Text = "Energy Level:"
        '
        'PrgHungry
        '
        Me.PrgHungry.Location = New System.Drawing.Point(140, 11)
        Me.PrgHungry.Name = "PrgHungry"
        Me.PrgHungry.Size = New System.Drawing.Size(530, 38)
        Me.PrgHungry.TabIndex = 5
        '
        'lbHungry
        '
        Me.lbHungry.AutoSize = True
        Me.lbHungry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHungry.Location = New System.Drawing.Point(12, 14)
        Me.lbHungry.Name = "lbHungry"
        Me.lbHungry.Size = New System.Drawing.Size(105, 20)
        Me.lbHungry.TabIndex = 0
        Me.lbHungry.Text = "Hungry Level:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightCyan
        Me.Panel4.Controls.Add(Me.btnSleep)
        Me.Panel4.Controls.Add(Me.btnPlay)
        Me.Panel4.Controls.Add(Me.btnEat)
        Me.Panel4.Controls.Add(Me.btnTalk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 186)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 132)
        Me.Panel4.TabIndex = 8
        '
        'btnSleep
        '
        Me.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSleep.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSleep.Location = New System.Drawing.Point(475, 28)
        Me.btnSleep.Name = "btnSleep"
        Me.btnSleep.Size = New System.Drawing.Size(131, 67)
        Me.btnSleep.TabIndex = 3
        Me.btnSleep.Text = "Sleep"
        Me.btnSleep.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(338, 28)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(131, 67)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnEat
        '
        Me.btnEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEat.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat.Location = New System.Drawing.Point(201, 28)
        Me.btnEat.Name = "btnEat"
        Me.btnEat.Size = New System.Drawing.Size(131, 67)
        Me.btnEat.TabIndex = 1
        Me.btnEat.Text = "Eat"
        Me.btnEat.UseVisualStyleBackColor = True
        '
        'btnTalk
        '
        Me.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTalk.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTalk.Location = New System.Drawing.Point(64, 28)
        Me.btnTalk.Name = "btnTalk"
        Me.btnTalk.Size = New System.Drawing.Size(131, 67)
        Me.btnTalk.TabIndex = 0
        Me.btnTalk.Text = "Talk"
        Me.btnTalk.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Turquoise
        Me.Panel3.Controls.Add(Me.PrgHappiness)
        Me.Panel3.Controls.Add(Me.lbHappiness)
        Me.Panel3.Controls.Add(Me.PrgEnergy)
        Me.Panel3.Controls.Add(Me.lbEnergy)
        Me.Panel3.Controls.Add(Me.PrgHungry)
        Me.Panel3.Controls.Add(Me.lbHungry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 318)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 142)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Pbresult)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 186)
        Me.Panel1.TabIndex = 6
        '
        'Pbresult
        '
        Me.Pbresult.BackColor = System.Drawing.SystemColors.Info
        Me.Pbresult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pbresult.Location = New System.Drawing.Point(24, 12)
        Me.Pbresult.Name = "Pbresult"
        Me.Pbresult.Size = New System.Drawing.Size(151, 127)
        Me.Pbresult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbresult.TabIndex = 6
        Me.Pbresult.TabStop = False
        '
        'Timer1
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 460)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pbresult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pbresult As PictureBox
    Friend WithEvents lbOutput As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrgHappiness As ProgressBar
    Friend WithEvents lbHappiness As Label
    Friend WithEvents PrgEnergy As ProgressBar
    Friend WithEvents lbEnergy As Label
    Friend WithEvents PrgHungry As ProgressBar
    Friend WithEvents lbHungry As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnEat As Button
    Friend WithEvents btnTalk As Button
    Friend WithEvents btnSleep As Button
    Friend WithEvents btnPlay As Button
End Class
