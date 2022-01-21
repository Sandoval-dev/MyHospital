using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospital
{
    public class Bolum
    {
        public int id { get; set; }
        public string bolumName { get; set; }
        public int doktorSayisi { get; set; }
        public int hastaSayisi { get; set; }
        public int hemsireSayisi { get; set; }
        public int ameliyathaneSayisi { get; set; }
        public Doktor doktorname { get; set; }


        public Bolum(int id,string bolumname,int doktorsayisi,int hastasayisi,int hemsiresayisi,int ameliyathanesayisi,Doktor doktorname)
        {
            this.id = id;
            this.bolumName = bolumname;
            this.doktorSayisi = doktorsayisi;
            this.hastaSayisi = hastasayisi;
            this.hemsireSayisi = hemsiresayisi;
            this.ameliyathaneSayisi = ameliyathanesayisi;
            this.doktorname = doktorname;
        }
    }
}
