<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homePage
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
        Me.PlayBttn = New System.Windows.Forms.Button()
        Me.BackgroundRing = New System.Windows.Forms.PictureBox()
        Me.Ringimg1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SavedGames = New System.Windows.Forms.Button()
        Me.SETTINGS = New System.Windows.Forms.Button()
        Me.TUTORIAL = New System.Windows.Forms.Button()
        Me.SUPPORT = New System.Windows.Forms.Button()
        CType(Me.BackgroundRing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ringimg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(269, 101)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(636, 100)
        Me.Title.TabIndex = 0
        Me.Title.Text = "TITAN BOWLING"
        '
        'PlayBttn
        '
        Me.PlayBttn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBttn.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.PlayBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PlayBttn.FlatAppearance.BorderSize = 0
        Me.PlayBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.PlayBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PlayBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayBttn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayBttn.Location = New System.Drawing.Point(462, 281)
        Me.PlayBttn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlayBttn.Name = "PlayBttn"
        Me.PlayBttn.Size = New System.Drawing.Size(178, 80)
        Me.PlayBttn.TabIndex = 1
        Me.PlayBttn.Text = "PLAY"
        Me.PlayBttn.UseVisualStyleBackColor = False
        '
        'BackgroundRing
        '
        Me.BackgroundRing.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundRing.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Ring
        Me.BackgroundRing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackgroundRing.Location = New System.Drawing.Point(93, 309)
        Me.BackgroundRing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BackgroundRing.Name = "BackgroundRing"
        Me.BackgroundRing.Size = New System.Drawing.Size(914, 553)
        Me.BackgroundRing.TabIndex = 2
        Me.BackgroundRing.TabStop = False
        '
        'Ringimg1
        '
        Me.Ringimg1.BackColor = System.Drawing.Color.Transparent
        Me.Ringimg1.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_1
        Me.Ringimg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Ringimg1.ErrorImage = Nothing
        Me.Ringimg1.InitialImage = Nothing
        Me.Ringimg1.Location = New System.Drawing.Point(-63, -36)
        Me.Ringimg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ringimg1.Name = "Ringimg1"
        Me.Ringimg1.Size = New System.Drawing.Size(242, 197)
        Me.Ringimg1.TabIndex = 3
        Me.Ringimg1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(345, 415)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(410, 513)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_3
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(912, 85)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(355, 336)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'SavedGames
        '
        Me.SavedGames.BackColor = System.Drawing.Color.Transparent
        Me.SavedGames.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.SavedGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SavedGames.FlatAppearance.BorderSize = 0
        Me.SavedGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SavedGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SavedGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SavedGames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SavedGames.Location = New System.Drawing.Point(672, 380)
        Me.SavedGames.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SavedGames.Name = "SavedGames"
        Me.SavedGames.Size = New System.Drawing.Size(178, 80)
        Me.SavedGames.TabIndex = 7
        Me.SavedGames.Text = "SAVED GAMES"
        Me.SavedGames.UseVisualStyleBackColor = False
        '
        'SETTINGS
        '
        Me.SETTINGS.BackColor = System.Drawing.Color.Transparent
        Me.SETTINGS.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.SETTINGS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SETTINGS.FlatAppearance.BorderSize = 0
        Me.SETTINGS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SETTINGS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SETTINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SETTINGS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SETTINGS.Location = New System.Drawing.Point(761, 555)
        Me.SETTINGS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SETTINGS.Name = "SETTINGS"
        Me.SETTINGS.Size = New System.Drawing.Size(178, 80)
        Me.SETTINGS.TabIndex = 8
        Me.SETTINGS.Text = "SETTINGS"
        Me.SETTINGS.UseVisualStyleBackColor = False
        '
        'TUTORIAL
        '
        Me.TUTORIAL.BackColor = System.Drawing.Color.Transparent
        Me.TUTORIAL.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.TUTORIAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TUTORIAL.FlatAppearance.BorderSize = 0
        Me.TUTORIAL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TUTORIAL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TUTORIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TUTORIAL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TUTORIAL.Location = New System.Drawing.Point(250, 380)
        Me.TUTORIAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TUTORIAL.Name = "TUTORIAL"
        Me.TUTORIAL.Size = New System.Drawing.Size(178, 80)
        Me.TUTORIAL.TabIndex = 9
        Me.TUTORIAL.Text = "TUTORIAL"
        Me.TUTORIAL.UseVisualStyleBackColor = False
        '
        'SUPPORT
        '
        Me.SUPPORT.BackColor = System.Drawing.Color.Transparent
        Me.SUPPORT.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Button_Background
        Me.SUPPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SUPPORT.FlatAppearance.BorderSize = 0
        Me.SUPPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SUPPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SUPPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUPPORT.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SUPPORT.Location = New System.Drawing.Point(159, 555)
        Me.SUPPORT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SUPPORT.Name = "SUPPORT"
        Me.SUPPORT.Size = New System.Drawing.Size(178, 80)
        Me.SUPPORT.TabIndex = 10
        Me.SUPPORT.Text = "CREDITS"
        Me.SUPPORT.UseVisualStyleBackColor = False
        '
        'homePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 668)
        Me.Controls.Add(Me.SUPPORT)
        Me.Controls.Add(Me.TUTORIAL)
        Me.Controls.Add(Me.SETTINGS)
        Me.Controls.Add(Me.SavedGames)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Ringimg1)
        Me.Controls.Add(Me.PlayBttn)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.BackgroundRing)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "homePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.BackgroundRing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ringimg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents PlayBttn As Button
    Friend WithEvents BackgroundRing As PictureBox
    Friend WithEvents Ringimg1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SavedGames As Button
    Friend WithEvents SETTINGS As Button
    Friend WithEvents TUTORIAL As Button
    Friend WithEvents SUPPORT As Button
End Class
