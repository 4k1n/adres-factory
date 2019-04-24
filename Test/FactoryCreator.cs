using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FactoryCreator
    {
        AddressFactory factory;
        public TelefonNumarasi telefon;
        public Adres adres;

        public FactoryCreator(AddressFactory _addrFactory)
        {
            this.factory = _addrFactory;
            this.telefon = this.factory.TelefonNumarasiYarat();
            this.adres = this.factory.AdresYarat();
        }
    }
}
