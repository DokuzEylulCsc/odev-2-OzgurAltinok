using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Sube
    {
        OgretimElemani Hoca;
        List<Ogrenci> ogrenciler;

        public OgretimElemani Hoca1 { get => Hoca; set => Hoca = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
    }
}
