using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Sube
    {
        #region genelAciklama
        /*
        Her Tabloya Karşılık Gelecek Bir Class Bu Class Her Sutuna Karşılık Gelecek
       * Bir Property Oluşturacagız.
       * Nesneye Daha Sonra Değer Atamak ve Sadece İstenilen Property 'i kullanabilmek için
       * Boş bir Constructor olusturayacağız
       * Bunun Haricinde Tek satırda bir nesneye deger atayabilmek için her property karşılık
       * gelen bir parametre alan bir constructor yazacağız.Böylece tek bir satırda nesneye deger             Atamış olacağız
       * Son Olarak class isimlerimiz Tekil olması kod yazarken daha kısa kod yazmayı sağlayacak
       * Aynı Zamanda normalde yapmadığım bir sey olan bu kadar uzun ve çok yorum satırları koymak
       * web ve windows tarafında uygulamanın servere gidip gelme süresini uzatmaktadır.
       
       */

        #endregion

        #region Fields

        private int _SubeID;
        private int _SehirID;
        private string _SubeAdi; 
        #endregion

        #region Properties
        public int SubeID
        {
            get { return _SubeID; }
            set { _SubeID = value; }
        }
        public int SehirID
        {
            get { return _SehirID; }
            set { _SehirID = value; }
        }
        public string SubeAdi
        {
            get { return _SubeAdi; }
            set { _SubeAdi = value; }
        } 
        #endregion

        #region Constructor
        public Sube()
        {

        }

        public Sube(int subeID, int sehirID, string subeAdi)
        {
            this._SubeID = subeID;
            this._SehirID = sehirID;
            this._SubeAdi = subeAdi;
        } 
        #endregion

        public override string ToString()
        {
            return SubeAdi;
        }
        
    }
}
