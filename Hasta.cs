using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospital
{
    public class Hasta
    {
        public int hastaId { get; set; }
        public string  hastaIsim { get; set; }
        public string hastaSoyisim { get; set; }
        public int hastaYas { get; set; }
        public Doktor hastaDoktor { get; set; }

    }
}
