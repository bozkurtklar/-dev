using System;

namespace Odev
{
    class Program
    {
        public static car Bmw { get; private set; }

        static void Main(string[] args)
        {
            car Araba = new car();
            Araba.Marka = "--------Citroen---------";
            Araba.Model = "C5 Aircross";
            Araba.UretımYılı = "Üretim Tarhi: 2020";


            hdımotor Cıtroen = new hdımotor();
            Cıtroen.Adi = "Hdi Motor";
            Cıtroen.beygir = "92+";
            Cıtroen.YakıtTuketimi = "0/100 Km 5.4 Litre Tüketim";

            Console.WriteLine(Araba.Marka + "\n" + Araba.Model + "\n" + Araba.UretımYılı + "\n" + Cıtroen.YakıtTuketimi + "\n" + Cıtroen.Adi + "\n" + Cıtroen.beygir);

            Console.WriteLine("----------------------------------------------------------------");
              

          



















        }
    }
}
