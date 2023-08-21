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
        Shape = New PictureBox()
        PictureBox3 = New PictureBox()
        Title = New Label()
        HomeButton = New Button()
        CType(Shape, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Shape
        ' 
        Shape.BackgroundImage = My.Resources.Resources.square_shape
        Shape.BackgroundImageLayout = ImageLayout.Zoom
        Shape.Location = New Point(806, 337)
        Shape.Name = "Shape"
        Shape.Size = New Size(220, 242)
        Shape.TabIndex = 19
        Shape.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.ErrorImage = Nothing
        PictureBox3.InitialImage = Nothing
        PictureBox3.Location = New Point(-142, -92)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(311, 252)
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(188, 27)
        Title.Name = "Title"
        Title.Size = New Size(396, 99)
        Title.TabIndex = 17
        Title.Text = "TUTORIAL"
        ' 
        ' HomeButton
        ' 
        HomeButton.BackgroundImage = My.Resources.Resources.home
        HomeButton.BackgroundImageLayout = ImageLayout.Zoom
        HomeButton.FlatAppearance.BorderSize = 0
        HomeButton.FlatStyle = FlatStyle.Flat
        HomeButton.Location = New Point(897, 12)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(35, 40)
        HomeButton.TabIndex = 20
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' TutorialForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(HomeButton)
        Controls.Add(Shape)
        Controls.Add(PictureBox3)
        Controls.Add(Title)
        Name = "TutorialForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TutorialForm"
        CType(Shape, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Shape As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents HomeButton As Button
End Class
