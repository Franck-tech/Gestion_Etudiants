<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim NomELabel As System.Windows.Forms.Label
        Dim PrénomsELabel As System.Windows.Forms.Label
        Dim SexeELabel As System.Windows.Forms.Label
        Dim N_BorderauLabel As System.Windows.Forms.Label
        Dim MontantLabel As System.Windows.Forms.Label
        Dim TotalPayeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim LibelléFLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GestionEtudiantsDataSet2 = New Gestion_Etudiants.GestionEtudiantsDataSet()
        Me.Payement_RBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payement_RTableAdapter2 = New Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.Payement_RTableAdapter()
        Me.TableAdapterManager = New Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.TableAdapterManager()
        Me.NomETextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsETextBox = New System.Windows.Forms.TextBox()
        Me.SexeETextBox = New System.Windows.Forms.TextBox()
        Me.N_BorderauTextBox = New System.Windows.Forms.TextBox()
        Me.MontantTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayeTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LibelléFTextBox = New System.Windows.Forms.TextBox()
        Me.PayementRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NomELabel = New System.Windows.Forms.Label()
        PrénomsELabel = New System.Windows.Forms.Label()
        SexeELabel = New System.Windows.Forms.Label()
        N_BorderauLabel = New System.Windows.Forms.Label()
        MontantLabel = New System.Windows.Forms.Label()
        TotalPayeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        LibelléFLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GestionEtudiantsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payement_RBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayementRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DataGridView1.DataSource = Me.PayementRBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(486, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(650, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(847, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Recherche"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(932, 31)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(163, 22)
        Me.TextBox10.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NomELabel)
        Me.GroupBox1.Controls.Add(Me.NomETextBox)
        Me.GroupBox1.Controls.Add(PrénomsELabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsETextBox)
        Me.GroupBox1.Controls.Add(SexeELabel)
        Me.GroupBox1.Controls.Add(Me.SexeETextBox)
        Me.GroupBox1.Controls.Add(N_BorderauLabel)
        Me.GroupBox1.Controls.Add(Me.N_BorderauTextBox)
        Me.GroupBox1.Controls.Add(MontantLabel)
        Me.GroupBox1.Controls.Add(Me.MontantTextBox)
        Me.GroupBox1.Controls.Add(TotalPayeLabel)
        Me.GroupBox1.Controls.Add(Me.TotalPayeTextBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(LibelléFLabel)
        Me.GroupBox1.Controls.Add(Me.LibelléFTextBox)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 449)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payement"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(593, 31)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 22)
        Me.TextBox6.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(513, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Filtrer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Image = Global.Gestion_Etudiants.My.Resources.Resources.exchange
        Me.Button1.Location = New System.Drawing.Point(208, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = " Mise a Jour"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Gestion_Etudiants.My.Resources.Resources.search
        Me.Button3.Location = New System.Drawing.Point(1083, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 30)
        Me.Button3.TabIndex = 24
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Gestion_Etudiants.My.Resources.Resources.funnel
        Me.Button2.Location = New System.Drawing.Point(768, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 42)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GestionEtudiantsDataSet2
        '
        Me.GestionEtudiantsDataSet2.DataSetName = "GestionEtudiantsDataSet"
        Me.GestionEtudiantsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payement_RBindingSource
        '
        Me.Payement_RBindingSource.DataMember = "Payement_R"
        Me.Payement_RBindingSource.DataSource = Me.GestionEtudiantsDataSet2
        '
        'Payement_RTableAdapter2
        '
        Me.Payement_RTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ContenirTableAdapter = Nothing
        Me.TableAdapterManager.EtudiantsTableAdapter = Nothing
        Me.TableAdapterManager.FillièreTableAdapter = Nothing
        Me.TableAdapterManager.InscrireTableAdapter = Nothing
        Me.TableAdapterManager.MatièresTableAdapter = Nothing
        Me.TableAdapterManager.PésenceTableAdapter = Nothing
        Me.TableAdapterManager.SalleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilisateurTableAdapter = Nothing
        '
        'NomELabel
        '
        NomELabel.AutoSize = True
        NomELabel.Location = New System.Drawing.Point(37, 58)
        NomELabel.Name = "NomELabel"
        NomELabel.Size = New System.Drawing.Size(49, 14)
        NomELabel.TabIndex = 24
        NomELabel.Text = "Nom E:"
        '
        'NomETextBox
        '
        Me.NomETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "NomE", True))
        Me.NomETextBox.Location = New System.Drawing.Point(122, 55)
        Me.NomETextBox.Name = "NomETextBox"
        Me.NomETextBox.Size = New System.Drawing.Size(316, 22)
        Me.NomETextBox.TabIndex = 25
        '
        'PrénomsELabel
        '
        PrénomsELabel.AutoSize = True
        PrénomsELabel.Location = New System.Drawing.Point(37, 96)
        PrénomsELabel.Name = "PrénomsELabel"
        PrénomsELabel.Size = New System.Drawing.Size(72, 14)
        PrénomsELabel.TabIndex = 26
        PrénomsELabel.Text = "Prénoms E:"
        '
        'PrénomsETextBox
        '
        Me.PrénomsETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "PrénomsE", True))
        Me.PrénomsETextBox.Location = New System.Drawing.Point(122, 93)
        Me.PrénomsETextBox.Name = "PrénomsETextBox"
        Me.PrénomsETextBox.Size = New System.Drawing.Size(316, 22)
        Me.PrénomsETextBox.TabIndex = 27
        '
        'SexeELabel
        '
        SexeELabel.AutoSize = True
        SexeELabel.Location = New System.Drawing.Point(37, 124)
        SexeELabel.Name = "SexeELabel"
        SexeELabel.Size = New System.Drawing.Size(49, 14)
        SexeELabel.TabIndex = 28
        SexeELabel.Text = "Sexe E:"
        '
        'SexeETextBox
        '
        Me.SexeETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "SexeE", True))
        Me.SexeETextBox.Location = New System.Drawing.Point(122, 121)
        Me.SexeETextBox.Name = "SexeETextBox"
        Me.SexeETextBox.Size = New System.Drawing.Size(316, 22)
        Me.SexeETextBox.TabIndex = 29
        '
        'N_BorderauLabel
        '
        N_BorderauLabel.AutoSize = True
        N_BorderauLabel.Location = New System.Drawing.Point(37, 161)
        N_BorderauLabel.Name = "N_BorderauLabel"
        N_BorderauLabel.Size = New System.Drawing.Size(78, 14)
        N_BorderauLabel.TabIndex = 30
        N_BorderauLabel.Text = "N°Borderau:"
        '
        'N_BorderauTextBox
        '
        Me.N_BorderauTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "N°Borderau", True))
        Me.N_BorderauTextBox.Location = New System.Drawing.Point(122, 158)
        Me.N_BorderauTextBox.Name = "N_BorderauTextBox"
        Me.N_BorderauTextBox.Size = New System.Drawing.Size(316, 22)
        Me.N_BorderauTextBox.TabIndex = 31
        '
        'MontantLabel
        '
        MontantLabel.AutoSize = True
        MontantLabel.Location = New System.Drawing.Point(37, 200)
        MontantLabel.Name = "MontantLabel"
        MontantLabel.Size = New System.Drawing.Size(56, 14)
        MontantLabel.TabIndex = 32
        MontantLabel.Text = "Montant:"
        '
        'MontantTextBox
        '
        Me.MontantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "Montant", True))
        Me.MontantTextBox.Location = New System.Drawing.Point(122, 197)
        Me.MontantTextBox.Name = "MontantTextBox"
        Me.MontantTextBox.Size = New System.Drawing.Size(316, 22)
        Me.MontantTextBox.TabIndex = 33
        '
        'TotalPayeLabel
        '
        TotalPayeLabel.AutoSize = True
        TotalPayeLabel.Location = New System.Drawing.Point(37, 244)
        TotalPayeLabel.Name = "TotalPayeLabel"
        TotalPayeLabel.Size = New System.Drawing.Size(69, 14)
        TotalPayeLabel.TabIndex = 34
        TotalPayeLabel.Text = "Total Paye:"
        '
        'TotalPayeTextBox
        '
        Me.TotalPayeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "TotalPaye", True))
        Me.TotalPayeTextBox.Location = New System.Drawing.Point(122, 241)
        Me.TotalPayeTextBox.Name = "TotalPayeTextBox"
        Me.TotalPayeTextBox.Size = New System.Drawing.Size(316, 22)
        Me.TotalPayeTextBox.TabIndex = 35
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(37, 289)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(36, 14)
        DateLabel.TabIndex = 36
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Payement_RBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(122, 285)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(316, 22)
        Me.DateDateTimePicker.TabIndex = 37
        '
        'LibelléFLabel
        '
        LibelléFLabel.AutoSize = True
        LibelléFLabel.Location = New System.Drawing.Point(37, 325)
        LibelléFLabel.Name = "LibelléFLabel"
        LibelléFLabel.Size = New System.Drawing.Size(62, 14)
        LibelléFLabel.TabIndex = 38
        LibelléFLabel.Text = "Libellé F:"
        '
        'LibelléFTextBox
        '
        Me.LibelléFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payement_RBindingSource, "LibelléF", True))
        Me.LibelléFTextBox.Location = New System.Drawing.Point(122, 322)
        Me.LibelléFTextBox.Name = "LibelléFTextBox"
        Me.LibelléFTextBox.Size = New System.Drawing.Size(316, 22)
        Me.LibelléFTextBox.TabIndex = 39
        '
        'PayementRBindingSource
        '
        Me.PayementRBindingSource.DataMember = "Payement_R"
        Me.PayementRBindingSource.DataSource = Me.GestionEtudiantsDataSet2
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NomE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NomE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrénomsE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PrénomsE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SexeE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SexeE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "N°Borderau"
        Me.DataGridViewTextBoxColumn12.HeaderText = "N°Borderau"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Montant"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Montant"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TotalPaye"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TotalPaye"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "LibelléF"
        Me.DataGridViewTextBoxColumn16.HeaderText = "LibelléF"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1177, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GestionEtudiantsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payement_RBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayementRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GestionEtudiantsDataSet As GestionEtudiantsDataSet
    Friend WithEvents Payement_RTableAdapter As GestionEtudiantsDataSetTableAdapters.Payement_RTableAdapter
    Friend WithEvents NomEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NBorderauDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPayeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibelléFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GestionEtudiantsDataSet1 As GestionEtudiantsDataSet
    Friend WithEvents Payement_RTableAdapter1 As GestionEtudiantsDataSetTableAdapters.Payement_RTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents GestionEtudiantsDataSet2 As GestionEtudiantsDataSet
    Friend WithEvents Payement_RBindingSource As BindingSource
    Friend WithEvents Payement_RTableAdapter2 As GestionEtudiantsDataSetTableAdapters.Payement_RTableAdapter
    Friend WithEvents TableAdapterManager As GestionEtudiantsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomETextBox As TextBox
    Friend WithEvents PrénomsETextBox As TextBox
    Friend WithEvents SexeETextBox As TextBox
    Friend WithEvents N_BorderauTextBox As TextBox
    Friend WithEvents MontantTextBox As TextBox
    Friend WithEvents TotalPayeTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents LibelléFTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents PayementRBindingSource As BindingSource
End Class
