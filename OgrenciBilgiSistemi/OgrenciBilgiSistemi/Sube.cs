using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Sube : Ders
    {
        char subeBilgisi;

        public char SubeBilgisi { get => subeBilgisi; set => subeBilgisi = value; }

        internal Sube(string sube_dersIsim, string sube_dersDonem, char sube) : base(sube_dersIsim, sube_dersDonem)
        {
            SubeBilgisi = sube;
        }

    }
}
