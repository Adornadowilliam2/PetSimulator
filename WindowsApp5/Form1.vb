Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button1.Visible = False
    End Sub
    'To change the icon and form name of this Form1
    Public Sub New()
        InitializeComponent()
        Me.Icon = Icon.FromHandle(My.Resources.ZPETS.GetHicon())
        Me.Text = "Main Menu"
    End Sub


    Private Sub btnAdapt_Click(sender As Object, e As EventArgs) Handles btnAdapt.Click
        Form2.Show()
        Hide()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form4.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Form3.Show()
        Hide()
    End Sub

    'My System Enable Section
    Public Sub EnableButton3()
        btnView.Enabled = True
        btnAdapt.Enabled = False
        btnPlay.Enabled = True
    End Sub
    'To be able not to play anymore
    Public Sub DisableButton()
        btnPlay.Enabled = False
        btnAdapt.Text = "Press Exit to Play"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'to close my form two times :)
        Dim result As DialogResult = MessageBox.Show("You want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the application permanently
            Application.Exit()
        ElseIf result = DialogResult.No Then
            'Cancel
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenGate()
        btnAdapt.Enabled = True
    End Sub
    Public Sub OpenGate()
        'Form2.Pbresult.Image = Nothing
        'Form2.ComboBox1.SelectedIndex = -1
        'Form2.TextBox1.Text = ""
        'Form3.Panel1.BackColor = Color.LightSkyBlue
        'Form3.Panel2.BackColor = Color.LightBlue
        'Form3.Panel3.BackColor = Color.LightBlue
        'Form3.ProgressBar1.Visible = True
        'Form3.ProgressBar2.Visible = True
        'Form3.ProgressBar3.Visible = True
        'Form3.Label5.Text = "Hungry Level:"
        'Form3.Label6.Text = "Energy Level:"
        'Form3.Label7.Text = "Happines Level:"
        ''Erase all my form
        'Form3.ComboBox1.SelectedIndex = -1
        'Form3.TextBox2.ForeColor = Color.Green
        'Form3.TextBox2.Text = "Alive"
        'Form3.TextBox1.Text = ""
        'Button1.Enabled = False
        'btnView.Enabled = False
        'btnPlay.Enabled = False
        'Form3.Panel1.Visible = False
        'Form4.Panel1.Visible = False
        'Form4.Panel2.Visible = False
        'Form4.Panel3.Visible = False
        'Form4.Panel4.Visible = False
        'Form2.lb1.Text = "•__________"
        'Form2.lb2.Text = "•__________"
        'Form2.lb3.Text = "•__________"
        'Form2.lb4.Text = "•__________"
        'Form2.lb5.Text = "•__________"
        'Form2.lb6.Text = "•__________"
        Form2.Dispose()
        Form3.Dispose()
        Form4.Dispose()
        Form5.Dispose()
        Form6.Dispose()
    End Sub

    Public Sub InvisibleButton()
        Button1.Visible = False
    End Sub
End Class
