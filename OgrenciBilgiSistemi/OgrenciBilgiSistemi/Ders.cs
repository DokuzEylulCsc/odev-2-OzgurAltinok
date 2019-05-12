using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ders
    {
        private List<Ogrenci> ogrenciler = new List<Ogrenci>();
        private OgretimElemani ogretimElemani = new OgretimElemani();
        private Asistan asistanHoca = new Asistan();
        private string dersDonemi;

        internal List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
        internal OgretimElemani OgretimElemani { get => ogretimElemani; set => ogretimElemani = value; }
        internal Asistan AsistanHoca { get => asistanHoca; set => asistanHoca = value; }
        public string DersDonemi { get => dersDonemi; set => dersDonemi = value; }

        internal void OgretimElemaniAta(OgretimElemani hoca)
        {
            OgretimElemani = hoca;
        }

        internal void OgretimElemaniGuncelle(OgretimElemani hoca)
        {
            //serialize-deserialize kullanabilirsin.(JSON)
            OgretimElemani = hoca;
        }

        internal void OgrenciEkle(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
        }

        internal void OgrenciSil(Ogrenci ogrenci)
        {
            Ogrenciler.Remove(ogrenci);
        }
    }
}
