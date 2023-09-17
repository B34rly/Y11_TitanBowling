<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Title = New Label()
        Shape = New PictureBox()
        ColorTheme = New Button()
        Volume = New Button()
        Button2 = New Button()
        HomeButton = New Button()
        CType(Shape, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(63, 181)
        Title.Name = "Title"
        Title.Size = New Size(385, 99)
        Title.TabIndex = 1
        Title.Text = "SETTINGS"
        ' 
        ' Shape
        ' 
        Shape.BackgroundImage = My.Resources.Resources.square_shape
        Shape.BackgroundImageLayout = ImageLayout.Zoom
        Shape.Location = New Point(-374, 114)
        Shape.Name = "Shape"
        Shape.Size = New Size(853, 242)
        Shape.TabIndex = 2
        Shape.TabStop = False
        ' 
        ' ColorTheme
        ' 
        ColorTheme.BackColor = Color.Transparent
        ColorTheme.BackgroundImageLayout = ImageLayout.Zoom
        ColorTheme.FlatAppearance.BorderSize = 0
        ColorTheme.FlatAppearance.MouseDownBackColor = Color.Transparent
        ColorTheme.FlatAppearance.MouseOverBackColor = Color.Transparent
        ColorTheme.FlatStyle = FlatStyle.Flat
        ColorTheme.Font = New Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point)
        ColorTheme.ForeColor = Color.White
        ColorTheme.Location = New Point(529, 144)
        ColorTheme.Name = "ColorTheme"
        ColorTheme.Size = New Size(223, 60)
        ColorTheme.TabIndex = 3
        ColorTheme.Text = "BLUE"
        ColorTheme.TextAlign = ContentAlignment.MiddleLeft
        ColorTheme.UseVisualStyleBackColor = False
        ' 
        ' Volume
        ' 
        Volume.BackColor = Color.Transparent
        Volume.BackgroundImageLayout = ImageLayout.Zoom
        Volume.FlatAppearance.BorderSize = 0
        Volume.FlatAppearance.MouseDownBackColor = Color.Transparent
        Volume.FlatAppearance.MouseOverBackColor = Color.Transparent
        Volume.FlatStyle = FlatStyle.Flat
        Volume.Font = New Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point)
        Volume.ForeColor = Color.White
        Volume.Location = New Point(529, 210)
        Volume.Name = "Volume"
        Volume.Size = New Size(223, 60)
        Volume.TabIndex = 4
        Volume.Text = "MUTE"
        Volume.TextAlign = ContentAlignment.MiddleLeft
        Volume.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(529, 276)
        Button2.Name = "Button2"
        Button2.Size = New Size(223, 60)
        Button2.TabIndex = 5
        Button2.Text = "DELETE SAVES"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' HomeButton
        ' 
        HomeButton.BackgroundImage = My.Resources.Resources.home
        HomeButton.BackgroundImageLayout = ImageLayout.Zoom
        HomeButton.FlatAppearance.BorderSize = 0
        HomeButton.FlatStyle = FlatStyle.Flat
        HomeButton.Location = New Point(10, 10)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(35, 40)
        HomeButton.TabIndex = 22
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(HomeButton)
        Controls.Add(Button2)
        Controls.Add(Volume)
        Controls.Add(ColorTheme)
        Controls.Add(Title)
        Controls.Add(Shape)
        Name = "SettingsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        CType(Shape, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Shape As PictureBox
    Friend WithEvents ColorTheme As Button
    Friend WithEvents Volume As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HomeButton As Button
End Class
