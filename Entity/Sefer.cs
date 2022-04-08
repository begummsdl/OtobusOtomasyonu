using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Sefer
    {
        #region Fields
        private int _SeferID;
        private int _KalkisSehirID;
        private int _VarisSehirID;
        private int _OtobusID;
        private int _SoforID;
        private int _MuavinID;
        private DateTime _KalkisZamani;
        private DateTime _VarisZamani;
        private byte _TahminiSure;
        private decimal _BiletTutari;
        #endregion

        #region Properties
        public int SeferID
        {
            get { return _SeferID; }
            set { _SeferID = value; }
        }
        public int KalkisSehirID
        {
            get { return _KalkisSehirID; }
            set { _KalkisSehirID = value; }
        }
        public int VarisSehirID
        {
            get { return _VarisSehirID; }
            set { _VarisSehirID = value; }
        }
        public int OtobusID
        {
            get { return _OtobusID; }
            set { _OtobusID = value; }
        }
        public int SoforID
        {
            get { return _SoforID; }
            set { _SoforID = value; }
        }
        public int MuavinID
        {
            get { return _MuavinID; }
            set { _MuavinID = value; }
        }
        public DateTime KalkisZamani
        {
            get { return _KalkisZamani; }
            set { _KalkisZamani = value; }
        }
        public DateTime VarisZamani
        {
            get { return _VarisZamani; }
            set { _VarisZamani = value; }
        }
        public byte TahminiSure
        {
            get { return _TahminiSure; }
            set { _TahminiSure = value; }
        }
        public decimal BiletTutari
        {
            get { return _BiletTutari; }
            set { _BiletTutari = value; }
        }
        #endregion
        #region Constructor
        public Sefer()
        {

        }
        public Sefer(int seferID, int KalkisSehirID, int varisSehirID, int otobusID, int soforID, int muavinID, DateTime kalkiszamani, DateTime variszamani, byte tahminisure, decimal bilettutari)
        {
            this._SeferID = seferID;
            this._KalkisSehirID = KalkisSehirID; this._VarisSehirID = varisSehirID; this._OtobusID = otobusID; this._SoforID = soforID; this._MuavinID = muavinID; this._KalkisZamani = kalkiszamani; this._VarisZamani = variszamani; this._TahminiSure = tahminisure; this._BiletTutari = bilettutari;
        } 
        #endregion
        public override string ToString() // Buna Bakılacak Amac Seferler tablosunda Tüm İşlemlerin SeferID'ye göre Olması
        {
            return SeferID.ToString();
        }
    }
}
