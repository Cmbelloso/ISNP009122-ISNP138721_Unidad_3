Public Class Form1

    Dim alumno As New alumno

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        If TxtNombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            TxtCodigo.Text = alumno.generarCodigo(TxtNombre.Text)
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        alumno.datosAlumnos(TxtCodigo.Text,
                           TxtNombre.Text,
                           TxtApellido.Text,
                           TxtGenero.Text,
                           TxtDirección.Text,
                           TxtDui.Text,
                           TxtEdad.Text,
                           TxtCorreo.Text)

        datosAlumnos.Rows.Add(TxtCodigo.Text,
                             alumno.nombreAlumno,
                             alumno.apellidoAlumno,
                             alumno.generoAlumno,
                             alumno.direcciónAlumno,
                             alumno.duiAlumno,
                             alumno.edadAlumno,
                             alumno.correoAlumno)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & "Registrados con Éxito")
        End If

        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtGenero.Text = ""
        TxtDirección.Text = ""
        TxtDui.Text = ""
        TxtEdad.Text = ""
        TxtCorreo.Text = ""

    End Sub
End Class
