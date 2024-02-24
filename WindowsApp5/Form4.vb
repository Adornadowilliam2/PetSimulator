Public Class Form4
    'To be able to change the conversation
    Dim isFirstMessage As Boolean = True
    Dim isSecondMessage As Boolean = False

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblname.Text = inputValue
        ComboBox1.SelectedItem = selectedValue
        ComboBox1.Enabled = False
        Form1.Button1.Visible = True
        Form3.ShowImage2()
        Form1.DisableButton()
        'To hide my combobox
        ComboBox1.Visible = False
    End Sub
    'To change the icon and form name of this Form4
    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Play Form"
    End Sub

    Private Sub btnEat_Click(sender As Object, e As EventArgs) Handles btnEat.Click
        Form5.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            Pbresult.Image = My.Resources.Bloop
            Panel1.BackgroundImage = My.Resources.Zunderwater
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb = 1 Then
            Pbresult.Image = My.Resources.Godzilla
            Panel1.BackgroundImage = My.Resources.Zunderwater
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb = 2 Then
            Pbresult.Image = My.Resources.Kingkong
            Panel1.BackgroundImage = My.Resources.Zforest
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb = 3 Then
            Pbresult.Image = My.Resources.Megalodon
            Panel1.BackgroundImage = My.Resources.Zunderwater
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cb = 4 Then
            Pbresult.Image = My.Resources.Trex
            Panel1.BackgroundImage = My.Resources.Zforest
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        End If

        'My life of my Cute Pets :)
        If cb = 0 Then
            PrgHungry.Value = 80
            PrgEnergy.Value = 70
            PrgHappiness.Value = 80
        ElseIf cb = 1 Then
            PrgHungry.Value = 70
            PrgEnergy.Value = 20
            PrgHappiness.Value = 90
        ElseIf cb = 2 Then
            PrgHungry.Value = 25
            PrgEnergy.Value = 30
            PrgHappiness.Value = 60
        ElseIf cb = 3 Then
            PrgHungry.Value = 80
            PrgEnergy.Value = 20
            PrgHappiness.Value = 70
        ElseIf cb = 4 Then
            PrgHungry.Value = 70
            PrgEnergy.Value = 40
            PrgHappiness.Value = 80
        End If
    End Sub

    Private Sub btnTalk_Click(sender As Object, e As EventArgs) Handles btnTalk.Click
        'To have more text
        If isFirstMessage Then
            lbOutput.Text = "My name is " & lblname.Text & ", Nice to meet youuuuuuuuuuuu!"
            isFirstMessage = False
            isSecondMessage = True
        ElseIf isSecondMessage Then
            lbOutput.Text = "I'm looking forward to you, Master."
            isSecondMessage = False
        Else
            lbOutput.Text = "Let's give our best!"
            isFirstMessage = True
        End If
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        My.Computer.Audio.Play(lullaby)
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            Form6.BackgroundImage = My.Resources.XBloop
            Form6.Panel1.Visible = False
        ElseIf cb = 1 Then
            Form6.BackgroundImage = My.Resources.XGodzilla
            Form6.Panel1.Visible = False
        ElseIf cb = 2 Then
            Form6.BackgroundImage = My.Resources.XKingkong
            Form6.Panel1.Visible = False
        ElseIf cb = 3 Then
            Form6.BackgroundImage = My.Resources.XMegalodon
            Form6.Panel1.Visible = False
        ElseIf cb = 4 Then
            Form6.BackgroundImage = My.Resources.XTrex
            Form6.Panel1.Visible = False
        End If
        Form6.Show()
        Timer1.Interval = 5000 ' 10seconds
        Timer1.Start()
        Hide()




        If cb = 0 Then
            PrgEnergy.Value += 10

            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
            PrgHungry.Value -= 5
            If PrgHungry.Value > PrgHungry.Maximum Then
                PrgHungry.Value = PrgHungry.Maximum
            End If
            lbOutput.Text = "..............ZZZZZZZZZZZZZZZZZZZZZZZZ"
        ElseIf cb = 1 Then
            PrgEnergy.Value += 10

            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
            PrgHungry.Value -= 5
            If PrgHungry.Value > PrgHungry.Maximum Then
                PrgHungry.Value = PrgHungry.Maximum
            End If
            lbOutput.Text = "Arggg......zzzzzZZZZZZZ"
        ElseIf cb = 2 Then
            PrgEnergy.Value += 10

            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
            PrgHungry.Value -= 5
            If PrgHungry.Value > PrgHungry.Maximum Then
                PrgHungry.Value = PrgHungry.Maximum
            End If
            lbOutput.Text = "Amimir......zZZZZZ"
        ElseIf cb = 3 Then
            PrgEnergy.Value += 10

            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
            PrgHungry.Value -= 5
            If PrgHungry.Value > PrgHungry.Maximum Then
                PrgHungry.Value = PrgHungry.Maximum
            End If
            lbOutput.Text = "Thank....you.....zZZZZZZ..."
        ElseIf cb = 4 Then
            PrgEnergy.Value += 5

            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
            PrgHungry.Value -= 5
            If PrgHungry.Value > PrgHungry.Maximum Then
                PrgHungry.Value = PrgHungry.Maximum
            End If
            lbOutput.Text = "As a big predator sometimes i need time to sleep"
        End If
        'Section of Death
        If PrgHungry.Value = 100 Or PrgHungry.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much food.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If PrgHungry.Value = 0 Or PrgHungry.Value < 0 Then
            Hide()
            MessageBox.Show("Your pet died of starvation.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If PrgHappiness.Value = 100 Or PrgHappiness.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much happiness.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If PrgHappiness.Value = 0 Or PrgHappiness.Value < 0 Then
            Hide()
            MessageBox.Show("Your pet committed suicide" & vbCrLf & "because nothing anymore of life was happy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If PrgEnergy.Value = 100 Or PrgEnergy.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        If PrgEnergy.Value = 0 Or PrgEnergy.Value < 0 Then
            Hide()
            MessageBox.Show("Your pet died because you forgot to give it some energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead

        End If
        Form3.TextBox2.Text = "Dead"
        Form3.TextBox2.ForeColor = Color.Red
        Form3.Panel1.BackColor = Color.Red
        Form3.Panel2.BackColor = Color.Brown
        Form3.Panel3.BackColor = Color.Brown
        Dim progressBar As New ProgressBar()
        Dim minValue As Integer = 0
        Dim maxValue As Integer = 100

        AdjustProgressBarMinMax(progressBar, minValue, maxValue)

    End Sub
    Private Sub AdjustProgressBarMinMax(ByRef progressBar As ProgressBar, ByVal minValue As Integer, ByVal maxValue As Integer)
        If minValue >= maxValue Then
            Throw New ArgumentException("Minimum value must be less than maximum value.")
        End If

        If progressBar.Minimum <> minValue Then
            progressBar.Minimum = minValue
        End If

        If progressBar.Maximum <> maxValue Then
            progressBar.Maximum = maxValue
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form6.Panel1.Visible = True
        Form6.Show()
        Hide()
        Form6.ComboBox1.SelectedIndex = -1
        Form6.ComboBox1.Enabled = True
        Form6.Submitbtn.Enabled = True
        Form6.Button2.Visible = False
        Form6.PictureBox1.Image = Nothing
        Form6.PictureBox2.Image = Nothing
        Form6.TextBox1.Text = ""
        Dim cb = ComboBox1.SelectedIndex
        'Play Section
        If cb = 0 Then
            'Bloop Dont like to play
            PrgHappiness.Value -= 20
            If PrgHappiness.Value > PrgHappiness.Maximum Then
                PrgHappiness.Value = PrgHappiness.Maximum
            End If
            lbOutput.Text = "What a hassle"
            PrgEnergy.Value -= 5
            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If

        ElseIf cb = 1 Then
            PrgHappiness.Value += 5
            If PrgHappiness.Value > PrgHappiness.Maximum Then
                PrgHappiness.Value = PrgHappiness.Maximum
            End If
            lbOutput.Text = "Not a fan of this activity"
            PrgEnergy.Value -= 5
            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If

        ElseIf cb = 2 Then
            PrgHappiness.Value += 10
            If PrgHappiness.Value > PrgHappiness.Maximum Then
                PrgHappiness.Value = PrgHappiness.Maximum
            End If
            lbOutput.Text = "Wanna do another round of monkey climbing?"
            PrgEnergy.Value -= 5
            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If

        ElseIf cb = 3 Then
            'Dont like to play by Meg
            PrgHappiness.Value -= 20
            If PrgHappiness.Value > PrgHappiness.Maximum Then
                PrgHappiness.Value = PrgHappiness.Maximum
            End If
            lbOutput.Text = "Not Again....... i don't want to play"
            PrgEnergy.Value -= 5
            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
        ElseIf cb = 4 Then
            PrgHappiness.Value += 10
            If PrgHappiness.Value > PrgHappiness.Maximum Then
                PrgHappiness.Value = PrgHappiness.Maximum

            End If
            lbOutput.Text = "WANT TO PLAY HIDE-AND-SEEK Roarrr..."
            PrgEnergy.Value -= 5
            If PrgEnergy.Value > PrgEnergy.Maximum Then
                PrgEnergy.Value = PrgEnergy.Maximum
            End If
        End If
        PrgHungry.Value -= 5
        If PrgHungry.Value > PrgHungry.Maximum Then
            PrgHungry.Value = PrgHungry.Maximum
        End If
        'Section of Death
        If PrgHungry.Value = 100 Or PrgHungry.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much food.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If PrgHungry.Value = 0 Or PrgHungry.Value < 0 Then
            Hide()
            MessageBox.Show("Your pet died of starvation.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If PrgHappiness.Value = 100 Or PrgHappiness.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much happiness.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If PrgHappiness.Value = 0 Or PrgHappiness.Value < 0 Then
            Hide()
            MessageBox.Show("Your pet committed suicide" & vbCrLf & "because nothing anymore of life was happy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If PrgEnergy.Value = 100 Or PrgEnergy.Value > 100 Then
            Hide()
            MessageBox.Show("Your pet died because of too much energy.")
            Form1.Show()
            Form1.PictureBox1.Image = My.Resources.ZDead
            Form6.Hide()
        End If
        If PrgEnergy.Value = 0 Or PrgEnergy.Value < 0 Then
            Hide()
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

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("what a weakling")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form6.Hide() ' Hide Form2
        Me.Show() ' Show Form1 again
    End Sub
End Class