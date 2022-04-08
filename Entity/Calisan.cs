using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Calisan
    {
        #region Fields
        private int _PersonelID;
        private string _Ad;
        private string _Soyad;
        private string _Telefon;
        private string _Email;
        private int _SubeID;
        private string _EvAdresi;
        private string _KullaniciAdi;
        private string _Sifre;
        private bool _Yoneticimi;
        private int _CalisaTipID;
        #endregion

        #region Properties
        public int PersonelID
        {
            get { return _PersonelID; }
            set { _PersonelID = value; }
        }


        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }


        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value; }
        }


        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }


        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public int SubeID
        {
            get { return _SubeID; }
            set { _SubeID = value; }
        }


        public string EvAdresi
        {
            get { return _EvAdresi; }
            set { _EvAdresi = value; }
        }


        public string KullaniciAdi
        {
            get { return _KullaniciAdi; }
            set { _KullaniciAdi = value; }
        }


        public string Sifre
        {
            get { return _Sifre; }
            set { _Sifre = value; }
        }


        public bool Yoneticimi
        {
            get { return _Yoneticimi; }
            set { _Yoneticimi = value; }
        }


        public int CalisaTipID
        {
            get { return _CalisaTipID; }
            set { _CalisaTipID = value; }
        }
        #endregion

        #region Constructor
        public Calisan()
        {

        }

        public Calisan(int personelID, string ad, string soyad, string telefon, string email, int subeID, string evadresi, string kullaniciadi, string sifre, bool yoneticimi, int calisantip)
        {
            this._PersonelID = personelID;
            this._Ad = ad;
            this._Soyad = soyad;
            this._Telefon = telefon;
            this._Email = email;
            this._SubeID = subeID;
            this._EvAdresi = evadresi;
            this._KullaniciAdi = kullaniciadi;
            this._Sifre = sifre;
            this._Yoneticimi = yoneticimi;
            this._CalisaTipID = calisantip;
        }
        #endregion
        public override string ToString()
        {
            return Ad;
        }
    }
}
