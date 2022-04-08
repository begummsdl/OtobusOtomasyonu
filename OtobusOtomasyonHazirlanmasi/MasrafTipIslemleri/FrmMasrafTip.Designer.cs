namespace OtobusOtomasyonHazirlanmasi.MasrafTipIslemleri
{
    partial class FrmMasrafTip
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtListenenKayitSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArananSube = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMasrafTip = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOtobusMasraf = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbMasrafTip = new System.Windows.Forms.ComboBox();
            this.txtMasrafTipAdi = new System.Windows.Forms.TextBox();
            this.txtMasrafTipID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.txtListenenKayitSayisi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtArananSube);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lsvMasrafTip);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Tipleri Listeleme ve Arama ";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.Location = new System.Drawing.Point(234, 377);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtListenenKayitSayisi
            // 
            this.txtListenenKayitSayisi.Location = new System.Drawing.Point(148, 382);
            this.txtListenenKayitSayisi.Name = "txtListenenKayitSayisi";
            this.txtListenenKayitSayisi.ReadOnly = true;
            this.txtListenenKayitSayisi.Size = new System.Drawing.Size(52, 20);
            this.txtListenenKayitSayisi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Listelenen Kayıt Sayısı :";
            // 
            // txtArananSube
            // 
            this.txtArananSube.Location = new System.Drawing.Point(149, 25);
            this.txtArananSube.Name = "txtArananSube";
            this.txtArananSube.Size = new System.Drawing.Size(100, 20);
            this.txtArananSube.TabIndex = 3;
            this.txtArananSube.TextChanged += new System.EventHandler(this.txtArananSube_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aranacak MasrafTip Adi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masraf TipAdi Detayını Görmek İçin Listeden Seçim Yapınız";
            // 
            // lsvMasrafTip
            // 
            this.lsvMasrafTip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lsvMasrafTip.FullRowSelect = true;
            this.lsvMasrafTip.GridLines = true;
            this.lsvMasrafTip.Location = new System.Drawing.Point(13, 84);
            this.lsvMasrafTip.Name = "lsvMasrafTip";
            this.lsvMasrafTip.Size = new System.Drawing.Size(296, 287);
            this.lsvMasrafTip.TabIndex = 0;
            this.lsvMasrafTip.UseCompatibleStateImageBehavior = false;
            this.lsvMasrafTip.View = System.Windows.Forms.View.Details;
            this.lsvMasrafTip.SelectedIndexChanged += new System.EventHandler(this.lsvMasrafTip_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MasrafTipID";
            this.columnHeader5.Width = 1;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Masraf Tip Adi";
            this.columnHeader6.Width = 287;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOtobusMasraf);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cmbMasrafTip);
            this.groupBox2.Controls.Add(this.txtMasrafTipAdi);
            this.groupBox2.Controls.Add(this.txtMasrafTipID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(341, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 408);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şube İşlemleri";
            // 
            // btnOtobusMasraf
            // 
            this.btnOtobusMasraf.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.otobusmasraf;
            this.btnOtobusMasraf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOtobusMasraf.ForeColor = System.Drawing.Color.Green;
            this.btnOtobusMasraf.Location = new System.Drawing.Point(268, 363);
            this.btnOtobusMasraf.Name = "btnOtobusMasraf";
            this.btnOtobusMasraf.Size = new System.Drawing.Size(135, 35);
            this.btnOtobusMasraf.TabIndex = 25;
            this.btnOtobusMasraf.Text = "Otobus Masraflari Gör";
            this.btnOtobusMasraf.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOtobusMasraf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtobusMasraf.UseVisualStyleBackColor = true;
            this.btnOtobusMasraf.Click += new System.EventHandler(this.btnOtobusMasraf_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(10, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 82);
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
            // cmbMasrafTip
            // 
            this.cmbMasrafTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasrafTip.FormattingEnabled = true;
            this.cmbMasrafTip.Location = new System.Drawing.Point(258, 25);
            this.cmbMasrafTip.Name = "cmbMasrafTip";
            this.cmbMasrafTip.Size = new System.Drawing.Size(121, 21);
            this.cmbMasrafTip.TabIndex = 7;
            this.cmbMasrafTip.SelectedIndexChanged += new System.EventHandler(this.cmbMasrafTip_SelectedIndexChanged);
            // 
            // txtMasrafTipAdi
            // 
            this.txtMasrafTipAdi.Location = new System.Drawing.Point(148, 26);
            this.txtMasrafTipAdi.Name = "txtMasrafTipAdi";
            this.txtMasrafTipAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMasrafTipAdi.TabIndex = 6;
            // 
            // txtMasrafTipID
            // 
            this.txtMasrafTipID.Location = new System.Drawing.Point(104, 25);
            this.txtMasrafTipID.Name = "txtMasrafTipID";
            this.txtMasrafTipID.ReadOnly = true;
            this.txtMasrafTipID.Size = new System.Drawing.Size(17, 20);
            this.txtMasrafTipID.TabIndex = 5;
            this.txtMasrafTipID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Masraf Tip Adi :";
            // 
            // FrmMasrafTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMasrafTip";
            this.Text = "Masraf Tip İşlemleri";
            this.Load += new System.EventHandler(this.FrmMasrafTip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtListenenKayitSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArananSube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvMasrafTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbMasrafTip;
        private System.Windows.Forms.TextBox txtMasrafTipAdi;
        private System.Windows.Forms.TextBox txtMasrafTipID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnOtobusMasraf;
    }
}