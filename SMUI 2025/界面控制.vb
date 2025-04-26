Imports System.Windows.Forms.Control

Public Class 界面控制

    Public Shared Sub 按下鼠标显示上下文菜单(c As Control, e As MouseEventArgs, m As 暗黑上下文菜单, p As 上下文菜单显示位置)
        Select Case p
            Case 上下文菜单显示位置.左对齐在下方显示
                Select Case e.Button
                    Case MouseButtons.Left
                        m.Show(c, 0, c.Height - 2)
                    Case MouseButtons.Right
                        m.Show(MousePosition)
                End Select
            Case 上下文菜单显示位置.右对齐在下方显示
                m.Show(c, c.Width - m.Width, c.Height - 2)
            Case 上下文菜单显示位置.左对齐在上方显示
                m.Show(c, e.Location.X, e.Location.Y - m.Height)
            Case 上下文菜单显示位置.右对齐在上方显示
                m.Show(c, e.Location.X + c.Width - m.Width, e.Location.Y - m.Height)
        End Select
    End Sub

    Enum 上下文菜单显示位置
        左对齐在下方显示 = 1
        右对齐在下方显示 = 2
        左对齐在上方显示 = 3
        右对齐在上方显示 = 4
    End Enum




End Class
