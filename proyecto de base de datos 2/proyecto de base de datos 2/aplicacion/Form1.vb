
Imports System.Data.SqlClient
Imports System.Data.Sql


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim codigo_cliente As Integer
    '    Dim DPI As String
    '    Dim nombre As String
    '    Dim apellido As String
    '    apellido = TextBox4.Text
    '    nombre = TextBox2.Text
    '    DPI = TextBox3.Text
    '    codigo_cliente = Val(TextBox1.Text)
    '    Dim Con As New SqlConnection(My.Settings.conexion)
    '    Dim sql As String
    '    Dim bandera As Integer

    '    If codigo_cliente <> Nothing Then
    '        sql = "select * from te_clientes where codigo_cliente =" & codigo_cliente
    '    End If
    '    If DPI <> Nothing Then
    '        sql = "select * from te_clientes where identificacion ='" & DPI & "'"
    '    End If
    '    If nombre <> Nothing Then
    '        sql = "select * from nombrec where nombre ='" & nombre & "'"
    '    End If
    '    If apellido <> Nothing Then
    '        sql = "select * from te_clientes where apellido1 ='" & apellido & "'"
    '    End If
    '    Dim cmd As New SqlCommand(sql, Con)



    '    Try
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "te_clientes")
    '        Me.DataGridView1.DataSource = ds.Tables("te_clientes")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    Dim codigo_cliente As Integer
    '    codigo_cliente = Val(TextBox1.Text)
    '    Dim Con As New SqlConnection(My.Settings.conexion)
    '    Dim sql As String = "select * from te_clientes "
    '    Dim cmd As New SqlCommand(sql, Con)

    '    Try
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "te_clientes")
    '        Me.DataGridView1.DataSource = ds.Tables("te_clientes")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Form2.Show()
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    Form3.Show()
    'End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As New SqlCommand("SELECT USUARIO FROM USUARIO WHERE USUARIO= @USUARIO AND CONTRASEÑA=@CONTRASEÑA", con)
        sql.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = TextBox1.Text
        sql.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(sql)
        Dim table As New DataTable()

        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("usuario o contrasenia invalida")

        Else

            Form2.Show()

            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()

        End If




    End Sub
End Class
