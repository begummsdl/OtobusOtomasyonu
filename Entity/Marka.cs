using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Marka
    {
        #region Fields
        private int _MarkaID;
        private string _MarkaAdi;

        #endregion

        #region Properties
        public int MarkaID
        {
            get { return _MarkaID; }
            set { _MarkaID = value; }
        }


        public string MarkaAdi
        {
            get { return _MarkaAdi; }
            set { _MarkaAdi = value; }
        }
        #endregion

        #region Constructor
        public Marka()
        {

        }
        public Marka(int markaID, string markaAdi)
        {
            this._MarkaID = markaID;
            this._MarkaAdi = markaAdi;
        }
        #endregion
        public override string ToString()
        {
            return MarkaAdi;
        }
    }
}
