Imports System.String
Module Identifiers_and_procedures
    Structure Players
        Dim Name As String
        Dim Points As Integer
        Dim Piece As Byte
    End Structure
    Structure Opponent
        Dim Name As String
        Dim Piece As Byte
        Dim Points As Integer
        Dim Xp As Byte
    End Structure
    Structure Move
        Dim COMPlace As Byte
        Dim P1Place As Byte
    End Structure
    Public Player1 As Players
    Public Player2 As Players
    Public Opp As Opponent
    Public GameType As Byte = 0 ' 0 means (1p vs com) 1 means (1p vs 2p) 2 means championship 3 means knockout 4 means cup 5 means selection 
    Public turn As Byte = 1 ' how many cells have benn filled so far    
    Public Board(8) As Byte ' 1 means 1p, 2 means 2p or com, 0 means nothing has been played on the cell
    Public GameLevel As Byte = 0 ' Difficulty: 0-easy 1-normal 2-hard
    Public COMhasplayed As Boolean = False
    Public HasVisitedNewGame As Boolean = False
    Private WhereToPlay As Short
    Private What2do As Byte
    Public SomeoneWon As Boolean
    Private PrevMove As Move
    Public WinningPieces(2) As Byte
    Public WinninPieceImage As Image = Nothing
    Public WinningType As Byte
    Public AppStartDirec As String = ""
    Public InputRequest As Byte
    Public OpponentList As String
    Public Const NL As String = ControlChars.NewLine
    Public Fixture As String = ""
    Public OppLimit As Byte = 0
    Private Final As String = ""
    Private Sub InitializeSet()
        Player1.Piece = 0
    End Sub
    Public Sub COMPlayHard(ByVal stage As Byte) ' Procedure to run if 1p plays first
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If stage = 1 Then
                    Dim x As Byte = Rnd() * 10
                    If x <= 5 Then
                        COMPlay(4)
                    End If
                    If COMhasplayed = False Then
                        WhereToPlay = Rnd() * 10
                        Select Case WhereToPlay
                            Case Is < 5
                                If WhereToPlay < 3 Then
                                    COMPlay(6)
                                Else
                                    COMPlay(0)
                                End If
                            Case Is >= 5
                                If WhereToPlay > 7 Then
                                    COMPlay(8)
                                Else
                                    COMPlay(2)
                                End If
                        End Select
                        RandomPlay(1)
                    End If
                End If
                If stage = 2 Then
                    If Board(4) = 2 Then
                        Defend(1)
                        If COMhasplayed = False Then
                            Defend(2)
                        End If
                        If COMhasplayed = False Then
                            AttackHard(2, 1)
                        End If
                    Else
                        Defend(1)
                        If COMhasplayed = False Then
                            AttackHard(2, 2)
                        End If
                        If COMhasplayed = False Then
                            Defend(2)
                        End If
                    End If
                    CheckWin()
                End If
                If stage = 3 Then
                    CheckIfCOMCanWin()
                    Defend(1)
                    Defend(2)
                    AttackHard(3, 1)
                    RandomPlay(2)
                    CheckWin()
                End If
                If stage = 4 Then
                    CheckIfCOMCanWin()
                    Defend(1)
                    Defend(2)
                    RandomPlay(2)
                    CheckWin()
                    If Player1.Piece = 1 Then
                        If SomeoneWon = False Then
                            Form1.infoLabel.Text = "Draw!"
                        End If
                    End If
                End If
                If stage = 5 Then
                    CheckIfCOMCanWin()
                    Defend(1)
                    Defend(2)
                    RandomPlay(2)
                    CheckWin()
                    If SomeoneWon = False Then
                        Form1.infoLabel.Text = "Draw!"
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub COMPlayNormal(ByVal stage As Byte)
        If stage = 1 Then
            NormRandPlay()
            RandomPlay(1)
            CheckWin()
        End If
        If stage = 2 Then
            Defend(1)
            Defend(2)
            AttackHard(2, 1)
            RandomPlay(1)
            NormRandPlay()
            CheckWin()
        End If
        If stage = 3 Then
            Dim s As Byte
            s = Rnd() * 10
            If s >= 5 Then
                CheckIfCOMCanWin()
                RandomPlay(1)
                NormRandPlay()
                CheckWin()
            Else
                Defend(1)
                Defend(2)
                AttackHard(3, 1)
                AttackHard(3, 2)
                RandomPlay(1)
                NormRandPlay()
                CheckWin()
            End If
        End If
        If stage = 4 Then
            Dim k As Byte
            k = Rnd() * 10
            If k <= 5 Then
                Defend(1)
                Defend(2)
                RandomPlay(1)
                RandomPlay(2)
                NormRandPlay()
                CheckWin()
                If Player1.Piece = 1 Then
                    If SomeoneWon = False Then
                        Form1.infoLabel.Text = "Draw!"
                    End If
                End If
            Else
                RandomPlay(1)
                RandomPlay(2)
                NormRandPlay()
                CheckWin()
                If Player1.Piece = 1 Then
                    If SomeoneWon = False Then
                        Form1.infoLabel.Text = "Draw!"
                    End If
                End If
            End If
        End If
        If stage = 5 Then
            CheckIfCOMCanWin()
            Defend(1)
            Defend(2)
            RandomPlay(2)
            RandomPlay(1)
            NormRandPlay()
            CheckWin()
            If SomeoneWon = False Then
                Form1.infoLabel.Text = "Draw!"
            End If
        End If
    End Sub
    Public Sub COMPlayEasy(ByVal stage As Byte)
        If stage = 1 Then
            NormRandPlay()
            RandomPlay(1)
        End If
        If stage = 2 Then
            Dim x As Byte
            x = Rnd() * 10
            If x <= 4 Then
                Defend(1)
                Defend(2)
                RandomPlay(1)
                NormRandPlay()
                CheckWin()
            Else
                EasyAttack()
                RandomPlay(1)
                NormRandPlay()
                CheckWin()
            End If
        End If
        If stage = 3 Then
            CheckIfCOMCanWin()
            Defend(1)
            Defend(2)
            EasyAttack()
            RandomPlay(1)
            NormRandPlay()
            CheckWin()
        End If
        If stage = 4 Then
            RandomPlay(1)
            RandomPlay(2)
            NormRandPlay()
            CheckWin()
            If Player1.Piece = 1 Then
                If SomeoneWon = False Then
                    Form1.infoLabel.Text = "Draw!"
                End If
            End If
        End If
        If stage = 5 Then
            CheckIfCOMCanWin()
            Defend(1)
            Defend(2)
            RandomPlay(1)
            NormRandPlay()
            CheckWin()
            If SomeoneWon = False Then
                Form1.infoLabel.Text = "Draw!"
            End If
        End If
    End Sub
    Private Sub Defend(ByVal type As Integer)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If type = 1 Then
                    DefendWhen(1, 5, 7)
                    DefendWhen(1, 2, 0)
                    DefendWhen(8, 4, 0)
                    DefendWhen(0, 8, 4)
                    DefendWhen(0, 8, 4)
                    DefendWhen(3, 4, 5)
                    DefendWhen(4, 5, 3)
                    DefendWhen(6, 8, 7)
                    DefendWhen(7, 6, 8)
                    DefendWhen(7, 8, 6)
                    DefendWhen(0, 1, 2)
                    DefendWhen(0, 2, 1)
                    DefendWhen(6, 2, 4)
                    DefendWhen(1, 4, 7)
                    DefendWhen(1, 7, 4)
                    DefendWhen(4, 7, 1)
                    DefendWhen(0, 3, 6)
                    DefendWhen(6, 3, 0)
                    DefendWhen(0, 6, 3)
                    DefendWhen(2, 8, 5)
                    DefendWhen(2, 5, 8)
                    DefendWhen(5, 8, 2)
                    DefendWhen(0, 4, 8)
                    DefendWhen(2, 4, 6)
                    DefendWhen(6, 4, 2)
                    DefendWhen(3, 5, 4)
                End If
                If type = 2 Then
                    If Board(0) = 1 And Board(8) = 1 Then
                        Dim x As Byte = Rnd() * 10
                        If x <= 5 Then
                            DefendWhen(0, 8, 6)
                        Else
                            DefendWhen(0, 8, 2)
                        End If
                    End If
                    DefendWhen(2, 6, 8)
                    DefendWhen(2, 6, 0)
                    COMPlay(4)
                    If Board(0) = 1 Then
                        COMPlay(2)
                        COMPlay(6)
                    End If
                    COMPlay(2)
                    COMPlay(6)
                    If Board(6) = 1 Then
                        COMPlay(0)
                        COMPlay(8)
                    End If
                    If Board(8) = 1 Then
                        COMPlay(2)
                        COMPlay(6)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub AttackHard(ByVal stage As Byte, ByVal attType As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If stage = 2 And attType = 1 Then ' atttype bieng 1 means com played center so continue with plan
                    If COMhasplayed = False Then
                        WhereToPlay = Rnd() * 10
                        If COMhasplayed = False Then
                            If WhereToPlay <= 2 Then
                                COMPlay(0) ' if 1p hasn't filled the cell
                            End If
                        End If
                        If COMhasplayed = False Then
                            If WhereToPlay > 2 And WhereToPlay <= 4 Then
                                COMPlay(2)
                            End If
                        End If
                        If COMhasplayed = False Then
                            If WhereToPlay > 4 And WhereToPlay <= 6 Then
                                COMPlay(6)
                            End If
                        End If
                        If COMhasplayed = False Then
                            If WhereToPlay > 6 And WhereToPlay <= 8 Then
                                COMPlay(8)
                            End If
                        End If
                        If COMhasplayed = False Then
                            If WhereToPlay > 8 Then
                                COMPlay(0)
                            End If
                        End If
                    End If
                End If
                If stage = 2 And attType = 2 Then
                    If COMhasplayed = False Then
                        If Board(0) = 0 And Board(2) = 0 Then
                            Dim decision As Byte = Rnd() * 10
                            If decision <= 5 Then
                                COMPlay(0)
                            End If
                        Else
                            COMPlay(0)
                            COMPlay(2)
                        End If
                    End If
                End If
                If stage = 3 And attType = 1 Then
                    If COMhasplayed = False Then
                        COMAttackBasedOn3EmptySpaces(2, 4, 6, 5, 0, 8)
                        COMAttackBasedOn3EmptySpaces(0, 4, 1, 8, 6, 2)
                        COMAttackBasedOn3EmptySpaces(0, 4, 8, 3, 2, 6)
                        COMAttackBasedOn3EmptySpaces(2, 4, 6, 1, 8, 0)
                        COMAttackBasedOn3EmptySpaces(2, 4, 6, 8, 3, 5)
                        COMAttackBasedOn3EmptySpaces(6, 4, 3, 2, 8, 0)
                        COMAttackBasedOn3EmptySpaces(6, 4, 7, 2, 0, 8)
                        COMAttackBasedOn3EmptySpaces(0, 4, 5, 8, 6, 3)
                        COMAttackBasedOn3EmptySpaces(8, 4, 7, 2, 0, 6)
                        COMAttackBasedOn3EmptySpaces(8, 4, 6, 0, 2, 7)
                        COMAttackBasedOn3EmptySpaces(8, 4, 3, 0, 2, 5)
                        COMAttackBasedOn2EmptySpaces(2, 4, 6, 0, 8)
                        COMAttackBasedOn2EmptySpaces(0, 4, 1, 6, 2)
                        COMAttackBasedOn2EmptySpaces(0, 4, 8, 2, 6)
                        COMAttackBasedOn2EmptySpaces(2, 4, 6, 8, 0)
                        COMAttackBasedOn2EmptySpaces(2, 4, 6, 3, 5)
                        COMAttackBasedOn2EmptySpaces(6, 4, 3, 8, 0)
                        COMAttackBasedOn2EmptySpaces(6, 4, 7, 0, 8)
                        COMAttackBasedOn2EmptySpaces(0, 4, 5, 6, 3)
                        COMAttackBasedOn2EmptySpaces(8, 4, 7, 0, 6)
                        COMAttackBasedOn2EmptySpaces(8, 4, 6, 2, 7)
                        COMAttackBasedOn2EmptySpaces(8, 4, 3, 2, 5)
                        COMAttackBasedOn2EmptySpaces(2, 4, 5, 0, 8)
                        COMAttackBasedOn2EmptySpaces(0, 4, 8, 6, 2)
                        COMAttackBasedOn2EmptySpaces(0, 4, 3, 2, 6)
                        COMAttackBasedOn2EmptySpaces(2, 4, 1, 8, 0)
                        COMAttackBasedOn2EmptySpaces(2, 4, 8, 3, 5)
                        COMAttackBasedOn2EmptySpaces(6, 4, 2, 8, 0)
                        COMAttackBasedOn2EmptySpaces(6, 4, 2, 0, 8)
                        COMAttackBasedOn2EmptySpaces(0, 4, 8, 6, 3)
                        COMAttackBasedOn2EmptySpaces(8, 4, 2, 0, 6)
                        COMAttackBasedOn2EmptySpaces(8, 4, 0, 2, 7)
                        COMAttackBasedOn2EmptySpaces(8, 4, 0, 2, 5)
                        COMAttackBasedOn2EmptySpaces(2, 4, 6, 5, 3)
                        COMAttackBasedOn2EmptySpaces(2, 4, 6, 5, 8)
                        COMAttackBasedOn2EmptySpaces(0, 4, 1, 8, 2)
                        COMAttackBasedOn2EmptySpaces(0, 4, 3, 6, 5)
                        COMAttackBasedOn2EmptySpaces(0, 4, 8, 3, 6)
                        COMAttackBasedOn2EmptySpaces(0, 4, 1, 8, 7)
                        COMAttackBasedOn2EmptySpaces(2, 4, 1, 6, 7)
                        COMAttackBasedOn2EmptySpaces(2, 4, 1, 6, 0)
                        COMAttackBasedOn2EmptySpaces(2, 4, 8, 6, 5)
                        COMAttackBasedOn2EmptySpaces(6, 4, 7, 2, 1)
                        COMAttackBasedOn2EmptySpaces(6, 4, 3, 2, 0)
                        COMAttackBasedOn2EmptySpaces(6, 4, 7, 2, 8)
                        COMAttackBasedOn2EmptySpaces(6, 4, 7, 2, 1)
                        COMAttackBasedOn2EmptySpaces(6, 4, 8, 2, 7)
                        COMAttackBasedOn2EmptySpaces(0, 4, 5, 8, 3)
                        COMAttackBasedOn2EmptySpaces(8, 4, 6, 0, 2)
                        COMAttackBasedOn2EmptySpaces(8, 4, 7, 2, 6)
                        COMAttackBasedOn2EmptySpaces(8, 4, 6, 0, 7)
                        COMAttackBasedOn2EmptySpaces(8, 4, 3, 0, 5)
                        COMAttackBasedOn2EmptySpaces(8, 4, 5, 0, 3)
                        Form2Ways(2, 4, 3)
                        Form2Ways(2, 4, 8)
                        Form2Ways(0, 4, 5)
                        Form2Ways(0, 4, 2)
                        Form2Ways(0, 4, 6)
                        Form2Ways(0, 4, 7)
                        Form2Ways(2, 4, 7)
                        Form2Ways(2, 4, 0)
                        Form2Ways(2, 4, 5)
                        Form2Ways(6, 4, 1)
                        Form2Ways(6, 4, 0)
                        Form2Ways(6, 4, 8)
                        Form2Ways(6, 4, 7)
                        Form2Ways(0, 4, 1)
                        Form2Ways(0, 4, 3)
                        Form2Ways(8, 4, 6)
                        Form2Ways(8, 4, 7)
                        Form2Ways(8, 4, 5)
                        Form2Ways(8, 4, 3)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub COMDisable(ByVal box As Byte)
        If box = 0 Then
            Form1.a1.Tag = "p"
            Form1.a1.Enabled = False
        End If
        If box = 1 Then
            Form1.a2.Tag = "p"
            Form1.a2.Enabled = False
        End If
        If box = 2 Then
            Form1.a3.Tag = "p"
            Form1.a3.Enabled = False
        End If
        If box = 3 Then
            Form1.a4.Tag = "p"
            Form1.a4.Enabled = False
        End If
        If box = 4 Then
            Form1.a5.Tag = "p"
            Form1.a5.Enabled = False
        End If
        If box = 5 Then
            Form1.a6.Tag = "p"
            Form1.a6.Enabled = False
        End If
        If box = 6 Then
            Form1.a7.Tag = "p"
            Form1.a7.Enabled = False
        End If
        If box = 7 Then
            Form1.a8.Tag = "p"
            Form1.a8.Enabled = False
        End If
        If box = 8 Then
            Form1.a9.Tag = "p"
            Form1.a9.Enabled = False
        End If
    End Sub
    Private Sub CheckIfCOMCanWin()
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                TryToWin(1, 4, 7)
                TryToWin(1, 7, 4)
                TryToWin(7, 4, 1)
                TryToWin(1, 2, 0)
                TryToWin(1, 0, 2)
                TryToWin(2, 0, 1)
                TryToWin(8, 4, 0)
                TryToWin(0, 8, 4)
                TryToWin(4, 0, 8)
                TryToWin(3, 4, 5)
                TryToWin(4, 5, 3)
                TryToWin(6, 8, 7)
                TryToWin(7, 6, 8)
                TryToWin(7, 8, 6)
                TryToWin(0, 1, 2)
                TryToWin(0, 2, 1)
                TryToWin(6, 2, 4)
                TryToWin(1, 4, 7)
                TryToWin(1, 7, 4)
                TryToWin(4, 7, 1)
                TryToWin(0, 3, 6)
                TryToWin(6, 3, 0)
                TryToWin(0, 6, 3)
                TryToWin(2, 8, 5)
                TryToWin(2, 5, 8)
                TryToWin(5, 8, 2)
                TryToWin(0, 4, 8)
                TryToWin(2, 4, 6)
                TryToWin(6, 4, 2)
                TryToWin(3, 5, 4)
            End If
        End If
    End Sub
    Private Sub COMPlay(ByVal position As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(position) = 0 Then
                    If Player1.Piece = 0 Then
                        If position = 0 Then
                            Form1.a1.Image = Form1.blue.Image
                        ElseIf position = 1 Then
                            Form1.a2.Image = Form1.blue.Image
                        ElseIf position = 2 Then
                            Form1.a3.Image = Form1.blue.Image
                        ElseIf position = 3 Then
                            Form1.a4.Image = Form1.blue.Image
                        ElseIf position = 4 Then
                            Form1.a5.Image = Form1.blue.Image
                        ElseIf position = 5 Then
                            Form1.a6.Image = Form1.blue.Image
                        ElseIf position = 6 Then
                            Form1.a7.Image = Form1.blue.Image
                        ElseIf position = 7 Then
                            Form1.a8.Image = Form1.blue.Image
                        ElseIf position = 8 Then
                            Form1.a9.Image = Form1.blue.Image
                        End If
                    End If
                    If Player1.Piece = 1 Then
                        If position = 0 Then
                            Form1.a1.Image = Form1.red.Image
                        ElseIf position = 1 Then
                            Form1.a2.Image = Form1.red.Image
                        ElseIf position = 2 Then
                            Form1.a3.Image = Form1.red.Image
                        ElseIf position = 3 Then
                            Form1.a4.Image = Form1.red.Image
                        ElseIf position = 4 Then
                            Form1.a5.Image = Form1.red.Image
                        ElseIf position = 5 Then
                            Form1.a6.Image = Form1.red.Image
                        ElseIf position = 6 Then
                            Form1.a7.Image = Form1.red.Image
                        ElseIf position = 7 Then
                            Form1.a8.Image = Form1.red.Image
                        ElseIf position = 8 Then
                            Form1.a9.Image = Form1.red.Image
                        End If
                    End If
                    Board(position) = 2
                    COMDisable(position)
                    COMhasplayed = True
                End If
            End If
        End If
    End Sub
    Public Sub P1Play(ByVal place As Byte)
        If place = 0 Then
            If Player1.Piece = 0 Then
                Form1.a1.Image = Form1.red.Image
                Board(0) = 1
                PrevMove.P1Place = 0
                Form1.a1.Tag = "p"
                Form1.a1.Enabled = False
                Form1.Disable()
            Else
                Form1.a1.Image = Form1.blue.Image
                Board(0) = 1
                Form1.a1.Tag = "p"
                Form1.a1.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 1 Then
            If Player1.Piece = 0 Then
                Form1.a2.Image = Form1.red.Image
                Board(1) = 1
                Form1.a2.Tag = "p"
                Form1.a2.Enabled = False
                Form1.Disable()
            Else
                Form1.a2.Image = Form1.blue.Image
                Board(1) = 1
                Form1.a2.Tag = "p"
                Form1.a2.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 2 Then
            If Player1.Piece = 0 Then
                Form1.a3.Image = Form1.red.Image
                Board(2) = 1
                Form1.a3.Tag = "p"
                Form1.a3.Enabled = False
                Form1.Disable()
            Else
                Form1.a3.Image = Form1.blue.Image
                Board(2) = 1
                Form1.a3.Tag = "p"
                Form1.a3.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 3 Then
            If Player1.Piece = 0 Then
                Form1.a4.Image = Form1.red.Image
                Board(3) = 1
                Form1.a4.Tag = "p"
                Form1.a4.Enabled = False
                Form1.Disable()
            Else
                Form1.a4.Image = Form1.blue.Image
                Board(3) = 1
                Form1.a4.Tag = "p"
                Form1.a4.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 4 Then
            If Player1.Piece = 0 Then
                Form1.a5.Image = Form1.red.Image
                Board(4) = 1
                Form1.a5.Tag = "p"
                Form1.a5.Enabled = False
                Form1.Disable()
            Else
                Form1.a5.Image = Form1.blue.Image
                Board(4) = 1
                Form1.a5.Tag = "p"
                Form1.a5.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 5 Then
            If Player1.Piece = 0 Then
                Form1.a6.Image = Form1.red.Image
                Board(5) = 1
                Form1.a6.Tag = "p"
                Form1.a6.Enabled = False
                Form1.Disable()
            Else
                Form1.a6.Image = Form1.blue.Image
                Board(5) = 1
                Form1.a6.Tag = "p"
                Form1.a6.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 6 Then
            If Player1.Piece = 0 Then
                Form1.a7.Image = Form1.red.Image
                Board(6) = 1
                Form1.a7.Tag = "p"
                Form1.a7.Enabled = False
                Form1.Disable()
            Else
                Form1.a7.Image = Form1.blue.Image
                Board(6) = 1
                Form1.a7.Tag = "p"
                Form1.a7.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 7 Then
            If Player1.Piece = 0 Then
                Form1.a8.Image = Form1.red.Image
                Board(7) = 1
                Form1.a8.Tag = "p"
                Form1.a8.Enabled = False
                Form1.Disable()
            Else
                Form1.a8.Image = Form1.blue.Image
                Board(7) = 1
                Form1.a8.Tag = "p"
                Form1.a8.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 8 Then
            If Player1.Piece = 0 Then
                Form1.a9.Image = Form1.red.Image
                Board(8) = 1
                Form1.a9.Tag = "p"
                Form1.a9.Enabled = False
                Form1.Disable()
            Else
                Form1.a9.Image = Form1.blue.Image
                Board(8) = 1
                Form1.a9.Tag = "p"
                Form1.a9.Enabled = False
                Form1.Disable()
            End If
        End If
        COMhasplayed = False
    End Sub
    Private Sub COMAttackBasedOn2EmptySpaces(ByVal firstfilled As Byte, ByVal secondFilled As Byte, ByVal firstEmpty As Byte, ByVal secondEmpty As Byte, ByVal Decision As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(firstfilled) = 2 And Board(secondFilled) = 2 Then
                    If Board(firstEmpty) = 0 And Board(secondEmpty) = 0 Then
                        COMPlay(Decision)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Form2Ways(ByVal firstFilled As Byte, ByVal secondFilled As Byte, ByVal Decision As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(firstFilled) = 2 And Board(secondFilled) = 2 Then
                    If Board(Decision) = 0 Then
                        COMPlay(Decision)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub COMAttackBasedOn3EmptySpaces(ByVal firstfilled As Byte, ByVal secondFilled As Byte, ByVal firstEmpty As Byte, ByVal secondEmpty As Byte, ByVal thirdEmpty As Byte, ByVal Decision As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(firstfilled) = 2 And Board(secondFilled) = 2 Then
                    If Board(firstEmpty) = 0 And Board(secondEmpty) = 0 And Board(thirdEmpty) = 0 Then
                        COMPlay(Decision)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub DefendWhen(ByVal firstPosition, ByVal secondPosition, ByVal Decision)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(firstPosition) = 1 And Board(secondPosition) = 1 Then
                    COMPlay(Decision)
                End If
            End If
        End If
    End Sub
    Private Sub RandomPlay(ByVal type As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If type = 2 Then
                    COMPlay(0)
                    COMPlay(1)
                    COMPlay(2)
                    COMPlay(3)
                    COMPlay(4)
                    COMPlay(5)
                    COMPlay(6)
                    COMPlay(7)
                    COMPlay(8)

                End If
                If type = 1 Then
                    COMPlay(1)
                    COMPlay(3)
                    COMPlay(5)
                    COMPlay(7)

                End If
            End If
        End If
    End Sub
    Private Sub RandomDefence(ByVal firstPosition As Byte, ByVal secondPosition As Byte, ByVal Decision As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If GameLevel = 2 Then
                    If Board(firstPosition) = 1 And Board(secondPosition) = 1 Then
                        COMPlay(Decision)
                    End If
                Else
                    If Board(firstPosition) = 1 And Board(secondPosition) = 1 Then
                        Dim action As Byte = Rnd() * 10
                        If action > 3 Then
                            COMPlay(Decision)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub TryToWin(ByVal firstPosition As Byte, ByVal secondPosition As Byte, ByVal Decision As Byte)
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(firstPosition) = 2 And Board(secondPosition) = 2 Then
                    COMPlay(Decision)
                End If
            End If
        End If
    End Sub
    Public Sub CheckWin()
        Dim BoardData As String = ""
        If SomeoneWon = False Then
            BoardData = Board(0).ToString & Board(1).ToString & Board(2).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 1
                AnimateWinningPiece(0, 1, 2)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 1
                    AnimateWinningPiece(0, 1, 2)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 1
                    AnimateWinningPiece(0, 1, 2)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(2).ToString & Board(5).ToString & Board(8).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 6
                AnimateWinningPiece(2, 5, 8)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 6
                    AnimateWinningPiece(2, 5, 8)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 6
                    AnimateWinningPiece(2, 5, 8)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(3).ToString & Board(4).ToString & Board(5).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 2
                AnimateWinningPiece(3, 4, 5)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 2
                    AnimateWinningPiece(3, 4, 5)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 2
                    AnimateWinningPiece(3, 4, 5)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(6).ToString & Board(7).ToString & Board(8).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 3
                AnimateWinningPiece(6, 7, 8)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 3
                    AnimateWinningPiece(6, 7, 8)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 3
                    AnimateWinningPiece(6, 7, 8)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(0).ToString & Board(3).ToString & Board(6).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 4
                AnimateWinningPiece(0, 3, 6)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 4
                    AnimateWinningPiece(0, 3, 6)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 4
                    AnimateWinningPiece(0, 3, 6)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(1).ToString & Board(4).ToString & Board(7).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 5
                AnimateWinningPiece(1, 4, 7)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 5
                    AnimateWinningPiece(1, 4, 7)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 5
                    AnimateWinningPiece(1, 4, 7)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(0).ToString & Board(4).ToString & Board(8).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 7
                AnimateWinningPiece(0, 4, 8)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 7
                    AnimateWinningPiece(0, 4, 8)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 7
                    AnimateWinningPiece(0, 4, 8)
                End If
            End If
        End If
        If SomeoneWon = False Then
            BoardData = Board(2).ToString & Board(4).ToString & Board(6).ToString
            If BoardData = "111" Then
                Form1.infoLabel.Text = "Player 1 Wins!"
                SomeoneWon = True
                WinningType = 8
                AnimateWinningPiece(2, 4, 6)
            ElseIf BoardData = "222" Then
                If GameType = 0 Then
                    NotifyCOMP2Win()
                    SomeoneWon = True
                    WinningType = 8
                    AnimateWinningPiece(2, 4, 6)
                ElseIf GameType = 1 Then
                    Form1.infoLabel.Text = "Player 2 Wins!"
                    SomeoneWon = True
                    WinningType = 8
                    AnimateWinningPiece(2, 4, 6)
                End If
            End If
        End If
        If SomeoneWon = True Then
            nonSelectiveReset()
        End If
    End Sub
    Private Sub nonSelectiveReset()
        Form1.a1.Enabled = False
        Form1.a2.Enabled = False
        Form1.a3.Enabled = False
        Form1.a4.Enabled = False
        Form1.a5.Enabled = False
        Form1.a6.Enabled = False
        Form1.a7.Enabled = False
        Form1.a8.Enabled = False
        Form1.a9.Enabled = False
    End Sub
    Private Sub NotifyCOMP2Win()
        If GameType = 0 Then
            Form1.infoLabel.Text = "COM Wins!"
        ElseIf GameType = 1 Then
            Form1.infoLabel.Text = "Player 2 Wins!"
        End If
    End Sub
    Private Sub NormRandPlay()
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                Dim x As Byte
                x = Rnd() * 10
                If x = 0 Then
                    COMPlay(0)
                End If
                If x = 1 Then
                    COMPlay(1)
                End If
                If x = 2 Then
                    COMPlay(2)
                End If
                If x = 3 Then
                    COMPlay(3)
                End If
                If x = 4 Then
                    COMPlay(4)
                End If
                If x = 5 Then
                    COMPlay(5)
                End If
                If x = 6 Then
                    COMPlay(6)
                End If
                If x = 7 Then
                    COMPlay(7)
                End If
                If x = 8 Then
                    COMPlay(8)
                End If
                If x = 9 Then
                    COMPlay(5)
                End If
                If x = 10 Then
                    COMPlay(3)
                End If
            End If
        End If
    End Sub
    Private Sub EasyAttack()
        Dim x As Byte = 0
        x = Rnd() * 10
        If SomeoneWon = False Then
            If COMhasplayed = False Then
                If Board(0) = 2 Then
                    If x >= 5 Then
                        COMPlay(1)
                    Else
                        COMPlay(3)
                    End If
                End If
                If Board(1) = 2 Then
                    If x >= 5 Then
                        COMPlay(4)
                    ElseIf x = 3 Then
                        COMPlay(0)
                    Else
                        COMPlay(2)
                    End If
                End If
                If Board(3) = 2 Then
                    If x >= 5 Then
                        COMPlay(4)
                    ElseIf x = 2 Then
                        COMPlay(0)
                    Else
                        COMPlay(6)
                    End If
                End If
                If Board(2) = 2 Then
                    If x >= 5 Then
                        COMPlay(1)
                    ElseIf x = 2 Then
                        COMPlay(5)
                    Else
                        COMPlay(0)
                    End If
                End If
                If Board(4) = 2 Then
                    If x >= 5 Then
                        COMPlay(1)
                    ElseIf x = 2 Then
                        COMPlay(7)
                    Else
                        COMPlay(5)
                    End If
                End If
                If Board(7) = 2 Then
                    If x >= 5 Then
                        COMPlay(4)
                    ElseIf x = 2 Then
                        COMPlay(6)
                    Else
                        COMPlay(8)
                    End If
                End If
                If Board(6) = 2 Then
                    If x >= 5 Then
                        COMPlay(3)
                    ElseIf x = 2 Then
                        COMPlay(7)
                    Else
                        COMPlay(8)
                    End If
                End If
                If Board(8) = 2 Then
                    If x >= 5 Then
                        COMPlay(5)
                    ElseIf x = 2 Then
                        COMPlay(7)
                    Else
                        COMPlay(4)
                    End If
                End If
                If Board(4) = 2 Then
                    If x >= 5 Then
                        COMPlay(0)
                    ElseIf x = 2 Then
                        COMPlay(8)
                    Else
                        COMPlay(7)
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub P2Play(ByVal place As Byte)
        If place = 0 Then
            If Player2.Piece = 0 Then
                Form1.a1.Image = Form1.red.Image
                Board(0) = 2
                PrevMove.P1Place = 0
                Form1.a1.Tag = "p"
                Form1.a1.Enabled = False
                Form1.Disable()
            Else
                Form1.a1.Image = Form1.blue.Image
                Board(0) = 2
                Form1.a1.Tag = "p"
                Form1.a1.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 1 Then
            If Player2.Piece = 0 Then
                Form1.a2.Image = Form1.red.Image
                Board(1) = 2
                PrevMove.P1Place = 0
                Form1.a2.Tag = "p"
                Form1.a2.Enabled = False
                Form1.Disable()
            Else
                Form1.a2.Image = Form1.blue.Image
                Board(1) = 2
                Form1.a2.Tag = "p"
                Form1.a2.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 2 Then
            If Player2.Piece = 0 Then
                Form1.a3.Image = Form1.red.Image
                Board(2) = 2
                Form1.a3.Tag = "p"
                Form1.a3.Enabled = False
                Form1.Disable()
            Else
                Form1.a3.Image = Form1.blue.Image
                Board(2) = 2
                Form1.a3.Tag = "p"
                Form1.a3.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 3 Then
            If Player2.Piece = 0 Then
                Form1.a4.Image = Form1.red.Image
                Board(3) = 2
                Form1.a4.Tag = "p"
                Form1.a4.Enabled = False
                Form1.Disable()
            Else
                Form1.a4.Image = Form1.blue.Image
                Board(3) = 2
                Form1.a4.Tag = "p"
                Form1.a4.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 4 Then
            If Player2.Piece = 0 Then
                Form1.a5.Image = Form1.red.Image
                Board(4) = 2
                Form1.a5.Tag = "p"
                Form1.a5.Enabled = False
                Form1.Disable()
            Else
                Form1.a5.Image = Form1.blue.Image
                Board(4) = 2
                Form1.a5.Tag = "p"
                Form1.a5.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 5 Then
            If Player2.Piece = 0 Then
                Form1.a6.Image = Form1.red.Image
                Board(5) = 2
                Form1.a6.Tag = "p"
                Form1.a6.Enabled = False
                Form1.Disable()
            Else
                Form1.a6.Image = Form1.blue.Image
                Board(5) = 2
                Form1.a6.Tag = "p"
                Form1.a6.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 6 Then
            If Player2.Piece = 0 Then
                Form1.a7.Image = Form1.red.Image
                Board(6) = 2
                Form1.a7.Tag = "p"
                Form1.a7.Enabled = False
                Form1.Disable()
            Else
                Form1.a7.Image = Form1.blue.Image
                Board(6) = 2
                Form1.a7.Tag = "p"
                Form1.a7.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 7 Then
            If Player2.Piece = 0 Then
                Form1.a8.Image = Form1.red.Image
                Board(7) = 2
                Form1.a8.Tag = "p"
                Form1.a8.Enabled = False
                Form1.Disable()
            Else
                Form1.a8.Image = Form1.blue.Image
                Board(7) = 2
                Form1.a8.Tag = "p"
                Form1.a8.Enabled = False
                Form1.Disable()
            End If
        End If
        If place = 8 Then
            If Player2.Piece = 0 Then
                Form1.a9.Image = Form1.red.Image
                Board(8) = 2
                Form1.a9.Tag = "p"
                Form1.a9.Enabled = False
                Form1.Disable()
            Else
                Form1.a9.Image = Form1.blue.Image
                Board(8) = 2
                Form1.a9.Tag = "p"
                Form1.a9.Enabled = False
                Form1.Disable()
            End If
        End If
        COMhasplayed = False
    End Sub
    Private Sub AnimateWinningPiece(ByVal a As Byte, ByVal b As Byte, ByVal c As Byte)
        WinningPieces(0) = a
        WinningPieces(1) = b
        WinningPieces(2) = c
        GetRightImage(WinningPieces(1))
        Form1.animateTimer.Enabled = True
    End Sub
    Private Sub GetRightImage(ByVal place As Byte)
        If place = 0 Then
            WinninPieceImage = Form1.a1.Image
        End If
        If place = 1 Then
            WinninPieceImage = Form1.a2.Image
        End If
        If place = 2 Then
            WinninPieceImage = Form1.a3.Image
        End If
        If place = 3 Then
            WinninPieceImage = Form1.a4.Image
        End If
        If place = 4 Then
            WinninPieceImage = Form1.a5.Image
        End If
        If place = 5 Then
            WinninPieceImage = Form1.a6.Image
        End If
        If place = 6 Then
            WinninPieceImage = Form1.a7.Image
        End If
        If place = 7 Then
            WinninPieceImage = Form1.a8.Image
        End If
        If place = 8 Then
            WinninPieceImage = Form1.a9.Image
        End If
    End Sub
    Public Sub GenerateFixtures(ByVal TournamentType As Byte)
        Static TotalMatchable As Byte = 0
        Static x As Byte = 0 'first opponent
        Static u As Byte = 1 'second opponent
        TotalMatchable = OppLimit
        If GameType = 2 Then
            While TotalMatchable <> 1
                If TotalMatchable > 1 Then
                    Fixture &= Form1.fixtureGenRichTextBox.Lines(x) & _
                    " Vs " & Form1.fixtureGenRichTextBox.Lines(u) & NL
                    u += 1
                End If
                If TotalMatchable = 1 Then
                    Fixture &= Form1.fixtureGenRichTextBox.Lines(x) & _
                                        " Vs " & Form1.fixtureGenRichTextBox.Lines(u)
                End If
                If u = OppLimit Then
                    u = x + 2
                    x += 1
                    TotalMatchable -= 1
                End If
            End While
            Form1.fixtureGenRichTextBox.Text = ""
            Form1.fixtureGenRichTextBox.Text = Fixture
            For l As Integer = 0 To 190
                Form1.shuffleListBox.Items.Add(Form1.fixtureGenRichTextBox.Lines(l))
            Next
            Form1.shuffleListBox.Sorted = True
            Form1.shuffleListBox.Items.RemoveAt(0)
            Shuffle(1)
        End If
        If GameType = 3 Then
            u = 0
            While u <> 16
                Fixture &= Form1.fixtureGenRichTextBox.Lines(x) & _
                " Vs " & Form1.fixtureGenRichTextBox.Lines(x + 1) & NL
                x += 2
                u += 1
            End While
        End If
        If GameType = 4 Then
            Dim Group(7) As String
            Static c As Byte = 0
            Static g As Integer = 0
            Static carr As Byte = 0
            Do Until c = 8
                Group(c) &= Form1.fixtureGenRichTextBox.Lines(g) & NL
                g += 1
                carr += 1
                If carr = 4 Then
                    carr = 0
                    c += 1
                End If
            Loop
            c = 0
            Form1.fixtureGenRichTextBox.Text = ""
            Static n As Byte = 0
            Dim TempStr As String = ""
            g = 0
            c = 0
            Do Until c = 8
                Form1.fixtureGenRichTextBox.Text = Group(c)
                While g <> 3
                    TempStr &= Form1.fixtureGenRichTextBox.Lines(g) & _
                    " Vs " & Form1.fixtureGenRichTextBox.Lines(n + 1) & NL
                    n += 1
                    If n = 3 Then
                        If g = 0 Then
                            n = 1
                        ElseIf g = 1 Then
                            n = 2
                        End If
                        g += 1
                    End If
                End While
                Form1.fixtureGenRichTextBox.Text = TempStr
                Final = ""
                AddToFixture(c)
                TempStr = ""
                c += 1
                n = 0
                g = 0
            Loop
        End If
    End Sub
    Private Sub Shuffle(ByVal type As Byte)
        If type = 1 Then
            Dim x As Byte = 0
            Fixture = ""
            While (Form1.shuffleListBox.Items.Count <> 0)
                x = Rnd() * 100
                Try
                    Fixture &= Form1.shuffleListBox.Items.Item(x) & NL
                    Form1.shuffleListBox.Items.RemoveAt(x)
                Catch
                    x = Rnd() * 10
                    If x <= 5 Then
                        Fixture &= Form1.shuffleListBox.Items.Item(Form1.shuffleListBox.Items.Count - 1).ToString() & NL
                        Form1.shuffleListBox.Items.RemoveAt(Form1.shuffleListBox.Items.Count - 1)
                    Else
                        Fixture &= Form1.shuffleListBox.Items.Item(0) & NL
                        Form1.shuffleListBox.Items.RemoveAt(0)
                    End If
                End Try
            End While
        End If
        If type = 2 Then
            Dim Ff(5) As String
            Ff(0) = Form1.fixtureGenRichTextBox.Lines(0)
            Ff(1) = Form1.fixtureGenRichTextBox.Lines(1)
            Ff(2) = Form1.fixtureGenRichTextBox.Lines(2)
            Ff(3) = Form1.fixtureGenRichTextBox.Lines(3)
            Ff(4) = Form1.fixtureGenRichTextBox.Lines(4)
            Ff(5) = Form1.fixtureGenRichTextBox.Lines(5)
            Final &= Ff(0) & NL & Ff(5) & NL & Ff(1) & NL & Ff(4) & NL & Ff(2) & NL & Ff(3) & NL
        End If
    End Sub
    Private Sub AddToFixture(ByVal Group As Byte)
        Final = ""
        Shuffle(2)
        If Group = 0 Then
            Fixture &= "1" & NL & Final
        End If
        If Group = 1 Then
            Fixture &= "2" & NL & Final
        End If
        If Group = 2 Then
            Fixture &= "3" & NL & Final
        End If
        If Group = 3 Then
            Fixture &= "4" & NL & Final
        End If
        If Group = 4 Then
            Fixture &= "5" & NL & Final
        End If
        If Group = 5 Then
            Fixture &= "6" & NL & Final
        End If
        If Group = 6 Then
            Fixture &= "7" & NL & Final
        End If
        If Group = 7 Then
            Fixture &= "8" & NL & Final
        End If
        Final = ""
    End Sub
End Module
