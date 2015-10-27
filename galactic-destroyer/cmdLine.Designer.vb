<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmdLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cmdLine))
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
        Me.txtSelectionBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "] LOAD, RUN"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'txtSelectionBox
        '
        Me.txtSelectionBox.BackColor = System.Drawing.Color.Black
        Me.txtSelectionBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSelectionBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSelectionBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSelectionBox.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectionBox.ForeColor = System.Drawing.Color.White
        Me.txtSelectionBox.HideSelection = False
        Me.txtSelectionBox.Location = New System.Drawing.Point(43, 157)
        Me.txtSelectionBox.MaxLength = 4
        Me.txtSelectionBox.Name = "txtSelectionBox"
        Me.txtSelectionBox.Size = New System.Drawing.Size(100, 17)
        Me.txtSelectionBox.TabIndex = 1
        Me.txtSelectionBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "  LOADING GAME FROM RAM..."
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(511, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "  MAKE   SURE  THE  GAME  DISK  IS  INSERTED  AND  ENTER  ""1""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  OR,  IF  USING  " & _
    "A  MODERN  COMPUTER,  PRESS  ENTER"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "  WAITING  FOR  RESPONSE..."
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = ">"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(372, 59)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "  CANNOT  READ  FROM  DISK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  I/O  ERROR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ??????????????????????????????" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  R" & _
    "EAD  ERROR  SECTOR  1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  CHECK  DISK  AND  CONNECTIONS  AND  RESTART"
        Me.Label6.UseCompatibleTextRendering = True
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Print Char 21", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(43, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "LOADED  GAME  INTO  DEFAULT  RAM  LOCATION"
        Me.Label7.UseCompatibleTextRendering = True
        Me.Label7.Visible = False
        '
        'cmdLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(550, 509)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSelectionBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cmdLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnClose As System.Windows.Forms.Button
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
    Friend WithEvents txtSelectionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
