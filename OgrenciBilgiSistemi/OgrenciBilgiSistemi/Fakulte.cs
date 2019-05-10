using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Fakulte
    {
        List<Ders> dersler;
        List<Sube> subeler;
        List<Ogrenci> ogrenciler;
        List<Bolum> bolumler;

        public List<Ders> Dersler { get => dersler; set => dersler = value; }
        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
        public List<Bolum> Bolumler { get => bolumler; set => bolumler = value; }
    }
}
