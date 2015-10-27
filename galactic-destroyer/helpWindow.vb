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

'the help window, initialize variables necessary for runtime
Public Class helpWindow
    Declare Auto Function CreateCaret Lib "user32" (hWnd As IntPtr, hBitmap As IntPtr, nWidth As Integer, nHeight As Integer) As Boolean
    Declare Auto Function ShowCaret Lib "user32" (hWnd As IntPtr) As Boolean

    Public currentHighScore As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        mainMenuWindow.Show()
    End Sub

    Private Sub closeWindow(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.C Then
            Me.Close()
            mainMenuWindow.txtSelectionBox.Text = ""
            mainMenuWindow.Show()
        End If
    End Sub

    Private Sub helpWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label2.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        Label3.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
        btnClose.Font = CustomFont.GetInstance(8.25, FontStyle.Bold)
        lblCopyright.Font = CustomFont.GetInstance(6.75, FontStyle.Bold)
    End Sub
End Class