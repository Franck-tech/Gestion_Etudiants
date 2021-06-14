Imports System.Data.OleDb
Imports System.Data
Public Class Form2
    Dim Connect As New OleDbConnection(My.Settings.GestionEtudiantsConnectionString)
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(Form4)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(Form3)
    End Sub

    Sub switchPanel(ByVal panel As Form)

        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(Form5)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet3.Inscription_R' table. You can move, or remove it, as needed.
        Me.Inscription_RTableAdapter2.Fill(Me.GestionEtudiantsDataSet3.Inscription_R)
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet2.Inscription_R' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'GestionEtudiantsDataSet2.Inscription_R' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(Form6)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        switchPanel(Form6)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Confirmation As DialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Confirmation = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        InscriptionRBindingSource.MovePrevious()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        InscriptionRBindingSource.MoveNext()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("Voulez vous vraiment supprimer ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            InscriptionRBindingSource.RemoveCurrent()
        Else
            DataGridView1.Show()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox11.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox6.Focus()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DescriptionFTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionFTextBox.TextChanged

    End Sub

    Private Sub DescriptionFLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub N_BorderauTextBox_TextChanged(sender As Object, e As EventArgs) Handles N_BorderauTextBox.TextChanged

    End Sub

    Private Sub N_BorderauLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MontantTextBox_TextChanged(sender As Object, e As EventArgs) Handles MontantTextBox.TextChanged

    End Sub

    Private Sub MontantLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalPayeTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPayeTextBox.TextChanged

    End Sub

    Private Sub TotalPayeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateDateTimePicker.ValueChanged

    End Sub
End Class