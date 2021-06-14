<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdULabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim PrénomsLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Nom_UtilisateurLabel As System.Windows.Forms.Label
        Dim Mot_de_passeLabel As System.Windows.Forms.Label
        Dim StatutLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomUtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotDePasseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionEtudiantsDataSet = New Gestion_Etudiants.GestionEtudiantsDataSet()
        Me.UtilisateurTableAdapter = New Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.UtilisateurTableAdapter()
        Me.UtilisateurBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.TableAdapterManager()
        Me.IdUTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_UtilisateurTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_de_passeTextBox = New System.Windows.Forms.TextBox()
        Me.StatutTextBox = New System.Windows.Forms.TextBox()
        IdULabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        PrénomsLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Nom_UtilisateurLabel = New System.Windows.Forms.Label()
        Mot_de_passeLabel = New System.Windows.Forms.Label()
        StatutLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionEtudiantsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdULabel)
        Me.GroupBox1.Controls.Add(Me.IdUTextBox)
        Me.GroupBox1.Controls.Add(NomLabel)
        Me.GroupBox1.Controls.Add(Me.NomTextBox)
        Me.GroupBox1.Controls.Add(PrénomsLabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsTextBox)
        Me.GroupBox1.Controls.Add(TelLabel)
        Me.GroupBox1.Controls.Add(Me.TelTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Nom_UtilisateurLabel)
        Me.GroupBox1.Controls.Add(Me.Nom_UtilisateurTextBox)
        Me.GroupBox1.Controls.Add(Mot_de_passeLabel)
        Me.GroupBox1.Controls.Add(Me.Mot_de_passeTextBox)
        Me.GroupBox1.Controls.Add(StatutLabel)
        Me.GroupBox1.Controls.Add(Me.StatutTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1129, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnel"
        '
        'Button1
        '
        Me.Button1.Image = Global.Gestion_Etudiants.My.Resources.Resources.diskette__2_
        Me.Button1.Location = New System.Drawing.Point(877, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 34)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "   Sauvegarder"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrénomsDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.NomUtilisateurDataGridViewTextBoxColumn, Me.MotDePasseDataGridViewTextBoxColumn, Me.StatutDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UtilisateurBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 229)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1103, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'IdUDataGridViewTextBoxColumn
        '
        Me.IdUDataGridViewTextBoxColumn.DataPropertyName = "IdU"
        Me.IdUDataGridViewTextBoxColumn.HeaderText = "IdU"
        Me.IdUDataGridViewTextBoxColumn.Name = "IdUDataGridViewTextBoxColumn"
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        '
        'PrénomsDataGridViewTextBoxColumn
        '
        Me.PrénomsDataGridViewTextBoxColumn.DataPropertyName = "Prénoms"
        Me.PrénomsDataGridViewTextBoxColumn.HeaderText = "Prénoms"
        Me.PrénomsDataGridViewTextBoxColumn.Name = "PrénomsDataGridViewTextBoxColumn"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'NomUtilisateurDataGridViewTextBoxColumn
        '
        Me.NomUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "Nom Utilisateur"
        Me.NomUtilisateurDataGridViewTextBoxColumn.HeaderText = "Nom Utilisateur"
        Me.NomUtilisateurDataGridViewTextBoxColumn.Name = "NomUtilisateurDataGridViewTextBoxColumn"
        '
        'MotDePasseDataGridViewTextBoxColumn
        '
        Me.MotDePasseDataGridViewTextBoxColumn.DataPropertyName = "Mot de passe"
        Me.MotDePasseDataGridViewTextBoxColumn.HeaderText = "Mot de passe"
        Me.MotDePasseDataGridViewTextBoxColumn.Name = "MotDePasseDataGridViewTextBoxColumn"
        '
        'StatutDataGridViewTextBoxColumn
        '
        Me.StatutDataGridViewTextBoxColumn.DataPropertyName = "Statut"
        Me.StatutDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatutDataGridViewTextBoxColumn.Name = "StatutDataGridViewTextBoxColumn"
        '
        'UtilisateurBindingSource
        '
        Me.UtilisateurBindingSource.DataMember = "Utilisateur"
        Me.UtilisateurBindingSource.DataSource = Me.GestionEtudiantsDataSet
        '
        'GestionEtudiantsDataSet
        '
        Me.GestionEtudiantsDataSet.DataSetName = "GestionEtudiantsDataSet"
        Me.GestionEtudiantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilisateurTableAdapter
        '
        Me.UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'UtilisateurBindingSource1
        '
        Me.UtilisateurBindingSource1.DataMember = "Utilisateur"
        Me.UtilisateurBindingSource1.DataSource = Me.GestionEtudiantsDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContenirTableAdapter = Nothing
        Me.TableAdapterManager.EtudiantsTableAdapter = Nothing
        Me.TableAdapterManager.FillièreTableAdapter = Nothing
        Me.TableAdapterManager.InscrireTableAdapter = Nothing
        Me.TableAdapterManager.MatièresTableAdapter = Nothing
        Me.TableAdapterManager.PésenceTableAdapter = Nothing
        Me.TableAdapterManager.SalleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateurTableAdapter = Me.UtilisateurTableAdapter
        '
        'IdULabel
        '
        IdULabel.AutoSize = True
        IdULabel.Location = New System.Drawing.Point(31, 53)
        IdULabel.Name = "IdULabel"
        IdULabel.Size = New System.Drawing.Size(35, 14)
        IdULabel.TabIndex = 15
        IdULabel.Text = "Id U:"
        AddHandler IdULabel.Click, AddressOf Me.IdULabel_Click
        '
        'IdUTextBox
        '
        Me.IdUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "IdU", True))
        Me.IdUTextBox.Location = New System.Drawing.Point(100, 50)
        Me.IdUTextBox.Name = "IdUTextBox"
        Me.IdUTextBox.Size = New System.Drawing.Size(233, 22)
        Me.IdUTextBox.TabIndex = 16
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(31, 104)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(36, 14)
        NomLabel.TabIndex = 17
        NomLabel.Text = "Nom:"
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(100, 102)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(233, 22)
        Me.NomTextBox.TabIndex = 18
        '
        'PrénomsLabel
        '
        PrénomsLabel.AutoSize = True
        PrénomsLabel.Location = New System.Drawing.Point(31, 157)
        PrénomsLabel.Name = "PrénomsLabel"
        PrénomsLabel.Size = New System.Drawing.Size(59, 14)
        PrénomsLabel.TabIndex = 19
        PrénomsLabel.Text = "Prénoms:"
        '
        'PrénomsTextBox
        '
        Me.PrénomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Prénoms", True))
        Me.PrénomsTextBox.Location = New System.Drawing.Point(100, 154)
        Me.PrénomsTextBox.Name = "PrénomsTextBox"
        Me.PrénomsTextBox.Size = New System.Drawing.Size(233, 22)
        Me.PrénomsTextBox.TabIndex = 20
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(376, 54)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(29, 14)
        TelLabel.TabIndex = 21
        TelLabel.Text = "Tel:"
        AddHandler TelLabel.Click, AddressOf Me.TelLabel_Click
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(480, 51)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(244, 22)
        Me.TelTextBox.TabIndex = 22
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(376, 107)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 14)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(480, 104)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(244, 22)
        Me.EmailTextBox.TabIndex = 24
        '
        'Nom_UtilisateurLabel
        '
        Nom_UtilisateurLabel.AutoSize = True
        Nom_UtilisateurLabel.Location = New System.Drawing.Point(376, 160)
        Nom_UtilisateurLabel.Name = "Nom_UtilisateurLabel"
        Nom_UtilisateurLabel.Size = New System.Drawing.Size(98, 14)
        Nom_UtilisateurLabel.TabIndex = 25
        Nom_UtilisateurLabel.Text = "Nom Utilisateur:"
        '
        'Nom_UtilisateurTextBox
        '
        Me.Nom_UtilisateurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Nom Utilisateur", True))
        Me.Nom_UtilisateurTextBox.Location = New System.Drawing.Point(480, 157)
        Me.Nom_UtilisateurTextBox.Name = "Nom_UtilisateurTextBox"
        Me.Nom_UtilisateurTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Nom_UtilisateurTextBox.TabIndex = 26
        '
        'Mot_de_passeLabel
        '
        Mot_de_passeLabel.AutoSize = True
        Mot_de_passeLabel.Location = New System.Drawing.Point(760, 58)
        Mot_de_passeLabel.Name = "Mot_de_passeLabel"
        Mot_de_passeLabel.Size = New System.Drawing.Size(80, 14)
        Mot_de_passeLabel.TabIndex = 27
        Mot_de_passeLabel.Text = "Mot de passe:"
        '
        'Mot_de_passeTextBox
        '
        Me.Mot_de_passeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Mot de passe", True))
        Me.Mot_de_passeTextBox.Location = New System.Drawing.Point(864, 55)
        Me.Mot_de_passeTextBox.Name = "Mot_de_passeTextBox"
        Me.Mot_de_passeTextBox.Size = New System.Drawing.Size(221, 22)
        Me.Mot_de_passeTextBox.TabIndex = 28
        '
        'StatutLabel
        '
        StatutLabel.AutoSize = True
        StatutLabel.Location = New System.Drawing.Point(760, 105)
        StatutLabel.Name = "StatutLabel"
        StatutLabel.Size = New System.Drawing.Size(43, 14)
        StatutLabel.TabIndex = 29
        StatutLabel.Text = "Statut:"
        '
        'StatutTextBox
        '
        Me.StatutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilisateurBindingSource1, "Statut", True))
        Me.StatutTextBox.Location = New System.Drawing.Point(864, 102)
        Me.StatutTextBox.Name = "StatutTextBox"
        Me.StatutTextBox.Size = New System.Drawing.Size(221, 22)
        Me.StatutTextBox.TabIndex = 30
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionEtudiantsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GestionEtudiantsDataSet As GestionEtudiantsDataSet
    Friend WithEvents UtilisateurBindingSource As BindingSource
    Friend WithEvents UtilisateurTableAdapter As GestionEtudiantsDataSetTableAdapters.UtilisateurTableAdapter
    Friend WithEvents IdUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomUtilisateurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotDePasseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUTextBox As TextBox
    Friend WithEvents UtilisateurBindingSource1 As BindingSource
    Friend WithEvents NomTextBox As TextBox
    Friend WithEvents PrénomsTextBox As TextBox
    Friend WithEvents TelTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Nom_UtilisateurTextBox As TextBox
    Friend WithEvents Mot_de_passeTextBox As TextBox
    Friend WithEvents StatutTextBox As TextBox
    Friend WithEvents TableAdapterManager As GestionEtudiantsDataSetTableAdapters.TableAdapterManager
End Class
