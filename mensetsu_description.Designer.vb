<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mensetsu_description
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tugihe = New System.Windows.Forms.PictureBox()
        Me.skip = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tugihe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tugihe
        '
        Me.tugihe.BackColor = System.Drawing.Color.Transparent
        Me.tugihe.Image = Global.MainMenu.My.Resources.Resources._next
        Me.tugihe.Location = New System.Drawing.Point(0, 0)
        Me.tugihe.Name = "tugihe"
        Me.tugihe.Size = New System.Drawing.Size(320, 150)
        Me.tugihe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tugihe.TabIndex = 3
        Me.tugihe.TabStop = False
        '
        'skip
        '
        Me.skip.BackColor = System.Drawing.Color.Transparent
        Me.skip.Image = Global.MainMenu.My.Resources.Resources.skip
        Me.skip.Location = New System.Drawing.Point(0, 0)
        Me.skip.Name = "skip"
        Me.skip.Size = New System.Drawing.Size(320, 150)
        Me.skip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.skip.TabIndex = 2
        Me.skip.TabStop = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Image = Global.MainMenu.My.Resources.Resources.back
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(320, 150)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 0
        Me.back.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'mensetsu_description
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 416)
        Me.Controls.Add(Me.tugihe)
        Me.Controls.Add(Me.skip)
        Me.Controls.Add(Me.back)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mensetsu_description"
        Me.ShowInTaskbar = False
        Me.Text = "explanation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tugihe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents skip As System.Windows.Forms.PictureBox
    Friend WithEvents tugihe As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
