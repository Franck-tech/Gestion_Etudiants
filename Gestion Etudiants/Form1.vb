Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Dim Connect As New OleDbConnection(My.Settings.GestionEtudiantsConnectionString)
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Veilliez remplir les informations", MsgBoxStyle.Exclamation)
        Else
            If Connect.State = ConnectionState.Closed Then
                Connect.Open()
            End If
            Dim cmd As New OleDbCommand("select *from Utilisateur where (([Nom Utilisateur]=?) and ([Mot de passe]=?))", Connect)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Form2.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
            Else
                MsgBox("Connection échoué", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class