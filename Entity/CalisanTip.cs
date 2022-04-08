using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class CalisanTip
    {
        #region Fields
        private int _CalisanTipID;
        private string _CalisanTipAdi;
        #endregion

        #region Properties
        public int CalisanTipID
        {
            get { return _CalisanTipID; }
            set { _CalisanTipID = value; }
        }

        public string CalisanTipAdi
        {
            get { return _CalisanTipAdi; }
            set { _CalisanTipAdi = value; }
        }
        #endregion

        #region Constructor
        public CalisanTip()
        {

        }
        public CalisanTip(int calisantipID, string calisantipadi)
        {
            this._CalisanTipID = calisantipID;
            this._CalisanTipAdi = calisantipadi;
        }
        #endregion
     
        public override string ToString()
        {
            return CalisanTipAdi;
        }
    }
}
