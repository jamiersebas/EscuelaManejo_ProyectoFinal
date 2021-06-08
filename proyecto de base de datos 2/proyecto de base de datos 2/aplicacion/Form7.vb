
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_RegistroPago", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try

            SQL.Parameters.Add("@ID_PAGO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox1.Text)
            SQL.Parameters.Add("@FECHA_PAGO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox2.Text
            SQL.Parameters.Add("@TIPO_PAGO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox3.Text
            SQL.Parameters.Add("@MONTO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox4.Text)
            SQL.Parameters.Add("@ID_CLIENTE", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox5.Text)
            SQL.Parameters.Add("@ID_CONTRATO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox6.Text)



            con.Open()
            SQL.ExecuteReader()

            MsgBox("se ingresaron los datos en la BD")

        Catch ex As Exception
            MsgBox("error al ingresar los datos")
        End Try
    End Sub
End Class