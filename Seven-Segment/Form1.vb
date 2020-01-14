Public Class Form1

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Dim i As Integer
        'If monitor.Text <= 8 Then
        '    monitor.Text = monitor.Text + 1


        monitor.Text = monitor.Text + 1

        If monitor.Text = 10 Then
            i = monitor.Text
            monitor.Text = i - 10


        End If







    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'FOR BUTTON A'
        Dim s As New Drawing2D.GraphicsPath
        s.StartFigure()
        s.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        s.AddLine(40, 0, Button1.Width - 40, 0)
        s.AddArc(New Rectangle(Button1.Width - 40, 0, 40, 40), -90, 90)
        s.AddLine(Button1.Width, 40, Button1.Width, Button1.Height - 40)
        s.AddArc(New Rectangle(Button1.Width - 40, Button1.Height - 40, 40, 40), 0, 90)
        s.AddLine(Button1.Width - 40, Button1.Height, 40, Button1.Height)
        s.AddArc(New Rectangle(0, Button1.Height - 40, 40, 40), 90, 90)
        s.CloseFigure()
        Button1.Region = New Region(s)

        'FOR BUTTON B'
        Dim h As New Drawing2D.GraphicsPath
        h.StartFigure()
        h.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        h.AddLine(40, 0, Button2.Width - 40, 0)
        h.AddArc(New Rectangle(Button2.Width - 40, 0, 40, 40), -90, 90)
        h.AddLine(Button2.Width, 40, Button2.Width, Button2.Height - 40)
        h.AddArc(New Rectangle(Button2.Width - 40, Button2.Height - 40, 40, 40), 0, 90)
        h.AddLine(Button2.Width - 40, Button2.Height, 40, Button2.Height)
        h.AddArc(New Rectangle(0, Button2.Height - 40, 40, 40), 90, 90)
        h.CloseFigure()
        Button2.Region = New Region(h)

        'FOR BUTTON C'
        Dim o As New Drawing2D.GraphicsPath
        o.StartFigure()
        o.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        o.AddLine(40, 0, Button3.Width - 40, 0)
        o.AddArc(New Rectangle(Button3.Width - 40, 0, 40, 40), -90, 90)
        o.AddLine(Button3.Width, 40, Button3.Width, Button3.Height - 40)
        o.AddArc(New Rectangle(Button3.Width - 40, Button3.Height - 40, 40, 40), 0, 90)
        o.AddLine(Button3.Width - 40, Button3.Height, 40, Button3.Height)
        o.AddArc(New Rectangle(0, Button3.Height - 40, 40, 40), 90, 90)
        o.CloseFigure()
        Button3.Region = New Region(o)

        'FOR BUTTON D'
        Dim w As New Drawing2D.GraphicsPath
        w.StartFigure()
        w.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        w.AddLine(40, 0, Button4.Width - 40, 0)
        w.AddArc(New Rectangle(Button4.Width - 40, 0, 40, 40), -90, 90)
        w.AddLine(Button4.Width, 40, Button4.Width, Button4.Height - 40)
        w.AddArc(New Rectangle(Button4.Width - 40, Button4.Height - 40, 40, 40), 0, 90)
        w.AddLine(Button4.Width - 40, Button4.Height, 40, Button4.Height)
        w.AddArc(New Rectangle(0, Button4.Height - 40, 40, 40), 90, 90)
        w.CloseFigure()
        Button4.Region = New Region(w)

        'FOR BUTTON E'
        Dim m As New Drawing2D.GraphicsPath
        m.StartFigure()
        m.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        m.AddLine(40, 0, Button5.Width - 40, 0)
        m.AddArc(New Rectangle(Button5.Width - 40, 0, 40, 40), -90, 90)
        m.AddLine(Button5.Width, 40, Button5.Width, Button5.Height - 40)
        m.AddArc(New Rectangle(Button5.Width - 40, Button5.Height - 40, 40, 40), 0, 90)
        m.AddLine(Button5.Width - 40, Button5.Height, 40, Button5.Height)
        m.AddArc(New Rectangle(0, Button5.Height - 40, 40, 40), 90, 90)
        m.CloseFigure()
        Button5.Region = New Region(m)

        'FOR BUTTON F'
        Dim a As New Drawing2D.GraphicsPath
        a.StartFigure()
        a.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        a.AddLine(40, 0, Button6.Width - 40, 0)
        a.AddArc(New Rectangle(Button6.Width - 40, 0, 40, 40), -90, 90)
        a.AddLine(Button6.Width, 40, Button6.Width, Button6.Height - 40)
        a.AddArc(New Rectangle(Button6.Width - 40, Button6.Height - 40, 40, 40), 0, 90)
        a.AddLine(Button6.Width - 40, Button6.Height, 40, Button6.Height)
        a.AddArc(New Rectangle(0, Button6.Height - 40, 40, 40), 90, 90)
        a.CloseFigure()
        Button6.Region = New Region(a)

        'FOR BUTTON G'
        Dim n As New Drawing2D.GraphicsPath
        n.StartFigure()
        n.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        n.AddLine(40, 0, Button7.Width - 40, 0)
        n.AddArc(New Rectangle(Button7.Width - 40, 0, 40, 40), -90, 90)
        n.AddLine(Button7.Width, 40, Button7.Width, Button7.Height - 40)
        n.AddArc(New Rectangle(Button7.Width - 40, Button7.Height - 40, 40, 40), 0, 90)
        n.AddLine(Button7.Width - 40, Button7.Height, 40, Button7.Height)
        n.AddArc(New Rectangle(0, Button7.Height - 40, 40, 40), 90, 90)
        n.CloseFigure()
        Button7.Region = New Region(n)






    End Sub

    Private Sub monitor_TextChanged(sender As Object, e As EventArgs) Handles monitor.TextChanged
        If monitor.Text = 0 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button7.BackColor = Color.LightGray

        ElseIf monitor.Text = 1 Then

            Button1.BackColor = Color.LightGray
            Button4.BackColor = Color.LightGray
            Button5.BackColor = Color.LightGray
            Button6.BackColor = Color.LightGray
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button7.BackColor = Color.LightGray

        ElseIf monitor.Text = 2 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button6.BackColor = Color.LightGray
            Button7.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button3.BackColor = Color.LightGray

        ElseIf monitor.Text = 3 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            Button5.BackColor = Color.LightGray
            Button6.BackColor = Color.LightGray

        ElseIf monitor.Text = 4 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button1.BackColor = Color.LightGray
            Button4.BackColor = Color.LightGray
            Button5.BackColor = Color.LightGray

        ElseIf monitor.Text = 5 Then

            Button1.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            Button2.BackColor = Color.LightGray
            Button5.BackColor = Color.LightGray

        ElseIf monitor.Text = 6 Then

            Button1.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            Button2.BackColor = Color.LightGray

        ElseIf monitor.Text = 7 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button6.BackColor = Color.LightGray
            Button5.BackColor = Color.LightGray
            Button7.BackColor = Color.LightGray
            Button4.BackColor = Color.LightGray

        ElseIf monitor.Text = 8 Then

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink


        Else

            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button4.BackColor = Color.LightGray
            Button5.BackColor = Color.LightGray


        End If



    End Sub

    Private Sub monitor_Click(sender As Object, e As EventArgs) Handles monitor.Click

    End Sub
End Class
