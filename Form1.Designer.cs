namespace VillageNewbiesOhjelmisto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvMokkiNakyma = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoviDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoviDataset = new VillageNewbiesOhjelmisto.HoviDataset();
            this.tbToimialue = new System.Windows.Forms.TextBox();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.lblToimialue = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.osastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.tbHaku = new System.Windows.Forms.TextBox();
            this.mcKalenteri = new System.Windows.Forms.MonthCalendar();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varaus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiDataset = new VillageNewbiesOhjelmisto.mokkiDataset();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.lblPostinumeroAsiakas = new System.Windows.Forms.Label();
            this.tbPostinroAsiakas = new System.Windows.Forms.TextBox();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.tbPuhelinnro = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.lblPostitoimipaikkaAsiakas = new System.Windows.Forms.Label();
            this.tbPostitoimipaikkaAsiakas = new System.Windows.Forms.TextBox();
            this.lblEtsi = new System.Windows.Forms.Label();
            this.btnTyhjennaVaraukset = new System.Windows.Forms.Button();
            this.btnTyhjennä = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMaksuMaksettu = new System.Windows.Forms.Label();
            this.lblOnkoLaskuMaksettu = new System.Windows.Forms.Label();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.laskuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLaskuMaksettu = new System.Windows.Forms.Button();
            this.lblMokinYhtHinta = new System.Windows.Forms.Label();
            this.lblMokinYot = new System.Windows.Forms.Label();
            this.lblMokinHinta = new System.Windows.Forms.Label();
            this.tbHintaMokki = new System.Windows.Forms.TextBox();
            this.lblHintaMokki = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLisaaPalv = new System.Windows.Forms.Button();
            this.comboBPalvelut = new System.Windows.Forms.ComboBox();
            this.lblPalvelu = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.lblPalveluID = new System.Windows.Forms.Label();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.lblAlv = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.tbKuvausPalvelu = new System.Windows.Forms.TextBox();
            this.lblKuvausPalvelu = new System.Windows.Forms.Label();
            this.tbTyyppi = new System.Windows.Forms.TextBox();
            this.lblTyyppi = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.lblNimi = new System.Windows.Forms.Label();
            this.tbToimintaalue = new System.Windows.Forms.TextBox();
            this.lblToimintaalue = new System.Windows.Forms.Label();
            this.mokkiTableAdapter = new VillageNewbiesOhjelmisto.HoviDatasetTableAdapters.mokkiTableAdapter();
            this.postiTableAdapter = new VillageNewbiesOhjelmisto.HoviDatasetTableAdapters.postiTableAdapter();
            this.toimintaalueTableAdapter = new VillageNewbiesOhjelmisto.HoviDatasetTableAdapters.toimintaalueTableAdapter();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new VillageNewbiesOhjelmisto.mokkiDatasetTableAdapters.asiakasTableAdapter();
            this.varausTableAdapter = new VillageNewbiesOhjelmisto.mokkiDatasetTableAdapters.varausTableAdapter();
            this.palveluTableAdapter = new VillageNewbiesOhjelmisto.mokkiDatasetTableAdapters.palveluTableAdapter();
            this.laskuTableAdapter = new VillageNewbiesOhjelmisto.mokkiDatasetTableAdapters.laskuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokkiNakyma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoviDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoviDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osastoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiDataset)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMokkiNakyma
            // 
            this.dgvMokkiNakyma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokkiNakyma.AutoGenerateColumns = false;
            this.dgvMokkiNakyma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokkiNakyma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokkiNakyma.DataSource = this.mokkiBindingSource;
            this.dgvMokkiNakyma.Location = new System.Drawing.Point(244, 94);
            this.dgvMokkiNakyma.Name = "dgvMokkiNakyma";
            this.dgvMokkiNakyma.RowHeadersWidth = 62;
            this.dgvMokkiNakyma.RowTemplate.Height = 28;
            this.dgvMokkiNakyma.Size = new System.Drawing.Size(502, 447);
            this.dgvMokkiNakyma.TabIndex = 0;
            this.dgvMokkiNakyma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            this.mokkiidDataGridViewTextBoxColumn.Width = 150;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            this.toimintaalueidDataGridViewTextBoxColumn.Width = 150;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 150;
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            this.mokkinimiDataGridViewTextBoxColumn.Width = 150;
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            this.katuosoiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.Width = 150;
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            this.henkilomaaraDataGridViewTextBoxColumn.Width = 150;
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            this.varusteluDataGridViewTextBoxColumn.Width = 150;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.hoviDatasetBindingSource;
            // 
            // hoviDatasetBindingSource
            // 
            this.hoviDatasetBindingSource.DataSource = this.hoviDataset;
            this.hoviDatasetBindingSource.Position = 0;
            // 
            // hoviDataset
            // 
            this.hoviDataset.DataSetName = "HoviDataset";
            this.hoviDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbToimialue
            // 
            this.tbToimialue.Location = new System.Drawing.Point(15, 57);
            this.tbToimialue.Name = "tbToimialue";
            this.tbToimialue.Size = new System.Drawing.Size(181, 26);
            this.tbToimialue.TabIndex = 1;
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postiBindingSource, "toimipaikka", true));
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(15, 120);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(181, 26);
            this.tbPostitoimipaikka.TabIndex = 2;
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.hoviDatasetBindingSource;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "mokkinimi", true));
            this.tbMokkinimi.Location = new System.Drawing.Point(15, 240);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(181, 26);
            this.tbMokkinimi.TabIndex = 3;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "katuosoite", true));
            this.tbKatuosoite.Location = new System.Drawing.Point(15, 301);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(181, 26);
            this.tbKatuosoite.TabIndex = 4;
            // 
            // lblToimialue
            // 
            this.lblToimialue.AutoSize = true;
            this.lblToimialue.CausesValidation = false;
            this.lblToimialue.Location = new System.Drawing.Point(34, 16);
            this.lblToimialue.Name = "lblToimialue";
            this.lblToimialue.Size = new System.Drawing.Size(126, 20);
            this.lblToimialue.TabIndex = 5;
            this.lblToimialue.Text = "Toimialueen nimi";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(34, 97);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(123, 20);
            this.lblPostitoimipaikka.TabIndex = 6;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(34, 217);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(83, 20);
            this.lblMokkinimi.TabIndex = 7;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(34, 278);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(85, 20);
            this.lblKatuosoite.TabIndex = 8;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(8, 595);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(111, 41);
            this.btnLisaa.TabIndex = 9;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.BtnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(8, 642);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(111, 40);
            this.btnPoista.TabIndex = 10;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(34, 341);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(61, 20);
            this.lblKuvaus.TabIndex = 12;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "kuvaus", true));
            this.tbKuvaus.Location = new System.Drawing.Point(15, 364);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(181, 26);
            this.tbKuvaus.TabIndex = 11;
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(34, 468);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(77, 20);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "varustelu", true));
            this.tbVarustelu.Location = new System.Drawing.Point(15, 491);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(181, 26);
            this.tbVarustelu.TabIndex = 15;
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(34, 405);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(107, 20);
            this.lblHenkilomaara.TabIndex = 14;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "henkilomaara", true));
            this.tbHenkilomaara.Location = new System.Drawing.Point(15, 428);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(181, 26);
            this.tbHenkilomaara.TabIndex = 13;
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Location = new System.Drawing.Point(34, 158);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(98, 20);
            this.lblPostinumero.TabIndex = 18;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "postinro", true));
            this.tbPostinumero.Location = new System.Drawing.Point(15, 181);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(181, 26);
            this.tbPostinumero.TabIndex = 17;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.hoviDatasetBindingSource;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(125, 642);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(112, 43);
            this.btnMuokkaa.TabIndex = 19;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.BtnMuokkaa_Click);
            // 
            // tbHaku
            // 
            this.tbHaku.Location = new System.Drawing.Point(282, 39);
            this.tbHaku.Name = "tbHaku";
            this.tbHaku.Size = new System.Drawing.Size(294, 26);
            this.tbHaku.TabIndex = 20;
            this.tbHaku.TextChanged += new System.EventHandler(this.TbHaku_TextChanged);
            // 
            // mcKalenteri
            // 
            this.mcKalenteri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcKalenteri.Location = new System.Drawing.Point(780, 16);
            this.mcKalenteri.Name = "mcKalenteri";
            this.mcKalenteri.TabIndex = 21;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEtunimi.Location = new System.Drawing.Point(762, 566);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(181, 26);
            this.tbEtunimi.TabIndex = 22;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(670, 569);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(62, 20);
            this.lblEtunimi.TabIndex = 23;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoGenerateColumns = false;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.varaus_id});
            this.dgvAsiakkaat.DataSource = this.varausBindingSource;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(780, 278);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersWidth = 62;
            this.dgvAsiakkaat.RowTemplate.Height = 28;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(312, 263);
            this.dgvAsiakkaat.TabIndex = 24;
            this.dgvAsiakkaat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAsiakkaat_CellClick);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.Width = 150;
            // 
            // varaus_id
            // 
            this.varaus_id.DataPropertyName = "varaus_id";
            this.varaus_id.HeaderText = "varaus_id";
            this.varaus_id.MinimumWidth = 8;
            this.varaus_id.Name = "varaus_id";
            this.varaus_id.Width = 150;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.mokkiDataset;
            // 
            // mokkiDataset
            // 
            this.mokkiDataset.DataSetName = "mokkiDataset";
            this.mokkiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(670, 603);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(74, 20);
            this.lblSukunimi.TabIndex = 26;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSukunimi.Location = new System.Drawing.Point(762, 600);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(181, 26);
            this.tbSukunimi.TabIndex = 25;
            // 
            // lblPostinumeroAsiakas
            // 
            this.lblPostinumeroAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostinumeroAsiakas.AutoSize = true;
            this.lblPostinumeroAsiakas.Location = new System.Drawing.Point(670, 637);
            this.lblPostinumeroAsiakas.Name = "lblPostinumeroAsiakas";
            this.lblPostinumeroAsiakas.Size = new System.Drawing.Size(67, 20);
            this.lblPostinumeroAsiakas.TabIndex = 28;
            this.lblPostinumeroAsiakas.Text = "Postinro";
            // 
            // tbPostinroAsiakas
            // 
            this.tbPostinroAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostinroAsiakas.Location = new System.Drawing.Point(762, 634);
            this.tbPostinroAsiakas.Name = "tbPostinroAsiakas";
            this.tbPostinroAsiakas.Size = new System.Drawing.Size(181, 26);
            this.tbPostinroAsiakas.TabIndex = 27;
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuhelinnumero.AutoSize = true;
            this.lblPuhelinnumero.Location = new System.Drawing.Point(670, 777);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(84, 20);
            this.lblPuhelinnumero.TabIndex = 34;
            this.lblPuhelinnumero.Text = "Puhelinnro";
            // 
            // tbPuhelinnro
            // 
            this.tbPuhelinnro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPuhelinnro.Location = new System.Drawing.Point(762, 774);
            this.tbPuhelinnro.Name = "tbPuhelinnro";
            this.tbPuhelinnro.Size = new System.Drawing.Size(181, 26);
            this.tbPuhelinnro.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(670, 743);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(762, 740);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(181, 26);
            this.tbEmail.TabIndex = 31;
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(670, 709);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(82, 20);
            this.lblLahiosoite.TabIndex = 30;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLahiosoite.Location = new System.Drawing.Point(762, 706);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(181, 26);
            this.tbLahiosoite.TabIndex = 29;
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(979, 566);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(126, 51);
            this.btnLisaaAsiakas.TabIndex = 35;
            this.btnLisaaAsiakas.Text = "Lisää varaus";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.BtnLisaaAsiakas_Click);
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(979, 630);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(126, 51);
            this.btnPoistaAsiakas.TabIndex = 36;
            this.btnPoistaAsiakas.Text = "Poista varaus";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.BtnPoistaAsiakas_Click);
            // 
            // lblPostitoimipaikkaAsiakas
            // 
            this.lblPostitoimipaikkaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostitoimipaikkaAsiakas.AutoSize = true;
            this.lblPostitoimipaikkaAsiakas.Location = new System.Drawing.Point(631, 669);
            this.lblPostitoimipaikkaAsiakas.Name = "lblPostitoimipaikkaAsiakas";
            this.lblPostitoimipaikkaAsiakas.Size = new System.Drawing.Size(123, 20);
            this.lblPostitoimipaikkaAsiakas.TabIndex = 38;
            this.lblPostitoimipaikkaAsiakas.Text = "Postitoimipaikka";
            // 
            // tbPostitoimipaikkaAsiakas
            // 
            this.tbPostitoimipaikkaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostitoimipaikkaAsiakas.Location = new System.Drawing.Point(762, 669);
            this.tbPostitoimipaikkaAsiakas.Name = "tbPostitoimipaikkaAsiakas";
            this.tbPostitoimipaikkaAsiakas.Size = new System.Drawing.Size(181, 26);
            this.tbPostitoimipaikkaAsiakas.TabIndex = 37;
            // 
            // lblEtsi
            // 
            this.lblEtsi.AutoSize = true;
            this.lblEtsi.Location = new System.Drawing.Point(240, 42);
            this.lblEtsi.Name = "lblEtsi";
            this.lblEtsi.Size = new System.Drawing.Size(36, 20);
            this.lblEtsi.TabIndex = 39;
            this.lblEtsi.Text = "Etsi";
            // 
            // btnTyhjennaVaraukset
            // 
            this.btnTyhjennaVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTyhjennaVaraukset.Location = new System.Drawing.Point(979, 694);
            this.btnTyhjennaVaraukset.Name = "btnTyhjennaVaraukset";
            this.btnTyhjennaVaraukset.Size = new System.Drawing.Size(126, 51);
            this.btnTyhjennaVaraukset.TabIndex = 40;
            this.btnTyhjennaVaraukset.Text = "Tyhjennä";
            this.btnTyhjennaVaraukset.UseVisualStyleBackColor = true;
            this.btnTyhjennaVaraukset.Click += new System.EventHandler(this.BtnTyhjennaVaraukset_Click);
            // 
            // btnTyhjennä
            // 
            this.btnTyhjennä.Location = new System.Drawing.Point(125, 595);
            this.btnTyhjennä.Name = "btnTyhjennä";
            this.btnTyhjennä.Size = new System.Drawing.Size(111, 41);
            this.btnTyhjennä.TabIndex = 41;
            this.btnTyhjennä.Text = "Tyhjennä";
            this.btnTyhjennä.UseVisualStyleBackColor = true;
            this.btnTyhjennä.Click += new System.EventHandler(this.BtnTyhjennä_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(273, 728);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 46);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "Tulosta lasku";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 860);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMaksuMaksettu);
            this.tabPage2.Controls.Add(this.lblOnkoLaskuMaksettu);
            this.tabPage2.Controls.Add(this.dgvLaskut);
            this.tabPage2.Controls.Add(this.btnLaskuMaksettu);
            this.tabPage2.Controls.Add(this.lblMokinYhtHinta);
            this.tabPage2.Controls.Add(this.lblMokinYot);
            this.tabPage2.Controls.Add(this.lblMokinHinta);
            this.tabPage2.Controls.Add(this.tbHintaMokki);
            this.tabPage2.Controls.Add(this.lblHintaMokki);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnLisaaPalv);
            this.tabPage2.Controls.Add(this.comboBPalvelut);
            this.tabPage2.Controls.Add(this.lblPalvelu);
            this.tabPage2.Controls.Add(this.btnLisaa);
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.btnTyhjennaVaraukset);
            this.tabPage2.Controls.Add(this.btnTyhjennä);
            this.tabPage2.Controls.Add(this.lblPostitoimipaikkaAsiakas);
            this.tabPage2.Controls.Add(this.lblEtsi);
            this.tabPage2.Controls.Add(this.tbPostitoimipaikkaAsiakas);
            this.tabPage2.Controls.Add(this.btnMuokkaa);
            this.tabPage2.Controls.Add(this.btnPoistaAsiakas);
            this.tabPage2.Controls.Add(this.lblToimialue);
            this.tabPage2.Controls.Add(this.btnLisaaAsiakas);
            this.tabPage2.Controls.Add(this.tbToimialue);
            this.tabPage2.Controls.Add(this.lblPuhelinnumero);
            this.tabPage2.Controls.Add(this.tbPostitoimipaikka);
            this.tabPage2.Controls.Add(this.tbPuhelinnro);
            this.tabPage2.Controls.Add(this.tbMokkinimi);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.tbKatuosoite);
            this.tabPage2.Controls.Add(this.tbEmail);
            this.tabPage2.Controls.Add(this.lblPostitoimipaikka);
            this.tabPage2.Controls.Add(this.lblLahiosoite);
            this.tabPage2.Controls.Add(this.lblMokkinimi);
            this.tabPage2.Controls.Add(this.tbLahiosoite);
            this.tabPage2.Controls.Add(this.lblKatuosoite);
            this.tabPage2.Controls.Add(this.lblPostinumeroAsiakas);
            this.tabPage2.Controls.Add(this.tbKuvaus);
            this.tabPage2.Controls.Add(this.tbPostinroAsiakas);
            this.tabPage2.Controls.Add(this.lblKuvaus);
            this.tabPage2.Controls.Add(this.lblSukunimi);
            this.tabPage2.Controls.Add(this.tbHenkilomaara);
            this.tabPage2.Controls.Add(this.tbSukunimi);
            this.tabPage2.Controls.Add(this.lblHenkilomaara);
            this.tabPage2.Controls.Add(this.lblEtunimi);
            this.tabPage2.Controls.Add(this.dgvAsiakkaat);
            this.tabPage2.Controls.Add(this.tbEtunimi);
            this.tabPage2.Controls.Add(this.tbVarustelu);
            this.tabPage2.Controls.Add(this.lblVarustelu);
            this.tabPage2.Controls.Add(this.tbPostinumero);
            this.tabPage2.Controls.Add(this.mcKalenteri);
            this.tabPage2.Controls.Add(this.lblPostinumero);
            this.tabPage2.Controls.Add(this.dgvMokkiNakyma);
            this.tabPage2.Controls.Add(this.tbHaku);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 827);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMaksuMaksettu
            // 
            this.lblMaksuMaksettu.AutoSize = true;
            this.lblMaksuMaksettu.Location = new System.Drawing.Point(534, 597);
            this.lblMaksuMaksettu.Name = "lblMaksuMaksettu";
            this.lblMaksuMaksettu.Size = new System.Drawing.Size(56, 20);
            this.lblMaksuMaksettu.TabIndex = 58;
            this.lblMaksuMaksettu.Text = "Maksu";
            this.lblMaksuMaksettu.Visible = false;
            // 
            // lblOnkoLaskuMaksettu
            // 
            this.lblOnkoLaskuMaksettu.AutoSize = true;
            this.lblOnkoLaskuMaksettu.Location = new System.Drawing.Point(505, 562);
            this.lblOnkoLaskuMaksettu.Name = "lblOnkoLaskuMaksettu";
            this.lblOnkoLaskuMaksettu.Size = new System.Drawing.Size(158, 20);
            this.lblOnkoLaskuMaksettu.TabIndex = 57;
            this.lblOnkoLaskuMaksettu.Text = "Onko lasku maksettu";
            this.lblOnkoLaskuMaksettu.Visible = false;
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaskut.AutoGenerateColumns = false;
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laskuidDataGridViewTextBoxColumn,
            this.varausidDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn1});
            this.dgvLaskut.DataSource = this.laskuBindingSource;
            this.dgvLaskut.Location = new System.Drawing.Point(11, 752);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 62;
            this.dgvLaskut.RowTemplate.Height = 28;
            this.dgvLaskut.Size = new System.Drawing.Size(240, 69);
            this.dgvLaskut.TabIndex = 56;
            this.dgvLaskut.Visible = false;
            // 
            // laskuidDataGridViewTextBoxColumn
            // 
            this.laskuidDataGridViewTextBoxColumn.DataPropertyName = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.HeaderText = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.laskuidDataGridViewTextBoxColumn.Name = "laskuidDataGridViewTextBoxColumn";
            this.laskuidDataGridViewTextBoxColumn.Width = 150;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            this.varausidDataGridViewTextBoxColumn.Width = 150;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.Width = 150;
            // 
            // alvDataGridViewTextBoxColumn1
            // 
            this.alvDataGridViewTextBoxColumn1.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn1.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.alvDataGridViewTextBoxColumn1.Name = "alvDataGridViewTextBoxColumn1";
            this.alvDataGridViewTextBoxColumn1.Width = 150;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.mokkiDataset;
            // 
            // btnLaskuMaksettu
            // 
            this.btnLaskuMaksettu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaskuMaksettu.Location = new System.Drawing.Point(276, 780);
            this.btnLaskuMaksettu.Name = "btnLaskuMaksettu";
            this.btnLaskuMaksettu.Size = new System.Drawing.Size(117, 41);
            this.btnLaskuMaksettu.TabIndex = 55;
            this.btnLaskuMaksettu.Text = "Maksa lasku";
            this.btnLaskuMaksettu.UseVisualStyleBackColor = true;
            this.btnLaskuMaksettu.Click += new System.EventHandler(this.BtnLaskuMaksettu_Click);
            // 
            // lblMokinYhtHinta
            // 
            this.lblMokinYhtHinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMokinYhtHinta.AutoSize = true;
            this.lblMokinYhtHinta.Location = new System.Drawing.Point(257, 709);
            this.lblMokinYhtHinta.Name = "lblMokinYhtHinta";
            this.lblMokinYhtHinta.Size = new System.Drawing.Size(76, 20);
            this.lblMokinYhtHinta.TabIndex = 54;
            this.lblMokinYhtHinta.Text = "Hinta yht:";
            this.lblMokinYhtHinta.Visible = false;
            // 
            // lblMokinYot
            // 
            this.lblMokinYot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMokinYot.AutoSize = true;
            this.lblMokinYot.Location = new System.Drawing.Point(257, 645);
            this.lblMokinYot.Name = "lblMokinYot";
            this.lblMokinYot.Size = new System.Drawing.Size(112, 20);
            this.lblMokinYot.TabIndex = 53;
            this.lblMokinYot.Text = "Varatut päivät:";
            this.lblMokinYot.Visible = false;
            // 
            // lblMokinHinta
            // 
            this.lblMokinHinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMokinHinta.AutoSize = true;
            this.lblMokinHinta.Location = new System.Drawing.Point(257, 678);
            this.lblMokinHinta.Name = "lblMokinHinta";
            this.lblMokinHinta.Size = new System.Drawing.Size(94, 20);
            this.lblMokinHinta.TabIndex = 52;
            this.lblMokinHinta.Text = "Mökin hinta:";
            this.lblMokinHinta.Visible = false;
            // 
            // tbHintaMokki
            // 
            this.tbHintaMokki.Location = new System.Drawing.Point(15, 548);
            this.tbHintaMokki.Name = "tbHintaMokki";
            this.tbHintaMokki.Size = new System.Drawing.Size(181, 26);
            this.tbHintaMokki.TabIndex = 50;
            // 
            // lblHintaMokki
            // 
            this.lblHintaMokki.AutoSize = true;
            this.lblHintaMokki.Location = new System.Drawing.Point(34, 525);
            this.lblHintaMokki.Name = "lblHintaMokki";
            this.lblHintaMokki.Size = new System.Drawing.Size(124, 20);
            this.lblHintaMokki.TabIndex = 51;
            this.lblHintaMokki.Text = "Yhden yön hinta";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(273, 600);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 49;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(408, 661);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 160);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnLisaaPalv
            // 
            this.btnLisaaPalv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaaPalv.Location = new System.Drawing.Point(408, 605);
            this.btnLisaaPalv.Name = "btnLisaaPalv";
            this.btnLisaaPalv.Size = new System.Drawing.Size(91, 43);
            this.btnLisaaPalv.TabIndex = 46;
            this.btnLisaaPalv.Text = "Lisää";
            this.btnLisaaPalv.UseVisualStyleBackColor = true;
            this.btnLisaaPalv.Click += new System.EventHandler(this.BtnLisaaPalv_Click);
            // 
            // comboBPalvelut
            // 
            this.comboBPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBPalvelut.FormattingEnabled = true;
            this.comboBPalvelut.Location = new System.Drawing.Point(322, 559);
            this.comboBPalvelut.Name = "comboBPalvelut";
            this.comboBPalvelut.Size = new System.Drawing.Size(177, 28);
            this.comboBPalvelut.TabIndex = 44;
            // 
            // lblPalvelu
            // 
            this.lblPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalvelu.AutoSize = true;
            this.lblPalvelu.Location = new System.Drawing.Point(257, 559);
            this.lblPalvelu.Name = "lblPalvelu";
            this.lblPalvelu.Size = new System.Drawing.Size(59, 20);
            this.lblPalvelu.TabIndex = 43;
            this.lblPalvelu.Text = "Palvelu";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPalveluID);
            this.tabPage1.Controls.Add(this.lblPalveluID);
            this.tabPage1.Controls.Add(this.btnPoistaPalvelu);
            this.tabPage1.Controls.Add(this.btnLisaaPalvelu);
            this.tabPage1.Controls.Add(this.dgvPalvelut);
            this.tabPage1.Controls.Add(this.tbAlv);
            this.tabPage1.Controls.Add(this.lblAlv);
            this.tabPage1.Controls.Add(this.tbHinta);
            this.tabPage1.Controls.Add(this.lblHinta);
            this.tabPage1.Controls.Add(this.tbKuvausPalvelu);
            this.tabPage1.Controls.Add(this.lblKuvausPalvelu);
            this.tabPage1.Controls.Add(this.tbTyyppi);
            this.tabPage1.Controls.Add(this.lblTyyppi);
            this.tabPage1.Controls.Add(this.tbNimi);
            this.tabPage1.Controls.Add(this.lblNimi);
            this.tabPage1.Controls.Add(this.tbToimintaalue);
            this.tabPage1.Controls.Add(this.lblToimintaalue);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(183, 55);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(207, 26);
            this.tbPalveluID.TabIndex = 16;
            // 
            // lblPalveluID
            // 
            this.lblPalveluID.AutoSize = true;
            this.lblPalveluID.Location = new System.Drawing.Point(61, 58);
            this.lblPalveluID.Name = "lblPalveluID";
            this.lblPalveluID.Size = new System.Drawing.Size(76, 20);
            this.lblPalveluID.TabIndex = 15;
            this.lblPalveluID.Text = "PalveluID";
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(226, 484);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(174, 87);
            this.btnPoistaPalvelu.TabIndex = 14;
            this.btnPoistaPalvelu.Text = "Poista";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.BtnPoistaPalvelu_Click);
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(21, 484);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(174, 87);
            this.btnLisaaPalvelu.TabIndex = 13;
            this.btnLisaaPalvelu.Text = "Lisää";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.BtnLisaaPalvelu_Click);
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalvelut.AutoGenerateColumns = false;
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn1,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dgvPalvelut.DataSource = this.palveluBindingSource;
            this.dgvPalvelut.Location = new System.Drawing.Point(426, 0);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersWidth = 62;
            this.dgvPalvelut.RowTemplate.Height = 28;
            this.dgvPalvelut.Size = new System.Drawing.Size(713, 827);
            this.dgvPalvelut.TabIndex = 12;
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            this.palveluidDataGridViewTextBoxColumn.Width = 150;
            // 
            // toimintaalueidDataGridViewTextBoxColumn1
            // 
            this.toimintaalueidDataGridViewTextBoxColumn1.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.toimintaalueidDataGridViewTextBoxColumn1.Name = "toimintaalueidDataGridViewTextBoxColumn1";
            this.toimintaalueidDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.Width = 150;
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            this.tyyppiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kuvausDataGridViewTextBoxColumn1
            // 
            this.kuvausDataGridViewTextBoxColumn1.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn1.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.kuvausDataGridViewTextBoxColumn1.Name = "kuvausDataGridViewTextBoxColumn1";
            this.kuvausDataGridViewTextBoxColumn1.Width = 150;
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            this.hintaDataGridViewTextBoxColumn.Width = 150;
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            this.alvDataGridViewTextBoxColumn.Width = 150;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.mokkiDataset;
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(184, 406);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(207, 26);
            this.tbAlv.TabIndex = 11;
            // 
            // lblAlv
            // 
            this.lblAlv.AutoSize = true;
            this.lblAlv.Location = new System.Drawing.Point(62, 406);
            this.lblAlv.Name = "lblAlv";
            this.lblAlv.Size = new System.Drawing.Size(40, 20);
            this.lblAlv.TabIndex = 10;
            this.lblAlv.Text = "ALV";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(184, 351);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(207, 26);
            this.tbHinta.TabIndex = 9;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(62, 351);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(47, 20);
            this.lblHinta.TabIndex = 8;
            this.lblHinta.Text = "Hinta";
            // 
            // tbKuvausPalvelu
            // 
            this.tbKuvausPalvelu.Location = new System.Drawing.Point(183, 263);
            this.tbKuvausPalvelu.Multiline = true;
            this.tbKuvausPalvelu.Name = "tbKuvausPalvelu";
            this.tbKuvausPalvelu.Size = new System.Drawing.Size(207, 70);
            this.tbKuvausPalvelu.TabIndex = 7;
            // 
            // lblKuvausPalvelu
            // 
            this.lblKuvausPalvelu.AutoSize = true;
            this.lblKuvausPalvelu.Location = new System.Drawing.Point(61, 263);
            this.lblKuvausPalvelu.Name = "lblKuvausPalvelu";
            this.lblKuvausPalvelu.Size = new System.Drawing.Size(61, 20);
            this.lblKuvausPalvelu.TabIndex = 6;
            this.lblKuvausPalvelu.Text = "Kuvaus";
            // 
            // tbTyyppi
            // 
            this.tbTyyppi.Location = new System.Drawing.Point(183, 210);
            this.tbTyyppi.Name = "tbTyyppi";
            this.tbTyyppi.Size = new System.Drawing.Size(207, 26);
            this.tbTyyppi.TabIndex = 5;
            // 
            // lblTyyppi
            // 
            this.lblTyyppi.AutoSize = true;
            this.lblTyyppi.Location = new System.Drawing.Point(61, 210);
            this.lblTyyppi.Name = "lblTyyppi";
            this.lblTyyppi.Size = new System.Drawing.Size(53, 20);
            this.lblTyyppi.TabIndex = 4;
            this.lblTyyppi.Text = "Tyyppi";
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(183, 157);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(207, 26);
            this.tbNimi.TabIndex = 3;
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(61, 157);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(39, 20);
            this.lblNimi.TabIndex = 2;
            this.lblNimi.Text = "Nimi";
            // 
            // tbToimintaalue
            // 
            this.tbToimintaalue.Location = new System.Drawing.Point(183, 104);
            this.tbToimintaalue.Name = "tbToimintaalue";
            this.tbToimintaalue.Size = new System.Drawing.Size(207, 26);
            this.tbToimintaalue.TabIndex = 1;
            // 
            // lblToimintaalue
            // 
            this.lblToimintaalue.AutoSize = true;
            this.lblToimintaalue.Location = new System.Drawing.Point(61, 104);
            this.lblToimintaalue.Name = "lblToimintaalue";
            this.lblToimintaalue.Size = new System.Drawing.Size(99, 20);
            this.lblToimintaalue.TabIndex = 0;
            this.lblToimintaalue.Text = "Toimintaalue";
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.mokkiDataset;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 860);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokkiNakyma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoviDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoviDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osastoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiDataset)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMokkiNakyma;
        private System.Windows.Forms.BindingSource hoviDatasetBindingSource;
        private HoviDataset hoviDataset;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private HoviDatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.TextBox tbToimialue;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.Label lblToimialue;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.BindingSource osastoBindingSource;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private HoviDatasetTableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private HoviDatasetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private mokkiDataset mokkiDataset;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.TextBox tbHaku;
        private System.Windows.Forms.MonthCalendar mcKalenteri;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label lblPostinumeroAsiakas;
        private System.Windows.Forms.TextBox tbPostinroAsiakas;
        private System.Windows.Forms.Label lblPuhelinnumero;
        private System.Windows.Forms.TextBox tbPuhelinnro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblLahiosoite;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Button btnLisaaAsiakas;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private mokkiDatasetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Label lblPostitoimipaikkaAsiakas;
        private System.Windows.Forms.TextBox tbPostitoimipaikkaAsiakas;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private mokkiDatasetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.Label lblEtsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varaus_id;
        private System.Windows.Forms.Button btnTyhjennaVaraukset;
        private System.Windows.Forms.Button btnTyhjennä;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.Label lblAlv;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.TextBox tbKuvausPalvelu;
        private System.Windows.Forms.Label lblKuvausPalvelu;
        private System.Windows.Forms.TextBox tbTyyppi;
        private System.Windows.Forms.Label lblTyyppi;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.TextBox tbToimintaalue;
        private System.Windows.Forms.Label lblToimintaalue;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private mokkiDatasetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.Label lblPalveluID;
        private System.Windows.Forms.ComboBox comboBPalvelut;
        private System.Windows.Forms.Label lblPalvelu;
        private System.Windows.Forms.Button btnLisaaPalv;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbHintaMokki;
        private System.Windows.Forms.Label lblHintaMokki;
        private System.Windows.Forms.Label lblMokinYot;
        private System.Windows.Forms.Label lblMokinHinta;
        private System.Windows.Forms.Label lblMokinYhtHinta;
        private System.Windows.Forms.Button btnLaskuMaksettu;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private mokkiDatasetTableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn laskuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblMaksuMaksettu;
        private System.Windows.Forms.Label lblOnkoLaskuMaksettu;
    }
}

