namespace NakliyeProje
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
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.LblGenelToplam = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.TxtNereye = new System.Windows.Forms.TextBox();
            this.TxtNereden = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtAlinan = new System.Windows.Forms.TextBox();
            this.TxtMasraf = new System.Windows.Forms.TextBox();
            this.TxtKdv = new System.Windows.Forms.TextBox();
            this.TxtKar = new System.Windows.Forms.TextBox();
            this.lblmasraf = new System.Windows.Forms.Label();
            this.LblToplamKdv = new System.Windows.Forms.Label();
            this.LblToplamKar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLINANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASRAFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVTUTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEREDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEREYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARİHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNakliyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nakliyeProjeDataSet = new NakliyeProje.NakliyeProjeDataSet();
            this.tblNakliyeTableAdapter = new NakliyeProje.NakliyeProjeDataSetTableAdapters.TblNakliyeTableAdapter();
            this.nakliyeProjeDataSet1 = new NakliyeProje.NakliyeProjeDataSet1();
            this.tblNakliyeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblNakliyeTableAdapter1 = new NakliyeProje.NakliyeProjeDataSet1TableAdapters.TblNakliyeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNakliyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakliyeProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakliyeProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNakliyeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.Location = new System.Drawing.Point(724, 586);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.Size = new System.Drawing.Size(211, 39);
            this.BtnFiltrele.TabIndex = 24;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = true;
            this.BtnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(578, 579);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(140, 25);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2023, 2, 22, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(578, 610);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(140, 25);
            this.dateTimePicker3.TabIndex = 23;
            this.dateTimePicker3.Value = new System.DateTime(2023, 2, 22, 0, 0, 0, 0);
            // 
            // LblGenelToplam
            // 
            this.LblGenelToplam.AutoSize = true;
            this.LblGenelToplam.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGenelToplam.Location = new System.Drawing.Point(18, 586);
            this.LblGenelToplam.Name = "LblGenelToplam";
            this.LblGenelToplam.Size = new System.Drawing.Size(14, 18);
            this.LblGenelToplam.TabIndex = 6;
            this.LblGenelToplam.Text = "-";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(586, 198);
            this.TxtAciklama.Multiline = true;
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(140, 52);
            this.TxtAciklama.TabIndex = 7;
            // 
            // TxtNereye
            // 
            this.TxtNereye.Location = new System.Drawing.Point(586, 136);
            this.TxtNereye.Name = "TxtNereye";
            this.TxtNereye.Size = new System.Drawing.Size(140, 25);
            this.TxtNereye.TabIndex = 5;
            // 
            // TxtNereden
            // 
            this.TxtNereden.Location = new System.Drawing.Point(586, 105);
            this.TxtNereden.Name = "TxtNereden";
            this.TxtNereden.Size = new System.Drawing.Size(140, 25);
            this.TxtNereden.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(253, 109);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(112, 31);
            this.BtnKaydet.TabIndex = 17;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(371, 109);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(112, 31);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(253, 182);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(230, 31);
            this.BtnHesapla.TabIndex = 15;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(253, 146);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(112, 31);
            this.BtnSil.TabIndex = 19;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(371, 146);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(112, 31);
            this.BtnTemizle.TabIndex = 20;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alınan Ücret:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(495, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nereden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Masraf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(506, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nereye:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kdv Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(489, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(78, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kâr:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(517, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tarih:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 100);
            this.panel1.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(205, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(520, 53);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ubeyde Gasel Nakliye Şirketi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(87, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(127, 101);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(104, 25);
            this.TxtId.TabIndex = 29;
            // 
            // TxtAlinan
            // 
            this.TxtAlinan.Location = new System.Drawing.Point(127, 132);
            this.TxtAlinan.Name = "TxtAlinan";
            this.TxtAlinan.Size = new System.Drawing.Size(104, 25);
            this.TxtAlinan.TabIndex = 0;
            // 
            // TxtMasraf
            // 
            this.TxtMasraf.Location = new System.Drawing.Point(126, 163);
            this.TxtMasraf.Name = "TxtMasraf";
            this.TxtMasraf.Size = new System.Drawing.Size(104, 25);
            this.TxtMasraf.TabIndex = 1;
            // 
            // TxtKdv
            // 
            this.TxtKdv.Location = new System.Drawing.Point(126, 194);
            this.TxtKdv.Name = "TxtKdv";
            this.TxtKdv.Size = new System.Drawing.Size(104, 25);
            this.TxtKdv.TabIndex = 2;
            // 
            // TxtKar
            // 
            this.TxtKar.Location = new System.Drawing.Point(126, 225);
            this.TxtKar.Name = "TxtKar";
            this.TxtKar.Size = new System.Drawing.Size(104, 25);
            this.TxtKar.TabIndex = 3;
            // 
            // lblmasraf
            // 
            this.lblmasraf.AutoSize = true;
            this.lblmasraf.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmasraf.Location = new System.Drawing.Point(18, 615);
            this.lblmasraf.Name = "lblmasraf";
            this.lblmasraf.Size = new System.Drawing.Size(14, 18);
            this.lblmasraf.TabIndex = 31;
            this.lblmasraf.Text = "-";
            // 
            // LblToplamKdv
            // 
            this.LblToplamKdv.AutoSize = true;
            this.LblToplamKdv.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamKdv.Location = new System.Drawing.Point(277, 586);
            this.LblToplamKdv.Name = "LblToplamKdv";
            this.LblToplamKdv.Size = new System.Drawing.Size(14, 18);
            this.LblToplamKdv.TabIndex = 32;
            this.LblToplamKdv.Text = "-";
            // 
            // LblToplamKar
            // 
            this.LblToplamKar.AutoSize = true;
            this.LblToplamKar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamKar.Location = new System.Drawing.Point(277, 615);
            this.LblToplamKar.Name = "LblToplamKar";
            this.LblToplamKar.Size = new System.Drawing.Size(14, 18);
            this.LblToplamKar.TabIndex = 33;
            this.LblToplamKar.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 584);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 34;
            this.label11.Text = "Başlangıç:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 615);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Bitiş:";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(253, 219);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(230, 31);
            this.BtnListele.TabIndex = 36;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aLINANDataGridViewTextBoxColumn,
            this.mASRAFDataGridViewTextBoxColumn,
            this.kDVTUTARDataGridViewTextBoxColumn,
            this.kARDataGridViewTextBoxColumn,
            this.nEREDENDataGridViewTextBoxColumn,
            this.nEREYEDataGridViewTextBoxColumn,
            this.tARİHDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNakliyeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 317);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 51;
            // 
            // aLINANDataGridViewTextBoxColumn
            // 
            this.aLINANDataGridViewTextBoxColumn.DataPropertyName = "ALINAN";
            this.aLINANDataGridViewTextBoxColumn.HeaderText = "ALINAN";
            this.aLINANDataGridViewTextBoxColumn.Name = "aLINANDataGridViewTextBoxColumn";
            this.aLINANDataGridViewTextBoxColumn.Width = 93;
            // 
            // mASRAFDataGridViewTextBoxColumn
            // 
            this.mASRAFDataGridViewTextBoxColumn.DataPropertyName = "MASRAF";
            this.mASRAFDataGridViewTextBoxColumn.HeaderText = "MASRAF";
            this.mASRAFDataGridViewTextBoxColumn.Name = "mASRAFDataGridViewTextBoxColumn";
            this.mASRAFDataGridViewTextBoxColumn.Width = 95;
            // 
            // kDVTUTARDataGridViewTextBoxColumn
            // 
            this.kDVTUTARDataGridViewTextBoxColumn.DataPropertyName = "KDVTUTAR";
            this.kDVTUTARDataGridViewTextBoxColumn.HeaderText = "KDVTUTAR";
            this.kDVTUTARDataGridViewTextBoxColumn.Name = "kDVTUTARDataGridViewTextBoxColumn";
            this.kDVTUTARDataGridViewTextBoxColumn.Width = 115;
            // 
            // kARDataGridViewTextBoxColumn
            // 
            this.kARDataGridViewTextBoxColumn.DataPropertyName = "KAR";
            this.kARDataGridViewTextBoxColumn.HeaderText = "KAR";
            this.kARDataGridViewTextBoxColumn.Name = "kARDataGridViewTextBoxColumn";
            this.kARDataGridViewTextBoxColumn.Width = 64;
            // 
            // nEREDENDataGridViewTextBoxColumn
            // 
            this.nEREDENDataGridViewTextBoxColumn.DataPropertyName = "NEREDEN";
            this.nEREDENDataGridViewTextBoxColumn.HeaderText = "NEREDEN";
            this.nEREDENDataGridViewTextBoxColumn.Name = "nEREDENDataGridViewTextBoxColumn";
            this.nEREDENDataGridViewTextBoxColumn.Width = 109;
            // 
            // nEREYEDataGridViewTextBoxColumn
            // 
            this.nEREYEDataGridViewTextBoxColumn.DataPropertyName = "NEREYE";
            this.nEREYEDataGridViewTextBoxColumn.HeaderText = "NEREYE";
            this.nEREYEDataGridViewTextBoxColumn.Name = "nEREYEDataGridViewTextBoxColumn";
            this.nEREYEDataGridViewTextBoxColumn.Width = 97;
            // 
            // tARİHDataGridViewTextBoxColumn
            // 
            this.tARİHDataGridViewTextBoxColumn.DataPropertyName = "TARİH";
            this.tARİHDataGridViewTextBoxColumn.HeaderText = "TARİH";
            this.tARİHDataGridViewTextBoxColumn.Name = "tARİHDataGridViewTextBoxColumn";
            this.tARİHDataGridViewTextBoxColumn.Width = 82;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            this.aCIKLAMADataGridViewTextBoxColumn.Width = 113;
            // 
            // tblNakliyeBindingSource
            // 
            this.tblNakliyeBindingSource.DataMember = "TblNakliye";
            this.tblNakliyeBindingSource.DataSource = this.nakliyeProjeDataSet;
            // 
            // nakliyeProjeDataSet
            // 
            this.nakliyeProjeDataSet.DataSetName = "NakliyeProjeDataSet";
            this.nakliyeProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNakliyeTableAdapter
            // 
            this.tblNakliyeTableAdapter.ClearBeforeFill = true;
            // 
            // nakliyeProjeDataSet1
            // 
            this.nakliyeProjeDataSet1.DataSetName = "NakliyeProjeDataSet1";
            this.nakliyeProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNakliyeBindingSource1
            // 
            this.tblNakliyeBindingSource1.DataMember = "TblNakliye";
            this.tblNakliyeBindingSource1.DataSource = this.nakliyeProjeDataSet1;
            // 
            // tblNakliyeTableAdapter1
            // 
            this.tblNakliyeTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(939, 642);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblToplamKar);
            this.Controls.Add(this.LblToplamKdv);
            this.Controls.Add(this.lblmasraf);
            this.Controls.Add(this.TxtKar);
            this.Controls.Add(this.TxtKdv);
            this.Controls.Add(this.TxtMasraf);
            this.Controls.Add(this.TxtAlinan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.TxtNereye);
            this.Controls.Add(this.TxtNereden);
            this.Controls.Add(this.LblGenelToplam);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnFiltrele);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nakliye Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNakliyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakliyeProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakliyeProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNakliyeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label LblGenelToplam;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.TextBox TxtNereye;
        private System.Windows.Forms.TextBox TxtNereden;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtAlinan;
        private System.Windows.Forms.TextBox TxtMasraf;
        private System.Windows.Forms.TextBox TxtKdv;
        private System.Windows.Forms.TextBox TxtKar;
        private System.Windows.Forms.Label lblmasraf;
        private System.Windows.Forms.Label LblToplamKdv;
        private System.Windows.Forms.Label LblToplamKar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NakliyeProjeDataSet nakliyeProjeDataSet;
        private System.Windows.Forms.BindingSource tblNakliyeBindingSource;
        private NakliyeProjeDataSetTableAdapters.TblNakliyeTableAdapter tblNakliyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLINANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASRAFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVTUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEREDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEREYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARİHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private NakliyeProjeDataSet1 nakliyeProjeDataSet1;
        private System.Windows.Forms.BindingSource tblNakliyeBindingSource1;
        private NakliyeProjeDataSet1TableAdapters.TblNakliyeTableAdapter tblNakliyeTableAdapter1;
    }
}

