<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupportForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SupportForm))
        Title = New Label()
        PictureBox3 = New PictureBox()
        Shape = New PictureBox()
        Label1 = New Label()
        HomeButton = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Shape, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.White
        Title.Location = New Point(101, 95)
        Title.Name = "Title"
        Title.Size = New Size(373, 99)
        Title.TabIndex = 3
        Title.Text = "SUPPORT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Shape_3
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.ErrorImage = Nothing
        PictureBox3.InitialImage = Nothing
        PictureBox3.Location = New Point(716, -23)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(311, 252)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Shape
        ' 
        Shape.BackgroundImage = My.Resources.Resources.square_shape
        Shape.BackgroundImageLayout = ImageLayout.Zoom
        Shape.Location = New Point(768, 336)
        Shape.Name = "Shape"
        Shape.Size = New Size(220, 242)
        Shape.TabIndex = 12
        Shape.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(112, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 276)
        Label1.TabIndex = 13
        Label1.Text = resources.GetString("Label1.Text")
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
        ' SupportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(32), CByte(76))
        ClientSize = New Size(944, 501)
        Controls.Add(HomeButton)
        Controls.Add(Label1)
        Controls.Add(Shape)
        Controls.Add(PictureBox3)
        Controls.Add(Title)
        Name = "SupportForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SupportForm"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Shape, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Shape As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HomeButton As Button
End Class
