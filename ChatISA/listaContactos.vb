Imports System
Imports System.IO
Imports System.Collections
Imports System.Data.Odbc
Imports ADODB
Imports MySql.Data.MySqlClient


Public Class listaContactos
    Dim conect As New conexionMySQL
    Friend conexion As MySqlConnection

    Public conexionBD As OdbcConnection
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Dim sql As String = "validarAgregarContacto(1, '" & txt_correo.Text & "', '" & cmbx_grupo.Text & "') "
        conect.ComandoSQL(sql, "usuario", 0, 0)

        conect.LimpiarGrid(dgv_listaContacto)
        cargarGrid()

        txt_correo.Text = ""

    End Sub

    Private Sub listaContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()
        cargarCombo()

    End Sub

    Private Sub cargarGrid()
        Dim sql As String = "select idUsuario, nombreUsuario, correoUsuario from usuario;"
        conect.ComandoSQL(sql, "usuario", 1, 0)

        sql = "select idGrupoChat, nombreGrupoUsuarios, pathConversacion from grupoChat;"
        conect.ComandoSQL(sql, "grupoChat", 4, 0)
    End Sub

    Private Sub cargarCombo()
        Dim sql As String = "select idGrupoChat, nombreGrupoUsuarios from grupoChat;"
        conect.ComandoSQL(sql, "grupoChat", 3, 0)
    End Sub


    Private Sub dgv_listaContacto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaContacto.CellContentClick
        txt_id.Text = dgv_listaContacto.CurrentRow.Cells.Item("idUsuario").Value
        txt_correo.Text = dgv_listaContacto.CurrentRow.Cells.Item("correoUsuario").Value

        Dim nombreDestinoP = dgv_listaContacto.CurrentRow.Cells.Item("nombreUsuario").Value

        Dim form2 As New Form1("Arce", nombreDestinoP, "Conectado", login.txtb_IP.Text, "p")
        form2.Show()

    End Sub

    Private Sub dgv_gurpo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gurpo.CellContentClick
        Dim nombreDestinoP = dgv_listaContacto.CurrentRow.Cells.Item("nombreUsuario").Value

        Dim form2 As New Form1("Arce", nombreDestinoP, "Conectado", login.txtb_IP.Text, "g")
        form2.Show()
    End Sub
End Class