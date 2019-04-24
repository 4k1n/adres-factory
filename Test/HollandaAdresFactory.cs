using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class HollandaAdresFactory : AddressFactory
    {
        public Adres AdresYarat()
        {
            return new HollandaAdres();
        }

        public TelefonNumarasi TelefonNumarasiYarat()
        {
            return new HollandaTelefonNumarasi();
        }
    }
}
