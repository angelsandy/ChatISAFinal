<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_acceder = New System.Windows.Forms.Button()
        Me.txtb_contrasenia = New System.Windows.Forms.TextBox()
        Me.txtb_correo = New System.Windows.Forms.TextBox()
        Me.lbl_contrasenia = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_usuarion = New System.Windows.Forms.Label()
        Me.lbl_contreasenian = New System.Windows.Forms.Label()
        Me.txtb_file = New System.Windows.Forms.TextBox()
        Me.txtb_usuarion = New System.Windows.Forms.TextBox()
        Me.fbtn_file = New System.Windows.Forms.Button()
        Me.txtb_contrasenian = New System.Windows.Forms.TextBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.lbl_ip = New System.Windows.Forms.Label()
        Me.txtb_IPn = New System.Windows.Forms.TextBox()
        Me.lbl_ipa = New System.Windows.Forms.Label()
        Me.txtb_IP = New System.Windows.Forms.TextBox()
        Me.lbl_correon = New System.Windows.Forms.Label()
        Me.txt_correon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_acceder
        '
        Me.btn_acceder.Location = New System.Drawing.Point(236, 229)
        Me.btn_acceder.Name = "btn_acceder"
        Me.btn_acceder.Size = New System.Drawing.Size(121, 23)
        Me.btn_acceder.TabIndex = 22
        Me.btn_acceder.Text = "Acceder"
        Me.btn_acceder.UseVisualStyleBackColor = True
        '
        'txtb_contrasenia
        '
        Me.txtb_contrasenia.Location = New System.Drawing.Point(236, 123)
        Me.txtb_contrasenia.Name = "txtb_contrasenia"
        Me.txtb_contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtb_contrasenia.Size = New System.Drawing.Size(121, 20)
        Me.txtb_contrasenia.TabIndex = 21
        '
        'txtb_correo
        '
        Me.txtb_correo.Location = New System.Drawing.Point(236, 83)
        Me.txtb_correo.Name = "txtb_correo"
        Me.txtb_correo.Size = New System.Drawing.Size(121, 20)
        Me.txtb_correo.TabIndex = 20
        '
        'lbl_contrasenia
        '
        Me.lbl_contrasenia.AutoSize = True
        Me.lbl_contrasenia.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_contrasenia.Location = New System.Drawing.Point(230, 106)
        Me.lbl_contrasenia.Name = "lbl_contrasenia"
        Me.lbl_contrasenia.Size = New System.Drawing.Size(61, 13)
        Me.lbl_contrasenia.TabIndex = 19
        Me.lbl_contrasenia.Text = "Contraseña"
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_correo.Location = New System.Drawing.Point(230, 66)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(38, 13)
        Me.lbl_correo.TabIndex = 18
        Me.lbl_correo.Text = "Correo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_usuarion
        '
        Me.lbl_usuarion.AutoSize = True
        Me.lbl_usuarion.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_usuarion.Location = New System.Drawing.Point(46, 106)
        Me.lbl_usuarion.Name = "lbl_usuarion"
        Me.lbl_usuarion.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuarion.TabIndex = 26
        Me.lbl_usuarion.Text = "Usuario"
        '
        'lbl_contreasenian
        '
        Me.lbl_contreasenian.AutoSize = True
        Me.lbl_contreasenian.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_contreasenian.Location = New System.Drawing.Point(46, 146)
        Me.lbl_contreasenian.Name = "lbl_contreasenian"
        Me.lbl_contreasenian.Size = New System.Drawing.Size(61, 13)
        Me.lbl_contreasenian.TabIndex = 27
        Me.lbl_contreasenian.Text = "Contraseña"
        '
        'txtb_file
        '
        Me.txtb_file.Location = New System.Drawing.Point(52, 246)
        Me.txtb_file.Name = "txtb_file"
        Me.txtb_file.Size = New System.Drawing.Size(87, 20)
        Me.txtb_file.TabIndex = 33
        '
        'txtb_usuarion
        '
        Me.txtb_usuarion.Location = New System.Drawing.Point(52, 123)
        Me.txtb_usuarion.Name = "txtb_usuarion"
        Me.txtb_usuarion.Size = New System.Drawing.Size(121, 20)
        Me.txtb_usuarion.TabIndex = 28
        '
        'fbtn_file
        '
        Me.fbtn_file.Location = New System.Drawing.Point(145, 243)
        Me.fbtn_file.Name = "fbtn_file"
        Me.fbtn_file.Size = New System.Drawing.Size(28, 23)
        Me.fbtn_file.TabIndex = 32
        Me.fbtn_file.Text = "..."
        Me.fbtn_file.UseVisualStyleBackColor = True
        '
        'txtb_contrasenian
        '
        Me.txtb_contrasenian.Location = New System.Drawing.Point(52, 163)
        Me.txtb_contrasenian.Name = "txtb_contrasenian"
        Me.txtb_contrasenian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtb_contrasenian.Size = New System.Drawing.Size(121, 20)
        Me.txtb_contrasenian.TabIndex = 29
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_foto.Location = New System.Drawing.Point(49, 229)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(68, 13)
        Me.lbl_foto.TabIndex = 31
        Me.lbl_foto.Text = "Foto de perfil"
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(52, 282)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(121, 23)
        Me.btn_crear.TabIndex = 30
        Me.btn_crear.Text = "Crear cuenta"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'lbl_ip
        '
        Me.lbl_ip.AutoSize = True
        Me.lbl_ip.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_ip.Location = New System.Drawing.Point(46, 186)
        Me.lbl_ip.Name = "lbl_ip"
        Me.lbl_ip.Size = New System.Drawing.Size(17, 13)
        Me.lbl_ip.TabIndex = 34
        Me.lbl_ip.Text = "IP"
        '
        'txtb_IPn
        '
        Me.txtb_IPn.Location = New System.Drawing.Point(52, 203)
        Me.txtb_IPn.Name = "txtb_IPn"
        Me.txtb_IPn.Size = New System.Drawing.Size(121, 20)
        Me.txtb_IPn.TabIndex = 35
        '
        'lbl_ipa
        '
        Me.lbl_ipa.AutoSize = True
        Me.lbl_ipa.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_ipa.Location = New System.Drawing.Point(230, 146)
        Me.lbl_ipa.Name = "lbl_ipa"
        Me.lbl_ipa.Size = New System.Drawing.Size(17, 13)
        Me.lbl_ipa.TabIndex = 36
        Me.lbl_ipa.Text = "IP"
        '
        'txtb_IP
        '
        Me.txtb_IP.Location = New System.Drawing.Point(236, 163)
        Me.txtb_IP.Name = "txtb_IP"
        Me.txtb_IP.Size = New System.Drawing.Size(121, 20)
        Me.txtb_IP.TabIndex = 37
        '
        'lbl_correon
        '
        Me.lbl_correon.AutoSize = True
        Me.lbl_correon.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl_correon.Location = New System.Drawing.Point(46, 66)
        Me.lbl_correon.Name = "lbl_correon"
        Me.lbl_correon.Size = New System.Drawing.Size(38, 13)
        Me.lbl_correon.TabIndex = 38
        Me.lbl_correon.Text = "Correo"
        '
        'txt_correon
        '
        Me.txt_correon.Location = New System.Drawing.Point(52, 83)
        Me.txt_correon.Name = "txt_correon"
        Me.txt_correon.Size = New System.Drawing.Size(121, 20)
        Me.txt_correon.TabIndex = 39
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ChatISA.My.Resources.Resources.post_it
        Me.ClientSize = New System.Drawing.Size(412, 331)
        Me.Controls.Add(Me.lbl_correon)
        Me.Controls.Add(Me.txt_correon)
        Me.Controls.Add(Me.lbl_ipa)
        Me.Controls.Add(Me.txtb_IP)
        Me.Controls.Add(Me.lbl_ip)
        Me.Controls.Add(Me.txtb_IPn)
        Me.Controls.Add(Me.lbl_correo)
        Me.Controls.Add(Me.lbl_usuarion)
        Me.Controls.Add(Me.lbl_contrasenia)
        Me.Controls.Add(Me.lbl_contreasenian)
        Me.Controls.Add(Me.btn_acceder)
        Me.Controls.Add(Me.txtb_correo)
        Me.Controls.Add(Me.txtb_contrasenia)
        Me.Controls.Add(Me.txtb_file)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.txtb_usuarion)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.fbtn_file)
        Me.Controls.Add(Me.txtb_contrasenian)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_acceder As System.Windows.Forms.Button
    Friend WithEvents txtb_contrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txtb_correo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_contrasenia As System.Windows.Forms.Label
    Friend WithEvents lbl_correo As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_usuarion As System.Windows.Forms.Label
    Friend WithEvents lbl_contreasenian As System.Windows.Forms.Label
    Friend WithEvents txtb_file As System.Windows.Forms.TextBox
    Friend WithEvents txtb_usuarion As System.Windows.Forms.TextBox
    Friend WithEvents fbtn_file As System.Windows.Forms.Button
    Friend WithEvents txtb_contrasenian As System.Windows.Forms.TextBox
    Friend WithEvents lbl_foto As System.Windows.Forms.Label
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents lbl_ip As System.Windows.Forms.Label
    Friend WithEvents txtb_IPn As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ipa As System.Windows.Forms.Label
    Friend WithEvents txtb_IP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_correon As System.Windows.Forms.Label
    Friend WithEvents txt_correon As System.Windows.Forms.TextBox
End Class
