using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class MasrafTip
    {
        #region Fields
        private int _MasrafTipID;
        private string _MasrafTipAdi;
        #endregion

        #region Properties
        public int MasrafTipID
        {
            get { return _MasrafTipID; }
            set { _MasrafTipID = value; }
        }


        public string MasrafTipAdi
        {
            get { return _MasrafTipAdi; }
            set { _MasrafTipAdi = value; }
        }
        #endregion

        #region Constructor
        public MasrafTip()
        {

        }
        public MasrafTip(int masraftipID, string masraftipadi)
        {
            this._MasrafTipID = masraftipID;
            this._MasrafTipAdi = masraftipadi;
        }
        #endregion
        public override string ToString()
        {
            return MasrafTipAdi;
        }
    }
}
