Imports System.Reflection.Emit

Public Class homePage
    Private Sub SETTINGS_Click(sender As Object, e As EventArgs) Handles SETTINGS.Click
        SettingsForm.Show()
        Hide()
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles PlayBttn.Click

        Dim save = SavingSystem.Load(SavingSystem.CurrentActiveSave)

        If save.filled Then

            NewGame.Team1Names = save.a
            NewGame.Team2Names = save.b
            NewGame.Team3Names = save.c
            NewGame.Team4Names = save.d

            PlayingForm.Show()
            Hide()
        Else
            NewGame.Show()
            NewGame.Team1Names = {"", "", "", ""}
            NewGame.Team2Names = {"", "", "", ""}
            NewGame.Team3Names = {"", "", "", ""}
            NewGame.Team4Names = {"", "", "", ""}
            Hide()
        End If

    End Sub
    Private Sub Supprt_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
        SupportForm.Show()
        Hide()
    End Sub
    Private Sub SavesForm_Click(sender As Object, e As EventArgs) Handles SavedGames.Click
        SavesForm.Show()
        Hide()
    End Sub
    Private Sub homePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SavingSystem.Init("1")
        SavingSystem.Init("2")
        SavingSystem.Init("3")
        SavingSystem.Init("4")

        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)
    End Sub

    Private Sub TUTORIAL_Click(sender As Object, e As EventArgs) Handles TUTORIAL.Click
        TutorialForm.Show()
        Hide()
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Me.BackColor = SavingSystem.theme
        NewGame.BackColor = SavingSystem.theme
        PlayingForm.BackColor = SavingSystem.theme
        SavesForm.BackColor = SavingSystem.theme
        SettingsForm.BackColor = SavingSystem.theme
        SupportForm.BackColor = SavingSystem.theme
        TutorialForm.BackColor = SavingSystem.theme
    End Sub

End Class
