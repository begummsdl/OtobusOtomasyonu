using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Bilet
    {
        #region Fileds
        private int _IslemYapanPersonelID;
        private int _YolcuID;
        private int _SeferID;
        private DateTime _IslemZamani;
        private bool _SatisMiRezervasyonMu;
        private byte _KoltukNo;
        private bool _YolcuCinsiyet;
        private string _YolcuAd;
        private string _YolcuSoyad;
        private bool _SatisTip;
        private decimal _Ucret;


        #endregion

        #region Properties
        public int IslemYapanPersonelID
        {
            get { return _IslemYapanPersonelID; }
            set { _IslemYapanPersonelID = value; }
        }


        public int YolcuID
        {
            get { return _YolcuID; }
            set { _YolcuID = value; }
        }


        public int SeferID
        {
            get { return _SeferID; }
            set { _SeferID = value; }
        }


        public DateTime IslemZamani
        {
            get { return _IslemZamani; }
            set { _IslemZamani = value; }
        }


        public bool SatisMiRezervasyonMu
        {
            get { return _SatisMiRezervasyonMu; }
            set { _SatisMiRezervasyonMu = value; }
        }


        public byte KoltukNo
        {
            get { return _KoltukNo; }
            set { _KoltukNo = value; }
        }


        public bool YolcuCinsiyet
        {
            get { return _YolcuCinsiyet; }
            set { _YolcuCinsiyet = value; }
        }


        public string YolcuAd
        {
            get { return _YolcuAd; }
            set { _YolcuAd = value; }
        }


        public string YolcuSoyad
        {
            get { return _YolcuSoyad; }
            set { _YolcuSoyad = value; }
        }


        public bool SatisTip
        {
            get { return _SatisTip; }
            set { _SatisTip = value; }
        }


        public decimal Ucret
        {
            get { return _Ucret; }
            set { _Ucret = value; }
        }
        #endregion


        #region Constructor

        public Bilet()
        {

        }
        public Bilet(int islemyapanpersonelID, int yolcuID, int seferID, DateTime islemzamani, bool satismirezervasyonmu, byte koltukno, bool yolcucinsiyet, string yolcuad, string yolcusoyad, bool satistip, decimal ucret)
        {
            this._IslemYapanPersonelID = islemyapanpersonelID;
            this._YolcuID = yolcuID;
            this._SeferID = seferID;
            this._IslemZamani = islemzamani;
            this._SatisMiRezervasyonMu = satismirezervasyonmu;
            this._KoltukNo = koltukno;
            this._YolcuCinsiyet = yolcucinsiyet;
            this._YolcuAd = yolcuad;
            this._YolcuSoyad = yolcusoyad;
            this._SatisTip = satistip;
            this._Ucret = ucret;
        }
        #endregion
    }
}
