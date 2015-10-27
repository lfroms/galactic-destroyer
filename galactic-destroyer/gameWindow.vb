'Title  :   Galactic Destroyer
'Author :   Lukas Romsicki
'Course :   ICS2O
'Date   :   Jun 9 2015
'License:   This code may be redistributed once, all code used in another project must be cited ~
'           with author's name and the date cited.

Imports System                              'import system libraries
Imports System.IO                           'import system input libraries
Imports System.Runtime.InteropServices      'import system runtime libraries
Imports System.Threading

'the main game window, initialize variables necessary for runtime
Public Class gameWindow
    Dim avoidObjects(-1) As avoid                   'defines array for "avoids" declared in seprarate class
    Dim intCountAvoids As Integer                   'defines counter for number of "avoids" in the array
    Dim numTargets As Integer = 10                  'sets the default number of targets to hit to 10
    Dim target(numTargets) As target                'defines array for targets, with (numTargets) memory locations
    Dim setAnimation As Boolean = False             'defines boolean for animating destroyed firingDevice
    Dim livesLostText(8) As String                  'defines array for lives lost animation text
    Dim gameOverText(8) As String                   'defines array for game over animation text
    Dim aniCounter As Integer = 0                   'defines counter for animations
    Dim lostMode As Boolean = False                 'sets which mode the window is running
    Dim lvlUpText(8) As String                      'defines array for level up animation text
    Dim congratulations(21) As String               'defines array for congratulations animation text

    Dim currentScore As Integer = 0                 'resets the current score to zero
    Dim currentLives As Integer = 3                 'sets the default number of lives to 3
    Dim currentLevel As Integer = 1                 'resets the current level to level 1
    Dim currentRemaining As Integer = numTargets    'sets the number of remaining targets to the default number of targets

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Int32) As Int16       'set the key sync state so that the firing device moves smoothly and quickly

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, Me.MouseDown, RectangleShape1.MouseDown, RectangleShape2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm()                                          'when window is moved, run MoveForm()
        End If
    End Sub

    Private Sub MoveForm()
        ReleaseCapture()                                        'move the form
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

