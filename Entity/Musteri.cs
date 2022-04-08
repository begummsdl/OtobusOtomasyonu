using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Musteri
    {
        #region Fileds
        private int _MusteriID;
        private string _Ad;
        private string _SoyAd;
        private string _Email;
        private string _Telefon;
        private bool _Cinsiyet;
        private DateTime _DogumTarihi;
        private int _SehirID;
        private string _Adres;
        private string _KartNumarasi;
        private bool _KartTeslimDurumu;
        private decimal _MevcutPara;
        #endregion

        #region Properties
        public int MusteriID
        {
            get { return _MusteriID; }
            set { _MusteriID = value; }
        }


        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }



        public string SoyAd
        {
            get { return _SoyAd; }
            set { _SoyAd = value; }
        }



        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }


        public bool Cinsiyet
        {
            get { return _Cinsiyet; }
            set { _Cinsiyet = value; }
        }


        public DateTime DogumTarihi
        {
            get { return _DogumTarihi; }
            set { _DogumTarihi = value; }
        }


        public int SehirID
        {
            get { return _SehirID; }
            set { _SehirID = value; }
        }


        public string Adres
        {
            get { return _Adres; }
            set { _Adres = value; }
        }


        public string KartNumarasi
        {
            get { return _KartNumarasi; }
            set { _KartNumarasi = value; }
        }


        public bool KartTeslimDurumu
        {
            get { return _KartTeslimDurumu; }
            set { _KartTeslimDurumu = value; }
        }


        public decimal MevcutPara
        {
            get { return _MevcutPara; }
            set { _MevcutPara = value; }
        }
        #endregion

        #region Constructors
        public Musteri()
        {

        }

        public Musteri(int musteriID, string ad, string soyad, string email, string telefon, bool cinsiyet, DateTime dogumtarihi, int sehirID, string adres, string kartnumarasi, bool kartteslimdurumu, decimal mevcutpara)
        {
            this._MusteriID = musteriID;
            this._Ad = ad;
            this.SoyAd = soyad;
            this._Email = email;
            this._Telefon = telefon;
            this._Cinsiyet = cinsiyet;
            this._DogumTarihi = dogumtarihi;
            this._SehirID = sehirID;
            this._Adres = adres;
            this._KartNumarasi = kartnumarasi;
            this._KartTeslimDurumu = kartteslimdurumu;
            this._MevcutPara = mevcutpara;
        }
        #endregion
    }
}
