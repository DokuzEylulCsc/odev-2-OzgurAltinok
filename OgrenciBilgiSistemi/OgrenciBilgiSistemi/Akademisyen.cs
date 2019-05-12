using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal abstract class Akademisyen
    {
        string isim;
        string soyIsim;
        string brans;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public string Brans { get => brans; set => brans = value; }
    }
}
