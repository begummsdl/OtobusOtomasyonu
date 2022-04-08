using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.SehirIslemleri
{
    public partial class FrmSehir : Form
    {
        public FrmSehir()
        {
            InitializeComponent();
        }

        private void FrmSehir_Load(object sender, EventArgs e)
        {
            this.Left = 80;
            this.Top = 150;
            Face.Sehir.sehirListele(cmbSehir);
            Face.Sehir.SehirListesi(lsvSehir);
            txtSehirSayisi.Text = Convert.ToString(lsvSehir.Items.Count);
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sh = (Entity.Sehir)cmbSehir.SelectedItem;
            txtSehirAdi.Text = sh.SehirAdi;
            txtSehirID.Text = Convert.ToString(sh.SehirID);
        }

        private void txtAranacak_TextChanged(object sender, EventArgs e)
        {
            Face.Sehir.ArananSehir(lsvSehir, Face.Kontrol.Temizle(txtAranacak.Text));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtSehirAdi.Text = "";
            txtSehirID.Text = "";
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSehirAdi.Text == "")
            {
                MessageBox.Show("Sehir Ekleyebilmek İçin Lütfen Bir Şehir Adi Giriniz", "Dikkat Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool sonuc = Face.Sehir.SehirVarmi(txtSehirAdi.Text);
                if (sonuc)
                {
                    MessageBox.Show("Daha Önceden Eklenmiş Bir Şehiri Eklemek İstiyorsunuz!");
                }
                else
                {
                    Entity.Sehir sh = new Entity.Sehir();
                    sh.SehirAdi = Face.Kontrol.Temizle(txtSehirAdi.Text.ToUpper());
                    int etkilenensatirsayisi = Face.Sehir.SehirEkle(sh);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Şehir Ekleme İşlemi Başarılı");
                        Face.Sehir.sehirListele(cmbSehir);
                        Face.Sehir.SehirListesi(lsvSehir);
                        txtSehirSayisi.Text = Convert.ToString(lsvSehir.Items.Count);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Sehir Ekleme İşlemleri Sırasında Bir Hata Meydana Geldi");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSehirID.Text == "" || txtSehirAdi.Text == "")
            {
                MessageBox.Show("Sehir Güncellemek İçin Lütfen Mevcut Şehirlerden Seçim Yapınız");
            }
            else
            {
                bool sonuc = Face.Sehir.SehirVarmi(Face.Kontrol.Temizle(txtSehirAdi.Text));
                if (sonuc)
                {
                    MessageBox.Show("Güncelemek İstediğiniz SehirAdi Daha Önceden Kayıtlı");
                }
                else
                {
                    Entity.Sehir sh = new Entity.Sehir();
                    sh.SehirID = Convert.ToInt32(txtSehirID.Text);
                    sh.SehirAdi = Convert.ToString(Face.Kontrol.Temizle(txtSehirAdi.Text));
                    int etkilenensatirsayisi = Face.Sehir.SehirGuncelle(sh);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Şehir Güncelleme İşlemi Başarılı");
                        Face.Sehir.sehirListele(cmbSehir);
                        Face.Sehir.SehirListesi(lsvSehir);
                        txtSehirSayisi.Text = Convert.ToString(lsvSehir.Items.Count);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Sehir Güncelleme İşlemleri Sırasında hata Oluştu");
                    }

                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSehirID.Text == "")
            {
                MessageBox.Show("Silinecek Sehiri Mevcut Şehirlerden Seçiniz");
            }
            else
            {
                if (MessageBox.Show("Sehiri Silmek İstediğinizden Emin Misiniz", "Silmek İstediğinizden Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Sehir sh = new Entity.Sehir();
                    sh.SehirID = Convert.ToInt32(txtSehirID.Text);
                    int etkilenensatirsayisi = Face.Sehir.SehirSil(sh);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Şehir Silme İşlemi Başarılı");
                        Face.Sehir.sehirListele(cmbSehir);
                        Face.Sehir.SehirListesi(lsvSehir);
                        txtSehirSayisi.Text = Convert.ToString(lsvSehir.Items.Count);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Sehir Silme İşlemleri Sırasında Hata Meydana Geldi");
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
