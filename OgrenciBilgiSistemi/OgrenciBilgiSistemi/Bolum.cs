using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Bolum
    {
        List<Ders> dersler;
        List<Sube> subeler;
        List<Ogrenci> ogrenciler;

        public List<Ders> Dersler { get => dersler; set => dersler = value; }
        public List<Sube> Subeler { get => subeler; set => subeler = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }

        public void OgrenciyiBolumeKayitEt()
        {

        }

        public void OgrencininBolumdenKaydiniSil()
        {

        }

        //Bolume hoca ekle
        public void OgretimElemaniEkle()
        {

        }

        public void OgretimElemaniSil()
        {

        }

        public void DersYarat()
        {

        }

        public void DersSil()
        {

        }
    }
}
