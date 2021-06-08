Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_ReporteContrato", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try
            Dim da As New SqlDataAdapter(SQL)
            Dim ds As New DataSet

            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)


            con.Open()
            SQL.ExecuteReader()

            MsgBox("se ejecuto correctamente reporte de contratos con la informacion mas importante")

        Catch ex As Exception
            MsgBox("error en la ejecucion de la consulta")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim SQL As New SqlCommand("SP_ReportePagos", con)
        SQL.CommandType = CommandType.StoredProcedure
        Try
            Dim da As New SqlDataAdapter(SQL)
            Dim ds As New DataSet

            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)


            con.Open()
            SQL.ExecuteReader()

            MsgBox("Se ejecuto correctamente reporte de los pagos que se realizaron para las clases de manejo")


            Label1.Text = "AFASDFAS"
        Catch ex As Exception
            MsgBox("error en la ejecucion de la consulta")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class