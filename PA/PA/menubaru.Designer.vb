<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menubaru
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnlapangan = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnX = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnlaporan)
        Me.Panel1.Controls.Add(Me.btnlapangan)
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 641)
        Me.Panel1.TabIndex = 0
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.GreenYellow
        Me.btnexit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold)
        Me.btnexit.Location = New System.Drawing.Point(0, 388)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(226, 50)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.GreenYellow
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold)
        Me.btnlogout.Location = New System.Drawing.Point(0, 338)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(226, 50)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.GreenYellow
        Me.btnlaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporan.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold)
        Me.btnlaporan.Location = New System.Drawing.Point(0, 288)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(226, 50)
        Me.btnlaporan.TabIndex = 6
        Me.btnlaporan.Text = "LAPORAN"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnlapangan
        '
        Me.btnlapangan.BackColor = System.Drawing.Color.GreenYellow
        Me.btnlapangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlapangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlapangan.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold)
        Me.btnlapangan.Location = New System.Drawing.Point(0, 238)
        Me.btnlapangan.Name = "btnlapangan"
        Me.btnlapangan.Size = New System.Drawing.Size(226, 50)
        Me.btnlapangan.TabIndex = 5
        Me.btnlapangan.Text = "LAPANGAN"
        Me.btnlapangan.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.GreenYellow
        Me.btnhome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.Location = New System.Drawing.Point(0, 188)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(226, 50)
        Me.btnhome.TabIndex = 4
        Me.btnhome.Text = "HOME"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 188)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA.My.Resources.Resources.field
        Me.PictureBox1.Location = New System.Drawing.Point(29, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENYEWAAN LAPANGAN FUTSAL DAN MINISOCCER"
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Red
        Me.btnX.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.18462!, System.Drawing.FontStyle.Bold)
        Me.btnX.Location = New System.Drawing.Point(1019, 0)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(76, 44)
        Me.btnX.TabIndex = 2
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KELOMPOK 5 A2'21"
        '
        'menubaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 641)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1095, 641)
        Me.MinimumSize = New System.Drawing.Size(1095, 641)
        Me.Name = "menubaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menubaru"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnlaporan As Button
    Friend WithEvents btnlapangan As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnX As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnexit As Button
End Class
