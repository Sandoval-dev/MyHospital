using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            DoktorHastaBolum();
            Console.WriteLine("\n");
            DoktorveHastaListele();

            Console.ReadLine();

        }

        private static void DoktorveHastaListele()
        {
            string jsonOkunanData = File.ReadAllText("c:\\MyHospital\\doktorlarim.json");
            List<Doktor> xobject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Doktor>>(jsonOkunanData);
            Console.WriteLine("Doktorlarımızın İsim ve Soyisimleri:");
            for (int i = 0; i < xobject.Count; i++)
            {
                Console.WriteLine(xobject[i]);
            }
        }

        private static void DoktorHastaBolum()
        {
            List<Doktor> doktors = new List<Doktor>();

            Doktor doktor1 = new Doktor();
            doktor1.id = 1;
            doktor1.isim = "Semih";
            doktor1.soyisim = "Önder";
            doktor1.bolum = "Ruh ve Sinir Hastalıkları";
            doktor1.seviye = "Profesör";
            doktors.Add(doktor1);

            Doktor doktor2 = new Doktor();
            doktor2.id = 2;
            doktor2.isim = "Sena";
            doktor2.soyisim = "Kaşıkçı";
            doktor2.bolum = "Fizyoloji";
            doktor2.seviye = "Uzman Doktor";
            doktors.Add(doktor2);

            Doktor doktor3 = new Doktor();
            doktor3.id = 3;
            doktor3.isim = "Batuhan";
            doktor3.soyisim = "Demir";
            doktor3.bolum = "Radyoloji";
            doktor3.seviye = "Doçent";
            doktors.Add(doktor3);

            Doktor doktor4 = new Doktor();
            doktor4.id = 4;
            doktor4.isim = "İkbal";
            doktor4.soyisim = "Delibaş";
            doktor4.bolum = "Kardiyoloji";
            doktor4.seviye = "Ordinaryus";
            doktors.Add(doktor4);

            Doktor doktor5 = new Doktor();
            doktor5.id = 5;
            doktor5.isim = "Emircan";
            doktor5.soyisim = "Namlı";
            doktor5.bolum = "Üroloji";
            doktor5.seviye = "Operatör Doktor";
            doktors.Add(doktor5);

            Doktor doktor6 = new Doktor();
            doktor6.id = 6;
            doktor6.isim = "Muhammed Okan";
            doktor6.soyisim = "Çoban";
            doktor6.bolum = "Göğüs Hastalıkları";
            doktor6.seviye = "Stajyer Doktor";
            doktors.Add(doktor6);

            Doktor doktor7 = new Doktor();
            doktor7.id = 7;
            doktor7.isim = "Ali";
            doktor7.soyisim = "Özkan";
            doktor7.bolum = "Nöroloji";
            doktor7.seviye = "Yardımcı Doçent";
            doktors.Add(doktor7);

            Doktor doktor8 = new Doktor();
            doktor8.id = 8;
            doktor8.isim = "Hüseyin Efe";
            doktor8.soyisim = "Tarman";
            doktor8.bolum = "Kadın Hastalıkları ve Doğum";
            doktor8.seviye = "Uzman Doktor";
            doktors.Add(doktor8);

            Doktor doktor9 = new Doktor();
            doktor9.id = 9;
            doktor9.isim = "Yaren";
            doktor9.soyisim = "Demir";
            doktor9.bolum = "Nefroloji";
            doktor9.seviye = "Profesör";
            doktors.Add(doktor9);

            Doktor doktor10 = new Doktor();
            doktor10.id = 10;
            doktor10.isim = "Ayça";
            doktor10.soyisim = "Çelik";
            doktor10.bolum = "Kulak Burun Boğaz";
            doktor10.seviye = "Doçent";
            doktors.Add(doktor10);
     
            Console.Write(" Doktor Bilgileriniz Json formatında C:\\MyHospital\\doktorlarim.json olarak kaydedilecektir.");

            Console.ReadLine();

            if (Directory.Exists("C:\\MyHospital"))
            {
                //İlgili klasör var ise bir şey yapma
            }
            else
            {
                Directory.CreateDirectory("C:\\MyHospital");
            }

            string JsonDoktorlarım = Newtonsoft.Json.JsonConvert.SerializeObject(doktors);
            File.WriteAllText("C:\\MyHospital\\doktorlarim.json", JsonDoktorlarım);
            Console.WriteLine("Json Export İşlemi tamamlandı ");
            Console.WriteLine("\n");

            List<Hasta> hastalar = new List<Hasta>();

            Hasta hasta1 = new Hasta();
            hasta1.hastaId = 1;
            hasta1.hastaIsim = "Cengiz";
            hasta1.hastaSoyisim = "Kurtoğlu";
            hasta1.hastaYas = 47;
            hasta1.hastaDoktor = doktor7;
            hastalar.Add(hasta1);

            Hasta hasta2 = new Hasta();
            hasta2.hastaId = 2;
            hasta2.hastaIsim = "Beril";
            hasta2.hastaSoyisim = "Keskin";
            hasta2.hastaYas = 21;
            hasta2.hastaDoktor = doktor10;
            hastalar.Add(hasta2);

            Hasta hasta3 = new Hasta();
            hasta3.hastaId = 3;
            hasta3.hastaIsim = "Canan";
            hasta3.hastaSoyisim = "Bukur";
            hasta3.hastaYas = 30;
            hasta3.hastaDoktor = doktor2;
            hastalar.Add(hasta3);

            Hasta hasta4 = new Hasta();
            hasta4.hastaId = 4;
            hasta4.hastaIsim = "Melike";
            hasta4.hastaSoyisim = "Çelikel";
            hasta4.hastaYas = 14;
            hasta4.hastaDoktor = doktor1;
            hastalar.Add(hasta4);

            Hasta hasta5 = new Hasta();
            hasta5.hastaId = 5;
            hasta5.hastaIsim = "Fadıl Tarık";
            hasta5.hastaSoyisim = "Konuş";
            hasta5.hastaYas = 85;
            hasta5.hastaDoktor = doktor3;
            hastalar.Add(hasta5);

            Hasta hasta6 = new Hasta();
            hasta6.hastaId = 6;
            hasta6.hastaIsim = "Mehmet";
            hasta6.hastaSoyisim = "Cumbul";
            hasta6.hastaYas = 65;
            hasta6.hastaDoktor = doktor5;
            hastalar.Add(hasta6);

            Hasta hasta7 = new Hasta();
            hasta7.hastaId = 7;
            hasta7.hastaIsim = "Merve Selin";
            hasta7.hastaSoyisim = "Kıv";
            hasta7.hastaYas = 28;
            hasta7.hastaDoktor = doktor4;
            hastalar.Add(hasta7);

            Hasta hasta8 = new Hasta();
            hasta8.hastaId = 8;
            hasta8.hastaIsim = "Ataberk";
            hasta8.hastaSoyisim = "Özdemir";
            hasta8.hastaYas = 10;
            hasta8.hastaDoktor = doktor9;
            hastalar.Add(hasta8);

            Hasta hasta9 = new Hasta();
            hasta9.hastaId = 9;
            hasta9.hastaIsim = "Muratcan";
            hasta9.hastaSoyisim = "Bobuşoğlu";
            hasta9.hastaYas = 18;
            hasta9.hastaDoktor = doktor6;
            hastalar.Add(hasta9);

            Hasta hasta10 = new Hasta();
            hasta10.hastaId = 10;
            hasta10.hastaIsim = "Berrak";
            hasta10.hastaSoyisim = "Eskimez";
            hasta10.hastaYas = 63;
            hasta10.hastaDoktor = doktor8;
            hastalar.Add(hasta10);



            Console.Write("Hasta Bilgileriniz Json formatınca C:\\MyHospital\\hastalarim.json olarak kaydedilecektir.");
            Console.ReadLine();

            if (Directory.Exists("C:\\MyHospital"))
            {
                //İlgili klasör var ise bir şey yapma
            }
            else
            {
                Directory.CreateDirectory("C:\\MyHospital");
            }

            string JsonHastalarim = Newtonsoft.Json.JsonConvert.SerializeObject(hastalar);
            File.WriteAllText("C:\\MyHospital\\hastalarim.json", JsonHastalarim);
            Console.WriteLine("Json Export İşlemi tamamlandı");
            Console.WriteLine("\n");

            List<YogunBakimHasta> yogunBakimHastalar = new List<YogunBakimHasta>();
            
            YogunBakimHasta yogunBakimHasta1 = new YogunBakimHasta(hasta1);
            yogunBakimHasta1.durum = "Kritik";
            yogunBakimHastalar.Add(yogunBakimHasta1);

            YogunBakimHasta yogunBakimHasta2 = new YogunBakimHasta(hasta6);                        
            yogunBakimHasta2.durum = "Stabil";
            yogunBakimHastalar.Add(yogunBakimHasta2);

            YogunBakimHasta yogunBakimHasta3 = new YogunBakimHasta(hasta8);
            yogunBakimHasta3.durum = "İyi";
            yogunBakimHastalar.Add(yogunBakimHasta3);


            Console.Write("Yoğun Bakım Hasta Bilgileriniz Json formatınca C:\\MyHospital\\yogunbakim.json olarak kaydedilecektir.");
            Console.ReadLine();

            if (Directory.Exists("C:\\MyHospital"))
            {
                //İlgili klasör var ise bir şey yapma
            }
            else
            {
                Directory.CreateDirectory("C:\\MyHospital");
            }

            string JsonYogunBakim = Newtonsoft.Json.JsonConvert.SerializeObject(yogunBakimHastalar);
            File.WriteAllText("C:\\MyHospital\\yogunbakim.json", JsonYogunBakim);
            Console.WriteLine("Json Export İşlemi tamamlandı");
            Console.WriteLine("\n");


            List<Bolum> bolums = new List<Bolum>();
            Bolum bolum1 = new Bolum(1, "Ruh ve Sinir Hastalıkları", 1, 1, 5, 3,doktor1);
            Bolum bolum2 = new Bolum(2, "Fizyoloji", 1, 1, 8, 2,doktor2);
            Bolum bolum3 = new Bolum(3, "Radyoloji", 1, 1, 2, 1,doktor3);
            Bolum bolum4 = new Bolum(4, "Kardiyoloji", 1, 1, 4, 2,doktor4);
            Bolum bolum5 = new Bolum(5, "Üroloji", 1, 1, 5, 2,doktor5);
            Bolum bolum6 = new Bolum(6, "Göğüs Hastalıkları", 1,1,3,1, doktor6);
            Bolum bolum7 = new Bolum(7, "Nöroloji", 1, 1, 2, 1, doktor7);
            Bolum bolum8 = new Bolum(8, "Kadın Hastalıkları ve Doğum", 1, 1, 4, 2, doktor8);
            Bolum bolum9 = new Bolum(9, "Nefroloji", 1, 1, 2, 1, doktor9);
            Bolum bolum10 = new Bolum(10, "Kulak Burun Boğaz", 1, 1, 1, 1, doktor10);
            bolums.Add(bolum1);
            bolums.Add(bolum2);
            bolums.Add(bolum3);
            bolums.Add(bolum4);
            bolums.Add(bolum5);
            bolums.Add(bolum6);
            bolums.Add(bolum7);
            bolums.Add(bolum8);
            bolums.Add(bolum9);
            bolums.Add(bolum10);
            
            Console.Write("Hastane Bölüm Bilgileriniz Json formatınca C:\\MyHospital\\bolumler.json olarak kaydedilecektir.");
            Console.ReadLine();

            if (Directory.Exists("C:\\MyHospital"))
            {
                //İlgili klasör var ise bir şey yapma
            }
            else
            {
                Directory.CreateDirectory("C:\\MyHospital");
            }

            string JsonBolum = Newtonsoft.Json.JsonConvert.SerializeObject(bolums);
            File.WriteAllText("C:\\MyHospital\\bolumler.json", JsonBolum);
            Console.WriteLine("Json Export İşlemi tamamlandı");
        }

       
    }
}
