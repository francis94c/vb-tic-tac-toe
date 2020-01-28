<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewFixturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StandingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectPieceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.a1 = New System.Windows.Forms.PictureBox
        Me.a2 = New System.Windows.Forms.PictureBox
        Me.a3 = New System.Windows.Forms.PictureBox
        Me.a9 = New System.Windows.Forms.PictureBox
        Me.a8 = New System.Windows.Forms.PictureBox
        Me.a7 = New System.Windows.Forms.PictureBox
        Me.a4 = New System.Windows.Forms.PictureBox
        Me.a6 = New System.Windows.Forms.PictureBox
        Me.a5 = New System.Windows.Forms.PictureBox
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.red = New System.Windows.Forms.PictureBox
        Me.blue = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.player1RadioButton = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.infoLabel = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.fixtureGenRichTextBox = New System.Windows.Forms.RichTextBox
        Me.shuffleListBox = New System.Windows.Forms.ListBox
        Me.animateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.UndoToolStripMenuItem, Me.TournamentToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewFixturesToolStripMenuItem, Me.StandingsToolStripMenuItem})
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TournamentToolStripMenuItem.Text = "Tournament"
        '
        'ViewFixturesToolStripMenuItem
        '
        Me.ViewFixturesToolStripMenuItem.Name = "ViewFixturesToolStripMenuItem"
        Me.ViewFixturesToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ViewFixturesToolStripMenuItem.Text = "Fixtures"
        '
        'StandingsToolStripMenuItem
        '
        Me.StandingsToolStripMenuItem.Name = "StandingsToolStripMenuItem"
        Me.StandingsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StandingsToolStripMenuItem.Text = "Standings"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectPieceToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'SelectPieceToolStripMenuItem
        '
        Me.SelectPieceToolStripMenuItem.Name = "SelectPieceToolStripMenuItem"
        Me.SelectPieceToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SelectPieceToolStripMenuItem.Text = "Select Piece"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 185)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 92)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(185, 10)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(134, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 185)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'a1
        '
        Me.a1.Location = New System.Drawing.Point(12, 38)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(47, 51)
        Me.a1.TabIndex = 6
        Me.a1.TabStop = False
        Me.a1.Tag = "Picture"
        '
        'a2
        '
        Me.a2.Location = New System.Drawing.Point(81, 38)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(47, 51)
        Me.a2.TabIndex = 7
        Me.a2.TabStop = False
        Me.a2.Tag = "Picture"
        '
        'a3
        '
        Me.a3.Location = New System.Drawing.Point(150, 38)
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(47, 51)
        Me.a3.TabIndex = 8
        Me.a3.TabStop = False
        Me.a3.Tag = "Picture"
        '
        'a9
        '
        Me.a9.Location = New System.Drawing.Point(150, 172)
        Me.a9.Name = "a9"
        Me.a9.Size = New System.Drawing.Size(47, 51)
        Me.a9.TabIndex = 9
        Me.a9.TabStop = False
        Me.a9.Tag = "Picture"
        '
        'a8
        '
        Me.a8.Location = New System.Drawing.Point(81, 172)
        Me.a8.Name = "a8"
        Me.a8.Size = New System.Drawing.Size(47, 51)
        Me.a8.TabIndex = 10
        Me.a8.TabStop = False
        Me.a8.Tag = "Picture"
        '
        'a7
        '
        Me.a7.Location = New System.Drawing.Point(12, 172)
        Me.a7.Name = "a7"
        Me.a7.Size = New System.Drawing.Size(47, 51)
        Me.a7.TabIndex = 11
        Me.a7.TabStop = False
        Me.a7.Tag = "Picture"
        '
        'a4
        '
        Me.a4.Location = New System.Drawing.Point(12, 105)
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(47, 51)
        Me.a4.TabIndex = 12
        Me.a4.TabStop = False
        Me.a4.Tag = "Picture"
        '
        'a6
        '
        Me.a6.Location = New System.Drawing.Point(150, 105)
        Me.a6.Name = "a6"
        Me.a6.Size = New System.Drawing.Size(47, 51)
        Me.a6.TabIndex = 13
        Me.a6.TabStop = False
        Me.a6.Tag = "Picture"
        '
        'a5
        '
        Me.a5.Location = New System.Drawing.Point(81, 105)
        Me.a5.Name = "a5"
        Me.a5.Size = New System.Drawing.Size(47, 51)
        Me.a5.TabIndex = 14
        Me.a5.TabStop = False
        Me.a5.Tag = "Picture"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(12, 159)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(185, 10)
        Me.PictureBox12.TabIndex = 15
        Me.PictureBox12.TabStop = False
        '
        'red
        '
        Me.red.Image = CType(resources.GetObject("red.Image"), System.Drawing.Image)
        Me.red.Location = New System.Drawing.Point(150, 38)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(47, 51)
        Me.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.red.TabIndex = 0
        Me.red.TabStop = False
        Me.red.Visible = False
        '
        'blue
        '
        Me.blue.Image = CType(resources.GetObject("blue.Image"), System.Drawing.Image)
        Me.blue.Location = New System.Drawing.Point(81, 105)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(47, 51)
        Me.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.blue.TabIndex = 1
        Me.blue.TabStop = False
        Me.blue.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1"
        '
        'player1RadioButton
        '
        Me.player1RadioButton.AutoSize = True
        Me.player1RadioButton.Location = New System.Drawing.Point(54, -118)
        Me.player1RadioButton.Name = "player1RadioButton"
        Me.player1RadioButton.Size = New System.Drawing.Size(14, 13)
        Me.player1RadioButton.TabIndex = 1
        Me.player1RadioButton.TabStop = True
        Me.player1RadioButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "COM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "VS"
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoLabel.Location = New System.Drawing.Point(4, 159)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(90, 23)
        Me.infoLabel.TabIndex = 5
        Me.infoLabel.Text = "Label4"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.infoLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.player1RadioButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.fixtureGenRichTextBox)
        Me.Panel1.Controls.Add(Me.shuffleListBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(201, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 209)
        Me.Panel1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(31, 40)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(187, 96)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'fixtureGenRichTextBox
        '
        Me.fixtureGenRichTextBox.Location = New System.Drawing.Point(3, 81)
        Me.fixtureGenRichTextBox.Name = "fixtureGenRichTextBox"
        Me.fixtureGenRichTextBox.Size = New System.Drawing.Size(100, 96)
        Me.fixtureGenRichTextBox.TabIndex = 17
        Me.fixtureGenRichTextBox.Text = ""
        Me.fixtureGenRichTextBox.Visible = False
        '
        'shuffleListBox
        '
        Me.shuffleListBox.FormattingEnabled = True
        Me.shuffleListBox.Location = New System.Drawing.Point(88, 61)
        Me.shuffleListBox.Name = "shuffleListBox"
        Me.shuffleListBox.Size = New System.Drawing.Size(120, 95)
        Me.shuffleListBox.TabIndex = 20
        Me.shuffleListBox.Visible = False
        '
        'animateTimer
        '
        Me.animateTimer.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 233)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.a5)
        Me.Controls.Add(Me.a6)
        Me.Controls.Add(Me.a4)
        Me.Controls.Add(Me.a7)
        Me.Controls.Add(Me.a8)
        Me.Controls.Add(Me.a9)
        Me.Controls.Add(Me.a3)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.blue)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents a1 As System.Windows.Forms.PictureBox
    Friend WithEvents a2 As System.Windows.Forms.PictureBox
    Friend WithEvents a3 As System.Windows.Forms.PictureBox
    Friend WithEvents a9 As System.Windows.Forms.PictureBox
    Friend WithEvents a8 As System.Windows.Forms.PictureBox
    Friend WithEvents a7 As System.Windows.Forms.PictureBox
    Friend WithEvents a4 As System.Windows.Forms.PictureBox
    Friend WithEvents a6 As System.Windows.Forms.PictureBox
    Friend WithEvents a5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents blue As System.Windows.Forms.PictureBox
    Friend WithEvents red As System.Windows.Forms.PictureBox
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectPieceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents player1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents infoLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents animateTimer As System.Windows.Forms.Timer
    Friend WithEvents TournamentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFixturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fixtureGenRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents shuffleListBox As System.Windows.Forms.ListBox

End Class
