Public Class Form1
    Public ip As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ip = "192.168.0.3"
        lbl_ip.Text = ip
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pwd

        TextBox2.Text = ""
        user = txt_user.Text
        pwd = txt_pwd.Text

        Dim RetVal
        Dim cmdx
        cmdx = "net use x: \\" & ip & "\share " & pwd & " /user:" & user
        RetVal = Shell(cmdx)
        'MsgBox(cmdx)
        'RetVal = Shell("calc.exe")

        Dim cmdz
        cmdz = "net use z: \\" & ip & "\homes " & pwd & " /user:" & user
        RetVal = Shell(cmdz)
        'RetVal = Shell("calc.exe")

        'TextBox2 = cmdx & vbCrLf & cmdz
        System.Threading.Thread.Sleep(2000)
        Dim cmd, msg
        cmd = "net use "
        msg = PMsg(RunCmd(cmd))

        If InStr(msg, "Error") >= 1 Then
            TextBox2.ForeColor = Color.Red
            msg = msg & " " & pwd
        Else
            TextBox2.ForeColor = Color.Black
        End If

        TextBox2.Text = msg
    End Sub

    '此函數來自宜蘭瘋狂魔術師
    Private Function RunCmd(ByVal command As String) As String
        '實例一個Process類，啟動一個獨立進程
        Dim p As Process = New Process()

        'Process類有一個StartInfo屬性，這個是ProcessStartInfo類，包括了一些屬性和方法，下面我們用到了他的幾個屬性：

        p.StartInfo.FileName = "cmd.exe"           '設定程序名
        p.StartInfo.Arguments = "/c " + command    '設定程式執行參數
        p.StartInfo.UseShellExecute = False        '關閉Shell的使用
        p.StartInfo.RedirectStandardInput = True   '重定向標準輸入
        p.StartInfo.RedirectStandardOutput = True  '重定向標準輸出
        p.StartInfo.RedirectStandardError = True   '重定向錯誤輸出
        p.StartInfo.CreateNoWindow = True          '設置不顯示窗口

        p.Start() '啟動

        'p.StandardInput.WriteLine(command);       '也可以用這種方式輸入要執行的命令
        'p.StandardInput.WriteLine("exit");        '不過要記得加上Exit要不然下一行程式執行的時候會當機

        Return p.StandardOutput.ReadToEnd()        '從輸出流取得命令執行結果

    End Function

    '處理msg 只找出開頭有OK的行
    '傳入msg
    '傳回處理好的msg
    Private Function PMsg(ByVal msg As String) As String
        'OK X: \\192.168.1.112\share Microsoft Windows Network
        'OK Z: \\192.168.1.112\homes Microsoft Windows Network
        '清單沒有任何項目
        'For Each sLine In arrText
        'Console.WriteLine(sLine)
        'Next
        ' Do While (Not EOF(filenum))
        'line Input #filenum, tmpstr1
        'tmpstr = tmpstr & tmpstr1 & "|"
        'Loop
        Dim tmpstr, sLine, dOk, reStr
        tmpstr = Split(msg, vbCrLf)
        For Each sLine In tmpstr
            'MsgBox(sLine)
            'MsgBox(InStr(sLine, "OK"))
            If InStr(sLine, "OK") >= 1 Then
                dOk = 1
                reStr &= good(sLine)
            End If
        Next

        If dOk <> 1 Then
            reStr = "Error!連線不成功!"
        End If

        Return reStr
    End Function

    '處理msg net use * /del /y
    '傳入msg
    '傳回處理好的msg
    Private Function PMsgDel(ByVal msg As String) As String
        '清單沒有任何項目
        Dim tmpstr, sLine, reStr
        tmpstr = Split(msg, vbCrLf)
        For Each sLine In tmpstr
            'MsgBox(sLine)
            'MsgBox(InStr(sLine, "OK"))
            If InStr(sLine, "清單沒有任何項目") >= 1 Then
                reStr = "Logout！清單沒有任何項目"
            End If
        Next

        Return reStr
    End Function

    '只取要的文字
    Private Function good(ByVal gLine As String) As String
        Dim gStr, gTmp
        gTmp = Split(delSpace(gLine))
        gStr = gTmp(1) & " " & gTmp(2) & " " & gTmp(3) & vbCrLf
        Return gStr
    End Function

    '刪除字串中不必要的空白
    Private Function delSpace(ByVal mStr As String) As String
        Dim tmp, reStr
        tmp = Split(mStr)
        For Each mWord In tmp
            If mWord <> "" Then
                reStr = reStr & " " & mWord
            End If
        Next
        reStr = reStr & vbCrLf

        Return reStr
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        '清除所有連線
        Dim cmdd, RetVal
        cmdd = "net use * /del /y"
        RetVal = Shell(cmdd)
        'RetVal = Shell("calc.exe")

        System.Threading.Thread.Sleep(2000)
        Dim cmd, msg
        cmd = "net use "
        msg = PMsgDel(RunCmd(cmd))

        TextBox2.Text = msg
    End Sub
End Class
