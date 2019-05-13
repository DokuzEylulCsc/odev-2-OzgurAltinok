using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OgrenciBilgiSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ders ders = new Ders("yapay zeka", "2016-2017");

            //OgretimElemani hoca = new OgretimElemani("kerem", "alisik", "mat");
            //hoca.Isim = "mahmut";

            //ders.OgretimElemaniAta(hoca);

            //LisansOgrenci ogrenci = new LisansOgrenci("mehmet");
            //ders.OgrenciEkle(ogrenci);
            //ders.OgrenciEkle(new DoktoraOgrenci("isil"));
            //ders.OgrenciEkle(new LisansOgrenci("ekrem"));
            //ders.OgrenciEkle(new LisansOgrenci("kerem"));


            //Console.WriteLine(ders.OgretimElemani.Isim);
            //ders.DerseKayitliOgrencileriListele();
            //ders.JsonKaydet();

            //Console.ReadKey();

            //Form olarak kullanildiginda eksikler var ancak, diger tum fonksiyonlarin
            //sorunsuz calisiyor, odev iceriginde GUI,UI yapilmasini istenmedigi icin
            //Form tasarlamakla ugrasmamistim, ancak sinifta digerlerinin yaptigini
            //fark edip son gunde form tasarlayabildim, bu sebeple Form'un eksikleri var.

            //Form'da list box'a eklenen item'lerden yeni form'lara su sirayla ulasilabilir.
            //
            // Universite > FakultelerListesiItemi > FakulteEkrani >BolumlerListesiItemi > DerslerListesiItemi

            Application.Run(new UniversiteEkrani());
        }
    }
}
