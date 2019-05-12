using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    abstract class Ogrenci
    {
        string isim;
        string soyIsim;
        string ogrBolum;
        int sinif;
        char sube;
        string ogrenimSeviyesi;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public string OgrBolum { get => ogrBolum; set => ogrBolum = value; }
        public int Sinif { get => sinif; set => sinif = value; }
        public char Sube { get => sube; set => sube = value; }
        public string OgrenimSeviyesi { get => ogrenimSeviyesi; set => ogrenimSeviyesi = value; }
    }
}
