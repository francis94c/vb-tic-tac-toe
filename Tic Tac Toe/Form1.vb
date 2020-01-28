Public Class Form1
    Private gameIsGoingOn As Boolean = False
    Private whoseTurn As Byte = 0
    Private AnimateIndicator As Boolean = True
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(0)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then ' 1p Vs 2p
            If whoseTurn = 1 Then
                P1Play(0)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(0)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        ElseIf GameType = 2 Then ' Championship

        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppStartDirec = Application.StartupPath
        Randomize()
        Disable()
        infoLabel.Text = ""
        Player1.Name = "Player1"
        Player2.Name = "Player2"
    End Sub
    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        Dim newGameForm As New newGameConfigForm
        newGameForm.ShowDialog()
        If hasVisitedNewGame = True Then
            Reset()
            Enable()
            hasVisitedNewGame = False
        Else
            If gameIsGoingOn = False Then
                GameLevel = 0
                GameType = 0
                Player1.piece = 0
            End If
        End If
        If Player1.piece = 1 Then
            If GameType = 0 Then
                If GameLevel = 2 Then
                    COMPlayHard(1)
                    turn += 1
                ElseIf GameLevel = 1 Then
                    COMPlayNormal(1)
                    turn += 1
                ElseIf GameLevel = 0 Then
                    COMPlayEasy(1)
                    turn += 1
                End If
            End If
        End If
        If GameType = 1 Then
            If Player1.piece = 0 Then
                infoLabel.Text = "Player 1 Goes First"
                whoseTurn = 1
            ElseIf Player2.piece = 0 Then
                infoLabel.Text = "Player 2 Goes First"
                whoseTurn = 2
            End If
        End If
        If GameType >= 2 Then

        End If
    End Sub
    Private Sub Enable()
        If someoneWon = False Then
            Dim ctrl As Control
            For Each ctrl In Controls
                If ctrl.Tag = "Picture" Then
                    ctrl.Enabled = True
                End If
            Next
        End If
    End Sub
    Public Sub Disable()
        Dim ctrl As Control
        For Each ctrl In Controls
            If ctrl.Tag = "Picture" Then
                ctrl.Enabled = False
            End If
        Next
    End Sub
    Public Sub Reset()
        Dim ctrl As Control
        For Each ctrl In Controls
            If ctrl.Tag = "p" Then
                ctrl.Tag = "Picture"
            End If
        Next
        a1.Image = Nothing
        a2.Image = Nothing
        a3.Image = Nothing
        a4.Image = Nothing
        a5.Image = Nothing
        a6.Image = Nothing
        a7.Image = Nothing
        a8.Image = Nothing
        a9.Image = Nothing
        turn = 1
        COMhasplayed = False
        For i As Integer = 0 To 8
            Board(i) = 0
        Next i
        someoneWon = False
        COMhasplayed = False
        infoLabel.Text = ""
        AnimateIndicator = True
        WinninPieceImage = Nothing
        animateTimer.Enabled = False
    End Sub

    Private Sub a2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(1)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(1)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(1)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub

    Private Sub a5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a5.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(4)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(4)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(4)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub
    Private Sub a3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(2)

            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(2)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(2)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub

    Private Sub a6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a6.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(5)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(5)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(5)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub

    Private Sub a4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a4.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(3)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(3)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(3)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub

    Private Sub a9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a9.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(8)

            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(8)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(8)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub

    Private Sub a7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a7.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(6)

            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(6)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(6)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub
    Private Sub a8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a8.Click
        gameIsGoingOn = True
        ' 1p vs com
        If GameType = 0 Then ' 1p vs com
            P1Play(7)
            CheckWin()
            ' coms turn
            If GameLevel = 2 Then ' hard
                COMPlayHard(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 1 Then
                COMPlayNormal(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            ElseIf GameLevel = 0 Then
                COMPlayEasy(turn)
                turn += 1
                Enable()
                COMhasplayed = False
            End If
            ' 1p vs 2p
        ElseIf GameType = 1 Then
            If whoseTurn = 1 Then
                P1Play(7)
                Enable()
                whoseTurn = 2
                CheckWin()
                FeedDetails()
                CheckDraw()
            ElseIf whoseTurn = 2 Then
                P2Play(7)
                Enable()
                whoseTurn = 1
                CheckWin()
                FeedDetails()
                CheckDraw()
            End If
        End If
    End Sub
    Private Sub FeedDetails()
        If someoneWon = False Then
            If whoseTurn = 1 Then
                infoLabel.Text = "Player1's Turn"
                turn += 1
            ElseIf whoseTurn = 2 Then
                infoLabel.Text = "Player2's Turn"
                turn += 1
            End If
        End If
    End Sub
    Private Sub CheckDraw()
        If someoneWon = False Then
            If turn >= 10 Then
                infoLabel.Text = "Draw!"
            End If
        End If
    End Sub
    Private Sub animateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animateTimer.Tick
        If WinningType = 1 Then
            Animate(a1, a2, a3)
        ElseIf WinningType = 2 Then
            Animate(a4, a5, a6)
        ElseIf WinningType = 3 Then
            Animate(a7, a8, a9)
        ElseIf WinningType = 4 Then
            Animate(a1, a4, a7)
        ElseIf WinningType = 5 Then
            Animate(a2, a5, a8)
        ElseIf WinningType = 6 Then
            Animate(a3, a6, a9)
        ElseIf WinningType = 7 Then
            Animate(a1, a5, a9)
        ElseIf WinningType = 8 Then
            Animate(a3, a5, a7)
        End If
    End Sub
    Private Sub Animate(ByRef FirstPlace As Object, ByRef SecondPlace As Object, ByRef ThirdPlace As Object)
        If AnimateIndicator = True Then
            FirstPlace.Image = Nothing
            SecondPlace.Image = Nothing
            ThirdPlace.Image = Nothing
            AnimateIndicator = False
        ElseIf AnimateIndicator = False Then
            FirstPlace.Image = WinninPieceImage
            SecondPlace.Image = WinninPieceImage
            ThirdPlace.Image = WinninPieceImage
            AnimateIndicator = True
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim FormLineBorder As System.Drawing.Graphics
        Dim Pen As New System.Drawing.Pen(System.Drawing.Color.Black)
        FormLineBorder = Me.CreateGraphics
        FormLineBorder.DrawLine(Pen, 200, 0, 200, 267)
        FormLineBorder.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = Fixture
    End Sub
End Class