#Region " Functions and Constants "
    <DllImport("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2
#End Region 'for windowmove

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()                                              ' close the form
        mainMenuWindow.Show()
        mainMenuWindow.txtSelectionBox.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveFiringDevice.Tick
        If GetAsyncKeyState(Keys.A) And firingDevice.Left > 20 Then             'detects key sync state and listens for A key
            firingDevice.Left -= 4                                              'moves firingDevice 4 pixels to the left
        ElseIf GetAsyncKeyState(Keys.D) And firingDevice.Right < 530 Then       'detects key sync state and listens for D key
            firingDevice.Left += 4                                              'moves firingDevice 4 pixels to the right
        End If
        If shot.Top > 40 Then                                                   'allows for fire to be called only if previous shot exits 40 pixels away from top of window
            fire()                                                              'fire a shot
        Else
            shot.Visible = False                                                'suspends the shot, allowing for a new one to be made
        End If

        checkCollision()                                                        'check for collisions with the targets infinitely
        checkAvoidCollision()                                                   'check for collisions with the "avoids" infinitely
        checkLevel()                                                            'check the current level infinitely
    End Sub

    Private Sub gameWindow_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode                                                           'on keyboard key press
            Case Keys.L And shot.Visible = False And lostMode = False                   'listen for L key and whether or not the shot is visible
                My.Computer.Audio.Play(My.Resources.Shoot, AudioPlayMode.Background)    'play fire sound effect
                shot.Top = firingDevice.Top                                             'sets initial location of the shot
                shot.Visible = True                                                     'display the shot
                shot.Left = firingDevice.Left + 28                                      'centers the shot in the centre of the firingDevice
        End Select
    End Sub

    Private Sub gameWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True                                                       'enable listening for keyboard button presses
        Randomize()                                                             'initialize the random number generator
        createTargets()                                                         'generate the initial targets
        shot.Visible = False                                                    'hide the shot, if not already hidden
        My.Computer.Audio.Play(My.Resources.Start, AudioPlayMode.Background)    'play the startup sound effect

        If mainMenuWindow.currentHighScore < 10 Then                                 'set the ranges in order to_
            lblHighScore.Text = "HIGHSCORE: 000" & mainMenuWindow.currentHighScore   'display zeroes appropriately
        ElseIf mainMenuWindow.currentHighScore < 100 >= 10 Then
            lblHighScore.Text = "HIGHSCORE: 00" & mainMenuWindow.currentHighScore
        ElseIf mainMenuWindow.currentHighScore >= 100 < 1000 Then
            lblHighScore.Text = "HIGHSCORE: 0" & mainMenuWindow.currentHighScore
        ElseIf mainMenuWindow.currentHighScore >= 1000 Then
            lblHighScore.Text = "HIGHSCORE: " & mainMenuWindow.currentHighScore
        End If

        initArrays()

        lblScoreBox.Font = CustomFont.GetInstance(11.25, FontStyle.Bold)        'load the needed fonts off a custom font module
        lblHighScore.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        lblLevel.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        lblLivesView.Font = CustomFont.GetInstance(6, FontStyle.Bold)
        lblLost.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
        lblPointsView.Font = CustomFont.GetInstance(6, FontStyle.Bold)
        btnClose.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
        msc.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
    End Sub

    Private Sub tmrGen_Tick(sender As Object, e As EventArgs) Handles tmrGen.Tick
        For x = 0 To avoidObjects.Length - 1            'on tick, loop from array 0 to ubound array minus 1
            avoidObjects(x).create()                    'create an "avoid" object
            If avoidObjects(x).Top > 460 Then           'when "avoids" are out of bounds,
                avoidObjects(x).Dispose()               'release the "avoid" from memory
            End If
        Next
    End Sub

    Private Sub tmrAvoid_Tick(sender As Object, e As EventArgs) Handles tmrAvoid.Tick
        ReDim Preserve avoidObjects(intCountAvoids)     'preserve existing objects and redim the "avoid" array
        Dim avoid1 As New avoid                         'create a new "avoid" under the external class
        Controls.Add(avoid1)                            'add the control to the form
        avoidObjects(intCountAvoids) = avoid1           'set the "avoid" to a memory location in the array
        intCountAvoids += 1                             'increase the "avoid" counter
        tmrGen.Enabled = True                           'enable the generation timer

        avoid1.Left = 500 * Rnd()                       'set the random "avoid" drop x-value
    End Sub

    Private Sub createTargets()                                                 'create targets
        For x = 1 To numTargets                                                 'loop from 1 to the total number of required targets
            target(x) = New target                                              'make a new target at the x array slot
            Controls.Add(target(x))                                             'add the control to the form

            target(x).Left = 40 + (460 * Rnd())                                 'set random x-position of the target
            target(x).Top = 140 + (200 * Rnd())                                 'set random y-position of the target

            If ((x Mod 2) = 0) Then                                             'on every second target, rotate 90 degrees
                target(x).Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                target(x).Size = New Size(28, 14)                               'resize to fit
            Else
                target(x).Size = New Size(14, 28)                               'resize to fit
            End If
        Next
    End Sub

    Private Sub fire()                                                  'fire the shot
        If shot.Visible = True Then                                     'if the shot is currently visible
            shot.Top -= 6                                               'animate the line moving upwards
        End If
        If shot.Top + shot.Height < Me.ClientRectangle.Top Then         'clear the shot if it reaches the upper bound of the screen
            shot.Visible = False
        End If
    End Sub

    Private Sub checkCollision()                                                                    'check for collisions of the shot and the target
        For x = 1 To numTargets
            If (shot.Top + shot.Height >= target(x).Top) And (shot.Top <= target(x).Top + target(x).Height) And (shot.Left + shot.Width >= target(x).Left) And (shot.Left <= target(x).Left + target(x).Width) And shot.Visible = True And target(x).Visible = True Then
                target(x).Visible = False                                                           'hide the target
                currentRemaining = currentRemaining - 1                                             'erase the number of required targets to hit
                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)                  'play a sound effect

                shot.Visible = False                                                                'hide the shot
                currentScore = currentScore + 10                                                    'increase the score by 10 points

                If currentScore < 100 Then                                                          'set the ranges in order to_
                    lblPointsView.Text = "Points: 00" & currentScore                                'display zeroes appropriately
                ElseIf currentScore >= 100 < 1000 Then
                    lblPointsView.Text = "Points: 0" & currentScore
                ElseIf currentScore >= 1000 Then
                    lblPointsView.Text = "Points: " & currentScore
                End If

                If currentRemaining <= 0 And currentLevel < 7 Then                                  'if there are no more targets remaining
                    currentRemaining = numTargets                                                   'reset the required number of targets to hit
                    My.Computer.Audio.Play(My.Resources.Next_Level, AudioPlayMode.Background)       'play a sound effect
                    levelUp()                                                                       'congratulate the user
                    currentLevel = currentLevel + 1                                                 'level up the user
                    firingDevice.Visible = True                                                     'recover the firingDevice
                ElseIf currentRemaining <= 0 And currentLevel = 7 Then
                    tmrGen.Enabled = False
                    tmrAvoid.Enabled = False
                    tmrPrintCongratulations.Enabled = True
                    lostMode = True
                    For i = 1 To numTargets                                 'remove devices/controls
                        Controls.Remove(target(i))
                    Next
                    For i = 0 To avoidObjects.Length - 1
                        avoidObjects(i).Dispose()
                    Next

                    responsiveSleep(4)                                      'wait for 4 seconds with a message on screen
                    aniCounter = 0

                    If currentScore > mainMenuWindow.currentHighScore Then  'quit the program and update the high score record globally
                        mainMenuWindow.currentHighScore = currentScore
                    End If
                    Me.Close()
                    mainMenuWindow.Show()
                    msc.Text = ""
                    mainMenuWindow.txtSelectionBox.Text = ""
                End If
            End If
        Next
    End Sub

    Private Sub checkAvoidCollision()                                                       'check for collisions with the "avoids"
        lblLivesView.Text = "Lives: " & currentLives                                        'display lives in the box
        For x = 0 To avoidObjects.Length - 1                                                'for the entire array
            If (firingDevice.Top + firingDevice.Height >= avoidObjects(x).Top) And (firingDevice.Top <= avoidObjects(x).Top + avoidObjects(x).Height) And (firingDevice.Left + firingDevice.Width >= avoidObjects(x).Left) And (firingDevice.Left <= avoidObjects(x).Left + avoidObjects(x).Width) And firingDevice.Visible = True And avoidObjects(x).Visible = True Then
                avoidObjects(x).Dispose()
                If currentLives < 1 Then                                                    'if user loses
                    My.Computer.Audio.Play(My.Resources.Ending, AudioPlayMode.Background)   'play a sound effect
                    resetDisplayAndMessage(False)                                           'reset the display
                    lblLivesView.Text = "Lives: " & currentLives                            'reset the lives label
                    currentLives = 3                                                        'reset the current number of available lives to 3
                Else
                    My.Computer.Audio.Play(My.Resources.Death, AudioPlayMode.Background)    'play a sound effect
                    tmrInterchange.Enabled = True
                    resetDisplayAndMessage(True)
                    firingDevice.Visible = True
                    currentLives = currentLives - 1                                         'decrease the number of available lives by 1
                    lblLivesView.Text = "Lives: " & currentLives                            'update the lives label
                End If
            End If
        Next
    End Sub

    Private Sub checkLevel()                    'check the which level we are currently on
        If currentLevel = 1 Then                'if on level 1
            tmrAvoid.Interval = 2500            'set interval of "avoids" to 2,500 milliseconds
            lblLevel.Text = "LEVEL: 1"          'set the level label text
        ElseIf currentLevel = 2 Then            'if on level 2
            tmrAvoid.Interval = 2000            'set interfal of "avoids" to 2,000 milliseconds
            lblLevel.Text = "LEVEL: 2"
        ElseIf currentLevel = 3 Then            'etc.
            tmrAvoid.Interval = 1500
            lblLevel.Text = "LEVEL: 3"
        ElseIf currentLevel = 4 Then
            tmrAvoid.Interval = 1000
            lblLevel.Text = "LEVEL: 4"
        ElseIf currentLevel = 5 Then
            tmrAvoid.Interval = 500
            lblLevel.Text = "LEVEL: 5"
        ElseIf currentLevel = 6 Then
            tmrAvoid.Interval = 400
            lblLevel.Text = "LEVEL: 6"
        ElseIf currentLevel = 7 Then
            tmrAvoid.Interval = 300
            lblLevel.Text = "LEVEL: 7"
        End If
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrInterchange.Tick
        If setAnimation = True Then                             'animate on boolean change
            firingDevice.Image = imgListCharAni.Images(0)       'animate the destroyed firingDevice
            setAnimation = False                                'reset the boolean
        Else
            firingDevice.Image = imgListCharAni.Images(1)
            setAnimation = True
        End If
    End Sub

    Private Sub resetDisplayAndMessage(ByVal sender As Boolean)
        If sender = True Then                                       'if this is a case of life lost
            tmrInterchange.Enabled = True                           'reset the layout of the screen for the following devices
            tmrGen.Enabled = False
            tmrAvoid.Enabled = False
            tmrPrintCharLives.Enabled = True
            lostMode = True
            For x = 1 To numTargets                                 'remove the targets from the screen
                Controls.Remove(target(x))                          'remove the controls
            Next
            For x = 0 To avoidObjects.Length - 1                    'remove the "avoids" from the screen
                avoidObjects(x).Dispose()                           'dispose from memory
            Next
            responsiveSleep(4)                                      'responsively wait for 4 seconds with a message
            tmrInterchange.Enabled = False                          'reenable all devices
            firingDevice.Image = My.Resources.FiringDevice
            aniCounter = 0                                          'reset the animation counter
            lblLost.Text = ""                                       'reset the centre screen label
            lostMode = False
            currentRemaining = numTargets                           'reset the number of targets

            createTargets()                                         'regenerate the targets
            tmrGen.Enabled = True                                   'reenable all timers
            tmrAvoid.Enabled = True
        ElseIf sender = False Then                                  'if this is a case of GAME lost
            tmrInterchange.Enabled = True                           'reset the layout of the screen for the following device
            tmrGen.Enabled = False
            tmrAvoid.Enabled = False
            tmrPrintGameOver.Enabled = True
            lostMode = True
            For x = 1 To numTargets                                 'remove devices/controls
                Controls.Remove(target(x))
            Next
            For x = 0 To avoidObjects.Length - 1
                avoidObjects(x).Dispose()
            Next

            responsiveSleep(4)                                      'wait for 4 seconds with a message on screen
            aniCounter = 0

            If currentScore > mainMenuWindow.currentHighScore Then  'quit the program and update the high score record globally
                mainMenuWindow.currentHighScore = currentScore
            End If
            Me.Close()
            mainMenuWindow.Show()
            mainMenuWindow.txtSelectionBox.Text = ""
        Else

        End If
    End Sub

    Private Sub tmrPrintCharLives_Tick(sender As Object, e As EventArgs) Handles tmrPrintCharLives.Tick
        lblLost.Text = lblLost.Text + livesLostText(aniCounter)             'animate typewriter-style text appearance
        aniCounter = aniCounter + 1                                         'update the animation counter
        If aniCounter > 8 Then                                              'cancel once completed writing text
            tmrPrintCharLives.Enabled = False
        End If
    End Sub

    Private Sub responsiveSleep(ByVal seconds As Integer)                   'sleep without freezing the program
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub tmrPrintGameOver_Tick(sender As Object, e As EventArgs) Handles tmrPrintGameOver.Tick
        lblLost.Text = lblLost.Text + gameOverText(aniCounter)              'animate typewriter-style text appearance
        aniCounter = aniCounter + 1                                         'update the animation counter
        If aniCounter > 8 Then                                              'cancel once completed writing text
            tmrPrintGameOver.Enabled = False
        End If
    End Sub

    Private Sub levelUp()                                                   'perform the necessary functions for levelling up
        tmrGen.Enabled = False                                              'these are the same as for losing a life/game, but_
        tmrAvoid.Enabled = False                                            'also display different level up text
        tmrPrintLevelUp.Enabled = True                                      'print level up text
        lostMode = True
        For x = 1 To numTargets                                             'clear the screen
            target(x).Dispose()
        Next
        For x = 0 To avoidObjects.Length - 1
            avoidObjects(x).Dispose()
        Next
        aniCounter = 0
        responsiveSleep(4)                                                  'responsively sleep for 4 seconds
        lblLost.Text = ""
        lostMode = False
        currentRemaining = numTargets

        createTargets()                                                     'recreate the targets
        tmrGen.Enabled = True
        tmrAvoid.Enabled = True
    End Sub

    Private Sub tmrPrintLevelUp_Tick(sender As Object, e As EventArgs) Handles tmrPrintLevelUp.Tick
        lblLost.Text = lblLost.Text + lvlUpText(aniCounter)                 'animate typewriter-style text appearance
        aniCounter = aniCounter + 1                                         'update the animation counter
        If aniCounter > 8 Then                                              'cancel once completed writing text
            tmrPrintLevelUp.Enabled = False
            aniCounter = 0
        End If
    End Sub

    Private Sub initArrays()                        'initialize the text message arrays
        livesLostText(0) = "L"
        livesLostText(1) = "I"
        livesLostText(2) = "V"
        livesLostText(3) = "E"
        livesLostText(4) = "S"
        livesLostText(5) = " "
        livesLostText(6) = "-"
        livesLostText(7) = " "
        livesLostText(8) = "1"

        gameOverText(0) = "G"
        gameOverText(1) = "A"
        gameOverText(2) = "M"
        gameOverText(3) = "E"
        gameOverText(4) = " "
        gameOverText(5) = "O"
        gameOverText(6) = "V"
        gameOverText(7) = "E"
        gameOverText(8) = "R"

        lvlUpText(0) = "L"
        lvlUpText(1) = "E"
        lvlUpText(2) = "V"
        lvlUpText(3) = "E"
        lvlUpText(4) = "L"
        lvlUpText(5) = " "
        lvlUpText(6) = "U"
        lvlUpText(7) = "P"
        lvlUpText(8) = "!"

        congratulations(0) = "M"
        congratulations(1) = "I"
        congratulations(2) = "S"
        congratulations(3) = "S"
        congratulations(4) = "I"
        congratulations(5) = "O"
        congratulations(6) = "N"
        congratulations(7) = " "
        congratulations(8) = " "
        congratulations(9) = "A"
        congratulations(10) = "C"
        congratulations(11) = "C"
        congratulations(12) = "O"
        congratulations(13) = "M"
        congratulations(14) = "P"
        congratulations(15) = "L"
        congratulations(16) = "I"
        congratulations(17) = "S"
        congratulations(18) = "H"
        congratulations(19) = "E"
        congratulations(20) = "D"
        congratulations(21) = "!"
    End Sub

    Private Sub tmrPrintCongratulations_Tick(sender As Object, e As EventArgs) Handles tmrPrintCongratulations.Tick
        msc.Text = msc.Text + congratulations(aniCounter)           'animate typewriter-style text appearance
        aniCounter = aniCounter + 1                                         'update the animation counter
        If aniCounter > 21 Then                                             'cancel once completed writing text
            tmrPrintCongratulations.Enabled = False
            aniCounter = 0
        End If
    End Sub
End Class