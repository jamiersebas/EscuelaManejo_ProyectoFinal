
Imports System.Data.SqlClient
Imports System.Data.Sql


Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_CrearContrato", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try

            SQL.Parameters.Add("@ID_CONTRATO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox1.Text)
            SQL.Parameters.Add("@SESION", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox2.Text)
            SQL.Parameters.Add("@ID_PERSONAL", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox3.Text)
            SQL.Parameters.Add("@ID_PLACA", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox4.Text)
            SQL.Parameters.Add("@FECHA_INICIO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox5.Text
            SQL.Parameters.Add("@FECHA_FIN", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox6.Text
            SQL.Parameters.Add("@COSTO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox7.Text)
            SQL.Parameters.Add("@ESTADO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = ComboBox1.Text
            SQL.Parameters.Add("@ID_CLIENTE", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox9.Text)

            con.Open()
            SQL.ExecuteReader()

            MsgBox("se ingresaron los datos en la BD")

        Catch ex As Exception
            MsgBox("error al ingresar los datos")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class