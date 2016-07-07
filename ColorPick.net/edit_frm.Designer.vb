<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_frm))
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.pp = New System.Windows.Forms.Panel()
        Me.c = New System.Windows.Forms.Label()
        Me.ctxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.crgb = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.noti = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCurrentPalleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 10
        '
        'pp
        '
        Me.pp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pp.Location = New System.Drawing.Point(0, 97)
        Me.pp.Name = "pp"
        Me.pp.Size = New System.Drawing.Size(334, 126)
        Me.pp.TabIndex = 0
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.c.ForeColor = System.Drawing.Color.Black
        Me.c.Location = New System.Drawing.Point(12, 9)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(99, 36)
        Me.c.TabIndex = 1
        Me.c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctxt
        '
        Me.ctxt.Location = New System.Drawing.Point(11, 71)
        Me.ctxt.Name = "ctxt"
        Me.ctxt.Size = New System.Drawing.Size(100, 20)
        Me.ctxt.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'crgb
        '
        Me.crgb.Location = New System.Drawing.Point(116, 71)
        Me.crgb.Name = "crgb"
        Me.crgb.Size = New System.Drawing.Size(100, 20)
        Me.crgb.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 20)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clr"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'noti
        '
        Me.noti.ContextMenuStrip = Me.ContextMenuStrip1
        Me.noti.Icon = CType(resources.GetObject("noti.Icon"), System.Drawing.Icon)
        Me.noti.Text = "Color Picker .NET"
        Me.noti.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditColorsToolStripMenuItem, Me.ShowCurrentPalleteToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 76)
        '
        'EditColorsToolStripMenuItem
        '
        Me.EditColorsToolStripMenuItem.Name = "EditColorsToolStripMenuItem"
        Me.EditColorsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EditColorsToolStripMenuItem.Text = "Edit Colors"
        '
        'ShowCurrentPalleteToolStripMenuItem
        '
        Me.ShowCurrentPalleteToolStripMenuItem.Name = "ShowCurrentPalleteToolStripMenuItem"
        Me.ShowCurrentPalleteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ShowCurrentPalleteToolStripMenuItem.Text = "Show Current Pallete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.White
        Me.txt.ForeColor = System.Drawing.Color.Black
        Me.txt.Location = New System.Drawing.Point(118, 9)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(204, 36)
        Me.txt.TabIndex = 6
        Me.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hex :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "RGB :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "___________________________________________"
        '
        'edit_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(334, 223)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.crgb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ctxt)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.pp)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_frm"
        Me.Text = "Color Picker .NET"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents pp As Panel
    Friend WithEvents c As Label
    Friend WithEvents ctxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents crgb As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents noti As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowCurrentPalleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
