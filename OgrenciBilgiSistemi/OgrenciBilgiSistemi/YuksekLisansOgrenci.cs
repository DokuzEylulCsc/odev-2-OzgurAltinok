using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class YuksekLisansOgrenci : Ogrenci
    {
        internal YuksekLisansOgrenci(string isim)
        {
            Isim = isim;
            OgrenimSeviyesi = this.GetType().Name;
        }
    }
}
