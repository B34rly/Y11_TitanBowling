﻿Imports System.Threading
Public Class PlayingForm
    Dim Game As GameData
    Dim AcceptInput As Boolean = False

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        homePage.Show()
        Me.Close()
    End Sub

    <Serializable>
    Public Class TeamData
        Public Property TeamMembers As String()
        Public Property TeamName As String
        Public Property TeamID As Integer '1 to 4
        Public Property Scores As Integer()()

        Public Sub New(Name As String, ID As Integer, Name1 As String, Name2 As String, Name3 As String, Name4 As String)
            TeamName = Name
            TeamID = ID
            Dim NumberOfTeamMembers As Integer = 0
            If Name1 <> "" Then NumberOfTeamMembers += 1
            If Name2 <> "" Then NumberOfTeamMembers += 1
            If Name3 <> "" Then NumberOfTeamMembers += 1
            If Name4 <> "" Then NumberOfTeamMembers += 1

            Select Case NumberOfTeamMembers 'safely initialises the string array holding each teammembers names
                Case 1
                    TeamMembers = New String(0) {Name1}
                Case 2
                    TeamMembers = New String(1) {Name1, Name2}
                Case 3
                    TeamMembers = New String(2) {Name1, Name2, Name3}
                Case 4
                    TeamMembers = New String(3) {Name1, Name2, Name3, Name4}
            End Select

        End Sub

        Public Function nextTwoRolls(Frame() As Integer) As Integer 'gets the number of pins knocked in the next 2 rolls from the current integer
            Dim FrameIndex As Integer = Array.IndexOf(Scores, Frame)
            Dim Points As Integer = 0
            If FrameIndex = (Scores.Length - 1) Then
                If Frame(2) <> -1 Then
                    Points += Frame(2)
                    If Frame(3) <> -1 Then
                        Points += Frame(3)
                    End If
                End If
            ElseIf Scores(FrameIndex + 1)(1) = -1 Then
                Points = 0
            ElseIf Scores(FrameIndex + 1)(1) = 10 Then
                Points += 10
                Try
                    If Scores(FrameIndex + 2)(1) <> -1 Then
                        Points += Scores(FrameIndex + 2)(1)
                    End If
                Catch ex As Exception
                    If Scores(FrameIndex + 1)(2) <> -1 Then
                        Points += Scores(FrameIndex + 1)(2)
                    End If
                End Try
            Else
                Points += Scores(FrameIndex + 1)(1)
                If Scores(FrameIndex + 1)(2) <> -1 Then
                    Points += Scores(FrameIndex + 1)(2)

                End If
            End If
            Return Points
        End Function

        Public Function NextRoll(Frame() As Integer) 'Gets the number of pins knocked in the next roll to the given frame
            Dim FrameIndex As Integer = Array.IndexOf(Scores, Frame)
            Dim Points As Integer = 0
            If FrameIndex = (Scores.Length - 1) Then
                If Frame(3) <> -1 Then
                    Points += Frame(3)
                End If
            ElseIf Scores(FrameIndex + 1)(1) = -1 Then
                Points = 0
            ElseIf Scores(FrameIndex + 1)(1) = 10 Then
                Points += 10
                Try
                    If Scores(FrameIndex + 2)(1) <> -1 Then
                        Points += Scores(FrameIndex + 2)(1)
                    End If
                Catch ex As Exception

                End Try
            Else
                Points += Scores(FrameIndex + 1)(1)
            End If
            Return Points
        End Function

        Public Sub CalculateScore() 'calculates the scoreboard for the team
            Dim Total As Integer = 0
            For Each Frame() As Integer In Scores
                If Frame(1) = -1 Then
                    Frame(0) = Total
                    Continue For
                ElseIf Frame(1) = 10 Then
                    Frame(0) = 10 + nextTwoRolls(Frame)
                ElseIf (Frame(1) + Frame(2) = 10) Then
                    Frame(0) = 10 + NextRoll(Frame)
                Else
                    Frame(0) = Frame(1) + Frame(2)
                End If

                Frame(0) += Total

                If Array.IndexOf(Scores, Frame) = Scores.Length - 1 And Frame(1) <> 10 Then
                    If Frame(3) <> -1 Then
                        Frame(0) += Frame(3)
                    End If
                End If

                Total = Frame(0)
            Next
        End Sub

        Public Function GetPlayer(CurrentFrame As Integer) As String
            Return TeamMembers(CurrentFrame Mod TeamMembers.Length)
        End Function

    End Class

    <Serializable>
    Public Class GameData
        Public Property Teams As TeamData()
        Public Property Frames As Integer

        Public Sub AddTeam(Team As TeamData)
            If Teams Is Nothing Then
                Teams = {Team}
            Else
                Array.Resize(Teams, Teams.Length + 1)
                Teams(Teams.Length - 1) = Team
            End If
        End Sub

        Public Sub ResetFrames()
            Frames = 12

            For Each Team In Teams
                Dim save = SavingSystem.Load(SavingSystem.CurrentActiveSave)

                Debug.WriteLine("Nothing?")
                Debug.WriteLine(save.ascores.Length)

                Select Case Team.TeamID 'loads the save game data into the form
                    Case 1
                        Team.Scores = New Integer(Frames - 1)() {}
                        For Frame As Integer = 0 To (Frames - 1)
                            Team.Scores(Frame) = New Integer() {save.ascores(Frame * 3), save.ascores((Frame * 3) + 1), save.ascores((Frame * 3) + 2)} 'convrting 2d array to 1d array
                        Next
                        Team.Scores(Frames - 1) = New Integer() {save.ascores(33), save.ascores(34), save.ascores(35), save.ascores(36)}
                    Case 2
                        Team.Scores = New Integer(Frames - 1)() {}
                        For Frame As Integer = 0 To (Frames - 1)
                            Team.Scores(Frame) = New Integer() {save.bscores(Frame * 3), save.bscores((Frame * 3) + 1), save.bscores((Frame * 3) + 2)}
                        Next
                        Team.Scores(Frames - 1) = New Integer() {save.bscores(33), save.bscores(34), save.bscores(35), save.bscores(36)}
                    Case 3
                        Team.Scores = New Integer(Frames - 1)() {}
                        For Frame As Integer = 0 To (Frames - 1)
                            Team.Scores(Frame) = New Integer() {save.cscores(Frame * 3), save.cscores((Frame * 3) + 1), save.cscores((Frame * 3) + 2)}
                        Next
                        Team.Scores(Frames - 1) = New Integer() {save.cscores(33), save.cscores(34), save.cscores(35), save.cscores(36)}
                    Case 4
                        Team.Scores = New Integer(Frames - 1)() {}
                        For Frame As Integer = 0 To (Frames - 1)
                            Team.Scores(Frame) = New Integer() {save.dscores(Frame * 3), save.dscores((Frame * 3) + 1), save.dscores((Frame * 3) + 2)}
                        Next
                        Team.Scores(Frames - 1) = New Integer() {save.dscores(33), save.dscores(34), save.dscores(35), save.dscores(36)}
                End Select
            Next
        End Sub
    End Class
    Private Sub InitTeamLabels(Team As String) 'prepares all team labels for usage, setting them to the active colour scheme
        Me.Controls(Team).ForeColor = Color.White
        Me.Controls(Team + "Label").Text = ""
        Me.Controls(Team + "Total").BackColor = Color.White
        Me.Controls(Team + "Total").Text = "0"

        For FrameNumber As Integer = 1 To 12
            Dim Frame As String = "Frame" + FrameNumber.ToString
            Me.Controls(Team + Frame).BackColor = Color.White
            Me.Controls(Team + Frame).Text = ""
            Me.Controls(Team + Frame + "L").BackColor = Color.LightGray
            Me.Controls(Team + Frame + "L").Text = ""
            Me.Controls(Team + Frame + "R").BackColor = Color.LightGray
            Me.Controls(Team + Frame + "R").Text = ""
            If FrameNumber = 12 Then
                Me.Controls(Team + Frame + "D").BackColor = Color.LightGray
                Me.Controls(Team + Frame + "D").Text = ""
            End If
        Next
    End Sub
    Private Sub PlayingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game = New GameData

        For TeamNumber As Integer = 1 To 4 'sets all labels to deactivated mode
            Dim Team As String = "Team" + TeamNumber.ToString
            Me.Controls(Team).ForeColor = Color.Gray
            Me.Controls(Team + "Label").Text = ""
            Me.Controls(Team + "Total").BackColor = Color.Gray
            Me.Controls(Team + "Total").Text = ""

            For FrameNumber As Integer = 1 To 12
                Dim Frame As String = "Frame" + FrameNumber.ToString
                Me.Controls(Team + Frame).BackColor = Color.Gray
                Me.Controls(Team + Frame).Text = ""
                Me.Controls(Team + Frame + "L").BackColor = Color.DarkGray
                Me.Controls(Team + Frame + "L").Text = ""
                Me.Controls(Team + Frame + "R").BackColor = Color.DarkGray
                Me.Controls(Team + Frame + "R").Text = ""
                If FrameNumber = 12 Then
                    Me.Controls(Team + Frame + "D").BackColor = Color.DarkGray
                    Me.Controls(Team + Frame + "D").Text = ""
                End If
            Next
        Next

        'make team names variable and get them from newgame form too.
        Dim Team1Names = NewGame.Team1Names

        If Team1Names(0) <> "" Then
            InitTeamLabels("Team1")

            Dim Team1 As New TeamData("Team 1", 1, Team1Names(0), Team1Names(1), Team1Names(2), Team1Names(3))
            Team1Label.Text = Team1Names(0)
            For Member As Integer = 1 To (Team1.TeamMembers.Length - 1)
                Team1Label.Text = Team1Label.Text + ", " + Team1.TeamMembers(Member)
            Next
            Game.AddTeam(Team1)
        End If

        Dim Team2Names = NewGame.Team2Names

        If Team2Names(0) <> "" Then
            InitTeamLabels("Team2")

            Dim Team2 As New TeamData("Team 2", 2, Team2Names(0), Team2Names(1), Team2Names(2), Team2Names(3))
            Team2Label.Text = Team2Names(0)
            For Member As Integer = 1 To (Team2.TeamMembers.Length - 1)
                Team2Label.Text = Team2Label.Text + ", " + Team2.TeamMembers(Member)
            Next
            Game.AddTeam(Team2)
        End If

        Dim Team3Names = NewGame.Team3Names
        If Team3Names(0) <> "" Then
            InitTeamLabels("Team3")

            Dim Team3 As New TeamData("Team 3", 3, Team3Names(0), Team3Names(1), Team3Names(2), Team3Names(3))
            Team3Label.Text = Team3Names(0)
            For Member As Integer = 1 To (Team3.TeamMembers.Length - 1)
                Team3Label.Text = Team3Label.Text + ", " + Team3.TeamMembers(Member)
            Next
            Game.AddTeam(Team3)
        End If

        Dim Team4Names = NewGame.Team4Names
        If Team4Names(0) <> "" Then
            InitTeamLabels("Team4")

            Dim Team4 As New TeamData("Team 4", 4, Team4Names(0), Team4Names(1), Team4Names(2), Team4Names(3))
            Team4Label.Text = Team4Names(0)
            For Member As Integer = 1 To (Team4.TeamMembers.Length - 1)
                Team4Label.Text = Team4Label.Text + ", " + Team4.TeamMembers(Member)
            Next
            Game.AddTeam(Team4)
        End If

        Game.ResetFrames()

        Dim GameThread As New Thread(AddressOf GameLoop)
        GameThread.Start() 'creates a new thread for the gameloop. this allows for the game to run in a while loop without disrupting ui or being too resource intensive.

    End Sub

    Private Async Function GetIntegerInput(Message As String, title As String, MaxValue As Integer) As Task(Of Integer) 'gets input from the input textbox
        Dim Valid As Boolean = False
        Dim IntegerInput As Integer
        'Must be invoked, as this is being run on a separate worker thread.
        TurnLabel.Invoke(Sub() TurnLabel.Text = title + vbCrLf + Message)
        PinsInput.Invoke(Sub() PinsInput.PlaceholderText = String.Format("0 to {0}", MaxValue.ToString))

        While Valid = False
            Do Until AcceptInput
                Thread.Sleep(200) 'Time is not affected by much in-code facters. Must be a value large enough to not slow program down, but small enough as to not cause a noticable gap between button clic and response
            Loop
            AcceptInput = False
            Dim Input As String

            PinsInput.Invoke(Sub() Input = PinsInput.Text)

            If IsNumeric(Input) Then
                If Integer.TryParse(Input, IntegerInput) <> False Then
                    If (IntegerInput >= 0 AndAlso IntegerInput <= MaxValue) Then
                        If (PinsInput.InvokeRequired) Then
                            PinsInput.Invoke(Sub() PinsInput.Text = "")
                        Else
                            PinsInput.Text = ""
                        End If
                        Return IntegerInput
                        Valid = True
                    Else
                        MsgBox(String.Format("Number must be between 0 and {0}!", MaxValue.ToString))
                    End If
                End If
            Else
                MsgBox("You must input numeric characters only!")
            End If
        End While
    End Function

    Private Sub EnterScore_Click(sender As Object, e As EventArgs) Handles EnterScore.Click
        AcceptInput = True
        'This allows GetIntegerInput to accept and parse the inputted number 
    End Sub

    Private Async Sub GameLoop()
        For CurrentFrame As Integer = 0 To (Game.Frames - 1) 'stores which frame game is in, starting from 0. 
            For Each Team In Game.Teams
                'SINCE THIS IS RUN IN A SEPARATE THREAD, YOU CANNOT DIRECTLY ACCESS CONTROLS! they are invoked
                For i As Integer = 0 To Team.Scores.Length - 1 'prints team scoreboard to debug
                    Dim Frame As Integer() = Team.Scores(i)
                    Debug.Write(String.Format("Frame: {0}", i))
                    For j As Integer = 0 To Frame.Length - 1
                        Debug.Write(String.Format("Score {0}: {1} -- ", j, Frame(j)))
                    Next
                    Debug.WriteLine("")
                Next


                Dim FrameScore As Integer() = Team.Scores(CurrentFrame)
                Dim CurrentPlayer As String = Team.GetPlayer(CurrentFrame)
                Dim CurrentTeam As Integer = Team.TeamID
                Dim PinsDowned As Integer

                'initiates all the labels for the current frame
                Dim currentFrameLabel = Me.Controls(String.Format("Team{0}Frame{1}", CurrentTeam, CurrentFrame + 1))
                Dim currentFrameLabelL = Me.Controls(String.Format("Team{0}Frame{1}{2}", CurrentTeam, CurrentFrame + 1, "L"))
                Dim currentFrameLabelR = Me.Controls(String.Format("Team{0}Frame{1}{2}", CurrentTeam, CurrentFrame + 1, "R"))
                Dim currentFrameLabelD = If(CurrentFrame = 11, Me.Controls(String.Format("Team{0}Frame{1}{2}", CurrentTeam, CurrentFrame + 1, "D")), Nothing)
                Dim teamTotalLabel = Me.Controls(String.Format("Team{0}Total", CurrentTeam))


                If FrameScore(1) <> -1 Then 'goes through all filled frames. allows game to continue from previous save
                    'account for strikes and spares
                    If FrameScore(1) = 10 Then
                        currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = "")
                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = "X")
                    ElseIf FrameScore(1) + FrameScore(2) = 10 Then
                        currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = String.Format(FrameScore(1)))
                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = "/")
                    Else
                        currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = String.Format(FrameScore(1)))
                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = String.Format(FrameScore(2)))
                    End If
                    If CurrentFrame = 11 Then
                        If FrameScore(3) = 10 Then
                            currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = "X")
                        ElseIf FrameScore(3) = -1 Then
                            currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = "")
                        Else
                            currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = String.Format(FrameScore(3)))
                        End If
                        If FrameScore(1) = 10 Then
                            currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = "X")
                            currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = String.Format(If(FrameScore(2) = 10, "X", FrameScore(2))))
                            If FrameScore(2) + FrameScore(3) = 10 Then
                                currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = "/")
                            End If
                        End If
                    End If

                    teamTotalLabel.Invoke(Sub() teamTotalLabel.Text = String.Format(FrameScore(0)))
                    currentFrameLabel.Invoke(Sub() currentFrameLabel.Text = String.Format(FrameScore(0)))

                    Continue For
                End If

                PinsDowned = Await GetIntegerInput(String.Format("It's currently {0}'s turn!" + vbCrLf + "How many pins did they knock over? (Must be a number from 0 to 10.)", CurrentPlayer), String.Format("Input number of pins knocked over by {0} of Team {1} in Frame {2}", CurrentPlayer, (CurrentTeam).ToString, (CurrentFrame + 1).ToString), 10)
                'Make sure it is within correct values (0-10 inclusive)

                Debug.WriteLine(PinsDowned.ToString)

                FrameScore(1) = PinsDowned

                currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = String.Format(FrameScore(1)))

                If PinsDowned = 10 Then
                    ' strike
                    currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = "")

                    If CurrentFrame = (Game.Frames - 1) Then 'strike in the last frame
                        currentFrameLabelL.Invoke(Sub() currentFrameLabelL.Text = "X")

                        PinsDowned = Await GetIntegerInput(String.Format("Because {0} scored a strike in the last frame, they get 2 more bonus rolls!" + vbCrLf + "How many pins did they knock over in the first roll? (Must be a number from 0 to 10.)", CurrentPlayer), String.Format("Input number of pins knocked over by {0} of Team {1} in Frame {2}", CurrentPlayer, (CurrentTeam).ToString, (CurrentFrame + 1).ToString), 10)
                        FrameScore(2) = PinsDowned

                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = String.Format(If(FrameScore(2) = 10, "X", FrameScore(2))))

                        Dim PinsLeft As Integer = If(PinsDowned = 10, 10, 10 - PinsDowned)

                        PinsDowned = Await GetIntegerInput(String.Format("Because {0} scored a strike in the last frame, they get 2 more bonus rolls!" + vbCrLf + "How many pins did they knock over in the second roll? (Must be a number from 0 to {1}.)", CurrentPlayer, PinsLeft), String.Format("Input number of pins knocked over by {0} of Team {1} in Frame {2}", CurrentPlayer, (CurrentTeam).ToString, (CurrentFrame + 1).ToString), PinsLeft.ToString)

                        FrameScore(3) = PinsDowned

                        currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = String.Format(If(FrameScore(3) = 10, "X", FrameScore(3))))
                    Else 'Strike in any frame not the last
                        FrameScore(2) = -1

                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = "X")
                    End If
                Else
                    Dim PinsLeft As Integer = If(10 - PinsDowned = 0, 10, 10 - PinsDowned)

                    PinsDowned = Await GetIntegerInput(String.Format("For a chance to spare, {0} can bowl a second time!" + vbCrLf + "How many pins did they knock over in the second roll? (Must be a number from 0 to {1}.)", CurrentPlayer, PinsLeft.ToString), String.Format("Input number of pins knocked over by {0} of Team {1} in Frame {2}", CurrentPlayer, (CurrentTeam).ToString, (CurrentFrame + 1).ToString), PinsLeft)
                    FrameScore(2) = PinsDowned

                    currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = String.Format(FrameScore(2)))

                    If FrameScore(1) + FrameScore(2) = 10 Then
                        currentFrameLabelR.Invoke(Sub() currentFrameLabelR.Text = "/")

                        If CurrentFrame = (Game.Frames - 1) Then
                            PinsDowned = Await GetIntegerInput(String.Format("Because {0} scored a spare in the last frame, they get 1 bonus roll!" + vbCrLf + "How many pins did they knock over in this roll? (Must be a number from 0 to 10.)", CurrentPlayer), String.Format("Input number of pins knocked over by {0} of Team {1} in Frame {2}", CurrentPlayer, (CurrentTeam).ToString, (CurrentFrame + 1).ToString), 10)
                            FrameScore(3) = PinsDowned


                            currentFrameLabelD.Invoke(Sub() currentFrameLabelD.Text = String.Format(If(FrameScore(3) = 10, "X", FrameScore(3))))
                        End If
                    End If
                End If

                Team.CalculateScore()

                currentFrameLabel.Invoke(Sub() currentFrameLabel.Text = String.Format(Team.Scores(CurrentFrame)(0)))

                teamTotalLabel.Invoke(Sub() teamTotalLabel.Text = String.Format(Team.Scores(CurrentFrame)(0)))

                Dim save = SavingSystem.Load(SavingSystem.CurrentActiveSave)

                Dim oneDimensionalScores(36) As Integer
                For Each Frame In Team.Scores 'for vb.net related reasons, it can only save 1d arrays. hence all 2d score arrays are translated into 1d and saved
                    For Each Score In Frame
                        oneDimensionalScores(Array.IndexOf(Team.Scores, Frame) * 3 + Array.IndexOf(Frame, Score)) = Score
                    Next
                Next
                Debug.WriteLine(oneDimensionalScores)

                Select Case Team.TeamID
                    Case 1
                        save.ascores = oneDimensionalScores
                    Case 2
                        save.bscores = oneDimensionalScores
                    Case 3
                        save.cscores = oneDimensionalScores
                    Case 4
                        save.dscores = oneDimensionalScores
                End Select

                SavingSystem.Save(save, SavingSystem.CurrentActiveSave)
            Next
        Next

        MsgBox("Game is over! No new scores can be inputted. Select a new save to begin a new game", 1, "Game Over!")
        TurnLabel.Invoke(Sub() TurnLabel.Text = "Game over!")
        PinsInput.Invoke(Sub() PinsInput.PlaceholderText = "")
    End Sub

End Class