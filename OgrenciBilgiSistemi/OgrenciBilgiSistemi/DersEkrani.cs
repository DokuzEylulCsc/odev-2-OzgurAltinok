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
    partial class DersEkrani : Form
    {
        Ders ders = new Ders();

        public DersEkrani(string isim, Ders myDers)
        {
            InitializeComponent();

            Ders = myDers;

            DersName.Text = isim.ToUpper() + " DERSİ";
        }

        

        internal Ders Ders { get => ders; set => ders = value; }

        private void JsonKaydetButton_Click(object sender, EventArgs e)
        {
            Ders.JsonKaydet();
        }
    }
}
