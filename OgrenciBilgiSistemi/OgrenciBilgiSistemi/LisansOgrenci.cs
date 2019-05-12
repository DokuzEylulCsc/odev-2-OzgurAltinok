using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class LisansOgrenci : Ogrenci
    {
        internal LisansOgrenci(string isim)
        {
            Isim = isim;
            OgrenimSeviyesi = this.GetType().Name;
        }
    }
}
