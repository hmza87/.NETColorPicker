<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tryp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tryp))
        Me.cname = New System.Windows.Forms.TextBox()
        Me.cols = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cname
        '
        Me.cname.Dock = System.Windows.Forms.DockStyle.Top
        Me.cname.Location = New System.Drawing.Point(0, 0)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(126, 20)
        Me.cname.TabIndex = 0
        '
        'cols
        '
        Me.cols.BackColor = System.Drawing.Color.Gray
        Me.cols.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cols.Location = New System.Drawing.Point(0, 20)
        Me.cols.Name = "cols"
        Me.cols.Size = New System.Drawing.Size(126, 211)
        Me.cols.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tryp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(126, 231)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cols)
        Me.Controls.Add(Me.cname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tryp"
        Me.Text = "ColorPicker.NET"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cname As TextBox
    Friend WithEvents cols As Panel
    Friend WithEvents Button1 As Button
End Class
