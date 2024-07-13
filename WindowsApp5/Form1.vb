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
        ' Show confirmation dialog
        Dim result As DialogResult = MessageBox.Show("You want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Unsubscribe from FormClosing event to prevent further checks
            RemoveHandler Me.FormClosing, AddressOf Form1_FormClosing

            ' Close the application permanently
            Application.Exit()
        ElseIf result = DialogResult.No Then
            ' Cancel closing the form
            e.Cancel = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenGate()
        btnAdapt.Enabled = True
    End Sub
    Public Sub OpenGate()
        Form2.Dispose()
        Form3.Dispose()
        Form4.Dispose()
        Form5.Dispose()
        Form6.Dispose()
    End Sub

    Public Sub InvisibleButton()
        Button1.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
