using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ders ders = new Ders("yapay zeka", "2016-2017");

            OgretimElemani hoca = new OgretimElemani();
            OgretimElemani hoca2 = new OgretimElemani();
            hoca.Isim = "mahmut";
            hoca2.Isim = "elif";

            ders.OgretimElemaniAta(hoca);
            ders.OgretimElemaniGuncelle(hoca2);

            LisansOgrenci ogrenci = new LisansOgrenci("mehmet");
            ders.OgrenciEkle(ogrenci);
            ders.OgrenciEkle(new DoktoraOgrenci("isil"));
            ders.OgrenciEkle(new LisansOgrenci("ekrem"));
            ders.OgrenciEkle(new LisansOgrenci("kerem"));


            //Console.WriteLine(ders.OgretimElemani.Isim);
            //ders.DerseKayitliOgrencileriListele();
            ders.JsonKaydet();

            Console.ReadKey();
        }
    }
}
