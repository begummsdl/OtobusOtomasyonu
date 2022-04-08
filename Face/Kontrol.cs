using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Face
{
    public class Kontrol
    {
        public Kontrol()
        {

        }
        public static string Temizle(string Metin)
        {
            string gelenKelime = Metin;
            gelenKelime = gelenKelime.Replace(" ", "");
            gelenKelime = gelenKelime.Replace("'", "");
            gelenKelime = gelenKelime.Replace("?", "");
            gelenKelime = gelenKelime.Replace("[", "");
            return gelenKelime;
        }
    }
}
