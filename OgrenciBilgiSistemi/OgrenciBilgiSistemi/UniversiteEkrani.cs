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
    public partial class UniversiteEkrani : Form
    {
        Universite universite = new Universite();
        Fakulte fakulte = new Fakulte();

        public UniversiteEkrani()
        {
            InitializeComponent();
        }

        internal Universite Universite { get => universite; set => universite = value; }
        internal Fakulte Fakulte { get => fakulte; set => fakulte = value; }

        private void FakulteEkleButonu_Click(object sender, EventArgs e)
        {
            //Her eleman eklemesinde liste duzgun guncellensin diye.
            fakulteListesi.Items.Clear();

            //Universiteye eklenecek bir fakulte nesnesi olustur.
            Fakulte fak = new Fakulte(FakulteToSave.Text);

            Universite.FakulteEkle(fak);

            //Listbox'a yazdir.
            foreach (Fakulte fakulte in Universite.Fakulteler)
            {
                fakulteListesi.Items.Add(fakulte.Isim);
            }
        }

        private void fakulteListesi_SelectedValueChanged(object sender, EventArgs e)
        {
            //Secilen listbox item'ini tutmak icin.
            //Ref: https://www.codeproject.com/Questions/348044/mouseclick-event-on-listbox-item-in-csharp-visual
            ListBox secilenFakulte = (ListBox)sender;

            //Spesifik fakulte isimleri ve yarattigimiz fakulte icin bir constructor
            FakulteEkrani fakulteEkrani = new FakulteEkrani(secilenFakulte.SelectedItem.ToString(), Fakulte);
            fakulteEkrani.Show();
        }
    }
}
