using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    partial class BolumEkrani : Form
    {
        Bolum bolum = new Bolum();
        Ders ders_ = new Ders();
        List<OgretimElemani> ogretimElemaniBolumEkrani = new List<OgretimElemani>();
        List<Ogrenci> ogrenciBolumEkrani = new List<Ogrenci>();
        List<Ders> dersBolumEkrani = new List<Ders>();

        public BolumEkrani(string isim, Bolum bol)
        {
            InitializeComponent();

            //Fakulteye onceden eklenen bir bolume erismemiz icin
            //Aksihalde yeni baska bir bolum nesnesine ekler.
            Bolum = bol;

            //Bolum ismini yazdirmak icin.
            BolumName.Text = isim.ToUpper() + " BÖLÜMÜ";
        }

        internal Bolum Bolum { get => bolum; set => bolum = value; }
        internal List<OgretimElemani> OgretimElemaniBolumEkrani { get => ogretimElemaniBolumEkrani; set => ogretimElemaniBolumEkrani = value; }
        internal List<Ogrenci> OgrenciBolumEkrani { get => ogrenciBolumEkrani; set => ogrenciBolumEkrani = value; }
        internal List<Ders> DersBolumEkrani { get => dersBolumEkrani; set => dersBolumEkrani = value; }
        internal Ders Ders_ { get => ders_; set => ders_ = value; }

        private void OgrGorevliEkleButon_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            HocaListesi.Items.Clear();

            //Bolume eklenecek bir ogretim gorevlisi nesnesi olustur.
            OgretimElemani ogrEl = new OgretimElemani(OgrGorIsim.Text, OgrGorSoyIsim.Text, OgrGorBrans.Text);

            //Listeye ekle
            OgretimElemaniBolumEkrani.Add(ogrEl);

            //Bolum nesnesine ekle
            Bolum.OgretimElemaniEkle(ogrEl);

            //Listbox'a yazdir.
            for (int i = 0; i < Bolum.OgretimElemanlari.Count; i++)
            {
                HocaListesi.Items.Add(Bolum.OgretimElemanlari[i].Isim + " - " + Bolum.OgretimElemanlari[i].SoyIsim);
            }

            //Textbox'lari nesne ekledikten sonra sildim
            OgrGorIsim.Text = "";
            OgrGorSoyIsim.Text = "";
            OgrGorBrans.Text = "";
        }

        private void OgrGorevliSilButon_Click(object sender, EventArgs e)
        {
            // tiklanan list item'inden nesneye erismem gerekiyordu
            // zaman ayiramadim
            //Bolum.OgretimElemaniSil();
        }

        private void OgrenciSilButon_Click(object sender, EventArgs e)
        {
            // tiklanan list item'inden nesneye erismem gerekiyordu
            // zaman ayiramadim
            //Bolum.OgrencininBolumdenKaydiniSil();
        }

        private void DersEkleButon_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            DersListesi.Items.Clear();

            //Bolume eklenecek bir ders nesnesi olustur.
            Ders ders = new Ders(DersIsim.Text, DersDonem.Text);
            
            //Bolum'un icindeki Ders nesnesini class icinde global olarak kullanmak icin
            Ders_ = ders;

            //Listeye ekle
            DersBolumEkrani.Add(ders);

            //Bolum nesnesine ekle
            Bolum.DersEkle(ders);

            //Listbox'a yazdir.
            for (int i = 0; i < Bolum.Dersler.Count; i++)
            {
                DersListesi.Items.Add(Bolum.Dersler[i].DersIsim + " - " + Bolum.Dersler[i].DersDonemi);
            }

            //Textbox'lari nesne ekledikten sonra sildim
            DersIsim.Text = "";
            DersDonem.Text = "";
        }

        private void DersSilButon_Click(object sender, EventArgs e)
        {
            // tiklanan list item'inden nesneye erismem gerekiyordu
            // zaman ayiramadim

            //Bolum.DersSil();
        }

        private void YLOgrenciEkleButon_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            OgrenciListesi.Items.Clear();

            //Bolume eklenecek bir ogrenci nesnesi olustur.
            YuksekLisansOgrenci lisansOgr = new YuksekLisansOgrenci(OgrIsim.Text, OgrSoyIsim.Text, OgrBolum.Text, System.Convert.ToInt32(OgrSinif.Text), System.Convert.ToChar(OgrSube.Text));

            //Listeye ekle
            OgrenciBolumEkrani.Add(lisansOgr);

            //Bolum nesnesine ekle
            Bolum.OgrenciyiBolumeKayitEt(lisansOgr);

            //Listbox'a yazdir.
            for (int i = 0; i < Bolum.Ogrenciler.Count; i++)
            {
                OgrenciListesi.Items.Add(Bolum.Ogrenciler[i].Isim + " - " + Bolum.Ogrenciler[i].SoyIsim);
            }

            //Textbox'lari nesne ekledikten sonra sildim
            OgrIsim.Text = "";
            OgrSoyIsim.Text = "";
            OgrBolum.Text = "";
            OgrSinif.Text = "";
            OgrSube.Text = "";
        }

        private void DOgrenciEkleButon_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            OgrenciListesi.Items.Clear();

            //Bolume eklenecek bir ogrenci nesnesi olustur.
            DoktoraOgrenci lisansOgr = new DoktoraOgrenci(OgrIsim.Text, OgrSoyIsim.Text, OgrBolum.Text, System.Convert.ToInt32(OgrSinif.Text), System.Convert.ToChar(OgrSube.Text));

            //Listeye ekle
            OgrenciBolumEkrani.Add(lisansOgr);

            //Bolum nesnesine ekle
            Bolum.OgrenciyiBolumeKayitEt(lisansOgr);

            //Listbox'a yazdir.
            for (int i = 0; i < Bolum.Ogrenciler.Count; i++)
            {
                OgrenciListesi.Items.Add(Bolum.Ogrenciler[i].Isim + Bolum.Ogrenciler[i].SoyIsim);
            }

            //Textbox'lari nesne ekledikten sonra sildim
            OgrIsim.Text = "";
            OgrSoyIsim.Text = "";
            OgrBolum.Text = "";
            OgrSinif.Text = "";
            OgrSube.Text = "";
        }

        private void LOgrenciEkleButon_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            OgrenciListesi.Items.Clear();

            //Bolume eklenecek bir ogrenci nesnesi olustur.
            LisansOgrenci lisansOgr = new LisansOgrenci(OgrIsim.Text, OgrSoyIsim.Text, OgrBolum.Text, System.Convert.ToInt32(OgrSinif.Text), System.Convert.ToChar(OgrSube.Text));

            //Listeye ekle
            OgrenciBolumEkrani.Add(lisansOgr);

            //Bolum nesnesine ekle
            Bolum.OgrenciyiBolumeKayitEt(lisansOgr);

            //Listbox'a yazdir.
            for (int i = 0; i < Bolum.Ogrenciler.Count; i++)
            {
                OgrenciListesi.Items.Add(Bolum.Ogrenciler[i].Isim + Bolum.Ogrenciler[i].SoyIsim);
            }

            //Textbox'lari nesne ekledikten sonra sildim
            OgrIsim.Text = "";
            OgrSoyIsim.Text = "";
            OgrBolum.Text = "";
            OgrSinif.Text = "";
            OgrSube.Text = "";
        }

        private void DersListesi_SelectedValueChanged(object sender, EventArgs e)
        {
            //Secilen listbox item'ini tutmak icin.
            //Ref: https://www.codeproject.com/Questions/348044/mouseclick-event-on-listbox-item-in-csharp-visual
            ListBox secilenDers = (ListBox)sender;

            //Spesifik bolum icin bir constructor
            DersEkrani dersEkrani = new DersEkrani(secilenDers.SelectedItem.ToString(), Ders_);
            dersEkrani.Show();
        }
    }
}
