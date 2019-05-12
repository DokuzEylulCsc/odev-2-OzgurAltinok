using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Universite
    {
        List<Fakulte> fakulteler = new List<Fakulte>();

        public List<Fakulte> Fakulteler { get => fakulteler; set => fakulteler = value; }

        internal void FakulteEkle(Fakulte fakulte)
        {
            Fakulteler.Add(fakulte);
        }

    }
}
