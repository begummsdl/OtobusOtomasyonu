using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Otobus
    {
        private int _OtobusID;

        public int OtobusID
        {
            get { return _OtobusID; }
            set { _OtobusID = value; }
        }
        private string _Plaka;

        public string Plaka
        {
            get { return _Plaka; }
            set { _Plaka = value; }
        }
        private byte _KoltukSayisi;

        public byte KoltukSayisi
        {
            get { return _KoltukSayisi; }
            set { _KoltukSayisi = value; }
        }
        private int _MarkaID;

        public int MarkaID
        {
            get { return _MarkaID; }
            set { _MarkaID = value; }
        }
        private bool _AktifMi;

        public bool AktifMi
        {
            get { return _AktifMi; }
            set { _AktifMi = value; }
        }
        public Otobus()
        {

        }
        public Otobus(int otobusID,string plaka,byte koltuksayisi, int markaID,bool aktifmi)
        {
            this._OtobusID = otobusID;
            this._Plaka = plaka;
            this._KoltukSayisi = koltuksayisi;
            this._MarkaID = markaID;
            this._AktifMi = aktifmi;
        }
        public override string ToString()
        {
            return Plaka;
        }
    }
}
