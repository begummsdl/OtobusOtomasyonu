using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.CalisanIslemleri
{
    public partial class FrmYeniCalisan : Form
    {
        public FrmYeniCalisan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            FrmGiris frm = new FrmGiris();
            FrmGiris.ActiveForm.AddOwnedForm(frm);
            this.Close();
        }

        private void FrmYeniCalisan_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 100;
            Face.Calisan.CalisanListesi(lsvCalisan);
            Face.Sube.Subelistele(cmbSubeAdi);
            Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
            txtCalisanSayisi.Text = Convert.ToString(Face.Calisan.CalisanSayisi());
        }

        private void cmbSubeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sube sube = (Entity.Sube)cmbSubeAdi.SelectedItem;
            txtSubeID.Text = Convert.ToString(sube.SubeID);
            txtSubeAdi.Text = sube.SubeAdi;
        }

        private void cmbCalisanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.CalisanTip clt = (Entity.CalisanTip)cmbCalisanTip.SelectedItem;
            txtCalisanTipID.Text = Convert.ToString(clt.CalisanTipID);
            txtCalisanTipAdi.Text = Convert.ToString(clt.CalisanTipAdi);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtPersonelID.Text = "";
            txtCalisanAdi.Text = "";
            txtCalisanSoyad.Clear();
            txtCalisanTipAdi.Clear();
            txtCalisanTipID.Clear();
            txtEmail.Clear();
            txtEvAdresi.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Text = "";
            txtSubeAdi.Clear();
            txtSubeID.Clear();
            txtTelefon.Clear();
            txtCalisanAdi.Focus();
            txtSifre.ReadOnly = true;
            lsvCalisan.FullRowSelect = false; //yeniden seçim için
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtCalisanAdi.Text == "" || txtCalisanSoyad.Text == "" || txtCalisanTipAdi.Text == "" || txtCalisanTipID.Text == "" || txtEmail.Text == "" || txtEvAdresi.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtSubeAdi.Text == "" || txtSubeID.Text == "" || txtTelefon.Text == "" || (rdbYonetici.Checked == false && rdbCalisan.Checked == false))
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvCalisan.FullRowSelect = true;
            }
            else if (txtKullaniciAdi.Text.ToLower() == "admin" )
            {
                MessageBox.Show("Kullanıcı adı admin olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvCalisan.FullRowSelect = true;
            }
            else
            {
                bool sonuc = Face.Calisan.CalisanVarmi(Face.Kontrol.Temizle(txtCalisanAdi.Text), Face.Kontrol.Temizle(txtCalisanSoyad.Text));
                if (sonuc)
                {
                    MessageBox.Show("Bu Çalışan Sistemde Bulunmaktadır Uyarı!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lsvCalisan.FullRowSelect = true;
                }
                else
                {
                    Entity.Calisan cl = new Entity.Calisan();
                    cl.Ad = Face.Kontrol.Temizle(txtCalisanAdi.Text);
                    cl.Soyad = Face.Kontrol.Temizle(txtCalisanSoyad.Text);
                    cl.Email = Face.Kontrol.Temizle(txtEmail.Text);
                    cl.Telefon = Face.Kontrol.Temizle(txtTelefon.Text);
                    cl.SubeID = Convert.ToInt32(Face.Kontrol.Temizle(txtSubeID.Text));
                    cl.KullaniciAdi = Face.Kontrol.Temizle(txtKullaniciAdi.Text);
                    cl.EvAdresi = Face.Kontrol.Temizle(txtEvAdresi.Text);
                    cl.CalisaTipID = Convert.ToInt32(Face.Kontrol.Temizle(txtCalisanTipID.Text));
                    if (rdbYonetici.Checked)
                    {
                        cl.Yoneticimi = true;
                    }
                    else if (rdbCalisan.Checked)
                    {
                        cl.Yoneticimi = false;
                    }
                    cl.Sifre = Face.Kontrol.Temizle(txtSifre.Text);
                    if (Face.Calisan.CalisanEkle(cl) > 0)
                    {
                        MessageBox.Show("Calisan Başarı ile Eklendi");
                        Face.Calisan.CalisanListesi(lsvCalisan);
                        Face.Sube.Subelistele(cmbSubeAdi);
                        Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
                        lsvCalisan.FullRowSelect = true;

                    }

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text == "")
            {
                MessageBox.Show("Lütfen Silinecek Çalışanı Listeden Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "Uyarı silenen data geri alanamaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Calisan silinecekcalisan = new Entity.Calisan();
                    silinecekcalisan.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    if (Face.Calisan.CalisanSil(silinecekcalisan) > 0)
                    {
                        MessageBox.Show("kayıt Silindi");
                        Temizle();
                        Face.Calisan.CalisanListesi(lsvCalisan);
                        txtCalisanSayisi.Text = Convert.ToString(Face.Calisan.CalisanSayisi());
                    }
                }
                else
                    MessageBox.Show("Silme İşlemi İptal Edildi");
            }
        }

        private void lsvCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsvCalisan.SelectedItems.Count > 0)
            {
                txtPersonelID.Text = lsvCalisan.SelectedItems[0].SubItems[0].Text;
                txtCalisanAdi.Text = lsvCalisan.SelectedItems[0].SubItems[1].Text;
                txtCalisanSoyad.Text = lsvCalisan.SelectedItems[0].SubItems[2].Text;
                txtEmail.Text = lsvCalisan.SelectedItems[0].SubItems[3].Text;
                txtTelefon.Text = lsvCalisan.SelectedItems[0].SubItems[4].Text;
                txtSubeID.Text = lsvCalisan.SelectedItems[0].SubItems[5].Text;
                txtSubeAdi.Text = lsvCalisan.SelectedItems[0].SubItems[6].Text;
                txtEvAdresi.Text = lsvCalisan.SelectedItems[0].SubItems[7].Text;
                txtKullaniciAdi.Text = lsvCalisan.SelectedItems[0].SubItems[8].Text;
                txtCalisanTipID.Text = lsvCalisan.SelectedItems[0].SubItems[9].Text;
                txtCalisanTipAdi.Text = lsvCalisan.SelectedItems[0].SubItems[10].Text;
                if (lsvCalisan.SelectedItems[0].SubItems[11].Text == "Evet")
                {
                    rdbYonetici.Checked = true;
                }
                else
                {
                    rdbCalisan.Checked = true;
                }
                txtSifre.Text = lsvCalisan.SelectedItems[0].SubItems[12].Text;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (txtCalisanAdi.Text == "" || txtCalisanSoyad.Text == "" || txtCalisanTipAdi.Text == "" || txtCalisanTipID.Text == "" || txtEmail.Text == "" || txtEvAdresi.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtSubeAdi.Text == "" || txtSubeID.Text == "" || txtTelefon.Text == "" || (rdbYonetici.Checked == false && rdbCalisan.Checked == false))
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvCalisan.FullRowSelect = true;
            }
            else
            {
                Entity.Calisan gnccl = new Entity.Calisan();
                gnccl.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                gnccl.Ad = Face.Kontrol.Temizle(txtCalisanAdi.Text);
                gnccl.Soyad = Face.Kontrol.Temizle(txtCalisanSoyad.Text);
                gnccl.Email = Face.Kontrol.Temizle(txtEmail.Text);
                gnccl.Telefon = Face.Kontrol.Temizle(txtTelefon.Text);
                gnccl.SubeID = Convert.ToInt32(Face.Kontrol.Temizle(txtSubeID.Text));
                gnccl.KullaniciAdi = Face.Kontrol.Temizle(txtKullaniciAdi.Text);
                gnccl.EvAdresi = Face.Kontrol.Temizle(txtEvAdresi.Text);
                gnccl.CalisaTipID = Convert.ToInt32(Face.Kontrol.Temizle(txtCalisanTipID.Text));
                if (rdbYonetici.Checked)
                {
                    gnccl.Yoneticimi = true;
                }
                else if (rdbCalisan.Checked)
                {
                    gnccl.Yoneticimi = false;
                }
                gnccl.Sifre = Face.Kontrol.Temizle(txtSifre.Text);
                if (Face.Calisan.CalisanGuncelle(gnccl) > 0)
                {
                    MessageBox.Show("Calisan Bilgileri Guncellendi");
                    Temizle();
                    lsvCalisan.FullRowSelect = true;
                    Face.Calisan.CalisanListesi(lsvCalisan);
                    Face.Sube.Subelistele(cmbSubeAdi);
                    Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);


                }
                else
                {
                    MessageBox.Show("Çalışan Bilgileri Güncellenememiştir");
                    Temizle();
                }

            }
        }

        private void txtAranacakAd_TextChanged(object sender, EventArgs e)
        {
            Face.Calisan.AdaGoreCalisanGetir(lsvCalisan, txtAranacakAd.Text);
        }

        private void txtAranacakSube_TextChanged(object sender, EventArgs e)
        {
            Face.Calisan.SubeAdinaGoreCalisanGetir(lsvCalisan, txtAranacakSube.Text);

        }




    }
}
