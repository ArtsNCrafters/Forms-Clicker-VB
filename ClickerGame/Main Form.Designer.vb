﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClicker
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClicker))
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
        Me.txtDecor5 = New System.Windows.Forms.TextBox()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.picGlag = New System.Windows.Forms.PictureBox()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(409, 79)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Click"
        Me.totGlag.SetToolTip(Me.Button1, "you use this to click :)")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpgrade1
        '
        Me.btnUpgrade1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade1.Location = New System.Drawing.Point(342, 235)
        Me.btnUpgrade1.Name = "btnUpgrade1"
        Me.btnUpgrade1.Size = New System.Drawing.Size(84, 41)
        Me.btnUpgrade1.TabIndex = 2
        Me.btnUpgrade1.Text = "&Upgrade: 100 clicks"
        Me.btnUpgrade1.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.Location = New System.Drawing.Point(341, 186)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(84, 47)
        Me.btnRandom.TabIndex = 3
        Me.btnRandom.Text = "&Random Decor: 1000 clicks"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblDecor
        '
        Me.lblDecor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDecor.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblDecor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecor.Location = New System.Drawing.Point(18, 44)
        Me.lblDecor.Name = "lblDecor"
        Me.lblDecor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDecor.Size = New System.Drawing.Size(122, 51)
        Me.lblDecor.TabIndex = 4
        Me.lblDecor.Text = "You got a decoration :)"
        Me.lblDecor.Visible = False
        '
        'pgbDecor1
        '
        Me.pgbDecor1.Location = New System.Drawing.Point(17, 280)
        Me.pgbDecor1.Name = "pgbDecor1"
        Me.pgbDecor1.Size = New System.Drawing.Size(409, 10)
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
        Me.btnDev.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDev.Location = New System.Drawing.Point(350, 9)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(75, 23)
        Me.btnDev.TabIndex = 6
        Me.btnDev.Text = "Dev"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'dtpDecor2
        '
        Me.dtpDecor2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDecor2.Location = New System.Drawing.Point(17, 254)
        Me.dtpDecor2.Name = "dtpDecor2"
        Me.dtpDecor2.Size = New System.Drawing.Size(200, 23)
        Me.dtpDecor2.TabIndex = 7
        Me.dtpDecor2.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDecor2.Visible = False
        '
        'rbtDecor4
        '
        Me.rbtDecor4.AutoSize = True
        Me.rbtDecor4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDecor4.Location = New System.Drawing.Point(17, 98)
        Me.rbtDecor4.Name = "rbtDecor4"
        Me.rbtDecor4.Size = New System.Drawing.Size(81, 19)
        Me.rbtDecor4.TabIndex = 11
        Me.rbtDecor4.Text = "Dark Mode"
        Me.rbtDecor4.UseVisualStyleBackColor = True
        Me.rbtDecor4.Visible = False
        '
        'rbtDecor42
        '
        Me.rbtDecor42.AutoSize = True
        Me.rbtDecor42.Checked = True
        Me.rbtDecor42.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDecor42.Location = New System.Drawing.Point(17, 121)
        Me.rbtDecor42.Name = "rbtDecor42"
        Me.rbtDecor42.Size = New System.Drawing.Size(82, 19)
        Me.rbtDecor42.TabIndex = 12
        Me.rbtDecor42.TabStop = True
        Me.rbtDecor42.Text = "Light Mode"
        Me.rbtDecor42.UseVisualStyleBackColor = True
        Me.rbtDecor42.Visible = False
        '
        'rbtDecor43
        '
        Me.rbtDecor43.AutoSize = True
        Me.rbtDecor43.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDecor43.Location = New System.Drawing.Point(17, 144)
        Me.rbtDecor43.Name = "rbtDecor43"
        Me.rbtDecor43.Size = New System.Drawing.Size(142, 19)
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
        'txtDecor5
        '
        Me.txtDecor5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDecor5.Font = New System.Drawing.Font("Wingdings 3", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtDecor5.Location = New System.Drawing.Point(326, 160)
        Me.txtDecor5.Name = "txtDecor5"
        Me.txtDecor5.Size = New System.Drawing.Size(100, 20)
        Me.txtDecor5.TabIndex = 15
        Me.txtDecor5.Visible = False
        '
        'picBook
        '
        Me.picBook.Image = Global.ClickerGame.My.Resources.Resources.book_icon
        Me.picBook.Location = New System.Drawing.Point(326, 40)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(100, 100)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBook.TabIndex = 16
        Me.picBook.TabStop = False
        Me.totGlag.SetToolTip(Me.picBook, "woah, you found my scrapbook! open it if you want.")
        Me.picBook.Visible = False
        '
        'picGlag
        '
        Me.picGlag.Image = Global.ClickerGame.My.Resources.Resources.gigglridle
        Me.picGlag.Location = New System.Drawing.Point(17, 167)
        Me.picGlag.Name = "picGlag"
        Me.picGlag.Size = New System.Drawing.Size(135, 81)
        Me.picGlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGlag.TabIndex = 14
        Me.picGlag.TabStop = False
        Me.totGlag.SetToolTip(Me.picGlag, "testing testing hai chat :))")
        Me.picGlag.Visible = False
        '
        'frmClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 387)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.txtDecor5)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(454, 426)
        Me.MinimumSize = New System.Drawing.Size(454, 426)
        Me.Name = "frmClicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clicker Game"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtDecor5 As TextBox
    Friend WithEvents picBook As PictureBox
End Class
