Public Class Form5
    Dim currentValue As String
    Dim cb = Form4.ComboBox1.SelectedIndex
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.ShowImage2()
        Form1.DisableButton()
    End Sub
    'To change the icon and form name of this Form5
    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Food Form"
    End Sub
    Private Sub btnFish_Click(sender As Object, e As EventArgs) Handles btnFish.Click
        'Fish Section

        If cb = 0 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Yey! My Favorite, Thanks Master"
        ElseIf cb = 1 Then
            'Godzilla Dont like fish
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value -= 20
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Roaaarrrrrrrrrr.............  "
        ElseIf cb = 2 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "My Favorite, Hooo.. HA Ha (2x)"
        ElseIf cb = 3 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "*Dancing Baby Shark for exchange to Food you give"
        ElseIf cb = 4 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Roarrrrrrrrrrrrr....Arggghhhhhhh..... Thanks"
        End If
        'Section of Death
        If Form4.PrgHungry.Value = 100 Or Form4.PrgHungry.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much food.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If Form4.PrgHungry.Value = 0 Or Form4.PrgHungry.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died of starvation.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHappiness.Value = 100 Or Form4.PrgHappiness.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much happiness.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHappiness.Value = 0 Or Form4.PrgHappiness.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet committed suicide" & vbCrLf & "because nothing anymore of life was happy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgEnergy.Value = 100 Or Form4.PrgEnergy.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgEnergy.Value = 0 Or Form4.PrgEnergy.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because you forgot to give it some energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        Form3.TextBox2.Text = "Dead"
        Form3.TextBox2.ForeColor = Color.Red
        Form3.Panel1.BackColor = Color.Red
        Form3.Panel2.BackColor = Color.Brown
        Form3.Panel3.BackColor = Color.Brown
    End Sub
    'Waste section
    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click

        If cb = 0 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Still the same taste as Fish"
        ElseIf cb = 1 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "*Use the Big Beam for Lettering THANK YOU"
        ElseIf cb = 2 Then
            'King kong dont like waste
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value -= 20
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Are you kidding me?"
        ElseIf cb = 3 Then
            'Meg dont like waste
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value -= 20
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Ew....... *Grunting "
        ElseIf cb = 4 Then
            'Trex dont like waste
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value -= 20
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "YUCCKKCKCKC!!......... Argggggggggghhhh "
        End If
        'Section of Death
        If Form4.PrgHungry.Value = 100 Or Form4.PrgHungry.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much food.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHungry.Value = 0 Or Form4.PrgHungry.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died of starvation.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHappiness.Value = 100 Or Form4.PrgHappiness.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much happiness.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHappiness.Value = 0 Or Form4.PrgHappiness.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet committed suicide" & vbCrLf & "because nothing anymore of life was happy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgEnergy.Value = 100 Or Form4.PrgEnergy.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgEnergy.Value = 0 Or Form4.PrgEnergy.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because you forgot to give it some energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        Form3.TextBox2.Text = "Dead"
        Form3.TextBox2.ForeColor = Color.Red
        Form3.Panel1.BackColor = Color.Red
        Form3.Panel2.BackColor = Color.Brown
        Form3.Panel3.BackColor = Color.Brown
    End Sub
    'Human Section
    Private Sub btnHuman_Click(sender As Object, e As EventArgs) Handles btnHuman.Click

        If cb = 0 Then
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Not bad for a good appetizer"
        ElseIf cb = 1 Then
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Taste like nothing"
        ElseIf cb = 2 Then
            'King kong dont like humans to eat
            Form4.PrgHungry.Value += 5

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value -= 20
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "STOPPP... I don't eat people because it" & vbCrLf & "reminds me of my friend Ann Darrow."
        ElseIf cb = 3 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "I Need more, Masterrr........"
        ElseIf cb = 4 Then
            Form4.PrgHungry.Value += 10

            If Form4.PrgHungry.Value > Form4.PrgHungry.Maximum Then
                Form4.PrgHungry.Value = Form4.PrgHungry.Maximum
            End If
            Form4.PrgHappiness.Value += 5
            If Form4.PrgHappiness.Value > Form4.PrgHappiness.Maximum Then
                Form4.PrgHappiness.Value = Form4.PrgHappiness.Maximum
            End If
            Form4.PrgEnergy.Value += 5
            If Form4.PrgEnergy.Value > Form4.PrgEnergy.Maximum Then
                Form4.PrgEnergy.Value = Form4.PrgEnergy.Maximum
            End If
            Hide()
            Form4.lbOutput.Text = "Taste like an A4 Wagyu Beef" & vbCrLf & "and the blood taste like a wine"
        End If
        'Section of Death
        If Form4.PrgHungry.Value = 100 Or Form4.PrgHungry.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much food.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If Form4.PrgHungry.Value = 0 Or Form4.PrgHungry.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died of starvation.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgHappiness.Value = 100 Or Form4.PrgHappiness.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much happiness.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If Form4.PrgHappiness.Value = 0 Or Form4.PrgHappiness.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet committed suicide" & vbCrLf & "because nothing anymore of life was happy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If Form4.PrgEnergy.Value = 100 Or Form4.PrgEnergy.Value > 100 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because of too much energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If Form4.PrgEnergy.Value = 0 Or Form4.PrgEnergy.Value < 0 Then
            Form4.Hide()
            MessageBox.Show("Your pet died because you forgot to give it some energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        Form3.TextBox2.Text = "Dead"
        Form3.TextBox2.ForeColor = Color.Red
        Form3.Panel1.BackColor = Color.Red
        Form3.Panel2.BackColor = Color.Brown
        Form3.Panel3.BackColor = Color.Brown
    End Sub
End Class