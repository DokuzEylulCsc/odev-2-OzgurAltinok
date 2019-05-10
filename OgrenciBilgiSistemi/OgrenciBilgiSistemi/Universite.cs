using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Universite
    {
        IList<Fakulte> fakulteler;

        public IList<Fakulte> Fakulteler { get => fakulteler; set => fakulteler = value; }
    }
}
