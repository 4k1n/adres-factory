using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class HollandaAdres : Adres
    {
        public override string Ulke
        {
            get
            {
                return "Hollanda";
            }
        }

        public override string getTamAdres()
        {
            return base.getTamAdres();
        }
    }
}
