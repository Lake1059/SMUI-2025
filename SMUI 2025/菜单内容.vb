Public Class 菜单内容

    Public Shared ReadOnly 菜单_启动SMAPI As New 暗黑上下文菜单 With {.ShowImageMargin = False}

    Public Shared Sub 初始化菜单_启动SMAPI()
        AddHandler Form1.UiButton启动SMAPI.MouseDown, Sub(sender, e) 界面控制.按下鼠标显示上下文菜单(sender, e, 菜单_启动SMAPI, 界面控制.上下文菜单显示位置.左对齐在下方显示)
        菜单_启动SMAPI.Items.AddRange({
                                  New ToolStripSeparator With {.Tag = "null"},
                                  New ToolStripMenuItem("启动 SMAPI") With {.ForeColor = Color.CornflowerBlue},
                                  New ToolStripMenuItem("编辑启动参数"),
                                  New ToolStripMenuItem("启动原版游戏"),
                                  New ToolStripSeparator,
                                  New ToolStripMenuItem("运行命令行") With {.ForeColor = Color.Tomato},
                                  New ToolStripMenuItem("编辑命令行"),
                                  New ToolStripSeparator With {.Tag = "null"}
        })
    End Sub

    Public Shared ReadOnly 菜单_购买订阅 As New 暗黑上下文菜单 With {.ShowImageMargin = False}

    Public Shared Sub 初始化菜单_购买订阅()
        AddHandler Form1.UiButton购买订阅.MouseDown, Sub(sender, e) 界面控制.按下鼠标显示上下文菜单(sender, e, 菜单_购买订阅, 界面控制.上下文菜单显示位置.左对齐在下方显示)
        菜单_购买订阅.Items.AddRange({
                                  New ToolStripSeparator With {.Tag = "null"},
                                  New ToolStripMenuItem("前往 afdian 购买（￥CNY - 微信 \ 支付宝）") With {.ForeColor = Color.Violet},
                                  New ToolStripMenuItem("前往 payhip 购买（$USD - VISA \ PayPal）") With {.ForeColor = Color.CornflowerBlue},
                                  New ToolStripSeparator With {.Tag = "null"}
        })
    End Sub

    Public Shared ReadOnly 菜单_内容菜单 As New 暗黑上下文菜单 With {.ShowImageMargin = False, .AutoClose = False}
    Public Shared ReadOnly 菜单_内容菜单2 As New 暗黑上下文菜单 With {.ShowImageMargin = False, .AutoClose = False, .DropShadowEnabled = False}

    Public Shared Sub 初始化菜单_内容菜单()
        AddHandler Form1.UiButton内容菜单.MouseDown, Sub(sender, e)
                                                     If 菜单_内容菜单.Visible = True Then
                                                         菜单_内容菜单.Close()
                                                         菜单_内容菜单2.Close()
                                                         Exit Sub
                                                     End If
                                                     菜单_内容菜单.Show(Form1.UiButton内容菜单, Form1.UiButton内容菜单.Width - 菜单_内容菜单.Width, Form1.UiButton内容菜单.Height - 2)
                                                     菜单_内容菜单2.Show(Form1.UiButton内容菜单, Form1.UiButton内容菜单.Width - 菜单_内容菜单.Width - 菜单_内容菜单2.Width + 2, Form1.UiButton内容菜单.Height - 2)
                                                 End Sub
        菜单_内容菜单.Items.AddRange({
                               New ToolStripSeparator With {.Tag = "null"},
                               New ToolStripMenuItem("应用程序目录") With {.ForeColor = Color.Violet},
                               New ToolStripMenuItem("用户数据文件夹"),
                               New ToolStripMenuItem("插件目录"),
                               New ToolStripSeparator,
                               New ToolStripMenuItem("星露谷游戏文件夹"),
                               New ToolStripMenuItem("星露谷 Mods 文件夹"),
                               New ToolStripMenuItem("星露谷存档文件夹"),
                               New ToolStripMenuItem("SMAPI 日志文件夹"),
                               New ToolStripSeparator,
                               New ToolStripMenuItem("星露谷 NEXUSMODS") With {.ForeColor = Color.DarkOrange},
                               New ToolStripMenuItem("星露谷 DEG Mods"),
                               New ToolStripMenuItem("星露谷 ModDrop") With {.ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("星露谷 naver 韩网咖啡厅") With {.ForeColor = Color.Green},
                               New ToolStripSeparator,
                               New ToolStripMenuItem("SMAPI 官网"),
                               New ToolStripMenuItem("SMAPI 模组兼容表"),
                               New ToolStripMenuItem("SMAPI 日志分析器"),
                               New ToolStripSeparator With {.Tag = "null"}
        })
        菜单_内容菜单2.Items.AddRange({
                                New ToolStripSeparator With {.Tag = "null"},
                                New ToolStripMenuItem("星露谷贴吧"),
                                New ToolStripMenuItem("星露谷 Steam 页面") With {.ForeColor = Color.CornflowerBlue},
                                New ToolStripMenuItem("星露谷官方维基"),
                                New ToolStripMenuItem("星露谷官方社区"),
                                New ToolStripMenuItem("星露谷 Discord 官方聊天室") With {.ForeColor = Color.Violet},
                                New ToolStripMenuItem("星露谷 Reddit 官方论坛") With {.ForeColor = Color.PaleVioletRed},
                                New ToolStripMenuItem("星露谷 CA 的推特") With {.ForeColor = Color.CornflowerBlue},
                                New ToolStripSeparator,
                                New ToolStripMenuItem("农场布局规划"),
                                New ToolStripMenuItem("存档预测"),
                                New ToolStripMenuItem("存档进度检测"),
                                New ToolStripSeparator,
                                New ToolStripMenuItem("关闭这些菜单") With {.ForeColor = Color.Tomato},
                                New ToolStripSeparator With {.Tag = "null"}
        })
    End Sub

    Public Shared ReadOnly 菜单_目录和预设菜单 As New 暗黑上下文菜单 With {.ShowImageMargin = False}
    Public Shared Sub 初始化菜单_目录菜单()
        AddHandler Form1.UiButton目录和预设菜单.MouseDown, Sub(sender, e) 界面控制.按下鼠标显示上下文菜单(sender, e, 菜单_目录和预设菜单, 界面控制.上下文菜单显示位置.左对齐在下方显示)
        菜单_目录和预设菜单.Items.AddRange({
                               New ToolStripSeparator With {.Tag = "null"},
                               New ToolStripMenuItem("原来的分类模式") With {.Enabled = False, .ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("创建目录"),
                               New ToolStripMenuItem("删除目录"),
                               New ToolStripSeparator,
                               New ToolStripMenuItem("定制的传统方案") With {.Enabled = False, .ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("创建预设组"),
                               New ToolStripMenuItem("删除预设组"),
                               New ToolStripSeparator,
                               New ToolStripMenuItem("其他功能") With {.Enabled = False, .ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("导入导出"),
                               New ToolStripMenuItem("排序管理"),
                               New ToolStripMenuItem("加入检查更新表"),
                               New ToolStripMenuItem("加入导出预设"),
                               New ToolStripSeparator With {.Tag = "null"}
        })
    End Sub

    Public Shared ReadOnly 菜单_目录和预设的右键菜单 As New 暗黑上下文菜单 With {.ShowImageMargin = False}
    Public Shared Sub 初始化菜单_目录和预设的右键菜单()
        Form1.ListView1.ContextMenuStrip = 菜单_目录和预设的右键菜单
        菜单_目录和预设的右键菜单.Items.AddRange({
                               New ToolStripSeparator With {.Tag = "null"},
                               New ToolStripMenuItem("文件资源管理器") With {.Enabled = False, .ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("打开文件夹"),
                               New ToolStripMenuItem("重命名"),
                               New ToolStripSeparator,
                               New ToolStripMenuItem("批量样式") With {.Enabled = False, .ForeColor = Color.CornflowerBlue},
                               New ToolStripMenuItem("设置字形"),
                               New ToolStripMenuItem("设置文字颜色"),
                               New ToolStripMenuItem("设置背景颜色"),
                               New ToolStripSeparator With {.Tag = "null"}
        })
    End Sub

End Class
