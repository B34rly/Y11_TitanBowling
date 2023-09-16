<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Title = New Label()
        team1 = New Button()
        team2 = New Button()
        team3 = New Button()
        team4 = New Button()
        NameInput = New TextBox()
        AddNAme = New Button()
        EnterGame = New Button()
        PictureBox3 = New PictureBox()
        Ringimg1 = New PictureBox()
        PictureBox1 = New PictureBox()
        HomeButton = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ringimg1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(267, 31)
        Title.Name = "Title"
        Title.Size = New Size(449, 99)
        Title.TabIndex = 2
        Title.Text = "NEW GAME"
        ' 
        ' team1
        ' 
        team1.BackColor = Color.White
        team1.FlatAppearance.BorderSize = 0
        team1.FlatStyle = FlatStyle.Flat
        team1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        team1.Location = New Point(204, 204)
        team1.Name = "team1"
        team1.Size = New Size(131, 182)
        team1.TabIndex = 3
        team1.TextAlign = ContentAlignment.TopCenter
        team1.UseVisualStyleBackColor = False
        ' 
        ' team2
        ' 
        team2.BackColor = Color.White
        team2.FlatAppearance.BorderSize = 0
        team2.FlatStyle = FlatStyle.Flat
        team2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        team2.Location = New Point(354, 204)
        team2.Name = "team2"
        team2.Size = New Size(131, 182)
        team2.TabIndex = 4
        team2.TextAlign = ContentAlignment.TopCenter
        team2.UseVisualStyleBackColor = False
        ' 
        ' team3
        ' 
        team3.BackColor = Color.White
        team3.FlatAppearance.BorderSize = 0
        team3.FlatStyle = FlatStyle.Flat
        team3.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        team3.Location = New Point(505, 204)
        team3.Name = "team3"
        team3.Size = New Size(131, 182)
        team3.TabIndex = 5
        team3.TextAlign = ContentAlignment.TopCenter
        team3.UseVisualStyleBackColor = False
        ' 
        ' team4
        ' 
        team4.BackColor = Color.White
        team4.FlatAppearance.BorderSize = 0
        team4.FlatStyle = FlatStyle.Flat
        team4.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        team4.Location = New Point(656, 204)
        team4.Name = "team4"
        team4.Size = New Size(131, 182)
        team4.TabIndex = 6
        team4.TextAlign = ContentAlignment.TopCenter
        team4.UseVisualStyleBackColor = False
        ' 
        ' NameInput
        ' 
        NameInput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NameInput.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        NameInput.Location = New Point(341, 143)
        NameInput.Name = "NameInput"
        NameInput.PlaceholderText = "Enter Name"
        NameInput.Size = New Size(193, 34)
        NameInput.TabIndex = 7
        NameInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' AddNAme
        ' 
        AddNAme.BackColor = Color.Transparent
        AddNAme.BackgroundImage = My.Resources.Resources.Button_Background
        AddNAme.BackgroundImageLayout = ImageLayout.Zoom
        AddNAme.FlatAppearance.BorderSize = 0
        AddNAme.FlatAppearance.MouseDownBackColor = Color.Transparent
        AddNAme.FlatAppearance.MouseOverBackColor = Color.Transparent
        AddNAme.FlatStyle = FlatStyle.Flat
        AddNAme.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AddNAme.Location = New Point(550, 143)
        AddNAme.Name = "AddNAme"
        AddNAme.Size = New Size(101, 34)
        AddNAme.TabIndex = 8
        AddNAme.Text = "ADD"
        AddNAme.UseVisualStyleBackColor = False
        ' 
        ' EnterGame
        ' 
        EnterGame.BackColor = Color.Transparent
        EnterGame.BackgroundImage = My.Resources.Resources.Button_Background
        EnterGame.BackgroundImageLayout = ImageLayout.Zoom
        EnterGame.FlatAppearance.BorderSize = 0
        EnterGame.FlatAppearance.MouseDownBackColor = Color.Transparent
        EnterGame.FlatAppearance.MouseOverBackColor = Color.Transparent
        EnterGame.FlatStyle = FlatStyle.Flat
        EnterGame.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        EnterGame.Location = New Point(379, 434)
        EnterGame.Name = "EnterGame"
        EnterGame.Size = New Size(228, 55)
        EnterGame.TabIndex = 9
        EnterGame.Text = "ENTER GAME"
        EnterGame.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.ErrorImage = Nothing
        PictureBox3.InitialImage = Nothing
        PictureBox3.Location = New Point(850, 31)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(311, 252)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Ringimg1
        ' 
        Ringimg1.BackColor = Color.Transparent
        Ringimg1.BackgroundImage = My.Resources.Resources.Shape_1
        Ringimg1.BackgroundImageLayout = ImageLayout.Zoom
        Ringimg1.ErrorImage = Nothing
        Ringimg1.InitialImage = Nothing
        Ringimg1.Location = New Point(-57, -18)
        Ringimg1.Name = "Ringimg1"
        Ringimg1.Size = New Size(212, 148)
        Ringimg1.TabIndex = 11
        Ringimg1.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(-113, 340)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(311, 252)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' HomeButton
        ' 
        HomeButton.BackgroundImage = My.Resources.Resources.home
        HomeButton.BackgroundImageLayout = ImageLayout.Zoom
        HomeButton.FlatAppearance.BorderSize = 0
        HomeButton.FlatStyle = FlatStyle.Flat
        HomeButton.Location = New Point(12, 12)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(35, 40)
        HomeButton.TabIndex = 21
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Brown
        Button1.Location = New Point(204, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 25)
        Button1.TabIndex = 22
        Button1.Text = "Remove All"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Brown
        Button2.Location = New Point(354, 392)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 25)
        Button2.TabIndex = 23
        Button2.Text = "Remove All"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Brown
        Button3.Location = New Point(505, 392)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 25)
        Button3.TabIndex = 24
        Button3.Text = "Remove All"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Brown
        Button4.Location = New Point(656, 392)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 25)
        Button4.TabIndex = 25
        Button4.Text = "Remove All"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' NewGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(HomeButton)
        Controls.Add(PictureBox1)
        Controls.Add(Ringimg1)
        Controls.Add(PictureBox3)
        Controls.Add(EnterGame)
        Controls.Add(AddNAme)
        Controls.Add(NameInput)
        Controls.Add(team4)
        Controls.Add(team3)
        Controls.Add(team2)
        Controls.Add(team1)
        Controls.Add(Title)
        Name = "NewGame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NewGame"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Ringimg1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents team1 As Button
    Friend WithEvents team2 As Button
    Friend WithEvents team3 As Button
    Friend WithEvents team4 As Button
    Friend WithEvents NameInput As TextBox
    Friend WithEvents AddNAme As Button
    Friend WithEvents EnterGame As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Ringimg1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
