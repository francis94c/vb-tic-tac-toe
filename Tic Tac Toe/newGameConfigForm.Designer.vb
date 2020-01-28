<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newGameConfigForm
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
        Me.difficultyGroupBox = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton11 = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.pieceGroupBox = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.opponentSelectionGroupBox = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.selectedListBox = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.allListBox = New System.Windows.Forms.ListBox
        Me.COMRichTextBox = New System.Windows.Forms.RichTextBox
        Me.difficultyGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pieceGroupBox.SuspendLayout()
        Me.opponentSelectionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'difficultyGroupBox
        '
        Me.difficultyGroupBox.Controls.Add(Me.RadioButton3)
        Me.difficultyGroupBox.Controls.Add(Me.RadioButton2)
        Me.difficultyGroupBox.Controls.Add(Me.RadioButton1)
        Me.difficultyGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.difficultyGroupBox.Name = "difficultyGroupBox"
        Me.difficultyGroupBox.Size = New System.Drawing.Size(70, 82)
        Me.difficultyGroupBox.TabIndex = 0
        Me.difficultyGroupBox.TabStop = False
        Me.difficultyGroupBox.Text = "Difficulty"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Hard"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Normal"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Easy"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Location = New System.Drawing.Point(88, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Type"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(6, 128)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton11.TabIndex = 5
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Selection Play"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 109)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton10.TabIndex = 4
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Cup"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 86)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton7.TabIndex = 3
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Knockout"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "1p Vs COM"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "1p Vs 2p"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 63)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Championship"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Checked = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton8.TabIndex = 2
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Red"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton9.TabIndex = 3
        Me.RadioButton9.Text = "Blue"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'pieceGroupBox
        '
        Me.pieceGroupBox.Controls.Add(Me.RadioButton9)
        Me.pieceGroupBox.Controls.Add(Me.RadioButton8)
        Me.pieceGroupBox.Location = New System.Drawing.Point(12, 98)
        Me.pieceGroupBox.Name = "pieceGroupBox"
        Me.pieceGroupBox.Size = New System.Drawing.Size(70, 63)
        Me.pieceGroupBox.TabIndex = 4
        Me.pieceGroupBox.TabStop = False
        Me.pieceGroupBox.Text = "Piece"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 149)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'opponentSelectionGroupBox
        '
        Me.opponentSelectionGroupBox.Controls.Add(Me.Button2)
        Me.opponentSelectionGroupBox.Controls.Add(Me.selectedListBox)
        Me.opponentSelectionGroupBox.Controls.Add(Me.Label1)
        Me.opponentSelectionGroupBox.Controls.Add(Me.allListBox)
        Me.opponentSelectionGroupBox.Location = New System.Drawing.Point(12, 167)
        Me.opponentSelectionGroupBox.Name = "opponentSelectionGroupBox"
        Me.opponentSelectionGroupBox.Size = New System.Drawing.Size(223, 179)
        Me.opponentSelectionGroupBox.TabIndex = 6
        Me.opponentSelectionGroupBox.TabStop = False
        Me.opponentSelectionGroupBox.Text = "Opponent Settings"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 22)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "See Opponent's Info..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'selectedListBox
        '
        Me.selectedListBox.FormattingEnabled = True
        Me.selectedListBox.Location = New System.Drawing.Point(126, 19)
        Me.selectedListBox.Name = "selectedListBox"
        Me.selectedListBox.Size = New System.Drawing.Size(92, 134)
        Me.selectedListBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-->"
        '
        'allListBox
        '
        Me.allListBox.FormattingEnabled = True
        Me.allListBox.Location = New System.Drawing.Point(3, 16)
        Me.allListBox.Name = "allListBox"
        Me.allListBox.Size = New System.Drawing.Size(92, 134)
        Me.allListBox.TabIndex = 0
        '
        'COMRichTextBox
        '
        Me.COMRichTextBox.Location = New System.Drawing.Point(114, 166)
        Me.COMRichTextBox.Name = "COMRichTextBox"
        Me.COMRichTextBox.Size = New System.Drawing.Size(100, 96)
        Me.COMRichTextBox.TabIndex = 7
        Me.COMRichTextBox.Text = ""
        Me.COMRichTextBox.Visible = False
        '
        'newGameConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 351)
        Me.Controls.Add(Me.opponentSelectionGroupBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pieceGroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.difficultyGroupBox)
        Me.Controls.Add(Me.COMRichTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "newGameConfigForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Game"
        Me.difficultyGroupBox.ResumeLayout(False)
        Me.difficultyGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pieceGroupBox.ResumeLayout(False)
        Me.pieceGroupBox.PerformLayout()
        Me.opponentSelectionGroupBox.ResumeLayout(False)
        Me.opponentSelectionGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents difficultyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents pieceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents opponentSelectionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents allListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents selectedListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents COMRichTextBox As System.Windows.Forms.RichTextBox
End Class
