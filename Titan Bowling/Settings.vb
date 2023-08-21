Public Class SettingsForm
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualHelpFunctions.OverlayObjects(Title, Shape, Me)
    End Sub

    Private Sub ColorTheme_Click(sender As Object, e As EventArgs) Handles ColorTheme.Click

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        homePage.Show()
        Me.Hide()
    End Sub
End Class