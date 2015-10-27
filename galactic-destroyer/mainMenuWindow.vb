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

'the main menu window, initialize variables necessary for runtime
Public Class mainMenuWindow
    Dim alreadyLoaded As Boolean = False
    Declare Auto Function CreateCaret Lib "user32" (hWnd As IntPtr, hBitmap As IntPtr, nWidth As Integer, nHeight As Integer) As Boolean
    Declare Auto Function ShowCaret Lib "user32" (hWnd As IntPtr) As Boolean

    Public currentHighScore As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub gameWindow_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        CreateCaret(txtSelectionBox.Handle, IntPtr.Zero, 10, txtSelectionBox.Height)
        ShowCaret(txtSelectionBox.Handle)

        If currentHighScore < 10 Then                                 'set the ranges in order to_
            lblHighScore.Text = "HIGHSCORE: 000" & currentHighScore   'display zeroes appropriately
        ElseIf currentHighScore < 100 >= 10 Then
            lblHighScore.Text = "HIGHSCORE: 00" & currentHighScore
        ElseIf currentHighScore >= 100 < 1000 Then
            lblHighScore.Text = "HIGHSCORE: 0" & currentHighScore
        ElseIf currentHighScore >= 1000 Then
            lblHighScore.Text = "HIGHSCORE: " & currentHighScore
        End If

        txtSelectionBox.Text = ""
    End Sub

    Private Sub getFocus(sender As System.Object, e As System.EventArgs) Handles txtSelectionBox.GotFocus, btnClose.GotFocus, txtSelectionBox.LostFocus, Me.GotFocus, RectangleShape1.GotFocus, firingDevice.GotFocus, Me.Load
        CreateCaret(txtSelectionBox.Handle, IntPtr.Zero, 10, txtSelectionBox.Height)
        ShowCaret(txtSelectionBox.Handle)
        txtSelectionBox.Focus()
        Me.ActiveControl = txtSelectionBox                            'set the active control to always be the selection box

        If currentHighScore < 10 Then                                 'set the ranges in order to_
            lblHighScore.Text = "HIGHSCORE: 000" & currentHighScore   'display zeroes appropriately
        ElseIf currentHighScore < 100 >= 10 Then
            lblHighScore.Text = "HIGHSCORE: 00" & currentHighScore
        ElseIf currentHighScore >= 100 < 1000 Then
            lblHighScore.Text = "HIGHSCORE: 0" & currentHighScore
        ElseIf currentHighScore >= 1000 Then
            lblHighScore.Text = "HIGHSCORE: " & currentHighScore
        End If

        Label1.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label2.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label3.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label4.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
        Label5.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        lblHighScore.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        btnClose.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
        lblCopyright.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
    End Sub

    Private Async Sub respond(sender As Object, e As KeyEventArgs) Handles txtSelectionBox.KeyDown      'decide what to do in case of enter key press
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtSelectionBox.Text = "1" And alreadyLoaded = True Then
                Me.Hide()
                gameWindow.Show()
            ElseIf txtSelectionBox.Text = "1" And alreadyLoaded = False Then
                Me.Hide()
                alreadyLoaded = True
                cmdLine.Show()
            ElseIf txtSelectionBox.Text = "2" Then
                Me.Hide()
                helpWindow.Show()
            ElseIf txtSelectionBox.Text = "3" Then
                End
            Else
                Label5.Visible = True
                My.Computer.Audio.Play(My.Resources.Powerup, AudioPlayMode.Background)              'play a sound effect
                Await Task.Delay(2000)
                Label5.Visible = False
            End If
        End If
    End Sub
End Class