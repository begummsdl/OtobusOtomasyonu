using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.MusteriIslemleri
{
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            label17.Text = Convert.ToString(Face.Musteri.MüsteriSayisi());
            Face.Musteri.MüsterileriGetir(lsvMusteriler);
            Face.Sehir.sehirListele(cmbSehir);
        }

        private void lsvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMusteriler.SelectedItems.Count > 0)
            {
                txtMüsteriID.Text = lsvMusteriler.SelectedItems[0].SubItems[0].Text;
                txtAd.Text = lsvMusteriler.SelectedItems[0].SubItems[1].Text;
                txtSoyad.Text = lsvMusteriler.SelectedItems[0].SubItems[2].Text;
                txtEmail.Text = lsvMusteriler.SelectedItems[0].SubItems[3].Text;
                txtTelefon.Text = lsvMusteriler.SelectedItems[0].SubItems[4].Text;
                txtCinsiyet.Text = lsvMusteriler.SelectedItems[0].SubItems[5].Text;
                txtDogumTarihi.Text = lsvMusteriler.SelectedItems[0].SubItems[6].Text;
                txtSehirID.Text = lsvMusteriler.SelectedItems[0].SubItems[7].Text;
                txtSehir.Text = lsvMusteriler.SelectedItems[0].SubItems[8].Text;
                txtAdres.Text = lsvMusteriler.SelectedItems[0].SubItems[9].Text;
                txtkartNumarasi.Text = lsvMusteriler.SelectedItems[0].SubItems[10].Text;
                if (lsvMusteriler.SelectedItems[0].SubItems[11].Text == "Teslim Edildi")
                {
                    rbEdildi.Checked = true;

                }
                else
                {
                    rbEdilmedi.Checked = false;
                }
                txtMevcutPara.Text = lsvMusteriler.SelectedItems[0].SubItems[12].Text;

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSehir_MouseHover(object sender, EventArgs e)
        {
            cmbSehir.Width = 80;
        }

        private void cmbSehir_MouseLeave(object sender, EventArgs e)
        {
            cmbSehir.Width = 27;
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sehir = (Entity.Sehir)cmbSehir.SelectedItem;
            txtSehir.Text = sehir.SehirAdi;
            txtSehirID.Text = Convert.ToString(sehir.SehirID);
            cmbSehir.Width = 27;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnEkle.Enabled = true;
            lsvMusteriler.FullRowSelect = false;
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMüsteriID.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";
            txtDogumTarihi.Text = "";
            txtSehir.Text = "";
            txtSehirID.Text = "";
            txtkartNumarasi.Text = "";
            txtMevcutPara.Text = "";
            rbEdildi.Checked = true;
            rbEdilmedi.Checked = false;
            txtCinsiyet.Text = "";
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCinsiyet.Text = Convert.ToString(cmbCinsiyet.SelectedItem);
            cmbCinsiyet.Width = 27;
        }

        private void cmbCinsiyet_MouseHover(object sender, EventArgs e)
        {
            cmbCinsiyet.Width = 80;
        }

        private void cmbCinsiyet_MouseLeave(object sender, EventArgs e)
        {
            cmbCinsiyet.Width = 27;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtTelefon.Text == "" || txtAdres.Text == "" || txtCinsiyet.Text == "" || txtDogumTarihi.Text == "" || txtSehir.Text == "" || txtkartNumarasi.Text == "" || txtMevcutPara.Text == "")
            {
                MessageBox.Show("Eksik Bilgi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvMusteriler.FullRowSelect = true;

            }
            else
            {
                bool sonuc = Face.Musteri.MusteriVarMi(txtAd.Text, txtSoyad.Text);
                if (sonuc)
                {
                    MessageBox.Show("Kayıt Zaten Mevcut", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    btnEkle.Enabled = false;
                    btnYeni.Enabled = true;
                    lsvMusteriler.FullRowSelect = true;

                }
                else
                {
                    Entity.Musteri müsteri = new Entity.Musteri();
                    müsteri.Ad = txtAd.Text;
                    müsteri.SoyAd = txtSoyad.Text;
                    müsteri.Email = txtEmail.Text;
                    müsteri.Telefon = txtTelefon.Text;
                    if (txtCinsiyet.Text == "Bay")
                    {
                        müsteri.Cinsiyet = false;
                    }
                    else
                    {
                        müsteri.Cinsiyet = true;

                    }
                    müsteri.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
                    müsteri.SehirID = Convert.ToInt32(txtSehirID.Text);
                    müsteri.Adres = txtAdres.Text;
                    müsteri.KartNumarasi = txtkartNumarasi.Text;
                    if (rbEdildi.Checked == true)
                    {
                        müsteri.KartTeslimDurumu = true;
                    }
                    else
                    {
                        müsteri.KartTeslimDurumu = false;
                    }
                    müsteri.MevcutPara = Convert.ToDecimal(txtMevcutPara.Text);
                    if (Face.Musteri.MusteriEkle(müsteri) > 0)
                    {
                        MessageBox.Show("Müşteri Bilgileri Eklendi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnYeni.Enabled = true;
                        lsvMusteriler.FullRowSelect = true;
                        Face.Musteri.MüsterileriGetir(lsvMusteriler);
                        label17.Text = Convert.ToString(Face.Musteri.MüsteriSayisi());
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Bilgileri Eklenemedi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnYeni.Enabled = true;
                        lsvMusteriler.FullRowSelect = true;

                    }
                }

            }
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            txtkartNumarasi.Text = "";
            bool sonuc = Face.Musteri.KartNumarasiVarMi(txtkartNumarasi.Text);
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    int sayi = rnd.Next(0, 10);
                    txtkartNumarasi.Text += sayi;
                }

            } while (sonuc);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GrpAra.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtMüsteriID.Text == "")
            {
                MessageBox.Show("Silinecek Müşteri Seçiniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Silmek İstiyor Musunuz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Musteri musteri = new Entity.Musteri();
                    musteri.MusteriID = Convert.ToInt32(txtMüsteriID.Text);
                    if (Face.Musteri.MusteriSil(musteri) > 0)
                    {
                        MessageBox.Show("Müşteri Silindi.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        Face.Musteri.MüsterileriGetir(lsvMusteriler);
                        label17.Text = Convert.ToString(Face.Musteri.MüsteriSayisi());
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Silinemedi.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtTelefon.Text == "" || txtAdres.Text == "" || txtCinsiyet.Text == "" || txtDogumTarihi.Text == "" || txtSehir.Text == "" || txtkartNumarasi.Text == "" || txtMevcutPara.Text == "")
            {
                MessageBox.Show("Eksik Bilgi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {



                Entity.Musteri müsteri = new Entity.Musteri();
                müsteri.MusteriID = Convert.ToInt32(txtMüsteriID.Text);
                müsteri.Ad = txtAd.Text;
                müsteri.SoyAd = txtSoyad.Text;
                müsteri.Email = txtEmail.Text;
                müsteri.Telefon = txtTelefon.Text;
                if (txtCinsiyet.Text == "Bay")
                {
                    müsteri.Cinsiyet = false;
                }
                else
                {
                    müsteri.Cinsiyet = true;

                }
                müsteri.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
                müsteri.SehirID = Convert.ToInt32(txtSehirID.Text);
                müsteri.Adres = txtAdres.Text;
                müsteri.KartNumarasi = txtkartNumarasi.Text;
                if (rbEdildi.Checked == true)
                {
                    müsteri.KartTeslimDurumu = true;
                }
                else
                {
                    müsteri.KartTeslimDurumu = false;
                }
                müsteri.MevcutPara = Convert.ToDecimal(txtMevcutPara.Text);
                if (Face.Musteri.MusteriGuncelle(müsteri) > 0)
                {
                    MessageBox.Show("Müşteri Bilgileri Güncellendi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Face.Musteri.MüsterileriGetir(lsvMusteriler);
                }
                else
                {
                    MessageBox.Show("Müşteri Bilgileri Güncellenemedi", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }

            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            GrpAra.Visible = false;
        }

        private void txtIsmeGore_TextChanged(object sender, EventArgs e)
        {
            Face.Musteri.AdaGoreMusteriAra(lsvMusteriler, txtIsmeGore.Text);
        }

        private void txtEmaileGore_TextChanged(object sender, EventArgs e)
        {
            Face.Musteri.EmaileGoreMusteriAra(lsvMusteriler, txtEmaileGore.Text);
        }

        private void txtUnvanaGore_TextChanged(object sender, EventArgs e)
        {
            Face.Musteri.TelefonaGoreMusteriAra(lsvMusteriler, txtUnvanaGore.Text);
        }

        private void txtKartNumarasınaGore_TextChanged(object sender, EventArgs e)
        {
            Face.Musteri.KartNumarasınaGoreMusteriAra(lsvMusteriler, txtKartNumarasınaGore.Text);
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtDogumTarihi.Text = Convert.ToString(dtpDogumTarihi.Value);
        }
    }
}
