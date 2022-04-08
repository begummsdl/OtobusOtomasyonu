using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.OtobusIslemleri
{
    public partial class FrmOtobusIslemleri : Form
    {
        public FrmOtobusIslemleri()
        {
            InitializeComponent();
        }

        private void FrmOtobusIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 80;
            Face.Sehir.sehirListele(cmbMevcutSehirler);
            Face.Marka.MarkaListele(cmbMarkalar);
            Face.Otobus.OtobusListesi(lsvOtobusler);
            txtKayitSayisi.Text = Convert.ToString(lsvOtobusler.Items.Count);
        }

        private void cmbMevcutSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sh = (Entity.Sehir)cmbMevcutSehirler.SelectedItem;
            txtSehirID.Text = Convert.ToString(sh.SehirID);
            txtSehirAdi.Text = sh.SehirAdi;
        }


        private void cmbMarkalar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Entity.Marka mk = (Entity.Marka)cmbMarkalar.SelectedItem;
            txtMarka.Text = mk.MarkaAdi;
            txtMarkaID.Text = Convert.ToString(mk.MarkaID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSehirAdi_TextChanged(object sender, EventArgs e)
        {
            Face.Sehir.SehirAdinaGoreOtobusSayisi(Face.Kontrol.Temizle(txtSehirAdi.Text), txtOtoBusSayisi);
            if (txtOtoBusSayisi.Text == "")
            {
                txtOtoBusSayisi.Text = "0";
            }
        }

        private void lsvOtobusler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsvOtobusler.SelectedItems.Count > 0)
            {
                txtOtobusID.Text = lsvOtobusler.SelectedItems[0].SubItems[0].Text;
                txtPlaka.Text = lsvOtobusler.SelectedItems[0].SubItems[1].Text;
                txtKoltukSayisi.Text = lsvOtobusler.SelectedItems[0].SubItems[2].Text;
                txtMarkaID.Text = lsvOtobusler.SelectedItems[0].SubItems[3].Text;
                txtMarka.Text = lsvOtobusler.SelectedItems[0].SubItems[4].Text;
                if (lsvOtobusler.SelectedItems[0].SubItems[5].Text == "Evet")
                {
                    rbEvet.Checked = true;
                }
                else
                {
                    rbHayır.Checked = true;
                }
            }
        }

        private void btnOtobusMasraf_Click(object sender, EventArgs e)
        {
            OtobusMasrafIslemleri.FrmOtobusMasraflar frm = new OtobusMasrafIslemleri.FrmOtobusMasraflar();
            frm.ShowDialog();
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
            txtMarka.Text = "";
            txtMarkaID.Text = "";
            txtOtobusID.Text = "";
            txtKoltukSayisi.Text = "";
            txtAranacakOtobusPlaka.Text = "";
            txtSehirAdi.Text = "";
            txtSehirID.Text = "";
            txtPlaka.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text == "" || txtKoltukSayisi.Text == "" || txtMarka.Text == "" || txtMarkaID.Text == "" || (rbEvet.Checked == false && rbHayır.Checked == false))
            {
                MessageBox.Show("Otobus Ekleyebilmek İçin Tüm Alanlar Doldurulmalırı", "Dikkat Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool sonuc = Face.Otobus.OtobusVarmi(Face.Kontrol.Temizle(txtPlaka.Text.ToUpper()));
                if (sonuc)
                {
                    MessageBox.Show("Daha Önceden Eklenmiş Bir Otobüsü Eklemek İstiyorsunuz", "Uyarı Kayıt Var", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entity.Otobus oto = new Entity.Otobus();
                    oto.Plaka = Face.Kontrol.Temizle(txtPlaka.Text.ToUpper());
                    oto.KoltukSayisi = Convert.ToByte(Face.Kontrol.Temizle(txtKoltukSayisi.Text));
                    oto.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                    if (rbEvet.Checked)
                    {
                        oto.AktifMi = true;
                    }
                    else
                    {
                        oto.AktifMi = false;
                    }
                    int etkilenensatirsayisi = Face.Otobus.OtobusEkle(oto);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Otobus Ekleme İşlemi Başarılı");
                        Face.Sehir.sehirListele(cmbMevcutSehirler);
                        Face.Marka.MarkaListele(cmbMarkalar);
                        Face.Otobus.OtobusListesi(lsvOtobusler);
                        txtKayitSayisi.Text = Convert.ToString(lsvOtobusler.Items.Count);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text == "" || txtKoltukSayisi.Text == "" || txtMarka.Text == "" || txtMarkaID.Text == "" || (rbEvet.Checked == false && rbHayır.Checked == false))
            {
                MessageBox.Show("Otobus Güncelleyebilmek İçin Tüm Alanlar Doldurulmalırı", "Dikkat Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.Otobus ot = new Entity.Otobus();
                ot.OtobusID = Convert.ToInt32(txtOtobusID.Text);
                ot.Plaka = Face.Kontrol.Temizle(txtPlaka.Text.ToUpper());
                ot.KoltukSayisi = Convert.ToByte(Face.Kontrol.Temizle(txtKoltukSayisi.Text));
                ot.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                if (rbEvet.Checked)
                {
                    ot.AktifMi = true;
                }
                else
                {
                    ot.AktifMi = false;
                }
                int etkilenensatirsayisi = Face.Otobus.OtobusGuncelle(ot);
                if (etkilenensatirsayisi > 0)
                {
                    MessageBox.Show("Otobus Güncelleme İşlemi Başarılı");
                    Face.Sehir.sehirListele(cmbMevcutSehirler);
                    Face.Marka.MarkaListele(cmbMarkalar);
                    Face.Otobus.OtobusListesi(lsvOtobusler);
                    txtKayitSayisi.Text = Convert.ToString(lsvOtobusler.Items.Count);
                    Temizle();
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOtobusID.Text == "")
            {
                MessageBox.Show("Otobüsü Silebilmek İçin Lütfen Listeden Bir Otobüs Seçiniz!", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show("Otobüsü Silmek İstediğinizden Eminmisiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Otobus otb = new Entity.Otobus();
                    otb.OtobusID = Convert.ToInt32(txtOtobusID.Text);
                    int etkilenensatirsayisi = Face.Otobus.OtobusSil(otb);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Otobüs Silme İşlemi Başarılı");
                        Face.Sehir.sehirListele(cmbMevcutSehirler);
                        Face.Marka.MarkaListele(cmbMarkalar);
                        Face.Otobus.OtobusListesi(lsvOtobusler);
                        txtKayitSayisi.Text = Convert.ToString(lsvOtobusler.Items.Count);
                        Temizle();
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Otobüs Silme İşlemleri Sırasında Bir Hata Meydana Geldi");
                    }
                }
                else
                {
                    MessageBox.Show("Otobüs Silme İşleminden Vazgeçildi");
                }
            }
        }

       
        private void txtAranacakOtobusPlaka_TextChanged_1(object sender, EventArgs e)
        {
Face.Otobus.PlakayaGoreOtobusAra(lsvOtobusler, Face.Kontrol.Temizle(txtAranacakOtobusPlaka.Text.ToUpper()));
        }




    }
}
