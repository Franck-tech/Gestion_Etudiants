Public Class Form3
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet2.Payement_R' table. You can move, or remove it, as needed.
        Me.Payement_RTableAdapter2.Fill(Me.GestionEtudiantsDataSet2.Payement_R)
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet1.Payement_R' table. You can move, or remove it, as needed.
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class