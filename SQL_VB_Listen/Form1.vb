Imports System.Data
Imports System.Data.SqlClient


Public Class Form1

    Dim conn As SqlConnection
    Dim ErrorCode As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn = New SqlConnection("server=agem-se1.agem-bisenhs.org.uk; user id=AHirst; password=Coniston125; database=Master")
        Try
            conn.Open()
            MessageBox.Show("Successful conection to SQL Server AGEM-SE1", "Connection Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conn.Close()

        Catch Sqlex As SqlException
            Select Case Sqlex.Number
                Case 53
                    ErrorCode = Sqlex.Number
                    MessageBox.Show($"Connection ErrorCode {ErrorCode} Sorry, connection to the SQL server was not successful", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case Else
                    MessageBox.Show($"SQL Connection ErrorCode {ErrorCode} Connection to the SQL Server Failed", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub

End Class
