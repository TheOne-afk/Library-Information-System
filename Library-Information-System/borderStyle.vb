Imports System.Drawing.Drawing2D
'Autor Abdelouahed Zakaria
'Email Admin@trysoftware.info
'site : http://www.trysoftware.info/
Public Class CustomTextBox : Inherits Control
    Dim WithEvents MyTxtBox As New TextBox

    Private CreateRoundPath As GraphicsPath
    Private CreateRoundRectangle As Rectangle
    Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
        CreateRoundRectangle = New Rectangle(x, y, width, height)
        Return CreateRound(CreateRoundRectangle, slope)
    End Function

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function



#Region "TextBox Properties"
    Private _passmask As Boolean = False
    Private _maxchars As Integer = 10000
    Private _align As HorizontalAlignment
    Private ReadOnly_ As Boolean = False
    Private GrayText_ As String = "Add your Text"
    Property GrayText As String
        Get
            Return GrayText_
        End Get
        Set(value As String)
            GrayText_ = value
            Invalidate()
        End Set
    End Property
    Public Shadows Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyTxtBox.ForeColor = value
            Invalidate()

        End Set
    End Property
    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            Invalidate()
        End Set
    End Property
    Public Shadows Property UseSystemPasswordChar() As Boolean
        Get
            Return _passmask
        End Get
        Set(ByVal v As Boolean)
            MyTxtBox.UseSystemPasswordChar = UseSystemPasswordChar
            _passmask = v
            Invalidate()
        End Set
    End Property

    Public Shadows Property MaxLength() As Integer
        Get
            Return _maxchars
        End Get
        Set(ByVal v As Integer)
            _maxchars = v
            MyTxtBox.MaxLength = MaxLength
            Invalidate()
        End Set
    End Property

    Public Shadows Property TextAlignment() As HorizontalAlignment
        Get
            Return _align
        End Get
        Set(ByVal v As HorizontalAlignment)
            _align = v
            Invalidate()
        End Set
    End Property

    Public Shadows Property _ReadOnly As Boolean
        Get
            Return ReadOnly_
        End Get
        Set(value As Boolean)
            ReadOnly_ = value
            MyTxtBox.ReadOnly = _ReadOnly
            Invalidate()
        End Set
    End Property
#End Region


    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnBackColorChanged(e)
        MyTxtBox.BackColor = BackColor
        Invalidate()
    End Sub

    Protected Overrides Sub OnForeColorChanged(ByVal e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        MyTxtBox.ForeColor = ForeColor
        Invalidate()
    End Sub
    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        MyTxtBox.Font = Font
    End Sub
    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        MyTxtBox.Focus()
    End Sub
    Sub txtlostforuc() Handles MyTxtBox.LostFocus
        ClearTxt = False
        ForeColor = Color.Gray
        Invalidate()

    End Sub
    Sub txtGotfocus() Handles MyTxtBox.GotFocus
        If Text = GrayText_ Then
            ClearTxt = True
            MyTxtBox.Clear()
            Invalidate()

        End If

    End Sub
    Private ClearTxt As Boolean = False


    Sub TextChngTxtBox() Handles MyTxtBox.TextChanged

        Text = MyTxtBox.Text
    End Sub
    Sub TextChng() Handles MyBase.TextChanged
        MyTxtBox.Text = Text
    End Sub
    Sub NewTextBox()
        With MyTxtBox
            .ReadOnly = ReadOnly_
            .Multiline = True
            .BackColor = Color.White
            .ForeColor = ForeColor
            .Text = String.Empty
            .TextAlign = HorizontalAlignment.Center
            .BorderStyle = BorderStyle.None
            .Location = New Point(5, 4)
            .Font = Font
            .Size = New Size(Width - 10, Height - 40)
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With

    End Sub

    Sub New()
        MyBase.New()
        NewTextBox()
        Controls.Add(MyTxtBox)
        Size = New Size(135, 35)
        DoubleBuffered = True

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.SmoothingMode = SmoothingMode.HighQuality

        Dim TextRectangle As New Rectangle(0, 0, Width - 1, Height - 1)
        Height = MyTxtBox.Height + 11
        With MyTxtBox
            Try
                .BackColor = Parent.BackColor
            Catch ex As Exception

            End Try
            If (Text = GrayText OrElse Text = "") AndAlso ClearTxt = False Then
                MyTxtBox.Text = GrayText
                MyTxtBox.ForeColor = Color.Gray
            Else
                .Text = Text
                .ForeColor = ForeColor
            End If
            .Width = Width - 10
            .TextAlign = TextAlignment
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With

        G.DrawPath(New Pen(Color.FromArgb(150, Color.Red), 2), CreateRound(TextRectangle, 10))

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

End Class