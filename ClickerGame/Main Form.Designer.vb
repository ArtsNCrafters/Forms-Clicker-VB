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
        Me.webDecor3 = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkDecor3 = New System.Windows.Forms.LinkLabel()
        Me.rbtDecor4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(409, 79)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpgrade1
        '
        Me.btnUpgrade1.Location = New System.Drawing.Point(342, 235)
        Me.btnUpgrade1.Name = "btnUpgrade1"
        Me.btnUpgrade1.Size = New System.Drawing.Size(84, 41)
        Me.btnUpgrade1.TabIndex = 2
        Me.btnUpgrade1.Text = "&Upgrade: 100 clicks"
        Me.btnUpgrade1.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(341, 186)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(84, 47)
        Me.btnRandom.TabIndex = 3
        Me.btnRandom.Text = "&Random Decor: 1000 clicks"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblDecor
        '
        Me.lblDecor.AutoSize = True
        Me.lblDecor.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblDecor.Location = New System.Drawing.Point(159, 40)
        Me.lblDecor.Name = "lblDecor"
        Me.lblDecor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDecor.Size = New System.Drawing.Size(115, 13)
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
        Me.Timer1.Interval = 10
        '
        'btnDev
        '
        Me.btnDev.Location = New System.Drawing.Point(350, 9)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(75, 23)
        Me.btnDev.TabIndex = 6
        Me.btnDev.Text = "Dev"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'dtpDecor2
        '
        Me.dtpDecor2.Location = New System.Drawing.Point(17, 254)
        Me.dtpDecor2.Name = "dtpDecor2"
        Me.dtpDecor2.Size = New System.Drawing.Size(200, 20)
        Me.dtpDecor2.TabIndex = 7
        Me.dtpDecor2.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDecor2.Visible = False
        '
        'webDecor3
        '
        Me.webDecor3.Location = New System.Drawing.Point(17, 167)
        Me.webDecor3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webDecor3.Name = "webDecor3"
        Me.webDecor3.ScriptErrorsSuppressed = True
        Me.webDecor3.Size = New System.Drawing.Size(110, 66)
        Me.webDecor3.TabIndex = 8
        Me.webDecor3.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        Me.webDecor3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(0, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "click me to fullscreen"
        Me.Label2.Visible = False
        '
        'lnkDecor3
        '
        Me.lnkDecor3.AutoSize = True
        Me.lnkDecor3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lnkDecor3.LinkColor = System.Drawing.Color.Navy
        Me.lnkDecor3.Location = New System.Drawing.Point(0, 361)
        Me.lnkDecor3.Name = "lnkDecor3"
        Me.lnkDecor3.Size = New System.Drawing.Size(206, 13)
        Me.lnkDecor3.TabIndex = 10
        Me.lnkDecor3.TabStop = True
        Me.lnkDecor3.Text = "if you get to a blocked website ur screwed"
        Me.lnkDecor3.Visible = False
        Me.lnkDecor3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'rbtDecor4
        '
        Me.rbtDecor4.AutoSize = True
        Me.rbtDecor4.Checked = True
        Me.rbtDecor4.Location = New System.Drawing.Point(17, 144)
        Me.rbtDecor4.Name = "rbtDecor4"
        Me.rbtDecor4.Size = New System.Drawing.Size(83, 17)
        Me.rbtDecor4.TabIndex = 11
        Me.rbtDecor4.TabStop = True
        Me.rbtDecor4.Text = "Background"
        Me.rbtDecor4.UseVisualStyleBackColor = True
        Me.rbtDecor4.Visible = False
        '
        'frmClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(438, 387)
        Me.Controls.Add(Me.rbtDecor4)
        Me.Controls.Add(Me.lnkDecor3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.webDecor3)
        Me.Controls.Add(Me.dtpDecor2)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.pgbDecor1)
        Me.Controls.Add(Me.lblDecor)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnUpgrade1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClicker"
        Me.Text = "Clicker Game"
        Me.TransparencyKey = System.Drawing.SystemColors.Menu
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
    Friend WithEvents webDecor3 As WebBrowser
    Friend WithEvents Label2 As Label
    Friend WithEvents lnkDecor3 As LinkLabel
    Friend WithEvents rbtDecor4 As RadioButton
End Class
