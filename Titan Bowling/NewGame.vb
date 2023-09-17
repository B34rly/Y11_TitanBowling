Public Class NewGame

    Dim selectedTeam As Integer
    Public Team1Names() As String
    Public Team2Names() As String
    Public Team3Names() As String
    Public Team4Names() As String
    Dim currentSelection As Button

    Dim team1MemberCount = 0
    Dim team2MemberCount = 0
    Dim team3MemberCount = 0
    Dim team4MemberCount = 0

    Private Sub NewGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentSelection = team1
        selectedTeam = 1 'this was 0, which meant you were able to continually add members if you hadn't selected a team anything. Also 
        'could've brought in an error box telling user to select a team. but this is a simpler option
        'also we need to remove players / add a teams reset button on this page. 
        team1.BackColor = Color.LightYellow
        team2.BackColor = Color.White
        team3.BackColor = Color.White
        team4.BackColor = Color.White

        Team1Names = {"", "", "", ""}
        Team2Names = {"", "", "", ""}
        Team3Names = {"", "", "", ""}
        Team4Names = {"", "", "", ""}
    End Sub

    Private Sub team1_Click(sender As Object, e As EventArgs) Handles team1.Click
        selectedTeam = 1
        team1.BackColor = Color.LightYellow
        team2.BackColor = Color.White
        team3.BackColor = Color.White
        team4.BackColor = Color.White
        currentSelection = team1

    End Sub

    Private Sub team2_Click(sender As Object, e As EventArgs) Handles team2.Click
        selectedTeam = 2
        team1.BackColor = Color.White
        team2.BackColor = Color.LightYellow
        team3.BackColor = Color.White
        team4.BackColor = Color.White
        currentSelection = team2

    End Sub

    Private Sub team3_Click(sender As Object, e As EventArgs) Handles team3.Click
        selectedTeam = 3
        team1.BackColor = Color.White
        team2.BackColor = Color.White
        team3.BackColor = Color.LightYellow
        team4.BackColor = Color.White
        currentSelection = team3

    End Sub

    Private Sub team4_Click(sender As Object, e As EventArgs) Handles team4.Click
        selectedTeam = 4
        team1.BackColor = Color.White
        team2.BackColor = Color.White
        team3.BackColor = Color.White
        team4.BackColor = Color.LightYellow
        currentSelection = team4

    End Sub

    Private Sub AddNAme_Click(sender As Object, e As EventArgs) Handles AddNAme.Click

        Dim addNames As Boolean = True

        If NameInput.Text Is "" Then
            MessageBox.Show("Enter A Name")
            addNames = False
        Else
            If selectedTeam = 1 And team1MemberCount >= 4 Then
                MessageBox.Show("Select another team. This one is full")
                addNames = False
            ElseIf selectedTeam = 2 And team2MemberCount >= 4 Then
                MessageBox.Show("Select another team. This one is full")
                addNames = False
            ElseIf selectedTeam = 3 And team3MemberCount >= 4 Then
                MessageBox.Show("Select another team. This one is full")
                addNames = False
            ElseIf selectedTeam = 4 And team4MemberCount >= 4 Then
                MessageBox.Show("Select another team. This one is full")
                addNames = False
            End If
        End If


        If addNames = True Then

            If selectedTeam = 1 Then
                Team1Names(team1MemberCount) = NameInput.Text
                team1MemberCount += 1
            ElseIf selectedTeam = 2 Then
                Team2Names(team2MemberCount) = NameInput.Text
                team2MemberCount += 1
            ElseIf selectedTeam = 3 Then
                Team3Names(team3MemberCount) = NameInput.Text
                team3MemberCount += 1
            ElseIf selectedTeam = 4 Then
                Team4Names(team4MemberCount) = NameInput.Text
                team4MemberCount += 1
            End If

            currentSelection.Text += Environment.NewLine + NameInput.Text

            NameInput.Text = ""
        End If


    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub EnterGame_Click(sender As Object, e As EventArgs) Handles EnterGame.Click
        If team1MemberCount > 0 Or team2MemberCount > 0 Or team3MemberCount > 0 Or team4MemberCount > 0 Then

            Dim save = SavingSystem.Load(SavingSystem.CurrentActiveSave)

            save.a = Team1Names
            save.b = Team2Names
            save.c = Team3Names
            save.d = Team4Names
            save.filled = True

            SavingSystem.Save(save, SavingSystem.CurrentActiveSave)

            PlayingForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Team1Names = {"", "", "", ""}
        team1MemberCount = 0
        team1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Team2Names = {"", "", "", ""}
        team2MemberCount = 0
        team2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Team3Names = {"", "", "", ""}
        team3MemberCount = 0
        team3.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Team4Names = {"", "", "", ""}
        team4MemberCount = 0
        team4.Text = ""

    End Sub
End Class