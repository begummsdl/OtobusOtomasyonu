using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.SubeIslemleri
{
    public partial class FrmSubeIslemleri : Form
    {
        public FrmSubeIslemleri()
        {
            InitializeComponent();
        }

        private void FrmSubeIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 80;
            Face.Sube.SubeListesi(lsvSube);
            txtListenenKayitSayisi.Text = Convert.ToString(lsvSube.Items.Count);
            grpSube.Visible = false;
            Face.Sube.Subelistele(cmbSubler);
            Face.Sehir.sehirListele(cmbSehir);
            btnGuncelle.Enabled = false;
        }

        private void lsvSube_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem li = lsvSube.SelectedItems[0];
            FrmSubeDetay frm = new FrmSubeDetay(li.Text);
            frm.Show();

        }

        private void cmbSubler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sube sube = (Entity.Sube)cmbSubler.SelectedItem;
            txtSubeID.Text = Convert.ToString(sube.SubeID);
            txtSubeAdi.Text = sube.SubeAdi;
            txtSehirAdi.Focus();
            txtSubeAdi.ReadOnly = false;
            btnGuncelle.Enabled = true;
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sehir sh = (Entity.Sehir)cmbSehir.SelectedItem;
            txtSehirID.Text = Convert.ToString(sh.SehirID);
            txtSehirAdi.Text = Convert.ToString(sh.SehirAdi);
            txtSehirAdi.Focus();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtSehirAdi.Clear();
            txtSehirID.Clear();
            txtEklenecekSube.Clear();
            txtArananSube.Clear();
            txtSubeID.Text = "";
            txtSubeAdi.Clear();
        }

        private void txtArananSube_TextChanged(object sender, EventArgs e)
        {
            Face.Sube.SubeAra(lsvSube, txtArananSube.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            grpSube.Visible = true; lblBilgi.Text = "Eklenecek Şube Adi Giriniz :";
            if (txtEklenecekSube.Text == "" || cmbSehir.SelectedItem.ToString() == "")
            {
                lblUyari.Text = "Uyari Şube Ekleyebilmek İçin Öncelikle Şehir Seçiniz ve BoşGeçmeyiniz!";
            }
            else
            {
                bool sonuc = Face.Sube.SubeVarmi(txtEklenecekSube.Text);
                if (sonuc)
                {
                    MessageBox.Show("Var Olan Bir Şubeyi Eklemek İstemektesiniz");
                }
                else
                {
                    Entity.Sube sb = new Entity.Sube();
                    sb.SubeAdi = Face.Kontrol.Temizle(txtEklenecekSube.Text);
                    sb.SehirID = Convert.ToInt32(Face.Kontrol.Temizle(txtSehirID.Text));

                    int etkilenensatirsayisi = Face.Sube.SubeEkle(sb);
                    if (etkilenensatirsayisi > 0)
                    {
                        MessageBox.Show("Şube ekleme işlemi başarılı");
                        Face.Sehir.sehirListele(cmbSehir);
                        Face.Sube.Subelistele(cmbSubler);
                        Face.Sube.SubeListesi(lsvSube);
                        txtListenenKayitSayisi.Text = Convert.ToString(lsvSube.Items.Count);
                        btnEkle.Enabled = false;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Şube Ekleme İşlemleri Sırasında Hata Meydana Geldi");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSubeAdi.Text == "" || txtSehirID.Text == "")
            {
                MessageBox.Show("Şube Güncelemek İçin Sehir ve Şube Seçilmelidir", "Uayari Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Entity.Sube sb = new Entity.Sube();
                sb.SubeID = Convert.ToInt32(txtSubeID.Text);
                sb.SehirID = Convert.ToInt32(txtSehirID.Text);
                sb.SubeAdi = Face.Kontrol.Temizle(txtSubeAdi.Text);
                int etkiklenensatirsayisi = Face.Sube.SubeGuncelle(sb);
                if (etkiklenensatirsayisi > 0)
                {
                    MessageBox.Show("şube İşlemleri Başarılı");
                    Face.Sube.SubeListesi(lsvSube);
                    Face.Sube.Subelistele(cmbSubler);
                    Face.Sehir.sehirListele(cmbSehir);
                    btnGuncelle.Enabled = false;
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    btnYeni.Enabled = true;
                    Temizle();
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtSubeAdi.Text == "")
            {
                MessageBox.Show("Şube Silebilmek İçin Mevcut Şubelerden Seçim Yapınız", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Silinsin Mi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entity.Sube sb = new Entity.Sube();
                    sb.SubeID = Convert.ToInt32(txtSubeID.Text);
                    int etkilenensayisi = Face.Sube.SubeSil(sb);
                    if (etkilenensayisi > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");
                        Face.Sube.SubeListesi(lsvSube);
                        Face.Sube.Subelistele(cmbSubler);
                        Face.Sehir.sehirListele(cmbSehir);
                        btnGuncelle.Enabled = false;
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemleri Sırasında Bir Hata Meydana Geldi");
                    }

                }
                else
                {
                    MessageBox.Show("Silme İşleminden Vazgecildi");
                }
            }
        }
    }
}
