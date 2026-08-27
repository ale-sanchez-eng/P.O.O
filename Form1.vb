Public Class Form1

    Private Sub CancionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CancionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CancionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicaDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MusicaDBDataSet.Canciones' Puede moverla o quitarla según sea necesario.
        Me.CancionesTableAdapter.Fill(Me.MusicaDBDataSet.Canciones)

    End Sub
    Private Function Validar() As Boolean

        If Not IsNumeric(Codigo_CancionTextBox.Text) Then
            MessageBox.Show("El código debe ser numérico")
            Codigo_CancionTextBox.Focus()
            Return False
        End If

        If TituloTextBox.Text.Trim = "" Then
            MessageBox.Show("Ingrese el título")
            TituloTextBox.Focus()
            Return False
        End If

        If DuracionTextBox.Text.Trim = "" Then
            MessageBox.Show("Ingrese la duración")
            DuracionTextBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Btninsert_Click(sender As Object, e As EventArgs) Handles Btninsert.Click
        Try
            If Not Validar() Then Exit Sub

            ' Evitar duplicados
            Dim tabla As DataTable
            tabla = Me.CancionesTableAdapter.GetDataByCodigo(CInt(Codigo_CancionTextBox.Text))

            If tabla.Rows.Count > 0 Then
                MessageBox.Show("Ese código ya existe")
                Exit Sub
            End If

            ' Insertar
            Me.CancionesTableAdapter.Insert(
                CInt(Codigo_CancionTextBox.Text),
                TituloTextBox.Text,
                DuracionTextBox.Text
            )

            Me.CancionesTableAdapter.Fill(Me.MusicaDBDataSet.Canciones)

            MessageBox.Show("Insertado correctamente")

        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message)
        End Try
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        Try
            If Not Validar() Then Exit Sub

            Me.CancionesTableAdapter.Editar(
                TituloTextBox.Text,
                DuracionTextBox.Text,
                CInt(Codigo_CancionTextBox.Text)
            )

            Me.CancionesTableAdapter.Fill(Me.MusicaDBDataSet.Canciones)

            MessageBox.Show("Actualizado correctamente")

        Catch ex As Exception
            MessageBox.Show("Error al editar")
        End Try
    End Sub

    Private Sub Btnborrar_Click(sender As Object, e As EventArgs) Handles Btnborrar.Click
        Dim resp As DialogResult

        resp = MessageBox.Show("¿Está seguro de borrar este registro?", "Confirmar", MessageBoxButtons.YesNo)

        If resp = DialogResult.Yes Then
            Try
                Me.CancionesTableAdapter.Borrar(CInt(Codigo_CancionTextBox.Text))

                Me.CancionesTableAdapter.Fill(Me.MusicaDBDataSet.Canciones)

                MessageBox.Show("Eliminado correctamente")

            Catch ex As Exception
                MessageBox.Show("Error al borrar")
            End Try
        End If
    End Sub

    Private Sub Btnbusc_Click(sender As Object, e As EventArgs) Handles Btnbusc.Click
        Try
            Me.CancionesTableAdapter.FillBy(
                Me.MusicaDBDataSet.Canciones,
                CInt(Codigo_CancionTextBox.Text)
            )
        Catch ex As Exception
            MessageBox.Show("Error al buscar")
        End Try
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Codigo_CancionTextBox.Clear()
        TituloTextBox.Clear()
        DuracionTextBox.Clear()
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

End Class
