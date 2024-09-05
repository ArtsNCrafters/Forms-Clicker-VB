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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
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
        Me.chtDecor3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chtDecor3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'rbtDecor4
        '
        Me.rbtDecor4.AutoSize = True
        Me.rbtDecor4.Location = New System.Drawing.Point(17, 98)
        Me.rbtDecor4.Name = "rbtDecor4"
        Me.rbtDecor4.Size = New System.Drawing.Size(78, 17)
        Me.rbtDecor4.TabIndex = 11
        Me.rbtDecor4.Text = "Dark Mode"
        Me.rbtDecor4.UseVisualStyleBackColor = True
        Me.rbtDecor4.Visible = False
        '
        'rbtDecor42
        '
        Me.rbtDecor42.AutoSize = True
        Me.rbtDecor42.Checked = True
        Me.rbtDecor42.Location = New System.Drawing.Point(17, 121)
        Me.rbtDecor42.Name = "rbtDecor42"
        Me.rbtDecor42.Size = New System.Drawing.Size(78, 17)
        Me.rbtDecor42.TabIndex = 12
        Me.rbtDecor42.Text = "Light Mode"
        Me.rbtDecor42.UseVisualStyleBackColor = True
        Me.rbtDecor42.Visible = False
        '
        'rbtDecor43
        '
        Me.rbtDecor43.AutoSize = True
        Me.rbtDecor43.Location = New System.Drawing.Point(17, 144)
        Me.rbtDecor43.Name = "rbtDecor43"
        Me.rbtDecor43.Size = New System.Drawing.Size(129, 17)
        Me.rbtDecor43.TabIndex = 13
        Me.rbtDecor43.Text = "INVISIBLE MODE???"
        Me.rbtDecor43.UseVisualStyleBackColor = True
        Me.rbtDecor43.Visible = False
        '
        'chtDecor3
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtDecor3.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtDecor3.Legends.Add(Legend2)
        Me.chtDecor3.Location = New System.Drawing.Point(17, 167)
        Me.chtDecor3.Name = "chtDecor3"
        Me.chtDecor3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = ":O"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "sillys :)"
        Me.chtDecor3.Series.Add(Series3)
        Me.chtDecor3.Series.Add(Series4)
        Me.chtDecor3.Size = New System.Drawing.Size(200, 81)
        Me.chtDecor3.TabIndex = 14
        Me.chtDecor3.Text = "Chart :3"
        Title2.Name = "title"
        Title2.Text = "Number of goolies in a goober"
        Me.chtDecor3.Titles.Add(Title2)
        Me.chtDecor3.Visible = False
        '
        'frmClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 387)
        Me.Controls.Add(Me.chtDecor3)
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
        Me.Name = "frmClicker"
        Me.Text = "Clicker Game"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.chtDecor3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chtDecor3 As DataVisualization.Charting.Chart
End Class
