Public Class TutorialForm
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        homePage.Show()
        Me.Close()


    End Sub

    Private Sub TutorialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TutorialText.Text = String.Format("This app follows traditional 10 pin bowling rules with a 12 frame game:{0}When a strike is hit (all 10 pins knocked in the first roll), the number of pins knocked in the next 2 rolls is added to the teams total score.{0}When a spare is achieved (all 10 pins knocked down using both rolls), the number of pins knocked in the next roll is added to the teams total score.{0}If a strike is hit in the final (12th) frame, 2 bonus rolls are awarded.{0}If a spare is hit in the final frame, 1 bonus roll is awarded.{1}Teams can be created by selecting the desired team roster, then inputting each players name on the new game form. To create a new game, a new save must be selected in the saves form. Otherwise, the last game is continued. ", vbCrLf + "    ", vbCrLf)
    End Sub
End Class