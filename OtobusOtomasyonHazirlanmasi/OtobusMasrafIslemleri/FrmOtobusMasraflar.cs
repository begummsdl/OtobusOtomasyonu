using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.OtobusMasrafIslemleri
{
    public partial class FrmOtobusMasraflar : Form
    {
        public FrmOtobusMasraflar()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void FrmOtobusMasraflar_Load(object sender, EventArgs e)
        {
            this.Left = 80;
            this.Top = 100;
            Face.Otobus.OtobusPlakaGetir(cmbOtobus);
            Face.MasrafTip.MasrafTipiGetir(cmbOtobusMasrafAdi);
            Face.Calisan.CalisanAdiGetir(cmbMasrafYapanPersoneller);
            Face.Sefer.SeferDoldur(txtKalkisID, txtVarisID, txtSeferID);
            ds = Face.OtobusMasraf.OtobusMasrafListeleGrd();
            dgvMasraf.DataSource = ds.Tables["OtoMasrafGor"];
            Face.Sefer.Seferlistesi(cmbSefer);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMasrafYapanAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["OtoMasrafGor"]);
            //Flan = 323 OR Filan= 'ABS'
            try
            {
                dv.RowFilter = "Ad LIKE '%" + txtMasrafYapanAra.Text;
            }
            catch
            {
                dv.RowFilter = "Ad LIKE '%" + txtMasrafYapanAra.Text + "%'";
            }
            //"UrunAdi LIKE 'gra%'"
            dgvMasraf.DataSource = dv;
        }

        private void txtOtobusPlakaAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["OtoMasrafGor"]);
            //Flan = 323 OR Filan= 'ABS'
            try
            {
                dv.RowFilter = "Plaka LIKE '%" + txtOtobusPlakaAra.Text;
            }
            catch
            {
                dv.RowFilter = "Plaka LIKE '%" + txtOtobusPlakaAra.Text + "%'";
            }
            //"UrunAdi LIKE 'gra%'"
            dgvMasraf.DataSource = dv;
        }

        private void dgvMasraf_Click(object sender, EventArgs e)
        {
            dgvMasraf.Columns[0].HeaderText = "OtobusMasrafID";

            dgvMasraf.Columns[1].HeaderText = "OtobusID";

            dgvMasraf.Columns[2].HeaderText = "MasrafTipID";

            dgvMasraf.Columns[3].HeaderText = "Tutar";

            dgvMasraf.Columns[4].HeaderText = "MasrafYapanPersonelID";

            dgvMasraf.Columns[5].HeaderText = "SeferID";

            dgvMasraf.Columns[6].HeaderText = "Plaka";

            dgvMasraf.Columns[7].HeaderText = "SoforID";

            dgvMasraf.Columns[8].HeaderText = "Ad";

            dgvMasraf.Columns[9].HeaderText = "Soyad";

            txtOtobusMasrafID.Text = dgvMasraf.CurrentRow.Cells[0].Value.ToString();

            txtOtobusID.Text = dgvMasraf.CurrentRow.Cells[1].Value.ToString();

            txtMasrafTipID.Text = dgvMasraf.CurrentRow.Cells[2].Value.ToString();

            txtMasrafTutari.Text = dgvMasraf.CurrentRow.Cells[3].Value.ToString();

            txtMasrafYapanPersonelID.Text = dgvMasraf.CurrentRow.Cells[4].Value.ToString();

            txtSoforSoyAd.Text = dgvMasraf.CurrentRow.Cells[8].Value.ToString();

            txtSeferID.Text = dgvMasraf.CurrentRow.Cells[5].Value.ToString();

            txtOtobusPlaka.Text = dgvMasraf.CurrentRow.Cells[6].Value.ToString();

            txtSoforID.Text = dgvMasraf.CurrentRow.Cells[7].Value.ToString();

            txtSoforAdi.Text = dgvMasraf.CurrentRow.Cells[8].Value.ToString();

            txtSoforSoyAd.Text = dgvMasraf.CurrentRow.Cells[9].Value.ToString();
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Otobus oto = (Entity.Otobus)cmbOtobus.SelectedItem;
            txtOtobusPlaka.Text = oto.Plaka;
            txtOtobusID.Text = Convert.ToString(oto.OtobusID);
            txtOtobusPlaka.Focus();
        }

        private void cmbOtobus_MouseHover(object sender, EventArgs e)
        {
            cmbOtobus.Width = 81;
        }

        private void cmbOtobus_MouseLeave(object sender, EventArgs e)
        {
            cmbOtobus.Width = 27;
        }

        private void cmbOtobusMasrafAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.MasrafTip masraf = (Entity.MasrafTip)cmbOtobusMasrafAdi.SelectedItem;
            txtMasrafAdi.Text = masraf.MasrafTipAdi;
            txtMasrafTipID.Text = Convert.ToString(masraf.MasrafTipID);
            txtMasrafAdi.Focus();
        }

        private void cmbOtobusMasrafAdi_MouseHover(object sender, EventArgs e)
        {
            cmbOtobusMasrafAdi.Width = 81;
        }

        private void cmbOtobusMasrafAdi_MouseLeave(object sender, EventArgs e)
        {
            cmbOtobusMasrafAdi.Width = 27;
        }

        private void cmbMasrafYapanPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Calisan calisan = (Entity.Calisan)cmbMasrafYapanPersoneller.SelectedItem;
            txtSoforAdi.Text = calisan.Ad;
            txtSoforID.Text = Convert.ToString(calisan.PersonelID);
            txtMasrafYapanPersonelID.Text = Convert.ToString(calisan.PersonelID);
            txtSoforSoyAd.Text = calisan.Soyad;
            txtSoforAdi.Focus();
        }

        private void cmbMasrafYapanPersoneller_MouseHover(object sender, EventArgs e)
        {
            cmbMasrafYapanPersoneller.Width = 81;
        }

        private void cmbMasrafYapanPersoneller_MouseLeave(object sender, EventArgs e)
        {
            cmbMasrafYapanPersoneller.Width = 27;
        }

        private void txtSeferID_TextChanged(object sender, EventArgs e)
        {
            Face.Sefer.SeferDoldur(txtKalkisID, txtVarisID, txtSeferID);
        }

        private void txtKalkisID_TextChanged(object sender, EventArgs e)
        {
            Face.Sefer.KalkisSehirAdiGetir(txtSeferID.Text, txtKalkisSehri);

        }

        private void txtVarisID_TextChanged(object sender, EventArgs e)
        {
            Face.Sefer.VarisSehirAdiGetir(txtSeferID.Text, txtVarisSehiri);
        }

        private void BtnFormAc_Click(object sender, EventArgs e)
        {
            string gonderilenID = txtMasrafTipID.Text;
            MasrafTipIslemleri.MasrafTipDetayGor frm = new MasrafTipIslemleri.MasrafTipDetayGor(gonderilenID);
            frm.ShowDialog();
        }
        private void Temizle()
        {
            txtOtobusID.Clear();
            txtOtobusMasrafID.Clear();
            txtOtobusPlaka.Clear();
            txtMasrafTipID.Clear();
            txtMasrafTutari.Clear();
            txtMasrafAdi.Clear();
            txtSoforID.Clear();
            txtSoforAdi.Clear();
            txtMasrafYapanPersonelID.Clear();
            txtSoforSoyAd.Clear();
            txtKalkisSehri.Clear();
            txtKalkisID.Clear();
            txtVarisID.Clear();
            txtVarisSehiri.Clear();
            txtSeferID.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtOtobusMasrafID.Text == "" || txtOtobusID.Text == "" || txtMasrafTipID.Text == "" || txtMasrafTutari.Text == "" || txtMasrafYapanPersonelID.Text == "" || txtSeferID.Text == "")
            {
                MessageBox.Show("OtobusMasrafı Bilgileri Eklenemedi OtobusMasrafID,OtobusID,MasrafTipi,MasrafTutari,MasrafYapanPersonel ve SeferID bilgilerini eksik bırakmayınız!", "DİKKAT! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Entity.OtobusMasraf otoms = new Entity.OtobusMasraf();
                otoms.OtobusMasrafID = Convert.ToInt32(Face.Kontrol.Temizle(txtOtobusMasrafID.Text));
                otoms.OtobusID = Convert.ToInt32(Face.Kontrol.Temizle(txtOtobusID.Text));
                otoms.MasrafipID = Convert.ToInt32(Face.Kontrol.Temizle(txtMasrafTipID.Text));
                otoms.Tutar = Convert.ToDecimal(Face.Kontrol.Temizle(txtMasrafTutari.Text));
                otoms.MasrafYapanPersonelID = Convert.ToInt32(Face.Kontrol.Temizle(txtMasrafYapanPersonelID.Text));
                otoms.SeferID = Convert.ToInt32(Face.Kontrol.Temizle(txtSeferID.Text));
                int etkilenensatir = Face.OtobusMasraf.OtobusMasrafGuncelle(otoms);
                if (etkilenensatir > 0)
                {
                    MessageBox.Show("OtobusMasraflari   Güncellendi!");
                    Face.Otobus.OtobusPlakaGetir(cmbOtobus);
                    Face.MasrafTip.MasrafTipiGetir(cmbOtobusMasrafAdi);
                    Face.Calisan.CalisanAdiGetir(cmbMasrafYapanPersoneller);
                    Face.Sefer.SeferDoldur(txtKalkisID, txtVarisID, txtSeferID);
                    ds = Face.OtobusMasraf.OtobusMasrafListeleGrd();
                    dgvMasraf.DataSource = ds.Tables["OtoMasrafGor"];
                    btnEkle.Enabled = false;
                    btnYeni.Enabled = true;
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                    Temizle();

                }
                else
                {
                    MessageBox.Show("OtobusMasraflari Güncelenemedi!");
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = true; ;
            btnSil.Enabled = true;
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ( txtOtobusID.Text == "" || txtMasrafTipID.Text == "" || txtMasrafTutari.Text == "" || txtMasrafYapanPersonelID.Text == "" || txtSeferID.Text == "")
            {
                MessageBox.Show("OtobusMasrafı Bilgileri Eklenemedi ,OtobusID,MasrafTipi,MasrafTutari,MasrafYapanPersonel ve SeferID bilgilerini eksik bırakmayınız!", "DİKKAT! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Entity.OtobusMasraf otoms = new Entity.OtobusMasraf();
                otoms.OtobusID = Convert.ToInt32(Face.Kontrol.Temizle(txtOtobusID.Text));
                otoms.MasrafipID = Convert.ToInt32(Face.Kontrol.Temizle(txtMasrafTipID.Text));
                otoms.Tutar = Convert.ToDecimal(Face.Kontrol.Temizle(txtMasrafTutari.Text));
                otoms.MasrafYapanPersonelID = Convert.ToInt32(Face.Kontrol.Temizle(txtMasrafYapanPersonelID.Text));
                otoms.SeferID = Convert.ToInt32(Face.Kontrol.Temizle(txtSeferID.Text));
                int etkilenensatir = Face.OtobusMasraf.OtobusMasrafEkle(otoms);
                if (etkilenensatir > 0)
                {
                    MessageBox.Show("Otobus Masraf  Bilgileri Eklendi!");
                    Face.Otobus.OtobusPlakaGetir(cmbOtobus);
                    Face.MasrafTip.MasrafTipiGetir(cmbOtobusMasrafAdi);
                    Face.Calisan.CalisanAdiGetir(cmbMasrafYapanPersoneller);
                    Face.Sefer.SeferDoldur(txtKalkisID, txtVarisID, txtSeferID);
                    ds = Face.OtobusMasraf.OtobusMasrafListeleGrd();
                    dgvMasraf.DataSource = ds.Tables["OtoMasrafGor"];
                    btnEkle.Enabled = false;
                    btnYeni.Enabled = true;
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                    Temizle();

                }
                else
                {
                    MessageBox.Show("OtobusMasraf Bilgileri Eklenemedi");
                }
            }
        }

        private void cmbSefer_MouseHover(object sender, EventArgs e)
        {
            cmbSefer.Width = 87;

        }

        private void cmbSefer_MouseLeave(object sender, EventArgs e)
        {
            cmbSefer.Width = 27;
        }

        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sefer sf = (Entity.Sefer)cmbSefer.SelectedItem;
            txtSeferID.Text = Convert.ToString(sf.SeferID);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOtobusMasrafID.Text == "" || txtOtobusID.Text == "" || txtMasrafTipID.Text == "" || txtMasrafTutari.Text == "" || txtMasrafYapanPersonelID.Text == "" || txtSeferID.Text == "")
            {
                MessageBox.Show("OtobusMasrafı Bilgileri Eklenemedi OtobusMasrafID,OtobusID,MasrafTipi,MasrafTutari,MasrafYapanPersonel ve SeferID bilgilerini eksik bırakmayınız!", "DİKKAT! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(txtOtobusMasrafID.Text + "Nolu " + " Masraf Silinsin mi?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.OtobusMasraf otoms = new Entity.OtobusMasraf();
                    otoms.OtobusMasrafID = Convert.ToInt32(Face.Kontrol.Temizle(txtOtobusMasrafID.Text));
                    int etkilenensatirsayisi = Face.OtobusMasraf.OtobusMasrafSil(otoms);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("OtobusMasraf  Silindi!");
                        Face.Otobus.OtobusPlakaGetir(cmbOtobus);
                        Face.MasrafTip.MasrafTipiGetir(cmbOtobusMasrafAdi);
                        Face.Calisan.CalisanAdiGetir(cmbMasrafYapanPersoneller);
                        Face.Sefer.SeferDoldur(txtKalkisID, txtVarisID, txtSeferID);
                        ds = Face.OtobusMasraf.OtobusMasrafListeleGrd();
                        dgvMasraf.DataSource = ds.Tables["OtoMasrafGor"];
                        btnEkle.Enabled = false;
                        btnYeni.Enabled = true;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                       
                    }
                    else
                    {
                        MessageBox.Show("OtobusMasraf Bilgileri Silinemedi!");
                    }
                }
                else
                {
                    MessageBox.Show("Silme işleminden vazgeçildi!");
                }
            }
        }
    }
}
