Public Class mainmenu
    Dim i_DesktopHeight As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_DesktopWidth As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_FadeInFlag As Boolean = True 'フォームフェードイン用の関数の宣言
    Sub button_location() 'ボタンの位置
        Jisyo_button.Left = i_DesktopWidth / 2 - Mensetsu_button.Size.Width / 2 + 200
        Jisyo_button.Top = i_DesktopHeight / 2 - Mensetsu_button.Size.Height / 2
        Mensetsu_button.Left = i_DesktopWidth / 2 - Mensetsu_button.Size.Width / 2 - 200
        Mensetsu_button.Top = i_DesktopHeight / 2 - Mensetsu_button.Size.Height / 2
    End Sub

    Private Sub mainmenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'フォームを閉じた時の処理
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'フォームを読み込んだとき時の処理
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

    ''ボタンをクリックorタップ（マウスダウン）した時の処理ここから
    Private Sub back_MouseDown(sender As Object, e As MouseEventArgs) Handles back.MouseDown '閉じる
        back.Image = My.Resources.end_hover
    End Sub

    Private Sub Jisyo_button_MouseDown(sender As Object, e As MouseEventArgs) Handles Jisyo_button.MouseDown '辞書
        Jisyo_button.Image = My.Resources.jisyo_hover
    End Sub

    Private Sub Mensetsu_button_MouseDown(sender As Object, e As MouseEventArgs) Handles Mensetsu_button.MouseDown '面接
        Mensetsu_button.Image = My.Resources.mensetsu_hover
    End Sub
    ''ボタンをクリックorタップ（マウスダウン）した時の処理ここまで

    ''ボタンをクリックして離した時の処理ここから
    Private Sub back_MouseUp(sender As Object, e As MouseEventArgs) Handles back.MouseUp '閉じる
        back.Image = My.Resources._end
    End Sub

    Private Sub Jisyo_button_MouseUp(sender As Object, e As MouseEventArgs) Handles Jisyo_button.MouseUp '辞書
        Jisyo_button.Image = My.Resources.jisyo
    End Sub

    Private Sub Mensetsu_button_MouseUp(sender As Object, e As MouseEventArgs) Handles Mensetsu_button.MouseUp '面接
        Mensetsu_button.Image = My.Resources.mensetsu
    End Sub
    ''ボタンをクリックして離した時の処理ここまで

    ''ボタンをクリックorタップ（標準）した時の処理ここから
    Private Sub back_click(sender As Object, e As MouseEventArgs) Handles back.Click '閉じる
        Me.Close()
        Title.Close()
    End Sub

    Private Sub Jisyo_button_click(sender As Object, e As MouseEventArgs) Handles Jisyo_button.Click '辞書
        dictionary.Show()
    End Sub

    Private Sub Mensetsu_button_click(sender As Object, e As MouseEventArgs) Handles Mensetsu_button.Click '面接
        mensetsu_menu.Show()
    End Sub
    ''ボタンをクリックorタップ（標準）した時の処理ここまで
End Class
