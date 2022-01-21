using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospital
{
    public class Doktor
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string seviye { get; set; }
        public string bolum { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim + " --> " + bolum;
        }
    }
}
