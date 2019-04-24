using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class TelefonNumarasi
    {
        private string telNo;

        public virtual string TelefonNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        public abstract string UlkeKodu { get; set; }

    }
}
