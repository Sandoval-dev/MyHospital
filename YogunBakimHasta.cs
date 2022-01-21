using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospital
{
    public class YogunBakimHasta:Hasta
    {     
        public string durum { get; set; }

        public YogunBakimHasta(Hasta hasta)
        {
            hastaIsim = hasta.hastaIsim;
            hastaSoyisim = hasta.hastaSoyisim;
            hastaId = hasta.hastaId;
            hastaYas = hasta.hastaYas;
            hastaDoktor = hasta.hastaDoktor;
           

            
            
        }

    }
}
