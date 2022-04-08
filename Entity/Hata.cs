using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Hata
    {
        #region Fields
        private int _HataID;
        private string _Numara;
        private string _Mesaj;
        private DateTime _Zamani;
        private string _Procedure;
        #endregion

        #region Properties
        public int HataID
        {
            get { return _HataID; }
            set { _HataID = value; }
        }


        public string Numara
        {
            get { return _Numara; }
            set { _Numara = value; }
        }


        public string Mesaj
        {
            get { return _Mesaj; }
            set { _Mesaj = value; }
        }


        public DateTime Zamani
        {
            get { return _Zamani; }
            set { _Zamani = value; }
        }


        public string Procedure
        {
            get { return _Procedure; }
            set { _Procedure = value; }
        }
        #endregion

        public Hata()
        {

        }
        public Hata(int hataID, string numara, string mesaj, DateTime zamani, string procedure)
        {
            this._HataID = hataID;
            this._Numara = numara;
            this._Mesaj = mesaj;
            this._Zamani = zamani;
            this._Procedure = procedure;
        }
    }
}
