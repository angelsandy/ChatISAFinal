Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Iconos
    'form para los íconos del chat
    Dim pb As PictureBox
    Public nuevoPb As PictureBox
    Public nuevoPb2 As PictureBox
    Public seleccion As UInteger
    Dim nombre As String
    Public stringDataIconos As String
    Const tamX = 35, tamY = 35

    Public Sub PictureBoxHandler(sender As Object, e As System.EventArgs) Handles alegre.Click, cool.Click, corazon.Click, corazon2.Click, decepcion.Click, dislike.Click, alegre.Click, genial.Click, laic.Click, llanto.Click, muyEnojado.Click, noSe.Click, pensativo.Click, sorprendido.Click, smiley.Click, llorar.Click, die.Click

        pb = DirectCast(sender, PictureBox)
        nombre = pb.Tag.ToString()

        'leemos cual fue el que se seleccionó
        Select Case (nombre)
            Case "=D"
                'MsgBox("Exito")
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case ":)"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "^^"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case ":D"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "B3"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "=o"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "(L)"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case ":("
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case ":/"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "='("
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "u.u"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "x-x"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "D:<"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                'Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "(D)"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "<3"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True
                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

            Case "</3"
                nuevoPb = New PictureBox
                nuevoPb.Visible = False
                nuevoPb.Name = pb.Name
                nuevoPb.Tag = pb.Tag
                nuevoPb.SizeMode = pb.SizeMode
                nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
                nuevoPb.Image = pb.Image
                nuevoPb.Visible = True

                Form1.crearIcono()
                ' Form1.server.Send(Encoding.ASCII.GetBytes(nuevoPb.Tag))

        End Select

    End Sub

    Public Sub RevisarMensaje(mensaje As String)
        Dim encontrado As Integer = 0

        encontrado = InStr(mensaje, ":,D")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "smiley"
            nuevoPb.Tag = "=D"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.alegre
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ":)")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "feliz"
            nuevoPb.Tag = ":)"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.feliz
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "^^")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "genial"
            nuevoPb.Tag = "^^"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.genial
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ":D")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "smile"
            nuevoPb.Tag = ":D"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.smile
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "B3")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "cool"
            nuevoPb.Tag = "B3"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.cool
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "=O")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "sorprendido"
            nuevoPb.Tag = "=O"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.sorprendido
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "(L)")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "laic"
            nuevoPb.Tag = "(L)"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.laic
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ":(")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "triste"
            nuevoPb.Tag = ":("
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.triste
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ":/")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "noSe"
            nuevoPb.Tag = ":/"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.noSe
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ":,(")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "llanto"
            nuevoPb.Tag = ":,("
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.llanto
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "u.u")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "decepcion"
            nuevoPb.Tag = "u.u"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.decepcion
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, ">_>")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "pensativo"
            nuevoPb.Tag = ">_>"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.pensativo
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "D:<")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "muyEnojado"
            nuevoPb.Tag = "D:<"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.muyEnojado
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "(D)")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "dislike"
            nuevoPb.Tag = "(D)"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.dislike
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "<3")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "corazon"
            nuevoPb.Tag = "<3"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "</3")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "corazon2"
            nuevoPb.Tag = "</3"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon2
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If

        encontrado = InStr(mensaje, "x-x")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "die"
            nuevoPb.Tag = "x-x"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If
        encontrado = InStr(mensaje, "='(")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "llorar"
            nuevoPb.Tag = "='("
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If
        encontrado = InStr(mensaje, "=D")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "smiley"
            nuevoPb.Tag = "=D"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If
        encontrado = InStr(mensaje, "=o")
        If encontrado > 0 Then
            nuevoPb = New PictureBox
            nuevoPb.Visible = False
            nuevoPb.Name = "sorprendido"
            nuevoPb.Tag = "=o"
            nuevoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            nuevoPb.Size = New System.Drawing.Size(tamX, tamY)
            nuevoPb.Image = Global.ChatISA.My.Resources.corazon
            nuevoPb.Visible = True
            Form1.crearIcono()
        End If
    End Sub

    Private Sub Iconos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cerrar11_Click(sender As Object, e As EventArgs) Handles Cerrar11.Click
        Me.Hide()
    End Sub
End Class