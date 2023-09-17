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


        Dim save1 = SavingSystem.Load("1")
        Dim save2 = SavingSystem.Load("2")
        Dim save3 = SavingSystem.Load("3")
        Dim save4 = SavingSystem.Load("4")

        If save1.initialized = False Then
            save1.initialized = True
            save1.a = {"", "", "", ""}
            save1.b = {"", "", "", ""}
            save1.c = {"", "", "", ""}
            save1.d = {"", "", "", ""}
        End If
        If save2.initialized = False Then
            save2.initialized = True
            save2.a = {"", "", "", ""}
            save2.b = {"", "", "", ""}
            save2.c = {"", "", "", ""}
            save2.d = {"", "", "", ""}
        End If
        If save3.initialized = False Then
            save3.initialized = True
            save3.a = {"", "", "", ""}
            save3.b = {"", "", "", ""}
            save3.c = {"", "", "", ""}
            save3.d = {"", "", "", ""}
        End If
        If save4.initialized = False Then
            save4.initialized = True
            save4.a = {"", "", "", ""}
            save4.b = {"", "", "", ""}
            save4.c = {"", "", "", ""}
            save4.d = {"", "", "", ""}
        End If

        SavingSystem.Save(save1, "1")
        SavingSystem.Save(save2, "2")
        SavingSystem.Save(save3, "3")
        SavingSystem.Save(save4, "4")


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
