Public Class Ingreso

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicaDBDataSet)

    End Sub


    Private Sub UsuarioBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicaDBDataSet)

    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MusicaDBDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.MusicaDBDataSet.Usuario)

    End Sub

    Private Sub Btningre_Click(sender As Object, e As EventArgs) Handles Btningre.Click
        If Me.UsuarioTableAdapter.FillBy(Me.MusicaDBDataSet.Usuario, UsuarioTextBox.Text, ClaveTextBox.Text) Then
            usuario = UsuarioTextBox.Text
            permiso = PermisoTextBox.Text
            Me.Hide()
            Form1.Show()
            intentos = 0

        Else
            UsuarioTextBox.Text = ""
            ClaveTextBox.Text = ""
            MessageBox.Show("Error,Usuario o Clave incorrecto")
            intentos = intentos + 1
            If intentos >= 3 Then
                MessageBox.Show("Superaste el límite de intentos")
                Form1.Show()
            End If


        End If
    End Sub
End Class