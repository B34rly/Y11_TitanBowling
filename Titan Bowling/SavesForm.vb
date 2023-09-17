Public Class SavesForm
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        homePage.Show()
        Me.Close()
    End Sub

    Private Sub SavesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim save1 = SavingSystem.Load("1")
        Dim save2 = SavingSystem.Load("2")
        Dim save3 = SavingSystem.Load("3")
        Dim save4 = SavingSystem.Load("4")

        Button1.Text = "Save 1 : "
        Button2.Text = "Save 2 : "
        Button3.Text = "Save 3 : "
        Button4.Text = "Save 4 : "

        For i = 0 To 3
            Button1.Text += save1.a(i) + " "
            Button1.Text += save1.b(i) + " "
            Button1.Text += save1.c(i) + " "
            Button1.Text += save1.d(i) + " "


            Button2.Text += save2.a(i) + " "
            Button2.Text += save2.b(i) + " "
            Button2.Text += save2.c(i) + " "
            Button2.Text += save2.d(i) + " "


            Button3.Text += save3.a(i) + " "
            Button3.Text += save3.b(i) + " "
            Button3.Text += save3.c(i) + " "
            Button3.Text += save3.d(i) + " "


            Button4.Text += save4.a(i) + " "
            Button4.Text += save4.b(i) + " "
            Button4.Text += save4.c(i) + " "
            Button4.Text += save4.d(i) + " "

        Next

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