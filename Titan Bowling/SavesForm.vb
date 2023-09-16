Public Class SavesForm
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub SavesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim save1 = SavingSystem.Load("1")
        Dim save2 = SavingSystem.Load("2")
        Dim save3 = SavingSystem.Load("3")
        Dim save4 = SavingSystem.Load("4")


        Button1.Text = "Save 1 : " + save1.a + ", " + save1.b + ", " + save1.c + ", " + save1.d + " : " + save1.progress.ToString() + "/12"
        Button2.Text = "Save 2 : " + save2.a + ", " + save2.b + ", " + save2.c + ", " + save2.d + " : " + save2.progress.ToString() + "/12"
        Button3.Text = "Save 3 : " + save3.a + ", " + save3.b + ", " + save3.c + ", " + save3.d + " : " + save3.progress.ToString() + "/12"
        Button4.Text = "Save 4 : " + save4.a + ", " + save4.b + ", " + save4.c + ", " + save4.d + " : " + save4.progress.ToString() + "/12"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SavingSystem.CurrentActiveSave = "1"
        MessageBox.Show("Save 1 Selected")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SavingSystem.CurrentActiveSave = "2"
        MessageBox.Show("Save 2 Selected")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SavingSystem.CurrentActiveSave = "3"
        MessageBox.Show("Save 3 Selected")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SavingSystem.CurrentActiveSave = "4"
        MessageBox.Show("Save 4 Selected")
    End Sub
End Class