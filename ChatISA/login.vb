Imports System
Imports System.IO
Imports System.Collections
Imports System.Data.Odbc
Imports ADODB
Imports MySql.Data.MySqlClient

Public Class login
    Dim conect As New conexionMySQL
    Friend conexion As MySqlConnection

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click

        Dim sql As String = "call agregarUsuario('" & txtb_usuarion.Text & "', '" & txtb_contrasenian.Text & "', '" & txtb_file.Text & "','" & txt_correon.Text & "', '" & txtb_IPn.Text & "' );"
        conect.ComandoSQL(sql, "usuario", 0, 0)
        listaContactos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_acceder_Click(sender As Object, e As EventArgs) Handles btn_acceder.Click
        validacion()
        listaContactos.Show()
    End Sub

    Private Sub validacion()
        Dim sql As String = " select validarUsuario( '" & txtb_correo.Text & "', '" & txtb_contrasenia.Text & "', '" & txtb_IP.Text & "' )"
        conect.ComandoSQL(sql, "usuario", 0, 0)

    End Sub

    Private Sub fbtn_file_Click(sender As Object, e As EventArgs) Handles fbtn_file.Click
        OpenFileDialog1.Filter = "Text File (*.txt)| * .txt; | PDF File (*.pdf)| * .pdf;| Word File (*.doc,*.docx)| *.doc;*.docx;  "
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtb_file.Text = OpenFileDialog1.FileName
        End If
    End Sub

End Class
