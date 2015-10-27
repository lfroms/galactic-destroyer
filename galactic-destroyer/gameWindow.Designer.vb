<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameWindow))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblScoreBox = New System.Windows.Forms.Label()
        Me.lblPointsView = New System.Windows.Forms.Label()
        Me.lblLivesView = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tmrMoveFiringDevice = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFire = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGen = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAvoid = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGenTargets = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInterchange = New System.Windows.Forms.Timer(Me.components)
        Me.imgListCharAni = New System.Windows.Forms.ImageList(Me.components)
        Me.lblLost = New System.Windows.Forms.Label()
        Me.tmrPrintCharLives = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPrintGameOver = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPrintLevelUp = New System.Windows.Forms.Timer(Me.components)
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.shot = New System.Windows.Forms.PictureBox()
        Me.firingDevice = New System.Windows.Forms.PictureBox()
        Me.tmrPrintCongratulations = New System.Windows.Forms.Timer(Me.components)
        Me.msc = New System.Windows.Forms.Label()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firingDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(550, 509)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.FillColor = System.Drawing.Color.Black
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(372, 47)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Black
        Me.RectangleShape2.Size = New System.Drawing.Size(158, 77)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Enabled = False
        Me.RectangleShape1.FillColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 37)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(528, 460)
        '
        'lblScoreBox
        '
        Me.lblScoreBox.AutoSize = True
        Me.lblScoreBox.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreBox.Font = New System.Drawing.Font("Print Char 21", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBox.ForeColor = System.Drawing.Color.White
        Me.lblScoreBox.Location = New System.Drawing.Point(375, 55)
        Me.lblScoreBox.Name = "lblScoreBox"
        Me.lblScoreBox.Size = New System.Drawing.Size(74, 20)
        Me.lblScoreBox.TabIndex = 1
        Me.lblScoreBox.Text = "Score"
        Me.lblScoreBox.UseCompatibleTextRendering = True
        '
        'lblPointsView
        '
        Me.lblPointsView.AutoSize = True
        Me.lblPointsView.BackColor = System.Drawing.Color.Transparent
        Me.lblPointsView.Font = New System.Drawing.Font("Print Char 21", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsView.ForeColor = System.Drawing.Color.White
        Me.lblPointsView.Location = New System.Drawing.Point(378, 82)
        Me.lblPointsView.Name = "lblPointsView"
        Me.lblPointsView.Size = New System.Drawing.Size(91, 12)
        Me.lblPointsView.TabIndex = 2
        Me.lblPointsView.Text = "Points: 0000"
        Me.lblPointsView.UseCompatibleTextRendering = True
        '
        'lblLivesView
        '
        Me.lblLivesView.AutoSize = True
        Me.lblLivesView.BackColor = System.Drawing.Color.Transparent
        Me.lblLivesView.Font = New System.Drawing.Font("Print Char 21", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivesView.ForeColor = System.Drawing.Color.White
        Me.lblLivesView.Location = New System.Drawing.Point(378, 100)
        Me.lblLivesView.Name = "lblLivesView"
        Me.lblLivesView.Size = New System.Drawing.Size(77, 12)
        Me.lblLivesView.TabIndex = 3
        Me.lblLivesView.Text = "Lives : 00"
        Me.lblLivesView.UseCompatibleTextRendering = True
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.Black
        Me.lblHighScore.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.ForeColor = System.Drawing.Color.White
        Me.lblHighScore.Location = New System.Drawing.Point(18, 48)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(128, 14)
        Me.lblHighScore.TabIndex = 4
        Me.lblHighScore.Text = "HIGHSCORE: 0000"
        Me.lblHighScore.UseCompatibleTextRendering = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Print Char 21", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(12, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tmrMoveFiringDevice
        '
        Me.tmrMoveFiringDevice.Enabled = True
        Me.tmrMoveFiringDevice.Interval = 1
        '
        'tmrFire
        '
        Me.tmrFire.Interval = 10
        '
        'tmrGen
        '
        Me.tmrGen.Interval = 10
        '
        'tmrAvoid
        '
        Me.tmrAvoid.Enabled = True
        Me.tmrAvoid.Interval = 500
        '
        'tmrInterchange
        '
        '
        'imgListCharAni
        '
        Me.imgListCharAni.ImageStream = CType(resources.GetObject("imgListCharAni.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListCharAni.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListCharAni.Images.SetKeyName(0, "FiringDeviceA.png")
        Me.imgListCharAni.Images.SetKeyName(1, "FiringDeviceB.png")
        '
        'lblLost
        '
        Me.lblLost.AutoSize = True
        Me.lblLost.BackColor = System.Drawing.Color.Transparent
        Me.lblLost.Font = New System.Drawing.Font("Print Char 21", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLost.ForeColor = System.Drawing.Color.White
        Me.lblLost.Location = New System.Drawing.Point(214, 250)
        Me.lblLost.Name = "lblLost"
        Me.lblLost.Size = New System.Drawing.Size(0, 14)
        Me.lblLost.TabIndex = 8
        Me.lblLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLost.UseCompatibleTextRendering = True
        '
        'tmrPrintCharLives
        '
        '
        'tmrPrintGameOver
        '
        '
        'tmrPrintLevelUp
        '
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Black
        Me.lblLevel.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(446, 478)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(70, 14)
        Me.lblLevel.TabIndex = 9
        Me.lblLevel.Text = "LEVEL: 1"
        Me.lblLevel.UseCompatibleTextRendering = True
        '
        'shot
        '
        Me.shot.BackColor = System.Drawing.Color.White
        Me.shot.Location = New System.Drawing.Point(20, 469)
        Me.shot.Name = "shot"
        Me.shot.Size = New System.Drawing.Size(1, 15)
        Me.shot.TabIndex = 7
        Me.shot.TabStop = False
        '
        'firingDevice
        '
        Me.firingDevice.BackColor = System.Drawing.Color.Transparent
        Me.firingDevice.Image = Global.Galactic_Destroyer.My.Resources.Resources.FiringDevice
        Me.firingDevice.Location = New System.Drawing.Point(45, 445)
        Me.firingDevice.Name = "firingDevice"
        Me.firingDevice.Size = New System.Drawing.Size(59, 22)
        Me.firingDevice.TabIndex = 6
        Me.firingDevice.TabStop = False
        '
        'tmrPrintCongratulations
        '
        '
        'msc
        '
        Me.msc.AutoSize = True
        Me.msc.BackColor = System.Drawing.Color.Transparent
        Me.msc.Font = New System.Drawing.Font("Print Char 21", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msc.ForeColor = System.Drawing.Color.White
        Me.msc.Location = New System.Drawing.Point(164, 251)
        Me.msc.Name = "msc"
        Me.msc.Size = New System.Drawing.Size(0, 14)
        Me.msc.TabIndex = 10
        Me.msc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.msc.UseCompatibleTextRendering = True
        '
        'gameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(550, 509)
        Me.Controls.Add(Me.msc)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblLost)
        Me.Controls.Add(Me.shot)
        Me.Controls.Add(Me.firingDevice)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblLivesView)
        Me.Controls.Add(Me.lblPointsView)
        Me.Controls.Add(Me.lblScoreBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gameWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void"
        CType(Me.shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firingDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblScoreBox As System.Windows.Forms.Label
    Friend WithEvents lblPointsView As System.Windows.Forms.Label
    Friend WithEvents lblLivesView As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents firingDevice As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMoveFiringDevice As System.Windows.Forms.Timer
    Friend WithEvents tmrFire As System.Windows.Forms.Timer
    Friend WithEvents tmrGen As System.Windows.Forms.Timer
    Friend WithEvents tmrAvoid As System.Windows.Forms.Timer
    Friend WithEvents tmrGenTargets As System.Windows.Forms.Timer
    Friend WithEvents tmrInterchange As System.Windows.Forms.Timer
    Friend WithEvents shot As System.Windows.Forms.PictureBox
    Friend WithEvents imgListCharAni As System.Windows.Forms.ImageList
    Friend WithEvents lblLost As System.Windows.Forms.Label
    Friend WithEvents tmrPrintCharLives As System.Windows.Forms.Timer
    Friend WithEvents tmrPrintGameOver As System.Windows.Forms.Timer
    Friend WithEvents tmrPrintLevelUp As System.Windows.Forms.Timer
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents tmrPrintCongratulations As System.Windows.Forms.Timer
    Friend WithEvents msc As System.Windows.Forms.Label

End Class
