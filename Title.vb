Public Class Title
    Dim i_Count As Integer = 0 'タイマー用の関数の宣言
    Dim i_FadeInFlag As Boolean = True'フォームフェードイン用の関数の宣言

    Private Sub Title_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'フォームロード時の宣言
        Me.Opacity = 0
    End Sub
    Private Sub Title_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i_Count = i_Count + 1
        If i_Count = 3 Then
            mainmenu.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
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