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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtb_mensaje = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Enviar1 = New Boton_archivos.enviar()
        Me.Cerrar11 = New Close.cerrar1()
        Me.Minimizar1 = New Minimizar.Minimizar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Send = New send.Class1()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rTBChat = New System.Windows.Forms.RichTextBox()
        Me.btn_camara = New System.Windows.Forms.Button()
        Me.Iconitos = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Iconitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtb_mensaje
        '
        Me.txtb_mensaje.Location = New System.Drawing.Point(68, 469)
        Me.txtb_mensaje.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_mensaje.Multiline = True
        Me.txtb_mensaje.Name = "txtb_mensaje"
        Me.txtb_mensaje.Size = New System.Drawing.Size(332, 71)
        Me.txtb_mensaje.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nombre.FormattingEnabled = True
        Me.Nombre.Location = New System.Drawing.Point(134, 119)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(243, 26)
        Me.Nombre.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Enviar1
        '
        Me.Enviar1.BackColor = System.Drawing.Color.White
        Me.Enviar1.BackgroundImage = CType(resources.GetObject("Enviar1.BackgroundImage"), System.Drawing.Image)
        Me.Enviar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enviar1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Enviar1.FlatAppearance.BorderSize = 0
        Me.Enviar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Enviar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Enviar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enviar1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enviar1.Location = New System.Drawing.Point(68, 432)
        Me.Enviar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Enviar1.Name = "Enviar1"
        Me.Enviar1.Size = New System.Drawing.Size(24, 33)
        Me.Enviar1.TabIndex = 9
        Me.Enviar1.UseVisualStyleBackColor = False
        '
        'Cerrar11
        '
        Me.Cerrar11.BackColor = System.Drawing.Color.White
        Me.Cerrar11.BackgroundImage = CType(resources.GetObject("Cerrar11.BackgroundImage"), System.Drawing.Image)
        Me.Cerrar11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Cerrar11.FlatAppearance.BorderSize = 0
        Me.Cerrar11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cerrar11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cerrar11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar11.Location = New System.Drawing.Point(446, 74)
        Me.Cerrar11.Margin = New System.Windows.Forms.Padding(2)
        Me.Cerrar11.Name = "Cerrar11"
        Me.Cerrar11.Size = New System.Drawing.Size(16, 13)
        Me.Cerrar11.TabIndex = 8
        Me.Cerrar11.UseVisualStyleBackColor = False
        '
        'Minimizar1
        '
        Me.Minimizar1.BackColor = System.Drawing.Color.White
        Me.Minimizar1.BackgroundImage = CType(resources.GetObject("Minimizar1.BackgroundImage"), System.Drawing.Image)
        Me.Minimizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimizar1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Minimizar1.FlatAppearance.BorderSize = 0
        Me.Minimizar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Minimizar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Minimizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizar1.Location = New System.Drawing.Point(424, 75)
        Me.Minimizar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Minimizar1.Name = "Minimizar1"
        Me.Minimizar1.Size = New System.Drawing.Size(17, 15)
        Me.Minimizar1.TabIndex = 7
        Me.Minimizar1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.ChatISA.My.Resources.Resources.conectado1
        Me.PictureBox3.Location = New System.Drawing.Point(362, 126)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 19)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.ChatISA.My.Resources.Resources.fotoperfil11
        Me.PictureBox2.Location = New System.Drawing.Point(61, 106)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Send
        '
        Me.Send.BackColor = System.Drawing.Color.White
        Me.Send.BackgroundImage = CType(resources.GetObject("Send.BackgroundImage"), System.Drawing.Image)
        Me.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Send.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Send.FlatAppearance.BorderSize = 0
        Me.Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Send.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send.Location = New System.Drawing.Point(403, 484)
        Me.Send.Margin = New System.Windows.Forms.Padding(2)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(38, 41)
        Me.Send.TabIndex = 2
        Me.Send.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 622)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rTBChat
        '
        Me.rTBChat.Location = New System.Drawing.Point(61, 206)
        Me.rTBChat.Name = "rTBChat"
        Me.rTBChat.Size = New System.Drawing.Size(338, 221)
        Me.rTBChat.TabIndex = 13
        Me.rTBChat.Text = ""
        '
        'btn_camara
        '
        Me.btn_camara.Location = New System.Drawing.Point(136, 437)
        Me.btn_camara.Name = "btn_camara"
        Me.btn_camara.Size = New System.Drawing.Size(75, 23)
        Me.btn_camara.TabIndex = 14
        Me.btn_camara.Text = "Camara"
        Me.btn_camara.UseVisualStyleBackColor = True
        '
        'Iconitos
        '
        Me.Iconitos.Image = CType(resources.GetObject("Iconitos.Image"), System.Drawing.Image)
        Me.Iconitos.Location = New System.Drawing.Point(95, 432)
        Me.Iconitos.Name = "Iconitos"
        Me.Iconitos.Size = New System.Drawing.Size(35, 32)
        Me.Iconitos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Iconitos.TabIndex = 15
        Me.Iconitos.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 618)
        Me.Controls.Add(Me.Iconitos)
        Me.Controls.Add(Me.btn_camara)
        Me.Controls.Add(Me.rTBChat)
        Me.Controls.Add(Me.Enviar1)
        Me.Controls.Add(Me.Cerrar11)
        Me.Controls.Add(Me.Minimizar1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.txtb_mensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Iconitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtb_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Send As send.Class1
    Friend WithEvents Nombre As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Minimizar1 As Minimizar.Minimizar
    Friend WithEvents Cerrar11 As Close.cerrar1
    Friend WithEvents Enviar1 As Boton_archivos.enviar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rTBChat As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_camara As System.Windows.Forms.Button
    Friend WithEvents Iconitos As System.Windows.Forms.PictureBox

End Class
