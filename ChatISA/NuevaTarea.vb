Imports System
Imports System.IO
Imports System.Collections
Imports System.Data.Odbc
Imports ADODB
Imports MySql.Data.MySqlClient

Public Class NuevaTarea
    Dim IpGet As login
    Dim datosUsuario As User
    Dim connect As New conexionMySQL
    Friend conexion As MySqlConnection
    Dim cantRegistros As Integer
    Dim localizarY As Integer
    Dim conRow As Integer
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaProyecto.SelectedIndexChanged
        Check()
    End Sub
    Sub Check()
        Dim item As String
        For i As Integer = 0 To ListaProyecto.Items.Count - 1
            If (ListaProyecto.GetItemChecked(i)) Then
                item = ListaProyecto.CheckedItems(i).ToString
                Dim sql As String = "Update Tarea Set activo = 0 where nombreTareas ='" & item & "';"
                connect.ComandoSQL(sql, "Tarea", 0, 0)
            Else
                item = ListaProyecto.CheckedItems(i).ToString
                Dim sql As String = "Update Tarea Set activo = 1 where nombreTareas ='" & item & "';"
                connect.ComandoSQL(sql, "Tarea", 0, 0)
            End If
        Next i

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Cerrar11_Click(sender As Object, e As EventArgs) Handles Cerrar11.Click
        Me.Hide()
    End Sub

    Private Sub proyectonuevo_TextChanged(sender As Object, e As EventArgs) Handles proyectonuevo.TextChanged

    End Sub

    Private Sub Cerrar12_Click(sender As Object, e As EventArgs) Handles Cerrar12.Click
        Dim sqlInsert As String = "Insert into Tarea values (null, '" & proyectonuevo.Text & "',1,'" & FechaEntrega.Text & "', 1);"
        ListaProyecto.Items.Add(proyectonuevo.Text)
        connect.ComandoSQL(sqlInsert, "Tarea", 0, 5)
    End Sub


    Private Sub NuevaTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlselect As String = "SELECT * FROM isa_1.tarea;"
        connect.ComandoSQL(sqlselect, "tarea", 6, 0)
        cantRegistros = DataGridView1.Rows.Count

        conRow = 0
        localizarY = 0
        While (cantRegistros <> 0)
            ListaProyecto.Items.Add(DataGridView1.Rows(conRow).Cells(1).Value)
            If (DataGridView1.Rows(conRow).Cells(2).Value <> 1) Then
                ListaProyecto.Items.Add(DataGridView1.Rows(conRow).Cells(1).Value, True)
            Else
                ListaProyecto.Items.Add(DataGridView1.Rows(conRow).Cells(1).Value, False)
            End If
            cantRegistros -= 1
            conRow += 1

        End While
    End Sub

    Private Sub nombreProyecto_Click(sender As Object, e As EventArgs) Handles nombreProyecto.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class