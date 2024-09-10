<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClicker
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpgrade1 = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblDecor = New System.Windows.Forms.Label()
        Me.pgbDecor1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDev = New System.Windows.Forms.Button()
        Me.dtpDecor2 = New System.Windows.Forms.DateTimePicker()
        Me.rbtDecor4 = New System.Windows.Forms.RadioButton()
        Me.rbtDecor42 = New System.Windows.Forms.RadioButton()
        Me.rbtDecor43 = New System.Windows.Forms.RadioButton()
        Me.totGlag = New System.Windows.Forms.ToolTip(Me.components)
        Me.picGlag = New System.Windows.Forms.PictureBox()
        CType(Me.picGlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 444)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(614, 118)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpgrade1
        '
        Me.btnUpgrade1.Location = New System.Drawing.Point(513, 352)
        Me.btnUpgrade1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpgrade1.Name = "btnUpgrade1"
        Me.btnUpgrade1.Size = New System.Drawing.Size(126, 62)
        Me.btnUpgrade1.TabIndex = 2
        Me.btnUpgrade1.Text = "&Upgrade: 100 clicks"
        Me.btnUpgrade1.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(512, 279)
        Me.btnRandom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(126, 70)
        Me.btnRandom.TabIndex = 3
        Me.btnRandom.Text = "&Random Decor: 1000 clicks"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblDecor
        '
        Me.lblDecor.AutoSize = True
        Me.lblDecor.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblDecor.Location = New System.Drawing.Point(238, 60)
        Me.lblDecor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDecor.Name = "lblDecor"
        Me.lblDecor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDecor.Size = New System.Drawing.Size(170, 20)
        Me.lblDecor.TabIndex = 4
        Me.lblDecor.Text = "You got a decoration :)"
        Me.lblDecor.Visible = False
        '
        'pgbDecor1
        '
        Me.pgbDecor1.Location = New System.Drawing.Point(26, 420)
        Me.pgbDecor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pgbDecor1.Name = "pgbDecor1"
        Me.pgbDecor1.Size = New System.Drawing.Size(614, 15)
        Me.pgbDecor1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgbDecor1.TabIndex = 5
        Me.pgbDecor1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'btnDev
        '
        Me.btnDev.Location = New System.Drawing.Point(525, 14)
        Me.btnDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(112, 34)
        Me.btnDev.TabIndex = 6
        Me.btnDev.Text = "Dev"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'dtpDecor2
        '
        Me.dtpDecor2.Location = New System.Drawing.Point(26, 381)
        Me.dtpDecor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDecor2.Name = "dtpDecor2"
        Me.dtpDecor2.Size = New System.Drawing.Size(298, 26)
        Me.dtpDecor2.TabIndex = 7
        Me.dtpDecor2.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDecor2.Visible = False
        '
        'rbtDecor4
        '
        Me.rbtDecor4.AutoSize = True
        Me.rbtDecor4.Location = New System.Drawing.Point(26, 147)
        Me.rbtDecor4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDecor4.Name = "rbtDecor4"
        Me.rbtDecor4.Size = New System.Drawing.Size(112, 24)
        Me.rbtDecor4.TabIndex = 11
        Me.rbtDecor4.Text = "Dark Mode"
        Me.rbtDecor4.UseVisualStyleBackColor = True
        Me.rbtDecor4.Visible = False
        '
        'rbtDecor42
        '
        Me.rbtDecor42.AutoSize = True
        Me.rbtDecor42.Checked = True
        Me.rbtDecor42.Location = New System.Drawing.Point(26, 182)
        Me.rbtDecor42.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDecor42.Name = "rbtDecor42"
        Me.rbtDecor42.Size = New System.Drawing.Size(113, 24)
        Me.rbtDecor42.TabIndex = 12
        Me.rbtDecor42.TabStop = True
        Me.rbtDecor42.Text = "Light Mode"
        Me.rbtDecor42.UseVisualStyleBackColor = True
        Me.rbtDecor42.Visible = False
        '
        'rbtDecor43
        '
        Me.rbtDecor43.AutoSize = True
        Me.rbtDecor43.Location = New System.Drawing.Point(26, 216)
        Me.rbtDecor43.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDecor43.Name = "rbtDecor43"
        Me.rbtDecor43.Size = New System.Drawing.Size(192, 24)
        Me.rbtDecor43.TabIndex = 13
        Me.rbtDecor43.Text = "INVISIBLE MODE???"
        Me.rbtDecor43.UseVisualStyleBackColor = True
        Me.rbtDecor43.Visible = False
        '
        'totGlag
        '
        Me.totGlag.Active = False
        Me.totGlag.AutomaticDelay = 0
        Me.totGlag.AutoPopDelay = 99999999
        Me.totGlag.InitialDelay = 0
        Me.totGlag.ReshowDelay = 0
        Me.totGlag.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.totGlag.ToolTipTitle = "Glag Says:"
        '
        'picGlag
        '
        Me.picGlag.Image = Global.ClickerGame.My.Resources.Resources.gigglridle
        Me.picGlag.Location = New System.Drawing.Point(26, 250)
        Me.picGlag.Margin = New System.Windows.Forms.Padding(4)
        Me.picGlag.Name = "picGlag"
        Me.picGlag.Size = New System.Drawing.Size(202, 122)
        Me.picGlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGlag.TabIndex = 14
        Me.picGlag.TabStop = False
        Me.totGlag.SetToolTip(Me.picGlag, "testing testing hai chat :))")
        Me.picGlag.Visible = False
        '
        'frmClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 580)
        Me.Controls.Add(Me.picGlag)
        Me.Controls.Add(Me.rbtDecor43)
        Me.Controls.Add(Me.rbtDecor42)
        Me.Controls.Add(Me.rbtDecor4)
        Me.Controls.Add(Me.dtpDecor2)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.pgbDecor1)
        Me.Controls.Add(Me.lblDecor)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnUpgrade1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClicker"
        Me.Text = "Clicker Game"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.picGlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUpgrade1 As Button
    Friend WithEvents btnRandom As Button
    Friend WithEvents lblDecor As Label
    Friend WithEvents pgbDecor1 As ProgressBar
    Friend WithEvents btnDev As Button
    Public WithEvents Timer1 As Timer
    Friend WithEvents dtpDecor2 As DateTimePicker
    Friend WithEvents rbtDecor4 As RadioButton
    Friend WithEvents rbtDecor42 As RadioButton
    Friend WithEvents rbtDecor43 As RadioButton
    Friend WithEvents picGlag As PictureBox
    Friend WithEvents totGlag As ToolTip
End Class
