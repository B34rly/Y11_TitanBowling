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
        Me.Title = New System.Windows.Forms.Label()
        Me.Shape = New System.Windows.Forms.PictureBox()
        Me.ColorTheme = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        CType(Me.Shape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(72, 241)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(483, 123)
        Me.Title.TabIndex = 1
        Me.Title.Text = "SETTINGS"
        '
        'Shape
        '
        Me.Shape.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.square_shape
        Me.Shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Shape.Location = New System.Drawing.Point(-427, 152)
        Me.Shape.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Shape.Name = "Shape"
        Me.Shape.Size = New System.Drawing.Size(975, 323)
        Me.Shape.TabIndex = 2
        Me.Shape.TabStop = False
        '
        'ColorTheme
        '
        Me.ColorTheme.BackColor = System.Drawing.Color.Transparent
        Me.ColorTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ColorTheme.FlatAppearance.BorderSize = 0
        Me.ColorTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ColorTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ColorTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorTheme.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ColorTheme.ForeColor = System.Drawing.Color.White
        Me.ColorTheme.Location = New System.Drawing.Point(605, 192)
        Me.ColorTheme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ColorTheme.Name = "ColorTheme"
        Me.ColorTheme.Size = New System.Drawing.Size(255, 80)
        Me.ColorTheme.TabIndex = 3
        Me.ColorTheme.Text = "THEMES"
        Me.ColorTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ColorTheme.UseVisualStyleBackColor = False
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.Color.Transparent
        Me.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Volume.FlatAppearance.BorderSize = 0
        Me.Volume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Volume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Volume.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Volume.ForeColor = System.Drawing.Color.White
        Me.Volume.Location = New System.Drawing.Point(605, 280)
        Me.Volume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(126, 80)
        Me.Volume.TabIndex = 4
        Me.Volume.Text = "MUTE"
        Me.Volume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Volume.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(605, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 80)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "DELETE SAVES"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.home
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Location = New System.Drawing.Point(12, 13)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(40, 53)
        Me.HomeButton.TabIndex = 22
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 668)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.ColorTheme)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Shape)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.Shape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Shape As PictureBox
    Friend WithEvents ColorTheme As Button
    Friend WithEvents Volume As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HomeButton As Button
End Class
