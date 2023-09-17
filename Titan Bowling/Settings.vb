Public Class SettingsForm
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualHelpFunctions.OverlayObjects(Title, Shape, Me)
    End Sub

    Private Sub ColorTheme_Click(sender As Object, e As EventArgs) Handles ColorTheme.Click
        If ColorTheme.Text = "BLUE" Then
            ColorTheme.Text = "RED"

            SavingSystem.theme = Color.FromArgb(135, 82, 82)
        ElseIf ColorTheme.Text = "RED" Then
            ColorTheme.Text = "GREEN"

            SavingSystem.theme = Color.FromArgb(86, 112, 88)

        ElseIf ColorTheme.Text = "GREEN" Then
            ColorTheme.Text = "BLUE"

            SavingSystem.theme = Color.FromArgb(1, 32, 76)

        End If

        Me.BackColor = SavingSystem.theme

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        homePage.Show()
        Me.Close()
    End Sub

    Private Sub Volume_Click(sender As Object, e As EventArgs) Handles Volume.Click
        If Volume.Text = "MUTE" Then
            Volume.Text = "UNMUTE"
            My.Computer.Audio.Stop()
        ElseIf Volume.Text = "UNMUTE" Then
            Volume.Text = "MUTE"
            My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SavingSystem.DeleteFile("1")
        SavingSystem.DeleteFile("2")
        SavingSystem.DeleteFile("3")
        SavingSystem.DeleteFile("4")

        MessageBox.Show("Please restart your game for this to take effect")

    End Sub
End Class