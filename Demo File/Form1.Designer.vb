<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listKeluaran = New System.Windows.Forms.ListBox()
        Me.tombolCiptakan = New System.Windows.Forms.Button()
        Me.tombolBaca = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listKeluaran
        '
        Me.listKeluaran.FormattingEnabled = True
        Me.listKeluaran.Location = New System.Drawing.Point(4, 13)
        Me.listKeluaran.Name = "listKeluaran"
        Me.listKeluaran.Size = New System.Drawing.Size(182, 212)
        Me.listKeluaran.TabIndex = 0
        '
        'tombolCiptakan
        '
        Me.tombolCiptakan.Location = New System.Drawing.Point(4, 232)
        Me.tombolCiptakan.Name = "tombolCiptakan"
        Me.tombolCiptakan.Size = New System.Drawing.Size(83, 37)
        Me.tombolCiptakan.TabIndex = 1
        Me.tombolCiptakan.Text = "Ciptakan File"
        Me.tombolCiptakan.UseVisualStyleBackColor = True
        '
        'tombolBaca
        '
        Me.tombolBaca.Location = New System.Drawing.Point(103, 232)
        Me.tombolBaca.Name = "tombolBaca"
        Me.tombolBaca.Size = New System.Drawing.Size(83, 37)
        Me.tombolBaca.TabIndex = 2
        Me.tombolBaca.Text = "Baca File"
        Me.tombolBaca.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(4, 285)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(182, 27)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 318)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBaca)
        Me.Controls.Add(Me.tombolCiptakan)
        Me.Controls.Add(Me.listKeluaran)
        Me.Name = "Form1"
        Me.Text = "Demo File"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listKeluaran As System.Windows.Forms.ListBox
    Friend WithEvents tombolCiptakan As System.Windows.Forms.Button
    Friend WithEvents tombolBaca As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
