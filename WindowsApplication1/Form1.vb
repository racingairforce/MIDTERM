Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c, f
        f = Val(txt1.Text)
        c = (f - 32) / 1.8
        lb1.Text = ("攝氏" & f & " 度 = 華氏 " & c & " 度 ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c, f
        f = Val(txt1.Text)
        c = f * 1.8 + 32
        lb1.Text = ("華氏" & c & " 度 = 攝氏 " & f & " 度 ")
    End Sub
End Class
