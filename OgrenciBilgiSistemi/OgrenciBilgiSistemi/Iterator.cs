using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal interface Iterator
    {
        bool hasNext();
        Object now();
        Object next();
    }
}
