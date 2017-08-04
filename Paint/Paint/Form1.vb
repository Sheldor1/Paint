Public Class Form1
    'Alpha v0.5.27.1.45
    Dim myBrush2 As New SolidBrush(Color.White)
    Dim myBrush As New SolidBrush(Color.Black)
    Dim down As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim blackpen As New Pen(Color.Black, 3)
        draw.DrawEllipse(blackpen, 70, 70, 25, 25)
        'head
        draw.DrawLine(blackpen, 82, 200, 82, 95)
        'leg
        draw.DrawLine(blackpen, 85, 197, 120, 315)
        'leg
        draw.DrawLine(blackpen, 80, 197, 10, 315)
        'arm
        draw.DrawLine(blackpen, 82, 120, 130, 170)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y
    End Sub

    'Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
    'Dim draw As System.Drawing.Graphics
    'draw = Me.CreateGraphics
    'End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If down Then
            draw.FillEllipse(myBrush, X, Y, VScrollBar1.Value, VScrollBar1.Value)
        End If
        'draw.FillEllipse(Brushes.Black, X, Y, 10, 10)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        down = True
        'If down Then
        'draw.FillEllipse(Brushes.Black, X, Y, 10, 10)
        'End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        down = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBrush.Color = Color.Crimson
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBrush.Color = Color.DarkRed
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myBrush.Color = Color.Orange
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        myBrush.Color = Color.DarkOrange
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        myBrush.Color = Color.Goldenrod
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        myBrush.Color = Color.Gold
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        myBrush.Color = Color.DarkGoldenrod
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        myBrush.Color = Color.LightGreen
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        myBrush.Color = Color.Green
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        myBrush.Color = Color.DarkGreen
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        myBrush.Color = Color.Violet
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        myBrush.Color = Color.Magenta
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        myBrush.Color = Color.DeepPink
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        myBrush.Color = Color.LightBlue
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        myBrush.Color = Color.Blue
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        myBrush.Color = Color.DarkBlue
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        myBrush.Color = Color.DarkOrchid
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        myBrush.Color = Color.Indigo
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        myBrush.Color = Color.Silver
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        myBrush.Color = Color.DimGray
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        myBrush.Color = Color.LightGray
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        myBrush.Color = Color.WhiteSmoke
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        myBrush.Color = Color.Brown
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        myBrush.Color = Color.Firebrick
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        myBrush.Color = Color.IndianRed
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        myBrush.Color = Color.AliceBlue
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        myBrush.Color = Color.Azure
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        myBrush.Color = Color.Aquamarine
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        myBrush.Color = Color.OrangeRed
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        myBrush.Color = Color.PapayaWhip
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        myBrush.Color = Color.Olive
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim blackpen As New Pen(Color.White, 3)
        draw.FillRectangle(myBrush2, 10, 10, 4000, 4000)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MsgBox("I said coming soon, now shoo.")
    End Sub
End Class
