using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.MasrafTipIslemleri
{
    public partial class FrmMasrafTip : Form
    {
        public FrmMasrafTip()
        {
            InitializeComponent();
        }

        private void FrmMasrafTip_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 80;
            Face.MasrafTip.MasrafTipListesi(lsvMasrafTip);
            txtListenenKayitSayisi.Text = Convert.ToString(lsvMasrafTip.Items.Count);
            Face.MasrafTip.MasrafTipListe(cmbMasrafTip);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvMasrafTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMasrafTip.SelectedItems.Count > 0)
            {
                string gelenID = lsvMasrafTip.SelectedItems[0].Text;
                MasrafTipIslemleri.MasrafTipDetayGor frm = new MasrafTipDetayGor(gelenID);
                frm.ShowDialog();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
           
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtArananSube.Text = "";
            txtMasrafTipID.Text = "";
            txtMasrafTipAdi.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMasrafTipAdi.Text == "")
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır", "Dikkat Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool sonuc = Face.MasrafTip.MasrafTipAdiVarmi(Face.Kontrol.Temizle(txtMasrafTipAdi.Text.ToUpper()));
                if (sonuc)
                {
                    MessageBox.Show("Girilen Masraf Tip Adı Daha Önceden Kayıt Edilmiş ", "Uyarı Kayıtlı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entity.MasrafTip mt = new Entity.MasrafTip();
                    mt.MasrafTipAdi = Face.Kontrol.Temizle(txtMasrafTipAdi.Text);
                    int etkilenensatirsayisi = Face.MasrafTip.MasrafTipEkle(mt);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Masraf Tipi Ekleme İşlemi Başarılı");
                        Face.MasrafTip.MasrafTipListesi(lsvMasrafTip);
                        txtListenenKayitSayisi.Text = Convert.ToString(lsvMasrafTip.Items.Count);
                        Face.MasrafTip.MasrafTipListe(cmbMasrafTip);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                    }
                }
            }
        }

        private void cmbMasrafTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.MasrafTip mt = (Entity.MasrafTip)cmbMasrafTip.SelectedItem;
            txtMasrafTipID.Text = Convert.ToString(mt.MasrafTipID);
            txtMasrafTipAdi.Text = mt.MasrafTipAdi;

        }

        private void txtArananSube_TextChanged(object sender, EventArgs e)
        {
            Face.MasrafTip.MasrafAdiAra(lsvMasrafTip, Face.Kontrol.Temizle(txtArananSube.Text.ToUpper()));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMasrafTipAdi.Text == "" || txtMasrafTipID.Text == "")
            {
                MessageBox.Show("Güncelleme Yapabilmek İçin Tüm Alanların Doldurulması Gereklidir  \n Lütfen Mevcut Masraf Tiplerinden Seçim yapınız", "Uyarı Eksik Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.MasrafTip mt = new Entity.MasrafTip();
                mt.MasrafTipID =Convert.ToInt32(txtMasrafTipID.Text);
                mt.MasrafTipAdi = Convert.ToString(txtMasrafTipAdi.Text);
                int etkilenensatirsayisi = Face.MasrafTip.MasrafTipGuncelle(mt);
                if (etkilenensatirsayisi > 0)
                {
                    MessageBox.Show("Masraf Tip Güncelleme İşlemi Başarılı");
                    Face.MasrafTip.MasrafTipListesi(lsvMasrafTip);
                    txtListenenKayitSayisi.Text = Convert.ToString(lsvMasrafTip.Items.Count);
                    Face.MasrafTip.MasrafTipListe(cmbMasrafTip);
                    Temizle();
                    btnEkle.Enabled = false;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Masraf Tip Güncelleme İşlemi Sırasında Hata Meydana Geldi");
                }
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtMasrafTipAdi.Text == "" || txtMasrafTipID.Text == "")
            {
                MessageBox.Show("Güncelleme Yapabilmek İçin Tüm Alanların Doldurulması Gereklidir  \n Lütfen Mevcut Masraf Tiplerinden Seçim yapınız", "Uyarı Eksik Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Masraf Tipini Silmek İstediğinizden Emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.MasrafTip mt = new Entity.MasrafTip();
                    mt.MasrafTipID=Convert.ToInt32(txtMasrafTipID.Text);
                    int etkilenensatirsayisi=Face.MasrafTip.MasrafTipSil(mt);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Masraf Silme İşlemi Başarılı");
                        Face.MasrafTip.MasrafTipListesi(lsvMasrafTip);
                        txtListenenKayitSayisi.Text = Convert.ToString(lsvMasrafTip.Items.Count);
                        Face.MasrafTip.MasrafTipListe(cmbMasrafTip);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Masraf Silme İşlemleri Sırasında Hata Meydana Geldi");
                    }
                }
                else
                {
                    MessageBox.Show("Silme İşleminden Vazgeçildi");
                }
            }
        }

        private void btnOtobusMasraf_Click(object sender, EventArgs e)
        {
            OtobusMasrafIslemleri.FrmOtobusMasraflar frm = new OtobusMasrafIslemleri.FrmOtobusMasraflar();
            frm.ShowDialog();
        }

       

        
    }
}
