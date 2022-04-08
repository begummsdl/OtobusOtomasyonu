using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
  public  class PersonelGirisCikis
    {
        #region Fields
        private int _PersonelIslemID;
        private int _PersonelID;
        private DateTime _IslemZamani;
        private bool _IslemTipi;
        #endregion

        #region Properties
        public int PersonelIslemID
        {
            get { return _PersonelIslemID; }
            set { _PersonelIslemID = value; }
        }


        public int PersonelID
        {
            get { return _PersonelID; }
            set { _PersonelID = value; }
        }


        public DateTime IslemZamani
        {
            get { return _IslemZamani; }
            set { _IslemZamani = value; }
        }


        public bool IslemTipi
        {
            get { return _IslemTipi; }
            set { _IslemTipi = value; }
        }
        #endregion

        #region Constructors
        public PersonelGirisCikis()
        {

        }
        public PersonelGirisCikis(int personelislemID, int personelID, DateTime islemzamani, bool islemtipi)
        {
            this._PersonelIslemID = personelislemID;
            this._PersonelID = personelID;
            this._IslemZamani = islemzamani;
            this._IslemTipi = islemtipi;

        }
        #endregion
    }
}
