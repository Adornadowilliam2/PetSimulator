Public Class Form2
    Dim cb As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub


    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Choose Form"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cb = ComboBox1.SelectedIndex ' Update cb when index changes
        Select Case cb
            Case 0
                Pbresult.Image = My.Resources.Bloop
            Case 1
                Pbresult.Image = My.Resources.Godzilla
            Case 2
                Pbresult.Image = My.Resources.Kingkong
            Case 3
                Pbresult.Image = My.Resources.Megalodon
            Case 4
                Pbresult.Image = My.Resources.Trex
        End Select

        ' Set labels based on selection
        Select Case cb
            Case 0
                lb1.Text = "• Eat Fish"
                lb2.Text = "• Sleep"
                lb3.Text = "• Eat Waste"
                lb4.Text = "• Play"
                lb5.Text = "•__________"
                lb6.Text = "•__________"
            Case 1
                lb1.Text = "• Eat Human"
                lb2.Text = "• Eat Waste"
                lb3.Text = "• Sleep"
                lb4.Text = "• Eat Fish"
                lb5.Text = "•__________"
                lb6.Text = "•__________"
            Case 2
                lb1.Text = "• Eat Fish"
                lb2.Text = "• Sleep"
                lb3.Text = "• Play"
                lb4.Text = "• Eat Human"
                lb5.Text = "• Eat Waste"
                lb6.Text = "•__________"
            Case 3
                lb1.Text = "• Eat Human"
                lb2.Text = "• Eat Fish"
                lb3.Text = "• Sleep"
                lb4.Text = "• Play"
                lb5.Text = "• Eat Waste"
                lb6.Text = "•__________"
            Case 4
                lb1.Text = "• Eat Human"
                lb2.Text = "• Eat Fish"
                lb3.Text = "• Play"
                lb4.Text = "•__________"
                lb5.Text = "• Eat Waste"
                lb6.Text = "•__________"
        End Select

        UpdateButton2State()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        inputValue = TextBox1.Text
        UpdateButton2State()
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = Char.ToUpper(TextBox1.Text(0)) + TextBox1.Text.Substring(1)
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub



    Private Sub UpdateButton2State()
        If TextBox1.Text = "" OrElse ComboBox1.SelectedIndex = -1 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.EnableButton3()
        Form1.Show()
        Me.Hide()
        selectedValue = ComboBox1.SelectedItem
        Select Case cb
            Case 0
                Form1.Panel1.BackgroundImage = My.Resources.Yimage3
                Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
                Form1.Label1.BackColor = Color.Transparent
                Form1.PictureBox1.Image = My.Resources.WBloop
            Case 1
                Pbresult.Image = My.Resources.Godzilla
                Form1.Panel1.BackgroundImage = My.Resources.Yimage2
                Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
                Form1.Label1.BackColor = Color.Transparent
                Form1.PictureBox1.Image = My.Resources.WGodzilla
                Form1.Label1.ForeColor = Color.White
            Case 2

                Form1.Panel1.BackgroundImage = My.Resources.Yimage1
                Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
                Form1.Label1.BackColor = Color.Transparent
                Form1.PictureBox1.Image = My.Resources.WKingkong
                Form1.Label1.ForeColor = Color.White
            Case 3

                Form1.Panel1.BackgroundImage = My.Resources.Yimage3
                Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
                Form1.Label1.BackColor = Color.Transparent
                Form1.Label1.ForeColor = Color.Black
                Form1.PictureBox1.Image = My.Resources.WMegalodon
            Case 4
                Form1.Panel1.BackgroundImage = My.Resources.Yimage1
                Form1.Panel1.BackgroundImageLayout = ImageLayout.Stretch
                Form1.Label1.BackColor = Color.Transparent
                Form1.PictureBox1.Image = My.Resources.WTrex
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
