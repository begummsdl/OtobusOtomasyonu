using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.BiletIslemleri
{
    public partial class FrmBiletSatis : Form
    {
        public FrmBiletSatis()
        {
            
            InitializeComponent();
        }
        //Hangi Sefer Üzerinde İşlem Yapıldığının Bilgisini Tutar
        int seferID = 0;
        // Secilen Seferin Ücret Bilgisini Tutar
        decimal ucret = 0;
        // İşlem Yapılan Müsteri Bilgisini Tutar
        Entity.Musteri musteri;
        // Hangi Koltuk üzerinde İşlem Yapıldığının Bilgisini Tutar.Context Menu Kullanılırken Lazım Olacak
        int uzerindeislemYapilanKoltuk = 0;
        private void FrmBiletSatis_Load(object sender, EventArgs e)
        {
            
            this.Top = 70;
            this.Left = 20;
            Face.Sehir.SehirGetir(cmbKalkisSehri);
            Face.Sehir.SehirGetir(cmbVarisSehri);
        }

        private void cmbVarisSehri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sehir = (Entity.Sehir)cmbVarisSehri.SelectedItem;
            txtVarisSehirID.Text = Convert.ToString(sehir.SehirID);
            txtVarisSehirAdi.Text = Convert.ToString(cmbVarisSehri.SelectedItem);
        }

        private void cmbKalkisSehri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sehir = (Entity.Sehir)cmbKalkisSehri.SelectedItem;
            txtKalkisSehirID.Text = Convert.ToString(sehir.SehirID);
            txtKalkisSehirAdi.Text = Convert.ToString(cmbKalkisSehri.SelectedItem);
        }

        private void btnSeferGoster_Click(object sender, EventArgs e)
        {
            dgvSonuc.DataSource = null;
            DataTable dt = Face.Sefer.BileTSatiMevcutSeferler(Convert.ToInt32(Face.Kontrol.Temizle(txtKalkisSehirID.Text)), Convert.ToInt32(Face.Kontrol.Temizle(txtVarisSehirID.Text)), dtpZaman.Value);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Seçilen Bilgilere Ait Sefer Bulunamadı");
            }
            else
            {
                dgvSonuc.DataSource = dt;
            }
        }

        private void bcKoltukBilgiGuncelle_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Control cl in grpOturmaPlani.Controls)
            {
                if (cl is Button)
                {
                    cl.BackColor = Color.Empty;
                    cl.ForeColor = Color.Black;

                    foreach (DataRow dr in Face.Sefer.SefereGoreKoltukNumaralari(seferID).Rows)
                    {
                        if (cl.Text == dr["KoltukNo"].ToString())
                        {
                            if (Convert.ToBoolean(dr["SatisMiRezervasyonMu"]) == true)
                            {
                                cl.ForeColor = Color.Green;
                                cl.BackColor = Color.Green;
                            }
                            else
                            {
                                //Eger rezervasyon değilse false döner ve satıs
                                cl.ForeColor = Color.White;
                            }
                            //Yolcu cinsiyet False Bay için kullanıldı
                            if (Convert.ToBoolean(dr["YolcuCinsiyet"]) == true)
                            {
                                cl.BackColor = Color.DarkRed;
                            }
                            else
                            {
                                cl.BackColor = Color.DarkBlue;
                            }
                        }
                    }
                }
            }
        }

        private void tmrKoltukBilgiGuncelleyici_Tick(object sender, EventArgs e)
        {
            bcKoltukBilgiGuncelle.RunWorkerAsync();//asekron calısma
            CheckForIllegalCrossThreadCalls = false;
        }

        private void dgvSonuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpOturmaPlani.Controls.Clear();

            lblPlaka.Text = dgvSonuc.Rows[e.RowIndex].Cells["Plaka"].Value.ToString();
            lblSeferBilgi.Text = txtKalkisSehirAdi.Text + " - " + txtVarisSehirAdi.Text;

            int koltuksayisi = Convert.ToInt32(dgvSonuc.Rows[e.RowIndex].Cells["KoltukSayisi"].Value.ToString());
            ucret = Convert.ToDecimal(dgvSonuc.Rows[e.RowIndex].Cells["BiletTutari"].Value.ToString());
            seferID = Convert.ToInt32(dgvSonuc.Rows[e.RowIndex].Cells["SeferID"].Value.ToString());
            lblMarkaAdi.Text = Convert.ToString(dgvSonuc.Rows[e.RowIndex].Cells["MarkaAdi"].Value.ToString());

            txtMevcutPara.Text = ucret.ToString();
            int soldan = 15, yukaridan = 15;

            for (int i = 0; i < koltuksayisi; i++)
            {
                Button koltuk = new Button();
                koltuk.Text = (i + 1).ToString();

                koltuk.Height = 30;
                koltuk.Width = 40;

                koltuk.FlatStyle = FlatStyle.Flat;

                koltuk.Cursor = Cursors.Hand;
                koltuk.Click += new EventHandler(koltuk_Click);
                //koltuk.Click += new EventHandler(koltuk_Click);

                if (i % 4 == 0)
                {
                    soldan = 25;
                    yukaridan += 30;

                }
                else if (i % 2 == 0)
                {
                    soldan += 25;
                }

                koltuk.Top = yukaridan;
                koltuk.Left = soldan;

                koltuk.ContextMenuStrip = this.biletSolMenu;
                grpOturmaPlani.Controls.Add(koltuk);

                soldan += 35;
            }
            tmrKoltukBilgiGuncelleyici.Start();
        }

        void koltuk_Click(object sender, EventArgs e)
        {
            // tıklanan Butonu yakala
            Button tiklananKoltuk = (Button)sender;

            // hangi koltuk üzerinde işlem yapılıyor
            int.TryParse(tiklananKoltuk.Text, out uzerindeislemYapilanKoltuk);
            if (tiklananKoltuk.ForeColor == Color.White)
            {

                // daha önceden satılmıs bir koltuk
                RezervasyonIptalContext.Visible = false;
                SatisYapContext.Visible = false;
                satisIptalContext.Visible = true;
                tiklananKoltuk.ContextMenuStrip.Show(tiklananKoltuk, 10, 10);
            }
            else if ((tiklananKoltuk.BackColor == Color.DarkBlue || tiklananKoltuk.BackColor == Color.DarkRed) && tiklananKoltuk.ForeColor == Color.Black)
            {
                // daha önceden rezerve edilmiş bir koltuk
                RezervasyonIptalContext.Visible = true;
                SatisYapContext.Visible = true;
                satisIptalContext.Visible = false;
                tiklananKoltuk.ContextMenuStrip.Show(tiklananKoltuk, 10, 10);
            }
            else
            {
                txtKoltukNo.Text = tiklananKoltuk.Text;
            }
        }

        private void chckMevcutMusteri_CheckedChanged(object sender, EventArgs e)
        {
            //chckMevcutMusteri Secilmiş ise satış İşlemi yapılacak seçilmemiş ise satış işlemi yapılmaz müşterinin kartına 
            //Hediye Para Eklenmez
            txtKartNo.ReadOnly = !chckMevcutMusteri.Checked;
            txtKoltukNo.Focus();
        }

        private void txtKartNo_TextChanged(object sender, EventArgs e)
        {
            musteri = Face.Musteri.KartNumarasinaGoreBilgi(txtKartNo.Text);
            if (musteri != null)
            {
                if (chckAyniBilgi.Checked)
                {
                    txtMusteriID.Text = Convert.ToString(musteri.MusteriID);
                    txtAd.Text = musteri.Ad;
                    txtSoyadi.Text = musteri.SoyAd;
                    cmbCinsiyet.SelectedIndex = Convert.ToInt32(musteri.Cinsiyet);
                    txtMevcutPara.Text = Convert.ToString(musteri.MevcutPara);
                }
            }
            else
            {
                txtAd.Clear();
                txtSoyadi.Clear();
                txtMevcutPara.Clear();
            }
        }

        private void chckAyniBilgi_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAyniBilgi.Checked)
            {
                if (musteri != null)
                {
                    txtMusteriID.Text =Convert.ToString(musteri.MusteriID);
                    txtAd.Text = musteri.Ad;
                    txtSoyadi.Text = musteri.SoyAd;
                    cmbCinsiyet.SelectedIndex = Convert.ToInt32(musteri.Cinsiyet);
                    txtMevcutPara.Text = musteri.MevcutPara.ToString();
                }
            }
            else
            {
                txtAd.Text = "";
                txtSoyadi.Clear();
                txtMevcutPara.Clear();
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Entity.Bilet bilet = new Entity.Bilet();
            bilet.KoltukNo = Convert.ToByte(txtKoltukNo.Text);
            bilet.IslemZamani = DateTime.Now;
            bilet.SeferID = seferID;
            bilet.IslemYapanPersonelID = FrmMain.calisan.PersonelID;
            bilet.SatisMiRezervasyonMu = Convert.ToBoolean(cmbIslemTipi.SelectedIndex);
            bilet.SatisTip = Convert.ToBoolean(cmbSatisTipi.SelectedIndex);
            bilet.YolcuCinsiyet = Convert.ToBoolean(cmbCinsiyet.SelectedIndex);
            bilet.YolcuAd = txtAd.Text;
            bilet.YolcuSoyad = txtSoyadi.Text;
            bilet.Ucret = ucret;
            if (cmbSatisTipi.SelectedItem.ToString() == "Nakit")
            {
                txtMusteriID.Text = "9999999";
            }
            bilet.YolcuID = Convert.ToInt32(txtMusteriID.Text);
            if (txtAd.Text == "" || txtSoyadi.Text == "" || txtKoltukNo.Text == "" || cmbCinsiyet.SelectedItem == "" || cmbIslemTipi.SelectedItem == "")
            {
                MessageBox.Show("Eksik Bilgi.");
            }
            else
            {
                if (cmbIslemTipi.SelectedItem == "Rezervasyon")
                {
                    if (Face.Bilet.BiletEkle(bilet) > 0)
                    {
                        MessageBox.Show("Rezervasyon İşlemi Gerçekleşmiştir.");
                        tmrKoltukBilgiGuncelleyici.Start();
                        //cmbSatisTipi.Items.Add("Nakit");
                        //cmbSatisTipi.Items.Add("Kart");
                    }
                }
                else
                {
                    if (cmbSatisTipi.SelectedItem == "Nakit")
                    {
                        if (Face.Bilet.BiletEkle(bilet) > 0)
                        {
                            MessageBox.Show("Satış İşlemi Gerçekleşmiştir.");
                            tmrKoltukBilgiGuncelleyici.Start();
                        }
                    }
                    else
                    {
                        if (musteri.MevcutPara < ucret)
                        {
                            MessageBox.Show("Bakiyeniz Yetersiz");
                        }
                        else
                        {

                            bool sonuc = Face.Bilet.MusteriParaGuncelle(Convert.ToInt32(txtMusteriID.Text), ucret);
                            if (Face.Bilet.BiletEkle(bilet) > 0 || sonuc)
                            {
                                MessageBox.Show("Satışınız Gerçekleşmiştir.");
                                tmrKoltukBilgiGuncelleyici.Start();
                                musteri = Face.Musteri.KartNumarasinaGoreBilgi(txtKartNo.Text);
                                if (musteri != null)
                                {
                                    if (chckAyniBilgi.Checked)
                                    {
                                        txtMusteriID.Text = Convert.ToString(musteri.MusteriID);
                                        txtAd.Text = musteri.Ad;
                                        txtSoyadi.Text = musteri.SoyAd;
                                        cmbCinsiyet.SelectedIndex = Convert.ToInt32(musteri.Cinsiyet);
                                        txtMevcutPara.Text = Convert.ToString(musteri.MevcutPara);
                                    }
                                }
                                else
                                {
                                    txtAd.Clear();
                                    txtSoyadi.Clear();
                                    txtMevcutPara.Clear();
                                }


                            }
                            else
                            {
                                MessageBox.Show("Başarısız");
                            }
                        }
                    }
                }
            }
        }

        private void VazgecContext_Click(object sender, EventArgs e)
        {
            biletSolMenu.Hide();
        }

        private void satisIptalContext_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Bu Satişi iptal etmek istediğinizden eminmisiniz?", "Satiş İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                // Satiş İptal işlemi gercekleşiyor
                Entity.Bilet bilet = new Entity.Bilet();
                bilet.KoltukNo = Convert.ToByte(uzerindeislemYapilanKoltuk);
                bilet.SeferID = seferID;

                if (Face.Bilet.SatisIptal(bilet) > 0)
                {
                    MessageBox.Show("Bilet İptali Gerçekleşti", "Satiş İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void RezervasyonIptalContext_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Bu Rezervasyonu iptal etmek istediğinizden eminmisiniz?", "Rezervasyon İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                // Satiş İptal işlemi gercekleşiyor
                Entity.Bilet bilet = new Entity.Bilet();
                bilet.KoltukNo = Convert.ToByte(uzerindeislemYapilanKoltuk);
                bilet.SeferID = seferID;

                if (Face.Bilet.SatisIptal(bilet) > 0)
                {
                    MessageBox.Show("Bilet İptali Gerçekleşti", "Satiş İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void SatisYapContext_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Bu Rezervasyonu Satışa Çevirmek İstediğinizden Emin misiniz?", "Bilet Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtMusteriID.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri Bilgilerini Giriniz");
            }
            else
            {
                if (sonuc == DialogResult.Yes)
                {
                    musteri = new Entity.Musteri();
                    musteri.MusteriID = Convert.ToInt32(txtMusteriID.Text);
                    musteri.MevcutPara = Convert.ToDecimal(txtMevcutPara.Text);
                    if (musteri.MevcutPara < ucret)
                    {
                        MessageBox.Show("Bakiyeniz Yetersiz");
                    }
                    else
                    {
                        Entity.Bilet bilet = new Entity.Bilet();
                        bilet.KoltukNo = Convert.ToByte(uzerindeislemYapilanKoltuk);
                        bilet.SeferID = seferID;


                        if (txtMusteriID.Text == "")
                        {
                            MessageBox.Show("Müşteri Seçiniz.");
                        }
                        else
                        {
                            bilet.YolcuID = Convert.ToInt32(txtMusteriID.Text);
                            if (Face.Bilet.RezervasyonuSatisaCevir(bilet) > 0)
                            {

                                MessageBox.Show("Bilet Satışı Yapıldı", "Bilet Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Face.Bilet.MusteriParaGuncelle(Convert.ToInt32(txtMusteriID.Text), ucret);
                                Face.Bilet.MusteriParasınıYaz(txtMevcutPara);

                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon Satışa Çevrilemedi.");
                            }
                        }
                    }
                }
            }
           
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            FrmBiletKes frm = new FrmBiletKes(txtAd.Text);
            frm.Show();
        }

        private void dtpZaman_ValueChanged(object sender, EventArgs e)
        {
            
            txtTarih.Text = Convert.ToString(dtpZaman.Value.ToShortDateString());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMevcutPara_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
