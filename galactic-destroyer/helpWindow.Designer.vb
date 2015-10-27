<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(helpWindow))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tmrMoveFiringDevice = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFire = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGen = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAvoid = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGenTargets = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInterchange = New System.Windows.Forms.Timer(Me.components)
        Me.imgListCharAni = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrPrintCharLives = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPrintGameOver = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.firingDevice = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firingDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(550, 509)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
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
        Me.btnClose.TabIndex = 0
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
        'imgListCharAni
        '
        Me.imgListCharAni.ImageStream = CType(resources.GetObject("imgListCharAni.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListCharAni.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListCharAni.Images.SetKeyName(0, "FiringDeviceA.png")
        Me.imgListCharAni.Images.SetKeyName(1, "FiringDeviceB.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 95)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NAVIGATION:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " A - MOVE LEFT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " D - MOVE RIGHT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " L - FIRE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OBJECTIVES:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " FI" & _
    "RE AT THE       WHILE AVOIDING THE FALLING"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galactic_Destroyer.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(143, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 159)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'firingDevice
        '
        Me.firingDevice.BackColor = System.Drawing.Color.Transparent
        Me.firingDevice.Image = Global.Galactic_Destroyer.My.Resources.Resources.FiringDevice
        Me.firingDevice.Location = New System.Drawing.Point(317, 327)
        Me.firingDevice.Name = "firingDevice"
        Me.firingDevice.Size = New System.Drawing.Size(59, 22)
        Me.firingDevice.TabIndex = 6
        Me.firingDevice.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Galactic_Destroyer.My.Resources.Resources.AvoidObject1
        Me.PictureBox2.Location = New System.Drawing.Point(447, 386)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 50)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Galactic_Destroyer.My.Resources.Resources.TargetObject1
        Me.PictureBox3.Location = New System.Drawing.Point(182, 386)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 50)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(180, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PRESS C TO CONTINUE"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(421, 41)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "YOUR  PLANET  IS  BEING  BLOCKED  BY  A  BUNCH  OF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVADING  POLYGONS!   IT  IS " & _
    " YOUR  MISSION  TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REMOVE  THESE  POLYGONS  WHILE  AVOIDING  THE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FALLING  MINE" & _
    "S!"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(270, 13)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(268, 14)
        Me.lblCopyright.TabIndex = 18
        Me.lblCopyright.Text = "COPYRIGHT  2015  LUKAS  ROMSICKI"
        Me.lblCopyright.UseCompatibleTextRendering = True
        '
        'helpWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(550, 509)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firingDevice)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "helpWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firingDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents firingDevice As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMoveFiringDevice As System.Windows.Forms.Timer
    Friend WithEvents tmrFire As System.Windows.Forms.Timer
    Friend WithEvents tmrGen As System.Windows.Forms.Timer
    Friend WithEvents tmrAvoid As System.Windows.Forms.Timer
    Friend WithEvents tmrGenTargets As System.Windows.Forms.Timer
    Friend WithEvents tmrInterchange As System.Windows.Forms.Timer
    Friend WithEvents imgListCharAni As System.Windows.Forms.ImageList
    Friend WithEvents tmrPrintCharLives As System.Windows.Forms.Timer
    Friend WithEvents tmrPrintGameOver As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label

End Class
