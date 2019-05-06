using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS
{
    public class Ders
    {
        List<Sube> subeler;
        List<Ogrenci> dersiAlanOgrenciler;

        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> DersiAlanOgrenciler { get => dersiAlanOgrenciler; set => dersiAlanOgrenciler = value; }
    }
}
