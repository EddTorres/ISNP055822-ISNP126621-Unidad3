Public Class Form1
    Dim Alumno As New Alumno
    Private Sub btnAgregar_click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Alumno.datosAlumno(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtSexo.Text, txtDireccion.Text, txtEdad.Text, txtCorreo.Text, mskID.Text)

        datosAlumno.Rows.Add(txtCodigo.Text,
                             Alumno.NombreAlumno,
                             Alumno.ApellidoAlumno,
                             Alumno.EdadAlumno,
                             Alumno.SexoAlumno,
                             Alumno.IDAlumno,
                             Alumno.CorreoAlumno,
                             Alumno.DireccionAlumno)

        If Alumno.datosAceptados Then
            MsgBox("Alumno " & Alumno.NombreAlumno & " resgistrado")
        Else

        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEdad.Text = ""
        txtSexo.Text = ""
        mskID.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""

    End Sub

    Private Sub btnGenerar_click(sender As Object, e As EventArgs) Handles btnGenerar.click
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")
        Else
            txtCodigo.Text = Alumno.generarCodigo(txtNombre.Text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub grpDatos_Enter(sender As Object, e As EventArgs) Handles grpDatos.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datosAlumno.CellContentClick

    End Sub
End Class