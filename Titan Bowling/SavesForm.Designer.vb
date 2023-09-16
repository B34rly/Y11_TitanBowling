<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavesForm
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        HomeButton = New Button()
        CType(Shape, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Shape
        ' 
        Shape.BackgroundImage = My.Resources.Resources.square_shape
        Shape.BackgroundImageLayout = ImageLayout.Zoom
        Shape.Location = New Point(773, 360)
        Shape.Name = "Shape"
        Shape.Size = New Size(220, 242)
        Shape.TabIndex = 16
        Shape.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.ErrorImage = Nothing
        PictureBox3.InitialImage = Nothing
        PictureBox3.Location = New Point(-115, -55)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(311, 252)
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(346, 36)
        Title.Name = "Title"
        Title.Size = New Size(260, 99)
        Title.TabIndex = 14
        Title.Text = "SAVES"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(17), CByte(25), CByte(56))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(208, 155)
        Button1.Name = "Button1"
        Button1.Size = New Size(537, 59)
        Button1.TabIndex = 17
        Button1.Text = "Save 1 - Team A, Team B - 7/10 Frames"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(17), CByte(25), CByte(56))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(208, 220)
        Button2.Name = "Button2"
        Button2.Size = New Size(537, 59)
        Button2.TabIndex = 18
        Button2.Text = "Save 2 - Team A, Team B, Team C - 12/12 Frames"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(17), CByte(25), CByte(56))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(208, 286)
        Button3.Name = "Button3"
        Button3.Size = New Size(537, 59)
        Button3.TabIndex = 19
        Button3.Text = "Save 3 - Team A, Team B - 5/12 Frames"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(17), CByte(25), CByte(56))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(208, 351)
        Button4.Name = "Button4"
        Button4.Size = New Size(537, 59)
        Button4.TabIndex = 20
        Button4.Text = "Save 4 - Team A, Team B, Team C, Team D - 2/10 Frames"
        Button4.UseVisualStyleBackColor = False
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
        HomeButton.TabIndex = 21
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' SavesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(HomeButton)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Shape)
        Controls.Add(PictureBox3)
        Controls.Add(Title)
        Name = "SavesForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SavesForm"
        CType(Shape, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Shape As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents HomeButton As Button
End Class
