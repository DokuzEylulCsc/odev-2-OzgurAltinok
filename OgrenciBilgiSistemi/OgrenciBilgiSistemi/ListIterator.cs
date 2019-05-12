using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    class ListIterator : Iterator
    {
        List<Ogrenci> ogrencis = new List<Ogrenci>();
        int position = 0;

        internal List<Ogrenci> Ogrencis { get => ogrencis; set => ogrencis = value; }
        internal int Position { get => position; set => position = value; }

        internal ListIterator(List<Ogrenci> ogr)
        {
            Ogrencis = ogr;
        }

        //Saginda eleman varsa true, yoksa false;
        public virtual bool hasNext()
        {
            if (Position >= Ogrencis.Count || Ogrencis.ElementAt(Position) == null)
                return false;
            else
            {
                return true;
            }
        }

        //Once bulunan indisteki elemani dondur, sonra indisi arttir
        public virtual Object next()
        {
            return Ogrencis.ElementAt(Position++);
        }

        //O anki indise ait elemani dondur, yoksa null dondur
        public virtual Object now()
        {
            Object returning = null;
            if (Position < Ogrencis.Count)
            {
                returning = Ogrencis.ElementAt(Position);
            }
            return returning;
        }
    }
}
