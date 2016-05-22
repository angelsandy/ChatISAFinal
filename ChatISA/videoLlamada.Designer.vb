<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class videoLlamada
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
        Me.components = New System.ComponentModel.Container()
        Me.RELOJRECIBEAUDIO = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxRECIBIR = New System.Windows.Forms.PictureBox()
        Me.RELOJWEBCAM = New System.Windows.Forms.Timer(Me.components)
        Me.PictureboxVISOR = New System.Windows.Forms.PictureBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.btn_hablar = New System.Windows.Forms.Button()
        Me.btn_finAudio = New System.Windows.Forms.Button()
        Me.btn_conexionCamara = New System.Windows.Forms.Button()
        Me.recibirVideo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxRECIBIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureboxVISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RELOJRECIBEAUDIO
        '
        '
        'PictureBoxRECIBIR
        '
        Me.PictureBoxRECIBIR.Location = New System.Drawing.Point(4, 13)
        Me.PictureBoxRECIBIR.Name = "PictureBoxRECIBIR"
        Me.PictureBoxRECIBIR.Size = New System.Drawing.Size(618, 486)
        Me.PictureBoxRECIBIR.TabIndex = 0
        Me.PictureBoxRECIBIR.TabStop = False
        '
        'RELOJWEBCAM
        '
        '
        'PictureboxVISOR
        '
        Me.PictureboxVISOR.Location = New System.Drawing.Point(497, 13)
        Me.PictureboxVISOR.Name = "PictureboxVISOR"
        Me.PictureboxVISOR.Size = New System.Drawing.Size(125, 129)
        Me.PictureboxVISOR.TabIndex = 1
        Me.PictureboxVISOR.TabStop = False
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(628, 13)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(44, 23)
        Me.btn_iniciar.TabIndex = 2
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'btn_hablar
        '
        Me.btn_hablar.Location = New System.Drawing.Point(628, 79)
        Me.btn_hablar.Name = "btn_hablar"
        Me.btn_hablar.Size = New System.Drawing.Size(44, 23)
        Me.btn_hablar.TabIndex = 3
        Me.btn_hablar.Text = "Hablar"
        Me.btn_hablar.UseVisualStyleBackColor = True
        '
        'btn_finAudio
        '
        Me.btn_finAudio.Location = New System.Drawing.Point(628, 108)
        Me.btn_finAudio.Name = "btn_finAudio"
        Me.btn_finAudio.Size = New System.Drawing.Size(44, 23)
        Me.btn_finAudio.TabIndex = 4
        Me.btn_finAudio.Text = "Fin"
        Me.btn_finAudio.UseVisualStyleBackColor = True
        '
        'btn_conexionCamara
        '
        Me.btn_conexionCamara.Location = New System.Drawing.Point(629, 156)
        Me.btn_conexionCamara.Name = "btn_conexionCamara"
        Me.btn_conexionCamara.Size = New System.Drawing.Size(43, 23)
        Me.btn_conexionCamara.TabIndex = 5
        Me.btn_conexionCamara.Text = "Conectar"
        Me.btn_conexionCamara.UseVisualStyleBackColor = True
        '
        'recibirVideo
        '
        '
        'videoLlamada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 511)
        Me.Controls.Add(Me.btn_conexionCamara)
        Me.Controls.Add(Me.btn_finAudio)
        Me.Controls.Add(Me.btn_hablar)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.PictureboxVISOR)
        Me.Controls.Add(Me.PictureBoxRECIBIR)
        Me.Name = "videoLlamada"
        Me.Text = "videoLlamada"
        CType(Me.PictureBoxRECIBIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureboxVISOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RELOJRECIBEAUDIO As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxRECIBIR As System.Windows.Forms.PictureBox
    Friend WithEvents RELOJWEBCAM As System.Windows.Forms.Timer
    Friend WithEvents PictureboxVISOR As System.Windows.Forms.PictureBox
    Friend WithEvents btn_iniciar As System.Windows.Forms.Button
    Friend WithEvents btn_hablar As System.Windows.Forms.Button
    Friend WithEvents btn_finAudio As System.Windows.Forms.Button
    Friend WithEvents btn_conexionCamara As System.Windows.Forms.Button
    Friend WithEvents recibirVideo As System.Windows.Forms.Timer
End Class
