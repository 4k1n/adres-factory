using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreator creator = new FactoryCreator(new AbdAdresFactory());
            creator.adres.Sehir = "SehirABD";
            creator.adres.PostaKodu = "PostaKoduABD";
            creator.telefon.TelefonNo = "3434343443";
            Console.WriteLine(creator.adres.getTamAdres());
            Console.WriteLine(creator.telefon.TelefonNo);
            Console.ReadLine();
        }
    }
}
