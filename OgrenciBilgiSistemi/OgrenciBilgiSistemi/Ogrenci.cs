﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    abstract class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private string ogrBolum;
        private int sinif;
        private char sube;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public string OgrBolum { get => ogrBolum; set => ogrBolum = value; }
        public int Sinif { get => sinif; set => sinif = value; }
        public char Sube { get => sube; set => sube = value; }
    }
}
