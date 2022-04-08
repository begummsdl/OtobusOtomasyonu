using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class OtobusMasraf
    {
        private int _OtobusMasrafID;

        public int OtobusMasrafID
        {
            get { return _OtobusMasrafID; }
            set { _OtobusMasrafID = value; }
        }
        private int _OtobusID;

        public int OtobusID
        {
            get { return _OtobusID; }
            set { _OtobusID = value; }
        }
        private int _MasrafipID;

        public int MasrafipID
        {
            get { return _MasrafipID; }
            set { _MasrafipID = value; }
        }

        
        private decimal _Tutar;

        public decimal Tutar
        {
            get { return _Tutar; }
            set { _Tutar = value; }
        }
        private int _MasrafYapanPersonelID;

        public int MasrafYapanPersonelID
        {
            get { return _MasrafYapanPersonelID; }
            set { _MasrafYapanPersonelID = value; }
        }
        private int _SeferID;

        public int SeferID
        {
            get { return _SeferID; }
            set { _SeferID = value; }
        }
        public OtobusMasraf()
        {

        }
        public OtobusMasraf(int otobusmasrafID,int otobusID,int masraftipID,decimal tutar,int masrafyapanpersonelID,int seferID)
        {
            this._OtobusMasrafID = otobusmasrafID;
            this._OtobusID = otobusID;
            this._MasrafipID = masraftipID;
            this._Tutar = tutar;
            this._MasrafYapanPersonelID = masrafyapanpersonelID;
            this._SeferID = seferID;
        }
    }
}
