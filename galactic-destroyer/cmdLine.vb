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

'the command line emulator window, initialize variables necessary for runtime
Public Class cmdLine
    Declare Auto Function CreateCaret Lib "user32" (hWnd As IntPtr, hBitmap As IntPtr, nWidth As Integer, nHeight As Integer) As Boolean
    Declare Auto Function ShowCaret Lib "user32" (hWnd As IntPtr) As Boolean

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        mainMenuWindow.Show()
    End Sub
    Private Sub gameWindow_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        CreateCaret(txtSelectionBox.Handle, IntPtr.Zero, 10, txtSelectionBox.Height)                            'resize the caret in the text box
        ShowCaret(txtSelectionBox.Handle)                                                                       'show the caret in the text box
        txtSelectionBox.Text = ""                                                                               'clear the text box
        txtSelectionBox.Visible = True                                                                          'show the text boc
    End Sub

    Private Sub getFocus(sender As System.Object, e As System.EventArgs) Handles txtSelectionBox.GotFocus, btnClose.GotFocus, txtSelectionBox.LostFocus, Me.GotFocus, RectangleShape1.GotFocus, Me.Load
        CreateCaret(txtSelectionBox.Handle, IntPtr.Zero, 10, txtSelectionBox.Height)                            'same as above
        ShowCaret(txtSelectionBox.Handle)
        txtSelectionBox.Focus()                                                                                 'focus to the text box
        Me.ActiveControl = txtSelectionBox                                                                      'focus to the text box

        Label1.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label2.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label3.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label4.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label5.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label6.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label7.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        btnClose.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
    End Sub

    Private Async Sub respond(sender As Object, e As KeyEventArgs) Handles txtSelectionBox.KeyDown
        If e.KeyCode = Keys.Enter Then                                                                  'decide what to do in case of enter key press
            e.SuppressKeyPress = True
            e.Handled = True
            If txtSelectionBox.Text = "" Then
                Label7.Visible = True
                txtSelectionBox.Visible = False
                Await Task.Delay(2000)
                Me.Close()
                gameWindow.Show()
            ElseIf txtSelectionBox.Text = "1" Then
                My.Computer.Audio.Play(My.Resources.Powerup, AudioPlayMode.Background)
                Await displayError()
            Else
                Me.Close()
                mainMenuWindow.Show()
            End If
        End If
    End Sub

    Private Async Function displayError() As Task                                   'show a virtual error
        Label6.Visible = True
        txtSelectionBox.Visible = False
        Await Task.Delay(2000)

        Me.Close()
        mainMenuWindow.txtSelectionBox.Text = ""
        mainMenuWindow.Show()
    End Function

    Private Sub responsiveSleep(ByVal seconds As Integer)                           'responsively sleep
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class