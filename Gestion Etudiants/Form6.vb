Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet.Utilisateur' table. You can move, or remove it, as needed.
        Me.UtilisateurTableAdapter.Fill(Me.GestionEtudiantsDataSet.Utilisateur)
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet.Utilisateur' table. You can move, or remove it, as needed.
        Me.UtilisateurTableAdapter.Fill(Me.GestionEtudiantsDataSet.Utilisateur)

    End Sub

    Private Sub IdULabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelTextBox.TextChanged

    End Sub

    Private Sub TelLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nom_UtilisateurTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nom_UtilisateurTextBox.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class