using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Fakulte
    {
        string isim;
        List<Ders> dersler = new List<Ders>();
        List<Sube> subeler = new List<Sube>();
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        List<Bolum> bolumler = new List<Bolum>();

        public string Isim { get => isim; set => isim = value; }
        public List<Ders> Dersler { get => dersler; set => dersler = value; }
        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
        public List<Bolum> Bolumler { get => bolumler; set => bolumler = value; }

        internal Fakulte(string fakulteIsim)
        {
            Isim = fakulteIsim;
        }

        internal Fakulte()
        {

        }

        internal void BolumEkle(Bolum bolum)
        {
            Bolumler.Add(bolum);
        }
    }
}
