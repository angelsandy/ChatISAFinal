<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.proyecto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.listaContactos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Proyectos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Insignias"
        '
        'proyecto
        '
        Me.proyecto.Location = New System.Drawing.Point(54, 283)
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(100, 23)
        Me.proyecto.TabIndex = 8
        Me.proyecto.Text = "Proyectos"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(54, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Isaac"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(54, 245)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(173, 23)
        Me.Nombre.TabIndex = 6
        Me.Nombre.Text = "isaac@hotmail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChatISA.My.Resources.Resources.male1
        Me.PictureBox1.Location = New System.Drawing.Point(107, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 106)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'listaContactos
        '
        Me.listaContactos.Location = New System.Drawing.Point(12, 488)
        Me.listaContactos.Name = "listaContactos"
        Me.listaContactos.Size = New System.Drawing.Size(91, 37)
        Me.listaContactos.TabIndex = 12
        Me.listaContactos.Text = "Contactos"
        Me.listaContactos.UseVisualStyleBackColor = True
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 536)
        Me.Controls.Add(Me.listaContactos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.proyecto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Perfil"
        Me.Text = "Perfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents proyecto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents listaContactos As System.Windows.Forms.Button
End Class
