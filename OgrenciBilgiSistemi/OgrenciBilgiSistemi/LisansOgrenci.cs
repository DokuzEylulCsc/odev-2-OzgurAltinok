using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class LisansOgrenci : Ogrenci
    {
        internal LisansOgrenci(string isim, string soyisim, string bolum, int sinif, char sube)
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
