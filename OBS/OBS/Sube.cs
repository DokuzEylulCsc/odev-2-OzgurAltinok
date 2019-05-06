using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS
{
    public class Sube
    {
        OgretimElemani hoca;
        List<Ogrenci> subeninOgrencileri;

        public OgretimElemani Hoca { get => hoca; set => hoca = value; }
        public List<Ogrenci> SubeninOgrencileri { get => subeninOgrencileri; set => subeninOgrencileri = value; }
    }
}
