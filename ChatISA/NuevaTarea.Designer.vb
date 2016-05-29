<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaTarea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaTarea))
        Me.ListaProyecto = New System.Windows.Forms.CheckedListBox()
        Me.proyectonuevo = New System.Windows.Forms.TextBox()
        Me.nombreProyecto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cerrar12 = New Close.cerrar1()
        Me.Cerrar11 = New Close.cerrar1()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.idTarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreTareas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaTarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaProyecto
        '
        Me.ListaProyecto.BackColor = System.Drawing.Color.Linen
        Me.ListaProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaProyecto.CheckOnClick = True
        Me.ListaProyecto.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaProyecto.FormattingEnabled = True
        Me.ListaProyecto.Location = New System.Drawing.Point(154, 281)
        Me.ListaProyecto.Name = "ListaProyecto"
        Me.ListaProyecto.Size = New System.Drawing.Size(291, 207)
        Me.ListaProyecto.TabIndex = 1
        '
        'proyectonuevo
        '
        Me.proyectonuevo.BackColor = System.Drawing.Color.Linen
        Me.proyectonuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.proyectonuevo.Location = New System.Drawing.Point(154, 507)
        Me.proyectonuevo.Name = "proyectonuevo"
        Me.proyectonuevo.Size = New System.Drawing.Size(291, 22)
        Me.proyectonuevo.TabIndex = 2
        '
        'nombreProyecto
        '
        Me.nombreProyecto.BackColor = System.Drawing.Color.Linen
        Me.nombreProyecto.Font = New System.Drawing.Font("Elephant", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreProyecto.Location = New System.Drawing.Point(154, 101)
        Me.nombreProyecto.Name = "nombreProyecto"
        Me.nombreProyecto.Size = New System.Drawing.Size(308, 51)
        Me.nombreProyecto.TabIndex = 11
        Me.nombreProyecto.Text = "Proyectos"
        Me.nombreProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Linen
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Subtareas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FechaEntrega
        '
        Me.FechaEntrega.CustomFormat = "yyyy-MM-dd"
        Me.FechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaEntrega.Location = New System.Drawing.Point(154, 535)
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.Size = New System.Drawing.Size(291, 22)
        Me.FechaEntrega.TabIndex = 13
        Me.FechaEntrega.Value = New Date(2016, 5, 17, 0, 0, 0, 0)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTarea, Me.nombreTareas, Me.fechaTarea, Me.activo})
        Me.DataGridView1.Location = New System.Drawing.Point(414, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(151, 150)
        Me.DataGridView1.TabIndex = 14
        Me.DataGridView1.Visible = False
        '
        'Cerrar12
        '
        Me.Cerrar12.BackColor = System.Drawing.Color.Linen
        Me.Cerrar12.BackgroundImage = CType(resources.GetObject("Cerrar12.BackgroundImage"), System.Drawing.Image)
        Me.Cerrar12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Cerrar12.FlatAppearance.BorderSize = 0
        Me.Cerrar12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cerrar12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cerrar12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar12.Location = New System.Drawing.Point(112, 506)
        Me.Cerrar12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cerrar12.Name = "Cerrar12"
        Me.Cerrar12.Size = New System.Drawing.Size(26, 21)
        Me.Cerrar12.TabIndex = 10
        Me.Cerrar12.UseVisualStyleBackColor = False
        '
        'Cerrar11
        '
        Me.Cerrar11.BackColor = System.Drawing.Color.Linen
        Me.Cerrar11.BackgroundImage = CType(resources.GetObject("Cerrar11.BackgroundImage"), System.Drawing.Image)
        Me.Cerrar11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Cerrar11.FlatAppearance.BorderSize = 0
        Me.Cerrar11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cerrar11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cerrar11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar11.Location = New System.Drawing.Point(470, 56)
        Me.Cerrar11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cerrar11.Name = "Cerrar11"
        Me.Cerrar11.Size = New System.Drawing.Size(21, 16)
        Me.Cerrar11.TabIndex = 9
        Me.Cerrar11.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ChatISA.My.Resources.Resources._13224096_10209627468987908_110713128_o
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 773)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'idTarea
        '
        Me.idTarea.DataPropertyName = "idTarea"
        Me.idTarea.HeaderText = "tarea"
        Me.idTarea.Name = "idTarea"
        Me.idTarea.ReadOnly = True
        '
        'nombreTareas
        '
        Me.nombreTareas.DataPropertyName = "nombreTareas"
        Me.nombreTareas.HeaderText = "Column1"
        Me.nombreTareas.Name = "nombreTareas"
        Me.nombreTareas.ReadOnly = True
        '
        'fechaTarea
        '
        Me.fechaTarea.DataPropertyName = "fechaTarea"
        Me.fechaTarea.HeaderText = "Column1"
        Me.fechaTarea.Name = "fechaTarea"
        Me.fechaTarea.ReadOnly = True
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.HeaderText = "Column1"
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        '
        'NuevaTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 620)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FechaEntrega)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombreProyecto)
        Me.Controls.Add(Me.Cerrar12)
        Me.Controls.Add(Me.Cerrar11)
        Me.Controls.Add(Me.proyectonuevo)
        Me.Controls.Add(Me.ListaProyecto)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaTarea"
        Me.Text = "Nueva_Tarea"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListaProyecto As System.Windows.Forms.CheckedListBox
    Friend WithEvents proyectonuevo As System.Windows.Forms.TextBox
    Friend WithEvents Cerrar11 As Close.cerrar1
    Friend WithEvents Cerrar12 As Close.cerrar1
    Friend WithEvents nombreProyecto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents idTarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreTareas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaTarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents activo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
