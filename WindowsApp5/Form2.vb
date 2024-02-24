Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

    End Sub
    'To change the icon and form name of this Form2
    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Choose Form"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'ComboBox Copy to the Form3
        selectedValue = ComboBox1.SelectedItem
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            Pbresult.Image = My.Resources.Bloop
            Form1.Panel1.BackgroundImage = My.Resources.Yimage3
            Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Form1.Label1.BackColor = Color.Transparent
            Form1.PictureBox1.Image = My.Resources.WBloop
        ElseIf cb = 1 Then
            Pbresult.Image = My.Resources.Godzilla
            Form1.Panel1.BackgroundImage = My.Resources.Yimage2
            Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Form1.Label1.BackColor = Color.Transparent
            Form1.PictureBox1.Image = My.Resources.WGodzilla
            Form1.Label1.ForeColor = Color.White
        ElseIf cb = 2 Then
            Pbresult.Image = My.Resources.Kingkong
            Form1.Panel1.BackgroundImage = My.Resources.Yimage1
            Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Form1.Label1.BackColor = Color.Transparent
            Form1.PictureBox1.Image = My.Resources.WKingkong
            Form1.Label1.ForeColor = Color.White
        ElseIf cb = 3 Then
            Pbresult.Image = My.Resources.Megalodon
            Form1.Panel1.BackgroundImage = My.Resources.Yimage3
            Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Form1.Label1.BackColor = Color.Transparent
            Form1.Label1.ForeColor = Color.Black
            Form1.PictureBox1.Image = My.Resources.WMegalodon
        ElseIf cb = 4 Then
            Pbresult.Image = My.Resources.Trex
            Form1.Panel1.BackgroundImage = My.Resources.Yimage1
            Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Form1.Label1.BackColor = Color.Transparent
            Form1.PictureBox1.Image = My.Resources.WTrex
        End If

        'My like and dislike of my pets
        If cb = 0 Then
            lb1.Text = "• Eat Fish"
            lb2.Text = "• Sleep"
            lb3.Text = "• Eat Waste"
            lb4.Text = "• Play"
            lb5.Text = "•__________"
            lb6.Text = "•__________"
        ElseIf cb = 1 Then
            lb1.Text = "• Eat Human"
            lb2.Text = "• Eat Waste"
            lb3.Text = "• Sleep"
            lb4.Text = "• Eat Fish"
            lb5.Text = "•__________"
            lb6.Text = "•__________"
        ElseIf cb = 2 Then
            lb1.Text = "• Eat Fish"
            lb2.Text = "• Sleep"
            lb3.Text = "• Play"
            lb4.Text = "• Eat Human"
            lb5.Text = "• Eat Waste"
            lb6.Text = "•__________"
        ElseIf cb = 3 Then
            lb1.Text = "• Eat Human"
            lb2.Text = "• Eat Fish"
            lb3.Text = "• Sleep"
            lb4.Text = "• Play"
            lb5.Text = "• Eat Waste"
            lb6.Text = "•__________"
        ElseIf cb = 4 Then
            lb1.Text = "• Eat Human"
            lb2.Text = "• Eat Fish"
            lb3.Text = "• Play"
            lb4.Text = "•__________"
            lb5.Text = "• Eat Waste"
            lb6.Text = "•__________"
        End If

        UpdateButton2State()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        inputValue = TextBox1.Text
        UpdateButton2State()
        Howbad()
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = Char.ToUpper(TextBox1.Text(0)) + TextBox1.Text.Substring(1)
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub
    Public Sub Howbad()
        If TextBox1.Text = "Fuck" Or TextBox1.Text = "Shit" Or TextBox1.Text = "Bitch" Or TextBox1.Text = "Bobo" Or TextBox1.Text = "Tanga" Then
            My.Computer.Audio.Play(bad)
            TextBox1.BackColor = Color.Orange
        Else
            TextBox1.BackColor = Color.Wheat
            My.Computer.Audio.Stop()
        End If
    End Sub
    'For Enable my Button in Textbox and ComboBox
    'And if one of them is missing the button in Adapat will not open
    Private Sub UpdateButton2State()
        If TextBox1.Text = "" Or ComboBox1.SelectedIndex = -1 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.EnableButton3()
        Form1.Show()
        Hide()
        selectedValue = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Hide()
    End Sub
End Class