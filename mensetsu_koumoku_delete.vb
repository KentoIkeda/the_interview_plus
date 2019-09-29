Public Class mensetsu_koumoku_delete
    Const a1path As String = "oto/1csvtxt.csv"
    Const a2path As String = "oto/2csvtxt.csv"
    Dim aline As String
    Dim ag As Integer
    Dim aa() As String
    Dim adat(30, 1) As String
    Dim asyori As Integer
    Dim asentaku As String
    Dim abanti As Integer
    Dim azenbu As Integer
    Dim afilesyu As String
    Dim akubun As String
    Dim i_FadeInFlag As Boolean = True 'フォームフェードイン用の関数の宣言

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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ahb As Integer = Screen.GetWorkingArea(Me).Width   '幅
        Dim atks As Integer = Screen.GetWorkingArea(Me).Height   '高さ
        Me.Width = ahb
        Me.Height = atks
        Dim aLeftPosition As Integer = Me.Left  ' フォームの左端
        Dim aTopPosition As Integer = Me.Top    ' フォームの上端
        Me.Location = New Point(aLeftPosition, aTopPosition)
        With PictureBox1 'back
            .Image = My.Resources.back
            .Size = New System.Drawing.Size(ahb * 0.25, atks * 0.2)
            .Location = New Point(ahb * 0, atks * 0.8)
        End With

        With PictureBox2 '多くの場合
            .Image = My.Resources.situmon_ooi
            .Size = New System.Drawing.Size(ahb * 0.25, atks * 0.2)
            .Location = New Point(ahb * 0.2, atks * 0.6)
        End With
        With PictureBox3 'たまにでる
            .Image = My.Resources.situmon_tamani
            .Size = New System.Drawing.Size(ahb * 0.25, atks * 0.2)
            .Location = New Point(ahb * 0.55, atks * 0.6)
        End With '削除する
        With PictureBox4
            .Image = My.Resources.situmon_koumoku_delete
            .Size = New System.Drawing.Size(ahb * 0.25, atks * 0.2)
            .Location = New Point(ahb * 0.75, atks * 0.8)
        End With
        With ListBox1
            .Size = New System.Drawing.Size(ahb * 0.8, atks * 0.5)
            .Location = New Point(ahb * 0.1, atks * 0.1)
            .Font = New Font(ListBox1.Font.Name, 24, ListBox1.Font.Style)
        End With
        Me.Opacity = 0
    End Sub

    ''PictureBoxをクリックした時の処理ここから
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'back
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '優先度１　多くの場合出る質問
        Call syokika()
        ListBox1.Items.Clear()
        Call yomikomi1()
        Call hyoji()
        Me.Update()
        afilesyu = a1path
        azenbu = ListBox1.Items.Count - 1
        akubun = "1/"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '優先度2　たまに出る質問
        Call syokika()
        ListBox1.Items.Clear()
        Call yomikomi2()
        Call hyoji()
        afilesyu = a2path
        azenbu = ListBox1.Items.Count - 1
        akubun = "2/"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If ListBox1.SelectedItems.Count > 0 Then
            asentaku = Microsoft.VisualBasic.Left(ListBox1.SelectedItem, 10) & "～"
            abanti = ListBox1.SelectedIndex
            asyori = MsgBox(asentaku & vbCrLf & "この項目を本当に削除しますか？", vbYesNo, "削除")
        Else
            MsgBox("項目を選択してください", , "選択されていません")
        End If
        Select Case asyori
            Case vbYes
                Call sakujo()
            Case vbNo

        End Select
    End Sub
    ''PictureBoxをクリックした時の処理ここまで

    ''PictureBoxをクリック（マウスダウン）した時の処理ここから
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = My.Resources.back_hover
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        PictureBox2.Image = My.Resources.situmon_ooi_hover
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        PictureBox3.Image = My.Resources.situmon_tamani_hover
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        PictureBox4.Image = My.Resources.situmon_koumoku_delete_hover
    End Sub
    ''PictureBoxをクリック（マウスダウン）した時の処理ここまで

    ''PictureBoxをクリックして離した時の処理ここから
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = My.Resources.back
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Image = My.Resources.situmon_ooi
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        PictureBox3.Image = My.Resources.situmon_tamani
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        PictureBox4.Image = My.Resources.situmon_koumoku_delete
    End Sub
    ''PictureBoxをクリックして離した時の処理ここまで

    ''各サブルーチンはここから
    Sub yomikomi1()
        Dim aobjf As New System.IO.StreamReader(a1path, _
                                               System.Text.Encoding.GetEncoding("Shift-JIS"))
        ag = 0
        Dim arint As Integer = 0 '配列添え字
        aline = aobjf.ReadLine()

        While (aline <> "")
            '行単位データをカンマ部分で分割し、配列へ格納
            aa = Split(aline, ",")

            For arint = 0 To UBound(aa) - 1
                adat(ag, CStr(arint)) = adat(ag, CStr(arint))
                adat(ag, CStr(arint)) = adat(ag, CStr(arint)) + aa(CStr(arint))
            Next

            ag = ag + 1
            aline = aobjf.ReadLine()
        End While

        aobjf.Close()
    End Sub

    Sub yomikomi2()
        Dim aobjf2 As New System.IO.StreamReader(a2path, _
                                             System.Text.Encoding.GetEncoding("Shift-JIS"))
        ag = 0
        Dim arint As Integer = 0 '配列添え字
        aline = aobjf2.ReadLine()

        While (aline <> "")
            '行単位データをカンマ部分で分割し、配列へ格納
            aa = Split(aline, ",")

            For arint = 0 To UBound(aa) - 1
                adat(ag, CStr(arint)) = adat(ag, CStr(arint))
                adat(ag, CStr(arint)) = adat(ag, CStr(arint)) + aa(CStr(arint))
            Next
            ag = ag + 1
            aline = aobjf2.ReadLine()
        End While

        aobjf2.Close()
    End Sub

    Sub hyoji()
        Dim ai As Integer = 0
        Do While adat(ai, 1) <> "" And adat(ai, 0) <> ""
            ListBox1.Items.Add(adat(ai, 1))
            ai = ai + 1
        Loop
    End Sub

    Sub syokika()
        Dim a30 As Integer
        For a30 = 0 To 30
            adat(a30, 0) = Nothing
            adat(a30, 1) = Nothing
        Next a30
    End Sub

    Sub sakujo()
        Dim asoeji As Integer
        Dim afpath As String
        asoeji = abanti
        afpath = "oto/" & akubun & adat(abanti, 0)
        System.IO.File.Delete(afpath)
        Do Until asoeji = azenbu
            adat(asoeji, 0) = adat(asoeji + 1, 0)
            adat(asoeji, 1) = adat(asoeji + 1, 1)
            asoeji = asoeji + 1
        Loop
        adat(azenbu, 0) = Nothing
        adat(azenbu, 1) = Nothing
        afpath = afilesyu
        System.IO.File.Delete(afpath)

        Dim aitigyou As String
        asoeji = 0
        Dim anewnaiyou As String
        anewnaiyou = Nothing
        For asoeji = 0 To azenbu - 1
            aitigyou = Nothing
            aitigyou = adat(asoeji, 0) & "," & adat(asoeji, 1) & "," & vbCrLf
            anewnaiyou = anewnaiyou & aitigyou
        Next
        IO.File.WriteAllText(afpath, anewnaiyou, System.Text.Encoding.GetEncoding("Shift-JIS"))
        ListBox1.Items.Clear()
        Call hyoji()
        MsgBox("削除しました", , "削除完了")
    End Sub
    ''各サブルーチンはここまで
End Class
