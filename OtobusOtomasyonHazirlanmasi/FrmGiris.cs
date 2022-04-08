using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Entity.Calisan kullanici = new Entity.Calisan();
            kullanici.KullaniciAdi = Face.Kontrol.Temizle(txtKullaniciAdi.Text);
            kullanici.Sifre = Face.Kontrol.Temizle(txtSifre.Text);

            Entity.Calisan calisanbilgi = Face.Calisan.Login(kullanici);


            if (calisanbilgi != null)
            {
                // Personlin Giris Çıkış Bilgilerini Kaydet
                Entity.PersonelGirisCikis girisbilgileri = new Entity.PersonelGirisCikis();
                girisbilgileri.PersonelID = calisanbilgi.PersonelID;
             
                girisbilgileri.IslemTipi = true;

                Face.PersonelGirisCikis.PersonelGirisCikisEkle(girisbilgileri);

                // oturum acan personeli belirle
                FrmMain.calisan = calisanbilgi;
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Kullanıcı Adi Veya Sifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 70;
        }
    }
}

