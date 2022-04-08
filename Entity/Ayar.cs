using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Ayar
    {
        /*
         Bu clas veri tabanımda tanımlamış olduğumuz %10 geri ödeme kuralı ile alakalı 
         * işlemler ilerleyen bölümde yazılacak trigger yardımıyla yapılacak
         */

        #region Fields
        private int _AyarID;
        private string _Anahtar;
        private string _Deger;
        #endregion

        #region Properties
        public int AyarID
        {
            get { return _AyarID; }
            set { _AyarID = value; }
        }


        public string Anahtar
        {
            get { return _Anahtar; }
            set { _Anahtar = value; }
        }


        public string Deger
        {
            get { return _Deger; }
            set { _Deger = value; }
        }
        #endregion
        #region Constructor
        public Ayar()
        {

        }
        public Ayar(int ayarID, string anahtar, string deger)
        {
            this._AyarID = ayarID;
            this._Anahtar = anahtar;
            this._Deger = deger;
        }
        #endregion
    }
}
