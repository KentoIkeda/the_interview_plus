<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.Mensetsu_button = New System.Windows.Forms.PictureBox()
        Me.Jisyo_button = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Mensetsu_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jisyo_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mensetsu_button
        '
        Me.Mensetsu_button.BackColor = System.Drawing.Color.Transparent
        Me.Mensetsu_button.Image = Global.MainMenu.My.Resources.Resources.mensetsu
        Me.Mensetsu_button.Location = New System.Drawing.Point(0, 0)
        Me.Mensetsu_button.Name = "Mensetsu_button"
        Me.Mensetsu_button.Size = New System.Drawing.Size(320, 150)
        Me.Mensetsu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mensetsu_button.TabIndex = 0
        Me.Mensetsu_button.TabStop = False
        '
        'Jisyo_button
        '
        Me.Jisyo_button.BackColor = System.Drawing.Color.Transparent
        Me.Jisyo_button.Image = Global.MainMenu.My.Resources.Resources.jisyo
        Me.Jisyo_button.Location = New System.Drawing.Point(0, 0)
        Me.Jisyo_button.Name = "Jisyo_button"
        Me.Jisyo_button.Size = New System.Drawing.Size(320, 150)
        Me.Jisyo_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jisyo_button.TabIndex = 1
        Me.Jisyo_button.TabStop = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Image = Global.MainMenu.My.Resources.Resources._end
        Me.back.Location = New System.Drawing.Point(0, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(320, 150)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back.TabIndex = 3
        Me.back.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MainMenu.My.Resources.Resources.mainmenu_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Jisyo_button)
        Me.Controls.Add(Me.Mensetsu_button)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainmenu"
        Me.ShowInTaskbar = False
        Me.Text = "メインメニュー"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Mensetsu_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jisyo_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mensetsu_button As System.Windows.Forms.PictureBox
    Friend WithEvents Jisyo_button As System.Windows.Forms.PictureBox
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
