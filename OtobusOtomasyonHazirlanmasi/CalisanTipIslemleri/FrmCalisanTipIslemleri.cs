using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.CalisanTipIslemleri
{
    public partial class FrmCalisanTipIslemleri : Form
    {
        public FrmCalisanTipIslemleri()
        {
            InitializeComponent();
        }

        private void FrmCalisanTipIslemleri_Load(object sender, EventArgs e)
        {
            this.Left = 80;
            this.Top = 150;
            Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
            Face.CalisanTip.CalisanTipListesi(lsvCalisanTip);
            txtListenenKayitSayisi.Text = Convert.ToString(lsvCalisanTip.Items.Count);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtArananSube_TextChanged(object sender, EventArgs e)
        {
            Face.CalisanTip.CalisanTipAra(lsvCalisanTip, txtAranacakCalisanTipAdi.Text);
            txtListenenKayitSayisi.Text = Convert.ToString(lsvCalisanTip.Items.Count);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            Temizle();
            cmbCalisanTip.Visible = false;
        }

        private void Temizle()
        {
            txtYeni.Text = "";
            txtCalisanTipAdi.Text = "";
            txtCalisanTipID.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            grpCalisanTip.Visible = true;
            if (txtYeni.Text == "")
            {
                MessageBox.Show("Yeni Bir Çalışan Tipinin Eklenemesi İçin Lütfen Yeni Calisan tipi Adını Giriniz", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool sonuc = Face.CalisanTip.CalisanTipAdiVarmi(Face.Kontrol.Temizle(txtYeni.Text));
                if (sonuc)
                {
                    MessageBox.Show("Daha Önceden Eklenmiş Bir Çalışan Tipini Eklemeye Çalışıyorsunuz", "Uyarı Var Olan Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entity.CalisanTip clt = new Entity.CalisanTip();
                    clt.CalisanTipAdi = Face.Kontrol.Temizle(txtYeni.Text);
                    int etkilenensatirsayisi = Face.CalisanTip.CalisanTipEkle(clt);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Çalışan Tipi Ekleme Başarılı");
                        Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
                        Face.CalisanTip.CalisanTipListesi(lsvCalisanTip);
                        txtListenenKayitSayisi.Text = Convert.ToString(lsvCalisanTip.Items.Count);
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        grpCalisanTip.Visible = false;
                        cmbCalisanTip.Visible = false;
                        Temizle();
                        btnYeni.Enabled = true;
                    }
                }
            }
        }

        private void cmbCalisanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.CalisanTip clt = (Entity.CalisanTip)cmbCalisanTip.SelectedItem;
            txtCalisanTipID.Text = Convert.ToString(clt.CalisanTipID);
            txtCalisanTipAdi.Text = clt.CalisanTipAdi;
            txtYeni.Text = clt.CalisanTipAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            cmbCalisanTip.Visible = true; grpCalisanTip.Visible = true;
            if (txtCalisanTipAdi.Text == "" || txtCalisanTipID.Text == "" || txtYeni.Text == "")
            {
                MessageBox.Show("Dikkat Eksik Bilgi Calisan Tipi Güncellemek İçin Lütfen Mevcut Calişan Tiplerinden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.CalisanTip clt = new Entity.CalisanTip();
                clt.CalisanTipID = Convert.ToInt32(txtCalisanTipID.Text);
                clt.CalisanTipAdi = Face.Kontrol.Temizle(txtYeni.Text);
                int etkilenensatirsayisi = Face.CalisanTip.CalisanTipGuncelle(clt);
                if (etkilenensatirsayisi > 0)
                {
                    MessageBox.Show("Çalisan Tip Adi Güncelleme İşlemi Başarılı");
                    Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
                    Face.CalisanTip.CalisanTipListesi(lsvCalisanTip);
                    txtListenenKayitSayisi.Text = Convert.ToString(lsvCalisanTip.Items.Count);
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                    grpCalisanTip.Visible = false;
                    cmbCalisanTip.Visible = false;
                    Temizle();
                    btnYeni.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Calisan Tip Adi Güncelleme İşlemiBaşarısız");
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {   // Normalde sadece güncelleme ve silme işlemlerinde ID ye göre bakılınca tüm formlarda yeterli olacaktır
            //Genel olarak kullanıcının Hatasının nerde olduğunu belirtmek için projede ad kısımları vs kullanılmıştır
            cmbCalisanTip.Visible = true;
            if (txtCalisanTipAdi.Text == "" || txtCalisanTipID.Text == "")
            {
                MessageBox.Show("Lütfen Mevcut Çalişan  Tiplerinden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Çalışan Tip Adını Silmek İstediğinizden Emin misiniz?", "Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.CalisanTip clt = new Entity.CalisanTip();
                    clt.CalisanTipID = Convert.ToInt32(txtCalisanTipID.Text);
                    int etkilenensatirsayisi = Face.CalisanTip.CalisanTipSil(clt);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show(" Çalışan Tip Silme İşlemi Başarılı");
                        Face.CalisanTip.CalisanTipGetir(cmbCalisanTip);
                        Face.CalisanTip.CalisanTipListesi(lsvCalisanTip);
                        txtListenenKayitSayisi.Text = Convert.ToString(lsvCalisanTip.Items.Count);
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        grpCalisanTip.Visible = false;
                        cmbCalisanTip.Visible = false;
                        Temizle();
                        btnYeni.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Çalışan Tip Silme İşlemleri Sırasında Hata Meydana Geldi");
                    }
                }
                else
                {
                    MessageBox.Show("Silme İşleminden Vazgeçildi");
                }
            }
        }
    }
}
