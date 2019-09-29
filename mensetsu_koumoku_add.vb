Public Class mensetsu_koumoku_add
    Dim ahaba As Integer = Screen.GetWorkingArea(Me).Width   '幅
    Dim atks As Integer = Screen.GetWorkingArea(Me).Height   '高さ
    Dim adrb As New OpenFileDialog()
    Dim afpath As String
    Dim ahairetu() As String
    Private _cells As String
    Dim afsu As Long, abuf As String 'ファイル数えるやつ
    Const asentakuumu As String = "「ファイルを開く」から" & vbCrLf & "ファイルを選択してください。"
    Const aksr As String = "oto/1/"
    Const aksr2 As String = "oto/2/"
    Const a1path As String = "oto/1csvtxt.csv"
    Const a2path As String = "oto/2csvtxt.csv"
    Dim aoksr As String = Nothing
    Dim aCSVpath As String
    Dim i_FadeInFlag As Boolean = True 'フォームフェードイン用の関数の宣言
    Private Property Cells(i As Long, p2 As Integer) As String
        Get
            Return _cells
        End Get
        Set(value As String)
            _cells = value
        End Set
    End Property

    Private Sub mensetsu_koumoku_add_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Timer1.Enabled = True
        i_FadeInFlag = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 0
        Me.Location = New Point(0, 0)
        With Label1 '文字表示
            .Size = New System.Drawing.Size(ahaba * 0.3, atks * 0.2)
            .Location = New Point(ahaba * 0.5, atks * 0.55)
            .BackColor = Color.FromArgb(128, 255, 255, 255)
            .Font = New Font(Label1.Font.Name, 18, Label1.Font.Style)
            .Text = asentakuumu
        End With
        With Label2 '説明
            .Size = New System.Drawing.Size(ahaba * 0.6, atks * 0.05)
            .Location = New Point(ahaba * 0.2, atks * 0.25)
            .Font = New Font(TextBox1.Font.Name, 18, TextBox1.Font.Style)
            .BackColor = Color.FromArgb(128, 255, 255, 255)
        End With
        With TextBox1 '文字入力
            .Size = New System.Drawing.Size(ahaba * 0.6, atks * 0.05)
            .Location = New Point(ahaba * 0.2, atks * 0.3)
            .Font = New Font(TextBox1.Font.Name, 24, TextBox1.Font.Style)
        End With
        With RadioButton1 '多くの場合
            .Size = New System.Drawing.Size(ahaba * 0.3, atks * 0.1)
            .Location = New Point(ahaba * 0.1, atks * 0.4)
            .Font = New Font(RadioButton1.Font.Name, 18, RadioButton1.Font.Style)
            .Text = "多くの場合出される質問"
            .BackColor = Color.FromArgb(128, 255, 255, 255)
            .Checked = True
        End With
        With RadioButton2 'たまに
            .Size = New System.Drawing.Size(ahaba * 0.3, atks * 0.1)
            .Location = New Point(ahaba * 0.55, atks * 0.4)
            .Font = New Font(RadioButton2.Font.Name, 18, RadioButton2.Font.Style)
            .Text = "たまに出される質問"
            .BackColor = Color.FromArgb(128, 255, 255, 255)
            .Checked = False
        End With
        With PictureBox1 'back
            .Image = My.Resources.back
        End With
        With PictureBox2 'ファイル選択
            .Location = New Point(ahaba * 0.1, atks * 0.55)
            .Image = My.Resources.file_open
        End With
        With PictureBox3 '追加
            .Location = New Point(ahaba * 0.6, atks * 0.8)
            .Image = My.Resources.situmon_tuika
        End With
        Shell("explorer.exe C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe")
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'ファイル選択
        ahairetu = Nothing
        With adrb
            .FileName = "situmon.wav"
            .Filter = "waveファイル(*.wav)|*.wav"
            .Title = "追加したい音声のファイルを選択してください"
            .RestoreDirectory = True
        End With
        If adrb.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき
            '選択されたファイル名を表示する
            afpath = (adrb.FileName)
            ahairetu = Split(afpath, "\")
            Label1.Text = ahairetu(UBound(ahairetu))
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.Text <> asentakuumu Then
            My.Computer.Audio.Play(afpath, _
                 AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '質問を追加する
        Dim asyori As String
        Dim atasikame As String
        If RadioButton1.Checked = True Then
            aoksr = aksr
            aCSVpath = a1path
            atasikame = "多くの場合出される質問"
        Else
            aoksr = aksr2
            aCSVpath = a2path
            atasikame = "たまに出される質問"
        End If
        asyori = MsgBox(Microsoft.VisualBasic.Left(TextBox1.Text, 5) & "～" & vbCrLf & _
                         atasikame & vbCrLf & _
                         Label1.Text & vbCrLf & _
                        "で質問を追加してもよいですか", vbYesNo, "内容の確認をしてください")
        If TextBox1.Text <> "" And Label1.Text <> asentakuumu Then

            abuf = Dir(aoksr & "*.*")
            Do While abuf <> ""
                afsu = afsu + 1
                Cells(afsu, 1) = abuf
                abuf = Dir()
            Loop
            If afsu < 30 Then
                aoksr = aoksr & Label1.Text
                FileCopy(afpath, aoksr)

                Dim akakikomi As New System.IO.StreamWriter(aCSVpath, _
                                                   True, System.Text.Encoding.GetEncoding("Shift-JIS"))
                akakikomi.WriteLine(Label1.Text & "," & TextBox1.Text & ",")
                akakikomi.Close()

                MsgBox("質問を追加しました", , "成功しました")
                afsu = 0
            Else
                MsgBox("質問は1つの項目につき30問までです。", , "増やすことができません")
            End If
        ElseIf TextBox1.Text <> "" Then
            MsgBox("質問に追加する音声ファイルを選択してください。", , "未入力な欄があります")
        ElseIf Label1.Text <> asentakuumu Then
            MsgBox("質問内容を入力してください。", , "未入力な欄があります")
        Else
            MsgBox("質問内容を入力し" & vbCrLf & _
                   "音声ファイルを選択してください", , "未入力です")
        End If

    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If Len(TextBox1.Text) > 30 Then
            MsgBox("表示できるテキストは30文字までです", , "文字数がオーバーしています")
            TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, 30)
            TextBox1.SelectionStart = 30
        End If
    End Sub

End Class
