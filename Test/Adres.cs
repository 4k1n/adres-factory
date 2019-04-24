using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Adres
    {
        public string Sokak { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }

        public abstract string Ulke { get;  }
        public virtual string getTamAdres()
        {
            return Sokak + Sehir + Bolge + Ulke;
        }

    }
}
