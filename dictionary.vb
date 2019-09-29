Public Class dictionary
    Dim i_DesktopHeight As Integer '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_DesktopWidth As Integer '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_CurrentDirectory As String = System.IO.Directory.GetCurrentDirectory() 'カレントディレクトリを取得するための宣言
    Dim i_nowopendocumentnumber As Integer '現在開いてる項目はどれか取得し識別させる為の関数の宣言
    Dim i_url As String
    Dim i_kakusiurl As String '穴埋め学習モード用のURLに変更する際の関数の宣言
    Dim i_image_hyouji As Image
    Dim i_image_hyouji_hover As Image
    Dim i_image_kakusu As Image
    Dim i_image_kakusu_hover As Image
    Dim i_FadeInFlag As Boolean = True 'フォームフェードイン用の関数の宣言
    ''<!-------- ↓各サブプロシージャここから↓ -------->
    Private Sub Syoki() '初期処理
        i_nowopendocumentnumber = 0
        i_url = "\html\syoki.html"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url)
        description.Text = "ようこそ!左から見たい項目を選んでください"
    End Sub

    Private Sub keigo_kihon() '敬語の基本
        i_nowopendocumentnumber = 1
        i_url = "\html\keigo_kihon"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "敬語の基本"
    End Sub

    Private Sub keigo_baito() 'アルバイト敬語
        i_nowopendocumentnumber = 2
        i_url = "\html\keigo_baito"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "アルバイト敬語"
    End Sub

    Private Sub ranuki_reire() '「ら」抜き言葉・「れ」入れ言葉
        i_nowopendocumentnumber = 3
        i_url = "\html\ranuki_reire"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "「ら」抜き言葉・「れ」入れ言葉"
    End Sub

    Private Sub midasinami_kihon() '身だしなみの基本
        i_nowopendocumentnumber = 4
        i_url = "\html\midasinami_kihon"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "身だしなみの基本"
    End Sub

    Private Sub kamigata_male() '髪型（男性）
        i_nowopendocumentnumber = 5
        i_url = "\html\kamigata_male"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "髪型（男性）"
    End Sub

    Private Sub kamigata_girl() '髪型（女性）
        i_nowopendocumentnumber = 6
        i_url = "\html\kamigata_girl"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "髪型（女性）"
    End Sub

    Private Sub nyuutaisitu_kihon() '入退室の基本
        i_nowopendocumentnumber = 7
        i_url = "\html\nyuutaisitu_kihon"
        Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
        description.Text = "入退室の基本"
    End Sub
    ''<!-------- ↑各サブプロシージャここまで↑ -------->

    Private Sub dictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'フォームを読み込んだ時の処理
        i_DesktopWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        i_DesktopHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        Hyouji_basyo.Width = i_DesktopWidth - Hyouji_basyo.Location.X
        Hyouji_basyo.Height = i_DesktopHeight - Hyouji_basyo.Location.Y
        Syoki()
        i_image_hyouji = My.Resources.hyouji
        i_image_hyouji_hover = My.Resources.hyouji_hover
        i_image_kakusu = My.Resources.kakusu
        i_image_kakusu_hover = My.Resources.kakusu_hover
        kakusu_button.Image = i_image_kakusu
        Me.Opacity = 0
    End Sub

    Private Sub dictionary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'フォームを閉じた時の処理
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'フェードイン用タイマー処理
        Select Case i_FadeInFlag
            Case True
                If Me.Opacity = 100 Then
                    Timer1.Enabled = False
                Else
                    Me.Opacity = Me.Opacity + 0.05F
                End If
            Case Else
                If Me.Opacity = 0 Then
                    Timer1.Enabled = False
                    Me.Dispose()
                Else
                    Me.Opacity = Me.Opacity - 0.05F
                End If
        End Select
    End Sub

    ''<!-------- ↓マウスをクリックした時の各ボタンorボタンもどき（ラベル）のスタイル変異ここから↓ -------->
    Private Sub Button_modoki_1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_1.MouseDown 'ボタンもどき1
        Button_modoki_1.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_2.MouseDown 'ボタンもどき2
        Button_modoki_2.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_3.MouseDown 'ボタンもどき3
        Button_modoki_3.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_4.MouseDown 'ボタンもどき4
        Button_modoki_4.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_5.MouseDown 'ボタンもどき5
        Button_modoki_5.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_6.MouseDown 'ボタンもどき6
        Button_modoki_6.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Button_modoki_7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_modoki_7.MouseDown 'ボタンもどき7
        Button_modoki_7.BackColor = Color.FromArgb(&HD0, &HD0, &HD0)
    End Sub

    Private Sub Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Title.MouseDown 'タイトル
        Title.ForeColor = Color.FromArgb(&H4D, &H4D, &H4D)
    End Sub

    Private Sub formback_MouseDown(sender As Object, e As MouseEventArgs) Handles formback.MouseDown '戻る
        formback.Image = My.Resources.back_dictionary_hover
    End Sub

    Private Sub kakusu_button_MouseDown(sender As Object, e As MouseEventArgs) Handles kakusu_button.MouseDown '隠すor表示する
        If kakusu_button.Image Is i_image_hyouji Then
            kakusu_button.Image = i_image_hyouji_hover
        Else
            kakusu_button.Image = i_image_kakusu_hover
        End If
    End Sub
    ''<!-------- ↑マウスをクリックした時の各ボタンorボタンもどき（ラベル）のスタイル変異ここまで↑ -------->

    ''<!-------- ↓マウスをクリックして離した直後の各ボタンorボタンもどき（ラベル）のスタイル変異ここから↓ -------->
    Private Sub Button_modoki_1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_1.MouseUp 'ボタンもどき1
        Button_modoki_1.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_2.MouseUp 'ボタンもどき2
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_3.MouseUp 'ボタンもどき3
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_4_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_4.MouseUp  'ボタンもどき4
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_5_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_5.MouseUp 'ボタンもどき5
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_6_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_6.MouseUp 'ボタンもどき6
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub Button_modoki_7_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_modoki_7.MouseUp 'ボタンもどき7
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HAD, &HAD, &HAD)
    End Sub

    Private Sub Title_MouseUp(sender As Object, e As MouseEventArgs) Handles Title.MouseUp 'タイトル
        Title.ForeColor = Color.FromArgb(&H0, &H0, &H0)
        Button_modoki_1.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_2.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_3.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_4.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_5.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_6.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
        Button_modoki_7.BackColor = Color.FromArgb(&HF4, &HF4, &HF4)
    End Sub

    Private Sub formback_MouseUp(sender As Object, e As MouseEventArgs) Handles formback.MouseUp '戻る
        formback.Image = My.Resources.back_dictionary
    End Sub

    Private Sub kakusu_button_MouseUp(sender As Object, e As MouseEventArgs) Handles kakusu_button.MouseUp '隠すor表示する
        If kakusu_button.Image Is i_image_hyouji_hover Then
            kakusu_button.Image = i_image_kakusu
        Else
            kakusu_button.Image = i_image_hyouji
        End If

        If kakusu_button.Image Is i_image_hyouji Then
            If i_nowopendocumentnumber = 0 Then
                i_kakusiurl = "_k"
                MsgBox("ページ上の太字部分が隠されて表示されます。" & vbCrLf & "元の状態に戻す場合は、「隠した部分を表示する」をクリックorタップしてください。")
            Else
                i_kakusiurl = "_k"
                Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
                MsgBox("ページ上の太字部分が隠されて表示されます。" & vbCrLf & "現在閲覧中のページは自動的に更新されます。" & vbCrLf & "元の状態に戻す場合は、「隠した部分を表示する」をクリックorタップしてください。")
            End If
        Else
            If i_nowopendocumentnumber = 0 Then
                i_kakusiurl = ""
                MsgBox("ページが通常の状態に戻されます。" & vbCrLf & "太字の重要部分を隠して表示する場合は、「太字部分を隠す」をクリックorタップしてください。")
            Else
                i_kakusiurl = ""
                Hyouji_basyo.Url = New Uri(i_CurrentDirectory.ToString & i_url & i_kakusiurl & ".html")
                MsgBox("ページが通常の状態に戻されます。" & vbCrLf & "現在閲覧中のページは自動的に更新されます。" & vbCrLf & "太字の重要部分を隠して表示する場合は、「太字部分を隠す」をクリックorタップしてください。")
            End If
        End If
    End Sub
    ''<!-------- ↑マウスをクリックして離した直後の各ボタンorボタンもどき（ラベル）のスタイル変異ここまで↑ -------->

    ''<!-------- ↓ボタンorボタンもどきをクリックした時の処理ここから↓ -------->
    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        Syoki()
    End Sub

    Private Sub Button_modoki_1_Click(sender As Object, e As EventArgs) Handles Button_modoki_1.Click
        keigo_kihon()
    End Sub

    Private Sub Button_modoki_2_Click(sender As Object, e As EventArgs) Handles Button_modoki_2.Click
        keigo_baito()
    End Sub

    Private Sub Button_modoki_3_Click(sender As Object, e As EventArgs) Handles Button_modoki_3.Click
        ranuki_reire()
    End Sub

    Private Sub Button_modoki_4_Click(sender As Object, e As EventArgs) Handles Button_modoki_4.Click
        midasinami_kihon()
    End Sub

    Private Sub Button_modoki_5_Click(sender As Object, e As EventArgs) Handles Button_modoki_5.Click
        kamigata_male()
    End Sub

    Private Sub Button_modoki_6_Click(sender As Object, e As EventArgs) Handles Button_modoki_6.Click
        kamigata_girl()
    End Sub

    Private Sub Button_modoki_7_Click(sender As Object, e As EventArgs) Handles Button_modoki_7.Click
        nyuutaisitu_kihon()
    End Sub

    Private Sub formback_Click(sender As Object, e As EventArgs) Handles formback.Click
        Me.Close()
    End Sub
    ''<!-------- ↑ボタンorボタンもどきをクリックした時の処理ここまで↑ -------->
End Class
