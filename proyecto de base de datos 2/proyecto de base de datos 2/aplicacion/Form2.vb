Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()

    End Sub
    'Dim eliminar As New propiedades
    'Dim func As New funciones
    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''    Try
    ''        eliminar.codigo_cliente = Val(TextBox1.Text)
    ''        func.eliminar_cliente(eliminar)
    ''        Me.Close()
    ''    Catch ex As Exception
    ''        MsgBox(ex.Message)
    ''    End Try

    ''End Sub
End Class