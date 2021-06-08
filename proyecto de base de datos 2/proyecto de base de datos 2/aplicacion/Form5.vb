Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form5
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_ClaseManejo", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try

            SQL.Parameters.Add("@ID_ClASE", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox1.Text)
            SQL.Parameters.Add("@ID_CLIENTE", SqlDbType.Int, 8, ParameterDirection.Input).Value = TextBox2.Text
            SQL.Parameters.Add("@ID_CONTRATO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox3.Text)
            SQL.Parameters.Add("@HORA_INICIO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox4.Text

            SQL.Parameters.Add("@HORA_FIN", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox5.Text
            SQL.Parameters.Add("@FECHA", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox6.Text

            con.Open()
            SQL.ExecuteReader()

            MsgBox("se ingresaron los datos en la BD")

        Catch ex As Exception
            MsgBox("error al ingresar los datos")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()

    End Sub
End Class