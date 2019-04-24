using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class AbdAdresFactory : AddressFactory
    {
        public Adres AdresYarat()
        {
            return new AbdAdres();
        }

        public TelefonNumarasi TelefonNumarasiYarat()
        {
            return new AbdTelefonNumarasi();
        }
    }
}
