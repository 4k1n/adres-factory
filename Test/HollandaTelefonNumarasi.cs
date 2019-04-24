using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class HollandaTelefonNumarasi : TelefonNumarasi
    {
        public override string UlkeKodu
        {
            get
            {
                return "11";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string TelefonNo
        {
            get
            {
                return base.TelefonNo;
            }

            set
            {
                if (value.Length == 9)
                    base.TelefonNo = value;
            }
        }
    }
}
