Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = inputValue
        TextBox1.ReadOnly = True
        ComboBox1.Enabled = False
        TextBox2.ReadOnly = True
        ComboBox1.SelectedItem = selectedValue
    End Sub
    'To change the icon and form name of this Form3
    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "View Form"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Same code in form 2
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            Pbresult.Image = My.Resources.Bloop
        ElseIf cb = 1 Then
            Pbresult.Image = My.Resources.Godzilla
        ElseIf cb = 2 Then
            Pbresult.Image = My.Resources.Kingkong
        ElseIf cb = 3 Then
            Pbresult.Image = My.Resources.Megalodon
        ElseIf cb = 4 Then
            Pbresult.Image = My.Resources.Trex
        End If

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

        'My life of my Cute Pets :)
        If cb = 0 Then
            ProgressBar1.Value = 80
            ProgressBar2.Value = 70
            ProgressBar3.Value = 80
        ElseIf cb = 1 Then
            ProgressBar1.Value = 70
            ProgressBar2.Value = 20
            ProgressBar3.Value = 80
        ElseIf cb = 2 Then
            ProgressBar1.Value = 25
            ProgressBar2.Value = 30
            ProgressBar3.Value = 60
        ElseIf cb = 3 Then
            ProgressBar1.Value = 80
            ProgressBar2.Value = 20
            ProgressBar3.Value = 70
        ElseIf cb = 4 Then
            ProgressBar1.Value = 70
            ProgressBar2.Value = 40
            ProgressBar3.Value = 80
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()

    End Sub
    'Change the form 3 appearance if my pets are dead
    Public Sub ShowImage2()
        PictureBox1.Image = My.Resources.ZRengoku2
        ProgressBar1.Visible = False
        ProgressBar2.Visible = False
        ProgressBar3.Visible = False
        Label5.Text = "Hint:"
        Label6.Text = "Do not max" & vbCrLf & "their Happiness" & vbCrLf & "Energy, Hungry."
        Label7.Text = "Also do not" & vbCrLf & "forget to give them food"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class