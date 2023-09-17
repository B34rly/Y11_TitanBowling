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
        Title = New Label()
        PlayBttn = New Button()
        BackgroundRing = New PictureBox()
        Ringimg1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        SavedGames = New Button()
        SETTINGS = New Button()
        TUTORIAL = New Button()
        SUPPORT = New Button()
        CType(BackgroundRing, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ringimg1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(235, 76)
        Title.Name = "Title"
        Title.Size = New Size(509, 81)
        Title.TabIndex = 0
        Title.Text = "TITAN BOWLING"
        ' 
        ' PlayBttn
        ' 
        PlayBttn.BackColor = Color.Transparent
        PlayBttn.BackgroundImage = My.Resources.Resources.Button_Background
        PlayBttn.BackgroundImageLayout = ImageLayout.Zoom
        PlayBttn.FlatAppearance.BorderSize = 0
        PlayBttn.FlatAppearance.MouseDownBackColor = Color.Transparent
        PlayBttn.FlatAppearance.MouseOverBackColor = Color.Transparent
        PlayBttn.FlatStyle = FlatStyle.Flat
        PlayBttn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PlayBttn.Location = New Point(404, 211)
        PlayBttn.Name = "PlayBttn"
        PlayBttn.Size = New Size(156, 60)
        PlayBttn.TabIndex = 1
        PlayBttn.Text = "PLAY"
        PlayBttn.UseVisualStyleBackColor = False
        ' 
        ' BackgroundRing
        ' 
        BackgroundRing.BackColor = Color.Transparent
        BackgroundRing.BackgroundImage = My.Resources.Resources.Ring
        BackgroundRing.BackgroundImageLayout = ImageLayout.Zoom
        BackgroundRing.Location = New Point(81, 232)
        BackgroundRing.Name = "BackgroundRing"
        BackgroundRing.Size = New Size(800, 415)
        BackgroundRing.TabIndex = 2
        BackgroundRing.TabStop = False
        ' 
        ' Ringimg1
        ' 
        Ringimg1.BackColor = Color.Transparent
        Ringimg1.BackgroundImage = My.Resources.Resources.Shape_1
        Ringimg1.BackgroundImageLayout = ImageLayout.Zoom
        Ringimg1.ErrorImage = Nothing
        Ringimg1.InitialImage = Nothing
        Ringimg1.Location = New Point(-55, -27)
        Ringimg1.Name = "Ringimg1"
        Ringimg1.Size = New Size(212, 148)
        Ringimg1.TabIndex = 3
        Ringimg1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.Shape_2
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.ErrorImage = Nothing
        PictureBox2.InitialImage = Nothing
        PictureBox2.Location = New Point(302, 311)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(359, 385)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.ErrorImage = Nothing
        PictureBox3.InitialImage = Nothing
        PictureBox3.Location = New Point(798, 64)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(311, 252)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' SavedGames
        ' 
        SavedGames.BackColor = Color.Transparent
        SavedGames.BackgroundImage = My.Resources.Resources.Button_Background
        SavedGames.BackgroundImageLayout = ImageLayout.Zoom
        SavedGames.FlatAppearance.BorderSize = 0
        SavedGames.FlatAppearance.MouseDownBackColor = Color.Transparent
        SavedGames.FlatAppearance.MouseOverBackColor = Color.Transparent
        SavedGames.FlatStyle = FlatStyle.Flat
        SavedGames.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SavedGames.Location = New Point(588, 285)
        SavedGames.Name = "SavedGames"
        SavedGames.Size = New Size(156, 60)
        SavedGames.TabIndex = 7
        SavedGames.Text = "SAVED GAMES"
        SavedGames.UseVisualStyleBackColor = False
        ' 
        ' SETTINGS
        ' 
        SETTINGS.BackColor = Color.Transparent
        SETTINGS.BackgroundImage = My.Resources.Resources.Button_Background
        SETTINGS.BackgroundImageLayout = ImageLayout.Zoom
        SETTINGS.FlatAppearance.BorderSize = 0
        SETTINGS.FlatAppearance.MouseDownBackColor = Color.Transparent
        SETTINGS.FlatAppearance.MouseOverBackColor = Color.Transparent
        SETTINGS.FlatStyle = FlatStyle.Flat
        SETTINGS.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SETTINGS.Location = New Point(666, 416)
        SETTINGS.Name = "SETTINGS"
        SETTINGS.Size = New Size(156, 60)
        SETTINGS.TabIndex = 8
        SETTINGS.Text = "SETTINGS"
        SETTINGS.UseVisualStyleBackColor = False
        ' 
        ' TUTORIAL
        ' 
        TUTORIAL.BackColor = Color.Transparent
        TUTORIAL.BackgroundImage = My.Resources.Resources.Button_Background
        TUTORIAL.BackgroundImageLayout = ImageLayout.Zoom
        TUTORIAL.FlatAppearance.BorderSize = 0
        TUTORIAL.FlatAppearance.MouseDownBackColor = Color.Transparent
        TUTORIAL.FlatAppearance.MouseOverBackColor = Color.Transparent
        TUTORIAL.FlatStyle = FlatStyle.Flat
        TUTORIAL.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TUTORIAL.Location = New Point(219, 285)
        TUTORIAL.Name = "TUTORIAL"
        TUTORIAL.Size = New Size(156, 60)
        TUTORIAL.TabIndex = 9
        TUTORIAL.Text = "TUTORIAL"
        TUTORIAL.UseVisualStyleBackColor = False
        ' 
        ' SUPPORT
        ' 
        SUPPORT.BackColor = Color.Transparent
        SUPPORT.BackgroundImage = My.Resources.Resources.Button_Background
        SUPPORT.BackgroundImageLayout = ImageLayout.Zoom
        SUPPORT.FlatAppearance.BorderSize = 0
        SUPPORT.FlatAppearance.MouseDownBackColor = Color.Transparent
        SUPPORT.FlatAppearance.MouseOverBackColor = Color.Transparent
        SUPPORT.FlatStyle = FlatStyle.Flat
        SUPPORT.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        SUPPORT.Location = New Point(139, 416)
        SUPPORT.Name = "SUPPORT"
        SUPPORT.Size = New Size(156, 60)
        SUPPORT.TabIndex = 10
        SUPPORT.Text = "SUPPORT"
        SUPPORT.UseVisualStyleBackColor = False
        ' 
        ' homePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(SUPPORT)
        Controls.Add(TUTORIAL)
        Controls.Add(SETTINGS)
        Controls.Add(SavedGames)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Ringimg1)
        Controls.Add(PlayBttn)
        Controls.Add(Title)
        Controls.Add(BackgroundRing)
        Name = "homePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(BackgroundRing, ComponentModel.ISupportInitialize).EndInit()
        CType(Ringimg1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
