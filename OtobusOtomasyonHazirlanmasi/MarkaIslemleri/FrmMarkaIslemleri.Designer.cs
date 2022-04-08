namespace OtobusOtomasyonHazirlanmasi.MarkaIslemleri
{
    partial class FrmMarkaIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarkaOtobusSayisi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAranacakMarka = new System.Windows.Forms.TextBox();
            this.grpSube = new System.Windows.Forms.GroupBox();
            this.rdrHayir = new System.Windows.Forms.RadioButton();
            this.rdrEvet = new System.Windows.Forms.RadioButton();
            this.grpYeniMarka = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYeniMarka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbOtobusler = new System.Windows.Forms.ComboBox();
            this.txtOtobusAdi = new System.Windows.Forms.TextBox();
            this.txtOtobusID = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.txtListenenKayitSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMarka = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMarka = new System.Windows.Forms.ListBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSube.SuspendLayout();
            this.grpYeniMarka.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grpSube);
            this.groupBox1.Controls.Add(this.txtListenenKayitSayisi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lsvMarka);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Listeleme ve Arama ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMarkaOtobusSayisi);
            this.groupBox3.Controls.Add(this.btnCikis);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAranacakMarka);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 46);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marka İşlemleri Yönetim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Markadaki Otobus Sayısı :";
            // 
            // txtMarkaOtobusSayisi
            // 
            this.txtMarkaOtobusSayisi.Location = new System.Drawing.Point(568, 13);
            this.txtMarkaOtobusSayisi.Name = "txtMarkaOtobusSayisi";
            this.txtMarkaOtobusSayisi.ReadOnly = true;
            this.txtMarkaOtobusSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaOtobusSayisi.TabIndex = 11;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.CikisIcon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.Location = new System.Drawing.Point(716, 10);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aranacak Marka Adi :";
            // 
            // txtAranacakMarka
            // 
            this.txtAranacakMarka.Location = new System.Drawing.Point(123, 17);
            this.txtAranacakMarka.Name = "txtAranacakMarka";
            this.txtAranacakMarka.Size = new System.Drawing.Size(100, 20);
            this.txtAranacakMarka.TabIndex = 3;
            this.txtAranacakMarka.TextChanged += new System.EventHandler(this.txtAranacakMarka_TextChanged);
            // 
            // grpSube
            // 
            this.grpSube.Controls.Add(this.lblMesaj);
            this.grpSube.Controls.Add(this.lstMarka);
            this.grpSube.Controls.Add(this.rdrHayir);
            this.grpSube.Controls.Add(this.rdrEvet);
            this.grpSube.Controls.Add(this.grpYeniMarka);
            this.grpSube.Controls.Add(this.label10);
            this.grpSube.Controls.Add(this.label9);
            this.grpSube.Controls.Add(this.groupBox4);
            this.grpSube.Controls.Add(this.cmbOtobusler);
            this.grpSube.Controls.Add(this.txtOtobusAdi);
            this.grpSube.Controls.Add(this.txtOtobusID);
            this.grpSube.Controls.Add(this.txtKoltukSayisi);
            this.grpSube.Controls.Add(this.label3);
            this.grpSube.Controls.Add(this.cmbMarka);
            this.grpSube.Controls.Add(this.label2);
            this.grpSube.Controls.Add(this.txtMarkaAdi);
            this.grpSube.Controls.Add(this.txtMarkaID);
            this.grpSube.ForeColor = System.Drawing.Color.Green;
            this.grpSube.Location = new System.Drawing.Point(407, 71);
            this.grpSube.Name = "grpSube";
            this.grpSube.Size = new System.Drawing.Size(403, 328);
            this.grpSube.TabIndex = 8;
            this.grpSube.TabStop = false;
            this.grpSube.Text = "Marka İnfo Işlemleri";
            // 
            // rdrHayir
            // 
            this.rdrHayir.AutoSize = true;
            this.rdrHayir.Location = new System.Drawing.Point(192, 155);
            this.rdrHayir.Name = "rdrHayir";
            this.rdrHayir.Size = new System.Drawing.Size(49, 17);
            this.rdrHayir.TabIndex = 31;
            this.rdrHayir.Text = "Hayır";
            this.rdrHayir.UseVisualStyleBackColor = true;
            // 
            // rdrEvet
            // 
            this.rdrEvet.AutoSize = true;
            this.rdrEvet.Checked = true;
            this.rdrEvet.Location = new System.Drawing.Point(128, 155);
            this.rdrEvet.Name = "rdrEvet";
            this.rdrEvet.Size = new System.Drawing.Size(47, 17);
            this.rdrEvet.TabIndex = 30;
            this.rdrEvet.TabStop = true;
            this.rdrEvet.Text = "Evet";
            this.rdrEvet.UseVisualStyleBackColor = true;
            // 
            // grpYeniMarka
            // 
            this.grpYeniMarka.Controls.Add(this.label6);
            this.grpYeniMarka.Controls.Add(this.txtYeniMarka);
            this.grpYeniMarka.ForeColor = System.Drawing.Color.Green;
            this.grpYeniMarka.Location = new System.Drawing.Point(9, 196);
            this.grpYeniMarka.Name = "grpYeniMarka";
            this.grpYeniMarka.Size = new System.Drawing.Size(382, 49);
            this.grpYeniMarka.TabIndex = 29;
            this.grpYeniMarka.TabStop = false;
            this.grpYeniMarka.Text = "Yeni Marka Ekle";
            this.grpYeniMarka.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Yeni Marka Ekle :";
            // 
            // txtYeniMarka
            // 
            this.txtYeniMarka.Location = new System.Drawing.Point(151, 20);
            this.txtYeniMarka.Name = "txtYeniMarka";
            this.txtYeniMarka.Size = new System.Drawing.Size(101, 20);
            this.txtYeniMarka.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Koltuk Sayısı  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Aktif Mi :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(6, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 67);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler İnfo :";
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Temizle;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.ForeColor = System.Drawing.Color.Green;
            this.btnYeni.Location = new System.Drawing.Point(7, 29);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 32);
            this.btnYeni.TabIndex = 16;
            this.btnYeni.Text = "Temizle";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.ForeColor = System.Drawing.Color.Green;
            this.btnSil.Location = new System.Drawing.Point(99, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 32);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Ekle;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEkle.ForeColor = System.Drawing.Color.Green;
            this.btnEkle.Location = new System.Drawing.Point(200, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 32);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Guncelle;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Green;
            this.btnGuncelle.Location = new System.Drawing.Point(300, 29);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbOtobusler
            // 
            this.cmbOtobusler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobusler.FormattingEnabled = true;
            this.cmbOtobusler.Location = new System.Drawing.Point(270, 61);
            this.cmbOtobusler.Name = "cmbOtobusler";
            this.cmbOtobusler.Size = new System.Drawing.Size(121, 21);
            this.cmbOtobusler.TabIndex = 7;
            this.cmbOtobusler.SelectedIndexChanged += new System.EventHandler(this.cmbOtobusler_SelectedIndexChanged);
            // 
            // txtOtobusAdi
            // 
            this.txtOtobusAdi.Location = new System.Drawing.Point(160, 62);
            this.txtOtobusAdi.Name = "txtOtobusAdi";
            this.txtOtobusAdi.ReadOnly = true;
            this.txtOtobusAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOtobusAdi.TabIndex = 6;
            // 
            // txtOtobusID
            // 
            this.txtOtobusID.Location = new System.Drawing.Point(128, 65);
            this.txtOtobusID.Name = "txtOtobusID";
            this.txtOtobusID.ReadOnly = true;
            this.txtOtobusID.Size = new System.Drawing.Size(17, 20);
            this.txtOtobusID.TabIndex = 5;
            this.txtOtobusID.Visible = false;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(160, 114);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.ReadOnly = true;
            this.txtKoltukSayisi.Size = new System.Drawing.Size(27, 20);
            this.txtKoltukSayisi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mevcut Otobusler :";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(270, 31);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 4;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka Adi :";
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(160, 31);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.ReadOnly = true;
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdi.TabIndex = 3;
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.Location = new System.Drawing.Point(128, 31);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.ReadOnly = true;
            this.txtMarkaID.Size = new System.Drawing.Size(17, 20);
            this.txtMarkaID.TabIndex = 2;
            this.txtMarkaID.Visible = false;
            // 
            // txtListenenKayitSayisi
            // 
            this.txtListenenKayitSayisi.Location = new System.Drawing.Point(141, 383);
            this.txtListenenKayitSayisi.Name = "txtListenenKayitSayisi";
            this.txtListenenKayitSayisi.ReadOnly = true;
            this.txtListenenKayitSayisi.Size = new System.Drawing.Size(52, 20);
            this.txtListenenKayitSayisi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Listelenen Kayıt Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka Detayını Görmek İçin Listeden Seçim Yapınız";
            // 
            // lsvMarka
            // 
            this.lsvMarka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvMarka.FullRowSelect = true;
            this.lsvMarka.GridLines = true;
            this.lsvMarka.Location = new System.Drawing.Point(6, 86);
            this.lsvMarka.Name = "lsvMarka";
            this.lsvMarka.Size = new System.Drawing.Size(385, 287);
            this.lsvMarka.TabIndex = 0;
            this.lsvMarka.UseCompatibleStateImageBehavior = false;
            this.lsvMarka.View = System.Windows.Forms.View.Details;
            this.lsvMarka.SelectedIndexChanged += new System.EventHandler(this.lsvMarka_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MarkaID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MarkaAdi";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Otobus PLaka";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Koltuk Sayısı";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OtobüsID";
            this.columnHeader5.Width = 1;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Aktif Mi";
            this.columnHeader6.Width = 69;
            // 
            // lstMarka
            // 
            this.lstMarka.FormattingEnabled = true;
            this.lstMarka.Location = new System.Drawing.Point(271, 101);
            this.lstMarka.Name = "lstMarka";
            this.lstMarka.Size = new System.Drawing.Size(120, 95);
            this.lstMarka.TabIndex = 32;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(268, 16);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(93, 13);
            this.lblMesaj.TabIndex = 33;
            this.lblMesaj.Text = "Mevcut Markalar :";
            this.lblMesaj.Visible = false;
            // 
            // FrmMarkaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 440);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarkaIslemleri";
            this.Text = "Marka Islemleri";
            this.Load += new System.EventHandler(this.FrmMarkaIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSube.ResumeLayout(false);
            this.grpSube.PerformLayout();
            this.grpYeniMarka.ResumeLayout(false);
            this.grpYeniMarka.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtListenenKayitSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAranacakMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvMarka;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarkaOtobusSayisi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox grpSube;
        private System.Windows.Forms.ComboBox cmbOtobusler;
        private System.Windows.Forms.TextBox txtOtobusAdi;
        private System.Windows.Forms.TextBox txtOtobusID;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox grpYeniMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYeniMarka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton rdrHayir;
        private System.Windows.Forms.RadioButton rdrEvet;
        private System.Windows.Forms.ListBox lstMarka;
        private System.Windows.Forms.Label lblMesaj;
    }
}