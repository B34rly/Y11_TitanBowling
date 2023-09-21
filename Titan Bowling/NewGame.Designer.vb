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
        Me.Title = New System.Windows.Forms.Label()
        Me.team1 = New System.Windows.Forms.Button()
        Me.team2 = New System.Windows.Forms.Button()
        Me.team3 = New System.Windows.Forms.Button()
        Me.team4 = New System.Windows.Forms.Button()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.AddNAme = New System.Windows.Forms.Button()
        Me.EnterGame = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Ringimg1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ringimg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(292, 41)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(560, 123)
        Me.Title.TabIndex = 2
        Me.Title.Text = "NEW GAME"
        '
        'team1
        '
        Me.team1.BackColor = System.Drawing.Color.White
        Me.team1.FlatAppearance.BorderSize = 0
        Me.team1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.team1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.team1.Location = New System.Drawing.Point(233, 272)
        Me.team1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.team1.Name = "team1"
        Me.team1.Size = New System.Drawing.Size(150, 243)
        Me.team1.TabIndex = 3
        Me.team1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.team1.UseVisualStyleBackColor = False
        '
        'team2
        '
        Me.team2.BackColor = System.Drawing.Color.White
        Me.team2.FlatAppearance.BorderSize = 0
        Me.team2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.team2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.team2.Location = New System.Drawing.Point(405, 272)
        Me.team2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.team2.Name = "team2"
        Me.team2.Size = New System.Drawing.Size(150, 243)
        Me.team2.TabIndex = 4
        Me.team2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.team2.UseVisualStyleBackColor = False
        '
        'team3
        '
        Me.team3.BackColor = System.Drawing.Color.White
        Me.team3.FlatAppearance.BorderSize = 0
        Me.team3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.team3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.team3.Location = New System.Drawing.Point(577, 272)
        Me.team3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.team3.Name = "team3"
        Me.team3.Size = New System.Drawing.Size(150, 243)
        Me.team3.TabIndex = 5
        Me.team3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.team3.UseVisualStyleBackColor = False
        '
        'team4
        '
        Me.team4.BackColor = System.Drawing.Color.White
        Me.team4.FlatAppearance.BorderSize = 0
        Me.team4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.team4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.team4.Location = New System.Drawing.Point(750, 272)
        Me.team4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.team4.Name = "team4"
        Me.team4.Size = New System.Drawing.Size(150, 243)
        Me.team4.TabIndex = 6
        Me.team4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.team4.UseVisualStyleBackColor = False
        '
        'NameInput
        '
        Me.NameInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameInput.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameInput.Location = New System.Drawing.Point(391, 182)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.PlaceholderText = "Enter Name"
        Me.NameInput.Size = New System.Drawing.Size(220, 41)
        Me.NameInput.TabIndex = 7
        Me.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddNAme
        '
        Me.AddNAme.BackColor = System.Drawing.Color.Transparent
        Me.AddNAme.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.AddNAme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddNAme.FlatAppearance.BorderSize = 0
        Me.AddNAme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AddNAme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AddNAme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNAme.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddNAme.Location = New System.Drawing.Point(630, 182)
        Me.AddNAme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddNAme.Name = "AddNAme"
        Me.AddNAme.Size = New System.Drawing.Size(115, 45)
        Me.AddNAme.TabIndex = 8
        Me.AddNAme.Text = "ADD"
        Me.AddNAme.UseVisualStyleBackColor = False
        '
        'EnterGame
        '
        Me.EnterGame.BackColor = System.Drawing.Color.Transparent
        Me.EnterGame.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.EnterGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EnterGame.FlatAppearance.BorderSize = 0
        Me.EnterGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EnterGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.EnterGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnterGame.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnterGame.Location = New System.Drawing.Point(433, 579)
        Me.EnterGame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EnterGame.Name = "EnterGame"
        Me.EnterGame.Size = New System.Drawing.Size(261, 73)
        Me.EnterGame.TabIndex = 9
        Me.EnterGame.Text = "ENTER GAME"
        Me.EnterGame.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_3
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(971, 41)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(355, 336)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Ringimg1
        '
        Me.Ringimg1.BackColor = System.Drawing.Color.Transparent
        Me.Ringimg1.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_1
        Me.Ringimg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Ringimg1.ErrorImage = Nothing
        Me.Ringimg1.InitialImage = Nothing
        Me.Ringimg1.Location = New System.Drawing.Point(-65, -24)
        Me.Ringimg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ringimg1.Name = "Ringimg1"
        Me.Ringimg1.Size = New System.Drawing.Size(242, 197)
        Me.Ringimg1.TabIndex = 11
        Me.Ringimg1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-129, 453)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 336)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.home
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Location = New System.Drawing.Point(14, 16)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(40, 53)
        Me.HomeButton.TabIndex = 21
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(233, 523)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Remove All"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Brown
        Me.Button2.Location = New System.Drawing.Point(405, 523)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 33)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Remove All"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Brown
        Me.Button3.Location = New System.Drawing.Point(577, 523)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 33)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Remove All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.Brown
        Me.Button4.Location = New System.Drawing.Point(750, 523)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 33)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Remove All"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Team 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(433, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 28)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Team 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(614, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Team 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(785, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Team 4"
        '
        'NewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 668)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ringimg1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.EnterGame)
        Me.Controls.Add(Me.AddNAme)
        Me.Controls.Add(Me.NameInput)
        Me.Controls.Add(Me.team4)
        Me.Controls.Add(Me.team3)
        Me.Controls.Add(Me.team2)
        Me.Controls.Add(Me.team1)
        Me.Controls.Add(Me.Title)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NewGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewGame"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ringimg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
