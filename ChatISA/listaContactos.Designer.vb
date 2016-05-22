<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaContactos
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
        Me.dgv_listaContacto = New System.Windows.Forms.DataGridView()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagenPerfil = New System.Windows.Forms.DataGridViewImageColumn()
        Me.nombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoUsuario = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.cmbx_grupo = New System.Windows.Forms.ComboBox()
        Me.dgv_gurpo = New System.Windows.Forms.DataGridView()
        Me.idGrupoChat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreGrupoUsuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pathConversacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_listaContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_gurpo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listaContacto
        '
        Me.dgv_listaContacto.AllowUserToAddRows = False
        Me.dgv_listaContacto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_listaContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaContacto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.correoUsuario, Me.imagenPerfil, Me.nombreUsuario, Me.estadoUsuario})
        Me.dgv_listaContacto.Location = New System.Drawing.Point(12, 116)
        Me.dgv_listaContacto.Name = "dgv_listaContacto"
        Me.dgv_listaContacto.ReadOnly = True
        Me.dgv_listaContacto.Size = New System.Drawing.Size(548, 171)
        Me.dgv_listaContacto.TabIndex = 0
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.HeaderText = "ID"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        '
        'correoUsuario
        '
        Me.correoUsuario.DataPropertyName = "correoUsuario"
        Me.correoUsuario.HeaderText = "Correo"
        Me.correoUsuario.Name = "correoUsuario"
        Me.correoUsuario.ReadOnly = True
        '
        'imagenPerfil
        '
        Me.imagenPerfil.HeaderText = "Perfil"
        Me.imagenPerfil.Name = "imagenPerfil"
        Me.imagenPerfil.ReadOnly = True
        '
        'nombreUsuario
        '
        Me.nombreUsuario.DataPropertyName = "nombreUsuario"
        Me.nombreUsuario.HeaderText = "Nombre"
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.ReadOnly = True
        Me.nombreUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombreUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'estadoUsuario
        '
        Me.estadoUsuario.HeaderText = "Estado"
        Me.estadoUsuario.Name = "estadoUsuario"
        Me.estadoUsuario.ReadOnly = True
        Me.estadoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.estadoUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(383, 38)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar contacto"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.Location = New System.Drawing.Point(27, 21)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(38, 13)
        Me.lbl_correo.TabIndex = 3
        Me.lbl_correo.Text = "Correo"
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(40, 38)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(316, 20)
        Me.txt_correo.TabIndex = 5
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Location = New System.Drawing.Point(27, 62)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(36, 13)
        Me.lbl_grupo.TabIndex = 7
        Me.lbl_grupo.Text = "Grupo"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(40, -11)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(33, 20)
        Me.txt_id.TabIndex = 9
        Me.txt_id.Visible = False
        '
        'cmbx_grupo
        '
        Me.cmbx_grupo.FormattingEnabled = True
        Me.cmbx_grupo.Location = New System.Drawing.Point(40, 78)
        Me.cmbx_grupo.Name = "cmbx_grupo"
        Me.cmbx_grupo.Size = New System.Drawing.Size(316, 21)
        Me.cmbx_grupo.TabIndex = 10
        '
        'dgv_gurpo
        '
        Me.dgv_gurpo.AllowUserToAddRows = False
        Me.dgv_gurpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gurpo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idGrupoChat, Me.nombreGrupoUsuarios, Me.pathConversacion})
        Me.dgv_gurpo.Location = New System.Drawing.Point(12, 293)
        Me.dgv_gurpo.Name = "dgv_gurpo"
        Me.dgv_gurpo.ReadOnly = True
        Me.dgv_gurpo.Size = New System.Drawing.Size(446, 167)
        Me.dgv_gurpo.TabIndex = 12
        '
        'idGrupoChat
        '
        Me.idGrupoChat.DataPropertyName = "idGrupoChat"
        Me.idGrupoChat.HeaderText = "ID"
        Me.idGrupoChat.Name = "idGrupoChat"
        Me.idGrupoChat.ReadOnly = True
        '
        'nombreGrupoUsuarios
        '
        Me.nombreGrupoUsuarios.DataPropertyName = "nombreGrupoUsuarios"
        Me.nombreGrupoUsuarios.HeaderText = "Grupo"
        Me.nombreGrupoUsuarios.Name = "nombreGrupoUsuarios"
        Me.nombreGrupoUsuarios.ReadOnly = True
        '
        'pathConversacion
        '
        Me.pathConversacion.DataPropertyName = "pathConversacion"
        Me.pathConversacion.HeaderText = "Path"
        Me.pathConversacion.Name = "pathConversacion"
        Me.pathConversacion.ReadOnly = True
        '
        'listaContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 488)
        Me.Controls.Add(Me.dgv_gurpo)
        Me.Controls.Add(Me.cmbx_grupo)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_grupo)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.lbl_correo)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_listaContacto)
        Me.MinimizeBox = False
        Me.Name = "listaContactos"
        Me.Text = "listaContactos"
        CType(Me.dgv_listaContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_gurpo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_listaContacto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_correo As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_grupo As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents cmbx_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_gurpo As System.Windows.Forms.DataGridView
    Friend WithEvents idGrupoChat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreGrupoUsuarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pathConversacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correoUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imagenPerfil As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents nombreUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoUsuario As System.Windows.Forms.DataGridViewImageColumn
End Class
