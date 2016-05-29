Public Class Perfil
    Dim myForm2 As New NuevaTarea
    Dim DataGet As User
    Dim listaContactos1 As New listaContactos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        myForm2.Show()
    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nombre.Text = DataGet.userName
    End Sub

    Private Sub listaContactos_Click(sender As Object, e As EventArgs) Handles listaContactos.Click
        Me.Hide()
        listaContactos1.Show()
    End Sub
End Class