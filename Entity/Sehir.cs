using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Sehir
    {
        #region Fields
        private int _SehirID;
        private string _SehirAdi;
        
        #endregion

        #region Properties
        public int SehirID
        {
            get { return _SehirID; }
            set { _SehirID = value; }
        }
        public string SehirAdi
        {
            get { return _SehirAdi; }
            set { _SehirAdi = value; }
        } 
        #endregion

        #region Constructor
        public Sehir()
        {

        }
        public Sehir(int sehirID, string sehirAdi)
        {
            this._SehirID = sehirID;
            this._SehirAdi = sehirAdi;
        } 
        #endregion

        public override string ToString()
        {
            return SehirAdi;
        }

    }
}
