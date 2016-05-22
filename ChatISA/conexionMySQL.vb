Imports MySql.Data.MySqlClient

Public Class conexionMySQL

    Dim cadena = "server=localhost; user id=root; password=arce;"
    Dim cadenaTemp
    Dim conexion As New MySqlConnection(cadena)
    Dim cmd As New MySqlCommand
    Dim bd = "use ISA_1; "

    Dim dr As MySqlDataReader
    Dim ds As New DataSet

    Public Sub ComandoSQL(ByVal codigoSql1 As String, ByVal tablas As String, ByVal formulario As Integer, ByVal subProceso As Integer)

        cmd.Connection = conexion
        cmd.CommandText = bd + codigoSql1
        conexion.Open()
        dr = cmd.ExecuteReader()
        ds.Load(dr, LoadOption.PreserveChanges, (tablas))

        Select Case (formulario)
            Case 0
            Case 1
                listaContactos.dgv_listaContacto.DataSource = ds.Tables(tablas)
            Case 3
                listaContactos.cmbx_grupo.DataSource = ds.Tables(tablas)
                listaContactos.cmbx_grupo.DisplayMember = "nombreGrupoUsuarios"
                listaContactos.cmbx_grupo.ValueMember = "idGrupoChat"
            Case 4
                listaContactos.dgv_gurpo.DataSource = ds.Tables(tablas)
        End Select

        dr.Close()
        conexion.Close()
    End Sub

    Public Sub LimpiarGrid(ByVal GridALimpiar As DataGridView)
        Dim dt As DataTable
        dt = CType(GridALimpiar.DataSource, DataTable)
        dt.Rows.Clear()
    End Sub

    Public Sub LimpiarCombo(ByVal ComboALimpiar As ComboBox)
        Dim dt As DataTable
        dt = CType(ComboALimpiar.DataSource, DataTable)
        dt.Rows.Clear()
    End Sub

End Class
