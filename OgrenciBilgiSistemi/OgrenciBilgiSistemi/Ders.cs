using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OgrenciBilgiSistemi
{
    class Ders
    {
        string dersIsim;
        string dersDonemi;
        OgretimElemani ogretimElemani = new OgretimElemani();
        Asistan asistanHoca = new Asistan();
        List<Ogrenci> ogrenciler = new List<Ogrenci>();

        // Access modifier'lar public olmasi gerekiyordu cunku
        // JSON'a kaydetmemizi saglayan framework'u using' ile cagriyoruz, kendi assembly'mizde degil.
        // internal ile bile Json = JsonConvert.SerializeObject(this); bu kodu isletemeyiz. bkz: Satir: #71
        // Bu yuzden public kullandim,
        public string DersIsim { get => dersIsim; set => dersIsim = value; }
        public string DersDonemi { get => dersDonemi; set => dersDonemi = value; }
        public OgretimElemani OgretimElemani { get => ogretimElemani; set => ogretimElemani = value; }
        public Asistan AsistanHoca { get => asistanHoca; set => asistanHoca = value; }
        public List<Ogrenci> Ogrenciler { get => ogrenciler; set => ogrenciler = value; }

        internal Ders(string dersIsim, string donem)
        {
            DersIsim = dersIsim;
            DersDonemi = donem;
        }

        internal void OgretimElemaniAta(OgretimElemani hoca)
        {
            OgretimElemani = hoca;
        }

        internal void OgretimElemaniGuncelle(OgretimElemani hoca)
        {
            string json = Serialize(hoca);
            OgretimElemani = Deserialize(json);
        }

        internal void OgrenciEkle(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
        }

        internal void OgrenciSil(Ogrenci ogrenci)
        {
            Ogrenciler.Remove(ogrenci);
        }

        //Iterator interface'inden OgrenciListesini gezmek icin ListIterator nesnesi olusturdum.
        internal Iterator GetIterator()
        {
            return new ListIterator(this.Ogrenciler);
        }

        //Iterator design pattern'i ile tum listeyi gezdim.
        internal void DerseKayitliOgrencileriListele()
        {
            Iterator it = this.GetIterator();
            //OgrenciListesi'nde her eleman icin saginda eleman varsa devam et
            while (it.hasNext() == true)
            {
                string json = Serialize(it.next());
                Console.WriteLine(CreatePrettyJSON(json));
            }
        }

        //Object serialization&deserialization yapildi. Newtonsoft framework'u kullanildi
        // Referans: https://www.newtonsoft.com/json/help/html/SerializingJSON.htm#JsonConvert
        internal string Serialize(Object o)
        {
            return JsonConvert.SerializeObject(o);
        }

        internal OgretimElemani Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<OgretimElemani>(serialized);
        }

        //JSON'u daha temiz yazmak icin kullanildi
        //Referans: https://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_Linq_JToken.htm
        //serialize ettigin objenin Json halini guzellestir (prettyJSON)
        internal string CreatePrettyJSON(string json)
        {
            return JToken.Parse(json).ToString(Formatting.Indented);
        }

        internal void JsonKaydet()
        {
            //serialize et
            string json = Serialize(this);

            //prettyJSON'u yaz. #ornegin: matematik(2016-2017).json
            File.WriteAllText(@"d:\" + this.DersIsim + "(" + this.DersDonemi + ")" + ".json", CreatePrettyJSON(json));
        }
    }
}
