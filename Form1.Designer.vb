<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_pwd = New System.Windows.Forms.Label()
        Me.lbl_server = New System.Windows.Forms.Label()
        Me.lbl_ip = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_user.Location = New System.Drawing.Point(219, 91)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(119, 30)
        Me.txt_user.TabIndex = 0
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(219, 140)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(119, 30)
        Me.txt_pwd.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(184, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "連線"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 252)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(449, 80)
        Me.TextBox2.TabIndex = 3
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(121, 95)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(82, 24)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "帳號："
        '
        'lbl_pwd
        '
        Me.lbl_pwd.AutoSize = True
        Me.lbl_pwd.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_pwd.Location = New System.Drawing.Point(121, 140)
        Me.lbl_pwd.Name = "lbl_pwd"
        Me.lbl_pwd.Size = New System.Drawing.Size(82, 24)
        Me.lbl_pwd.TabIndex = 9
        Me.lbl_pwd.Text = "密碼："
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_server.Location = New System.Drawing.Point(121, 53)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(82, 24)
        Me.lbl_server.TabIndex = 6
        Me.lbl_server.Text = "主機："
        '
        'lbl_ip
        '
        Me.lbl_ip.AutoSize = True
        Me.lbl_ip.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_ip.Location = New System.Drawing.Point(215, 53)
        Me.lbl_ip.Name = "lbl_ip"
        Me.lbl_ip.Size = New System.Drawing.Size(21, 21)
        Me.lbl_ip.TabIndex = 7
        Me.lbl_ip.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(208, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "©sairwolf"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Blue
        Me.lbl_title.Location = New System.Drawing.Point(90, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(278, 27)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "連線網路磁碟機X: Z:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 358)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_ip)
        Me.Controls.Add(Me.lbl_server)
        Me.Controls.Add(Me.lbl_pwd)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.txt_user)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Net Use XZ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_pwd As Label
    Friend WithEvents lbl_server As Label
    Friend WithEvents lbl_ip As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_title As Label
End Class
