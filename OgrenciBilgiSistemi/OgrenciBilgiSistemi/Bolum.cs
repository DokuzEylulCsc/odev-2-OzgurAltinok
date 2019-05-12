using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Bolum
    {
        private string isim;
        private List<Ders> dersler = new List<Ders>();
        private List<Sube> subeler = new List<Sube>();
        private List<Ogrenci> ogrenciler = new List<Ogrenci>();
        private List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();

        public List<Ders> Dersler { get => dersler; set => dersler = value; }
        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
        public string Isim { get => isim; set => isim = value; }
        public List<OgretimElemani> OgretimElemanlari { get => ogretimElemanlari; set => ogretimElemanlari = value; }

        public Bolum(string bolumIsim)
        {
            Isim = bolumIsim;
        }

        public void OgrenciyiBolumeKayitEt(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
        }

        public void OgrencininBolumdenKaydiniSil(Ogrenci ogrenci)
        {
            Ogrenciler.Remove(ogrenci);
        }

        public void OgrencileriListele()
        {
            //Iterator design pattern ekle.
            for (int i = 0; i < Ogrenciler.Count; i++)
                Console.WriteLine(Ogrenciler[i].Isim);
        }

        public void OgretimElemaniEkle(OgretimElemani ogretimElemani)
        {
            OgretimElemanlari.Add(ogretimElemani);
        }

        public void OgretimElemaniSil(OgretimElemani ogretimElemani)
        {
            OgretimElemanlari.Remove(ogretimElemani);
        }

        public void DersEkle(Ders ders)
        {
            Dersler.Add(ders);
        }

        public void DersSil(Ders ders)
        {
            Dersler.Remove(ders);
        }
    }
}
