Public Class mensetsu_menu
    Dim i_DesktopHeight As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_DesktopWidth As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_FadeInFlag As Boolean = True 'フォームフェードイン用の関数の宣言
    Sub button_location()
        Mensetsu_play_button.Top = i_DesktopHeight / 2 - Mensetsu_play_button.Size.Height / 2
        Mensetsu_play_button.Left = i_DesktopWidth / 2 - Mensetsu_play_button.Size.Width / 2 - 260
        Mensetsu_settei_button.Top = i_DesktopHeight / 2 - Mensetsu_settei_button.Size.Height / 2
        Mensetsu_settei_button.Left = i_DesktopWidth / 2 - Mensetsu_settei_button.Size.Width / 2 + 260
    End Sub

    Private Sub mensetsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'フォームを読み込んだ時の処理
        button_location()
        Me.Opacity = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'フォームフェードイン用タイマー処理
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

    Private Sub mensetsu_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'フォームを閉じた時の処理
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub

    ''マウスをクリックorタップ（マウスダウン）したときの処理ここから
    Private Sub back_MouseDown(sender As Object, e As MouseEventArgs) Handles back.MouseDown '戻る
        back.Image = My.Resources.back_hover
    End Sub

    Private Sub Mensetsu_play_button_MouseDown(sender As Object, e As MouseEventArgs) Handles Mensetsu_play_button.MouseDown '面接する
        Mensetsu_play_button.Image = My.Resources.mensetu_play_hover
    End Sub

    Private Sub Mensetsu_settei_button_MouseDown(sender As Object, e As MouseEventArgs) Handles Mensetsu_settei_button.MouseDown '設定
        Mensetsu_settei_button.Image = My.Resources.settei_hover
    End Sub
    ''マウスをクリックorタップ（マウスダウン）したときの処理ここまで

    ''マウスをクリックorタップ（マウスダウン）したときの処理ここから
    Private Sub back_MouseUp(sender As Object, e As MouseEventArgs) Handles back.MouseUp '戻る
        back.Image = My.Resources.back
    End Sub

    Private Sub Mensetsu_play_button_MouseUp(sender As Object, e As MouseEventArgs) Handles Mensetsu_play_button.MouseUp '面接する
        Mensetsu_play_button.Image = My.Resources.mensetu_play
    End Sub

    Private Sub Mensetsu_settei_button_MouseUp(sender As Object, e As MouseEventArgs) Handles Mensetsu_settei_button.MouseUp '設定
        Mensetsu_settei_button.Image = My.Resources.settei
    End Sub
    ''マウスをクリックorタップ（マウスダウン）したときの処理ここまで

    ''マウスをクリック（標準）したときの処理ここから
    Private Sub back_click(sender As Object, e As MouseEventArgs) Handles back.Click '戻る
        Me.Close()
    End Sub

    Private Sub Mensetsu_play_button_click(sender As Object, e As MouseEventArgs) Handles Mensetsu_play_button.Click '面接する
        mensetsu_description.Show()
    End Sub

    Private Sub Mensetsu_settei_button_click(sender As Object, e As MouseEventArgs) Handles Mensetsu_settei_button.Click '設定
        mensetsu_settei.Show()
    End Sub
    ''マウスをクリック（標準）したときの処理ここまで
End Class