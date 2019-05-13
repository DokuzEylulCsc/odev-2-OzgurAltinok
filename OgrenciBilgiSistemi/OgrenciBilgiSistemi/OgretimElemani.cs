using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class OgretimElemani : Akademisyen
    {
        internal OgretimElemani(string isim, string soyIsim, string brans)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            Brans = brans;
        }

        internal OgretimElemani()
        {

        }
    }
}
