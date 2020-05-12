Public Class Form1
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim N, K, M, I As Integer
        N = TB1.Text
        K = TB2.Text
        For I = 1 To N
            M = InputBox("Введіть число")
            LB1.Text = LB1.Text + CStr(M) + "  "
            If M = K Then
                LB2.Text = LB2.Text + CStr(I) + "  "
            End If
        Next
    End Sub


End Class
