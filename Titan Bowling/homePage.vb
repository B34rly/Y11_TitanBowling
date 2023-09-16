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
        SavingSystem.Save(SavingSystem.Load("1"), "1")
        SavingSystem.Save(SavingSystem.Load("2"), "2")
        SavingSystem.Save(SavingSystem.Load("3"), "3")
        SavingSystem.Save(SavingSystem.Load("4"), "4")
    End Sub
End Class
