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
        Dim contra As String = txtb_contrasenian.ToString()
        Dim contra2 As String = TestEncoding(contra)

        Dim sql As String = "call agregarUsuario('" & txtb_usuarion.Text & "', '" & contra2 & "', '" & txtb_file.Text & "','" & txt_correon.Text & "', '" & txtb_IPn.Text & "' );"

        conect.ComandoSQL(sql, "usuario", 0, 0)
        listaContactos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_acceder_Click(sender As Object, e As EventArgs) Handles btn_acceder.Click
        validacion()
        Perfil.Show()
    End Sub

    Private Sub validacion()
        Dim contra As String = txtb_contrasenia.ToString()
        Dim contra2 As String = TestEncoding(contra)
        Dim sql As String = " select validarUsuario( '" & txtb_correo.Text & "', '" & contra2 & "', '" & txtb_IP.Text & "' )"
        conect.ComandoSQL(sql, "usuario", 0, 0)
    End Sub

    Private Sub fbtn_file_Click(sender As Object, e As EventArgs) Handles fbtn_file.Click
        OpenFileDialog1.Filter = "Text File (*.txt)| * .txt; | PDF File (*.pdf)| * .pdf;| Word File (*.doc,*.docx)| *.doc;*.docx;  "
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtb_file.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Function TestEncoding(pass As String)
        Dim plainText As String = pass
        Dim password As String = ""

        Dim wrapper As New EncryptDecryptVB(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)


        My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
        Return cipherText
    End Function

    'Funcion para Desencriptar
    Sub TestDecoding(ByVal pass As String)
        Dim cipherText As String = pass
        Dim password As String = ""
        Dim wrapper As New EncryptDecryptVB(password)

        'DecryptData throws if the wrong password is used
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)

        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try

    End Sub

    Private Sub rdb_IPn_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_IPn.CheckedChanged
        If rdb_IPn.Checked Then
            Me.cmbx_IP.Enabled = False
            Me.txtb_IP.Enabled = True

        End If
    End Sub

    Private Sub rdb_IP_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_IP.CheckedChanged
        If rdb_IP.Checked Then
            Me.txtb_IP.Enabled = False
            Me.cmbx_IP.Enabled = True
        End If
    End Sub

    Private Sub cmbx_IP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbx_IP.SelectedIndexChanged


    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select ip from usuario;"
        conect.ComandoSQL(sql, "usuario", 5, 0)
    End Sub
End Class
