<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        IN_DURATION = New TextBox()
        PictureBox4 = New PictureBox()
        IN_INTERVAL = New TextBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label4 = New Label()
        PictureBox7 = New PictureBox()
        Label5 = New Label()
        SCN_SELF2 = New CheckBox()
        SCN_NOTEPAD2 = New CheckBox()
        SCN_EXCEL2 = New CheckBox()
        PictureBox8 = New PictureBox()
        OUT_TIMER = New Label()
        OUT_TIMER_LABEL = New Label()
        PictureBox1 = New PictureBox()
        BTN_START = New Button()
        Label8 = New Label()
        Label9 = New Label()
        PANEL_PROC_LOAD = New Panel()
        ProgressBar1 = New ProgressBar()
        Label6 = New Label()
        Label10 = New Label()
        KILL_SWITCH = New Button()
        PANEL_LOCK = New Panel()
        LOCK_UNLOCK = New Button()
        LOCK_TEXT = New MaskedTextBox()
        LOCK_LABEL = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PANEL_PROC_LOAD.SuspendLayout()
        PANEL_LOCK.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label1.Font = New Font("Bahnschrift Condensed", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(37, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 33)
        Label1.TabIndex = 100
        Label1.Text = "PROSCREEN"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Location = New Point(31, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(370, 2)
        PictureBox2.TabIndex = 102
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label2.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(53, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 17)
        Label2.TabIndex = 103
        Label2.Text = "SPECIAL EDITION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(99, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 17)
        Label3.TabIndex = 104
        Label3.Text = "SET DURATION"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(102, 102)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(176, 2)
        PictureBox3.TabIndex = 105
        PictureBox3.TabStop = False
        ' 
        ' IN_DURATION
        ' 
        IN_DURATION.BackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        IN_DURATION.BorderStyle = BorderStyle.FixedSingle
        IN_DURATION.Font = New Font("Bahnschrift Condensed", 14F, FontStyle.Bold)
        IN_DURATION.ForeColor = Color.White
        IN_DURATION.Location = New Point(279, 104)
        IN_DURATION.MaximumSize = New Size(60, 30)
        IN_DURATION.MinimumSize = New Size(60, 30)
        IN_DURATION.Name = "IN_DURATION"
        IN_DURATION.Size = New Size(60, 30)
        IN_DURATION.TabIndex = 3
        IN_DURATION.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Location = New Point(277, 102)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 34)
        PictureBox4.TabIndex = 107
        PictureBox4.TabStop = False
        ' 
        ' IN_INTERVAL
        ' 
        IN_INTERVAL.BackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        IN_INTERVAL.BorderStyle = BorderStyle.FixedSingle
        IN_INTERVAL.Font = New Font("Bahnschrift Condensed", 14F, FontStyle.Bold)
        IN_INTERVAL.ForeColor = Color.White
        IN_INTERVAL.Location = New Point(279, 176)
        IN_INTERVAL.MaximumSize = New Size(60, 30)
        IN_INTERVAL.MinimumSize = New Size(60, 30)
        IN_INTERVAL.Name = "IN_INTERVAL"
        IN_INTERVAL.Size = New Size(60, 30)
        IN_INTERVAL.TabIndex = 4
        IN_INTERVAL.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Location = New Point(277, 174)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 34)
        PictureBox5.TabIndex = 111
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Location = New Point(102, 174)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(176, 2)
        PictureBox6.TabIndex = 109
        PictureBox6.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(99, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 17)
        Label4.TabIndex = 108
        Label4.Text = "SET INTERVALS"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.Location = New Point(102, 245)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(240, 2)
        PictureBox7.TabIndex = 114
        PictureBox7.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(99, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 17)
        Label5.TabIndex = 113
        Label5.Text = "SELECT SCENARIOS"
        ' 
        ' SCN_SELF2
        ' 
        SCN_SELF2.Appearance = Appearance.Button
        SCN_SELF2.FlatAppearance.BorderColor = Color.White
        SCN_SELF2.FlatAppearance.BorderSize = 2
        SCN_SELF2.FlatStyle = FlatStyle.Flat
        SCN_SELF2.Font = New Font("Bahnschrift Condensed", 11F)
        SCN_SELF2.ForeColor = Color.White
        SCN_SELF2.Location = New Point(102, 245)
        SCN_SELF2.Name = "SCN_SELF2"
        SCN_SELF2.Size = New Size(64, 34)
        SCN_SELF2.TabIndex = 5
        SCN_SELF2.Text = "SELF"
        SCN_SELF2.TextAlign = ContentAlignment.MiddleCenter
        SCN_SELF2.UseVisualStyleBackColor = True
        ' 
        ' SCN_NOTEPAD2
        ' 
        SCN_NOTEPAD2.Appearance = Appearance.Button
        SCN_NOTEPAD2.FlatAppearance.BorderColor = Color.White
        SCN_NOTEPAD2.FlatAppearance.BorderSize = 2
        SCN_NOTEPAD2.FlatStyle = FlatStyle.Flat
        SCN_NOTEPAD2.Font = New Font("Bahnschrift Condensed", 11F)
        SCN_NOTEPAD2.ForeColor = Color.White
        SCN_NOTEPAD2.Location = New Point(190, 245)
        SCN_NOTEPAD2.Name = "SCN_NOTEPAD2"
        SCN_NOTEPAD2.Size = New Size(64, 34)
        SCN_NOTEPAD2.TabIndex = 6
        SCN_NOTEPAD2.Text = "NOTEPAD"
        SCN_NOTEPAD2.TextAlign = ContentAlignment.MiddleCenter
        SCN_NOTEPAD2.UseVisualStyleBackColor = True
        ' 
        ' SCN_EXCEL2
        ' 
        SCN_EXCEL2.Appearance = Appearance.Button
        SCN_EXCEL2.FlatAppearance.BorderColor = Color.White
        SCN_EXCEL2.FlatAppearance.BorderSize = 2
        SCN_EXCEL2.FlatStyle = FlatStyle.Flat
        SCN_EXCEL2.Font = New Font("Bahnschrift Condensed", 11F)
        SCN_EXCEL2.ForeColor = Color.White
        SCN_EXCEL2.Location = New Point(278, 245)
        SCN_EXCEL2.Name = "SCN_EXCEL2"
        SCN_EXCEL2.Size = New Size(64, 34)
        SCN_EXCEL2.TabIndex = 7
        SCN_EXCEL2.Text = "EXCEL"
        SCN_EXCEL2.TextAlign = ContentAlignment.MiddleCenter
        SCN_EXCEL2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        PictureBox8.Location = New Point(-9, 0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(453, 60)
        PictureBox8.TabIndex = 122
        PictureBox8.TabStop = False
        ' 
        ' OUT_TIMER
        ' 
        OUT_TIMER.AutoSize = True
        OUT_TIMER.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        OUT_TIMER.Font = New Font("Bahnschrift Condensed", 16F, FontStyle.Bold)
        OUT_TIMER.ForeColor = Color.White
        OUT_TIMER.Location = New Point(344, -1)
        OUT_TIMER.Name = "OUT_TIMER"
        OUT_TIMER.Size = New Size(50, 27)
        OUT_TIMER.TabIndex = 123
        OUT_TIMER.Text = "00:00"
        ' 
        ' OUT_TIMER_LABEL
        ' 
        OUT_TIMER_LABEL.AutoSize = True
        OUT_TIMER_LABEL.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        OUT_TIMER_LABEL.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        OUT_TIMER_LABEL.ForeColor = Color.White
        OUT_TIMER_LABEL.Location = New Point(309, 6)
        OUT_TIMER_LABEL.Name = "OUT_TIMER_LABEL"
        OUT_TIMER_LABEL.Size = New Size(37, 17)
        OUT_TIMER_LABEL.TabIndex = 124
        OUT_TIMER_LABEL.Text = "TIMER:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        PictureBox1.Location = New Point(-9, 316)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(453, 130)
        PictureBox1.TabIndex = 125
        PictureBox1.TabStop = False
        ' 
        ' BTN_START
        ' 
        BTN_START.FlatAppearance.BorderSize = 2
        BTN_START.FlatStyle = FlatStyle.Flat
        BTN_START.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        BTN_START.ForeColor = Color.White
        BTN_START.Location = New Point(140, 330)
        BTN_START.Name = "BTN_START"
        BTN_START.Size = New Size(155, 66)
        BTN_START.TabIndex = 108
        BTN_START.Text = "START SCREEN MANAGEMENT"
        BTN_START.UseVisualStyleBackColor = True
        BTN_START.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(340, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 17)
        Label8.TabIndex = 127
        Label8.Text = "mins"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bahnschrift Condensed", 10F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(340, 182)
        Label9.Name = "Label9"
        Label9.Size = New Size(23, 17)
        Label9.TabIndex = 128
        Label9.Text = "sec"
        ' 
        ' PANEL_PROC_LOAD
        ' 
        PANEL_PROC_LOAD.Controls.Add(ProgressBar1)
        PANEL_PROC_LOAD.Controls.Add(Label6)
        PANEL_PROC_LOAD.Location = New Point(12, 66)
        PANEL_PROC_LOAD.Name = "PANEL_PROC_LOAD"
        PANEL_PROC_LOAD.Size = New Size(410, 244)
        PANEL_PROC_LOAD.TabIndex = 129
        PANEL_PROC_LOAD.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(128, 114)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(155, 23)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 126
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label6.Font = New Font("Bahnschrift Condensed", 11F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(128, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 26)
        Label6.TabIndex = 125
        Label6.Text = "PROCESS LIST IS LOADING"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label10.Font = New Font("Bahnschrift Condensed", 12F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(142, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(21, 19)
        Label10.TabIndex = 130
        Label10.Text = "FX"
        ' 
        ' KILL_SWITCH
        ' 
        KILL_SWITCH.BackColor = Color.Brown
        KILL_SWITCH.FlatAppearance.BorderSize = 2
        KILL_SWITCH.FlatAppearance.MouseDownBackColor = Color.IndianRed
        KILL_SWITCH.FlatAppearance.MouseOverBackColor = Color.Firebrick
        KILL_SWITCH.FlatStyle = FlatStyle.Flat
        KILL_SWITCH.Font = New Font("Bahnschrift", 8F, FontStyle.Bold)
        KILL_SWITCH.ForeColor = Color.White
        KILL_SWITCH.Location = New Point(364, 358)
        KILL_SWITCH.Name = "KILL_SWITCH"
        KILL_SWITCH.Size = New Size(58, 38)
        KILL_SWITCH.TabIndex = 9
        KILL_SWITCH.Text = "KILL SWITCH"
        KILL_SWITCH.UseVisualStyleBackColor = False
        ' 
        ' PANEL_LOCK
        ' 
        PANEL_LOCK.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        PANEL_LOCK.Controls.Add(LOCK_UNLOCK)
        PANEL_LOCK.Controls.Add(LOCK_TEXT)
        PANEL_LOCK.Controls.Add(LOCK_LABEL)
        PANEL_LOCK.Location = New Point(-9, 55)
        PANEL_LOCK.Name = "PANEL_LOCK"
        PANEL_LOCK.Size = New Size(452, 390)
        PANEL_LOCK.TabIndex = 132
        ' 
        ' LOCK_UNLOCK
        ' 
        LOCK_UNLOCK.BackColor = Color.Brown
        LOCK_UNLOCK.FlatAppearance.BorderSize = 2
        LOCK_UNLOCK.FlatAppearance.MouseDownBackColor = Color.IndianRed
        LOCK_UNLOCK.FlatAppearance.MouseOverBackColor = Color.Firebrick
        LOCK_UNLOCK.FlatStyle = FlatStyle.Flat
        LOCK_UNLOCK.Font = New Font("Bahnschrift", 12F, FontStyle.Bold)
        LOCK_UNLOCK.ForeColor = Color.White
        LOCK_UNLOCK.Location = New Point(186, 214)
        LOCK_UNLOCK.Name = "LOCK_UNLOCK"
        LOCK_UNLOCK.Size = New Size(82, 38)
        LOCK_UNLOCK.TabIndex = 2
        LOCK_UNLOCK.Text = "UNLOCK"
        LOCK_UNLOCK.UseVisualStyleBackColor = False
        ' 
        ' LOCK_TEXT
        ' 
        LOCK_TEXT.Font = New Font("Bahnschrift", 14F)
        LOCK_TEXT.Location = New Point(118, 168)
        LOCK_TEXT.Name = "LOCK_TEXT"
        LOCK_TEXT.Size = New Size(223, 30)
        LOCK_TEXT.TabIndex = 1
        LOCK_TEXT.TextAlign = HorizontalAlignment.Center
        LOCK_TEXT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        LOCK_TEXT.UseSystemPasswordChar = True
        ' 
        ' LOCK_LABEL
        ' 
        LOCK_LABEL.AutoSize = True
        LOCK_LABEL.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        LOCK_LABEL.Font = New Font("Bahnschrift Condensed", 16F, FontStyle.Bold)
        LOCK_LABEL.ForeColor = Color.White
        LOCK_LABEL.Location = New Point(195, 131)
        LOCK_LABEL.Name = "LOCK_LABEL"
        LOCK_LABEL.Size = New Size(68, 27)
        LOCK_LABEL.TabIndex = 133
        LOCK_LABEL.Text = "LOCKED:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        ClientSize = New Size(434, 436)
        Controls.Add(PANEL_LOCK)
        Controls.Add(KILL_SWITCH)
        Controls.Add(PANEL_PROC_LOAD)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(BTN_START)
        Controls.Add(PictureBox1)
        Controls.Add(OUT_TIMER_LABEL)
        Controls.Add(OUT_TIMER)
        Controls.Add(SCN_EXCEL2)
        Controls.Add(SCN_NOTEPAD2)
        Controls.Add(SCN_SELF2)
        Controls.Add(PictureBox7)
        Controls.Add(IN_INTERVAL)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(IN_DURATION)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Controls.Add(PictureBox8)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PANEL_PROC_LOAD.ResumeLayout(False)
        PANEL_LOCK.ResumeLayout(False)
        PANEL_LOCK.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents IN_DURATION As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents IN_INTERVAL As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SCN_SELF2 As CheckBox
    Friend WithEvents SCN_NOTEPAD2 As CheckBox
    Friend WithEvents SCN_EXCEL2 As CheckBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents OUT_TIMER As Label
    Friend WithEvents OUT_TIMER_LABEL As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_START As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PANEL_PROC_LOAD As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents KILL_SWITCH As Button
    Friend WithEvents PANEL_LOCK As Panel
    Friend WithEvents LOCK_TEXT As MaskedTextBox
    Friend WithEvents LOCK_LABEL As Label
    Friend WithEvents LOCK_UNLOCK As Button

End Class
