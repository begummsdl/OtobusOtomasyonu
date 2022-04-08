using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.SeferIslemleri
{
    public partial class FrmSeferIslemleri : Form
    {
        public FrmSeferIslemleri()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void FrmSeferIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 90;
            this.Left = 50;
            //Face.Sefer.SeferListele(lsvSefer);
            ds = Face.Sefer.SeferListele();
            dgvSonuc.DataSource = ds.Tables["DetayListesi"];
            Face.Sefer.Seferlistesi(cmbSefer);
            Face.Sehir.SehirGetir(cmbNereden);
            Face.Sehir.SehirGetir(cmbNereye);
            Face.Sehir.SehirGetir(cmbKalkisSehri);
            Face.Sehir.SehirGetir(cmbVarisSehri);
            Face.Sefer.SoforAdBulGetir(cmbSofor);
            Face.Sefer.MuavinAdBulGetir(cmbMuavin);
            Face.Sefer.OtobusPlakaBulGetir(cmbOtobusPlaka);
            dtpKalkisZamani.Visible = true;
            dtpVarisZamani.Visible = true;
            txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSonuc_Click(object sender, EventArgs e)
        {
            
            txtSeferNo.Text = dgvSonuc.CurrentRow.Cells[0].Value.ToString();
            txtKalkisSehirID.Text = dgvSonuc.CurrentRow.Cells[1].Value.ToString();
            txtKalkisSehri.Text = dgvSonuc.CurrentRow.Cells[2].Value.ToString();
            txtVarisSehirID.Text = dgvSonuc.CurrentRow.Cells[3].Value.ToString();
            txtVarisSehri.Text = dgvSonuc.CurrentRow.Cells[4].Value.ToString();
            txtOtobusID.Text = dgvSonuc.CurrentRow.Cells[5].Value.ToString();
            txtOtobusPlaka.Text = dgvSonuc.CurrentRow.Cells[6].Value.ToString();
            txtSoforAdi.Text = dgvSonuc.CurrentRow.Cells[7].Value.ToString();
            txtMuavinAdi.Text = dgvSonuc.CurrentRow.Cells[8].Value.ToString();
            txtVarisZamani.Text = dgvSonuc.CurrentRow.Cells[9].Value.ToString();
            txtKalkisZamani.Text = dgvSonuc.CurrentRow.Cells[10].Value.ToString();
            txtBiletTutari.Text = dgvSonuc.CurrentRow.Cells[11].Value.ToString();
            txtTahminiSure.Text = dgvSonuc.CurrentRow.Cells[12].Value.ToString();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void Temizle()
        {
            txtBiletTutari.Clear();
            txtKalkisSehri.Clear();
            txtKalkisSehirID.Clear();
            txtKalkisZamani.Clear();
            txtMuavinAdi.Clear();
            txtMuavinID.Clear();
            txtOtobusID.Clear();
            txtOtobusPlaka.Clear();
            txtSeferNo.Clear();
            txtSoforAdi.Clear();
            txtSoforID.Clear();
            txtTahminiSure.Clear();
            txtVarisSehri.Clear();
            txtVarisSehirID.Clear();
            txtVarisZamani.Clear();
        }

        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sefer sf = (Entity.Sefer)cmbSefer.SelectedItem;
            txtSeferNo.Text = Convert.ToString(sf.SeferID);
        }

        private void cmbKalkisSehri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sehir = (Entity.Sehir)cmbKalkisSehri.SelectedItem;
            txtKalkisSehirID.Text = Convert.ToString(sehir.SehirID);
            txtKalkisSehri.Text = cmbKalkisSehri.SelectedItem.ToString();
            txtKalkisSehri.Focus();
        }

        private void cmbVarisSehri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sehir = (Entity.Sehir)cmbVarisSehri.SelectedItem;
            txtVarisSehirID.Text = Convert.ToString(sehir.SehirID);
            txtVarisSehri.Text = cmbVarisSehri.SelectedItem.ToString();
            txtVarisSehri.Focus();
        }

        private void cmbOtobusPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Otobus oto = (Entity.Otobus)cmbOtobusPlaka.SelectedItem;
            txtOtobusID.Text = Convert.ToString(oto.OtobusID);
            txtOtobusPlaka.Text = cmbOtobusPlaka.SelectedItem.ToString();
            txtOtobusPlaka.Focus();
        }

        private void cmbMuavin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Calisan calis = (Entity.Calisan)cmbMuavin.SelectedItem;
            txtMuavinID.Text = Convert.ToString(calis.PersonelID);
            txtMuavinAdi.Text = cmbMuavin.SelectedItem.ToString();
            txtMuavinAdi.Focus();
        }

        private void cmbSofor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Calisan calis = (Entity.Calisan)cmbSofor.SelectedItem;
            txtSoforID.Text = Convert.ToString(calis.PersonelID);
            txtSoforAdi.Text = cmbSofor.SelectedItem.ToString();
            txtSoforAdi.Focus();
        }

        private void dtpKalkisZamani_ValueChanged(object sender, EventArgs e)
        {
            txtKalkisZamani.Text = dtpKalkisZamani.Value.ToShortDateString();
        }

        private void dtpVarisZamani_ValueChanged(object sender, EventArgs e)
        {
            txtVarisZamani.Text = dtpVarisZamani.Value.ToShortDateString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKalkisSehirID.Text == "" || txtVarisSehirID.Text == "" || txtVarisSehri.Text == "" || txtKalkisSehri.Text == "" || txtOtobusID.Text == "" || txtOtobusPlaka.Text == "" || txtMuavinID.Text == "" || txtMuavinAdi.Text == "" || txtSoforID.Text == "" || txtSoforAdi.Text == "" || txtKalkisZamani.Text == "" || txtVarisZamani.Text == "" || txtBiletTutari.Text == "" || txtTahminiSure.Text == "")
            {
                MessageBox.Show("KalkişSehirAdi,VarişŞehirAdi,OtobusPlaka,MuavinAdi,ŞoförAdi,KalkışZamani,VarişZamani,BiletTutarı,TahminiSüre\n Alanları Boş Geçilemez Lütfen Mevcut listelerden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.Sefer sefer = new Entity.Sefer();
                sefer.KalkisSehirID = Convert.ToInt32(txtKalkisSehirID.Text);
                sefer.VarisSehirID = Convert.ToInt32(txtVarisSehirID.Text);
                sefer.OtobusID = Convert.ToInt32(txtOtobusID.Text);
                sefer.MuavinID = Convert.ToInt32(txtMuavinID.Text);
                sefer.SoforID = Convert.ToInt32(txtSoforID.Text);
                sefer.KalkisZamani = Convert.ToDateTime(txtKalkisZamani.Text);
                sefer.VarisZamani = Convert.ToDateTime(txtVarisZamani.Text);
                sefer.TahminiSure = Convert.ToByte(txtTahminiSure.Text);
                sefer.BiletTutari = Convert.ToDecimal(txtBiletTutari.Text);

                if (Face.Sefer.SeferEkle(sefer) > 0)
                {
                    MessageBox.Show("Sefer Başarı ile Eklendi");
                    btnEkle.Enabled = false;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                    btnYeni.Enabled = true;
                    ds = Face.Sefer.SeferListele();
                    dgvSonuc.DataSource = ds.Tables["DetayListesi"];
                    Face.Sefer.Seferlistesi(cmbSefer);
                    Face.Sehir.SehirGetir(cmbNereden);
                    Face.Sehir.SehirGetir(cmbNereye);
                    Face.Sehir.SehirGetir(cmbKalkisSehri);
                    Face.Sehir.SehirGetir(cmbVarisSehri);
                    Face.Sefer.SoforAdBulGetir(cmbSofor);
                    Face.Sefer.MuavinAdBulGetir(cmbMuavin);
                    Face.Sefer.OtobusPlakaBulGetir(cmbOtobusPlaka);
                    dtpKalkisZamani.Visible = true;
                    dtpVarisZamani.Visible = true;
                    txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
                }
                else
                {
                    MessageBox.Show("Sefer Eklenirken Hata oluştu");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSeferNo.Text == "" || txtKalkisSehirID.Text == "" || txtVarisSehirID.Text == "" || txtVarisSehri.Text == "" || txtKalkisSehri.Text == "" || txtOtobusID.Text == "" || txtOtobusPlaka.Text == "" || txtMuavinID.Text == "" || txtMuavinAdi.Text == "" || txtSoforID.Text == "" || txtSoforAdi.Text == "" || txtKalkisZamani.Text == "" || txtVarisZamani.Text == "" || txtBiletTutari.Text == "" || txtTahminiSure.Text == "")
            {
                MessageBox.Show("SeferNo,KalkişSehirAdi,VarişŞehirAdi,OtobusPlaka,MuavinAdi,ŞoförAdi,KalkışZamani,VarişZamani,BiletTutarı,TahminiSüre\n Soför Adını ve Muavin Adını Mevcut Listeden Seçiniz\n Alanları Boş Geçilemez Lütfen Mevcut listelerden Seçim Yapınız", "Uyarı Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtKalkisZamani.Visible = true;
                txtVarisZamani.Visible = true;
                txtTahminiSure.Visible = true;
                txtBiletTutari.Visible = true;
                txtKalkisZamani.Text = dtpKalkisZamani.Value.ToShortDateString();
                txtVarisZamani.Text = dtpVarisZamani.Value.ToShortDateString();
                Entity.Sefer sf = new Entity.Sefer();
                sf.SeferID = Convert.ToInt32(Face.Kontrol.Temizle(txtSeferNo.Text));
                sf.KalkisSehirID = Convert.ToInt32(Face.Kontrol.Temizle(txtKalkisSehirID.Text));
                sf.VarisSehirID = Convert.ToInt32(Face.Kontrol.Temizle(txtVarisSehirID.Text));
                sf.OtobusID = Convert.ToInt32(Face.Kontrol.Temizle(txtOtobusID.Text));
                sf.MuavinID = Convert.ToInt32(Face.Kontrol.Temizle(txtMuavinID.Text));
                sf.SoforID = Convert.ToInt32(Face.Kontrol.Temizle(txtSoforID.Text));
                sf.KalkisZamani = Convert.ToDateTime(Face.Kontrol.Temizle(txtKalkisZamani.Text));
                sf.VarisZamani = Convert.ToDateTime(Face.Kontrol.Temizle(txtVarisZamani.Text));
                sf.TahminiSure = Convert.ToByte(Face.Kontrol.Temizle(txtTahminiSure.Text));
                sf.BiletTutari = Convert.ToDecimal(Face.Kontrol.Temizle(txtBiletTutari.Text));
                if (Face.Sefer.SeferGuncelle(sf) > 0)
                {
                    MessageBox.Show("Sefer Guncelleme İşlemi Başarı ile Gerçekleşti");
                    btnEkle.Enabled = false;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                    btnYeni.Enabled = true;
                    ds = Face.Sefer.SeferListele();
                    dgvSonuc.DataSource = ds.Tables["DetayListesi"];
                    Face.Sefer.Seferlistesi(cmbSefer);
                    Face.Sehir.SehirGetir(cmbNereden);
                    Face.Sehir.SehirGetir(cmbNereye);
                    Face.Sehir.SehirGetir(cmbKalkisSehri);
                    Face.Sehir.SehirGetir(cmbVarisSehri);
                    Face.Sefer.SoforAdBulGetir(cmbSofor);
                    Face.Sefer.MuavinAdBulGetir(cmbMuavin);
                    Face.Sefer.OtobusPlakaBulGetir(cmbOtobusPlaka);
                    dtpKalkisZamani.Visible = true;
                    dtpVarisZamani.Visible = true;
                    txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);

                }
                else
                {
                    MessageBox.Show("Guncelleme İşlemleri Sırasında bir Hata Oluştu +/n Lütfen Sistem Yöneticinize Başvurunuz");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSeferNo.Text == "")
            {
                MessageBox.Show("Seferi  Silebilmek için Listeden Secim Yapınız ");
            }
            else
            {
                if (MessageBox.Show(txtSeferNo.Text + "Numaralı" + " Sefer Silinsin mi?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Sefer sefer = new Entity.Sefer();
                    sefer.SeferID = Convert.ToInt32(txtSeferNo.Text);
                    int etkilenensatirsayisi = Face.Sefer.SeferSil(sefer);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Sefer  Silindi!");
                        btnEkle.Enabled = false;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                        btnYeni.Enabled = true;
                        ds = Face.Sefer.SeferListele();
                        dgvSonuc.DataSource = ds.Tables["DetayListesi"];
                        Face.Sefer.Seferlistesi(cmbSefer);
                        Face.Sehir.SehirGetir(cmbNereden);
                        Face.Sehir.SehirGetir(cmbNereye);
                        Face.Sehir.SehirGetir(cmbKalkisSehri);
                        Face.Sehir.SehirGetir(cmbVarisSehri);
                        Face.Sefer.SoforAdBulGetir(cmbSofor);
                        Face.Sefer.MuavinAdBulGetir(cmbMuavin);
                        Face.Sefer.OtobusPlakaBulGetir(cmbOtobusPlaka);
                        dtpKalkisZamani.Visible = true;
                        dtpVarisZamani.Visible = true;
                        txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
                    }
                    else
                    {
                        MessageBox.Show("Sefer Bilgileri Silinemedi!");
                    }
                }
                else
                {
                    MessageBox.Show(" Sefer Silme işleminden vazgeçildi!");
                }
            }
        }
        DataSet dm = new DataSet();
        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sh = (Entity.Sehir)cmbNereden.SelectedItem;
            txtNeredenID.Text = Convert.ToString(sh.SehirID);
            txtNeredenAd.Text = sh.SehirAdi;
            if (txtNeredenID.Text != "" && txtNereyeID.Text != "")
            {
                dm= Face.Sefer.SeferNoyaGoreAra(Convert.ToInt32(txtNeredenID.Text), Convert.ToInt32(txtNereyeID.Text));
                dgvSonuc.DataSource = dm.Tables["Ara"];
                txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
            }
        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sh = (Entity.Sehir)cmbNereye.SelectedItem;
            txtNereyeID.Text = Convert.ToString(sh.SehirID);
            txtNereyeAd.Text = sh.SehirAdi;
            if (txtNeredenID.Text != "" && txtNereyeID.Text != "")
            {
                dm = Face.Sefer.SeferNoyaGoreAra(Convert.ToInt32(txtNeredenID.Text), Convert.ToInt32(txtNereyeID.Text));
                dgvSonuc.DataSource = dm.Tables["Ara"];
                txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
            }
        }

        private void btnAnaListeyeGeriDon_Click(object sender, EventArgs e)
        {
            ds = Face.Sefer.SeferListele();
            dgvSonuc.DataSource = ds.Tables["DetayListesi"];
            txtSeferSayisi.Text = Convert.ToString(dgvSonuc.Rows.Count - 1);
            txtNereyeAd.Text = "";
            txtNeredenID.Text = "";
            txtNeredenAd.Text = "";
            txtNereyeID.Text = "";
        }


    }
}
