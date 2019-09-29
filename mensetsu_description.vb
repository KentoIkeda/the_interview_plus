Public Class mensetsu_description
    Dim i_DesktopHeight As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_DesktopWidth As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width '画面の解像度（縦）の長さの数値を入れるための関数の宣言
    Dim i_setsumei1 As Image = My.Resources.mensetsu_setumei_1 '説明の背景画像が入ってる変数の宣言
    Dim i_setsumei2 As Image = My.Resources.mensetsu_setumei_2 '説明の背景画像が入ってる変数の宣言
    Dim i_setsumei3 As Image = My.Resources.mensetsu_setumei_3 '説明の背景画像が入ってる変数の宣言
    Dim i_FadeInFlag As Boolean = True'フォームフェードイン用の関数の宣言
    Sub Button_location()
        back.Left = 0
        back.Top = 0
        skip.Left = i_DesktopWidth - skip.Size.Width
        skip.Top = 0
        tugihe.Left = i_DesktopWidth - tugihe.Size.Width
        tugihe.Top = i_DesktopHeight - tugihe.Size.Height
    End Sub

    Private Sub mensetsu_description_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = i_setsumei1
        Me.Opacity = 0
        Button_location()
    End Sub

    Private Sub mensetsu_description_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub

    Private Sub tugihe_Click(sender As Object, e As EventArgs) Handles tugihe.Click
        If Me.BackgroundImage Is i_setsumei1 Then
            Me.BackgroundImage = i_setsumei2
        ElseIf Me.BackgroundImage Is i_setsumei2 Then
            Me.BackgroundImage = i_setsumei3
        ElseIf Me.BackgroundImage Is i_setsumei3 Then
            mensetu.Show()
        End If
    End Sub

    Private Sub tugihe_MouseDown(sender As Object, e As MouseEventArgs) Handles tugihe.MouseDown
        tugihe.Image = My.Resources.next_hover
    End Sub

    Private Sub tugihe_MouseUp(sender As Object, e As MouseEventArgs) Handles tugihe.MouseUp
        tugihe.Image = My.Resources._next
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If Me.BackgroundImage Is i_setsumei3 Then
            Me.BackgroundImage = i_setsumei2
        ElseIf Me.BackgroundImage Is i_setsumei2 Then
            Me.BackgroundImage = i_setsumei1
        ElseIf Me.BackgroundImage Is i_setsumei1 Then
            Me.Close()
        End If
    End Sub

    Private Sub back_MouseDown(sender As Object, e As MouseEventArgs) Handles back.MouseDown
        back.Image = My.Resources.back_hover
    End Sub

    Private Sub back_MouseUp(sender As Object, e As MouseEventArgs) Handles back.MouseUp
        back.Image = My.Resources.back
    End Sub

    Private Sub skip_Click(sender As Object, e As EventArgs) Handles skip.Click
        mensetu.Show()
    End Sub

    Private Sub skip_MouseDown(sender As Object, e As MouseEventArgs) Handles skip.MouseDown
        skip.Image = My.Resources.skip_hover
    End Sub

    Private Sub skip_MouseUp(sender As Object, e As MouseEventArgs) Handles skip.MouseUp
        skip.Image = My.Resources.skip
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

End Class