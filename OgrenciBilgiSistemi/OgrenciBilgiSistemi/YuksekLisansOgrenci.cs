using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class YuksekLisansOgrenci : Ogrenci
    {
        internal YuksekLisansOgrenci(string isim, string soyisim, string bolum, int sinif, char sube)
        {
            Isim = isim;
            SoyIsim = soyisim;
            OgrBolum = bolum;
            Sinif = sinif;
            Sube = sube;
            OgrenimSeviyesi = this.GetType().Name;
        }
    }
}
