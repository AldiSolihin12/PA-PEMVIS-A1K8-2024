Public Class Rounded
    Public Shared Sub BuatTombolRounded(ByVal button As Button, ByVal cornerRadius As Integer)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim width As Integer = button.Width
        Dim height As Integer = button.Height
        Dim diameter As Integer = cornerRadius * 2

        path.AddArc(-1, -1, diameter, diameter, 180, 90)
        path.AddLine(cornerRadius - 1, -1, width - cornerRadius, -1)
        path.AddArc(width - diameter, -1, diameter, diameter, 270, 90)
        path.AddLine(width, cornerRadius - 1, width, height - cornerRadius)
        path.AddArc(width - diameter, height - diameter, diameter, diameter, 0, 90)
        path.AddLine(width - cornerRadius, height, cornerRadius - 1, height)
        path.AddArc(-1, height - diameter, diameter, diameter, 90, 90)
        path.AddLine(-1, height - cornerRadius, -1, cornerRadius - 1)
        path.CloseAllFigures()

        button.Region = New System.Drawing.Region(path)
    End Sub

    Public Shared Sub BuatPanelRounded(ByVal panel As Panel, ByVal cornerRadius As Integer)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim width As Integer = panel.Width
        Dim height As Integer = panel.Height
        Dim diameter As Integer = cornerRadius * 2

        path.AddArc(-1, -1, diameter, diameter, 180, 90)
        path.AddLine(cornerRadius - 1, -1, width - cornerRadius, -1)
        path.AddArc(width - diameter, -1, diameter, diameter, 270, 90)
        path.AddLine(width, cornerRadius - 1, width, height - cornerRadius)
        path.AddArc(width - diameter, height - diameter, diameter, diameter, 0, 90)
        path.AddLine(width - cornerRadius, height, cornerRadius - 1, height)
        path.AddArc(-1, height - diameter, diameter, diameter, 90, 90)
        path.AddLine(-1, height - cornerRadius, -1, cornerRadius - 1)
        path.CloseAllFigures()

        panel.Region = New System.Drawing.Region(path)
    End Sub
End Class
