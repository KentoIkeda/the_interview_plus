<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dictionary))
        Me.Title = New System.Windows.Forms.Label()
        Me.Button_modoki_1 = New System.Windows.Forms.Label()
        Me.Button_modoki_2 = New System.Windows.Forms.Label()
        Me.Button_modoki_3 = New System.Windows.Forms.Label()
        Me.Button_modoki_4 = New System.Windows.Forms.Label()
        Me.Button_modoki_5 = New System.Windows.Forms.Label()
        Me.Button_modoki_6 = New System.Windows.Forms.Label()
        Me.Button_modoki_7 = New System.Windows.Forms.Label()
        Me.Hyouji_basyo = New System.Windows.Forms.WebBrowser()
        Me.description = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.kakusu_button = New System.Windows.Forms.PictureBox()
        Me.formback = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kakusu_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(187, 62)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(385, 60)
        Me.Title.TabIndex = 0
        Me.Title.Text = "面接総合辞典"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_1
        '
        Me.Button_modoki_1.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_1.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_1.Location = New System.Drawing.Point(100, 160)
        Me.Button_modoki_1.Name = "Button_modoki_1"
        Me.Button_modoki_1.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_1.TabIndex = 1
        Me.Button_modoki_1.Text = "敬語の基本"
        Me.Button_modoki_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_2
        '
        Me.Button_modoki_2.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_2.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_2.Location = New System.Drawing.Point(100, 240)
        Me.Button_modoki_2.Name = "Button_modoki_2"
        Me.Button_modoki_2.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_2.TabIndex = 2
        Me.Button_modoki_2.Text = "アルバイト敬語"
        Me.Button_modoki_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_3
        '
        Me.Button_modoki_3.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_3.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_3.Location = New System.Drawing.Point(100, 320)
        Me.Button_modoki_3.Name = "Button_modoki_3"
        Me.Button_modoki_3.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_3.TabIndex = 3
        Me.Button_modoki_3.Text = "「ら」抜き・「れ」入れ言葉"
        Me.Button_modoki_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_4
        '
        Me.Button_modoki_4.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_4.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_4.Location = New System.Drawing.Point(100, 400)
        Me.Button_modoki_4.Name = "Button_modoki_4"
        Me.Button_modoki_4.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_4.TabIndex = 4
        Me.Button_modoki_4.Text = "身だしなみの基本"
        Me.Button_modoki_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_5
        '
        Me.Button_modoki_5.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_5.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_5.Location = New System.Drawing.Point(100, 480)
        Me.Button_modoki_5.Name = "Button_modoki_5"
        Me.Button_modoki_5.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_5.TabIndex = 5
        Me.Button_modoki_5.Text = "髪型（男性）"
        Me.Button_modoki_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_6
        '
        Me.Button_modoki_6.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_6.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_6.Location = New System.Drawing.Point(100, 560)
        Me.Button_modoki_6.Name = "Button_modoki_6"
        Me.Button_modoki_6.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_6.TabIndex = 6
        Me.Button_modoki_6.Text = "髪型（女性）"
        Me.Button_modoki_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_modoki_7
        '
        Me.Button_modoki_7.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 20.25!)
        Me.Button_modoki_7.ForeColor = System.Drawing.Color.Black
        Me.Button_modoki_7.Location = New System.Drawing.Point(100, 640)
        Me.Button_modoki_7.Name = "Button_modoki_7"
        Me.Button_modoki_7.Size = New System.Drawing.Size(293, 80)
        Me.Button_modoki_7.TabIndex = 7
        Me.Button_modoki_7.Text = "入退室の基本"
        Me.Button_modoki_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hyouji_basyo
        '
        Me.Hyouji_basyo.Location = New System.Drawing.Point(399, 160)
        Me.Hyouji_basyo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Hyouji_basyo.Name = "Hyouji_basyo"
        Me.Hyouji_basyo.Size = New System.Drawing.Size(568, 513)
        Me.Hyouji_basyo.TabIndex = 8
        Me.Hyouji_basyo.Url = New System.Uri("", System.UriKind.Relative)
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.description.ForeColor = System.Drawing.Color.Black
        Me.description.Location = New System.Drawing.Point(393, 122)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(0, 35)
        Me.description.TabIndex = 9
        Me.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox7.Location = New System.Drawing.Point(44, 640)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox6.Location = New System.Drawing.Point(44, 560)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox4.Location = New System.Drawing.Point(44, 400)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox2.Location = New System.Drawing.Point(44, 240)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox5.Location = New System.Drawing.Point(44, 480)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox3.Location = New System.Drawing.Point(44, 320)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MainMenu.My.Resources.Resources.listicon
        Me.PictureBox1.Location = New System.Drawing.Point(44, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 80)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'kakusu_button
        '
        Me.kakusu_button.Location = New System.Drawing.Point(578, 63)
        Me.kakusu_button.Name = "kakusu_button"
        Me.kakusu_button.Size = New System.Drawing.Size(113, 60)
        Me.kakusu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kakusu_button.TabIndex = 11
        Me.kakusu_button.TabStop = False
        '
        'formback
        '
        Me.formback.Image = Global.MainMenu.My.Resources.Resources.back_dictionary
        Me.formback.Location = New System.Drawing.Point(44, 62)
        Me.formback.Name = "formback"
        Me.formback.Size = New System.Drawing.Size(137, 61)
        Me.formback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.formback.TabIndex = 10
        Me.formback.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'dictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 781)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.kakusu_button)
        Me.Controls.Add(Me.formback)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.Hyouji_basyo)
        Me.Controls.Add(Me.Button_modoki_7)
        Me.Controls.Add(Me.Button_modoki_5)
        Me.Controls.Add(Me.Button_modoki_3)
        Me.Controls.Add(Me.Button_modoki_6)
        Me.Controls.Add(Me.Button_modoki_4)
        Me.Controls.Add(Me.Button_modoki_2)
        Me.Controls.Add(Me.Button_modoki_1)
        Me.Controls.Add(Me.Title)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dictionary"
        Me.ShowInTaskbar = False
        Me.Text = "面接総合辞典"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kakusu_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_1 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_2 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_3 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_4 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_5 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_6 As System.Windows.Forms.Label
    Friend WithEvents Button_modoki_7 As System.Windows.Forms.Label
    Friend WithEvents Hyouji_basyo As System.Windows.Forms.WebBrowser
    Friend WithEvents description As System.Windows.Forms.Label
    Friend WithEvents formback As System.Windows.Forms.PictureBox
    Friend WithEvents kakusu_button As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
