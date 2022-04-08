using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.MarkaIslemleri
{
    public partial class FrmMarkaIslemleri : Form
    {
        public FrmMarkaIslemleri()
        {
            InitializeComponent();
        }

        private void FrmMarkaIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 80;
            Face.Marka.MarkaListele(cmbMarka);
            Face.Marka.MarkaListesi(lsvMarka);
            Face.Otobus.OtobusPlakaGetir(cmbOtobusler);
            txtListenenKayitSayisi.Text = Convert.ToString(lsvMarka.Items.Count);
            lstMarka.Visible = false;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvMarka.SelectedItems.Count > 0)
                {
                    txtMarkaID.Text = lsvMarka.SelectedItems[0].SubItems[0].Text;
                    txtMarkaAdi.Text = lsvMarka.SelectedItems[0].SubItems[1].Text;
                    txtOtobusAdi.Text = lsvMarka.SelectedItems[0].SubItems[2].Text;
                    txtKoltukSayisi.Text = lsvMarka.SelectedItems[0].SubItems[3].Text;
                    txtOtobusID.Text = lsvMarka.SelectedItems[0].SubItems[4].Text;
                    if (lsvMarka.SelectedItems[0].SubItems[5].Text == "Evet")
                    {
                        rdrEvet.Checked = true;
                    }
                    else
                    {
                        rdrHayir.Checked = true;
                    }
                    Face.Marka.MarkadakiOtobusSayisi(txtMarkaAdi.Text, txtMarkaOtobusSayisi);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtAranacakMarka_TextChanged(object sender, EventArgs e)
        {
            Face.Marka.MarkaAdiAra(lsvMarka, Face.Kontrol.Temizle(txtAranacakMarka.Text));
            txtListenenKayitSayisi.Text = Convert.ToString(lsvMarka.Items.Count);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
            Temizle();
            lstMarka.Visible = false;
            lblMesaj.Visible = false;
        }

        private void Temizle()
        {
            txtMarkaAdi.Text = "";
            txtMarkaID.Text = "";
            txtOtobusAdi.Text = "";
            txtOtobusID.Text = "";
            txtKoltukSayisi.Text = "";
            rdrEvet.Checked = false;
            rdrHayir.Checked = false;
            txtYeniMarka.Text = "";
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Marka mk = (Entity.Marka)cmbMarka.SelectedItem;
            txtMarkaID.Text = Convert.ToString(mk.MarkaID);
            txtMarkaAdi.Text = mk.MarkaAdi;
            txtYeniMarka.Text = mk.MarkaAdi;
        }

        private void cmbOtobusler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Otobus oto = (Entity.Otobus)cmbOtobusler.SelectedItem;
            txtOtobusID.Text = Convert.ToString(oto.OtobusID);
            txtOtobusAdi.Text = oto.Plaka;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            grpYeniMarka.Visible = true;
            lstMarka.Visible = true;
            txtYeniMarka.Text = "";
            if (txtYeniMarka.Text == "")
            {
                MessageBox.Show("Marka Ekleyebilmek İçin Lütfen Marka Adını Giriniz", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool sonuc = Face.Marka.MarkaVarmi(Face.Kontrol.Temizle(txtYeniMarka.Text));
                if (sonuc)
                {
                    MessageBox.Show("Bu Marka Adi Daha Önceden Eklenmiş Uyarı!");
                }
                else
                {
                    Entity.Marka mk = new Entity.Marka();
                    mk.MarkaAdi = Face.Kontrol.Temizle(txtYeniMarka.Text);
                    int etkilenensatirsayisi = Face.Marka.MarkaEkle(mk);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Marka Ekleme İşlemi Başarılı,\n Yeni Eklenen Markayı Mevcut Markalardan Görebilirsiniz");
                        Face.Marka.MarkaListele(cmbMarka);
                        Face.Marka.MarkaListesi(lsvMarka);
                        Face.Otobus.OtobusPlakaGetir(cmbOtobusler);
                        Face.Marka.MarkaListGor(lstMarka);
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        Temizle();
                        grpYeniMarka.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Marka Ekleme İşlemleri Sırasında Hata Meydana Geldi");
                    }
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            grpYeniMarka.Visible = true; lstMarka.Visible = true; lblMesaj.Visible = true;
            if (txtMarkaAdi.Text == "" || txtMarkaID.Text == "" || txtYeniMarka.Text == "")
            {
                MessageBox.Show("Marka Güncelleyebilmek İçin Mevcut Markalar Listesinden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.Marka mk = new Entity.Marka();
                mk.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                mk.MarkaAdi = Face.Kontrol.Temizle(txtYeniMarka.Text);
                int etkilenensatirsayisi = Face.Marka.MarkaGuncelle(mk);
                if (etkilenensatirsayisi > 0)
                {
                    MessageBox.Show("Marka Güncelleme İşlemi Başarılı,\n Yeni Güncellenen Markayı Mevcut Markalardan Görebilirsiniz");
                    Face.Marka.MarkaListele(cmbMarka);
                    Face.Marka.MarkaListesi(lsvMarka);
                    Face.Otobus.OtobusPlakaGetir(cmbOtobusler);
                    Face.Marka.MarkaListGor(lstMarka);
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                    Temizle();
                    grpYeniMarka.Visible = false;
                    lblMesaj.Visible = true;
                }
                else
                {
                    MessageBox.Show("Marka Güncelleme İşlemleri Sırasında Hata Meydana Geldi");
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblMesaj.Visible = true;
            if (txtMarkaAdi.Text == "" || txtMarkaID.Text == "")
            {
                MessageBox.Show("Markayı Silebilmek İçin Mevcut Markalar Listesinden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Markayı Silmek İstediğinizden Emin misiniz", "Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Marka mk = new Entity.Marka();
                    mk.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                    int etkilenensatirsayisi = Face.Marka.MarkaSil(mk);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Marka Silme İşlemi Başarı İle Gerçekleşti");
                        Face.Marka.MarkaListele(cmbMarka);
                        Face.Marka.MarkaListesi(lsvMarka);
                        Face.Otobus.OtobusPlakaGetir(cmbOtobusler);
                        Face.Marka.MarkaListGor(lstMarka);
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnGuncelle.Enabled = false;
                        Temizle();
                        grpYeniMarka.Visible = false;
                        lblMesaj.Visible = true;
                        lstMarka.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Marka Silme İşlemleri Sırasında Hata Meydana Geldi");
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
