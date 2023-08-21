Public Class homePage
    Private Sub SETTINGS_Click(sender As Object, e As EventArgs) Handles SETTINGS.Click
        SettingsForm.Show()
        Hide()
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles PlayBttn.Click
        NewGame.Show()
        Hide()
    End Sub
    Private Sub Supprt_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
        SupportForm.Show()
        Hide()
    End Sub
    Private Sub SavesForm_Click(sender As Object, e As EventArgs) Handles SavedGames.Click
        SavesForm.Show()
        Hide()
    End Sub
End Class
