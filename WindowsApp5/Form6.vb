'Imports System.Random
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"Rock", "Paper", "Scissors"})
        Button2.Visible = False
        TextBox1.Text = "Choose Your Pick"
        TextBox1.ReadOnly = True
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Game Form"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim playerChoice As String = ComboBox1.SelectedItem.ToString()
        'Dim opponentChoice As String = GetOpponentChoice()

        'PictureBox1.Image = My.Resources.ResourceManager.GetObject(playerChoice)
        'PictureBox2.Image = My.Resources.ResourceManager.GetObject(opponentChoice)

    End Sub

    Private Sub CheatCode()
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            PictureBox2.Image = My.Resources.Paper
        ElseIf cb = 1 Then
            PictureBox2.Image = My.Resources.Scissors
        ElseIf cb = 2 Then
            PictureBox2.Image = My.Resources.Rock
        End If

    End Sub
    'Private Function GetOpponentChoice() As String
    'Dim choices As String() = {"Rock", "Paper", "Scissors"}
    'Dim random As New Random()

    'Return choices(random.Next(choices.Length))
    'End Function

    Private Sub Submitbtn_Click_1(sender As Object, e As EventArgs) Handles Submitbtn.Click
        CheatCode()

        TextBox1.Text = "You Won"

        Submitbtn.Enabled = False
        ComboBox1.Enabled = False
        Button2.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cb = ComboBox1.SelectedIndex
        If cb = 0 Then
            PictureBox1.Image = My.Resources.Rock
        ElseIf cb = 1 Then
            PictureBox1.Image = My.Resources.Paper
        ElseIf cb = 2 Then
            PictureBox1.Image = My.Resources.Scissors
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Hide()
    End Sub
End Class