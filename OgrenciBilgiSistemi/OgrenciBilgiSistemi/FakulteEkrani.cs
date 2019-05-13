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
    partial class FakulteEkrani : Form
    {
        Fakulte newFakulte = new Fakulte();
        Bolum newBolum = new Bolum();

        public FakulteEkrani(string isim, Fakulte fak)
        {
            InitializeComponent();

            //Universiteye onceden eklenen bir fakulte'ye erismememiz icin
            //Aksihalde yeni baska bir fakulte nesnesine ekler.
            NewFakulte = fak;

            //Fakulte ismini yazdirmak icin.
            FakulteName.Text = isim.ToUpper() + " FAKULTESİ";
        }

        internal Fakulte NewFakulte { get => newFakulte; set => newFakulte = value; }
        internal Bolum NewBolum { get => newBolum; set => newBolum = value; }

        private void BolumEkleButonu_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            bolumListesi.Items.Clear();

            //Fakulteye eklenecek bir bolum nesnesi olustur.
            NewBolum.Isim = BolumToSave.Text;

            NewFakulte.BolumEkle(NewBolum);

            //Listbox'a yazdir.
            for(int i=0;i<NewFakulte.Bolumler.Count;i++)
            {
                bolumListesi.Items.Add(NewFakulte.Bolumler[i].Isim);
            }
        }

        private void bolumListesi_SelectedValueChanged(object sender, EventArgs e)
        {
            //Secilen listbox item'ini tutmak icin.
            //Ref: https://www.codeproject.com/Questions/348044/mouseclick-event-on-listbox-item-in-csharp-visual
            ListBox secilenBolum = (ListBox)sender;

            //Spesifik bolum icin bir constructor
            BolumEkrani bolumEkrani = new BolumEkrani(secilenBolum.SelectedItem.ToString(), NewBolum);
            bolumEkrani.Show();
        }
    }
}
