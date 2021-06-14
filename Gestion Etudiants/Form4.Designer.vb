<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim IdELabel As System.Windows.Forms.Label
        Dim NomELabel As System.Windows.Forms.Label
        Dim PrénomsELabel As System.Windows.Forms.Label
        Dim ÂgeELabel As System.Windows.Forms.Label
        Dim SexeELabel As System.Windows.Forms.Label
        Dim DateNaissELabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim LibelléFLabel As System.Windows.Forms.Label
        Dim DescriptionFLabel As System.Windows.Forms.Label
        Dim N_BorderauLabel As System.Windows.Forms.Label
        Dim MontantLabel As System.Windows.Forms.Label
        Dim TotalPayeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InscriptionRBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionEtudiantsDataSet2 = New Gestion_Etudiants.GestionEtudiantsDataSet()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdETextBox = New System.Windows.Forms.TextBox()
        Me.NomETextBox = New System.Windows.Forms.TextBox()
        Me.PrénomsETextBox = New System.Windows.Forms.TextBox()
        Me.ÂgeETextBox = New System.Windows.Forms.TextBox()
        Me.SexeETextBox = New System.Windows.Forms.TextBox()
        Me.DateNaissEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SerieTextBox = New System.Windows.Forms.TextBox()
        Me.LibelléFTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionFTextBox = New System.Windows.Forms.TextBox()
        Me.N_BorderauTextBox = New System.Windows.Forms.TextBox()
        Me.MontantTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayeTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InscriptionRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inscription_RTableAdapter2 = New Gestion_Etudiants.GestionEtudiantsDataSetTableAdapters.Inscription_RTableAdapter()
        IdELabel = New System.Windows.Forms.Label()
        NomELabel = New System.Windows.Forms.Label()
        PrénomsELabel = New System.Windows.Forms.Label()
        ÂgeELabel = New System.Windows.Forms.Label()
        SexeELabel = New System.Windows.Forms.Label()
        DateNaissELabel = New System.Windows.Forms.Label()
        SerieLabel = New System.Windows.Forms.Label()
        LibelléFLabel = New System.Windows.Forms.Label()
        DescriptionFLabel = New System.Windows.Forms.Label()
        N_BorderauLabel = New System.Windows.Forms.Label()
        MontantLabel = New System.Windows.Forms.Label()
        TotalPayeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InscriptionRBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionEtudiantsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InscriptionRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdELabel
        '
        IdELabel.AutoSize = True
        IdELabel.Location = New System.Drawing.Point(31, 45)
        IdELabel.Name = "IdELabel"
        IdELabel.Size = New System.Drawing.Size(36, 14)
        IdELabel.TabIndex = 49
        IdELabel.Text = "Id E:"
        '
        'NomELabel
        '
        NomELabel.AutoSize = True
        NomELabel.Location = New System.Drawing.Point(31, 88)
        NomELabel.Name = "NomELabel"
        NomELabel.Size = New System.Drawing.Size(49, 14)
        NomELabel.TabIndex = 51
        NomELabel.Text = "Nom E:"
        '
        'PrénomsELabel
        '
        PrénomsELabel.AutoSize = True
        PrénomsELabel.Location = New System.Drawing.Point(31, 124)
        PrénomsELabel.Name = "PrénomsELabel"
        PrénomsELabel.Size = New System.Drawing.Size(72, 14)
        PrénomsELabel.TabIndex = 53
        PrénomsELabel.Text = "Prénoms E:"
        '
        'ÂgeELabel
        '
        ÂgeELabel.AutoSize = True
        ÂgeELabel.Location = New System.Drawing.Point(31, 164)
        ÂgeELabel.Name = "ÂgeELabel"
        ÂgeELabel.Size = New System.Drawing.Size(43, 14)
        ÂgeELabel.TabIndex = 55
        ÂgeELabel.Text = "Âge E:"
        '
        'SexeELabel
        '
        SexeELabel.AutoSize = True
        SexeELabel.Location = New System.Drawing.Point(383, 45)
        SexeELabel.Name = "SexeELabel"
        SexeELabel.Size = New System.Drawing.Size(49, 14)
        SexeELabel.TabIndex = 57
        SexeELabel.Text = "Sexe E:"
        '
        'DateNaissELabel
        '
        DateNaissELabel.AutoSize = True
        DateNaissELabel.Location = New System.Drawing.Point(383, 84)
        DateNaissELabel.Name = "DateNaissELabel"
        DateNaissELabel.Size = New System.Drawing.Size(82, 14)
        DateNaissELabel.TabIndex = 59
        DateNaissELabel.Text = "Date Naiss E:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(383, 124)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(40, 14)
        SerieLabel.TabIndex = 61
        SerieLabel.Text = "Serie:"
        '
        'LibelléFLabel
        '
        LibelléFLabel.AutoSize = True
        LibelléFLabel.Location = New System.Drawing.Point(383, 167)
        LibelléFLabel.Name = "LibelléFLabel"
        LibelléFLabel.Size = New System.Drawing.Size(62, 14)
        LibelléFLabel.TabIndex = 63
        LibelléFLabel.Text = "Libellé F:"
        '
        'DescriptionFLabel
        '
        DescriptionFLabel.AutoSize = True
        DescriptionFLabel.Location = New System.Drawing.Point(733, 40)
        DescriptionFLabel.Name = "DescriptionFLabel"
        DescriptionFLabel.Size = New System.Drawing.Size(87, 14)
        DescriptionFLabel.TabIndex = 65
        DescriptionFLabel.Text = "Description F:"
        '
        'N_BorderauLabel
        '
        N_BorderauLabel.AutoSize = True
        N_BorderauLabel.Location = New System.Drawing.Point(733, 71)
        N_BorderauLabel.Name = "N_BorderauLabel"
        N_BorderauLabel.Size = New System.Drawing.Size(78, 14)
        N_BorderauLabel.TabIndex = 67
        N_BorderauLabel.Text = "N°Borderau:"
        '
        'MontantLabel
        '
        MontantLabel.AutoSize = True
        MontantLabel.Location = New System.Drawing.Point(733, 99)
        MontantLabel.Name = "MontantLabel"
        MontantLabel.Size = New System.Drawing.Size(56, 14)
        MontantLabel.TabIndex = 69
        MontantLabel.Text = "Montant:"
        '
        'TotalPayeLabel
        '
        TotalPayeLabel.AutoSize = True
        TotalPayeLabel.Location = New System.Drawing.Point(733, 127)
        TotalPayeLabel.Name = "TotalPayeLabel"
        TotalPayeLabel.Size = New System.Drawing.Size(69, 14)
        TotalPayeLabel.TabIndex = 71
        TotalPayeLabel.Text = "Total Paye:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(733, 165)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(36, 14)
        DateLabel.TabIndex = 73
        DateLabel.Text = "Date:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 452)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(1144, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ListeEtudiants"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(88, 20)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(199, 22)
        Me.TextBox11.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(14, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 18)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Filtrer"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(887, 18)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(183, 22)
        Me.TextBox6.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(797, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Recherche"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.DataGridView1.DataSource = Me.InscriptionRBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(3, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1118, 130)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IdE"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IdE"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NomE"
        Me.DataGridViewTextBoxColumn15.HeaderText = "NomE"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PrénomsE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PrénomsE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ÂgeE"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ÂgeE"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SexeE"
        Me.DataGridViewTextBoxColumn18.HeaderText = "SexeE"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DateNaissE"
        Me.DataGridViewTextBoxColumn19.HeaderText = "DateNaissE"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Serie"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "LibelléF"
        Me.DataGridViewTextBoxColumn21.HeaderText = "LibelléF"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DescriptionF"
        Me.DataGridViewTextBoxColumn22.HeaderText = "DescriptionF"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "N°Borderau"
        Me.DataGridViewTextBoxColumn23.HeaderText = "N°Borderau"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Montant"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Montant"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TotalPaye"
        Me.DataGridViewTextBoxColumn25.HeaderText = "TotalPaye"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'InscriptionRBindingSource1
        '
        Me.InscriptionRBindingSource1.DataMember = "Inscription_R"
        Me.InscriptionRBindingSource1.DataSource = Me.GestionEtudiantsDataSet2
        '
        'GestionEtudiantsDataSet2
        '
        Me.GestionEtudiantsDataSet2.DataSetName = "GestionEtudiantsDataSet"
        Me.GestionEtudiantsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Gestion_Etudiants.My.Resources.Resources.funnel
        Me.Button7.Location = New System.Drawing.Point(251, 15)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 39)
        Me.Button7.TabIndex = 21
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Gestion_Etudiants.My.Resources.Resources.search
        Me.Button8.Location = New System.Drawing.Point(1052, 11)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(59, 35)
        Me.Button8.TabIndex = 22
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdELabel)
        Me.GroupBox1.Controls.Add(Me.IdETextBox)
        Me.GroupBox1.Controls.Add(NomELabel)
        Me.GroupBox1.Controls.Add(Me.NomETextBox)
        Me.GroupBox1.Controls.Add(PrénomsELabel)
        Me.GroupBox1.Controls.Add(Me.PrénomsETextBox)
        Me.GroupBox1.Controls.Add(ÂgeELabel)
        Me.GroupBox1.Controls.Add(Me.ÂgeETextBox)
        Me.GroupBox1.Controls.Add(SexeELabel)
        Me.GroupBox1.Controls.Add(Me.SexeETextBox)
        Me.GroupBox1.Controls.Add(DateNaissELabel)
        Me.GroupBox1.Controls.Add(Me.DateNaissEDateTimePicker)
        Me.GroupBox1.Controls.Add(SerieLabel)
        Me.GroupBox1.Controls.Add(Me.SerieTextBox)
        Me.GroupBox1.Controls.Add(LibelléFLabel)
        Me.GroupBox1.Controls.Add(Me.LibelléFTextBox)
        Me.GroupBox1.Controls.Add(DescriptionFLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionFTextBox)
        Me.GroupBox1.Controls.Add(N_BorderauLabel)
        Me.GroupBox1.Controls.Add(Me.N_BorderauTextBox)
        Me.GroupBox1.Controls.Add(MontantLabel)
        Me.GroupBox1.Controls.Add(Me.MontantTextBox)
        Me.GroupBox1.Controls.Add(TotalPayeLabel)
        Me.GroupBox1.Controls.Add(Me.TotalPayeTextBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(1141, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inscription"
        '
        'IdETextBox
        '
        Me.IdETextBox.Location = New System.Drawing.Point(124, 42)
        Me.IdETextBox.Name = "IdETextBox"
        Me.IdETextBox.Size = New System.Drawing.Size(220, 22)
        Me.IdETextBox.TabIndex = 50
        '
        'NomETextBox
        '
        Me.NomETextBox.Location = New System.Drawing.Point(124, 85)
        Me.NomETextBox.Name = "NomETextBox"
        Me.NomETextBox.Size = New System.Drawing.Size(220, 22)
        Me.NomETextBox.TabIndex = 52
        '
        'PrénomsETextBox
        '
        Me.PrénomsETextBox.Location = New System.Drawing.Point(124, 121)
        Me.PrénomsETextBox.Name = "PrénomsETextBox"
        Me.PrénomsETextBox.Size = New System.Drawing.Size(220, 22)
        Me.PrénomsETextBox.TabIndex = 54
        '
        'ÂgeETextBox
        '
        Me.ÂgeETextBox.Location = New System.Drawing.Point(124, 161)
        Me.ÂgeETextBox.Name = "ÂgeETextBox"
        Me.ÂgeETextBox.Size = New System.Drawing.Size(220, 22)
        Me.ÂgeETextBox.TabIndex = 56
        '
        'SexeETextBox
        '
        Me.SexeETextBox.Location = New System.Drawing.Point(476, 42)
        Me.SexeETextBox.Name = "SexeETextBox"
        Me.SexeETextBox.Size = New System.Drawing.Size(220, 22)
        Me.SexeETextBox.TabIndex = 58
        '
        'DateNaissEDateTimePicker
        '
        Me.DateNaissEDateTimePicker.Location = New System.Drawing.Point(476, 80)
        Me.DateNaissEDateTimePicker.Name = "DateNaissEDateTimePicker"
        Me.DateNaissEDateTimePicker.Size = New System.Drawing.Size(220, 22)
        Me.DateNaissEDateTimePicker.TabIndex = 60
        '
        'SerieTextBox
        '
        Me.SerieTextBox.Location = New System.Drawing.Point(476, 121)
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(220, 22)
        Me.SerieTextBox.TabIndex = 62
        '
        'LibelléFTextBox
        '
        Me.LibelléFTextBox.Location = New System.Drawing.Point(476, 164)
        Me.LibelléFTextBox.Name = "LibelléFTextBox"
        Me.LibelléFTextBox.Size = New System.Drawing.Size(220, 22)
        Me.LibelléFTextBox.TabIndex = 64
        '
        'DescriptionFTextBox
        '
        Me.DescriptionFTextBox.Location = New System.Drawing.Point(826, 37)
        Me.DescriptionFTextBox.Name = "DescriptionFTextBox"
        Me.DescriptionFTextBox.Size = New System.Drawing.Size(220, 22)
        Me.DescriptionFTextBox.TabIndex = 66
        '
        'N_BorderauTextBox
        '
        Me.N_BorderauTextBox.Location = New System.Drawing.Point(826, 68)
        Me.N_BorderauTextBox.Name = "N_BorderauTextBox"
        Me.N_BorderauTextBox.Size = New System.Drawing.Size(220, 22)
        Me.N_BorderauTextBox.TabIndex = 68
        '
        'MontantTextBox
        '
        Me.MontantTextBox.Location = New System.Drawing.Point(826, 96)
        Me.MontantTextBox.Name = "MontantTextBox"
        Me.MontantTextBox.Size = New System.Drawing.Size(220, 22)
        Me.MontantTextBox.TabIndex = 70
        '
        'TotalPayeTextBox
        '
        Me.TotalPayeTextBox.Location = New System.Drawing.Point(826, 124)
        Me.TotalPayeTextBox.Name = "TotalPayeTextBox"
        Me.TotalPayeTextBox.Size = New System.Drawing.Size(220, 22)
        Me.TotalPayeTextBox.TabIndex = 72
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Location = New System.Drawing.Point(826, 161)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(220, 22)
        Me.DateDateTimePicker.TabIndex = 74
        '
        'Button6
        '
        Me.Button6.Image = Global.Gestion_Etudiants.My.Resources.Resources.delete
        Me.Button6.Location = New System.Drawing.Point(916, 215)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Supprimer"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Gestion_Etudiants.My.Resources.Resources.printer
        Me.Button5.Location = New System.Drawing.Point(733, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Imprimer"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Gestion_Etudiants.My.Resources.Resources.diskette__1_
        Me.Button4.Location = New System.Drawing.Point(396, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Sauvegarder"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Gestion_Etudiants.My.Resources.Resources.follow__1_
        Me.Button3.Location = New System.Drawing.Point(220, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Nouveau"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Gestion_Etudiants.My.Resources.Resources.next_button
        Me.Button2.Location = New System.Drawing.Point(563, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Suivant"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Gestion_Etudiants.My.Resources.Resources.previous__1_
        Me.Button1.Location = New System.Drawing.Point(42, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Précedent"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InscriptionRBindingSource
        '
        Me.InscriptionRBindingSource.DataMember = "Inscription_R"
        '
        'Inscription_RTableAdapter2
        '
        Me.Inscription_RTableAdapter2.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InscriptionRBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionEtudiantsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InscriptionRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GestionEtudiantsDataSet As GestionEtudiantsDataSet
    Friend WithEvents Inscription_RTableAdapter As GestionEtudiantsDataSetTableAdapters.Inscription_RTableAdapter
    Friend WithEvents IdEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrénomsEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ÂgeEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateNaissEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibelléFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NBorderauDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPayeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GestionEtudiantsDataSet1 As GestionEtudiantsDataSet
    Friend WithEvents InscriptionRBindingSource As BindingSource
    Friend WithEvents Inscription_RTableAdapter1 As GestionEtudiantsDataSetTableAdapters.Inscription_RTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents IdETextBox As TextBox
    Friend WithEvents NomETextBox As TextBox
    Friend WithEvents PrénomsETextBox As TextBox
    Friend WithEvents ÂgeETextBox As TextBox
    Friend WithEvents SexeETextBox As TextBox
    Friend WithEvents DateNaissEDateTimePicker As DateTimePicker
    Friend WithEvents SerieTextBox As TextBox
    Friend WithEvents LibelléFTextBox As TextBox
    Friend WithEvents DescriptionFTextBox As TextBox
    Friend WithEvents N_BorderauTextBox As TextBox
    Friend WithEvents MontantTextBox As TextBox
    Friend WithEvents TotalPayeTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents GestionEtudiantsDataSet2 As GestionEtudiantsDataSet
    Friend WithEvents InscriptionRBindingSource1 As BindingSource
    Friend WithEvents Inscription_RTableAdapter2 As GestionEtudiantsDataSetTableAdapters.Inscription_RTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
End Class
