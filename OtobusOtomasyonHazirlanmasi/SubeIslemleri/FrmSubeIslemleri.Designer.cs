namespace OtobusOtomasyonHazirlanmasi.SubeIslemleri
{
    partial class FrmSubeIslemleri
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
            this.txtListenenKayitSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArananSube = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvSube = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalisanSayisi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpSube = new System.Windows.Forms.GroupBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtEklenecekSube = new System.Windows.Forms.TextBox();
            this.cmbSubler = new System.Windows.Forms.ComboBox();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtSehirID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSube.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtListenenKayitSayisi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtArananSube);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lsvSube);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şube Listeleme ve Arama ";
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
            this.txtArananSube.Location = new System.Drawing.Point(129, 29);
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
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aranacak Şube Adi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şube Detayını Görmek İçin Listeden Seçim Yapınız";
            // 
            // lsvSube
            // 
            this.lsvSube.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvSube.FullRowSelect = true;
            this.lsvSube.GridLines = true;
            this.lsvSube.Location = new System.Drawing.Point(13, 84);
            this.lsvSube.Name = "lsvSube";
            this.lsvSube.Size = new System.Drawing.Size(296, 287);
            this.lsvSube.TabIndex = 0;
            this.lsvSube.UseCompatibleStateImageBehavior = false;
            this.lsvSube.View = System.Windows.Forms.View.Details;
            this.lsvSube.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvSube_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SubeID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SehirID";
            this.columnHeader2.Width = 1;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SubeAdi";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SehirAdi";
            this.columnHeader4.Width = 141;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(341, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 67);
            this.groupBox4.TabIndex = 21;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.grpSube);
            this.groupBox2.Controls.Add(this.cmbSubler);
            this.groupBox2.Controls.Add(this.txtSubeAdi);
            this.groupBox2.Controls.Add(this.txtSubeID);
            this.groupBox2.Controls.Add(this.cmbSehir);
            this.groupBox2.Controls.Add(this.txtSehirAdi);
            this.groupBox2.Controls.Add(this.txtSehirID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(348, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 325);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şube İşlemleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCalisanSayisi);
            this.groupBox3.Controls.Add(this.btnCikis);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(8, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 46);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şube İşlemleri Yönetim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Şubedeki Çalışan Sayısı :";
            // 
            // txtCalisanSayisi
            // 
            this.txtCalisanSayisi.Location = new System.Drawing.Point(134, 13);
            this.txtCalisanSayisi.Name = "txtCalisanSayisi";
            this.txtCalisanSayisi.ReadOnly = true;
            this.txtCalisanSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanSayisi.TabIndex = 11;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.CikisIcon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.Location = new System.Drawing.Point(282, 10);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // grpSube
            // 
            this.grpSube.Controls.Add(this.lblUyari);
            this.grpSube.Controls.Add(this.lblBilgi);
            this.grpSube.Controls.Add(this.txtEklenecekSube);
            this.grpSube.ForeColor = System.Drawing.Color.Green;
            this.grpSube.Location = new System.Drawing.Point(11, 192);
            this.grpSube.Name = "grpSube";
            this.grpSube.Size = new System.Drawing.Size(358, 100);
            this.grpSube.TabIndex = 8;
            this.grpSube.TabStop = false;
            this.grpSube.Text = "Şube İnfo Işlemleri";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUyari.Location = new System.Drawing.Point(10, 20);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 2;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(10, 56);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(0, 13);
            this.lblBilgi.TabIndex = 1;
            // 
            // txtEklenecekSube
            // 
            this.txtEklenecekSube.Location = new System.Drawing.Point(182, 49);
            this.txtEklenecekSube.Name = "txtEklenecekSube";
            this.txtEklenecekSube.Size = new System.Drawing.Size(151, 20);
            this.txtEklenecekSube.TabIndex = 0;
            // 
            // cmbSubler
            // 
            this.cmbSubler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubler.FormattingEnabled = true;
            this.cmbSubler.Location = new System.Drawing.Point(249, 141);
            this.cmbSubler.Name = "cmbSubler";
            this.cmbSubler.Size = new System.Drawing.Size(121, 21);
            this.cmbSubler.TabIndex = 7;
            this.cmbSubler.SelectedIndexChanged += new System.EventHandler(this.cmbSubler_SelectedIndexChanged);
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(139, 142);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.ReadOnly = true;
            this.txtSubeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSubeAdi.TabIndex = 6;
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(95, 141);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.ReadOnly = true;
            this.txtSubeID.Size = new System.Drawing.Size(17, 20);
            this.txtSubeID.TabIndex = 5;
            this.txtSubeID.Visible = false;
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(249, 106);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 21);
            this.cmbSehir.TabIndex = 4;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(139, 103);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.ReadOnly = true;
            this.txtSehirAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSehirAdi.TabIndex = 3;
            // 
            // txtSehirID
            // 
            this.txtSehirID.Location = new System.Drawing.Point(95, 103);
            this.txtSehirID.Name = "txtSehirID";
            this.txtSehirID.ReadOnly = true;
            this.txtSehirID.Size = new System.Drawing.Size(17, 20);
            this.txtSehirID.TabIndex = 2;
            this.txtSehirID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mevcut Şubeler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir Adi :";
            // 
            // FrmSubeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSubeIslemleri";
            this.Text = "Şube Islemleri";
            this.Load += new System.EventHandler(this.FrmSubeIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSube.ResumeLayout(false);
            this.grpSube.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvSube;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtListenenKayitSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArananSube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalisanSayisi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox grpSube;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtEklenecekSube;
        private System.Windows.Forms.ComboBox cmbSubler;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtSehirID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}