Imports System.IO
Public Class newGameConfigForm
    Private difficulty As Byte = 0
    Private gType As Byte = 0
    Private piecee As Byte = 0
    Private InitStr As String = ""
    Public OppAmount As Byte = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call RadioButton1_CheckedChanged(sender, e)
        Call RadioButton2_CheckedChanged(sender, e)
        Call RadioButton3_CheckedChanged(sender, e)
        Call RadioButton4_CheckedChanged(sender, e)
        Call RadioButton5_CheckedChanged(sender, e)
        Call RadioButton6_CheckedChanged(sender, e)
        Call RadioButton7_CheckedChanged(sender, e)
        Call RadioButton8_CheckedChanged(sender, e)
        Call RadioButton9_CheckedChanged(sender, e)
        GameLevel = difficulty
        GameType = gType
        Player1.Piece = piecee
        If GameType = 1 Then
            If Player1.Piece = 0 Then
                Player2.Piece = 1
            Else
                Player2.Piece = 0
            End If
        End If
        If gType >= 2 Then
            If selectedListBox.Items.Count <> OppAmount Then
                Dim Reply As String = ""
                Reply = MessageBox.Show("Number of opponents must be up to " & OppLimit.ToString() _
                & ", Randomly select ramaining?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If Reply = DialogResult.Yes Then
                    RandomSelect()
                    Static u As Byte = 0
                    While u < OppLimit
                        If u <> OppLimit - 1 Then
                            OpponentList &= selectedListBox.Items.Item(u) & NL
                            u += 1
                        Else
                            OpponentList &= selectedListBox.Items.Item(u) & NL
                            u += 1
                        End If
                    End While
                    Form1.fixtureGenRichTextBox.Text = OpponentList
                    GenerateFixtures(gType)
                    Me.Close()
                End If
            End If
        End If
        HasVisitedNewGame = True
        If gType < 2 Then
            Me.Close()
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then ' easy
            difficulty = 0
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            difficulty = 1
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            difficulty = 2
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then ' 1p Vs 2p
            ComeOutOfSelectionPlay()
            gType = 1
            pieceGroupBox.Text = "P1 Piece"
            difficultyGroupBox.Enabled = False
            opponentSelectionGroupBox.Enabled = False
            RefreshListBoxes()
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then ' 1p Vs COM
            ComeOutOfSelectionPlay()
            gType = 0
            pieceGroupBox.Text = InitStr
            difficultyGroupBox.Enabled = True
            opponentSelectionGroupBox.Enabled = False
            RefreshListBoxes()
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then ' championship
            ComeOutOfSelectionPlay()
            gType = 2
            OppLimit = 20
            pieceGroupBox.Text = "P1 Piece"
            difficultyGroupBox.Enabled = False
            opponentSelectionGroupBox.Enabled = True
            RefreshListBoxes()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then ' Knockout
            ComeOutOfSelectionPlay()
            gType = 3
            OppLimit = 32
            pieceGroupBox.Text = "P1 Piece"
            difficultyGroupBox.Enabled = False
            opponentSelectionGroupBox.Enabled = True
            RefreshListBoxes()
        End If
    End Sub
    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then ' Player Piece (red) also means plays first
            piecee = 0
        End If
    End Sub

    Private Sub newGameConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitStr = pieceGroupBox.Text
        Dim COMSReader As New StreamReader(AppStartDirec & "\COM")
        COMRichTextBox.Text = COMSReader.ReadToEnd
        COMSReader.Close()
        Dim errBln As Boolean = False
        Static x As Byte = 0
        While errBln = False
            Try
                allListBox.Items.Add(COMRichTextBox.Lines(x))
                x += 2
            Catch ex As Exception
                errBln = True
            End Try
        End While
        allListBox.Items.Add(Player2.Name)
        allListBox.Sorted = True
        allListBox.Items.RemoveAt(0)
        errBln = False
        selectedListBox.Items.Add(Player1.Name)
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then ' player piece (blue) means com is red and plays first
            piecee = 1
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then ' Cup
            ComeOutOfSelectionPlay()
            gType = 4
            OppLimit = 32
            pieceGroupBox.Text = "P1 Piece"
            difficultyGroupBox.Enabled = False
            opponentSelectionGroupBox.Enabled = True
            RefreshListBoxes()
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            gType = 5
            opponentSelectionGroupBox.Enabled = True
            difficultyGroupBox.Enabled = False
            OppLimit = 1
            selectedListBox.Items.Clear()
            FillInAllOpponents()
        End If
    End Sub
    Private Sub allListBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allListBox.DoubleClick
        If selectedListBox.Items.Count < OppLimit Then
            If allListBox.SelectedIndex <> -1 Then
                Dim selectedIndex As Integer = 0
                selectedListBox.Items.Add(allListBox.SelectedItem)
                selectedIndex = allListBox.SelectedIndex
                allListBox.Items.RemoveAt(selectedIndex)
            End If
            selectedListBox.Sorted = True
        Else
            MessageBox.Show("Max of " & OppLimit.ToString & " Allowed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub selectedListBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectedListBox.DoubleClick
        If selectedListBox.SelectedIndex <> -1 Then
            Dim selectedIndex As Integer = 0
            allListBox.Items.Add(selectedListBox.SelectedItem)
            selectedIndex = selectedListBox.SelectedIndex
            selectedListBox.Items.RemoveAt(selectedIndex)
            allListBox.Sorted = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Opp(1) As String
        Dim Xp(1) As String
        For i As Integer = 0 To 1
            Opp(i) = ""
            Xp(i) = ""
        Next
        If allListBox.SelectedIndex <> -1 Then
            Opp(0) = allListBox.SelectedItem.ToString()
            Try
                For x As Integer = 0 To 65
                    If Opp(0) = COMRichTextBox.Lines(x) Then
                        Xp(0) = COMRichTextBox.Lines(x + 1)
                    End If
                Next
            Catch
            End Try
        End If
        If selectedListBox.SelectedIndex <> -1 Then
            Opp(1) = selectedListBox.SelectedItem.ToString()
            Try
                For x As Integer = 0 To 65
                    If Opp(1) = COMRichTextBox.Lines(x) Then
                        Xp(1) = COMRichTextBox.Lines(x + 1)
                    End If
                Next
            Catch
            End Try
        End If
        If Xp(0) <> "" And Xp(1) <> "" Then
            MessageBox.Show("Opponent(Free): " & Opp(0) & ControlChars.NewLine _
                              & "Experience: " & Xp(0) & ControlChars.NewLine _
                              & "Opponent(Selected): " & Opp(1) & ControlChars.NewLine _
                              & "Experience: " & Xp(1), "Oppenent's Info", MessageBoxButtons.OK, MessageBoxIcon.None)
        ElseIf Xp(0) <> "" Then
            MessageBox.Show("Opponent: " & Opp(0) & ControlChars.NewLine & "Experience: " & Xp(0), "Opponent's Info", MessageBoxButtons.OK, MessageBoxIcon.None)
        ElseIf Xp(1) <> "" Then
            MessageBox.Show("Opponent: " & Opp(1) & ControlChars.NewLine & "Experience: " & Xp(1), "Opponent's Info", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub
    Private Sub RefreshListBoxes()
        If selectedListBox.Items.Count > 1 Then
            allListBox.Items.Clear()
            Dim errBln As Boolean = False
            Static x As Byte = 0
            While errBln = False
                Try
                    allListBox.Items.Add(COMRichTextBox.Lines(x))
                    x += 2
                Catch ex As Exception
                    errBln = True
                    selectedListBox.Items.Clear()
                    selectedListBox.Items.Add(Player1.Name)
                End Try
            End While
            allListBox.Items.Add(Player2.Name)
            allListBox.Sorted = True
            allListBox.Items.RemoveAt(0)
            errBln = False
            selectedListBox.Items.Clear()
            selectedListBox.Items.Add(Player1.Name)
        End If
    End Sub
    Private Sub RandomSelect()
        Static x As Byte = 0
        While selectedListBox.Items.Count < OppLimit
            If selectedListBox.Items.Contains(COMRichTextBox.Lines(x)) = False Then
                selectedListBox.Items.Add(COMRichTextBox.Lines(x))
            End If
            x += 2
        End While
    End Sub
    Private Sub FillInAllOpponents()
        If selectedListBox.Items.Count > 1 Then
            allListBox.Items.Clear()
            Dim errBln As Boolean = False
            Static x As Byte = 0
            While errBln = False
                Try
                    allListBox.Items.Add(COMRichTextBox.Lines(x))
                    x += 2
                Catch ex As Exception
                    errBln = True
                    selectedListBox.Items.Clear()
                    selectedListBox.Items.Add(Player1.Name)
                End Try
            End While
            allListBox.Items.Add(Player2.Name)
            allListBox.Sorted = True
            allListBox.Items.RemoveAt(0)
            errBln = False
        End If
    End Sub
    Private Sub ComeOutOfSelectionPlay()
        If gType = 5 Then
            selectedListBox.Items.Clear()
            selectedListBox.Items.Add(Player1.Name)
        End If
    End Sub
End Class