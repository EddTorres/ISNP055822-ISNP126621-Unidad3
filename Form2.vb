Public Class Form2
    Dim Autos As New Auto
    Private Sub btnAgregar_click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Autos.datosAlumno(txtMarca.Text, txtModelo.Text, cbxColor.Text, txtAño.Text, txtCombustible.Text)

        datosAlumno.Rows.Add(
                             Autos.MarcaAuto,
                             Autos.ModeloAuto,
                             Autos.AñoAuto,
                             Autos.CombustibleAuto,
                             Autos.ColorAuto)

        If Autos.datosAceptados Then
            MsgBox("Auto " & Autos.MarcaAuto & " resgistrado")
        Else

        End If


        txtMarca.Text = ""
        txtModelo.Text = ""
        txtAño.Text = ""
        cbxColor.Text = ""
        txtCombustible.Text = ""


    End Sub

    Private Sub btnGenerar_click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub grpDatos_Enter(sender As Object, e As EventArgs) Handles grpDatos.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datosAlumno.CellContentClick

    End Sub
End Class