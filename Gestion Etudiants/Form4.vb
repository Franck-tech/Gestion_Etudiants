Imports System.Data.OleDb
Imports System.Data
Public Class Form4
    Dim Connect As New OleDbConnection(My.Settings.GestionEtudiantsConnectionString)
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InscriptionRBindingSource.MoveNext()
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Connect.Open()

        Try
            InscriptionRBindingSource.EndEdit()

            MessageBox.Show("Sauvegarde reussie")
            IdETextBox.Clear()
            NomETextBox.Clear()
            PrénomsETextBox.Clear()
            ÂgeETextBox.Clear()
            SexeETextBox.Clear()
            SerieTextBox.Clear()
            LibelléFTextBox.Clear()
            DescriptionFTextBox.Clear()
            MontantTextBox.Clear()
            N_BorderauTextBox.Clear()
            TotalPayeTextBox.Clear()

        Catch ex As Exception
            MessageBox.Show("Echec de sauvegarde")
        End Try

        Connect.Close()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet2.Inscription_R' table. You can move, or remove it, as needed.
        Me.Inscription_RTableAdapter2.Fill(Me.GestionEtudiantsDataSet2.Inscription_R)
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet1.Inscription_R' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InscriptionRBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InscriptionRBindingSource.AddNew()
        IdETextBox.Clear()
        NomETextBox.Clear()
        PrénomsETextBox.Clear()
        SexeETextBox.Clear()
        ÂgeETextBox.Clear()
        SerieTextBox.Clear()
        LibelléFTextBox.Clear()
        DescriptionFTextBox.Clear()
        N_BorderauTextBox.Clear()
        MontantTextBox.Clear()
        TotalPayeTextBox.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Voulez vous vraiment supprimer ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            InscriptionRBindingSource.RemoveCurrent()
        Else
            DataGridView1.Show()
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class