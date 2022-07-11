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
        Me.btnGenerisi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtSek = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMinP = New System.Windows.Forms.TextBox()
        Me.txtSekP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerisi
        '
        Me.btnGenerisi.BackColor = System.Drawing.Color.Thistle
        Me.btnGenerisi.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerisi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerisi.Location = New System.Drawing.Point(26, 253)
        Me.btnGenerisi.Name = "btnGenerisi"
        Me.btnGenerisi.Size = New System.Drawing.Size(450, 53)
        Me.btnGenerisi.TabIndex = 1
        Me.btnGenerisi.Text = "Generisi tajmer"
        Me.btnGenerisi.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Uneti vreme rada:"
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(246, 88)
        Me.txtMin.Multiline = True
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(74, 36)
        Me.txtMin.TabIndex = 3
        Me.txtMin.Text = "Min"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSek
        '
        Me.txtSek.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSek.Location = New System.Drawing.Point(402, 88)
        Me.txtSek.Multiline = True
        Me.txtSek.Name = "txtSek"
        Me.txtSek.Size = New System.Drawing.Size(74, 36)
        Me.txtSek.TabIndex = 4
        Me.txtSek.Text = "Sek"
        Me.txtSek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(353, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(282, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*kliknuti na bilo koji crni deo forme za izlazak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Uneti vreme pauze:"
        '
        'txtMinP
        '
        Me.txtMinP.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinP.Location = New System.Drawing.Point(246, 171)
        Me.txtMinP.Multiline = True
        Me.txtMinP.Name = "txtMinP"
        Me.txtMinP.Size = New System.Drawing.Size(74, 36)
        Me.txtMinP.TabIndex = 8
        Me.txtMinP.Text = "Min"
        Me.txtMinP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSekP
        '
        Me.txtSekP.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSekP.Location = New System.Drawing.Point(402, 170)
        Me.txtSekP.Multiline = True
        Me.txtSekP.Name = "txtSekP"
        Me.txtSekP.Size = New System.Drawing.Size(74, 36)
        Me.txtSekP.TabIndex = 9
        Me.txtSekP.Text = "Sek"
        Me.txtSekP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(353, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(501, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSekP)
        Me.Controls.Add(Me.txtMinP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSek)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerisi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerisi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtSek As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMinP As TextBox
    Friend WithEvents txtSekP As TextBox
    Friend WithEvents Label5 As Label
End Class
