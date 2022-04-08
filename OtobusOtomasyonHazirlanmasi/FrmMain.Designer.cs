namespace OtobusOtomasyonHazirlanmasi
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBiletSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsYonetimAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPersonelIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOtobusIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMusteriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMasrafIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.otobusMasraflariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masrafTipTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanTipIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanEkleme = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSehir = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpIslemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.ımportExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihBazliRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferBazliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHakkimda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsIslemler,
            this.mnsYonetimAraclar,
            this.mnsRaporlar,
            this.mnsYardim,
            this.mnsCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsIslemler
            // 
            this.mnsIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBiletSatis});
            this.mnsIslemler.Image = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.IslemIcon;
            this.mnsIslemler.Name = "mnsIslemler";
            this.mnsIslemler.Size = new System.Drawing.Size(95, 24);
            this.mnsIslemler.Text = "Islemler";
            this.mnsIslemler.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // mnBiletSatis
            // 
            this.mnBiletSatis.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.ticket_icon;
            this.mnBiletSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnBiletSatis.Name = "mnBiletSatis";
            this.mnBiletSatis.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnBiletSatis.Size = new System.Drawing.Size(181, 26);
            this.mnBiletSatis.Text = "Bilet Satiş";
            this.mnBiletSatis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnBiletSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnBiletSatis.Click += new System.EventHandler(this.mnBiletSatis_Click);
            // 
            // mnsYonetimAraclar
            // 
            this.mnsYonetimAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSeferIslemleri,
            this.mnSubeIslemleri,
            this.mnPersonelIslemleri,
            this.mnOtobusIslemleri,
            this.mnMusteriIslemleri,
            this.mnMarkaIslemleri,
            this.mnMasrafIslemleri,
            this.mnCalisanIslemleri,
            this.mnSehir,
            this.backUpIslemiToolStripMenuItem,
            this.ımportExportToolStripMenuItem});
            this.mnsYonetimAraclar.Image = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Yonetimselaracicon;
            this.mnsYonetimAraclar.Name = "mnsYonetimAraclar";
            this.mnsYonetimAraclar.Size = new System.Drawing.Size(166, 24);
            this.mnsYonetimAraclar.Text = "Yönetimsel Araçlar";
            // 
            // mnSeferIslemleri
            // 
            this.mnSeferIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Sefericon;
            this.mnSeferIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnSeferIslemleri.Name = "mnSeferIslemleri";
            this.mnSeferIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnSeferIslemleri.Text = "Sefer Islemleri";
            this.mnSeferIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnSeferIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSeferIslemleri.Click += new System.EventHandler(this.mnSeferIslemleri_Click);
            // 
            // mnSubeIslemleri
            // 
            this.mnSubeIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Subeicon;
            this.mnSubeIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnSubeIslemleri.Name = "mnSubeIslemleri";
            this.mnSubeIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnSubeIslemleri.Text = "Şube Islemleri";
            this.mnSubeIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnSubeIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSubeIslemleri.Click += new System.EventHandler(this.mnSubeIslemleri_Click);
            // 
            // mnPersonelIslemleri
            // 
            this.mnPersonelIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.PersonelIcon;
            this.mnPersonelIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnPersonelIslemleri.Name = "mnPersonelIslemleri";
            this.mnPersonelIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnPersonelIslemleri.Text = "Personel Islemleri";
            this.mnPersonelIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnPersonelIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnOtobusIslemleri
            // 
            this.mnOtobusIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.OtobusIcon;
            this.mnOtobusIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnOtobusIslemleri.Name = "mnOtobusIslemleri";
            this.mnOtobusIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnOtobusIslemleri.Text = "Otobus Islemleri";
            this.mnOtobusIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnOtobusIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnOtobusIslemleri.Click += new System.EventHandler(this.mnOtobusIslemleri_Click);
            // 
            // mnMusteriIslemleri
            // 
            this.mnMusteriIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.MusteriIcon;
            this.mnMusteriIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnMusteriIslemleri.Name = "mnMusteriIslemleri";
            this.mnMusteriIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnMusteriIslemleri.Text = "Musteri Islmeleri";
            this.mnMusteriIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnMusteriIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnMusteriIslemleri.Click += new System.EventHandler(this.mnMusteriIslemleri_Click);
            // 
            // mnMarkaIslemleri
            // 
            this.mnMarkaIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.MarkaIcon;
            this.mnMarkaIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnMarkaIslemleri.Name = "mnMarkaIslemleri";
            this.mnMarkaIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnMarkaIslemleri.Text = "Marka Islemleri";
            this.mnMarkaIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnMarkaIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnMarkaIslemleri.Click += new System.EventHandler(this.mnMarkaIslemleri_Click);
            // 
            // mnMasrafIslemleri
            // 
            this.mnMasrafIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.MasrafIcon;
            this.mnMasrafIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnMasrafIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otobusMasraflariToolStripMenuItem,
            this.masrafTipTanımlamalarıToolStripMenuItem});
            this.mnMasrafIslemleri.Name = "mnMasrafIslemleri";
            this.mnMasrafIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnMasrafIslemleri.Text = "Masraf Islemleri";
            this.mnMasrafIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnMasrafIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // otobusMasraflariToolStripMenuItem
            // 
            this.otobusMasraflariToolStripMenuItem.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.otobusmasraf;
            this.otobusMasraflariToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.otobusMasraflariToolStripMenuItem.Name = "otobusMasraflariToolStripMenuItem";
            this.otobusMasraflariToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.otobusMasraflariToolStripMenuItem.Text = "OtobusMasrafları";
            this.otobusMasraflariToolStripMenuItem.Click += new System.EventHandler(this.otobusMasraflariToolStripMenuItem_Click);
            // 
            // masrafTipTanımlamalarıToolStripMenuItem
            // 
            this.masrafTipTanımlamalarıToolStripMenuItem.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.MasraftipTanımlama;
            this.masrafTipTanımlamalarıToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.masrafTipTanımlamalarıToolStripMenuItem.Name = "masrafTipTanımlamalarıToolStripMenuItem";
            this.masrafTipTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.masrafTipTanımlamalarıToolStripMenuItem.Text = "MasrafTipTanımlamaları";
            this.masrafTipTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.masrafTipTanımlamalarıToolStripMenuItem_Click);
            // 
            // mnCalisanIslemleri
            // 
            this.mnCalisanIslemleri.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.CalisanIcon;
            this.mnCalisanIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnCalisanIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCalisanTipIslem,
            this.mnCalisanEkleme});
            this.mnCalisanIslemleri.Name = "mnCalisanIslemleri";
            this.mnCalisanIslemleri.Size = new System.Drawing.Size(283, 26);
            this.mnCalisanIslemleri.Text = "Calisan Islemleri";
            this.mnCalisanIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnCalisanIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnCalisanIslemleri.Click += new System.EventHandler(this.mnCalisanIslemleri_Click);
            // 
            // mnCalisanTipIslem
            // 
            this.mnCalisanTipIslem.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.AnaListe1;
            this.mnCalisanTipIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnCalisanTipIslem.Name = "mnCalisanTipIslem";
            this.mnCalisanTipIslem.Size = new System.Drawing.Size(234, 26);
            this.mnCalisanTipIslem.Text = "CalisanTipIslemleri";
            this.mnCalisanTipIslem.Click += new System.EventHandler(this.mnCalisanTipIslem_Click);
            // 
            // mnCalisanEkleme
            // 
            this.mnCalisanEkleme.Name = "mnCalisanEkleme";
            this.mnCalisanEkleme.Size = new System.Drawing.Size(234, 26);
            this.mnCalisanEkleme.Text = "Calışan Ekleme İşlemi";
            this.mnCalisanEkleme.Click += new System.EventHandler(this.mnCalisanEkleme_Click);
            // 
            // mnSehir
            // 
            this.mnSehir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnSehir.Name = "mnSehir";
            this.mnSehir.Size = new System.Drawing.Size(283, 26);
            this.mnSehir.Text = "Sehir Islemleri";
            this.mnSehir.Click += new System.EventHandler(this.sehirIslemleriToolStripMenuItem_Click);
            // 
            // backUpIslemiToolStripMenuItem
            // 
            this.backUpIslemiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackup,
            this.btnRestore});
            this.backUpIslemiToolStripMenuItem.Name = "backUpIslemiToolStripMenuItem";
            this.backUpIslemiToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.backUpIslemiToolStripMenuItem.Text = "Yedekleme/Yedekten Dönme";
            // 
            // btnBackup
            // 
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(184, 26);
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(184, 26);
            this.btnRestore.Text = "Yedekten Dön";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ımportExportToolStripMenuItem
            // 
            this.ımportExportToolStripMenuItem.Name = "ımportExportToolStripMenuItem";
            this.ımportExportToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.ımportExportToolStripMenuItem.Text = "Import/Export";
            this.ımportExportToolStripMenuItem.Click += new System.EventHandler(this.ımportExportToolStripMenuItem_Click);
            // 
            // mnsRaporlar
            // 
            this.mnsRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihBazliRaporToolStripMenuItem,
            this.seferBazliToolStripMenuItem});
            this.mnsRaporlar.Image = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.RaporSefer1;
            this.mnsRaporlar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnsRaporlar.Name = "mnsRaporlar";
            this.mnsRaporlar.Size = new System.Drawing.Size(100, 24);
            this.mnsRaporlar.Text = "Raporlar";
            this.mnsRaporlar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tarihBazliRaporToolStripMenuItem
            // 
            this.tarihBazliRaporToolStripMenuItem.Name = "tarihBazliRaporToolStripMenuItem";
            this.tarihBazliRaporToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.tarihBazliRaporToolStripMenuItem.Text = "Tarih Bazli Rapor";
            this.tarihBazliRaporToolStripMenuItem.Click += new System.EventHandler(this.tarihBazliRaporToolStripMenuItem_Click);
            // 
            // seferBazliToolStripMenuItem
            // 
            this.seferBazliToolStripMenuItem.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.RaporSefer;
            this.seferBazliToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seferBazliToolStripMenuItem.Name = "seferBazliToolStripMenuItem";
            this.seferBazliToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.seferBazliToolStripMenuItem.Text = "Sefer Bazli";
            this.seferBazliToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.seferBazliToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.seferBazliToolStripMenuItem.Click += new System.EventHandler(this.seferBazliToolStripMenuItem_Click);
            // 
            // mnsYardim
            // 
            this.mnsYardim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHakkimda});
            this.mnsYardim.Image = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.help_icon;
            this.mnsYardim.Name = "mnsYardim";
            this.mnsYardim.Size = new System.Drawing.Size(89, 24);
            this.mnsYardim.Text = "Yardım";
            // 
            // mnHakkimda
            // 
            this.mnHakkimda.Name = "mnHakkimda";
            this.mnHakkimda.Size = new System.Drawing.Size(159, 26);
            this.mnHakkimda.Text = "Hakkımda";
            // 
            // mnsCikis
            // 
            this.mnsCikis.Image = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.CikisIcon;
            this.mnsCikis.Name = "mnsCikis";
            this.mnsCikis.Size = new System.Drawing.Size(73, 24);
            this.mnsCikis.Text = "Çıkış";
            this.mnsCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnsCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.mnsCikis.Click += new System.EventHandler(this.mnsCikis_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.Bus_up_to_55_pax_;
            this.ClientSize = new System.Drawing.Size(991, 640);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Ana Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsIslemler;
        private System.Windows.Forms.ToolStripMenuItem mnBiletSatis;
        private System.Windows.Forms.ToolStripMenuItem mnsYonetimAraclar;
        private System.Windows.Forms.ToolStripMenuItem mnsRaporlar;
        private System.Windows.Forms.ToolStripMenuItem mnsYardim;
        private System.Windows.Forms.ToolStripMenuItem mnsCikis;
        private System.Windows.Forms.ToolStripMenuItem mnSeferIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnSubeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnPersonelIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnOtobusIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMusteriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMasrafIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tarihBazliRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferBazliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnHakkimda;
        private System.Windows.Forms.ToolStripMenuItem mnSehir;
        private System.Windows.Forms.ToolStripMenuItem otobusMasraflariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masrafTipTanımlamalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanTipIslem;
        private System.Windows.Forms.ToolStripMenuItem backUpIslemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBackup;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanEkleme;
        private System.Windows.Forms.ToolStripMenuItem ımportExportToolStripMenuItem;
    }
}