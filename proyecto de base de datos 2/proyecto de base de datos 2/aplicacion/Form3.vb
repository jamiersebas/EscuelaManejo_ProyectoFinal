Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_InsertarCliente", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try

            SQL.Parameters.Add("@ID_CLIENTE", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox1.Text)
            SQL.Parameters.Add("@NOMBRE_COMPLETO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox2.Text
            SQL.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox3.Text
            SQL.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox4.Text
            SQL.Parameters.Add("@TELEFONO", SqlDbType.Int, 8, ParameterDirection.Input).Value = Val(TextBox5.Text)
            SQL.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = TextBox6.Text
            SQL.Parameters.Add("@ESTADO", SqlDbType.VarChar, 6, ParameterDirection.Input).Value = ComboBox1.Text

            con.Open()
            SQL.ExecuteReader()

            MsgBox("se ingresaron los datos en la BD")

        Catch ex As Exception
            MsgBox("error al ingresar los datos")
        End Try





    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class