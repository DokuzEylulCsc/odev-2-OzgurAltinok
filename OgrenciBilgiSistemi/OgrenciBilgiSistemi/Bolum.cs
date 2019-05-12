using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Bolum
    {
        string isim;
        List<Ders> dersler = new List<Ders>();
        List<Sube> subeler = new List<Sube>();
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();

        public List<Ders> Dersler { get => dersler; set => dersler = value; }
        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
        public string Isim { get => isim; set => isim = value; }
        public List<OgretimElemani> OgretimElemanlari { get => ogretimElemanlari; set => ogretimElemanlari = value; }

        internal Bolum(string bolumIsim)
        {
            Isim = bolumIsim;
        }

        internal void OgrenciyiBolumeKayitEt(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
        }

        internal void OgrencininBolumdenKaydiniSil(Ogrenci ogrenci)
        {
            Ogrenciler.Remove(ogrenci);
        }

        internal void OgrencileriListele()
        {
            //Iterator design pattern ekle.
            for (int i = 0; i < Ogrenciler.Count; i++)
                Console.WriteLine(Ogrenciler[i].Isim);
        }

        internal void OgretimElemaniEkle(OgretimElemani ogretimElemani)
        {
            OgretimElemanlari.Add(ogretimElemani);
        }

        internal void OgretimElemaniSil(OgretimElemani ogretimElemani)
        {
            OgretimElemanlari.Remove(ogretimElemani);
        }

        internal void DersEkle(Ders ders)
        {
            Dersler.Add(ders);
        }

        internal void DersSil(Ders ders)
        {
            Dersler.Remove(ders);
        }
    }
}
