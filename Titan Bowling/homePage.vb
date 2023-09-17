Imports System.Reflection.Emit

Public Class homePage
    Private Sub SETTINGS_Click(sender As Object, e As EventArgs) Handles SETTINGS.Click
        SettingsForm.Show()
        Hide()
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles PlayBttn.Click

        Dim save = SavingSystem.Load(SavingSystem.CurrentActiveSave)

        If save.isSetup = True Then

            NewGame.Team1Names = save.aA
            NewGame.Team2Names = save.bA
            NewGame.Team3Names = save.cA
            NewGame.Team4Names = save.dA

            PlayingForm.Show()
            Hide()
        Else
            NewGame.Show()
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

        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)

        SavingSystem.Save(SavingSystem.Load("1"), "1")
        SavingSystem.Save(SavingSystem.Load("2"), "2")
        SavingSystem.Save(SavingSystem.Load("3"), "3")
        SavingSystem.Save(SavingSystem.Load("4"), "4")
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
