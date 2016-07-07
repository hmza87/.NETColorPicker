Imports System.ComponentModel

Public Class tryp
    Private Sub tryp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cinit()
        Dim l As Integer = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        Dim t As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Me.Left = GetSetting("CP", "Set", "l", l)
        Me.Top = GetSetting("CP", "Set", "t", t)
    End Sub
    Public Function cinit()
        cols.Controls.Clear()

        For i As Integer = 0 To 7
            For o As Integer = 0 To 2
                Dim l As New Label
                'l.BackColor = Color.Red
                cols.Controls.Add(l)



                l.Top = (i * 20) + (i * 2)

                l.Left = o * 40 + (o * 2)
                l.Width = 40 : l.Height = 20
                'l.Margin = New Padding(0, 0, 5, 0)
                l.Name = o & "_" & i
                l.BackColor = Color.FromArgb(GetSetting("CP", "COLS", l.Name, Color.WhiteSmoke.ToArgb.ToString))
                AddHandler l.Click, AddressOf Click
                AddHandler l.DoubleClick, AddressOf DoubleClick
            Next


        Next



    End Function
    Private Sub Click(sender As Object, e As EventArgs)
        'MsgBox(DirectCast(sender, Label).Name)
        cname.Text = edit_frm.ColtoHex(DirectCast(sender, Label).BackColor)
        Clipboard.SetText(cname.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        edit_frm.Show()
    End Sub

    Private Sub tryp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveSetting("CP", "Set", "l", Me.Left)
        SaveSetting("CP", "Set", "t", Me.Top)
    End Sub

    Private Sub DoubleClick(sender As Object, e As EventArgs)
        edit_frm.Show()
    End Sub
End Class