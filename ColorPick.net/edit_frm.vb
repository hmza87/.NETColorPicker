Imports System.ComponentModel
Imports IniParser
Imports IniParser.Model
Public Class edit_frm
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As UInt32) As Integer

    Dim mousepos As Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


    End Sub
    Sub u_init()

        For i As Integer = 0 To 7
            For o As Integer = 0 To 2
                Dim l As New Label
                'l.BackColor = Color.Red
                pp.Controls.Add(l)



                l.Left = (i * 40) + (i * 2)

                l.Top = o * 40 + (o * 2)
                l.Width = 40 : l.Height = 40
                'l.Margin = New Padding(0, 0, 5, 0)
                l.Name = o & "_" & i
                l.BackColor = Color.FromArgb(GetSetting("CP", "COLS", l.Name, Color.WhiteSmoke.ToArgb.ToString))
                AddHandler l.Click, AddressOf Click
            Next


        Next
        Me.Width = 350
    End Sub
    Sub t(tx As String)
        txt.Text = tx
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Cursor = Cursors.Cross
        u_init()
        t("Select one Color Box from the panel bellow")
    End Sub
    Function getCol(x As String, y As String) As Color

        Dim screenSize As Size = New Size(20, 20)

        Using screenGrab As New Bitmap(20, 20)

            Using g As Graphics = Graphics.FromImage(screenGrab)

                g.CopyFromScreen(New Point(mousepos.X - 10, mousepos.Y - 10), New Point(0, 0), screenSize)

                Return screenGrab.GetPixel(10, 10)

            End Using

        End Using
    End Function

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If IsNothing(c.Tag) Then
            Button1.Visible = False
            Button2.Visible = False
            Exit Sub
        Else
            Button1.Visible = True
            Button2.Visible = True
            t("Hold press CTRL and mouve the mouse to the desired color in your screen")
        End If


        Dim CTRL As Boolean
        Dim SHFT As Boolean
        Dim p As Long = GetCursorPos(mousepos)
        CTRL = GetAsyncKeyState(Keys.ControlKey)
        SHFT = GetAsyncKeyState(Keys.ShiftKey)
        If CTRL And Button1.Visible Then

            'Me.Text = mousepos.ToString & " " & getCol(mousepos.X, mousepos.Y).ToString
            Dim oc As Color = getCol(mousepos.X, mousepos.Y)
            ctxt.Text = ColtoHex(oc)
            Clipboard.SetText(ctxt.Text)
            crgb.Text = "rgb(" & oc.R & "," & oc.G & "," & oc.B & ")"
            Dim sc = CType(c.Tag, Label)
            sc.BackColor = c.BackColor
            t("Release CTRL when done")
        End If

    End Sub
    Public Function ColtoHex(oc As Color) As String
        Return "#" + oc.R.ToString("X2") + oc.G.ToString("X2") + oc.B.ToString("X2")

    End Function
    Private Sub Click(sender As Object, e As EventArgs)
        'MsgBox(DirectCast(sender, Label).Name)
        c.Tag = DirectCast(sender, Label)
        Dim oc = DirectCast(sender, Label).BackColor
        ctxt.Text = ColtoHex(oc)
        crgb.Text = "rgb(" & oc.R & "," & oc.G & "," & oc.B & ")"
    End Sub

    Private Sub ctxt_TextChanged(sender As Object, e As EventArgs) Handles ctxt.TextChanged
        'Dim cf As Color = ColorTranslator.FromHtml("#FF0000")
        'Dim hx As String = ColorTranslator.ToHtml(cf)
        Dim o As New ColorConverter

        c.BackColor = CType(o.ConvertFromString(ctxt.Text), Color)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        c.Tag = Nothing

        For Each lb As Label In pp.Controls
            SaveSetting("CP", "COLS", lb.Name, lb.BackColor.ToArgb.ToString)
            t("Saved.")
        Next


        tryp.cinit()

    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Text = Me.Width & " " & Me.Height
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'c.BackColor = Color.Wheat
        ctxt.Text = ColtoHex(Color.WhiteSmoke)
        Dim sc = CType(c.Tag, Label)
        sc.BackColor = c.BackColor
        Button1_Click(sender, e)
        t("Cleared!")
    End Sub

    Private Sub noti_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles noti.MouseDoubleClick
        tryp.Show()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
        If tryp.Visible = False Then tryp.Show()
    End Sub

    Private Sub EditColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditColorsToolStripMenuItem.Click
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub ShowCurrentPalleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCurrentPalleteToolStripMenuItem.Click
        Dim l As New tryp
        l.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        noti.Visible = False
        End
    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub
End Class
