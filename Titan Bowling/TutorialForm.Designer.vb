<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialForm
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
        Me.Shape = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.TutorialText = New System.Windows.Forms.Label()
        CType(Me.Shape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shape
        '
        Me.Shape.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.square_shape
        Me.Shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Shape.Location = New System.Drawing.Point(-51, 432)
        Me.Shape.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Shape.Name = "Shape"
        Me.Shape.Size = New System.Drawing.Size(251, 323)
        Me.Shape.TabIndex = 19
        Me.Shape.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.Shape_3
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(817, -37)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(355, 336)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(200, 81)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(495, 123)
        Me.Title.TabIndex = 17
        Me.Title.Text = "TUTORIAL"
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.Titan_Bowling.My.Resources.Resources.home
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Location = New System.Drawing.Point(31, 25)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(40, 53)
        Me.HomeButton.TabIndex = 20
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'TutorialText
        '
        Me.TutorialText.BackColor = System.Drawing.Color.Transparent
        Me.TutorialText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TutorialText.ForeColor = System.Drawing.Color.White
        Me.TutorialText.Location = New System.Drawing.Point(215, 228)
        Me.TutorialText.Name = "TutorialText"
        Me.TutorialText.Size = New System.Drawing.Size(656, 368)
        Me.TutorialText.TabIndex = 21
        Me.TutorialText.Text = "This game follows traditional bowling rules but with a 12 frame game."
        '
        'TutorialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 668)
        Me.Controls.Add(Me.TutorialText)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Shape)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Title)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TutorialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TutorialForm"
        CType(Me.Shape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Shape As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents TutorialText As Label
End Class
